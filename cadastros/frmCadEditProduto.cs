using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;
using System.Linq;
using Sync;
using Utils;

namespace prjbase
{
    public partial class frmCadEditProduto : prjbase.frmBaseCadEdit
    {
        private ProdutoBLL ProdutoBLL;
       
        public frmCadEditProduto()
        {
            InitializeComponent();            
        }

        protected override void LoadToControls()
        {
            if (Id != null)
            {
                ProdutoBLL = new ProdutoBLL();

                Produto Produto = ProdutoBLL.Localizar(Id);

                if (Produto != null)
                {
                    //txtId.Text = Produto.Id.ToString();
                    //txtCodigo.Text = Produto.codigo.ToString();
                    //txtCodInt.Text = Produto.codInt;
                    //txtNome.Text = Produto.nome;
                    //chkInativo.Checked = Produto.inativo == "S";                    
                }                
            }
        }

        protected override bool salvar(object sender, EventArgs e)
        {
            bool Retorno = epValidaDados.Validar(true);

            if (Retorno)
            {
                try
                {
                    ProdutoBLL = new ProdutoBLL();
                    ProdutoBLL.UsuarioLogado = Program.usuario_logado;
                    ProdutoProxy proxy = new ProdutoProxy();

                    Produto Produto = LoadFromControls();

                    if (Id != null)
                    {                        
                        //ProdutoBLL.AlterarProduto(Produto);
                        //proxy.AlterarProduto(Produto);
                    }
                    else
                    {
                        //ProdutoBLL.AdicionarProduto(Produto);
                        //proxy.IncluirProduto(Produto);
                    }
                    
                    if (Produto.id != 0)
                    {
                        //txtCodInt.Text = Produto.codInt;
                    }

                    Retorno = true;
                }
                catch (Exception ex)
                {
                    Retorno = false;
                    throw ex;
                }
            }
            return Retorno;
        }

        protected virtual Produto LoadFromControls()
        {
            Produto Produto = new Produto();

            if (Id != null)
            {
                //Produto.Id = Convert.ToInt64(txtId.Text);
                //Produto.codigo = Convert.ToInt64(txtCodigo.Text);
                //Produto.codInt = txtCodInt.Text;
            }
            
            //Produto.nome = txtNome.Text;
            //if (Id == null)
            //{
            //    ProdutoBLL = new ProdutoBLL();
            //    List<Produto> ProdutoList = ProdutoBLL.getProduto(p => p.nome.ToLower() == Produto.nome.ToLower());
            //    if (ProdutoList.Count > 0)
            //    {
            //        Produto.Id = ProdutoList.FirstOrDefault().Id;
            //        Produto.codigo = ProdutoList.FirstOrDefault().codigo;
            //        Produto.codInt = ProdutoList.FirstOrDefault().codInt;
            //    }
            //    else
            //    {
            //        Produto.codInt = Sequence.GetNextVal("sq_Produto_sequence").ToString();
            //    }
            //}
            
            
            //Produto.inativo = (chkInativo.Checked == true) ? "S" : "N";
            
            return Produto;
        }

        protected override void SetupControls()
        {                        
        }
                    
        protected override void Limpar(Control control)
        {
            base.Limpar(control);

            txtDescricao.Focus();
        }                
    }
}
