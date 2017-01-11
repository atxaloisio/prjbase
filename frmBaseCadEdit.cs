using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjbase
{
    public partial class frmBaseCadEdit : prjbase.frmBase
    {
        
        public frmBaseCadEdit()
        {
            InitializeComponent();
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {            
            cancelar(sender, e);
            Close();
        }

        protected virtual void btnSalvar_Click(object sender, EventArgs e)
        {            
            atualizagrid = true;
            salvar(sender, e);            
            btnIncluir.Top = 40;
            btnIncluir.Visible = true;
            btnCancelar.Top = 75;
        }

        protected virtual void cancelar(object sender, EventArgs e)
        {

        }

        protected virtual void salvar(object sender, EventArgs e)
        {

        }

        private void frmBaseCadEdit_Shown(object sender, EventArgs e)
        {
            if (Id != null)
            {
                MessageBox.Show("Id informado " + Convert.ToString(Id));
            }
        }
    }
}
