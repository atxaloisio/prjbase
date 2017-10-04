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
using Utils;
using System.Data.Entity;

namespace prjbase
{
    public partial class frmCadEditContas_Pagar : prjbase.frmBaseCadEdit
    {
        Contas_PagarBLL Contas_PagarBLL;
        ClienteBLL clienteBLL;
        public long? Id_filial = null;
        public frmCadEditContas_Pagar()
        {
            InitializeComponent();
        }

        protected override void LoadToControls()
        {
            base.LoadToControls();

            if (Id != null)
            {
                Contas_PagarBLL = new Contas_PagarBLL();
                Contas_Pagar Contas_Pagar = Contas_PagarBLL.Localizar(Id);

                if (Contas_Pagar != null)
                {
                    txtId.Text = Contas_Pagar.Id.ToString();
                    txtCodCliIntegracao.Text = Contas_Pagar.cliente.codigo_cliente_integracao;
                    txtClienteNome.Text = Contas_Pagar.cliente.razao_social;
                    txtIdCliente.Text = Contas_Pagar.Id_fornecedor.ToString();
                    cbCategoria.SelectedValue = Convert.ToInt64(Contas_Pagar.categoria);
                    txtDocumento.Text = Contas_Pagar.Documento;
                    txtValor.Text = Contas_Pagar.valor.Value.ToString("N2");
                    txtDtVencimento.Text = Contas_Pagar.vencimento.Value.ToShortDateString();
                    txtDtPrevPagamento.Text = Contas_Pagar.previsao.Value.ToShortDateString();
                    if (Contas_Pagar.pagamento != null)
                    {
                        txtDtPagamento.Text = Contas_Pagar.previsao.Value.ToShortDateString();
                    }
                    txtObs.Text = Contas_Pagar.observacao;

                    chkPago.Checked = Contas_Pagar.pago == "S";
                    chkPago.Enabled = false;
                    chkPago.Visible = chkPago.Checked;

                    txtUsuario.Text = Contas_Pagar.usuario_inclusao;
                    txtDtInclusao.Text = Contas_Pagar.inclusao.Value.ToShortDateString();
                    txtIdEmpresa.Text = Contas_Pagar.Id_empresa.ToString();
                    txtIdFilial.Text = Contas_Pagar.Id_filial.ToString();
                    txtObs.Text = Contas_Pagar.observacao;

                    //Habilitando o botão de pagamento
                    if (Contas_Pagar.pago == "N")
                    {
                        btnPagamento.Enabled = true;
                        btnPagamento.Visible = true;
                        btnPagamento.TabStop = true;
                    }
                    else
                    {
                        btnPagamento.Enabled = false;
                        btnPagamento.Visible = false;
                        btnPagamento.TabStop = false;
                    }

                }
            }
            else
            {
                if (Parametro.UtilizaFilial())
                {
                    if (Program.usuario_logado.Id_filial != null)
                    {
                        Id_filial = Program.usuario_logado.Id_filial;
                    }
                    else
                    {
                        frmUtilSelecionarFilial frm = new frmUtilSelecionarFilial();

                        if (frm.ExibeDialogo() == DialogResult.OK)
                        {
                            Id_filial = frm.Id;
                        }

                        frm.Dispose();
                    }

                    txtIdFilial.Text = Id_filial.ToString();
                }
                else
                {
                    txtIdFilial.Text = string.Empty;
                }

                txtIdEmpresa.Text = Program.usuario_logado.Id_empresa.ToString();
            }



        }

