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
        public frmCadEditLivro_Caixa()
        {
            InitializeComponent();
        }

        protected override void LoadToControls()
        {
            base.LoadToControls();

            if (Id != null)
            {
                Livro_CaixaBLL = new Livro_CaixaBLL();
                Livro_Caixa Livro_Caixa = Livro_CaixaBLL.Localizar(Id);

                if (Livro_Caixa != null)
                {
                    txtId.Text = Livro_Caixa.Id.ToString();
                    //txtNumero.Text = Livro_Caixa.numero;
                    //chkInativo.Checked = Livro_Caixa.inativo == "S";
                    txtNumero.Focus();
                }
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
                txtNumero.Focus();
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
            }

            //Livro_Caixa.numero = txtNumero.Text;
            
            Livro_CaixaBLL = new Livro_CaixaBLL();

            List<Livro_Caixa> lstLivro_Caixa = Livro_CaixaBLL.getLivro_Caixa(p => DbFunctions.TruncateTime(p.data) == DbFunctions.TruncateTime(Livro_Caixa.data));

            if (lstLivro_Caixa.Count() > 0)
            {
                Livro_Caixa = lstLivro_Caixa.First();
                Id = Livro_Caixa.Id;
                txtId.Text = Livro_Caixa.Id.ToString();
            }

            

            return Livro_Caixa;
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
    }
}
