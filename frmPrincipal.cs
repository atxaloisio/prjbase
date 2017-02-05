using System;
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
            if (Program.usuario_logado != null)
            {
                this.Text = this.Text + "           Usuário: " + Program.usuario_logado.nome;
            }
        }        

        private void mnuCadUsuario_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmUsuarios)
                {
                    instanciar = false;
                    mdiChildForm.BringToFront();
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
                    mdiChildForm.BringToFront();
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
                    mdiChildForm.BringToFront();
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

        private void mnuProdutos_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmProdutos)
                {
                    instanciar = false;
                    mdiChildForm.BringToFront();
                    mdiChildForm.Show();
                }
            }

            if (instanciar)
            {
                var frm = new frmProdutos();
                frm.ConfigurarForm(this);
                frm.Show();
            }
        }

        private void mnuPermissoesAcesso_Click(object sender, EventArgs e)
        {
            frmPermissaoAcesso permissaoAcesso = new frmPermissaoAcesso();
            permissaoAcesso.ExibeDialogo();
            permissaoAcesso.Dispose();
        }

        private void mnuPerfilUsuarios_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmPerfis)
                {
                    instanciar = false;
                    mdiChildForm.BringToFront();
                    mdiChildForm.Show();
                }
            }

            if (instanciar)
            {
                var frm = new frmPerfis();
                frm.ConfigurarForm(this);
                frm.Show();
            }
        }
    }
}
