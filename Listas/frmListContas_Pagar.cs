using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;
using Model;
using BLL;
using JThomas.Controls;
using Utils;
using LinqKit;


namespace prjbase
{
    public partial class frmListContas_Pagar : prjbase.frmBaseList
    {
        Contas_PagarBLL Contas_PagarBLL;

        public long? Id_filial = null;

        #region Constante de Colunas da Grid
        private const int COL_ID = 0;        
        private const int COL_FORNECEDOR = 1;
        private const int COL_DOCUMENTO = 2;
        private const int COL_VALOR = 3;
        private const int COL_VENCIMENTO = 4;
        private const int COL_PREVISAO = 5;
        private const int COL_PAGAMENTO = 6;
        private const int COL_PAGO = 7;
        
        #endregion

        public frmListContas_Pagar()
        {
            InitializeComponent();            
        }

        private void frmContas_Pagar_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        #region Metodos Sobreescritos

        protected override void setTamanhoPagina()
        {            
            string NrRegPagListagem = Parametro.GetParametro("NrRegPag");
            if (!string.IsNullOrEmpty(NrRegPagListagem))
            {
                tamanhoPagina = Convert.ToInt32(NrRegPagListagem);
            }
        }

        protected override void InstanciarFormulario()
        {
            frmInstancia = new frmCadEditContas_Pagar();
        }

        protected override void formataColunagridFiltros(DataGridView gridFiltros)
        {
            base.formataColunagridFiltros(gridFiltros);
            //altera o nome das colunas                        
            gridFiltros.Columns.Add("ID", "Código");
            gridFiltros.Columns.Add("FORNECEDOR", "Fornecedor");
            gridFiltros.Columns.Add("DOCUMENTO", "Documento");
            gridFiltros.Columns.Add("VALOR", "Valor");

            DataGridViewMaskedTextColumn colVencimento = new DataGridViewMaskedTextColumn("99/99/9999");
            colVencimento.DataPropertyName = "VENCIMENTO";
            colVencimento.HeaderText = "Dt. Vencimento";
            colVencimento.Name = "VENCIMENTO";
            colVencimento.ValueType = typeof(DateTime);
            colVencimento.SortMode = DataGridViewColumnSortMode.Programmatic;
            colVencimento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colVencimento.DefaultCellStyle.Format = "d";
            gridFiltros.Columns.Add(colVencimento);

            DataGridViewMaskedTextColumn colPrevisao = new DataGridViewMaskedTextColumn("99/99/9999");
            colPrevisao.DataPropertyName = "PREVISAO";
            colPrevisao.HeaderText = "Previsão Pagto";
            colPrevisao.Name = "PREVISAO";
            colPrevisao.ValueType = typeof(DateTime);
            colPrevisao.SortMode = DataGridViewColumnSortMode.Programmatic;
            colPrevisao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPrevisao.DefaultCellStyle.Format = "d";
            gridFiltros.Columns.Add(colPrevisao);

            DataGridViewMaskedTextColumn colPagamento = new DataGridViewMaskedTextColumn("99/99/9999");
            colPagamento.DataPropertyName = "PAGAMENTO";
            colPagamento.HeaderText = "Dt. Pagamento";
            colPagamento.Name = "PAGAMENTO";
            colPagamento.ValueType = typeof(DateTime);
            colPagamento.SortMode = DataGridViewColumnSortMode.Programmatic;
            colPagamento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPagamento.DefaultCellStyle.Format = "d";
            gridFiltros.Columns.Add(colPagamento);

            DataGridViewCheckBoxColumn pago = new DataGridViewCheckBoxColumn();
            pago.HeaderText = "Pago";
            pago.Name = "PAGO";
            pago.TrueValue = true;
            pago.FalseValue = false;
            pago.ThreeState = true;                    
            gridFiltros.Columns.Add(pago);
                       
           
            gridFiltros.Columns[COL_ID].Width = 70;
            gridFiltros.Columns[COL_ID].ValueType = typeof(int);
            gridFiltros.Columns[COL_ID].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridFiltros.Columns[COL_ID].Visible = false;

            gridFiltros.Columns[COL_FORNECEDOR].Width = 300;
            gridFiltros.Columns[COL_FORNECEDOR].ValueType = typeof(string);
            gridFiltros.Columns[COL_FORNECEDOR].SortMode = DataGridViewColumnSortMode.Programmatic;            

            gridFiltros.Columns[COL_DOCUMENTO].Width = 200;
            gridFiltros.Columns[COL_DOCUMENTO].ValueType = typeof(string);
            gridFiltros.Columns[COL_DOCUMENTO].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridFiltros.Columns[COL_VALOR].Width = 100;
            gridFiltros.Columns[COL_VALOR].ValueType = typeof(decimal);
            gridFiltros.Columns[COL_VALOR].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridFiltros.Columns[COL_VALOR].DefaultCellStyle.Format = "N2";

            gridFiltros.Columns[COL_VENCIMENTO].Width = 150;
            gridFiltros.Columns[COL_PREVISAO].Width = 150;
            gridFiltros.Columns[COL_PAGAMENTO].Width = 150;

            gridFiltros.Columns[COL_PAGO].Width = 60;
            gridFiltros.Columns[COL_PAGO].ValueType = typeof(bool);
            gridFiltros.Columns[COL_PAGO].SortMode = DataGridViewColumnSortMode.Programmatic;
            
            gridFiltros.CellContentClick += new DataGridViewCellEventHandler(gridFiltros_CellContentClick);

            //Adiciona uma linha ao grid.
            gridFiltros.Rows.Add();
                       
        }

