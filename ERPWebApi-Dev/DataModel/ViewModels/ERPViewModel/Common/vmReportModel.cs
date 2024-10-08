using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModels.ERPViewModel.Common
{
    public class vmReportModel
    {
        private List<DataTable> dtList = new List<DataTable>();
        private List<vmReportParameters> vrpList = new List<vmReportParameters>();
        public List<DataTable> DataTableList { get { return dtList; } set { dtList = value; } }
        public List<vmReportParameters> ParameterList { get { return vrpList; } set { vrpList = value; } }
        public string ReportPath { get; set; }
        public string RenderType { get; set; }
    }
}
