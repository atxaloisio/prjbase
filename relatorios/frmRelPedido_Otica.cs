﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Utils;

namespace prjbase
{
    public partial class frmRelPedido_Otica : prjbase.frmReportBase
    {
        public frmRelPedido_Otica()
        {
            InitializeComponent();
        }
        
        protected override void CarregaRelatorio()
        {
            rvRelatorios.LocalReport.DataSources.Clear();
            rvRelatorios.Reset();
            rvRelatorios.LocalReport.ReportEmbeddedResource = "prjbase.relatorios.relPedido_Otica.rdlc";
            dbintegracaoDataSetTableAdapters.qryPedido_OticaTableAdapter prod = new dbintegracaoDataSetTableAdapters.qryPedido_OticaTableAdapter();

            DataTable dt = new DataTable();

            dt = prod.GetData(Convert.ToInt64(Id));

            ReportDataSource ds = new ReportDataSource(dt.TableName, dt);

            ds.Name = "DataSet1";
            rvRelatorios.LocalReport.DataSources.Add(ds);

            rvRelatorios.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(onSubreportProcessing);

            ReportParameterCollection parametros = new ReportParameterCollection();
            ReportParameter parametro = new ReportParameter();
            parametro.Name = "EndLaboratorio";
            //parametro.Values.Add("LABORATORIO PRECISION - Rua Antonio Rabelo Guimarães, 256 - Centro - Nova Iguaçu/RJ - Fone: (21) 2667-6932");
            parametro.Values.Add("");
            parametros.Add(parametro);
            rvRelatorios.LocalReport.SetParameters(parametros);
        }

        protected void onSubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            dbintegracaoDataSetTableAdapters.qryItemPedido_OticaTableAdapter itempedido = new dbintegracaoDataSetTableAdapters.qryItemPedido_OticaTableAdapter();
            DataTable dt = itempedido.GetData(Convert.ToInt64(Id));
            e.DataSources.Add(new ReportDataSource("DataSetItemPedido_Otica", (object)dt));
        }
    }
}
