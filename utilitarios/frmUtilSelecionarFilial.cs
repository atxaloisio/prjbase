using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;

namespace prjbase
{
    public partial class frmUtilSelecionarFilial : prjbase.frmBase
    {        
        public frmUtilSelecionarFilial()
        {
            InitializeComponent();            
        }

        private void frmUtilSelecionarFilial_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SetupControls();            
            this.Cursor = Cursors.Default;
        }

        private void SetupControls()
        {
            setupcbFilial();
        }

        private void setupcbFilial()
        {
            FilialBLL filialBLL = new FilialBLL();
            List<Filial> lstFilial = filialBLL.getFilial();
            cbFilial.DataSource = lstFilial;
            cbFilial.ValueMember = "Id";
            cbFilial.DisplayMember = "nome_fantasia";
            cbFilial.SelectedIndex = -1;
            if (lstFilial.Count <= 0)
            {
                cbFilial.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt64(cbFilial.SelectedValue);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Id = null;
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
