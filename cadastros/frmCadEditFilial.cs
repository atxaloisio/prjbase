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

namespace prjbase
{
    public partial class frmCadEditFilial : prjbase.frmBaseCadEdit
    {
        FilialBLL FilialBLL;
        public virtual long Id_Empresa { get; set; }
        public frmCadEditFilial()
        {
            InitializeComponent();
            isDialogo = true;
        }

        protected override void LoadToControls()
        {
            base.LoadToControls();

            if (Id != null)
            {
                FilialBLL = new FilialBLL();
                Filial Filial = FilialBLL.Localizar(Id);

                if (Filial != null)
                {
                    txtId.Text = Filial.Id.ToString();                    
                }
            }

        }

        protected override bool salvar(object sender, EventArgs e)
        {
            if (epValidaDados.Validar())
            {
                Filial Filial = new Filial();
                FilialBLL = new FilialBLL();

                FilialBLL.UsuarioLogado = Program.usuario_logado;

                Filial = LoadFromControls();

                if (Id != null)
                {                    
                    FilialBLL.AlterarFilial(Filial);
                }
                else
                {                    
                    FilialBLL.AdicionarFilial(Filial);
                }

                if (Filial.Id != 0)
                {
                    Id = Filial.Id;
                    txtId.Text = Filial.Id.ToString();
                }
                txtNumero.Focus();
                return true;                
            }
            else
            {
                return false;
            }
        }

        protected virtual Filial LoadFromControls()
        {
            Filial filial = new Filial();

            if (Id != null)
            {
                filial.Id = Convert.ToInt64(txtId.Text);
            }

            filial.Id_empresa = Id_Empresa;
            
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                filial.codigo_filial = Convert.ToInt64(txtCodigo.Text);
            }

            filial.cnpj = txtCNPJ.Text;
            filial.codigo_filial_integracao = txtCodInt.Text;
            filial.razao_social = txtRazaoSocial.Text;
            filial.nome_fantasia = txtNomeFantasia.Text;
            filial.telefone1_ddd = txtDDD.Text;
            filial.telefone1_numero = txtTelefone.Text;
            filial.endereco = txtEndereco.Text;
            filial.endereco_numero = txtNumero.Text;
            filial.bairro = txtBairro.Text;
            filial.complemento = txtComplemento.Text;
            if (cbUF.SelectedValue != null)
            {
                filial.estado = cbUF.SelectedValue.ToString();
            }
            if (cbCidade.SelectedValue != null)
            {
                filial.cidade = cbCidade.SelectedValue.ToString();
            }
            filial.cep = txtCEP.Text;
            filial.telefone2_ddd = txtDDD2.Text;
            filial.telefone2_numero = txtTelefone2.Text;
            filial.fax_ddd = txtDDDFax.Text;
            filial.fax_numero = txtFax.Text;
            filial.email = txtEmail.Text;
            filial.website = txtWebSite.Text;
            filial.inscricao_estadual = txtInscricaoEstadual.Text;
            filial.inscricao_municipal = txtInscricaoMunicipal.Text;
            filial.inscricao_suframa = txtInscricaoSuframa.Text;
            filial.cnae = txtCodCnae.Text;

            if (cbRegimeTributario.SelectedValue != null)
            {
                filial.regime_tributario = Convert.ToSByte(cbRegimeTributario.SelectedValue);
            }

            if (!string.IsNullOrEmpty(txtDtSimplNac.Text))
            {
                filial.data_adesao_sn = Convert.ToDateTime(txtDtSimplNac.Text);
            }

            return filial;            
        }

        protected override void Limpar(Control control)

        {
            base.Limpar(control);
            txtNumero.Focus();
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

        private void frmCadEditFilial_Activated(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void frmCadEditFilial_Load(object sender, EventArgs e)
        {
            
        }
    }
}
