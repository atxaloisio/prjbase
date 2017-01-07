using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;

namespace prjbase
{
    public partial class frmUsuariosOld : Form
    {
        public frmUsuariosOld()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            using (var context = new dbIntegracaoEntities())
            {
                var lstUsuario = context.usuario.ToList<usuario>();
                dgvUsuarios.DataSource = lstUsuario;
            }
                /*
                lstDados.Items.Clear();
                using (var context = new dbIntegracaoEntities())
                {
                    foreach (var usuario in context.usuario.ToList())
                    {
                        lstDados.Items.Add(usuario.nome);
                    }
                }
                */
            }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            var frm = new frmUsuarioOld();
            //frm.MdiParent = this.MdiParent;
            frm.ShowDialog();
            //using (var context = new dbIntegracaoEntities())
            //{
            //    var lstUsuario = context.usuario.ToList<usuario>();

            //    context.usuario.Add(new usuario() { nome = txtNome.Text });

            //    context.SaveChanges();
            //    txtNome.Clear();
            //}
        }

        

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //using (var context = new dbIntegracaoEntities())
            //{
            //    var lstUsuario = context.usuario.ToList<usuario>();

            //    usuario UsuarioAlterado = lstUsuario.Where(a => a.nome == txtNome.Text).FirstOrDefault<usuario>();
            //    UsuarioAlterado.nome = "João Rafael";

            //    context.SaveChanges();
            //    txtNome.Clear();
            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
