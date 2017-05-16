using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;

namespace prjbase
{
    public partial class frmRelFiltroPedido_Otica : prjbase.frmBaseRelFiltro
    {
        public frmRelFiltroPedido_Otica()
        {
            InitializeComponent();
        }

        private void btnPesquisaPedidoDe_Click(object sender, EventArgs e)
        {
            ExecutaPesquisaPedido(txtCodPedidoDe);
        }

        private void ExecutaPesquisaPedido(TextBox txtCod, TextBox txtDesc = null )
        {
            frmPesquisaPedido_Otica pesquisa = new frmPesquisaPedido_Otica();
            if (pesquisa.ExibeDialogo(txtCod.Text) == DialogResult.OK)
            {
                if (pesquisa.Id != null)
                {
                    txtCod.Text = pesquisa.Id.ToString();                    
                }
            }

        }

        private void btnPesquisaPedidoAte_Click(object sender, EventArgs e)
        {
            ExecutaPesquisaPedido(txtCodPedidoAte);
        }

        private void btnPesquisaClienteDe_Click(object sender, EventArgs e)
        {
            ExecutaPesquisaCliente(txtCodClienteDe, txtNomeClienteDe);
        }

        private void ExecutaPesquisaCliente(TextBox txtCod, TextBox txtDesc = null)
        {
            frmPesquisaClientes pesquisa = new frmPesquisaClientes();
            if (pesquisa.ExibeDialogo(txtCod.Text) == DialogResult.OK)
            {
                if (pesquisa.Id != null)
                {
                    ClienteBLL clienteBLL = new ClienteBLL();
                    Cliente cliente = clienteBLL.Localizar(pesquisa.Id);
                    if (cliente != null)
                    {
                        txtCod.Text = cliente.codigo_cliente_integracao;
                        txtDesc.Text = cliente.nome_fantasia;
                    }
                }
            }
        }

        private void btnPesquisaClienteAte_Click(object sender, EventArgs e)
        {
            ExecutaPesquisaCliente(txtCodClienteAte, txtNomeClienteAte);
        }

        private void btnPesquisaTransportadoraDe_Click(object sender, EventArgs e)
        {
            ExecutaPesquisaTransportadora(txtCodTransportadoraDe, txtNomeTransportadoraDe);
        }

        private void ExecutaPesquisaTransportadora(TextBox txtCod, TextBox txtDesc = null)
        {
            frmPesquisaTransportadora pesquisa = new frmPesquisaTransportadora();
            if (pesquisa.ExibeDialogo(txtCod.Text) == DialogResult.OK)
            {
                if (pesquisa.Id != null)
                {
                    ClienteBLL clienteBLL = new ClienteBLL();
                    Cliente cliente = clienteBLL.Localizar(pesquisa.Id);
                    if (cliente != null)
                    {
                        txtCod.Text = cliente.codigo_cliente_integracao;
                        txtDesc.Text = cliente.nome_fantasia;
                    }
                }
            }
        }

        private void btnPesquisaTransportadoraAte_Click(object sender, EventArgs e)
        {
            ExecutaPesquisaTransportadora(txtCodTransportadoraAte, txtNomeTransportadoraAte);
        }

        private void ExecutaPesquisaVendedor(TextBox txtCod, TextBox txtDesc = null)
        {
            frmPesquisaVendedor pesquisa = new frmPesquisaVendedor();
            if (pesquisa.ExibeDialogo(txtCod.Text) == DialogResult.OK)
            {
                if (pesquisa.Id != null)
                {
                    VendedorBLL VendedorBLL = new VendedorBLL();
                    Vendedor Vendedor = VendedorBLL.Localizar(pesquisa.Id);
                    if (Vendedor != null)
                    {
                        txtCod.Text = Vendedor.Id.ToString();
                        txtDesc.Text = Vendedor.nome;
                    }
                }
            }
        }

        private void btnPesquisaVendedorDe_Click(object sender, EventArgs e)
        {
            ExecutaPesquisaVendedor(txtCodVendedorDe, txtNomeVendedorDe);
        }

        private void btnPesquisaVendedorAte_Click(object sender, EventArgs e)
        {
            ExecutaPesquisaVendedor(txtCodVendedorAte, txtNomeVendedorAte);
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox)
            {
                ((MaskedTextBox)sender).Select(0, 0);
            }
            else if (sender is TextBox)
            {
                ((TextBox)sender).Select(0, 0);
            }

        }

        public override void ConfigurarForm(Form pFormParent)
        {
            base.ConfigurarForm(pFormParent);
            SetupCaixa(cbCaixaDe);
            SetupCaixa(cbCaixaAte);
        }

        private void SetupCaixa(ComboBox cb)
        {
            CaixaBLL caixaBLL = new CaixaBLL();

            List<Caixa> CaixaList = caixaBLL.getCaixa();

            AutoCompleteStringCollection acc = new AutoCompleteStringCollection();

            foreach (Caixa item in CaixaList)
            {
                acc.Add(item.numero);
            }

            cb.DataSource = CaixaList;
            cb.AutoCompleteCustomSource = acc;
            cb.ValueMember = "Id";
            cb.DisplayMember = "numero";
            cb.SelectedIndex = -1;
        }
    }
}
