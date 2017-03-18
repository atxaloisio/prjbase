using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

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
                if (mdiChildForm is frmListUsuarios)
                {
                    instanciar = false;                    
                    mdiChildForm.WindowState = FormWindowState.Maximized;
                    mdiChildForm.BringToFront();
                }
            }

            if (instanciar)
            {
                var frm = new frmListUsuarios();
                frm.ConfigurarForm(this);
                frm.Tag = ((ToolStripMenuItem)sender).Tag;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
            
        }

        private void mnuCadClientes_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmListClientes)
                {
                    instanciar = false;
                    mdiChildForm.BringToFront();
                    mdiChildForm.Show();
                }
            }

            if (instanciar)
            {
                var frm = new frmListClientes();
                frm.ConfigurarForm(this);
                frm.Tag = ((ToolStripMenuItem)sender).Tag;
                frm.Show();
            }
            
        }

        private void mnuCadPedidoVendas_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmListPedidos_Otica)
                {
                    instanciar = false;
                    mdiChildForm.BringToFront();
                    mdiChildForm.Show();
                }
            }

            if (instanciar)
            {
                var frm = new frmListPedidos_Otica();
                frm.ConfigurarForm(this);
                frm.Tag = ((ToolStripMenuItem)sender).Tag;
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
                if (mdiChildForm is frmListProdutos)
                {
                    instanciar = false;
                    mdiChildForm.BringToFront();
                    mdiChildForm.Show();
                }
            }

            if (instanciar)
            {
                var frm = new frmListProdutos();
                frm.ConfigurarForm(this);
                frm.Tag = ((ToolStripMenuItem)sender).Tag;
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
                if (mdiChildForm is frmListPerfis)
                {
                    instanciar = false;                    
                    //mdiChildForm.Show();
                    mdiChildForm.WindowState = FormWindowState.Maximized;
                    mdiChildForm.BringToFront();
                }
            }

            if (instanciar)
            {
                var frm = new frmListPerfis();
                frm.ConfigurarForm(this);
                frm.Tag = ((ToolStripMenuItem)sender).Tag;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            confPermissaoMenu();        
        }

        private void confPermissaoMenu()
        {
            bool exibemenu = true;

            foreach (ToolStripMenuItem item in menuSistema.Items)
            {
                foreach (ToolStripMenuItem child in item.DropDownItems)
                {
                    if (child.DropDownItems.Count > 0)
                    {
                        interaMenuFilho(child);
                    }
                    else
                    {
                        Funcao_Perfil fp = Program.usuario_logado.perfil.funcao_perfil.Where(p => p.codigo_funcao == Convert.ToInt32(child.Tag)).FirstOrDefault();
                        if (fp != null)
                        {
                            exibemenu = fp.consultar == "S" || fp.editar == "S" || fp.excluir == "S" || fp.salvar == "S" || fp.imprimir == "S";
                            child.Visible = exibemenu;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Intera sobre os menus filhos para setar a permissão.
        /// </summary>
        /// <param name="itens"></param>
        private void interaMenuFilho(ToolStripMenuItem itens)
        {
            bool exibemenu = true;
            foreach (ToolStripMenuItem child in itens.DropDownItems)
            {
                if (child.DropDownItems.Count >0)
                {
                    interaMenuFilho(child);
                }
                else
                {
                    Funcao_Perfil fp = Program.usuario_logado.perfil.funcao_perfil.Where(p => p.codigo_funcao == Convert.ToInt32(child.Tag)).FirstOrDefault();
                    if (fp != null)
                    {
                        exibemenu = fp.consultar == "S" || fp.editar == "S" || fp.excluir == "S" || fp.salvar == "S" || fp.imprimir == "S";
                        child.Visible = exibemenu;
                    }
                }                
            }
        }

        private void mnuCadRelClienteFormaPagamento_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmListCliente_Parcela)
                {
                    instanciar = false;
                    //mdiChildForm.Show();
                    mdiChildForm.WindowState = FormWindowState.Maximized;
                    mdiChildForm.BringToFront();
                }
            }

            if (instanciar)
            {
                var frm = new frmListCliente_Parcela();
                frm.ConfigurarForm(this);
                frm.Tag = ((ToolStripMenuItem)sender).Tag;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void mnuCadRelLocalidadeTransportadora_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmListRotas)
                {
                    instanciar = false;
                    //mdiChildForm.Show();
                    mdiChildForm.WindowState = FormWindowState.Maximized;
                    mdiChildForm.BringToFront();
                }
            }

            if (instanciar)
            {
                var frm = new frmListRotas();
                frm.ConfigurarForm(this);
                frm.Tag = ((ToolStripMenuItem)sender).Tag;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
