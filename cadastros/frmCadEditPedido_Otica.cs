﻿using System;
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
using System.Globalization;
using Utils;

namespace prjbase
{
    public partial class frmCadEditPedido_Otica : prjbase.frmBaseCadEdit
    {
        private ClienteBLL clienteBLL;
        private ProdutoBLL produtoBLL;
        private FormasPagVendaBLL formasPagVendaBLL;
        private Motivo_EntregaBLL motivo_EntregaBLL;
        private Pedido_OticaBLL pedido_OticaBLL;

        #region Constante de Colunas da Grid
        private const int col_Id = 0;
        private const int col_Codigo = 1;
        private const int col_BtnPesquisa = 2;
        private const int col_Descricao = 3;
        private const int col_Unidade = 4;
        private const int col_Quantidade = 5;
        private const int col_VlrUnitario = 6;
        private const int col_PercDesconto = 7;
        private const int col_VlrDesconto = 8;
        private const int col_VlrTotal = 9;


        #endregion
        public frmCadEditPedido_Otica()
        {
            InitializeComponent();
        }

        protected override bool salvar(object sender, EventArgs e)
        {
            bool Retorno = epValidaDados.Validar(true);

            if (Retorno)
            {
                Retorno = ValidaDadosEspecifico();
            }

            try
            {
                pedido_OticaBLL = new Pedido_OticaBLL();

                Pedido_Otica pedido_Otica = new Pedido_Otica();

                #region Dados do Pedido
                pedido_Otica.agrupado = "N";
                pedido_Otica.Id_cliente = Convert.ToInt64(txtIdCliente.Text);
                pedido_Otica.codigo_cliente = txtCodCliIntegracao.Text;
                pedido_Otica.codigo_pedido = txtCodigo.Text;

                if (!string.IsNullOrEmpty(txtDtEmissao.Text))
                {
                    txtDtEmissao.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    pedido_Otica.data_emissao = Convert.ToDateTime(txtDtEmissao.Text);
                    txtDtEmissao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                }

                if (!string.IsNullOrEmpty(txtDtFechamento.Text))
                {
                    txtDtFechamento.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    pedido_Otica.data_fechamento = Convert.ToDateTime(txtDtFechamento.Text);
                    txtDtFechamento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                }

                if (cbCondPagamento.SelectedIndex != -1)
                {
                    pedido_Otica.condicao_pagamento = Convert.ToInt64(cbCondPagamento.SelectedValue);
                }
                pedido_Otica.numero_pedido_cliente = txtNrPedCliente.Text;

                if (!string.IsNullOrEmpty(txtDtPrevEntrega.Text))
                {
                    txtDtPrevEntrega.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    pedido_Otica.date_previsao_entrega = Convert.ToDateTime(txtDtPrevEntrega.Text);
                    txtDtPrevEntrega.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                }

                if (!string.IsNullOrEmpty(txtHrPrevEntrega.Text))
                {
                    CultureInfo Culture = CultureInfo.CurrentCulture;
                    TimeSpan horaEnt;
                    txtHrPrevEntrega.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    TimeSpan.TryParseExact(txtHrPrevEntrega.Text, "g", Culture, out horaEnt);
                    pedido_Otica.hora_previsao_entrega = horaEnt;
                }

                if (cbMotivoEntrega.SelectedIndex != -1)
                {
                    pedido_Otica.id_motivo_entrega = Convert.ToInt64(cbMotivoEntrega.SelectedValue);
                }

                if (cbTransportadora.SelectedIndex != -1)
                {
                    pedido_Otica.Id_transportadora = Convert.ToInt64(cbTransportadora.SelectedValue);
                }
                #endregion

                #region Dados Receiturario
                //Olho Direito
                pedido_Otica.od_gl_esf = txtod_gl_esf.Text;
                pedido_Otica.od_gl_cil = txtod_gl_cil.Text;

                if (!string.IsNullOrEmpty(txtod_eixo.Text))
                {
                    pedido_Otica.od_eixo = Convert.ToInt32(txtod_eixo.Text);
                }

                if (!string.IsNullOrEmpty(txtod_adicao.Text))
                {
                    pedido_Otica.od_adicao = Convert.ToDecimal(txtod_adicao.Text);
                }

                pedido_Otica.od_gp_esf = txtod_gp_esf.Text;
                pedido_Otica.od_gp_cil = txtod_gp_cil.Text;
                pedido_Otica.od_dnp_longe = txtod_dnp_longe.Text;
                pedido_Otica.od_dnp_perto = txtod_dnp_perto.Text;
                pedido_Otica.od_alt = txtod_alt.Text;
                pedido_Otica.od_dech = txtod_dech.Text;
                pedido_Otica.od_prisma_valor = txtod_prisma_valor.Text;

                if (!string.IsNullOrEmpty(txtod_prisma_eixo.Text))
                {
                    pedido_Otica.od_prisma_eixo = Convert.ToInt32(txtod_prisma_eixo.Text);
                }
                //Olho Esquerdo
                pedido_Otica.oe_gl_esf = txtoe_gl_esf.Text;
                pedido_Otica.oe_gl_cil = txtoe_gl_cil.Text;

                if (!string.IsNullOrEmpty(txtoe_eixo.Text))
                {
                    pedido_Otica.oe_eixo = Convert.ToInt32(txtoe_eixo.Text);
                }

                if (!string.IsNullOrEmpty(txtoe_adicao.Text))
                {
                    pedido_Otica.oe_adicao = Convert.ToDecimal(txtoe_adicao.Text);
                }

                pedido_Otica.oe_gp_esf = txtoe_gp_esf.Text;
                pedido_Otica.oe_gp_cil = txtoe_gp_cil.Text;
                pedido_Otica.oe_dnp_longe = txtoe_dnp_longe.Text;
                pedido_Otica.oe_dnp_perto = txtoe_dnp_perto.Text;
                pedido_Otica.oe_alt = txtoe_alt.Text;
                pedido_Otica.oe_dech = txtoe_dech.Text;
                pedido_Otica.oe_prisma_valor = txtoe_prisma_valor.Text;

                if (!string.IsNullOrEmpty(txtoe_prisma_eixo.Text))
                {
                    pedido_Otica.oe_prisma_eixo = Convert.ToInt32(txtoe_prisma_eixo.Text);
                }
                pedido_Otica.status = (int)StatusPedido.GRAVADO;
                #endregion

                #region Dados Armação
                Pedido_Armacao pedido_Armacao = new Pedido_Armacao();

                if (cbTipoArmacao.SelectedIndex != -1)
                {
                    pedido_Armacao.tipo = Convert.ToInt32(cbTipoArmacao.SelectedValue);
                }

                if (cbShapeArmacao.SelectedIndex != -1)
                {
                    pedido_Armacao.shape = Convert.ToInt32(cbShapeArmacao.SelectedValue);
                }

                if (!string.IsNullOrEmpty(txtDiaFinLente.Text))
                {
                    pedido_Armacao.diametro_final_lente = Convert.ToDecimal(txtDiaFinLente.Text);
                }

                if (!string.IsNullOrEmpty(txtLarguaArmacao.Text))
                {
                    pedido_Armacao.largura = Convert.ToInt32(txtLarguaArmacao.Text);
                }

                if (!string.IsNullOrEmpty(txtPonteArmacao.Text))
                {
                    pedido_Armacao.ponte = Convert.ToInt32(txtPonteArmacao.Text);
                }

                if (!string.IsNullOrEmpty(txtAlturaArmacao.Text))
                {
                    pedido_Armacao.altura = Convert.ToInt32(txtAlturaArmacao.Text);
                }

                if (!string.IsNullOrEmpty(txtMaiorDiagonal.Text))
                {
                    pedido_Armacao.maior_diagonal = Convert.ToInt32(txtMaiorDiagonal.Text);
                }

                if (!string.IsNullOrEmpty(txtEixoMaiorDiagonal.Text))
                {
                    pedido_Armacao.eixo_maior_diagonal = Convert.ToInt32(txtEixoMaiorDiagonal.Text);
                }

                pedido_Otica.pedido_armacao.Add(pedido_Armacao);
                #endregion

                #region Dados Lente
                Pedido_Lente pedido_Lente = new Pedido_Lente();
                if (cbTipoLente.SelectedIndex != -1)
                {
                    pedido_Lente.tipo = Convert.ToInt32(cbTipoLente.SelectedValue);
                }
                pedido_Lente.marca_material = txtMaterialLente.Text;
                pedido_Lente.observacoes = txtObs.Text;
                #endregion

                #region Itens do Pedido

                //

                foreach (DataGridViewRow item in dgvItemPedido.Rows)
                {
                    pedido_Otica.itempedido_otica.Add(new ItemPedido_Otica
                    {
                        Id_produto = Convert.ToInt64(item.Cells[col_Id].Value),
                        quantidade = Convert.ToInt32(item.Cells[col_Quantidade].Value),
                        unidade = ((DataGridViewComboBoxCell)item.Cells[col_Quantidade]).Value.ToString(),
                        percentual_desconto = Convert.ToDecimal(item.Cells[col_PercDesconto].Value),
                        valor_desconto = Convert.ToDecimal(item.Cells[col_VlrDesconto].Value),
                        valor_unitario = Convert.ToDecimal(item.Cells[col_VlrUnitario].Value),
                        valor_total = Convert.ToDecimal(item.Cells[col_VlrTotal].Value),
                    });
                    MessageBox.Show(item.Cells[0].Value.ToString());
                }

                #endregion




                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        private bool ValidaDadosEspecifico()
        {
            return true;
        }

        private void frmCadEditPedido_Otica_Load(object sender, EventArgs e)
        {
            SetupControls();
        }

        protected void SetupControls()
        {
            SetupCondPagamento();
            SetupTransportadora();
            SetupMotivoEntrega();
            SetupTipoArmacao();
            SetupShapeArmacao();
            SetupTipoLente();
            formataGridItens();
        }

        private void SetupTipoLente()
        {
            TipoLente tp = new TipoLente();

            cbTipoLente.DataSource = Enumerados.getListEnum(tp);
            cbTipoLente.ValueMember = "chave";
            cbTipoLente.DisplayMember = "descricao";
            cbTipoLente.SelectedIndex = -1;
        }

        private void SetupShapeArmacao()
        {
            ShapeArmacao tp = new ShapeArmacao();

            cbShapeArmacao.DataSource = Enumerados.getListEnum(tp);
            cbShapeArmacao.ValueMember = "chave";
            cbShapeArmacao.DisplayMember = "descricao";
            cbShapeArmacao.SelectedIndex = -1;
        }

        private void SetupTipoArmacao()
        {
            TipoArmacao tp = new TipoArmacao();

            cbTipoArmacao.DataSource = Enumerados.getListEnum(tp);
            cbTipoArmacao.ValueMember = "chave";
            cbTipoArmacao.DisplayMember = "descricao";
            cbTipoArmacao.SelectedIndex = -1;
        }

        private void SetupMotivoEntrega()
        {
            motivo_EntregaBLL = new Motivo_EntregaBLL();
            cbMotivoEntrega.DataSource = motivo_EntregaBLL.getMotivo_Entrega();
            cbMotivoEntrega.ValueMember = "Id";
            cbMotivoEntrega.DisplayMember = "Descricao";
            cbMotivoEntrega.SelectedIndex = -1;
        }

        private void SetupTransportadora()
        {
            clienteBLL = new ClienteBLL();
            cbTransportadora.DataSource = clienteBLL.getCliente(x => x.cliente_tag.Any(e => e.tag == "Transportadora"));
            cbTransportadora.ValueMember = "Id";
            cbTransportadora.DisplayMember = "nome_fantasia";
            cbTransportadora.SelectedIndex = -1;
        }

        private void SetupCondPagamento()
        {
            formasPagVendaBLL = new FormasPagVendaBLL();
            cbCondPagamento.DataSource = formasPagVendaBLL.getFormasPagVenda();
            cbCondPagamento.ValueMember = "Id";
            cbCondPagamento.DisplayMember = "cDescricao";
            cbCondPagamento.SelectedIndex = -1;
        }

        private void formataGridItens()
        {
            dgvItemPedido.Columns[col_Quantidade].ValueType = typeof(decimal);
            dgvItemPedido.Columns[col_Quantidade].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvItemPedido.Columns[col_VlrUnitario].DefaultCellStyle.Format = "N2";
            dgvItemPedido.Columns[col_VlrUnitario].ValueType = typeof(decimal);
            dgvItemPedido.Columns[col_VlrUnitario].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvItemPedido.Columns[col_PercDesconto].DefaultCellStyle.Format = "N2";
            dgvItemPedido.Columns[col_PercDesconto].ValueType = typeof(decimal);
            dgvItemPedido.Columns[col_PercDesconto].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvItemPedido.Columns[col_VlrDesconto].DefaultCellStyle.Format = "N2";
            dgvItemPedido.Columns[col_VlrDesconto].ValueType = typeof(decimal);
            dgvItemPedido.Columns[col_VlrDesconto].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvItemPedido.Columns[col_VlrTotal].DefaultCellStyle.Format = "N2";
            dgvItemPedido.Columns[col_VlrTotal].ReadOnly = true;
            dgvItemPedido.Columns[col_VlrTotal].ValueType = typeof(decimal);
            dgvItemPedido.Columns[col_VlrTotal].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            setupCol_Unidade();
        }

        private void dgvItemPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (dgvItemPedido.CurrentCell != null)
                {
                    int iColumn = dgvItemPedido.CurrentCell.ColumnIndex;
                    int iRow = dgvItemPedido.CurrentCell.RowIndex;

                    if (iColumn == dgvItemPedido.Columns.Count - 1)
                        dgvItemPedido.CurrentCell = dgvItemPedido[col_Codigo, iRow];
                    else
                    {
                        try
                        {
                            dgvItemPedido.CurrentCell = dgvItemPedido[iColumn + 1, iRow];
                        }
                        catch (Exception)
                        {
                            dgvItemPedido.CurrentCell = dgvItemPedido[iColumn, iRow];
                        }                                                                            
                    }
                }
            }

            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
                if (dgvItemPedido.CurrentCell != null)
                {
                    int iColumn = dgvItemPedido.CurrentCell.ColumnIndex;
                    int iRow = dgvItemPedido.CurrentCell.RowIndex;

                    dgvItemPedido[iColumn, iRow].Value = "";
                }
            }

            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;

