using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Model;
using BLL;

namespace prjbase
{
    public partial class frmCadEditUsuario : prjbase.frmBaseCadEdit
    {
        UsuarioBLL usuarioBLL;
        public frmCadEditUsuario()
        {
            InitializeComponent();
        }

        private void frmCadEditUsuario_Shown(object sender, EventArgs e)
        {
            if (Id != null)
            {
                usuarioBLL = new UsuarioBLL();
                Usuario usuario = usuarioBLL.Localizar(Id);

                if (usuario != null)
                {
                    txtId.Text = usuario.Id.ToString();
                    txtNome.Text = usuario.nome;
                    txtEmail.Text = usuario.email;
                    txtPassword.Text = usuario.password;
                    txtDtAlteracao.Text = usuario.dtalteracao.ToString();
                    txtDtCriacao.Text = usuario.dtcriacao.ToString();
                }
                //MessageBox.Show("Id informado " + Convert.ToString(Id));
            }
        }

        protected override void salvar(object sender, EventArgs e)
        {
            base.salvar(sender, e);

            Usuario usuario = new Usuario();
            usuarioBLL = new UsuarioBLL();

            usuario.nome = txtNome.Text;
            usuario.email = txtEmail.Text;
            usuario.password = txtPassword.Text;

            if (Id != null)
            {
                usuario.Id = Convert.ToInt32(txtId.Text);
                usuario.dtcriacao = Convert.ToDateTime(txtDtCriacao.Text);
                usuarioBLL.AlterarUsuario(usuario);
            }
            else
            {
                usuarioBLL.AdicionarUsuario(usuario);
            }

            if (usuario.Id != 0)
            {
                Id = usuario.Id;
                txtId.Text = usuario.Id.ToString();
            }
        }

        protected override void Limpar(Control control)

        {
            base.Limpar(control);
            txtNome.Focus();
        }
    }
}
