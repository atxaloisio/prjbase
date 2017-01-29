﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjbase
{
    public partial class frmBaseCadEdit : prjbase.frmBase
    {

        public frmBaseCadEdit()
        {
            InitializeComponent();
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar(sender, e);
            Close();
        }

        protected virtual void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                atualizagrid = true;
                salvar(sender, e);
                btnIncluir.Top = 40;
                btnIncluir.Visible = true;
                btnCancelar.Top = 75;
                MessageBox.Show(Text + " salvo com sucesso.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.InnerException.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        protected virtual void cancelar(object sender, EventArgs e)
        {

        }

        protected virtual void salvar(object sender, EventArgs e)
        {

        }

        protected virtual void Limpar(Control control)
        {
            foreach (Control pnl in control.Controls)
            {
                if (pnl is Panel)
                {
                    foreach (var ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox)

                        {                            
                            ((TextBox)ctrl).Text = string.Empty;
                        }
                    }
                }                
            }
        }

        private void frmBaseCadEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }

        protected virtual void btnIncluir_Click(object sender, EventArgs e)
        {
            Limpar(this);
            Id = null;
        }
    }
}