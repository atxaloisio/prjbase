using System;
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
using Model;

namespace prjbase
{
    public partial class frmRelListPedido_Otica : prjbase.frmReportBase
    {
        public StatusPedido? statusDe;
        public StatusPedido? statusAte;
        public frmRelListPedido_Otica()
        {
            InitializeComponent();            
        }

        protected override void CarregaRelatorio()
        {            
            if (statusDe != null)
            {
                rvRelatorios.LocalReport.DataSources.Clear();
                rvRelatorios.Reset();
                rvRelatorios.LocalReport.ReportEmbeddedResource = "prjbase.relatorios.relListPedido_Otica.rdlc";
                dbintegracaoDataSetTableAdapters.qryListPedido_OticaTableAdapter lstPed = new dbintegracaoDataSetTableAdapters.qryListPedido_OticaTableAdapter();

                DataTable dt = new DataTable();

                dt = lstPed.GetData((int)statusDe, (int)statusAte);

                ReportDataSource ds = new ReportDataSource(dt.TableName, dt);

                ds.Name = "DataSet1";
                rvRelatorios.LocalReport.DataSources.Add(ds);

                //rvRelatorios.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(onSubreportProcessing);

                ReportParameterCollection parametros = new ReportParameterCollection();

                ReportParameter parametro = new ReportParameter();
                parametro.Name = "EndLaboratorio";
                parametro.Values.Add("LABORATORIO PRECISION - Rua Antonio Rabelo Guimarães, 256 - Centro - Nova Iguaçu/RJ - Fone: (21) 2667-6932");

                ReportParameter pardQtdRegs = new ReportParameter();
                pardQtdRegs.Name = "QtdRegistros";
                pardQtdRegs.Values.Add(dt.Rows.Count.ToString());

                parametros.Add(parametro);
                parametros.Add(pardQtdRegs);
                rvRelatorios.LocalReport.SetParameters(parametros);
            }
            
        }
    }
}