        protected override bool salvar(object sender, EventArgs e)
        {
            if (epValidaDados.Validar())
            {
                Contas_Pagar Contas_Pagar = new Contas_Pagar();
                Contas_PagarBLL = new Contas_PagarBLL();

                Contas_PagarBLL.UsuarioLogado = Program.usuario_logado;

                Contas_Pagar = LoadFromControls();

                if (Id != null)
                {
                    Contas_PagarBLL.AlterarContas_Pagar(Contas_Pagar);
                }
                else
                {
                    Contas_PagarBLL.AdicionarContas_Pagar(Contas_Pagar);
                }

                if (Contas_Pagar.Id != 0)
                {
                    Id = Contas_Pagar.Id;
                    txtId.Text = Contas_Pagar.Id.ToString();
                    
                    btnPagamento.Enabled = !chkPago.Checked;
                    btnPagamento.TabStop = !chkPago.Checked;
                    btnPagamento.Visible = !chkPago.Checked;
                }
                txtDocumento.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

        protected virtual Contas_Pagar LoadFromControls()
        {
            Contas_Pagar Contas_Pagar = new Contas_Pagar();

            if (Id != null)
            {
                Contas_Pagar.Id = Convert.ToInt32(txtId.Text);

                Contas_Pagar.inclusao = Convert.ToDateTime(txtDtInclusao.Text);

                Contas_Pagar.usuario_inclusao = txtUsuario.Text;

            }

            if (!string.IsNullOrEmpty(txtIdFilial.Text))
            {
                Contas_Pagar.Id_filial = Convert.ToInt64(txtIdFilial.Text);
            }

            if (!string.IsNullOrEmpty(txtIdEmpresa.Text))
            {
                Contas_Pagar.Id_empresa = Convert.ToInt64(txtIdEmpresa.Text);
            }

            Contas_Pagar.Id_fornecedor = Convert.ToInt64(txtIdCliente.Text);
            Contas_Pagar.categoria = Convert.ToInt32(cbCategoria.SelectedValue);
            Contas_Pagar.Documento = txtDocumento.Text;

            txtDtVencimento.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            Contas_Pagar.vencimento = Convert.ToDateTime(txtDtVencimento.Text);
            txtDtVencimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            txtDtPrevPagamento.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            Contas_Pagar.previsao = Convert.ToDateTime(txtDtPrevPagamento.Text);
            txtDtPrevPagamento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            txtDtPagamento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!string.IsNullOrEmpty(txtDtPagamento.Text))
            {
                txtDtPagamento.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                Contas_Pagar.pagamento = Convert.ToDateTime(txtDtPagamento.Text);
                txtDtPagamento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }

            Contas_Pagar.observacao = txtObs.Text;
            Contas_Pagar.pago = chkPago.Checked ? "S" : "N";

            Contas_Pagar.valor = Convert.ToDecimal(txtValor.Text);


            return Contas_Pagar;
        }

        protected override void Limpar(Control control)

        {
            base.Limpar(control);
            txtDocumento.Focus();
        }

        private void Ctrls_Validating(object sender, CancelEventArgs e)
        {
            if (sender is MaskedTextBox)
            {
                if ((((MaskedTextBox)sender).Name == txtDtVencimento.Name)
                    || (((MaskedTextBox)sender).Name == txtDtPrevPagamento.Name))
                {
                    if (!string.IsNullOrEmpty(((MaskedTextBox)sender).Text))
                    {
                        ((MaskedTextBox)sender).TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                        if (!ValidateUtils.isDate(((MaskedTextBox)sender).Text))
                        {
                            MessageBox.Show("Data inválida.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //((MaskedTextBox)sender).Text = string.Empty;
                            ((MaskedTextBox)sender).Clear();
                            //((MaskedTextBox)sender).TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                            //((MaskedTextBox)sender).Select();
                            e.Cancel = true;
                        }
                        ((MaskedTextBox)sender).TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    }
                }
            }
        }

        //private void Ctrls_Validated(object sender, EventArgs e)
        //{
        //    if (sender is TextBox)
        //    {
        //        epValidaDados.SetError((TextBox)sender, string.Empty);
        //    }
        //    else if (sender is MaskedTextBox)
        //    {
        //        epValidaDados.SetError((MaskedTextBox)sender, string.Empty);
        //    }
        //    else if (sender is ComboBox)
        //    {
        //        epValidaDados.SetError((ComboBox)sender, string.Empty);
        //    }
        //}

        private void frmCadEditContas_Pagar_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            ExecutaPesquisaCliente();
        }

        private void ExecutaPesquisaCliente()
        {
            frmPesquisaFornecedor pesquisa = new frmPesquisaFornecedor();
            if (pesquisa.ExibeDialogo(txtCodCliIntegracao.Text) == DialogResult.OK)
            {
                if (pesquisa.Id != null)
                {
                    clienteBLL = new ClienteBLL();
                    Cliente cliente = clienteBLL.Localizar(pesquisa.Id);
                    if (cliente != null)
                    {
                        txtCodCliIntegracao.Text = cliente.codigo_cliente_integracao;
                        txtClienteNome.Text = cliente.nome_fantasia;
                        txtIdCliente.Text = cliente.Id.ToString();
                        cbCategoria.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Fornecedor não localizado.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCliIntegracao.Text = String.Empty;
                }
            }
            else
            {
                txtCodCliIntegracao.Text = string.Empty;
                txtCodCliIntegracao.Focus();
            }
        }

        private void LoadDadosCliente(long? id = null, string CodInteg = "")
        {
            clienteBLL = new ClienteBLL();
            Cliente cliente = new Cliente();

            if (id != null)
            {
                cliente = clienteBLL.Localizar(id);
            }
            else if (!string.IsNullOrEmpty(CodInteg))
            {
                if (CodInteg.Where(c => char.IsNumber(c)).Count() >= 11)
                {
                    string strCPF, strCNPJ = string.Empty;
                    strCPF = Convert.ToInt64(CodInteg).ToString(@"000\.000\.000\-00");
                    strCNPJ = Convert.ToInt64(CodInteg).ToString(@"00\.000\.000\/0000\-00");
                    cliente = clienteBLL.getCliente(p => p.cnpj_cpf == strCPF || p.cnpj_cpf == strCNPJ).FirstOrDefault();
                }
                else if ((CodInteg.Where(c => char.IsNumber(c)).Count() > 0) && (CodInteg.Where(c => char.IsNumber(c)).Count() < 11))
                {
                    cliente = clienteBLL.getCliente(p => p.codigo_cliente_integracao == CodInteg).FirstOrDefault();
                }
            }

            if (cliente != null)
            {
                txtIdCliente.Text = cliente.Id.ToString();
                txtCodCliIntegracao.Text = cliente.codigo_cliente_integracao;
                txtClienteNome.Text = cliente.nome_fantasia;
                cbCategoria.Focus();
            }
        }

        private void txtCodCliIntegracao_TextChanged(object sender, EventArgs e)
        {
            txtClienteNome.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
        }

        private void txtCodCliIntegracao_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCliIntegracao.Text))
            {
                if (txtCodCliIntegracao.Text.Where(c => char.IsNumber(c)).Count() > 0)
                {
                    LoadDadosCliente(null, txtCodCliIntegracao.Text);
                    if (string.IsNullOrEmpty(txtClienteNome.Text))
                    {
                        ExecutaPesquisaCliente();
                    }
                }
                else
                {
                    ExecutaPesquisaCliente();
                }
            }
        }

