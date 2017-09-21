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
            long? Id_filial = null;

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

            if (Id_filial != null)
            {
                Livro_CaixaBLL = new Livro_CaixaBLL();
                List<Livro_Caixa> lstLc = Livro_CaixaBLL.getLivro_Caixa(p => p.Id_filial == Id_filial & DbFunctions.TruncateTime(p.data) == DbFunctions.TruncateTime(DateTime.Now), true);
                Livro_Caixa Livro_Caixa = null;

                if(lstLc.Count > 0)
                {
                    Livro_Caixa = lstLc.First();
                }

                if (Livro_Caixa != null)
                {
                    Id = Livro_Caixa.Id;
                    txtId.Text = Livro_Caixa.Id.ToString();
                    txtData.Text = Livro_Caixa.data.Value.ToShortDateString();

                    if (Livro_Caixa.saldo_inicial != null)
                    {
                        txtSaldoInicial.Text = Livro_Caixa.saldo_inicial.Value.ToString("N2");
                    }

                    if (Livro_Caixa.saldo_final != null)
                    {
                        txtSaldoFinal.Text = Livro_Caixa.saldo_final.Value.ToString("N2");
                    }

                    if (TipoMovimento == tpMovimentoLivroCaixa.Abertura)
                    {
                        txtSaldoInicial.Enabled = true;
                        txtSaldoInicial.ReadOnly = false;

                        txtSaldoFinal.Enabled = false;
                        txtSaldoFinal.ReadOnly = true;                        
                    }

                    if (TipoMovimento == tpMovimentoLivroCaixa.Encerramento)
                    {
                        txtSaldoInicial.Enabled = false;
                        txtSaldoInicial.ReadOnly = true;

                        decimal sldIni = Convert.ToDecimal(txtSaldoFinal.Text);
                        //decimal sumEnt = Livro_Caixa.item_livro_caixa.Where(p=>p.)

                        txtSaldoFinal.Enabled = true;
                        txtSaldoFinal.ReadOnly = false;
                    }
                }
                else
                {
                    txtData.Text = DateTime.Now.ToShortDateString();
                    
                    if (Id_filial != null)
                    {
                        cbFilial.SelectedValue = Id_filial;
                        cbFilial.Enabled = false;
                        cbFilial.TabStop = false;

                        if (MessageBox.Show("Deseja utilizar como saldo de abertura, \n o saldo de encerramento da movimentação anterior?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //buscar a movimentação anterior
                            Livro_CaixaBLL = new Livro_CaixaBLL();
                            lstLc = Livro_CaixaBLL.getLivro_Caixa(p => p.Id_filial == Id_filial,true,c =>c.data.ToString());

                            if (lstLc.Count > 0)
                            {
                                Livro_Caixa = lstLc.First();
                            }                            
                        }

                        txtSaldoInicial.Enabled = true;
                        txtSaldoInicial.ReadOnly = false;
                        txtSaldoInicial.Focus();
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
                Livro_Caixa.saldo_final = Convert.ToDecimal(txtSaldoFinal.Text);
            }

            Livro_Caixa.data = Convert.ToDateTime(txtData.Text);
            Livro_Caixa.Id_empresa = Program.usuario_logado.Id_empresa;
            if (cbFilial.SelectedValue != null)
            {
                Livro_Caixa.Id_filial = Convert.ToInt64(cbFilial.SelectedValue);
            }
            Livro_Caixa.saldo_inicial = Convert.ToDecimal(txtSaldoInicial.Text);
                                                
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
    }
}
