﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjbase
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }        

        private void mnuCadUsuario_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmUsuarios)
                {
                    instanciar = false;
                    mdiChildForm.Show();
                }
            }

            if (instanciar)
            {
                var frm = new frmUsuarios();
                frm.ConfigurarForm(this);
                frm.Show();
            }
            
        }

        private void mnuCadClientes_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmClientes)
                {
                    instanciar = false;
                    mdiChildForm.Show();
                }
            }

            if (instanciar)
            {
                var frm = new frmClientes();
                frm.ConfigurarForm(this);
                frm.Show();
            }
            
        }

        private void mnuCadPedidoVendas_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmPedidos)
                {
                    instanciar = false;
                    mdiChildForm.Show();
                }
            }

            if (instanciar)
            {
                var frm = new frmPedidos();
                frm.ConfigurarForm(this);
                frm.Show();
            }
            
        }

        private void mnuJanFecharTodos_Click(object sender, EventArgs e)
        {
            foreach (var mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
            }
        }
    }
}
