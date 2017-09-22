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
    public partial class frmCadEditItem_Livro_Caixa : prjbase.frmBaseCadEdit
    {
        Item_Livro_CaixaBLL Item_Livro_CaixaBLL;
        public long? Id_Livro_Caixa;
        public frmCadEditItem_Livro_Caixa()
        {
            InitializeComponent();
        }

        protected override void LoadToControls()
        {
            base.LoadToControls();

            if (Id != null)
            {
                Item_Livro_CaixaBLL = new Item_Livro_CaixaBLL();
                Item_Livro_Caixa Item_Livro_Caixa = Item_Livro_CaixaBLL.Localizar(Id);

                if (Item_Livro_Caixa != null)
                {
                    txtId.Text = Item_Livro_Caixa.Id.ToString();
                    Id_Livro_Caixa = Item_Livro_Caixa.Id_livro;
                    txtId_Livro_Caixa.Text = Item_Livro_Caixa.Id_livro.ToString();
                    if (Item_Livro_Caixa.tipo == "E")
                    {
                        cbTipo.SelectedValue = 1;
                    }
                    else if (Item_Livro_Caixa.tipo == "S")
                    {
                        cbTipo.SelectedValue = 2;
                    }
                    txtDescricao.Text = Item_Livro_Caixa.descricao;
                    txtDocumento.Text = Item_Livro_Caixa.documento;
                    txtUsuario_Inclusao.Text = Item_Livro_Caixa.usuario_inclusao;
                    txtInclusao.Text = Item_Livro_Caixa.inclusao.Value.ToShortDateString();
                    txtValor.Text = Item_Livro_Caixa.valor.Value.ToString("N2");
                    
                    txtDocumento.Focus();
                }
            }

        }

        protected override void SetupControls()
        {
            base.SetupControls();

            IList<itemEnumList> lstTipo = new List<itemEnumList>();
            lstTipo.Add(new itemEnumList { chave = 1, descricao = "Entrada" });
            lstTipo.Add(new itemEnumList { chave = 2, descricao = "Saida" });
            

            cbTipo.DataSource = lstTipo;
            cbTipo.ValueMember = "chave";
            cbTipo.DisplayMember = "descricao";
            cbTipo.SelectedIndex = -1;
        }

        protected override bool salvar(object sender, EventArgs e)
        {
            if (epValidaDados.Validar())
            {
                Item_Livro_Caixa Item_Livro_Caixa = new Item_Livro_Caixa();
                Item_Livro_CaixaBLL = new Item_Livro_CaixaBLL();

                Item_Livro_CaixaBLL.UsuarioLogado = Program.usuario_logado;

                Item_Livro_Caixa = LoadFromControls();

                if (Id != null)
                {                    
                    Item_Livro_CaixaBLL.AlterarItem_Livro_Caixa(Item_Livro_Caixa);
                }
                else
                {                    
                    Item_Livro_CaixaBLL.AdicionarItem_Livro_Caixa(Item_Livro_Caixa);
                }

                if (Item_Livro_Caixa.Id != 0)
                {
                    Id = Item_Livro_Caixa.Id;
                    txtId.Text = Item_Livro_Caixa.Id.ToString();
                }
                txtDescricao.Focus();
                return true;                
            }
            else
            {
                return false;
            }
        }

        protected virtual Item_Livro_Caixa LoadFromControls()
        {
            Item_Livro_Caixa Item_Livro_Caixa = new Item_Livro_Caixa();

            if (Id != null)
            {
                Item_Livro_Caixa.Id = Convert.ToInt32(txtId.Text);
            }

            //Item_Livro_Caixa.numero = txtNumero.Text;
            
            Item_Livro_CaixaBLL = new Item_Livro_CaixaBLL();

            //List<Item_Livro_Caixa> lstItem_Livro_Caixa = Item_Livro_CaixaBLL.getItem_Livro_Caixa(p => p.numero == Item_Livro_Caixa.numero);

            //if (lstItem_Livro_Caixa.Count() > 0)
            //{
            //    Item_Livro_Caixa = lstItem_Livro_Caixa.First();
            //    Id = Item_Livro_Caixa.Id;
            //    txtId.Text = Item_Livro_Caixa.Id.ToString();
            //}

            //Item_Livro_Caixa.inativo = chkInativo.Checked ? "S" : "N";

            return Item_Livro_Caixa;
        }

        protected override void Limpar(Control control)

        {
            base.Limpar(control);
            txtDescricao.Focus();
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

        private void frmCadEditItem_Livro_Caixa_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmCadEditItem_Livro_Caixa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
