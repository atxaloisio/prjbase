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
    public partial class frmPedido_Otica : prjbase.frmBaseList
    {
        Pedido_OticaBLL Pedido_OticaBLL;

        #region Constante de Colunas da Grid
        private const int col_Id = 0;
        private const int col_email = 1;
        private const int col_nome = 2;
        private const int col_password = 3;
        private const int col_dtCricao = 4;
        private const int col_dtAlteracao = 5;

        #endregion
        public frmPedido_Otica()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmPedidoOtica_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        #region Metodos Sobreescritos

        protected override void InstanciarFormulario()
        {
            frmInstancia = new frmCadEditPedido_Otica();
        }

        protected override void formataColunagridFiltros(DataGridView gridFiltros)
        {
            base.formataColunagridFiltros(gridFiltros);
            //altera o nome das colunas                        
            gridFiltros.Columns.Add("ID", "Id");
            gridFiltros.Columns.Add("EMAIL", "e-Mail");
            gridFiltros.Columns.Add("NOME", "Nome");

            DataGridViewMaskedTextColumn col = new DataGridViewMaskedTextColumn("99/99/9999");
            col.DataPropertyName = "CRIACAO";
            col.HeaderText = "Dt. Criação";
            col.Name = "CRIACAO";
            col.ValueType = typeof(DateTime);
            col.SortMode = DataGridViewColumnSortMode.Programmatic;
            gridFiltros.Columns.Add(col);




            //
            gridFiltros.Columns[0].Width = 50;
            gridFiltros.Columns[0].ValueType = typeof(int);
            gridFiltros.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridFiltros.Columns[1].Width = 200;
            gridFiltros.Columns[1].ValueType = typeof(string);
            gridFiltros.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridFiltros.Columns[2].Width = 200;
            gridFiltros.Columns[2].ValueType = typeof(string);
            gridFiltros.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridFiltros.Columns[3].Width = 200;
            //gridFiltros.Columns[3].ValueType = typeof(DateTime);           
            //gridFiltros.Columns[3].DefaultCellStyle.Format = "dd/mm/YYYY";

            //Adiciona uma linha ao grid.
            gridFiltros.Rows.Add();

            //gridFiltros.Columns[2].Visible = false;            
        }

        protected override void formataColunagridDados(DataGridView gridDados)
        {
            base.formataColunagridDados(gridDados);
            //gridDados.Columns[0].Width = 50;
            //gridDados.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
            //gridDados.Columns[1].Width = 200;
            //gridDados.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
            //gridDados.Columns[2].Width = 200;
            //gridDados.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;
            //gridDados.Columns[3].Visible = false;
            //gridDados.Columns[4].Width = 200;
            //gridDados.Columns[4].SortMode = DataGridViewColumnSortMode.Programmatic;
            //gridDados.Columns[5].Visible = false;
        }

        protected override void carregaConsulta()
        {
            base.carregaConsulta();
            Pedido_OticaBLL = new Pedido_OticaBLL();
            List<Pedido_Otica> Pedido_OticaList = Pedido_OticaBLL.getPedido_Otica(p => p.Id.ToString(), false, deslocamento, tamanhoPagina, out totalReg);
            //List<Pedido_Otica> Pedido_OticaList = Pedido_OticaBLL.getPedido_Otica(p => p.nome.Contains("x"), T => T.Id.ToString(), false, deslocamento, tamanhopagina, out totalreg);
            dgvDados.DataSource = Pedido_OticaList;
            colOrdem = 0;
        }

        protected override void ordenaCelula(object sender, DataGridViewCellMouseEventArgs e)
        {
            base.ordenaCelula(sender, e);
            Pedido_OticaBLL = new Pedido_OticaBLL();

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

            //switch (e.ColumnIndex)
            //{

            //    case 1:
            //        {
            //            List<Pedido_Otica> Pedido_OticaList = Pedido_OticaBLL.getPedido_Otica(p => p.email, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
            //            dgvDados.DataSource = Pedido_OticaList;
            //        }
            //        break;

            //    case 2:
            //        {
            //            List<Pedido_Otica> Pedido_OticaList = Pedido_OticaBLL.getPedido_Otica(p => p.nome, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
            //            dgvDados.DataSource = Pedido_OticaList;
            //        }
            //        break;

            //    case 3:
            //        {
            //            List<Pedido_Otica> Pedido_OticaList = Pedido_OticaBLL.getPedido_Otica(p => p.dtcriacao.ToString(), direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
            //            dgvDados.DataSource = Pedido_OticaList;
            //        }
            //        break;
            //    //O default será executado quando o index for 0
            //    default:
            //        {
            //            List<Pedido_Otica> Pedido_OticaList = Pedido_OticaBLL.getPedido_Otica(p => p.Id.ToString(), direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
            //            dgvDados.DataSource = Pedido_OticaList;
            //        }
            //        break;
            //}

            colOrdem = e.ColumnIndex;

            col.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ?
        SortOrder.Ascending : SortOrder.Descending;

        }

        protected override void executeCellValidatingChild(object sender, DataGridViewCellValidatingEventArgs e)
        {
            base.executeCellValidatingChild(sender, e);

            //if (e.ColumnIndex == 0 && !string.IsNullOrEmpty((string)e.FormattedValue))
            //{
            //    //
            //}

            //if (e.ColumnIndex == 1 && !string.IsNullOrEmpty((string)e.FormattedValue))
            //{
            //    //Executa filtro.                
            //}

            //if (e.ColumnIndex == 2 && !string.IsNullOrEmpty((string)e.FormattedValue))
            //{
            //    //Executa filtro.                
            //}

            //if (e.ColumnIndex == 3 && !string.IsNullOrEmpty((string)e.FormattedValue))
            //{

            //    if ((string.IsNullOrEmpty((string)e.FormattedValue)) || ((string)e.FormattedValue == "__/__/____"))
            //    {
            //        dgvFiltro[e.ColumnIndex, e.RowIndex].Value = "";
            //        return;

            //    }

            //    if (!ValidateUtils.isDate((string)e.FormattedValue))
            //    {
            //        e.Cancel = true;
            //        dgvFiltro[e.ColumnIndex, e.RowIndex].Value = "";
            //        MessageBox.Show("Data inválida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //    else
            //    {
            //        //Executa filtro.
            //    }
            //}
        }

        protected override void executeCellEndEditChild(object sender, DataGridViewCellEventArgs e)
        {
            base.executeCellEndEditChild(sender, e);

            //int id = 0;
            //string email = "";
            //string nome = "";
            //DateTime? data = null;

            //if (!string.IsNullOrEmpty((string)dgvFiltro[0, e.RowIndex].Value))
            //{
            //    id = Convert.ToInt32(dgvFiltro[0, e.RowIndex].Value);
            //}

            //if (!string.IsNullOrEmpty((string)dgvFiltro[1, e.RowIndex].Value))
            //{
            //    email = dgvFiltro[1, e.RowIndex].Value.ToString();
            //}

            //if (!string.IsNullOrEmpty((string)dgvFiltro[2, e.RowIndex].Value))
            //{
            //    nome = dgvFiltro[2, e.RowIndex].Value.ToString();
            //}

            //if (!string.IsNullOrEmpty((string)dgvFiltro[3, e.RowIndex].Value))
            //{
            //    data = Convert.ToDateTime(dgvFiltro[3, e.RowIndex].Value);
            //}

            ////var predicate = PredicateBuilder.True<Pedido_Otica>();


            //Expression<Func<Pedido_Otica, bool>> predicate = p => true;


            //if (id > 0)
            //{
            //    predicate = predicate = p => p.Id == id;
            //}

            //if (!string.IsNullOrEmpty(email))
            //{
            //    predicate = predicate.And(p => p.email.Contains(email));
            //}

            //if (!string.IsNullOrEmpty(nome))
            //{
            //    predicate = predicate.And(p => p.nome.Contains(nome));
            //}

            //if ((data != null) & (ValidateUtils.isDate(data.ToString())))
            //{
            //    predicate = predicate.And(p => DbFunctions.TruncateTime(p.dtcriacao) == DbFunctions.TruncateTime(data));
            //}

            //List<Pedido_Otica> Pedido_OticaList = Pedido_OticaBLL.getPedido_Otica(predicate.Expand(), t => t.Id.ToString(), false, deslocamento, tamanhoPagina, out totalReg);
            //dgvDados.DataSource = Pedido_OticaList;

        }

        protected override void excluirRegistro(int Id)
        {
            base.excluirRegistro(Id);
            Pedido_OticaBLL = new Pedido_OticaBLL();
            try
            {
                if (Convert.ToInt32(dgvDados[0, dgvDados.CurrentRow.Index].Value) > 0)
                {
                    Pedido_Otica Pedido_Otica = Pedido_OticaBLL.Localizar(Convert.ToInt32(dgvDados[0, dgvDados.CurrentRow.Index].Value));
                    if (MessageBox.Show("Deseja realmente excluir o registro : " + Pedido_Otica.Id.ToString() + " - " + Pedido_Otica.cliente.nome_fantasia, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Pedido_OticaBLL.ExcluirPedido_Otica(Pedido_Otica);
                    }

                }
            }
            finally
            {
                Pedido_OticaBLL.Dispose();
            }

        }
        #endregion
    }
}
