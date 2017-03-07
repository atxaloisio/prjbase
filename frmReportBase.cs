using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace prjbase
{
    public partial class frmReportBase : prjbase.frmBase
    {
        public frmReportBase()
        {
            InitializeComponent();
        }

        private void frmReportBase_Load(object sender, EventArgs e)
        {            
            this.rvRelatorios.RefreshReport();
        }
    }
}
