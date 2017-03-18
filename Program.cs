using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Model;
using Sync;

namespace prjbase
{    
    static class Program
    {        
        public static Usuario usuario_logado  {get;set;}
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmSplash splash = new frmSplash();
            splash.Show();

            Application.DoEvents();
           
            splash.setMensagem("Carregando configurações.");
            splash.setprogresso(30);
            Thread.Sleep(500);
            Application.DoEvents();
            
            splash.setMensagem("Sincronizando informações com a nuvem.");

            /*Ao incluir um novo webservice no projeto SYNC copiar o conteundo de <system.serviceModel> </system.serviceModel> 
             * para o app.config da aplicação principal.
             */

#if RELEASE

            //Clientes
            ClienteProxy cp = new ClienteProxy();
            try
            {                
                cp.SyncCadastroCliente();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            //Produtos
            ProdutoProxy pp = new ProdutoProxy();
            try
            {
                pp.SyncCadastroProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            FormaPagVendasProxy fpv = new FormaPagVendasProxy();
            try
            {
                fpv.SyncFormaPagVendas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

            CidadesProxy cid = new CidadesProxy();
            try
            {
                cid.SyncCidades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
#endif




            splash.setprogresso(60);
            Thread.Sleep(100);
            Application.DoEvents();

            splash.setMensagem("Sincronizado.");            
            splash.setprogresso(100);
            Thread.Sleep(100);
            Application.DoEvents();

            Thread.Sleep(50);
            Application.DoEvents();

            splash.Dispose();

            frmLogin login = new frmLogin();


            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
            else
            {
                Application.Exit();
            }

            
        }
    }
}