                if (MessageBox.Show("Deseja cancelar a inclusão do produto?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvItemPedido.Rows.Count > 0)
                    {
                        dgvItemPedido.Rows.RemoveAt(dgvItemPedido.CurrentRow.Index);
                    }
                }                
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            bool AdicionaLinha = true;
            if (dgvItemPedido.Rows.Count > 0)
            {
                AdicionaLinha = ValidaLinhaGrid(dgvItemPedido.CurrentRow.Index);
            }

            if (AdicionaLinha)
            {
                dgvItemPedido.Rows.Add();
                dgvItemPedido.Focus();
                if (dgvItemPedido.Rows.Count > 0)
                {
                    dgvItemPedido.CurrentCell = dgvItemPedido.Rows[dgvItemPedido.Rows.Count - 1].Cells[col_Codigo];
                }
                SendKeys.Send("{DOWN}");
            }
        }

        private bool ValidaLinhaGrid(int index)
        {
            bool retorno = true;

            //retorno = dgvItemPedido_ValidarQuantidade(index);

            //if (retorno)
            //{
            //    retorno = dgvItemPedido_ValidarValorUnitario(index);
            //}

            //if (retorno)
            //{
            //    retorno = dgvItemPedido_ValidarPercDesconto(index);
            //}

            //if (retorno)
            //{
            //    retorno = dgvItemPedido_ValidarPercDesconto(index);
            //}

            return retorno;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvItemPedido.Rows.Count > 0)
            {
                dgvItemPedido.Rows.RemoveAt(dgvItemPedido.CurrentRow.Index);
            }

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            ExecutaPesquisaCliente();
        }

