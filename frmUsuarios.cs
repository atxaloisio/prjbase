using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjbase
{
    public partial class frmUsuarios : prjbase.frmBaseList
    {
        public frmUsuarios()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        protected override void InstanciarFormulario()
        {
            frmInstancia = new frmBaseCadEdit();
        }

        
    }
}
