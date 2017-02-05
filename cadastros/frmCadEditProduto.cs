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
    public partial class frmCadEditProduto : prjbase.frmBaseCadEdit
    {
        ProdutoBLL ProdutoBLL;
        public frmCadEditProduto()
        {
            InitializeComponent();
        }

        private void frmCadEditProduto_Shown(object sender, EventArgs e)
        {
            if (Id != null)
            {
                ProdutoBLL = new ProdutoBLL();
                Produto Produto = ProdutoBLL.Localizar(Id);

                if (Produto != null)
                {
                    //txtId.Text = Produto.Id.ToString();
                    //txtNome.Text = Produto.nome;
                    //txtEmail.Text = Produto.email;
                    //txtPassword.Text = Produto.password;
                    //txtDtAlteracao.Text = Produto.dtalteracao.ToString();
                    //txtDtCriacao.Text = Produto.dtcriacao.ToString();
                }
                //MessageBox.Show("Id informado " + Convert.ToString(Id));
            }
        }

        protected override bool salvar(object sender, EventArgs e)
        {            
            Produto Produto = new Produto();
            ProdutoBLL = new ProdutoBLL();

            Produto.descricao = "caneta bic preta";
            Produto.codigo = "PRD0003";
            Produto.ncm = "123456";
            Produto.unidade = "UN";

            Produto_Ibpt produto_ibpt = new Produto_Ibpt();

            produto_ibpt.aliqEstadual = new decimal(10.21);
            produto_ibpt.aliqFederal = new decimal(22.45);
            produto_ibpt.aliqMunicipal = new decimal(33);
            produto_ibpt.fonte = "teste";
            produto_ibpt.chave = "ver1";

            Produto.produto_ibpt.Add(produto_ibpt);


            ProdutoBLL.AdicionarProduto(Produto);
            return true;
            
        }

        protected override void Limpar(Control control)

        {
            base.Limpar(control);
            //txtNome.Focus();
        }
    }
}