        private void ExecutaPesquisaCliente()
        {
            frmPesquisaClientes pesquisa = new frmPesquisaClientes();
            if (pesquisa.ExibeDialogo(txtCodCliIntegracao.Text) == DialogResult.OK)
            {
                if (pesquisa.Id != null)
                {
                    clienteBLL = new ClienteBLL();
                    Cliente cliente = clienteBLL.Localizar(pesquisa.Id);
                    if (cliente != null)
                    {
                        txtCodCliIntegracao.Text = cliente.codigo_cliente_integracao;
                        txtClienteNome.Text = cliente.nome_fantasia;
                        txtIdCliente.Text = cliente.Id.ToString();
                        txtDtEmissao.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não localizado.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCliIntegracao.Text = String.Empty;
                }
            }
            else
            {
                txtCodCliIntegracao.Focus();
            }
        }

        private void LoadDadosCliente(long? id = null, string CodInteg = "")
        {
            clienteBLL = new ClienteBLL();
            Cliente cliente = new Cliente();

            if (id != null)
            {
                cliente = clienteBLL.Localizar(id);
            }
            else if (!string.IsNullOrEmpty(CodInteg))
            {
                if (CodInteg.Where(c => char.IsNumber(c)).Count() >= 11)
                {
                    string strCPF, strCNPJ = string.Empty;
                    strCPF = Convert.ToInt64(CodInteg).ToString(@"000\.000\.000\-00");
                    strCNPJ = Convert.ToInt64(CodInteg).ToString(@"00\.000\.000\/0000\-00");
                    cliente = clienteBLL.getCliente(p => p.cnpj_cpf == strCPF || p.cnpj_cpf == strCNPJ).FirstOrDefault();
                }
                else if ((CodInteg.Where(c => char.IsNumber(c)).Count() > 0) && (CodInteg.Where(c => char.IsNumber(c)).Count() < 11))
                {
                    cliente = clienteBLL.getCliente(p => p.codigo_cliente_integracao == CodInteg).FirstOrDefault();
                }
            }

            if (cliente != null)
            {
                txtIdCliente.Text = cliente.Id.ToString();
                txtCodCliIntegracao.Text = cliente.codigo_cliente_integracao;
                txtClienteNome.Text = cliente.nome_fantasia;
                txtDtEmissao.Focus();
            }
        }

        private void txtDtEmissao_Enter(object sender, EventArgs e)
        {

        }

        private void txtCodCliIntegracao_TextChanged(object sender, EventArgs e)
        {
            txtClienteNome.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
        }

        private void txtCodCliIntegracao_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCliIntegracao.Text))
            {
                if (txtCodCliIntegracao.Text.Where(c => char.IsNumber(c)).Count() > 0)
                {
                    LoadDadosCliente(null, txtCodCliIntegracao.Text);
                    if (string.IsNullOrEmpty(txtClienteNome.Text))
                    {
                        ExecutaPesquisaCliente();
                    }
                }
                else
                {
                    ExecutaPesquisaCliente();
                }
            }
        }

        private void Ctrls_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                epValidaDados.SetError((TextBox)sender, string.Empty);
                if (((TextBox)sender).Name == "txtCodCliIntegracao")
                {
                    epValidaDados.SetError(txtClienteNome, string.Empty);
                }
            }
            else if (sender is MaskedTextBox)
            {
                epValidaDados.SetError((MaskedTextBox)sender, string.Empty);
            }
            else if (sender is ComboBox)
            {
                epValidaDados.SetError((ComboBox)sender, string.Empty);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvItemPedido_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == col_BtnPesquisa)
            {
                setupCol_BtnPesquisa(sender, e);
                e.Handled = true;
            }

        }



        private void setupCol_BtnPesquisa(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            var w = Properties.Resources.Pesquisar.Width;
            var h = Properties.Resources.Pesquisar.Height;
            var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

            e.CellStyle.BackColor = SystemColors.HotTrack;
            e.CellStyle.ForeColor = SystemColors.HighlightText;
            e.CellStyle.SelectionBackColor = SystemColors.Highlight;
            e.CellStyle.SelectionForeColor = SystemColors.HighlightText;

            e.PaintBackground(new Rectangle(x, y, w, h), false);

            e.Graphics.DrawImage(Properties.Resources.Pesquisar, new Rectangle(x, y, w, h));
        }

        private void dgvItemPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == col_BtnPesquisa)
            {
                ExecutaPesquisaProduto(sender, e);
            }
        }

        private void ExecutaPesquisaProduto(object sender, DataGridViewCellEventArgs e)
        {
            frmPesquisaProdutos pesquisa = new frmPesquisaProdutos();
            string chavePesquisa = (dgvItemPedido[col_Codigo, e.RowIndex].Value == null ? string.Empty : dgvItemPedido[col_Codigo, e.RowIndex].Value.ToString());
            if (pesquisa.ExibeDialogo(chavePesquisa) == DialogResult.OK)
            {
                if (pesquisa.Id != null)
                {
                    produtoBLL = new ProdutoBLL();
                    Produto produto = produtoBLL.Localizar(pesquisa.Id);
                    if (produto != null)
                    {
                        dgvItemPedido[col_Id, e.RowIndex].Value = produto.id;
                        dgvItemPedido[col_Codigo, e.RowIndex].Value = produto.codigo_produto_integracao;
                        dgvItemPedido[col_Descricao, e.RowIndex].Value = produto.descricao;

                        ((DataGridViewComboBoxCell)dgvItemPedido[col_Unidade, e.RowIndex]).Value = produto.unidade;
                        //dgvItemPedido[col_Unidade, e.RowIndex].Value = produto.unidade;


                        dgvItemPedido[col_VlrUnitario, e.RowIndex].Value = produto.valor_unitario;
                        dgvItemPedido[col_PercDesconto, e.RowIndex].Value = 0;
                        dgvItemPedido[col_VlrDesconto, e.RowIndex].Value = Convert.ToDecimal(0.00);
                        dgvItemPedido[col_VlrTotal, e.RowIndex].Value = Convert.ToDecimal(0.00);

                        if (dgvItemPedido.Rows.Count > 0)
                        {
                            dgvItemPedido.CurrentCell = dgvItemPedido.Rows[e.RowIndex].Cells[col_Quantidade];
                        }
                    }
                }
            }
            else
            {
                txtCodCliIntegracao.Focus();
            }
        }



        private void dgvItemPedido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void setupCol_Unidade()
        {
            UnidadeBLL unidadeBLL = new UnidadeBLL();
            ((DataGridViewComboBoxColumn)dgvItemPedido.Columns[col_Unidade]).DataSource = unidadeBLL.getUnidade();
            ((DataGridViewComboBoxColumn)dgvItemPedido.Columns[col_Unidade]).DisplayMember = "codigo";
            ((DataGridViewComboBoxColumn)dgvItemPedido.Columns[col_Unidade]).ValueMember = "codigo";
        }

        private void dgvItemPedido_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            e.Control.KeyPress -= new KeyPressEventHandler(onlyNumber_KeyPress);

            switch (dgvItemPedido.CurrentCell.ColumnIndex)
            {
                case col_Quantidade:
                case col_PercDesconto:
                case col_VlrDesconto:
                case col_VlrUnitario:
                    {
                        TextBox tb = e.Control as TextBox;
                        if (tb != null)
                        {
                            tb.KeyPress += new KeyPressEventHandler(onlyNumber_KeyPress);
                        }

                    }
                    break;
            }
        }

        private void onlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) & (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void EsfCil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !e.KeyChar.Equals('+') && !e.KeyChar.Equals('-') && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Grau_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvItemPedido_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int coluna = dgvItemPedido.CurrentCell.ColumnIndex;
            int linha = dgvItemPedido.CurrentCell.RowIndex;

            if (e.ColumnIndex == col_Quantidade)
            {
                e.Cancel = !dgvItemPedido_ValidarQuantidade(e);
            }

            if (coluna == col_VlrUnitario)
            {
                e.Cancel = !dgvItemPedido_ValidarValorUnitario(e);
            }

            if (coluna == col_PercDesconto)
            {
                e.Cancel = !dgvItemPedido_ValidarPercDesconto(e);
            }

            if (coluna == col_VlrDesconto)
            {
                e.Cancel = !dgvItemPedido_ValidarValorDesconto(e);
            }

            if (e.Cancel)
            {
                dgvItemPedido.CurrentCell = dgvItemPedido[e.ColumnIndex, e.RowIndex];                
            }
        }

        private bool dgvItemPedido_ValidarValorDesconto(DataGridViewCellValidatingEventArgs e)
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                MessageBox.Show("Valor de desconto invalido.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                
                retorno = false;
            }

            if (retorno)
            {
                if ((dgvItemPedido[col_Quantidade, e.RowIndex].Value != null) & (dgvItemPedido[col_VlrUnitario, e.RowIndex].Value != null))
                {
                    decimal qtd = Convert.ToDecimal(dgvItemPedido[col_Quantidade, e.RowIndex].Value);
                    decimal vlrUn = Convert.ToDecimal(dgvItemPedido[col_VlrUnitario, e.RowIndex].Value);

                    decimal vlrTotal = qtd * vlrUn;
                    decimal vlrDesc = Convert.ToDecimal(e.FormattedValue);

                    if (vlrDesc > vlrTotal)
                    {
                        MessageBox.Show("Valor de desconto não pode ser maior que valor total.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                        retorno = false;
                    }                    
                }
            }

            return retorno;
        }

        private bool dgvItemPedido_ValidarPercDesconto(DataGridViewCellValidatingEventArgs e)
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                MessageBox.Show("Percentual de desconto invalido.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                
                retorno = false;
            }
            else if (Convert.ToDecimal(e.FormattedValue) > 100)
            {
                MessageBox.Show("Percentual de desconto deve ser menor que 100.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                              
                retorno = false;
            }
            else if (Convert.ToDecimal(e.FormattedValue) < 100)
            {
                MessageBox.Show("Percentual de desconto deve ser menor que zero.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                
                retorno = false;
            }
            
            return retorno;
        }

        private bool dgvItemPedido_ValidarQuantidade(DataGridViewCellValidatingEventArgs e)
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                MessageBox.Show("Quantidade obrigatória.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                                
                retorno = false;
            }
            
            return retorno;
        }

        private bool dgvItemPedido_ValidarValorUnitario(DataGridViewCellValidatingEventArgs e)
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                MessageBox.Show("Valor unitário obrigatório.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                
                retorno = false;
            }
            else if (Convert.ToDecimal(e.FormattedValue) <= 0)
            {
                MessageBox.Show("Deve ser maior que zero.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                
                retorno = false;
            }
                       
            return retorno;
        }

        private void eixo_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                if (Convert.ToInt32(((TextBox)sender).Text) > 180)
                {

                    MessageBox.Show("Eixo não pode ser superior a 180°", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ((TextBox)sender).Text = "0";
                    e.Cancel = true;
                }

                if (Convert.ToInt32(((TextBox)sender).Text) < 0)
                {

                    MessageBox.Show("Eixo não pode ser inferior a 0°", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ((TextBox)sender).Text = "0";
                    e.Cancel = true;
                }
            }
        }

        protected override void Limpar(Control control)
        {
            base.Limpar(control);
            txtCodigo.Focus();
        }

        private void Ctrls_Validating(object sender, CancelEventArgs e)
        {
            if (sender is MaskedTextBox)
            {
                if ((((MaskedTextBox)sender).Name == txtDtEmissao.Name)
                    || (((MaskedTextBox)sender).Name == txtDtFechamento.Name)
                    || (((MaskedTextBox)sender).Name == txtDtPrevEntrega.Name))
                {
                    if (!string.IsNullOrEmpty(((MaskedTextBox)sender).Text))
                    {
                        ((MaskedTextBox)sender).TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                        if (!ValidateUtils.isDate(((MaskedTextBox)sender).Text))
                        {
                            MessageBox.Show("Data inválida.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ((MaskedTextBox)sender).Text = string.Empty;
                            e.Cancel = true;
                        }
                        ((MaskedTextBox)sender).TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    }
                }
            }
        }

        private void btnPesquisa_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCliIntegracao.Text))
            {
                Ctrls_Validated(txtCodCliIntegracao, e);
            }
        }

        private void dgvItemPedido_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == col_Quantidade)
            {
                if ((dgvItemPedido[col_Quantidade, e.RowIndex].Value != null) && (dgvItemPedido[col_VlrUnitario, e.RowIndex].Value != null))
                {
                    decimal qtd = Convert.ToDecimal(dgvItemPedido[col_Quantidade, e.RowIndex].Value);
                    decimal vlrUn = Convert.ToDecimal(dgvItemPedido[col_VlrUnitario, e.RowIndex].Value);
                    dgvItemPedido[col_VlrTotal, e.RowIndex].Value = qtd * vlrUn;                    
                }
            }
            if(e.ColumnIndex == col_PercDesconto)
            {
                if ((dgvItemPedido[col_Quantidade, e.RowIndex].Value != null) & (dgvItemPedido[col_VlrUnitario, e.RowIndex].Value != null))
                {
                    decimal qtd = Convert.ToDecimal(dgvItemPedido[col_Quantidade, e.RowIndex].Value);
                    decimal vlrUn = Convert.ToDecimal(dgvItemPedido[col_VlrUnitario, e.RowIndex].Value);
                    decimal percDesc = Convert.ToDecimal(dgvItemPedido[col_PercDesconto, e.RowIndex].Value);
                    decimal vlrTotal = qtd * vlrUn;
                    decimal vlrDesc = (percDesc / 100) * vlrTotal;

                    dgvItemPedido[col_VlrDesconto, e.RowIndex].Value = vlrDesc;
                    dgvItemPedido[col_VlrTotal, e.RowIndex].Value = (vlrTotal - vlrDesc);
                }
            }

            if (e.ColumnIndex == col_VlrUnitario)
            {
                if ((dgvItemPedido[col_Quantidade, e.RowIndex].Value != null) && (dgvItemPedido[col_VlrUnitario, e.RowIndex].Value != null))
                {
                    decimal qtd = Convert.ToDecimal(dgvItemPedido[col_Quantidade, e.RowIndex].Value);
                    decimal vlrUn = Convert.ToDecimal(dgvItemPedido[col_VlrUnitario, e.RowIndex].Value);
                    dgvItemPedido[col_VlrTotal, e.RowIndex].Value = qtd * vlrUn;
                }
            }

            if (e.ColumnIndex == col_VlrDesconto)
            {
                decimal qtd = Convert.ToDecimal(dgvItemPedido[col_Quantidade, e.RowIndex].Value);
                decimal vlrUn = Convert.ToDecimal(dgvItemPedido[col_VlrUnitario, e.RowIndex].Value);
                decimal vlrDesc = Convert.ToDecimal(dgvItemPedido[col_VlrDesconto, e.RowIndex].Value);

                decimal vlrTotal = qtd * vlrUn;

                if (vlrTotal > 0)
                {
                    decimal percDesc = (vlrDesc / vlrTotal) * 100;
                    dgvItemPedido[col_PercDesconto, e.RowIndex].Value = percDesc;
                }

                dgvItemPedido[col_VlrTotal, e.RowIndex].Value = (vlrTotal - vlrDesc);
                
            }

            if (e.ColumnIndex == dgvItemPedido.Columns.Count - 1)
                dgvItemPedido.CurrentCell = dgvItemPedido[col_Codigo, e.RowIndex];
            else
                dgvItemPedido.CurrentCell = dgvItemPedido[e.ColumnIndex + 1, e.RowIndex];
        }

        private void dgvItemPedido_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            string msg = string.Empty;
            if (dgvItemPedido[col_Codigo, e.RowIndex].Value == null)
            {
                msg = msg + "Produto obrigatório";
            }
            else if (dgvItemPedido[col_Quantidade, e.RowIndex].Value == null)
            {
                msg = msg + "Quantidade obrigatório";                
            }
            else if (dgvItemPedido[col_VlrUnitario, e.RowIndex].Value == null)
            {
                msg = msg + "Valor unitário obrigatório";
            }
            else if (dgvItemPedido[col_PercDesconto, e.RowIndex].Value == null)
            {
                msg = msg + "Percentual de desconto obrigatório";
            }

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

        }

        private void dgvItemPedido_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }        
    }
}
