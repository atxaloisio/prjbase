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
    public partial class frmListItem_Livro_Caixa : prjbase.frmBaseList
    {
        Item_Livro_CaixaBLL Item_Livro_CaixaBLL;
        Livro_CaixaBLL Livro_CaixaBLL;
        long? Id_Filial = null;
        long? Id_Livro_Caixa = null;

        #region Constante de Colunas da Grid
        private const int COL_ID = 0;
        private const int COL_ID_LIVRO = 1;
        private const int COL_TIPO = 2;
        private const int COL_DESCRICAO = 3;
        private const int COL_DOCUMENTO = 4;
        private const int COL_VALOR = 5;
        private const int COL_USUARIO = 6;


        #endregion

        public frmListItem_Livro_Caixa()
        {
            InitializeComponent();            
        }

        private void frmItem_Livro_Caixa_Activated(object sender, EventArgs e)
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
            frmInstancia = new frmCadEditItem_Livro_Caixa();
        }

        protected override void formataColunagridFiltros(DataGridView gridFiltros)
        {
            base.formataColunagridFiltros(gridFiltros);
            //altera o nome das colunas                        
            gridFiltros.Columns.Add("ID", "Código");
            gridFiltros.Columns.Add("ID_LIVRO", "Livro");
                        
            DataGridViewComboBoxColumn colTipo = new DataGridViewComboBoxColumn();
            IList<itemEnumList> lstTipo = new List<itemEnumList>();
            lstTipo.Add(new itemEnumList { chave = 1, descricao = "Entrada"});
            lstTipo.Add(new itemEnumList { chave = 2, descricao = "Saida" });
            lstTipo.Insert(0, new itemEnumList { chave = 3, descricao = string.Empty });

            colTipo.DataSource = lstTipo;
            colTipo.ValueMember = "chave";
            colTipo.DisplayMember = "descricao";
            colTipo.DataPropertyName = "TIPO";
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "TIPO";
            colTipo.SortMode = DataGridViewColumnSortMode.Programmatic;
            gridFiltros.Columns.Add(colTipo);


            gridFiltros.Columns.Add("DESCRICAO", "Descrição");
            gridFiltros.Columns.Add("DOCUMENTO", "Documento");
            gridFiltros.Columns.Add("VALOR", "Valor");
            gridFiltros.Columns.Add("USUARIO", "Usuário");
                                              
            gridFiltros.Columns[COL_ID].Width = 70;
            gridFiltros.Columns[COL_ID].ValueType = typeof(int);
            gridFiltros.Columns[COL_ID].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridFiltros.Columns[COL_ID_LIVRO].Width = 70;
            gridFiltros.Columns[COL_ID_LIVRO].ValueType = typeof(int);
            gridFiltros.Columns[COL_ID_LIVRO].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridFiltros.Columns[COL_ID_LIVRO].Visible = false;

            gridFiltros.Columns[COL_TIPO].Width = 100;
           
            gridFiltros.Columns[COL_DESCRICAO].Width = 300;
            gridFiltros.Columns[COL_DESCRICAO].ValueType = typeof(string);
            gridFiltros.Columns[COL_DESCRICAO].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridFiltros.Columns[COL_DOCUMENTO].Width = 120;
            gridFiltros.Columns[COL_DOCUMENTO].ValueType = typeof(string);
            gridFiltros.Columns[COL_DOCUMENTO].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridFiltros.Columns[COL_VALOR].Width = 120;
            gridFiltros.Columns[COL_VALOR].ValueType = typeof(decimal);
            gridFiltros.Columns[COL_VALOR].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridFiltros.Columns[COL_VALOR].DefaultCellStyle.Format = "N2";

            gridFiltros.Columns[COL_USUARIO].Width = 200;
            gridFiltros.Columns[COL_USUARIO].ValueType = typeof(string);
            gridFiltros.Columns[COL_USUARIO].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridFiltros.CellContentClick += new DataGridViewCellEventHandler(gridFiltros_CellContentClick);

            //Adiciona uma linha ao grid.
            gridFiltros.Rows.Add();
                       
        }

        private void gridFiltros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == COL_TIPO)
            {
                executeCellEndEditChild(sender, e);
            }
        }
               
        protected override void formataColunagridDados(DataGridView gridDados)
        {
            base.formataColunagridDados(gridDados);
            gridDados.Columns[COL_ID].Width = 70;
            gridDados.Columns[COL_ID].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridDados.Columns[COL_ID].Visible = true;

            gridDados.Columns[COL_ID_LIVRO].Width = 70;
            gridDados.Columns[COL_ID_LIVRO].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridDados.Columns[COL_ID_LIVRO].Visible = false;

            gridDados.Columns[COL_TIPO].Width = 100;
            gridDados.Columns[COL_TIPO].ValueType = typeof(string);
            gridDados.Columns[COL_TIPO].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridDados.Columns[COL_DESCRICAO].Width = 300;
            gridDados.Columns[COL_DESCRICAO].ValueType = typeof(string);
            gridDados.Columns[COL_DESCRICAO].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridDados.Columns[COL_DOCUMENTO].Width = 120;
            gridDados.Columns[COL_DOCUMENTO].ValueType = typeof(string);
            gridDados.Columns[COL_DOCUMENTO].SortMode = DataGridViewColumnSortMode.Programmatic;

            gridDados.Columns[COL_VALOR].Width = 120;
            gridDados.Columns[COL_VALOR].ValueType = typeof(decimal);
            gridDados.Columns[COL_VALOR].SortMode = DataGridViewColumnSortMode.Programmatic;
            gridDados.Columns[COL_VALOR].DefaultCellStyle.Format = "N2";

            gridDados.Columns[COL_USUARIO].Width = 200;
            gridDados.Columns[COL_USUARIO].ValueType = typeof(string);
            gridDados.Columns[COL_USUARIO].SortMode = DataGridViewColumnSortMode.Programmatic;
        }

        protected override void carregaConsulta()
        {
            base.carregaConsulta();
            Item_Livro_CaixaBLL = new Item_Livro_CaixaBLL();
            Livro_CaixaBLL = new Livro_CaixaBLL();
            
            //Vamos listar as movimentações do dia.
            //Não existe mais de um livro caixa por dia.            

            if (Parametro.UtilizaFilial())
            {
                if (Id_Filial == null)
                {
                    if (Program.usuario_logado.Id_filial != null)
                    {
                        Id_Filial = Program.usuario_logado.Id_filial;
                    }
                    else
                    {
                        frmUtilSelecionarFilial frm = new frmUtilSelecionarFilial();

                        if (frm.ExibeDialogo() == DialogResult.OK)
                        {
                            Id_Filial = frm.Id;
                        }

                        frm.Dispose();
                    }
                }
                

                if (Id_Filial != null)
                {
                    List<Livro_Caixa> lstLC = null;
                    lstLC = Livro_CaixaBLL.getLivro_Caixa(p => p.Id_filial == Id_Filial & DbFunctions.TruncateTime(p.data) == DbFunctions.TruncateTime(DateTime.Now) & p.status == "A", false, deslocamento, tamanhoPagina, out totalReg,c=>c.Id.ToString());

                    if (lstLC.Count > 0)
                    {
                        Livro_Caixa Livro_Caixa = lstLC.First();
                        Id_Livro_Caixa = Livro_Caixa.Id;
                        dgvDados.DataSource = Item_Livro_CaixaBLL.ToList_Item_Livro_CaixaView(Livro_Caixa.item_livro_caixa);
                    }
                    else
                    {
                        desabilitaBotoes();                        
                        //throw new Exception("Não existe movimentação de livro caixa aberta no momento.");
                        MessageBox.Show("Não existe movimentação de livro caixa aberta para filial no momento.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                    }                    
                }
            }
            else
            {
                List<Livro_Caixa> lstLC = null;
                lstLC = Livro_CaixaBLL.getLivro_Caixa(p => DbFunctions.TruncateTime(p.data) == DbFunctions.TruncateTime(DateTime.Now) & p.status == "A", false, deslocamento, tamanhoPagina, out totalReg, c => c.Id.ToString());

                if (lstLC.Count > 0)
                {
                    Livro_Caixa Livro_Caixa = lstLC.First();
                    Id_Livro_Caixa = Livro_Caixa.Id;
                    dgvDados.DataSource = Item_Livro_CaixaBLL.ToList_Item_Livro_CaixaView(Livro_Caixa.item_livro_caixa);
                }
                else
                {
                    desabilitaBotoes();
                    //throw new Exception("Não existe movimentação de livro caixa aberta no momento.");
                    MessageBox.Show("Não existe movimentação de livro caixa aberta no momento.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
                                                            
            colOrdem = 0;
        }

        private void desabilitaBotoes()
        {
            btnIncluir.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            btnAnterior.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnProximo.Enabled = false;
            btnUltimo.Enabled = false;
        }

        protected override void ordenaCelula(object sender, DataGridViewCellMouseEventArgs e)
        {
            base.ordenaCelula(sender, e);
            Item_Livro_CaixaBLL = new Item_Livro_CaixaBLL();

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

                case COL_TIPO:
                    {
                        List<Item_Livro_Caixa> Item_Livro_CaixaList = Item_Livro_CaixaBLL.getItem_Livro_Caixa(p=>p.Id_livro == Id_Livro_Caixa, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c => c.tipo);
                        dgvDados.DataSource = Item_Livro_CaixaBLL.ToList_Item_Livro_CaixaView(Item_Livro_CaixaList);
                    }
                    break;
                case COL_DOCUMENTO:
                    {
                        List<Item_Livro_Caixa> Item_Livro_CaixaList = Item_Livro_CaixaBLL.getItem_Livro_Caixa(p => p.Id_livro == Id_Livro_Caixa, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c => c.documento);
                        dgvDados.DataSource = Item_Livro_CaixaBLL.ToList_Item_Livro_CaixaView(Item_Livro_CaixaList);
                    }
                    break;

                case COL_DESCRICAO:
                    {
                        List<Item_Livro_Caixa> Item_Livro_CaixaList = Item_Livro_CaixaBLL.getItem_Livro_Caixa(p => p.Id_livro == Id_Livro_Caixa, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c => c.descricao);
                        dgvDados.DataSource = Item_Livro_CaixaBLL.ToList_Item_Livro_CaixaView(Item_Livro_CaixaList);
                    }
                    break;
                case COL_USUARIO:
                    {
                        List<Item_Livro_Caixa> Item_Livro_CaixaList = Item_Livro_CaixaBLL.getItem_Livro_Caixa(p => p.Id_livro == Id_Livro_Caixa, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c => c.usuario_inclusao);
                        dgvDados.DataSource = Item_Livro_CaixaBLL.ToList_Item_Livro_CaixaView(Item_Livro_CaixaList);
                    }
                    break;
                case COL_VALOR:
                    {
                        List<Item_Livro_Caixa> Item_Livro_CaixaList = Item_Livro_CaixaBLL.getItem_Livro_Caixa(p => p.Id_livro == Id_Livro_Caixa, direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg, c => c.valor.ToString());
                        dgvDados.DataSource = Item_Livro_CaixaBLL.ToList_Item_Livro_CaixaView(Item_Livro_CaixaList);
                    }
                    break;
                //O default será executado quando o index for 0
                default:
                    {
                        List<Item_Livro_Caixa> Item_Livro_CaixaList = Item_Livro_CaixaBLL.getItem_Livro_Caixa(p => p.Id.ToString(), direction != ListSortDirection.Ascending, deslocamento, tamanhoPagina, out totalReg);
                        dgvDados.DataSource = Item_Livro_CaixaList;
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
            string tipo = string.Empty;
            string descricao = string.Empty;
            string documento = string.Empty;
            string usuario = string.Empty;
            decimal? valor = null;


            if (dgvFiltro[COL_ID, e.RowIndex].Value != null)
            {
                id = Convert.ToInt32(dgvFiltro[COL_ID, e.RowIndex].Value);
            }

            if (dgvFiltro[COL_TIPO, e.RowIndex].Value != null)
            {
                var tp = (int)((DataGridViewComboBoxCell)dgvFiltro[COL_TIPO, e.RowIndex]).Value;

                switch (tp)
                {
                    case 1:
                        {
                            tipo = "E";
                        }
                        break;
                    case 2:
                        {
                            tipo = "S";
                        }
                        break;
                    case 3:
                        {
                            tipo = string.Empty;
                        }
                        break;
                }                
            }

            if (!string.IsNullOrEmpty((string)dgvFiltro[COL_DESCRICAO, e.RowIndex].Value))
            {
                descricao = dgvFiltro[COL_DESCRICAO, e.RowIndex].Value.ToString();
            }

            if (!string.IsNullOrEmpty((string)dgvFiltro[COL_DOCUMENTO, e.RowIndex].Value))
            {
                documento = dgvFiltro[COL_DOCUMENTO, e.RowIndex].Value.ToString();
            }

            if (!string.IsNullOrEmpty((string)dgvFiltro[COL_USUARIO, e.RowIndex].Value))
            {
                usuario = dgvFiltro[COL_USUARIO, e.RowIndex].Value.ToString();
            }

            if (dgvFiltro[COL_VALOR, e.RowIndex].Value != null)
            {
                valor = Convert.ToDecimal(dgvFiltro[COL_VALOR, e.RowIndex].Value);
            }
            
            Expression<Func<Item_Livro_Caixa, bool>> predicate = p => true;


            if (id > 0)
            {
                predicate = predicate = p => p.Id == id;
            }

            if (!string.IsNullOrEmpty(tipo))
            {                 
                predicate = predicate.And(p => p.tipo == tipo);
            }

            if (!string.IsNullOrEmpty(descricao))
            {
                predicate = predicate.And(p => p.descricao.ToLower().Contains(descricao.ToLower()));
            }

            if (!string.IsNullOrEmpty(documento))
            {
                predicate = predicate.And(p => p.documento.ToLower().Contains(documento.ToLower()));
            }

            if (!string.IsNullOrEmpty(usuario))
            {
                predicate = predicate.And(p => p.usuario_inclusao.ToLower().Contains(usuario.ToLower()));
            }

            if ((valor != null))
            {
                predicate = predicate.And(p => p.valor == valor);
            }

            List<Item_Livro_Caixa> Item_Livro_CaixaList = Item_Livro_CaixaBLL.getItem_Livro_Caixa(predicate.Expand(), t => t.Id.ToString(), false, deslocamento, tamanhoPagina, out totalReg);
            dgvDados.DataSource = Item_Livro_CaixaBLL.ToList_Item_Livro_CaixaView(Item_Livro_CaixaList);

        }

        protected override void excluirRegistro(int Id)
        {
            base.excluirRegistro(Id);
            Item_Livro_CaixaBLL = new Item_Livro_CaixaBLL();
            try
            {
                if (Convert.ToInt32(dgvDados[0, dgvDados.CurrentRow.Index].Value) > 0)
                {
                    Item_Livro_Caixa Item_Livro_Caixa = Item_Livro_CaixaBLL.Localizar(Convert.ToInt32(dgvDados[0, dgvDados.CurrentRow.Index].Value));
                    if (MessageBox.Show("Deseja realmente excluir o registro : " + Item_Livro_Caixa.Id.ToString() + " - " + Item_Livro_Caixa.documento, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Item_Livro_CaixaBLL.ExcluirItem_Livro_Caixa(Item_Livro_Caixa);
                    }

                }
            }
            finally
            {
                Item_Livro_CaixaBLL.Dispose();
            }

        }

        protected override void btnIncluir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (ValidaAcessoFuncao(Operacao.Salvar))
            {
                this.Cursor = Cursors.Default;
                String TituloTela;
                if ((frmInstancia == null) || (frmInstancia.IsDisposed))
                {
                    this.InstanciarFormulario();

                    TituloTela = frmInstancia.Text;
                    frmInstancia.Text = "Incluir : " + frmInstancia.Text;
                    if (this.Tag != null)
                    {
                        frmInstancia.Tag = this.Tag;
                    }

                    frmInstancia.MinimizeBox = false;
                    frmInstancia.MaximizeBox = false;
                    frmInstancia.ControlBox = false;
                    frmInstancia.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frmInstancia.MdiParent = this.MdiParent;
                    frmInstancia.atualizagrid = new AtualizaGrid(atualizaGrid);
                    ((frmCadEditItem_Livro_Caixa)frmInstancia).Id_Livro_Caixa = Id_Livro_Caixa;
                    frmInstancia.Show();
                }
                else
                {
                    string mensagem = "Já existe uma Jalena aberta de " + frmInstancia.Text;
                    MessageBox.Show(mensagem, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
            }
        }


        #endregion

        private void frmItem_Livro_Caixa_BindingContextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
