using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;
using System.Globalization;
using Utils;

namespace prjbase.utilitarios
{
    public partial class frmUtilCancelarPedido : prjbase.frmBaseCadEdit
    {
        private ClienteBLL clienteBLL;
        private ProdutoBLL produtoBLL;
        private ParcelaBLL parcelaBLL;
        private Motivo_EntregaBLL motivo_EntregaBLL;
        private Pedido_OticaBLL pedido_OticaBLL;
        private VendedorBLL vendedorBLL;
        private Vendedor_LocalidadeBLL vendedor_LocalidadeBLL;
        private CaixaBLL caixaBLL;
        public frmUtilCancelarPedido()
        {
            InitializeComponent();
        }

        protected override void LoadToControls()
        {
            if (Id != null)
            {
                pedido_OticaBLL = new Pedido_OticaBLL();
                Pedido_Otica pedido_otica = pedido_OticaBLL.Localizar(Id);
                if (pedido_otica != null)
                {
                    txtId.Text = pedido_otica.Id.ToString();
                    txtIdCliente.Text = pedido_otica.Id_cliente.ToString();
                    txtCodigo.Text = pedido_otica.codigo.ToString();
                    txtCodCliIntegracao.Text = pedido_otica.cliente.codigo_cliente_integracao;
                    txtClienteNome.Text = pedido_otica.cliente.nome_fantasia;
                    txtDtEmissao.Text = pedido_otica.data_emissao.Value.ToShortDateString();
                    if (pedido_otica.data_fechamento != null)
                    {
                        txtDtFechamento.Text = pedido_otica.data_fechamento.Value.ToShortDateString();
                    }


                    if (pedido_otica.date_previsao_entrega != null)
                    {
                        txtDtPrevEntrega.Text = pedido_otica.date_previsao_entrega.Value.ToShortDateString();
                    }
                    if (pedido_otica.hora_previsao_entrega != null)
                    {
                        txtHrPrevEntrega.Text = pedido_otica.hora_previsao_entrega.Value.ToString();
                    }

                    if (pedido_otica.condicao_pagamento != null)
                    {
                        cbCondPagamento.SelectedValue = pedido_otica.condicao_pagamento;
                    }

                    if (pedido_otica.Id_transportadora != null)
                    {
                        cbTransportadora.SelectedValue = pedido_otica.Id_transportadora;
                    }

                    txtNrPedCliente.Text = pedido_otica.numero_pedido_cliente;

                    if (pedido_otica.Id_caixa != null)
                    {
                        cbCaixa.SelectedValue = pedido_otica.Id_caixa;
                    }

                    if (pedido_otica.motivo_entrega != null)
                    {
                        cbMotivoEntrega.SelectedValue = pedido_otica.motivo_entrega.Id;
                    }                                                                        
                }
            }
        }

        private bool ValidaDadosEspecifico()
        {            
            bool retorno = true;

            pedido_OticaBLL = new Pedido_OticaBLL();
            try
            {
                Pedido_Otica pedido_Otica = pedido_OticaBLL.Localizar(Id);

                if (pedido_Otica.status > (int)StatusPedido.AENTREGAR)
                {
                    string mensagem = string.Empty;
                    if (pedido_Otica.status == (int)StatusPedido.SAIUPENTREGA)
                    {
                        mensagem = "Pedido: " + pedido_Otica.codigo + " Não pode ser cancelado pois encontra-se em rota de entrega.";
                    }

                    if (pedido_Otica.status == (int)StatusPedido.ENTREGUE)
                    {
                        mensagem = "Pedido: " + pedido_Otica.codigo + " Não pode ser cancelado pois consta como entregue.";
                    }

                    if (pedido_Otica.status == (int)StatusPedido.AGRUPADO)
                    {
                        mensagem = "Pedido: " + pedido_Otica.codigo + " Não pode ser cancelado pois consta como agrupado.";
                    }

                    if (pedido_Otica.status == (int)StatusPedido.FATURADO)
                    {
                        mensagem = "Pedido: " + pedido_Otica.codigo + " Não pode ser cancelado pois consta como faturado.";
                    }

                    if (!string.IsNullOrEmpty(mensagem))
                    {
                        MessageBox.Show(mensagem, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        retorno = false;
                    }
                }
            }
            finally
            {
                pedido_OticaBLL.Dispose();
            }
            



            return retorno;
        }

        protected override bool salvar(object sender, EventArgs e)
        {
            bool Retorno = epValidaDados.Validar(true);

            Retorno = ValidaDadosEspecifico();
            
            if (Retorno)
            {
                try
                {
                    pedido_OticaBLL = new Pedido_OticaBLL();
                    pedido_OticaBLL.UsuarioLogado = Program.usuario_logado;

                    Pedido_Otica pedido_Otica = pedido_OticaBLL.Localizar(Id);
                    pedido_Otica.cancelado = "S";
                    pedido_Otica.data_cancelamento = DateTime.Now;
                    pedido_Otica.motivo_cancelamento = txtMotivoCancelamento.Text;


                    pedido_OticaBLL.AlterarPedido_Otica(pedido_Otica);
                                       
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
    }
}
