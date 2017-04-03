﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Model;
using BLL;
using Utils;

namespace prjbase
{
    public partial class frmPrincipal : Form
    {
        private string nomeApp = string.Empty;
        public frmPrincipal()
        {                       
            InitializeComponent();
            if (Program.usuario_logado != null)
            {
                nomeApp = ConfigurationManager.AppSettings["NomeApp"];

                

                this.Text = nomeApp + "           Usuário: " + Program.usuario_logado.nome;
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

        private void mnuCadRelClienteTransportadora_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmListCliente_Transportadora)
                {
                    instanciar = false;
                    //mdiChildForm.Show();
                    mdiChildForm.WindowState = FormWindowState.Maximized;
                    mdiChildForm.BringToFront();
                }
            }

            if (instanciar)
            {
                var frm = new frmListCliente_Transportadora();
                frm.ConfigurarForm(this);
                frm.Tag = ((ToolStripMenuItem)sender).Tag;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void trocarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            foreach (var mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
            }

            frmLogin login = new frmLogin();            

            if (login.ShowDialog() == DialogResult.OK)
            {
                if (Program.usuario_logado != null)
                {
                    this.Text = nomeApp + "           Usuário: " + Program.usuario_logado.nome;
                    confPermissaoMenu();
                }
            }
        }

        private void agrupamentoDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean instanciar = true;

            foreach (var mdiChildForm in MdiChildren)
            {
                if (mdiChildForm is frmProcAgrupaPedido)
                {
                    instanciar = false;
                    //mdiChildForm.Show();
                    mdiChildForm.WindowState = FormWindowState.Maximized;
                    mdiChildForm.BringToFront();
                }
            }

            if (instanciar)
            {
                var frm = new frmProcAgrupaPedido();
                frm.ConfigurarForm(this);
                frm.Tag = ((ToolStripMenuItem)sender).Tag;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void parametrosDeSistemasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametroSistema ParametroSistema = new frmParametroSistema();
            ParametroSistema.Tag = ((ToolStripMenuItem)sender).Tag;
            ParametroSistema.ExibeDialogo();
            ParametroSistema.Dispose();            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (Program.usuario_logado != null)
            {
                frmAlteraSenha AlteraSenha = new frmAlteraSenha();
                AlteraSenha.Tag = ((ToolStripMenuItem)sender).Tag;
                AlteraSenha.ExibeDialogo(Program.usuario_logado.Id);
                AlteraSenha.Dispose();
            }            
        }

        private void atualizarStatusDoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcAtualizaStatusPedido AtualizaStatusPedido = new frmProcAtualizaStatusPedido();
            AtualizaStatusPedido.Tag = ((ToolStripMenuItem)sender).Tag;
            AtualizaStatusPedido.ExibeDialogo();
            AtualizaStatusPedido.Dispose();
        }

        private void rotasDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelRota relatorio = new frmRelRota();
            //relatorio.rvRelatorios.LocalReport.ReportEmbeddedResource = "prjbase.relatorios.relRota.rdlc";
            relatorio.ExibeDialogo(this);
            relatorio.Dispose();
        }
    }
}
