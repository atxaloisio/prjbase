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
    public partial class frmCadEditProduto : prjbase.frmBaseCadEdit
    {
        private ProdutoBLL ProdutoBLL;

        #region Constante de Colunas da Grid de Movimentações do estoque
        private const int COL_ID = 0;
        private const int COL_IDPRODUTO = 1;
        private const int COL_DATA = 2;
        private const int COL_ORIGEM = 3;        
        private const int COL_QUANTIDADE = 4;
        private const int COL_VALOR = 5;
        private const int COL_SALDO = 6;
        private const int COL_CMCUNITARIO = 7;        
        private const int COL_CMCTOTAL = 8;

        #endregion

        public frmCadEditProduto()
        {
            InitializeComponent();            
        }

        protected override void LoadToControls()
        {
            if (Id != null)
            {
                ProdutoBLL = new ProdutoBLL();

                Produto Produto = ProdutoBLL.Localizar(Id);

                if (Produto != null)
                {
                    txtId.Text = Produto.id.ToString();
                    txtCodigo.Text = Produto.codigo;
                    txtCodigoOmie.Text = Produto.codigo_produto.ToString();
                    txtCodInt.Text = Produto.codigo_produto_integracao;
                    txtDescricao.Text = Produto.descricao;
                    txtPrecoUnitario.Text = Produto.valor_unitario.Value.ToString("N2");
                    txtNCM.Text = Produto.ncm;
                    txtEAN.Text = Produto.ean;
                    cbUnidade.Text = Produto.unidade;
                    cbFamiliaProduto.Text = Produto.descricao_familia;
                    txtPesoLiquido.Text = Produto.peso_liq.ToString();
                    txtPesoBruto.Text = Produto.peso_bruto.ToString();
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
                    ProdutoBLL = new ProdutoBLL();
                    ProdutoBLL.UsuarioLogado = Program.usuario_logado;
                    ProdutoProxy proxy = new ProdutoProxy();

                    Produto Produto = LoadFromControls();
                    Produto.sincronizar = "S";

                    bool IntOmie = Convert.ToBoolean(Parametro.GetParametro("intOmie"));
                    bool updateProdutoOmie = Convert.ToBoolean(Parametro.GetParametro("updateProdutoOmie"));

                    if (Id != null)
                    {                        
                        ProdutoBLL.AlterarProduto(Produto);                        
                    }
                    else
                    {
                        Produto.codigo_produto_integracao = Sequence.GetNextVal("sq_produto_sequence").ToString();
                        ProdutoBLL.AdicionarProduto(Produto);                                                
                    }

                    if (IntOmie & updateProdutoOmie)
                    {
                        if (Produto.codigo_produto == 0)
                        {
                            proxy.IncluirProduto(Produto);
                        }
                        else
                        {
                            proxy.AlterarProduto(Produto);
                        }
                    }



                        if (Produto.id != 0)
                    {
                        txtCodInt.Text = Produto.codigo_produto_integracao;
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

        protected virtual Produto LoadFromControls()
        {
            Produto Produto = new Produto();
            ProdutoBLL = new ProdutoBLL();

            if (Id != null)
            {
                Produto = ProdutoBLL.getProduto(Convert.ToInt64(Id),true).FirstOrDefault();
            }

            Produto.codigo = txtCodigo.Text;
            Produto.descricao = txtDescricao.Text;
            Produto.ncm = txtNCM.Text;
            Produto.peso_liq = Convert.ToDecimal(txtPesoLiquido.Text);
            Produto.peso_bruto = Convert.ToDecimal(txtPesoBruto.Text);
            Produto.valor_unitario = Convert.ToDecimal(txtPrecoUnitario.Text);

            if (cbUnidade.SelectedValue != null)
            {
                Produto.unidade = cbUnidade.SelectedValue.ToString();
            }

            if (cbFamiliaProduto.SelectedValue != null)
            {
                Familia_Produto fp = (Familia_Produto)cbFamiliaProduto.SelectedValue;
                Produto.id_familia = fp.Id;
                Produto.codigo_familia = fp.codigo;
                Produto.descricao_familia = fp.nomeFamilia;
            }

            Produto.descr_detalhada = txtDescDetProd.Text;
            
            return Produto;
        }

        protected override void SetupControls()
        {
            SetupUnidade();
            SetupFamiliaProduto();
            formataGridMovEstoque();
        }

        private void SetupFamiliaProduto()
        {
            Familia_ProdutoBLL familia_ProdutoBLL = new Familia_ProdutoBLL();
            List<Familia_Produto> fpList = familia_ProdutoBLL.getFamilia_Produto();
            cbFamiliaProduto.DataSource = fpList;

            AutoCompleteStringCollection acc = new AutoCompleteStringCollection();
            foreach (Familia_Produto item in fpList)
            {
                acc.Add(item.nomeFamilia);
            }

            cbFamiliaProduto.DisplayMember = "nomeFamilia";
            cbFamiliaProduto.ValueMember = "Id";
            cbFamiliaProduto.SelectedIndex = -1;
        }

        private void SetupUnidade()
        {
            UnidadeBLL unidadeBLL = new UnidadeBLL();
            List<Unidade> unList = unidadeBLL.getUnidade();
            cbUnidade.DataSource = unList;

            AutoCompleteStringCollection acc = new AutoCompleteStringCollection();
            foreach (Unidade item in unList)
            {
                acc.Add(item.codigo);
            }

            cbUnidade.DisplayMember = "codigo";
            cbUnidade.ValueMember = "codigo";
            cbUnidade.SelectedIndex = -1;
        }

        private void formataGridMovEstoque()
        {            
            dgvMovEstoque.AutoGenerateColumns = false;
            dgvMovEstoque.ColumnHeadersVisible = true;
            dgvMovEstoque.RowHeadersVisible = false;
            dgvMovEstoque.ReadOnly = true;
            dgvMovEstoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvMovEstoque.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            dgvMovEstoque.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvMovEstoque.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            formataColunadgvMovEstoque();
            //seleciona a linha inteira
            dgvMovEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //não permite seleção de multiplas linhas
            dgvMovEstoque.MultiSelect = false;
            // exibe nulos formatados
            dgvMovEstoque.DefaultCellStyle.NullValue = " - ";
            //permite que o texto maior que célula não seja truncado
            dgvMovEstoque.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMovEstoque.DefaultCellStyle.Font = new Font("Tahoma", 10F, FontStyle.Regular);

            dgvMovEstoque.CellDoubleClick += new DataGridViewCellEventHandler(dgvDados_CellDoubleClick);
            
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void formataColunadgvMovEstoque()
        {
            //altera o nome das colunas                        
            dgvMovEstoque.Columns.Add("ID", "Código");
            dgvMovEstoque.Columns.Add("ID_PRODUTO", "Produto");
            dgvMovEstoque.Columns.Add("DATA", "Data");
            dgvMovEstoque.Columns.Add("ORIGEM", "Origem");
            dgvMovEstoque.Columns.Add("QUANTIDADE", "Quantidade");
            dgvMovEstoque.Columns.Add("VALOR", "Valor");
            dgvMovEstoque.Columns.Add("SALDO", "Saldo Acumulado");
            dgvMovEstoque.Columns.Add("CMCUNITARIO", "CMC Unitário");
            dgvMovEstoque.Columns.Add("CMCTOTAL", "CMC Total");


            dgvMovEstoque.Columns[COL_ID].Width = 70;
            dgvMovEstoque.Columns[COL_ID].ValueType = typeof(int);
            dgvMovEstoque.Columns[COL_ID].SortMode = DataGridViewColumnSortMode.Programmatic;
            dgvMovEstoque.Columns[COL_ID].Visible = false;


            dgvMovEstoque.Columns[COL_IDPRODUTO].Width = 200;
            dgvMovEstoque.Columns[COL_IDPRODUTO].ValueType = typeof(int);
            dgvMovEstoque.Columns[COL_IDPRODUTO].SortMode = DataGridViewColumnSortMode.Programmatic;
            dgvMovEstoque.Columns[COL_IDPRODUTO].Visible = false;

            dgvMovEstoque.Columns[COL_DATA].Width = 100;
            dgvMovEstoque.Columns[COL_DATA].ValueType = typeof(DateTime);
            dgvMovEstoque.Columns[COL_DATA].SortMode = DataGridViewColumnSortMode.Programmatic;

            dgvMovEstoque.Columns[COL_ORIGEM].Width = 200;
            dgvMovEstoque.Columns[COL_ORIGEM].ValueType = typeof(string);
            dgvMovEstoque.Columns[COL_ORIGEM].SortMode = DataGridViewColumnSortMode.Programmatic;

            dgvMovEstoque.Columns[COL_QUANTIDADE].Width = 120;
            dgvMovEstoque.Columns[COL_QUANTIDADE].ValueType = typeof(string);
            dgvMovEstoque.Columns[COL_QUANTIDADE].SortMode = DataGridViewColumnSortMode.Programmatic;
            
            dgvMovEstoque.Columns[COL_VALOR].Width = 120;
            dgvMovEstoque.Columns[COL_VALOR].ValueType = typeof(decimal);
            dgvMovEstoque.Columns[COL_VALOR].SortMode = DataGridViewColumnSortMode.Programmatic;
            dgvMovEstoque.Columns[COL_VALOR].DefaultCellStyle.Format = "N2";
            dgvMovEstoque.Columns[COL_VALOR].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvMovEstoque.Columns[COL_SALDO].Width = 180;
            dgvMovEstoque.Columns[COL_SALDO].ValueType = typeof(decimal);
            dgvMovEstoque.Columns[COL_SALDO].SortMode = DataGridViewColumnSortMode.Programmatic;
            dgvMovEstoque.Columns[COL_SALDO].DefaultCellStyle.Format = "N2";
            dgvMovEstoque.Columns[COL_SALDO].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvMovEstoque.Columns[COL_CMCUNITARIO].Width = 120;
            dgvMovEstoque.Columns[COL_CMCUNITARIO].ValueType = typeof(decimal);
            dgvMovEstoque.Columns[COL_CMCUNITARIO].SortMode = DataGridViewColumnSortMode.Programmatic;
            dgvMovEstoque.Columns[COL_CMCUNITARIO].DefaultCellStyle.Format = "N2";
            dgvMovEstoque.Columns[COL_CMCUNITARIO].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvMovEstoque.Columns[COL_CMCTOTAL].Width = 120;
            dgvMovEstoque.Columns[COL_CMCTOTAL].ValueType = typeof(decimal);
            dgvMovEstoque.Columns[COL_CMCTOTAL].SortMode = DataGridViewColumnSortMode.Programmatic;
            dgvMovEstoque.Columns[COL_CMCTOTAL].DefaultCellStyle.Format = "N2";
            dgvMovEstoque.Columns[COL_CMCTOTAL].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            //Adiciona uma linha ao grid.
            //dgvMovEstoque.Rows.Add();
        }

        protected override void Limpar(Control control)
        {
            base.Limpar(control);

            txtCodigo.Focus();
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) & (e.KeyChar != 8) & (!e.KeyChar.Equals(',')))
            {
                e.Handled = true;
            }
        }

        private void OnlyNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                ((TextBox)sender).Text = Convert.ToDecimal(((TextBox)sender).Text).ToString("N2");
            }
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}

