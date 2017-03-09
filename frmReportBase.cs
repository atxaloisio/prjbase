using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


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
            // TODO: This line of code loads data into the 'dbintegracaoDataSet.produto1' table. You can move, or remove it, as needed.
            //this.produto1TableAdapter.Fill(this.dbintegracaoDataSet.produto1);
            // TODO: This line of code loads data into the 'dbintegracaoDataSet.produto' table. You can move, or remove it, as needed.
            rvRelatorios.LocalReport.DataSources.Clear();
            rvRelatorios.Reset();
            rvRelatorios.LocalReport.ReportEmbeddedResource = "prjbase.relatorios.relPedido_Otica.rdlc";
            //dbintegracaoDataSet db = new dbintegracaoDataSet();
            dbintegracaoDataSetTableAdapters.qryPedido_OticaTableAdapter prod = new dbintegracaoDataSetTableAdapters.qryPedido_OticaTableAdapter();
            //prod.Fill(db.produto1,43);

            //dbintegracaoDataSetTableAdapters.QueriesTableAdapter qry = new dbintegracaoDataSetTableAdapters.QueriesTableAdapter();
            


            DataTable dt = new DataTable();

            //dt = qry.qryPedido_Otica(Convert.ToInt64(4));

            dt = prod.GetData(Convert.ToInt64(Id));

            ReportDataSource ds = new ReportDataSource(dt.TableName, dt);

            ds.Name = "DataSet1";
            rvRelatorios.LocalReport.DataSources.Add(ds);

            rvRelatorios.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(onSubreportProcessing);

            ReportParameterCollection parametros = new ReportParameterCollection();
            ReportParameter parametro = new ReportParameter();
            parametro.Name = "EndLaboratorio";
            parametro.Values.Add("LABORATORIO PRECISION - Rua Antonio Rabelo Guimarães, 256 - Centro - Nova Iguaçu/RJ - Fone: (21) 2667-6932");
            parametros.Add(parametro);
            rvRelatorios.LocalReport.SetParameters(parametros);     
            
            // TODO: This line of code loads data into the 'dbintegracaoDataSet1.produto' table. You can move, or remove it, as needed.

            this.rvRelatorios.RefreshReport();
        }

        protected void onSubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            dbintegracaoDataSetTableAdapters.qryItemPedido_OticaTableAdapter itempedido = new dbintegracaoDataSetTableAdapters.qryItemPedido_OticaTableAdapter();
            DataTable dt = itempedido.GetData(Convert.ToInt64(Id));
            e.DataSources.Add(new ReportDataSource("DataSetItemPedido_Otica", (object)dt));
        }
    }
}
