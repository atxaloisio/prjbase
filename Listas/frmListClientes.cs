using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjbase
{
    public partial class frmListClientes : prjbase.frmBaseList
    {
        public frmListClientes()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        protected override void InstanciarFormulario()
        {
            frmInstancia = new frmBaseCadEdit();
        }

        private void frmClientes_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
