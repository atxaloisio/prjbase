using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using Model;

namespace prjbase
{
    public partial class frmParametroSistema : prjbase.frmBase
    {
        CategoriaBLL categoriaBLL;
        Conta_CorrenteBLL conta_CorrenteBLL;
        public frmParametroSistema()
        {
            InitializeComponent();
        }

        private void btnCaminhoArquivos_Click(object sender, EventArgs e)
        {
            if (dlgCaminhoArquivos.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoArquivos.Text = dlgCaminhoArquivos.SelectedPath;
            }            
        }

        protected virtual void SetupControls()
        {
            SetupCategoria();
            SetupContaCorrente();
        }

        protected virtual void SetupContaCorrente()
        {
            conta_CorrenteBLL = new Conta_CorrenteBLL();
            cbContaCorrente.DataSource = conta_CorrenteBLL.getConta_Corrente();
            cbContaCorrente.ValueMember = "Id";
            cbContaCorrente.DisplayMember = "descricao";
            cbContaCorrente.SelectedIndex = -1;
        }

        protected virtual void SetupCategoria()
        {
            categoriaBLL = new CategoriaBLL();
            cbCategoria.DataSource = categoriaBLL.getCategoria(c => c.conta_receita == "S" & c.descricao != "&lt;Disponível&gt;");
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "descricao";
            cbCategoria.SelectedIndex = -1;
        }

        private void frmParametroSistema_Load(object sender, EventArgs e)
        {
            SetupControls();
            LoadToControls();
        }

        private void LoadToControls()
        {
            if (ConfigurationManager.AppSettings["bGeraGenLab"] != null)
            {
                string value = ConfigurationManager.AppSettings["bGeraGenLab"];
                chkIntGenLab.Checked = Convert.ToBoolean(value);
            }
                

            if (ConfigurationManager.AppSettings["strPathFileGenLab"] != null)
            {
                txtCaminhoArquivos.Text = ConfigurationManager.AppSettings["strPathFileGenLab"];
            }
                

            if (ConfigurationManager.AppSettings["IdCategoria"] != null)
            {
                cbCategoria.SelectedValue = Convert.ToInt64(ConfigurationManager.AppSettings["IdCategoria"]);                
            }
                

            if (ConfigurationManager.AppSettings["IdContaCorrente"] != null)
            {
                cbContaCorrente.SelectedValue = Convert.ToInt64(ConfigurationManager.AppSettings["IdContaCorrente"]);
            }
                

            if (ConfigurationManager.AppSettings["codEmpresa"] != null)
            {
                txtCodigoEmpresa.Text = ConfigurationManager.AppSettings["codEmpresa"];
            }
                

            if (ConfigurationManager.AppSettings["app_key"] != null)
            {
                txtAppKey.Text = ConfigurationManager.AppSettings["app_key"];
            }

            if (ConfigurationManager.AppSettings["app_secret"] != null)
            {
                txtAppSecret.Text =  ConfigurationManager.AppSettings["app_secret"];
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            //Geral
            if (settings["bGeraGenLab"] != null)
            {
                settings["bGeraGenLab"].Value = Convert.ToString(chkIntGenLab.Checked);
            }

            if (settings["strPathFileGenLab"] != null)
            {
                settings["strPathFileGenLab"].Value = txtCaminhoArquivos.Text;
            }

            if (settings["IdCategoria"] != null)
            {
                if (cbCategoria.SelectedValue != null)
                    settings["IdCategoria"].Value = Convert.ToString(cbCategoria.SelectedValue);
            }

            if (settings["IdContaCorrente"] != null)
            {
                if (cbContaCorrente.SelectedValue != null)
                    settings["IdContaCorrente"].Value = Convert.ToString(cbContaCorrente.SelectedValue);
            }

            if (settings["codEmpresa"] != null)
            {
                settings["codEmpresa"].Value = txtCodigoEmpresa.Text;
            }

            if (settings["app_key"] != null)
            {
                settings["app_key"].Value = txtAppKey.Text;
            }
            else
            {
                ConfigurationManager.AppSettings.Add("app_key", txtAppKey.Text);
            }

            if (settings["app_secret"] != null)
            {
                settings["app_secret"].Value = txtAppSecret.Text;
            }
            else
            {
                ConfigurationManager.AppSettings.Add("app_secret", txtAppSecret.Text);
            }

            ConfigurationManager.RefreshSection("appSettings");
           
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);



            MessageBox.Show(Text + " salvo com sucesso.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void onlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) & (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
