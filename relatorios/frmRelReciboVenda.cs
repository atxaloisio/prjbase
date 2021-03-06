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
using Model;
using BLL;

namespace prjbase
{
    public partial class frmRelReciboVenda : prjbase.frmReportBase
    {
        public frmRelReciboVenda()
        {
            InitializeComponent();
        }

        protected override void CarregaRelatorio()
        {

            rvRelatorios.LocalReport.DataSources.Clear();
            rvRelatorios.Reset();
            rvRelatorios.LocalReport.ReportEmbeddedResource = "prjbase.relatorios.relReciboVenda.rdlc";
            
            dbintegracaoDataSetTableAdapters.qryReciboVendaTableAdapter Venda = new dbintegracaoDataSetTableAdapters.qryReciboVendaTableAdapter();
            dbintegracaoDataSetTableAdapters.empresa_logoTableAdapter Empresa_Logo = new dbintegracaoDataSetTableAdapters.empresa_logoTableAdapter();
            dbintegracaoDataSetTableAdapters.qryParcelaTableAdapter parcela = new dbintegracaoDataSetTableAdapters.qryParcelaTableAdapter();
            dbintegracaoDataSetTableAdapters.filial_logoTableTableAdapter Filial_Logo = new dbintegracaoDataSetTableAdapters.filial_logoTableTableAdapter();

            DataTable dt = new DataTable();
            DataTable dtl = new DataTable();
            DataTable dtp = new DataTable();

            //dt = prod.GetData(Convert.ToInt64(Id));
            dt = Venda.GetData(Convert.ToInt64(Id));

            if (stUsuario.UsuarioLogado.Id_filial != null)
            {
                dtl = Filial_Logo.GetData(Convert.ToInt64(stUsuario.UsuarioLogado.Id_filial));
            }
            else
            {
                dtl = Empresa_Logo.GetData();
            }
                
            dtp = parcela.GetData(Convert.ToInt64(Id));

            ReportDataSource ds = new ReportDataSource(dt.TableName, dt);
            ReportDataSource ds2 = new ReportDataSource(dtl.TableName, dtl);
            ReportDataSource ds3 = new ReportDataSource(dtp.TableName, dtp);


            ds.Name = "DataSet1";
            ds2.Name = "DataSet2";
            ds3.Name = "DataSet3";
            rvRelatorios.LocalReport.DataSources.Add(ds);
            rvRelatorios.LocalReport.DataSources.Add(ds2);
            rvRelatorios.LocalReport.DataSources.Add(ds3);

            //rvRelatorios.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(onSubreportProcessing);
            string msgRodape = string.Empty;
            if (stUsuario.UsuarioLogado.Id_filial != null)
            {
                FilialBLL FilialBLL = new FilialBLL();
                Filial f = FilialBLL.Localizar(stUsuario.UsuarioLogado.Id_filial);
                msgRodape = string.Format("{0} - {1} {2} {3}, {4} {5} {6} CEP: {7} Tel:({8}){9} e-mail:{10}                                {11}",f.nome_fantasia, f.endereco, f.endereco_numero, f.complemento, f.bairro, f.cidade, f.estado, f.cep, f.telefone1_ddd, f.telefone1_numero, f.email, "Documento sem valor fiscal");
            }
            else
            {
                if (stUsuario.UsuarioLogado.Id_empresa != null)
                {
                    EmpresaBLL EmpresaBLL = new EmpresaBLL();
                    Empresa e = EmpresaBLL.Localizar(stUsuario.UsuarioLogado.Id_empresa);
                    msgRodape = string.Format("{0} - {1} {2} {3}, {4} {5} {6} CEP: {7} Tel:({8}){9} e-mail:{10}                                {11}", e.nome_fantasia, e.endereco, e.endereco_numero, e.complemento, e.bairro, e.cidade, e.estado, e.cep, e.telefone1_ddd, e.telefone1_numero, e.email, "Documento sem valor fiscal");
                }
            }

            ReportParameterCollection parametros = new ReportParameterCollection();
            ReportParameter parametro = new ReportParameter();
            parametro.Name = "EndLaboratorio";
            parametro.Values.Add(msgRodape);
            parametro.Values.Add("");
            parametros.Add(parametro);
            
            ReportParameter nrRecibo = new ReportParameter();
            nrRecibo.Name = "nrRecibo";
            
            nrRecibo.Values.Add(Sequence.GetNextVal("sq_recibo_venda_sequence").ToString());            
            parametros.Add(nrRecibo);
            rvRelatorios.LocalReport.SetParameters(parametros);
        }

        //protected void onSubreportProcessing(object sender, SubreportProcessingEventArgs e)
        //{
        //    dbintegracaoDataSetTableAdapters.qryItemPedido_OticaTableAdapter itempedido = new dbintegracaoDataSetTableAdapters.qryItemPedido_OticaTableAdapter();
        //    DataTable dt = itempedido.GetData(Convert.ToInt64(Id));
        //    e.DataSources.Add(new ReportDataSource("DataSetItemPedido_Otica", (object)dt));
        //}
    }
}
