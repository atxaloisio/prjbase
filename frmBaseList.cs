using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjbase
{
    public partial class frmBaseList : prjbase.frmBase
    {
        protected frmBase frmInstancia;
        public frmBaseList()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        protected virtual void InstanciarFormulario()
        {
            
        }

        public virtual void ConfigurarForm(Form pFormParent)
        {
            WindowState = FormWindowState.Maximized;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            
            MdiParent = pFormParent;
        }

        protected virtual void btnIncluir_Click(object sender, EventArgs e)
        {
            String TituloTela;
            if (frmInstancia == null)
            {
                this.InstanciarFormulario();
            }
            TituloTela = frmInstancia.Text;
            frmInstancia.Text = "Incluir : " + frmInstancia.Text;
            frmInstancia.ShowDialog();
            frmInstancia.Text = TituloTela;
        }

        protected virtual void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnEditar_Click(object sender, EventArgs e)
        {
            String TituloTela;
            if (frmInstancia == null)
            {
                this.InstanciarFormulario();
            }
            TituloTela = frmInstancia.Text;
            frmInstancia.Text = "Editar : " + frmInstancia.Text;
            frmInstancia.ShowDialog();
            frmInstancia.Text = TituloTela;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBaseList_Load(object sender, EventArgs e)
        {
            //MinimizeBox = false;
            //MaximizeBox = false;
            //MinimumSize = Parent.Size; 
            btnFechar.Top = (pnlBotoes.Height - btnFechar.Height);
            Parent.Text = Parent.Text + " : " + Text;           
            WindowState = FormWindowState.Maximized;
        }
    }
}
