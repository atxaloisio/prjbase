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
    public partial class frmListUsuarios : prjbase.frmBaseList
    {
        UsuarioBLL usuarioBLL;

        #region Constante de Colunas da Grid
        private const int COL_ID = 0;
        private const int COL_EMAIL = 1;
        private const int COL_NOME = 2;
        private const int COL_PASSWORD = 3;
        private const int COL_PERFIL = 4;
        private const int COL_DTINCLUSAO = 5;
        private const int COL_USINCLUSAO = 6;
        private const int COL_DTALTERACAO = 7;
        private const int COL_USALTERACAO = 8;
        private const int COL_INTATIVO = 9;

        #endregion

        public frmListUsuarios()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }
        
        private void frmUsuarios_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        #region Metodos Sobreescritos

        protected override void InstanciarFormulario()
        {
            frmInstancia = new frmCadEditUsuario();
            frmInstancia.Tag = Tag;
        }

        protected override void formataColunagridFiltros(DataGridView gridFiltros)
        {
            base.formataColunagridFiltros(gridFiltros);
            //altera o nome das colunas                        
            gridFiltros.Columns.Add("ID", "Id");
            gridFiltros.Columns.Add("EMAIL", "e-Mail");
            gridFiltros.Columns.Add("NOME", "Nome");
            gridFiltros.Columns.Add("PASSWORD", "Password");
            gridFiltros.Columns.Add("PERFIL", "Perfil");

            DataGridViewMaskedTextColumn col = new DataGridViewMaskedTextColumn("99/99/9999");
            col.DataPropertyName = "CRIACAO";
            col.HeaderText = "Dt. Criação";
            col.Name = "CRIACAO";
            col.ValueType = typeof(DateTime);
            col.SortMode = DataGridViewColumnSortMode.Programmatic;
            gridFiltros.Columns.Add(col);


            

            //
            gridFiltros.Columns[COL_ID].Width = 50;
            gridFiltros.Columns[COL_ID].ValueType = typeof(int);
            gridFiltros.Columns[COL_ID].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridFiltros.Columns[COL_EMAIL].Width = 200;
            gridFiltros.Columns[COL_EMAIL].ValueType = typeof(string);
            gridFiltros.Columns[COL_EMAIL].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridFiltros.Columns[COL_NOME].Width = 200;
            gridFiltros.Columns[COL_NOME].ValueType = typeof(string);
            gridFiltros.Columns[COL_NOME].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridFiltros.Columns[COL_PASSWORD].Visible = false;
            

            //Adiciona uma linha ao grid.
            gridFiltros.Rows.Add();

            //gridFiltros.Columns[2].Visible = false;            
        }

        protected override void formataColunagridDados(DataGridView gridDados)
        {
            base.formataColunagridDados(gridDados);
            gridDados.Columns[0].Width = 50;
            gridDados.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridDados.Columns[1].Width = 200;
            gridDados.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridDados.Columns[2].Width = 200;
            gridDados.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridDados.Columns[3].Visible = false;
            gridDados.Columns[4].Visible = false;
            gridDados.Columns[5].Width = 200;
            gridDados.Columns[5].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridDados.Columns[6].Width = 200;
            gridDados.Columns[6].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridDados.Columns[7].Width = 200;
            gridDados.Columns[7].SortMode = DataGridViewColumnSortMode.Programmatic;

        }

        protected override void carregaConsulta()
        {
            base.carregaConsulta();
            usuarioBLL = new UsuarioBLL();
            List<Usuario> usuarioList = usuarioBLL.getUsuario(p => p.Id.ToString(), false, deslocamento, tamanhoPagina, out totalReg);
            //List<Usuario> usuarioList = usuarioBLL.getUsuario(p => p.nome.Contains("x"), T => T.Id.ToString(), false, deslocamento, tamanhopagina, out totalreg);
            dgvDados.DataSource = usuarioList;
            colOrdem = 0;
        }

        protected override void ordenaCelula(object sender, DataGridViewCellMouseEventArgs e)
        {
            base.ordenaCelula(sender, e);
            usuarioBLL = new UsuarioBLL();

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

                case 1:
                    {
                        List<Usuario> usuarioList = usuarioBLL.getUsuario(p => p.email, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        dgvDados.DataSource = usuarioList;
                    }
                    break;

                case 2:
                    {
                        List<Usuario> usuarioList = usuarioBLL.getUsuario(p => p.nome, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        dgvDados.DataSource = usuarioList;
                    }
                    break;

                case 3:
                    {
                        List<Usuario> usuarioList = usuarioBLL.getUsuario(p => p.inclusao.ToString(), direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        dgvDados.DataSource = usuarioList;
                    }
                    break;
                //O default será executado quando o index for 0
                default:
                    {
                        List<Usuario> usuarioList = usuarioBLL.getUsuario(p => p.Id.ToString(), direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        dgvDados.DataSource = usuarioList;
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

            if (e.ColumnIndex == 0 && !string.IsNullOrEmpty((string)e.FormattedValue))
            {
                //
            }

            if (e.ColumnIndex == 1 && !string.IsNullOrEmpty((string)e.FormattedValue))
            {
                //Executa filtro.                
            }

            if (e.ColumnIndex == 2 && !string.IsNullOrEmpty((string)e.FormattedValue))
            {
                //Executa filtro.                
            }

            if (e.ColumnIndex == 3 && !string.IsNullOrEmpty((string)e.FormattedValue))
            {

                if ((string.IsNullOrEmpty((string)e.FormattedValue)) || ((string)e.FormattedValue == "__/__/____"))
                {
                    dgvFiltro[e.ColumnIndex, e.RowIndex].Value = "";
                    return;

                }

                if (!ValidateUtils.isDate((string)e.FormattedValue))
                {
                    e.Cancel = true;
                    dgvFiltro[e.ColumnIndex, e.RowIndex].Value = "";
                    MessageBox.Show("Data inválida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Executa filtro.
                }                
            }            
        }

        protected override void executeCellEndEditChild(object sender, DataGridViewCellEventArgs e)
        {
            base.executeCellEndEditChild(sender, e);

            int id = 0;
            string email = "";
            string nome = "";
            DateTime? data = null;

            if (!string.IsNullOrEmpty((string)dgvFiltro[0, e.RowIndex].Value))
            {
                id = Convert.ToInt32(dgvFiltro[0, e.RowIndex].Value);
            }

            if (!string.IsNullOrEmpty((string)dgvFiltro[1, e.RowIndex].Value))
            {
                email = dgvFiltro[1, e.RowIndex].Value.ToString();
            }

            if (!string.IsNullOrEmpty((string)dgvFiltro[2, e.RowIndex].Value))
            {
                nome = dgvFiltro[2, e.RowIndex].Value.ToString();
            }

            if (!string.IsNullOrEmpty((string)dgvFiltro[3, e.RowIndex].Value))
            {
                data = Convert.ToDateTime(dgvFiltro[3, e.RowIndex].Value);
            }

            //var predicate = PredicateBuilder.True<Usuario>();

            
            Expression<Func<Usuario, bool>> predicate = p => true;


            if (id > 0)
            {
                predicate = predicate = p => p.Id == id;
            }
                        
            if (!string.IsNullOrEmpty(email))
            {
                predicate = predicate.And(p => p.email.Contains(email));
            }

            if (!string.IsNullOrEmpty(nome))
            {
                predicate = predicate.And(p => p.nome.Contains(nome));
            }

            if ((data != null) & (ValidateUtils.isDate(data.ToString())))
            {                
                predicate = predicate.And(p => DbFunctions.TruncateTime(p.inclusao) == DbFunctions.TruncateTime(data));                
            }

            List<Usuario> usuarioList = usuarioBLL.getUsuario(predicate.Expand(), t => t.Id.ToString(), false, deslocamento, tamanhoPagina, out totalReg);
            dgvDados.DataSource = usuarioList;
            
        }

        protected override void executeEditingControlShowingChild(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column0_KeyPress);
            e.Control.KeyPress -= new KeyPressEventHandler(Column3_KeyPress);
            if (dgvFiltro.CurrentCell.ColumnIndex == 0) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column0_KeyPress);
                }
            }

            if (dgvFiltro.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column3_KeyPress);
                }
            }
        }

        private void Column0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Column3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !e.KeyChar.Equals('/') && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        protected override void excluirRegistro(int Id)
        {
            base.excluirRegistro(Id);
            usuarioBLL = new UsuarioBLL();
            try
            {
                if (Convert.ToInt32(dgvDados[0, dgvDados.CurrentRow.Index].Value) > 0)
                {
                    Usuario usuario = usuarioBLL.Localizar(Convert.ToInt32(dgvDados[0, dgvDados.CurrentRow.Index].Value));
                    if (MessageBox.Show("Deseja realmente excluir o registro : " + usuario.Id.ToString() + " - " + usuario.nome , Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        usuarioBLL.ExcluirUsuario(usuario);
                    }
                    
                }
            }
            finally
            {
                usuarioBLL.Dispose();
            }
            
        }
        #endregion

        private void frmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
        }
    }
}
