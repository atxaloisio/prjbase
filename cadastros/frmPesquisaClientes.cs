using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;

namespace prjbase
{
    public partial class frmPesquisaClientes : prjbase.frmBasePesquisa
    {
        private ClienteBLL clienteBLL;
        public frmPesquisaClientes()
        {
            InitializeComponent();
        }

        protected override void setRetorno()
        {
            base.setRetorno();
        }

        public virtual DialogResult ExibeDialogo(string valorProcura)
        {
            txtFiltro.Text = valorProcura;            
            return ShowDialog();
        }

        protected override void ExecutaPesquisa()
        {
            clienteBLL = new ClienteBLL();
            if (string.IsNullOrEmpty(txtFiltro.Text))
            {
                dgvPesquisa.Columns.Clear();
                dgvPesquisa.DataSource = clienteBLL.getCliente();
            }
            else
            {
                dgvPesquisa.Columns.Clear();
                switch (Convert.ToString(cbFiltro.SelectedValue))
                {                    
                    case "Id":
                        {
                            dgvPesquisa.DataSource = clienteBLL.getCliente(p => p.codigo_cliente_integracao == txtFiltro.Text);
                        }
                        break;
                    case "nome_fantasia":
                        {
                            dgvPesquisa.DataSource = clienteBLL.getCliente(p => p.nome_fantasia.ToLower().Contains(txtFiltro.Text));
                        }
                        break;
                    case "cnpj_cpf":
                        {
                            string strCPF, strCNPJ = string.Empty;
                            strCPF = Convert.ToInt64(txtFiltro.Text).ToString(@"000\.000\.000\-00");
                            strCNPJ = Convert.ToInt64(txtFiltro.Text).ToString(@"00\.000\.000\/0000\-00");
                            dgvPesquisa.DataSource = clienteBLL.getCliente(p => p.cnpj_cpf == strCPF || p.cnpj_cpf  == strCNPJ );
                        }
                        break;
                }
            }
            
            
        }

        protected override void SetupControls()
        {
            List<FiltroPesquisa> lstFiltroPesquisa = new List<FiltroPesquisa>();

            lstFiltroPesquisa.Add(new FiltroPesquisa() { chave = "Id", descricao = "Código" });
            lstFiltroPesquisa.Add(new FiltroPesquisa() { chave = "nome_fantasia", descricao = "Nome" });
            lstFiltroPesquisa.Add(new FiltroPesquisa() { chave = "cnpj_cpf", descricao = "CNPJ / CPF" });

            cbFiltro.DataSource = lstFiltroPesquisa;
            cbFiltro.ValueMember = "chave";
            cbFiltro.DisplayMember = "descricao";
            
            dgvPesquisa.Columns.Add("codigo_cliente_integracao", "Código");
            dgvPesquisa.Columns.Add("cnpj_cpf", "CNPJ / CPF");
            dgvPesquisa.Columns.Add("razao_social", "Razão Social");
            dgvPesquisa.Columns.Add("nome_fantasia", "Nome");
            
            FormataGridPesquisa();

        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFiltro.SelectedValue.ToString() == "Id")
            {
                if (!char.IsDigit(e.KeyChar))

                {
                    e.Handled = true;
                }
            }
            
        }

        private void cbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbFiltro_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            txtFiltro.Text = string.Empty;
            dgvPesquisa.DataSource = null;
        }

        protected override void FormataGridPesquisa()
        {
            base.FormataGridPesquisa();

            foreach (DataGridViewColumn col in dgvPesquisa.Columns)
            {
                col.Visible = false;
                if (col.Name == "codigo_cliente_integracao")
                {
                    col.Visible = true;
                    col.HeaderText = "Código";
                    col.Width = 100;
                }

                if (col.Name == "nome_fantasia")
                {
                    col.Visible = true;
                    col.HeaderText = "Nome Fantasia";
                    col.Width = 300;
                }

                if (col.Name == "razao_social")
                {
                    col.Visible = true;
                    col.HeaderText = "Razão Social";
                    col.Width = 300;
                }

                if (col.Name == "cnpj_cpf")
                {
                    col.Visible = true;
                    col.HeaderText = "CNPJ / CPF";
                    col.Width = 100;                    
                }
            }
        }

        private void frmPesquisaClientes_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text))
            {
                if (txtFiltro.Text.Where(c => char.IsNumber(c)).Count() >= 11)
                {
                    cbFiltro.SelectedValue = "cnpj_cpf";
                }
                else if ((txtFiltro.Text.Where(c => char.IsNumber(c)).Count() > 0)&& (txtFiltro.Text.Where(c => char.IsNumber(c)).Count() < 11))
                {
                    cbFiltro.SelectedValue = "Id";
                }
                else
                {
                    cbFiltro.SelectedValue = "nome_fantasia";
                }

                ExecutaPesquisa();
                FormataGridPesquisa();
            }
        }
    }
}
