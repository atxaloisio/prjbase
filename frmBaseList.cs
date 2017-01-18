using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utils;

namespace prjbase
{
    public partial class frmBaseList : prjbase.frmBase
    {
        protected frmBase frmInstancia;

        protected int deslocamento = 0;
        protected int pagina = 0;
        protected int tamanhoPagina = 20;
        protected decimal totalPaginas = 0;
        protected int totalReg = 0;
        protected virtual int colOrdem { get; set; }
        public frmBaseList()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        protected virtual void InstanciarFormulario()
        {

        }

        public virtual void ConfigurarForm(Form pFormParent)
        {
            WindowState = FormWindowState.Maximized;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            MdiParent = pFormParent;
        }

        protected virtual void btnIncluir_Click(object sender, EventArgs e)
        {
            String TituloTela;
            if ((frmInstancia == null) || (frmInstancia.IsDisposed))
            {
                this.InstanciarFormulario();
            }
            TituloTela = frmInstancia.Text;
            frmInstancia.Text = "Incluir : " + frmInstancia.Text;
            //frmInstancia.Text = TituloTela;
            frmInstancia.ExibeDialogo();
            if (frmInstancia.atualizagrid)
            {
                MessageBox.Show("atualiza.");
            }
            else
            {
                MessageBox.Show("não atualiza");
            }
            frmInstancia.Dispose();

        }

        protected virtual void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnEditar_Click(object sender, EventArgs e)
        {
            String TituloTela;
            if ((frmInstancia == null) || (frmInstancia.IsDisposed))
            {
                this.InstanciarFormulario();
            }
            TituloTela = frmInstancia.Text;
            frmInstancia.Text = "Editar : " + frmInstancia.Text;
            //frmInstancia.Text = TituloTela;
            frmInstancia.ExibeDialogo(this, 1);
            if (frmInstancia.atualizagrid)
            {
                MessageBox.Show("atualiza.");
            }
            else
            {
                MessageBox.Show("não atualiza");
            }
            frmInstancia.Dispose();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void frmBaseList_Load(object sender, EventArgs e)
        {            
            carregaDados();
            WindowState = FormWindowState.Maximized;
            
            var topBotoesNavegacao = (pnlBotoes.Height - (btnFechar.Height + btnProximo.Height + 4));
            var topLabelsNavegacao = (pnlBotoes.Height - (btnFechar.Height + btnProximo.Height + lblDe.Height + 4));
            var topLabelsTotalReg  = (pnlBotoes.Height - (btnFechar.Height + btnProximo.Height + lblDe.Height + lblRegistros.Height + 25));
            var topPanelBorda = (pnlBotoes.Height - (btnFechar.Height + btnProximo.Height + lblDe.Height + pnlBorda.Height + 10));

            lblDe.Top = topLabelsNavegacao;
            lblNumeroPagina.Top = topLabelsNavegacao;
            lblTotalPaginas.Top = topLabelsNavegacao;

            lblRegistros.Top = topLabelsTotalReg;
            lblTotalRegistros.Top = topLabelsTotalReg;

            pnlBorda.Top = topPanelBorda;

            btnProximo.Top = topBotoesNavegacao;
            btnUltimo.Top = topBotoesNavegacao;
            btnAnterior.Top = topBotoesNavegacao;
            btnPrimeiro.Top = topBotoesNavegacao;

            btnFechar.Top = (pnlBotoes.Height - btnFechar.Height);
            Parent.Text = Parent.Text + " : " + Text;
            
        }

        protected virtual void formataGridDados()
        {
            var gridDados = dgvDados;
            gridDados.AutoGenerateColumns = false;
            gridDados.ColumnHeadersVisible = false;
            gridDados.RowHeadersVisible = false;
            gridDados.ReadOnly = true;
            gridDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            gridDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            gridDados.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            gridDados.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            formataColunagridDados(gridDados);
            //seleciona a linha inteira
            gridDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //não permite seleção de multiplas linhas
            gridDados.MultiSelect = false;
            // exibe nulos formatados
            gridDados.DefaultCellStyle.NullValue = " - ";
            //permite que o texto maior que célula não seja truncado
            gridDados.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gridDados.DefaultCellStyle.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        }

        protected virtual void formataGridFiltro()
        {
            var gridFiltros = dgvFiltro;
            gridFiltros.AutoGenerateColumns = false;
            gridFiltros.AllowUserToAddRows = false;
            gridFiltros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            gridFiltros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            gridFiltros.RowHeadersVisible = false;
            formataColunagridFiltros(gridFiltros);
            //altera a cor das linhas alternadas no grid
            gridFiltros.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            gridFiltros.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;

            //seleciona uma celula
            gridFiltros.SelectionMode = DataGridViewSelectionMode.CellSelect;
            //não permite seleção de multiplas linhas
            gridFiltros.MultiSelect = false;
            // exibe nulos formatados
            //gridFiltros.DefaultCellStyle.NullValue = " - ";
            //permite que o texto maior que célula não seja truncado
            gridFiltros.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gridFiltros.DefaultCellStyle.Font = new Font("Tahoma", 10F, FontStyle.Regular);
            gridFiltros.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10F, FontStyle.Bold);

            gridFiltros.DataError += new DataGridViewDataErrorEventHandler(dgvFiltro_DataError);

            gridFiltros.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvFiltro_EditingControlShowing);

