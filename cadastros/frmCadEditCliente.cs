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
    public partial class frmCadEditCliente : prjbase.frmBaseCadEdit
    {
        private ClienteBLL ClienteBLL;
       
        public frmCadEditCliente()
        {
            InitializeComponent();            
        }

        protected override void LoadToControls()
        {
            if (Id != null)
            {
                ClienteBLL = new ClienteBLL();

                Cliente Cliente = ClienteBLL.Localizar(Id);

                if (Cliente != null)
                {
                    //txtId.Text = Cliente.Id.ToString();
                    //txtCodigo.Text = Cliente.codigo.ToString();
                    //txtCodInt.Text = Cliente.codInt;
                    //txtNome.Text = Cliente.nome;
                    //chkInativo.Checked = Cliente.inativo == "S";                    
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
                    ClienteBLL = new ClienteBLL();
                    ClienteBLL.UsuarioLogado = Program.usuario_logado;
                    ClienteProxy proxy = new ClienteProxy();

                    Cliente Cliente = LoadFromControls();

                    if (Id != null)
                    {                        
                        //ClienteBLL.AlterarCliente(Cliente);
                        //proxy.AlterarCliente(Cliente);
                    }
                    else
                    {
                        //ClienteBLL.AdicionarCliente(Cliente);
                        //proxy.IncluirCliente(Cliente);
                    }
                    
                    if (Cliente.Id != 0)
                    {
                        //txtCodInt.Text = Cliente.codInt;
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

        protected virtual Cliente LoadFromControls()
        {
            Cliente Cliente = new Cliente();

            if (Id != null)
            {
                //Cliente.Id = Convert.ToInt64(txtId.Text);
                //Cliente.codigo = Convert.ToInt64(txtCodigo.Text);
                //Cliente.codInt = txtCodInt.Text;
            }
            
            //Cliente.nome = txtNome.Text;
            //if (Id == null)
            //{
            //    ClienteBLL = new ClienteBLL();
            //    List<Cliente> ClienteList = ClienteBLL.getCliente(p => p.nome.ToLower() == Cliente.nome.ToLower());
            //    if (ClienteList.Count > 0)
            //    {
            //        Cliente.Id = ClienteList.FirstOrDefault().Id;
            //        Cliente.codigo = ClienteList.FirstOrDefault().codigo;
            //        Cliente.codInt = ClienteList.FirstOrDefault().codInt;
            //    }
            //    else
            //    {
            //        Cliente.codInt = Sequence.GetNextVal("sq_Cliente_sequence").ToString();
            //    }
            //}
            
            
            //Cliente.inativo = (chkInativo.Checked == true) ? "S" : "N";
            
            return Cliente;
        }

        protected override void SetupControls()
        {                        
        }
                    
        protected override void Limpar(Control control)
        {
            base.Limpar(control);

            txtNome.Focus();
        }                
    }
}
