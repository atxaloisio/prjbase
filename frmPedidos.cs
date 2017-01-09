﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjbase
{
    public partial class frmPedidos : prjbase.frmBaseList
    {
        public frmPedidos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        protected override void InstanciarFormulario()
        {
            frmInstancia = new frmBaseCadEdit();
        }

        private void frmPedidos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmPedidos_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
