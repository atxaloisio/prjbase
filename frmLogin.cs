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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblLogin.Parent = this;
            lblLogin.BackColor = Color.Transparent;

            lblSenha.Parent = this;
            lblSenha.BackColor = Color.Transparent;

            pictureBox1.Parent = this;
            pictureBox1.BackColor = Color.Transparent;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
