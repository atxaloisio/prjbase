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
            DialogResult = DialogResult.Cancel;
            cancelar(sender, e);
            Close();
        }

        protected virtual void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            salvar(sender, e);
            Close();
        }

        protected virtual void cancelar(object sender, EventArgs e)
        {

        }

        protected virtual void salvar(object sender, EventArgs e)
        {

        }
    }
}