        private void gridFiltros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == COL_PAGO)
            {
                executeCellEndEditChild(sender, e);
            }
        }
               
        protected override void formataColunagridDados(DataGridView gridDados)
        {
            base.formataColunagridDados(gridDados);
            gridDados.Columns[COL_ID].Width = 70;
            gridDados.Columns[COL_ID].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridDados.Columns[COL_ID].Visible = false;

            gridDados.Columns[COL_FORNECEDOR].Width = 300;
            gridDados.Columns[COL_FORNECEDOR].SortMode = DataGridViewColumnSortMode.Programmatic;
            
            gridDados.Columns[COL_DOCUMENTO].Width = 200;
            gridDados.Columns[COL_DOCUMENTO].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridDados.Columns[COL_VALOR].Width = 100;
            gridDados.Columns[COL_VALOR].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridDados.Columns[COL_VENCIMENTO].Width = 150;
            gridDados.Columns[COL_VENCIMENTO].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridDados.Columns[COL_PREVISAO].Width = 150;
            gridDados.Columns[COL_PREVISAO].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridDados.Columns[COL_PAGAMENTO].Width = 150;
            gridDados.Columns[COL_PAGAMENTO].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridDados.Columns[COL_PAGO].Width = 60;
            gridDados.Columns[COL_PAGO].SortMode = DataGridViewColumnSortMode.Programmatic;            
        }

        protected override void carregaConsulta()
        {
            base.carregaConsulta();
            Contas_PagarBLL = new Contas_PagarBLL();
            List<Contas_Pagar> lstContas_Pagar = null;
            
            if (Id_filial != null)
            {
                lstContas_Pagar = Contas_PagarBLL.getContas_Pagar(p=>p.Id_filial == Id_filial, false, deslocamento, tamanhoPagina, out totalReg, c => c.Id.ToString());
            }
            else
            {
                lstContas_Pagar = Contas_PagarBLL.getContas_Pagar(p => p.Id.ToString(), false, deslocamento, tamanhoPagina, out totalReg);
            }

            
            dgvDados.DataSource = Contas_PagarBLL.ToList_Contas_PagarView(lstContas_Pagar);
            colOrdem = 0;
        }

        protected override void ordenaCelula(object sender, DataGridViewCellMouseEventArgs e)
        {
            base.ordenaCelula(sender, e);
            Contas_PagarBLL = new Contas_PagarBLL();

            DataGridViewColumn col = dgvFiltro.Columns[e.ColumnIndex];
            DataGridViewColumn colAnt = dgvFiltro.Columns[colOrdem];

            ListSortDirection direction;

            switch (col.HeaderCell.SortGlyphDirection)
            {
                case SortOrder.None:
                    direction = ListSortDirection.Ascending;
                    break;
                case SortOrder.Ascending:
                    direction = ListSortDirection.Ascending;
                    break;
                case SortOrder.Descending:
                    direction = ListSortDirection.Descending;
                    break;
                default:
                    direction = ListSortDirection.Ascending;
                    break;
            }


            if (colOrdem == e.ColumnIndex)
            {
                if (direction == ListSortDirection.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    col.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
                colAnt.HeaderCell.SortGlyphDirection = SortOrder.None;
            }

            switch (e.ColumnIndex)
            {
                case COL_FORNECEDOR:
                    {
                        List<Contas_Pagar> Contas_PagarList = null;
                        if (Id_filial != null)
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.Id_filial == Id_filial, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c => c.cliente.razao_social);
                        }
                        else
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.cliente.razao_social, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        }

                        dgvDados.DataSource = Contas_PagarBLL.ToList_Contas_PagarView(Contas_PagarList);
                    }
                    break;

                case COL_DOCUMENTO:
                    {
                        List<Contas_Pagar> Contas_PagarList = null;
                        if (Id_filial != null)
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.Id_filial == Id_filial, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c=>c.Documento);
                        }
                        else
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.Documento, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        }
                        
                        dgvDados.DataSource = Contas_PagarBLL.ToList_Contas_PagarView(Contas_PagarList);
                    }
                    break;

                case COL_VALOR:
                    {
                        List<Contas_Pagar> Contas_PagarList = null;
                        if (Id_filial != null)
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.Id_filial == Id_filial, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c => c.valor.ToString());
                        }
                        else
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.valor.ToString(), direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        }

                        dgvDados.DataSource = Contas_PagarBLL.ToList_Contas_PagarView(Contas_PagarList);
                    }
                    break;

                case COL_VENCIMENTO:
                    {
                        List<Contas_Pagar> Contas_PagarList = null;
                        if (Id_filial != null)
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.Id_filial == Id_filial, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c => c.vencimento.ToString());
                        }
                        else
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.vencimento.ToString(), direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        }

                        dgvDados.DataSource = Contas_PagarBLL.ToList_Contas_PagarView(Contas_PagarList);
                    }
                    break;

                case COL_PREVISAO:
                    {
                        List<Contas_Pagar> Contas_PagarList = null;
                        if (Id_filial != null)
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.Id_filial == Id_filial, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c => c.previsao.ToString());
                        }
                        else
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.previsao.ToString(), direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        }

                        dgvDados.DataSource = Contas_PagarBLL.ToList_Contas_PagarView(Contas_PagarList);
                    }
                    break;

                case COL_PAGAMENTO:
                    {
                        List<Contas_Pagar> Contas_PagarList = null;
                        if (Id_filial != null)
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.Id_filial == Id_filial, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c => c.pagamento.ToString());
                        }
                        else
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.pagamento.ToString(), direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        }

                        dgvDados.DataSource = Contas_PagarBLL.ToList_Contas_PagarView(Contas_PagarList);
                    }
                    break;

                case COL_PAGO:
                    {
                        List<Contas_Pagar> Contas_PagarList = null;
                        if (Id_filial != null)
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.Id_filial == Id_filial, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c => c.pago);
                        }
                        else
                        {
                            Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.pago, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        }

                        dgvDados.DataSource = Contas_PagarBLL.ToList_Contas_PagarView(Contas_PagarList);
                    }
                    break;

                //O default será executado quando o index for 0
                default:
                    {
                        List<Contas_Pagar> Contas_PagarList = Contas_PagarBLL.getContas_Pagar(p => p.Id.ToString(), direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        dgvDados.DataSource = Contas_PagarList;
                    }
                    break;
            }

            colOrdem = e.ColumnIndex;

            col.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ?
        SortOrder.Ascending : SortOrder.Descending;

        }

        protected override void executeCellValidatingChild(object sender, DataGridViewCellValidatingEventArgs e)
        {
            base.executeCellValidatingChild(sender, e);                      
        }

        protected override void executeCellEndEditChild(object sender, DataGridViewCellEventArgs e)
        {
            base.executeCellEndEditChild(sender, e);

            int id = 0;
            string fornecedor = string.Empty;
            string documento = string.Empty;
            decimal? valor = null;
            DateTime? vencimento = null;
            DateTime? previsao = null;
            DateTime? pagamento = null;
            string pago = string.Empty;
            

            if (dgvFiltro[COL_ID, e.RowIndex].Value != null)
            {
                id = Convert.ToInt32(dgvFiltro[COL_ID, e.RowIndex].Value);
            }

            if (dgvFiltro[COL_FORNECEDOR, e.RowIndex].Value != null)
            {
                fornecedor = dgvFiltro[COL_FORNECEDOR, e.RowIndex].Value.ToString();
            }

            if (dgvFiltro[COL_DOCUMENTO, e.RowIndex].Value!= null)
            {
                documento = dgvFiltro[COL_DOCUMENTO, e.RowIndex].Value.ToString();
            }

            if (!string.IsNullOrEmpty((string)dgvFiltro[COL_VENCIMENTO, e.RowIndex].Value))
            {
                if (dgvFiltro[COL_VENCIMENTO, e.RowIndex].Value.ToString() != "__/__/____")
                {
                    if (ValidateUtils.isDate((string)dgvFiltro[COL_VENCIMENTO, e.RowIndex].Value.ToString()))
                    {
                        vencimento = Convert.ToDateTime(dgvFiltro[COL_VENCIMENTO, e.RowIndex].Value);
                    }
                }
            }

            if (!string.IsNullOrEmpty((string)dgvFiltro[COL_PREVISAO, e.RowIndex].Value))
            {
                if (dgvFiltro[COL_PREVISAO, e.RowIndex].Value.ToString() != "__/__/____")
                {
                    if (ValidateUtils.isDate((string)dgvFiltro[COL_PREVISAO, e.RowIndex].Value.ToString()))
                    {
                        previsao = Convert.ToDateTime(dgvFiltro[COL_PREVISAO, e.RowIndex].Value);
                    }
                }
            }

            if (!string.IsNullOrEmpty((string)dgvFiltro[COL_PAGAMENTO, e.RowIndex].Value))
            {
                if (dgvFiltro[COL_PAGAMENTO, e.RowIndex].Value.ToString() != "__/__/____")
                {
                    if (ValidateUtils.isDate((string)dgvFiltro[COL_PAGAMENTO, e.RowIndex].Value.ToString()))
                    {
                        pagamento = Convert.ToDateTime(dgvFiltro[COL_PAGAMENTO, e.RowIndex].Value);
                    }
                }
            }

            if (dgvFiltro[COL_VALOR, e.RowIndex].Value != null)
            {
                valor = Convert.ToDecimal(dgvFiltro[COL_VALOR, e.RowIndex].Value);
            }

            if (e.ColumnIndex == COL_PAGO)
            {
                DataGridViewCheckBoxCell cell = dgvFiltro.CurrentCell as DataGridViewCheckBoxCell;                
                if (cell != null)
                {
                    CheckState value = (CheckState)cell.EditedFormattedValue;
                    switch (value)
                    {
                        case CheckState.Checked:
                            pago = "S";
                            break;
                        case CheckState.Unchecked:
                            pago = "N";
                            break;
                        default:
                            pago = string.Empty;
                            break;
                    }
                }                
            }

            Expression<Func<Contas_Pagar, bool>> predicate = p => true;


            if (id > 0)
            {
                predicate = predicate = p => p.Id == id;
            }

            if (!string.IsNullOrEmpty(fornecedor))
            {
                predicate = predicate.And(p => p.cliente.nome_fantasia.ToLower().Contains(fornecedor.ToLower()));
            }

            if (!string.IsNullOrEmpty(documento))
            {
                predicate = predicate.And(p => p.Documento.Contains(documento));
            }

            if ((vencimento != null) & (ValidateUtils.isDate(vencimento.ToString())))
            {
                predicate = predicate.And(p => DbFunctions.TruncateTime(p.vencimento) == DbFunctions.TruncateTime(vencimento));
            }

            if ((previsao != null) & (ValidateUtils.isDate(previsao.ToString())))
            {
                predicate = predicate.And(p => DbFunctions.TruncateTime(p.previsao) == DbFunctions.TruncateTime(previsao));
            }

            if ((pagamento != null) & (ValidateUtils.isDate(pagamento.ToString())))
            {
                predicate = predicate.And(p => DbFunctions.TruncateTime(p.pagamento) == DbFunctions.TruncateTime(pagamento));
            }

            if ((valor != null))
            {
                predicate = predicate.And(p => p.valor == valor);
            }
            
            if (!string.IsNullOrEmpty(pago))
            {
                predicate = predicate.And(p => p.pago == pago);
            }

            if (Id_filial != null)
            {
                predicate = predicate.And(p => p.Id_filial == Id_filial);
            }

            List<Contas_Pagar> Contas_PagarList = Contas_PagarBLL.getContas_Pagar(predicate.Expand(), t => t.Id.ToString(), false, deslocamento, tamanhoPagina, out totalReg);
            dgvDados.DataSource = Contas_PagarBLL.ToList_Contas_PagarView(Contas_PagarList);

        }

        protected override void excluirRegistro(int Id)
        {
            base.excluirRegistro(Id);
            Contas_PagarBLL = new Contas_PagarBLL();
            try
            {
                if (Convert.ToInt32(dgvDados[0, dgvDados.CurrentRow.Index].Value) > 0)
                {
                    Contas_Pagar Contas_Pagar = Contas_PagarBLL.Localizar(Convert.ToInt32(dgvDados[0, dgvDados.CurrentRow.Index].Value));
                    if (MessageBox.Show("Deseja realmente excluir o registro : " + Contas_Pagar.Id.ToString() + " - " + Contas_Pagar.Documento, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Contas_PagarBLL.ExcluirContas_Pagar(Contas_Pagar);
                    }

                }
            }
            finally
            {
                Contas_PagarBLL.Dispose();
            }

        }
        #endregion
                
    }
}