            gridFiltros.CellValidating += new DataGridViewCellValidatingEventHandler(dgvFiltro_CellValidating);
            gridFiltros.KeyDown += new KeyEventHandler(dgvFiltro_KeyDown);
            gridFiltros.CellEndEdit += new DataGridViewCellEventHandler(dgvFiltro_CellEndEdit);

            gridFiltros.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgvFiltro_ColumnHeaderMouseClick);
        }

        private void dgvFiltro_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ordenaCelula(sender, e);
        }

        protected virtual void ordenaCelula(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                int iColumn = dgvFiltro.CurrentCell.ColumnIndex;
                int iRow = dgvFiltro.CurrentCell.RowIndex;
                if (iColumn == dgvFiltro.Columns.Count - 1)
                    dgvFiltro.CurrentCell = dgvFiltro[0, iRow];
                else
                    dgvFiltro.CurrentCell = dgvFiltro[iColumn + 1, iRow];
            }

            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                int iColumn = dgvFiltro.CurrentCell.ColumnIndex;
                int iRow = dgvFiltro.CurrentCell.RowIndex;

                dgvFiltro[iColumn, iRow].Value = "";                
            }
        }

        private void dgvFiltro_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            executeCellEndEditChild(sender, e);
            dgvFiltro.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        protected virtual void executeCellEndEditChild(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvFiltro_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            executeCellValidatingChild(sender, e);
            
        }

        protected virtual void executeCellValidatingChild(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

        protected virtual void dgvFiltro_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                MessageBox.Show(e.Exception.Message);
            }

            //&& e.Context == DataGridViewDataErrorContexts.Parsing)
        }

        protected virtual void dgvFiltro_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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

        protected virtual void formataColunagridDados(DataGridView gridDados)
        {
            //metodo implementado nas entidades filhas
        }

        protected virtual void formataColunagridFiltros(DataGridView gridFiltros)
        {
            //metodo implementado nas entidades filhas
        }

        protected virtual void carregaConsulta()
        {
            //Metodo implementado nas entidades filhas
        }

        protected virtual void carregaDados()
        {
            try
            {
                carregaConsulta();
                pagina++;
                if (totalReg > 0)
                {
                    totalPaginas = Math.Ceiling(decimal.Divide(totalReg, tamanhoPagina));
                    lblNumeroPagina.Text = Convert.ToString(pagina);
                    lblTotalPaginas.Text = Convert.ToString(totalPaginas);
                    lblTotalRegistros.Text = Convert.ToString(totalReg);                   
                }
                configuraBotoesNaveg();
                formataGridDados();
                formataGridFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected virtual void callNextPage()
        {
            try
            {
                deslocamento = deslocamento + tamanhoPagina;
                if (deslocamento > totalReg)
                {
                    deslocamento = 0;
                }
                carregaConsulta();
                pagina++;

                if (pagina > (totalPaginas))
                {
                    pagina = 1;
                }
                
                lblNumeroPagina.Text = Convert.ToString(pagina);
                configuraBotoesNaveg();
                formataGridDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected virtual void callPrevPage()
        {
            try
            {
                if ((deslocamento > 0) & (deslocamento >= tamanhoPagina))
                {
                    deslocamento = deslocamento - tamanhoPagina;
                }
                else
                {
                    deslocamento = 0;
                }
                            
                carregaConsulta();
                pagina--;

                if (pagina < 1)
                {
                    pagina = 1;
                }                
                lblNumeroPagina.Text = Convert.ToString(pagina);
                configuraBotoesNaveg();
                formataGridDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void callLastPage()
        {
            try
            {
                int ultimapagina = totalReg - tamanhoPagina;

                if (ultimapagina < tamanhoPagina)
                {
                    deslocamento = totalReg - ultimapagina;
                }
                else
                {
                    deslocamento = ultimapagina;
                }
                
                                
                carregaConsulta();

                pagina = Convert.ToInt32(totalPaginas);                                
                lblNumeroPagina.Text = Convert.ToString(totalPaginas);
                configuraBotoesNaveg();
                formataGridDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void callFirstPage()
        {
            try
            {
                deslocamento = 0;                
                carregaConsulta();

                if (totalReg > 0)
                {
                    totalPaginas = Math.Ceiling(decimal.Divide(totalReg, tamanhoPagina));
                    pagina = 1;
                    lblNumeroPagina.Text = Convert.ToString(pagina);
                    lblTotalPaginas.Text = Convert.ToString(totalPaginas);
                }
                configuraBotoesNaveg();
                formataGridDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            callNextPage();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            callLastPage();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            callPrevPage();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            callFirstPage();
        }

        private void configuraBotoesNaveg()
        {
            btnAnterior.Enabled = deslocamento > 0;
            btnPrimeiro.Enabled = deslocamento > 0;
            btnProximo.Enabled = pagina < totalPaginas;
            btnUltimo.Enabled = pagina < totalPaginas;            
        }
    }
}
