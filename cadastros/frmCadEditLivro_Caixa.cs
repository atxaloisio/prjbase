using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;
using System.Linq;
using System.Data.Entity;
using Utils;

namespace prjbase
{
    public partial class frmCadEditLivro_Caixa : prjbase.frmBaseCadEdit
    {
        Livro_CaixaBLL Livro_CaixaBLL;
        FilialBLL filialBLL;
        public tpMovimentoLivroCaixa TipoMovimento;
        public frmCadEditLivro_Caixa()
        {
            InitializeComponent();
        }

        protected override void LoadToControls()
        {
            base.LoadToControls();

            if (Parametro.UtilizaFilial())
            {
                LoadToControlsFilial();
            }
            else
            {
                LoadToControlsEmpresa();
            }

        }

        private void LoadToControlsEmpresa()
        {
            Livro_CaixaBLL = new Livro_CaixaBLL();
            List<Livro_Caixa> lstLc = Livro_CaixaBLL.getLivro_Caixa(p => DbFunctions.TruncateTime(p.data) == DbFunctions.TruncateTime(DateTime.Now), true);
            Livro_Caixa Livro_Caixa = null;

            if (lstLc.Count > 0)
            {
                Livro_Caixa = lstLc.First();
            }

            if (Livro_Caixa != null)
            {
                Id = Livro_Caixa.Id;
                txtId.Text = Livro_Caixa.Id.ToString();
                txtData.Text = Livro_Caixa.data.Value.ToShortDateString();

                txtUsuarioInc.Text = Livro_Caixa.usuario_inclusao;
                txtDtInc.Text = Livro_Caixa.inclusao.Value.ToShortDateString();
                txtStatus.Text = Livro_Caixa.status;

                if (Livro_Caixa.saldo_inicial != null)
                {
                    txtSaldoInicial.Text = Livro_Caixa.saldo_inicial.Value.ToString("N2");
                }

                if (Livro_Caixa.saldo_final != null)
                {
                    txtSaldoFinal.Text = Livro_Caixa.saldo_final.Value.ToString("N2");
                }

                lblFilial.Visible = false;
                cbFilial.Visible = false;
                cbFilial.Enabled = false;
                cbFilial.TabStop = false;

                if (TipoMovimento == tpMovimentoLivroCaixa.Abertura)
                {
                    if (Livro_Caixa.status == "F")
                    {
                        if (Program.usuario_logado.perfil.administrativo == "S")
                        {
                            if (MessageBox.Show("Movimentação encerrada para a data: " + Livro_Caixa.data.Value.ToShortDateString() + "\n Deseja reabir a movimentação?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                txtSaldoFinal.Text = string.Empty;
                            }
                            else
                            {
                                txtSaldoInicial.Enabled = false;
                                txtSaldoInicial.ReadOnly = true;
                                btnSalvar.Enabled = false;
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Movimentação encerrada para a data: " + Livro_Caixa.data.Value.ToShortDateString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtSaldoInicial.Enabled = false;
                            txtSaldoInicial.ReadOnly = true;
                            btnSalvar.Enabled = false;
                        }
                        
                    }
                    else
                    {
                        txtSaldoInicial.Enabled = true;
                        txtSaldoInicial.ReadOnly = false;
                    }
                    
                    txtSaldoFinal.Enabled = false;
                    txtSaldoFinal.ReadOnly = true;
                }

                if (TipoMovimento == tpMovimentoLivroCaixa.Encerramento)
                {
                    txtSaldoInicial.Enabled = false;
                    txtSaldoInicial.ReadOnly = true;
                    //Saldo inicial
                    decimal sldIni = Convert.ToDecimal(txtSaldoInicial.Text);
                    //Soma das entradas do dia
                    decimal sumEnt = Convert.ToDecimal(Livro_Caixa.item_livro_caixa.Where(p => p.tipo == "E").Sum(c => c.valor));
                    //Soma das saidas do dia
                    decimal sumSaid = Convert.ToDecimal(Livro_Caixa.item_livro_caixa.Where(p => p.tipo == "S").Sum(c => c.valor));

                    decimal total = ((sldIni + sumEnt) - (-1 * sumSaid));

                    txtSaldoFinal.Text = total.ToString("N2");

                    txtSaldoFinal.Enabled = true;
                    txtSaldoFinal.ReadOnly = false;
                }
            }
            else
            {
                if (TipoMovimento == tpMovimentoLivroCaixa.Abertura)
                {
                    txtData.Text = DateTime.Now.ToShortDateString();

                    lblFilial.Visible = false;
                    cbFilial.Visible = false;
                    cbFilial.Enabled = false;
                    cbFilial.TabStop = false;

                    long Id_empresa = Convert.ToInt64(Program.usuario_logado.Id_empresa);

                    if (MessageBox.Show("Deseja utilizar como saldo de abertura, \n o saldo de encerramento da movimentação anterior?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //buscar a movimentação anterior
                        Livro_CaixaBLL = new Livro_CaixaBLL();
                        lstLc = Livro_CaixaBLL.getLivro_Caixa(p => p.Id_empresa == Id_empresa, true, c => c.data.ToString());

                        if (lstLc.Count > 0)
                        {                            
                            Livro_Caixa = lstLc.First();
                            //Verifica se a movimentação do dia anterior foi fechada se não foi fecha.
                            if (Livro_Caixa.status == "A")
                            {
                                //Saldo inicial
                                decimal sldIni = Convert.ToDecimal(Livro_Caixa.saldo_inicial);
                                //Soma das entradas do dia
                                decimal sumEnt = Convert.ToDecimal(Livro_Caixa.item_livro_caixa.Where(p => p.tipo == "E").Sum(c => c.valor));
                                //Soma das saidas do dia
                                decimal sumSaid = Convert.ToDecimal(Livro_Caixa.item_livro_caixa.Where(p => p.tipo == "S").Sum(c => c.valor));

                                decimal total = ((sldIni + sumEnt) - (-1 * sumSaid));
                                Livro_Caixa.status = "F";
                                Livro_Caixa.saldo_final = total;
                                Livro_CaixaBLL.AlterarLivro_Caixa(Livro_Caixa);
                            }

                            if (Livro_Caixa.saldo_final != null)
                            {
                                txtSaldoInicial.Text = Livro_Caixa.saldo_final.Value.ToString("N2");
                            }
                            
                        }
                    }

                    txtSaldoInicial.Enabled = true;
                    txtSaldoInicial.ReadOnly = false;
                    txtSaldoInicial.Focus();

                }
                else if (TipoMovimento == tpMovimentoLivroCaixa.Encerramento)
                {
                    MessageBox.Show("Não existe movimentação aberta para encerramento.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
        }

        private void LoadToControlsFilial()
        {
            long? Id_filial = null;

            if (Id_filial == null)
            {
                if (Program.usuario_logado.Id_filial == null)
                {
                    frmUtilSelecionarFilial frm = new frmUtilSelecionarFilial();

                    if (frm.ExibeDialogo() == DialogResult.OK)
                    {
                        Id_filial = frm.Id;
                    }

                    frm.Dispose();
                }
                else
                {
                    Id_filial = Program.usuario_logado.Id_filial;
                }
            }

            if (Id_filial != null)
            {
                Livro_CaixaBLL = new Livro_CaixaBLL();
                List<Livro_Caixa> lstLc = Livro_CaixaBLL.getLivro_Caixa(p => p.Id_filial == Id_filial & DbFunctions.TruncateTime(p.data) == DbFunctions.TruncateTime(DateTime.Now), true);
                Livro_Caixa Livro_Caixa = null;

                if (lstLc.Count > 0)
                {
                    Livro_Caixa = lstLc.First();
                }

                if (Livro_Caixa != null)
                {
                    Id = Livro_Caixa.Id;
                    txtId.Text = Livro_Caixa.Id.ToString();
                    txtData.Text = Livro_Caixa.data.Value.ToShortDateString();

                    txtUsuarioInc.Text = Livro_Caixa.usuario_inclusao;
                    txtDtInc.Text = Livro_Caixa.inclusao.Value.ToShortDateString();

                    if (Livro_Caixa.saldo_inicial != null)
                    {
                        txtSaldoInicial.Text = Livro_Caixa.saldo_inicial.Value.ToString("N2");
                    }

                    if (Livro_Caixa.saldo_final != null)
                    {
                        txtSaldoFinal.Text = Livro_Caixa.saldo_final.Value.ToString("N2");
                    }

                    lblFilial.Visible = true;
                    cbFilial.Visible = true;
                    cbFilial.SelectedValue = Id_filial;
                    cbFilial.Enabled = false;
                    cbFilial.TabStop = false;

                    if (TipoMovimento == tpMovimentoLivroCaixa.Abertura)
                    {
                        if (Livro_Caixa.status == "F")
                        {
                            if (Program.usuario_logado.perfil.administrativo == "S")
                            {
                                if (MessageBox.Show("Movimentação encerrada para a data: " + Livro_Caixa.data.Value.ToShortDateString() + "\n Deseja reabir a movimentação?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                                {
                                    txtSaldoFinal.Text = string.Empty;
                                    txtSaldoInicial.Enabled = true;
                                    txtSaldoInicial.ReadOnly = false;
                                    btnSalvar.Enabled = true;
                                }
                                else
                                {
                                    txtSaldoInicial.Enabled = false;
                                    txtSaldoInicial.ReadOnly = true;
                                    btnSalvar.Enabled = false;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Movimentação encerrada para a data: " + Livro_Caixa.data.Value.ToShortDateString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtSaldoInicial.Enabled = false;
                                txtSaldoInicial.ReadOnly = true;
                                btnSalvar.Enabled = false;
                            }
                        }
                        else
                        {
                            txtSaldoInicial.Enabled = true;
                            txtSaldoInicial.ReadOnly = false;
                        }

                        txtSaldoFinal.Enabled = false;
                        txtSaldoFinal.ReadOnly = true;
                    }

                    if (TipoMovimento == tpMovimentoLivroCaixa.Encerramento)
                    {
                        txtSaldoInicial.Enabled = false;
                        txtSaldoInicial.ReadOnly = true;
                        //Saldo inicial
                        decimal sldIni = Convert.ToDecimal(txtSaldoInicial.Text);
                        //Soma das entradas do dia
                        decimal sumEnt = Convert.ToDecimal(Livro_Caixa.item_livro_caixa.Where(p => p.tipo == "E").Sum(c => c.valor));
                        //Soma das saidas do dia
                        decimal sumSaid = Convert.ToDecimal(Livro_Caixa.item_livro_caixa.Where(p => p.tipo == "S").Sum(c => c.valor));

                        decimal total = ((sldIni + sumEnt) - (-1 * sumSaid));

                        txtSaldoFinal.Text = total.ToString("N2");

                        txtSaldoFinal.Enabled = true;
                        txtSaldoFinal.ReadOnly = false;
                    }
                }
                else
                {
                    if (TipoMovimento == tpMovimentoLivroCaixa.Abertura)
                    {
                        txtData.Text = DateTime.Now.ToShortDateString();

                        if (Id_filial != null)
                        {
                            lblFilial.Visible = true;
                            cbFilial.Visible = true;
                            cbFilial.SelectedValue = Id_filial;
                            cbFilial.Enabled = false;
                            cbFilial.TabStop = false;

                            if (MessageBox.Show("Deseja utilizar como saldo de abertura, \n o saldo de encerramento da movimentação anterior?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //buscar a movimentação anterior
                                Livro_CaixaBLL = new Livro_CaixaBLL();
                                lstLc = Livro_CaixaBLL.getLivro_Caixa(p => p.Id_filial == Id_filial, true, c => c.data.ToString());

                                if (lstLc.Count > 0)
                                {
                                    Livro_Caixa = lstLc.First();
                                    //Verifica se a movimentação do dia anterior foi fechada se não foi fecha.
                                    if (Livro_Caixa.status == "A")
                                    {
                                        //Saldo inicial
                                        decimal sldIni = Convert.ToDecimal(Livro_Caixa.saldo_inicial);
                                        //Soma das entradas do dia
                                        decimal sumEnt = Convert.ToDecimal(Livro_Caixa.item_livro_caixa.Where(p => p.tipo == "E").Sum(c => c.valor));
                                        //Soma das saidas do dia
                                        decimal sumSaid = Convert.ToDecimal(Livro_Caixa.item_livro_caixa.Where(p => p.tipo == "S").Sum(c => c.valor));

                                        decimal total = ((sldIni + sumEnt) - (-1 * sumSaid));
                                        Livro_Caixa.status = "F";
                                        Livro_Caixa.saldo_final = total;
                                        Livro_CaixaBLL.AlterarLivro_Caixa(Livro_Caixa);
                                    }

                                    if (Livro_Caixa.saldo_final != null)
                                    {
                                        txtSaldoInicial.Text = Livro_Caixa.saldo_final.Value.ToString("N2");
                                    }                                    
                                }
                            }

                            txtSaldoInicial.Enabled = true;
                            txtSaldoInicial.ReadOnly = false;
                            txtSaldoInicial.Focus();
                        }
                    }
                    else if (TipoMovimento == tpMovimentoLivroCaixa.Encerramento)
                    {
                        MessageBox.Show("Não existe movimentação aberta para encerramento.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }
            }
        }

        protected override void SetupControls()
        {
            base.SetupControls();
            setupcbFilial();
        }

        private void setupcbFilial()
        {
            filialBLL = new FilialBLL();
            List<Filial> lstFilial = filialBLL.getFilial();
            cbFilial.DataSource = lstFilial;
            cbFilial.ValueMember = "Id";
            cbFilial.DisplayMember = "nome_fantasia";
            cbFilial.SelectedIndex = -1;
            if (lstFilial.Count <= 0)
            {
                cbFilial.Enabled = false;
            }
        }

        protected override bool salvar(object sender, EventArgs e)
        {

            if (TipoMovimento == tpMovimentoLivroCaixa.Abertura)
            {
                epValidaDados.SetObrigatorio(txtSaldoFinal, false);                
            }

            if (epValidaDados.Validar())
            {
                Livro_Caixa Livro_Caixa = new Livro_Caixa();
                Livro_CaixaBLL = new Livro_CaixaBLL();

                Livro_CaixaBLL.UsuarioLogado = Program.usuario_logado;

                Livro_Caixa = LoadFromControls();
                
                if (Id != null)
                {                    
                    Livro_CaixaBLL.AlterarLivro_Caixa(Livro_Caixa);
                }
                else
                {
                    Livro_CaixaBLL.AdicionarLivro_Caixa(Livro_Caixa);
                }

                if (Livro_Caixa.Id != 0)
                {
                    Id = Livro_Caixa.Id;
                    txtId.Text = Livro_Caixa.Id.ToString();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        protected virtual Livro_Caixa LoadFromControls()
        {
            Livro_Caixa Livro_Caixa = new Livro_Caixa();

            if (Id != null)
            {
                Livro_Caixa.Id = Convert.ToInt32(txtId.Text);
                if (!string.IsNullOrEmpty(txtSaldoFinal.Text))
                {
                    Livro_Caixa.saldo_final = Convert.ToDecimal(txtSaldoFinal.Text);
                }
                
                Livro_Caixa.inclusao = Convert.ToDateTime(txtDtInc.Text);
                Livro_Caixa.usuario_inclusao = txtUsuarioInc.Text;
            }

            txtData.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            Livro_Caixa.data = Convert.ToDateTime(txtData.Text);

            Livro_Caixa.Id_empresa = Program.usuario_logado.Id_empresa;
            if (cbFilial.SelectedValue != null)
            {
                Livro_Caixa.Id_filial = Convert.ToInt64(cbFilial.SelectedValue);
            }
            Livro_Caixa.saldo_inicial = Convert.ToDecimal(txtSaldoInicial.Text);

            if (this.TipoMovimento == tpMovimentoLivroCaixa.Abertura)
            {
                if (!string.IsNullOrEmpty(txtStatus.Text))
                {
                    Livro_Caixa.status = txtStatus.Text;
                }
                else
                {
                    Livro_Caixa.status = "A";
                }
            }
            else if (this.TipoMovimento == tpMovimentoLivroCaixa.Encerramento)
            {
                Livro_Caixa.status = "F";
            }
                
            return Livro_Caixa;
        }

        protected override void Limpar(Control control)

        {
            base.Limpar(control);
        }

        private void Ctrls_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                epValidaDados.SetError((TextBox)sender, string.Empty);
            }
            else if (sender is MaskedTextBox)
            {
                epValidaDados.SetError((MaskedTextBox)sender, string.Empty);
            }
            else if (sender is ComboBox)
            {
                epValidaDados.SetError((ComboBox)sender, string.Empty);
            }
        }

        private void frmCadEditLivro_Caixa_Activated(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void frmCadEditLivro_Caixa_Resize(object sender, EventArgs e)
        {
            pnlJanela.Dock = DockStyle.None;
            pnlJanela.Left = (this.Width / 2) - (pnlJanela.Width / 2);
            pnlJanela.Top = (this.Height / 2) - (pnlJanela.Height / 2);

            if (pnlJanela.Top <= 0)
            {
                pnlJanela.Top = 5;
            }

            if (pnlJanela.Left <= 0)
            {
                pnlJanela.Left = 5;
                pnlJanela.Top = 5;
                pnlJanela.Dock = DockStyle.Left;
                pnlPrincipal.Width = pnlJanela.Width;
            }
            else
            {
                pnlJanela.Left = pnlJanela.Left - (pnlBotoes.Width / 2);
            }
            if (!isDialogo)
            {

            }
        }

        private void pnlJanela_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaAcessoFuncao(Operacao.Salvar))
                {
                    if (salvar(sender, e))
                    {
                        MessageBox.Show(Text + " salvo com sucesso.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ImprimirRegistro(Id);
                    }
                }
            }
            catch (Exception ex)
            {
                string mensagem = TrataException.getAllMessage(ex);
                MessageBox.Show(mensagem, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) & (e.KeyChar != 8) & (!e.KeyChar.Equals(',')))
            {
                e.Handled = true;
            }
        }

        private void OnlyNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                ((TextBox)sender).Text = Convert.ToDecimal(((TextBox)sender).Text).ToString("N2");
            }
        }
    }
}