        private void Ctrls_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                epValidaDados.SetError((TextBox)sender, string.Empty);
                if (((TextBox)sender).Name == "txtCodCliIntegracao")
                {
                    epValidaDados.SetError(txtClienteNome, string.Empty);
                    //epValidaDados.SetError(txtDtEmissao, string.Empty);
                }
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

        protected override void SetupControls()
        {
            base.SetupControls();
            SetupCategoria();
        }

        protected virtual void SetupCategoria()
        {
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            cbCategoria.DataSource = categoriaBLL.getCategoria(c => c.conta_despesa == "S" & c.descricao != "&lt;Disponível&gt;");
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "descricao";
            cbCategoria.SelectedIndex = -1;
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

        private void txt_Enter(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox)
            {
                ((MaskedTextBox)sender).Select(0, 0);
            }
            else if (sender is TextBox)
            {
                ((TextBox)sender).Select(0, 0);
            }

        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            processaPagamento();

        }

        private void processaPagamento()
        {
            decimal saldo = 0;
            decimal saldo_inicial = 0;
            decimal entradas = 0;
            decimal saidas = 0;

            try
            {
                //Vamos realizar o processo de pagamento do contas a pagar.
                //Primeiro vamos ver se existe saldo no caixa para o pagamento da conta a pagar
                if (!chkPago.Checked)
                {
                    Livro_CaixaBLL Livro_CaixaBLL = new Livro_CaixaBLL();
                    List<Livro_Caixa> lstLc = null;
                    if (Id_filial != null)
                    {
                        lstLc = Livro_CaixaBLL.getLivro_Caixa(p => p.Id_filial == Id_filial & DbFunctions.TruncateTime(p.data) == DbFunctions.TruncateTime(DateTime.Now), true);
                    }
                    else
                    {
                        lstLc = Livro_CaixaBLL.getLivro_Caixa(p => DbFunctions.TruncateTime(p.data) == DbFunctions.TruncateTime(DateTime.Now), true);
                    }


                    Livro_Caixa Livro_Caixa = null;

                    if (lstLc.Count > 0)
                    {
                        Livro_Caixa = lstLc.First();
                    }
                    else
                    {
                        throw new Exception("Não existe movimentação aberta para realizar o pagamento.");
                    }

                    if (Livro_Caixa != null)
                    {
                        if (Livro_Caixa.status != "F")
                        {
                            entradas = Convert.ToDecimal(Livro_Caixa.item_livro_caixa.Where(p => p.tipo == "E").Sum(c => c.valor));
                            saidas = Convert.ToDecimal(Livro_Caixa.item_livro_caixa.Where(p => p.tipo == "S").Sum(c => c.valor));
                            saldo_inicial = Convert.ToDecimal(Livro_Caixa.saldo_inicial);

                            //saldo obtido vamos comparar verificar se é suficinete para pagar 
                            saldo = ((saldo_inicial + entradas) - (-1 * saidas));

                            decimal valor = Convert.ToDecimal(txtValor.Text);

                            if (valor <= saldo)
                            {
                                //Vamos registrar um item no livro de caixa e atualizar o conta a pagar
                                //com a data de pagamento e o flag de pago.                            
                                Item_Livro_CaixaBLL Item_LivroBLL = new Item_Livro_CaixaBLL();
                                try
                                {
                                    Item_LivroBLL.UsuarioLogado = Program.usuario_logado;

                                    Item_Livro_Caixa Item_Livro = new Item_Livro_Caixa();

                                    Item_Livro.Id_contaspagar = Convert.ToInt64(Id);
                                    Item_Livro.Id_empresa = Program.usuario_logado.Id_empresa;

                                    if (Id_filial != null)
                                    {
                                        Item_Livro.Id_filial = Id_filial;
                                    }

                                    Item_Livro.inclusao = DateTime.Now;
                                    Item_Livro.tipo = "S";
                                    Item_Livro.descricao = "Contas a Pagar Documento: " + txtDocumento.Text;
                                    Item_Livro.usuario_inclusao = Program.usuario_logado.nome;
                                    Item_Livro.valor = valor;
                                    Item_Livro.Id_livro = Livro_Caixa.Id;

                                    Item_LivroBLL.AdicionarItem_Livro_Caixa(Item_Livro);

                                    if (Item_Livro.Id > 0)
                                    {
                                        Contas_PagarBLL = new Contas_PagarBLL();
                                        Contas_PagarBLL.UsuarioLogado = Program.usuario_logado;
                                        Contas_Pagar cp = Contas_PagarBLL.Localizar(Id);

                                        cp.pago = "S";
                                        cp.pagamento = DateTime.Now;
                                        cp.usuario_alteracao = Program.usuario_logado.nome;
                                        cp.alteracao = DateTime.Now;

                                        Contas_PagarBLL.AlterarContas_Pagar(cp);

                                        LoadToControls();

                                        chkPago.Checked = true;
                                        chkPago.Enabled = false;
                                        chkPago.Visible = true;
                                        btnPagamento.Enabled = false;

                                        btnIncluir.Top = 40;
                                        btnIncluir.Visible = true;
                                        MessageBox.Show("Processo de Pagamento realizado com sucesso.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }
                                catch (Exception)
                                {
                                    throw;
                                }
                            }
                            else
                            {
                                throw new Exception("saldo em caixa menor que o valor para pagamento.");
                            }

                        }
                        else
                        {
                            throw new Exception("Não será possivel realizar o pagamento pois a movimentação diária está Fechada");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string mensagem = TrataException.getAllMessage(ex);
                MessageBox.Show(mensagem, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }            
        }
    }
}
