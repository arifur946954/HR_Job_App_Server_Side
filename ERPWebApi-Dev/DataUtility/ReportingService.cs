//using DataModels.EntityModels.ERPModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

using Microsoft.AspNetCore.Http;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
//using AspNetCore.Reporting;
using DataModel.ViewModels;
using System.Text;
using Microsoft.Reporting.NETCore;
using DataModel.ViewModels.ERPViewModel.Common;

namespace DataUtility
{
    public class ReportingService
    {
        public static async Task<object> Report(List<DataTable> dataList, string filePath, string repType)
        {
            object bytes = null; string mimeType = string.Empty, paramSetName = "ParamSet", dataSetName = string.Empty; int extension = 1;
            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    //Initialize local report with path
                    LocalReport localReport = new LocalReport();
                    localReport.ReportPath = filePath;
                    //ReportDataSource dtSrc = new ReportDataSource();

                    //Set Parameters                    
                    //DataTable parameterList = Extension.GetDataTable(paramList);

                    //Add DataSource
                    foreach (var dt in dataList)
                    {
                        dataSetName = dt.Rows[0].Field<string>(Extension.dataColumn);
                        localReport.DataSources.Add(new ReportDataSource(dataSetName, dt));
                    }

                    //localReport.DataSources.Add(new ReportDataSource(paramSetName, parameterList));
                    //localReport.SetParameters(new[] { new ReportParameter("Parameter1", "Parameter value") });
                    bytes = localReport.Render(repType);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return bytes;
        }

        public static async Task<object> Report(vmReportModel rpt)
        {
            object bytes = null; string mimeType = string.Empty, dataSetName = string.Empty; //paramSetName = "ParamSet",  int extension = 1;
            try
            {                
                if (System.IO.File.Exists(rpt.ReportPath))
                {
                    //Initialize local report with path
                    LocalReport localReport = new LocalReport();
                    localReport.ReportPath = rpt.ReportPath;
                    //ReportDataSource dtSrc = new ReportDataSource();

                    //Add DataSource
                    foreach (var dt in rpt.DataTableList)
                    {
                        dataSetName = dt.Rows[0].Field<string>(Extension.dataColumn);
                        localReport.DataSources.Add(new ReportDataSource(dataSetName, dt));
                    }

                    //Set Parameters
                    if (rpt.ParameterList.Count > 0)
                    {
                        foreach (var item in rpt.ParameterList)
                        {
                            localReport.SetParameters(new[] { new ReportParameter(item.Name, item.Value) });
                        }
                    }

                    bytes = localReport.Render(rpt.RenderType);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return bytes;
        }

        public static object Reports(List<DataTable> dataList, string paramList, string filePath, string repType)
        {
            object bytes = null; string mimeType = string.Empty, paramSetName = "ParamSet", dataSetName = string.Empty; int extension = 1;
            try
            {
                //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                //Encoding.GetEncoding("windows-1252");
                if (System.IO.File.Exists(filePath))
                {
                    //Initialize local report with path
                    LocalReport localReport = new LocalReport();
                    localReport.ReportPath = filePath;
                    ReportDataSource dtSrc = new ReportDataSource();

                    //Set Parameters                    
                    DataTable parameterList = Extension.GetDataTable(paramList);

                    //Add DataSource
                    foreach (var dt in dataList)
                    {
                        dataSetName = dt.Rows[0].Field<string>(Extension.dataColumn);
                        localReport.DataSources.Add(new ReportDataSource(dataSetName, dt));
                    }

                    //localReport.SetParameters(new[] { new ReportParameter("Parameter1", "Parameter value") });
                    localReport.DataSources.Add(new ReportDataSource(paramSetName, parameterList));
                    bytes = localReport.Render(repType);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return bytes;
        }

        //public static object Report(List<DataTable> dataList, string paramList, string filePath, string repType)
        //{
        //    object bytes = null; string mimeType = string.Empty, paramSetName = "ParamSet", dataSetName = string.Empty; int extension = 1;
        //    try
        //    {
        //        if (System.IO.File.Exists(filePath))
        //        {
        //            //Initialize local report with path
        //            LocalReport localReport = new LocalReport();
        //            localReport.ReportPath = filePath;
        //            ReportDataSource dtSrc = new ReportDataSource();

        //            //Set Parameters                    
        //            DataTable parameterList = Extension.GetDataTable(paramList);

        //            //Add DataSource
        //            foreach (var dt in dataList)
        //            {
        //                dataSetName = dt.Rows[0].Field<string>(Extension.dataColumn);
        //                localReport.DataSources.Add(new ReportDataSource(dataSetName, dt));
        //            }

        //            localReport.DataSources.Add(new ReportDataSource(paramSetName, parameterList));
        //            bytes = localReport.Render(repType);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.ToString();
        //    }

        //    return bytes;
        //}

        //public static object Reports(List<DataTable> dataList, string paramList, string filePath, string repType)
        //{
        //    object bytes = null; string mimeType = string.Empty, paramSetName = "ParamSet", dataSetName = string.Empty; int extension = 1;
        //    try
        //    {
        //        //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        //        //Encoding.GetEncoding("windows-1252");
        //        if (System.IO.File.Exists(filePath))
        //        {
        //            //Initialize local report with path
        //            LocalReport localReport = new LocalReport();
        //            localReport.ReportPath = filePath;
        //            ReportDataSource dtSrc = new ReportDataSource();

        //            //Set Parameters                    
        //            DataTable parameterList = Extension.GetDataTable(paramList);

        //            //Add DataSource
        //            foreach (var dt in dataList)
        //            {
        //                dataSetName = dt.Rows[0].Field<string>(Extension.dataColumn);
        //                localReport.DataSources.Add(new ReportDataSource(dataSetName, dt));
        //            }

        //            //localReport.SetParameters(new[] { new ReportParameter("Parameter1", "Parameter value") });
        //            localReport.DataSources.Add(new ReportDataSource(paramSetName, parameterList));
        //            bytes = localReport.Render(repType);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.ToString();
        //    }

        //    return bytes;
        //}
    }
}