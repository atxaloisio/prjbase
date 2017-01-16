using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Model;
using BLL;

namespace prjbase
{
    public partial class frmUsuarios : prjbase.frmBaseList
    {
        UsuarioBLL usuarioBLL;
        
        public frmUsuarios()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;            
        }

        protected override void InstanciarFormulario()
        {
            frmInstancia = new frmCadEditUsuario();
        }

        private void frmUsuarios_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        protected override void formataColunagridFiltros(DataGridView gridFiltros)
        {
            base.formataColunagridFiltros(gridFiltros);
            //altera o nome das colunas                        
            gridFiltros.Columns.Add("ID", "Id");            
            gridFiltros.Columns.Add("EMAIL", "e-Mail");
            gridFiltros.Columns.Add("NOME", "Nome");            
            gridFiltros.Columns.Add("CRIACAO", "Dt. Criação");

            //
            gridFiltros.Columns[0].Width = 50;
            gridFiltros.Columns[0].ValueType = typeof(int);
            gridFiltros.Columns[1].Width = 200;
            gridFiltros.Columns[1].ValueType = typeof(string);
            gridFiltros.Columns[2].Width = 200;
            gridFiltros.Columns[2].ValueType = typeof(string);            
            gridFiltros.Columns[3].Width = 200;
            gridFiltros.Columns[3].ValueType = typeof(DateTime);

            gridFiltros.Rows.Add();

            //gridFiltros.Columns[2].Visible = false;
        }

        protected override void formataColunagridDados(DataGridView gridDados)
        {
            base.formataColunagridDados(gridDados);
            gridDados.Columns[0].Width = 50;
            gridDados.Columns[1].Width = 200;
            gridDados.Columns[2].Width = 200;
            gridDados.Columns[3].Visible = false;
            gridDados.Columns[4].Width = 200;
            gridDados.Columns[5].Visible = false;
        }

        protected override void carregaConsulta()
        {
            base.carregaConsulta();
            usuarioBLL = new UsuarioBLL();
            List<Usuario> usuarioList = usuarioBLL.getUsuario(p => p.Id.ToString(), false, deslocamento, tamanhoPagina, out totalReg);
            //List<Usuario> usuarioList = usuarioBLL.getUsuario(p => p.nome.Contains("x"), T => T.Id.ToString(), false, deslocamento, tamanhopagina, out totalreg);
            dgvDados.DataSource = usuarioList;            
        }        
    }
}
