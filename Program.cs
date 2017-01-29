﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Model;

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
            splash.setprogresso(60);
            Thread.Sleep(500);
            Application.DoEvents();
            
            splash.setMensagem("Sincronizado.");            
            splash.setprogresso(100);
            Thread.Sleep(500);
            Application.DoEvents();

            Thread.Sleep(500);
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
