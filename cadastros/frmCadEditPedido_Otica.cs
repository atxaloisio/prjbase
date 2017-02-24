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
    public partial class frmCadEditPedido_Otica : prjbase.frmBaseCadEdit
    {
        private ClienteBLL clienteBLL;
        private ProdutoBLL produtoBLL;
        private FormasPagVendaBLL formasPagVendaBLL;
        private Motivo_EntregaBLL motivo_EntregaBLL;

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
            if (epValidaDados.Validar())
            {

                
                return true;
            }
            else
            {
                return false;
            }
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
            formataGridItens();
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
                        dgvItemPedido.CurrentCell = dgvItemPedido[iColumn + 1, iRow];
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                if (dgvItemPedido.CurrentCell != null)
                {
                    int iColumn = dgvItemPedido.CurrentCell.ColumnIndex;
                    int iRow = dgvItemPedido.CurrentCell.RowIndex;

                    dgvItemPedido[iColumn, iRow].Value = "";
                }
            }
        }        

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            dgvItemPedido.Rows.Add();            
            dgvItemPedido.Focus();
            if (dgvItemPedido.Rows.Count > 0)
            {
                dgvItemPedido.CurrentCell = dgvItemPedido.Rows[dgvItemPedido.Rows.Count - 1].Cells[col_Codigo];
            }
            SendKeys.Send("{DOWN}");
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
                        txtIdCliente.Text = cliente.Id.ToString();
                        txtCodCliIntegracao.Text = cliente.codigo_cliente_integracao;
                        txtClienteNome.Text = cliente.nome_fantasia;
                        txtDtEmissao.Focus();
                    }
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
            if (!Char.IsNumber(e.KeyChar)) 
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

        private void dgvItemPedido_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dgvItemPedido_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int coluna = dgvItemPedido.CurrentCell.ColumnIndex;
            int linha = dgvItemPedido.CurrentCell.RowIndex;

            if (coluna == col_Quantidade)
            {
                if ((dgvItemPedido[coluna, linha].Value != null) && (dgvItemPedido[col_VlrUnitario, linha].Value != null))
                {
                    decimal qtd = Convert.ToDecimal(dgvItemPedido[col_Quantidade, linha].Value);
                    decimal vlrUn = Convert.ToDecimal(dgvItemPedido[col_VlrUnitario, linha].Value);
                    dgvItemPedido[col_VlrTotal, linha].Value = qtd * vlrUn;
                }
            }

            if (coluna == col_VlrUnitario)
            {                
                if ((dgvItemPedido[coluna, linha].Value != null) && (dgvItemPedido[col_VlrUnitario, linha].Value != null))
                {
                    decimal qtd = Convert.ToDecimal(dgvItemPedido[col_Quantidade, linha].Value);
                    decimal vlrUn = Convert.ToDecimal(dgvItemPedido[col_VlrUnitario, linha].Value);
                    dgvItemPedido[col_VlrTotal, linha].Value = qtd * vlrUn;
                }
            }

            if (coluna == col_PercDesconto)
            {
                decimal qtd = Convert.ToDecimal(dgvItemPedido[col_Quantidade, linha].Value);
                decimal vlrUn = Convert.ToDecimal(dgvItemPedido[col_VlrUnitario, linha].Value);
                decimal percDesc = Convert.ToDecimal(dgvItemPedido[col_PercDesconto, linha].Value);

                if (percDesc > 100)
                {
                    dgvItemPedido[col_PercDesconto, linha].Value = 100;
                }

                if (percDesc < 0)
                {
                    dgvItemPedido[col_PercDesconto, linha].Value = 0;
                }

                decimal vlrTotal = qtd * vlrUn;
                decimal vlrDesc = (percDesc / 100) * vlrTotal;

                dgvItemPedido[col_VlrDesconto, linha].Value = vlrDesc;
                dgvItemPedido[col_VlrTotal, linha].Value = (vlrTotal - vlrDesc);
            }

            if (coluna == col_VlrDesconto)
            {
                decimal qtd = Convert.ToDecimal(dgvItemPedido[col_Quantidade, linha].Value);
                decimal vlrUn = Convert.ToDecimal(dgvItemPedido[col_VlrUnitario, linha].Value);
                
                decimal vlrTotal = qtd * vlrUn;
                decimal vlrDesc = Convert.ToDecimal(dgvItemPedido[col_VlrDesconto, linha].Value);

                if (vlrTotal > 0)
                {
                    decimal percDesc = (vlrDesc / vlrTotal) * 100;
                    dgvItemPedido[col_PercDesconto, linha].Value = percDesc;
                }             
                                
                dgvItemPedido[col_VlrTotal, linha].Value = (vlrTotal - vlrDesc);
            }            
        }

        private void eixo_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(txtod_eixo.Text) > 180)
            {
                MessageBox.Show("Eixo não pode ser superior a 180°", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtod_eixo.Text = "0";
                e.Cancel = true;
            }

            if (Convert.ToInt32(txtod_eixo.Text) < 0)
            {
                MessageBox.Show("Eixo não pode ser inferior a 0°", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtod_eixo.Text = "0";
                e.Cancel = true;
            }
        }

        protected override void Limpar(Control control)
        {
            base.Limpar(control);
            txtCodigo.Focus();
        }
    }
}
