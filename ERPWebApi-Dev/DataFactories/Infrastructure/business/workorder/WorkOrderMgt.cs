using DataFactories.BaseFactory;
using DataFactories.Infrastructure.common.processflow;
using DataModel.EntityModels.OraModel;
using DataModel.ViewModels;
using DataModel.ViewModels.ERPViewModel.Business;
using DataModel.ViewModels.ERPViewModel.Common;
using DataUtility;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace DataFactories.Infrastructure.business.workorder
{
    public class WorkOrdersMgt
    {
        #region Variable declaration & initialization
        ModelContext _ctxOra = null;
        private IGenericFactoryOracle<vmCmnParameter> OraGeneric_vmCmnParameter = null;
        OracleCommand ocmd = null;
        Hashtable ht = null; OracleParameter[] oprm = null;
        #endregion
   


    public async Task<object> SaveUpdate(string _mJsonData, string _dJsonData, string _tcJsonData, vmCmnParameter param)
    {
        object referenceId = 0; string message = string.Empty; bool resstate = false;
        OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
        string result = string.Empty, mstrRes = string.Empty;
        try
        {
            
            ocmd = new OracleCommand();
            ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            ocmd.Parameters.Add("JsonData_Mstr", OracleDbType.Clob).Value = _mJsonData;
            ocmd.Parameters.Add("JsonData_TCN", OracleDbType.Clob).Value = _tcJsonData;
            ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
            ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

            mstrRes = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_WorkOrderMaster, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
            if (!string.IsNullOrEmpty(mstrRes) && mstrRes != "null")
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("Mstr_OID", OracleDbType.Varchar2).Value = mstrRes;
                ocmd.Parameters.Add("JsonData_Dtl", OracleDbType.Clob).Value = _dJsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                if (param.strId2 == "CAT000001" || param.strId2 == "CAT000002" || param.strId2 == "CAT000004" || param.strId2 == "CAT000005" || param.strId2 == "CAT000009" ||
                        param.strId2 == "CAT000007" || param.strId2 == "CAT000008" || param.strId2 == "CAT000003" || param.strId2 == "CAT000006"

                        )
                {
                    result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_WorkOrderDetail_Common, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                }
           
            }

            if (!string.IsNullOrEmpty(result) && result != "0" && result != "null")
            {

                    dynamic upQot = UpdateQuation(_mJsonData, mstrRes);



                    if (string.IsNullOrEmpty(param.strId))
                    {
                        var PrcsFlowMgt = new ProcessFlowMgt();
                        param.strId = result;
                        await PrcsFlowMgt.ProceedFirstForwardToNext(param);
                    }

                    message = MessageConstants.Saved;
                resstate = MessageConstants.SuccessState;
            }
            else
            {
                message = MessageConstants.SavedWarning;
            }
        }
        catch (Exception ex)
        {
            Logs.Bug(ex);
        }
        return new
        {
            message,
            resstate
        };
    }

        //update quotation work order number ande refrence
        public async Task<object> UpdateQuation(string _mJsonData, string mstrRes)
        {
            string message = string.Empty; bool resstate = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            var data = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(_mJsonData);
            string quotId = null;
            if (data != null && data.Count > 0)
            {
               
                  quotId = data[0].ContainsKey("quotId") ? data[0]["quotId"]?.ToString() : null;
  
            }
            if (string.IsNullOrEmpty(quotId) || string.IsNullOrEmpty(mstrRes))
            {
              message= MessageConstants.DataNotFind;
            }
           
      

            try
            {
                using (_ctxOra = new ModelContext())
                {
                    var quation = _ctxOra.TQuotationsMasters.FirstOrDefault(c => c.Oid == quotId);
                    if (quation == null)
                    {
                        message = MessageConstants.DataNotFind;
                    }
                    quation.Workorderno = mstrRes;
                    quation.Isworkorder = "1";
                    _ctxOra.SaveChanges();
                    message = MessageConstants.Saved;
                    resstate = MessageConstants.SuccessState;
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                message,
                resstate
            };
        }



        public async Task<string> SaveUpdateTermsConditions(List<vmTermsCondition> trmConList, vmCmnParameter cparam)
    {
        string result = string.Empty;
        List<TTermsCondition> tcList = new List<TTermsCondition>();
        using (_ctxOra = new ModelContext())
        {
            int nMaxDetailId = 0, IncNumber = 1;
            string MaxDetailId = Extension.Get_OID("T_TERMS_CONDITIONS", "OID", "TTC", StaticInfos.conStringOracle);
            string dtlId = Regex.Replace(MaxDetailId, @"[^\d]", "");
            Int32.TryParse(dtlId, out nMaxDetailId);
            int MaxDetailIds = nMaxDetailId > 0 ? nMaxDetailId - 1 : nMaxDetailId;
            if (nMaxDetailId > 0)
            {
                foreach (var tcl in trmConList.Where(x => string.IsNullOrEmpty(x.tcOid) && !string.IsNullOrEmpty(x.termsConditions)))
                {
                    TTermsCondition tc = new TTermsCondition();
                    tc.Oid = Extension.GET_INC_OID("TTC", MaxDetailIds, IncNumber, StaticInfos.conStringOracle);
                    tc.Termsconditions = tcl.termsConditions;
                    tc.Isactive = Extension.BoolVal(tcl.isActive);
                    tc.Iscancel = Extension.BoolVal(tcl.isDelete);
                    tc.Createby = cparam.LoggedUserId;
                    tc.Createon = Extension.Today;
                    tc.Createpc = Extension.Createpc();
                    tcList.Add(tc);
                    IncNumber++;
                    tcl.tcOid = tc.Oid;
                }

                if (tcList.Count > 0)
                {
                    await _ctxOra.TTermsConditions.AddRangeAsync(tcList);
                    await _ctxOra.SaveChangesAsync();

                    result = JsonConvert.SerializeObject(trmConList);
                }
            }
        }

        return result;
    }



      










        public async Task<object> GetWithPagination(vmCmnParameter param) //vmCmnParameters cmnParam
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string listWorkOrder = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "qresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "PageNumber", (1, Convert.ToDecimal(param.pageNumber))},
                    { "PageSize", (2, Convert.ToDecimal(param.pageSize)) },
                    { "SearchVal", (3, param.SearchVal.Trim().ToLower()) },
                    { "LoggedUserId", (4, param.LoggedUserId) }
                };

                listWorkOrder = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_WorkOrderByPage, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                listWorkOrder
            };
        }


        public async Task<object> GetWorkOrderFreeQootatonWithPagination(vmCmnParameter param) //vmCmnParameters cmnParam
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string listQuotation = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "qresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "PageNumber", (1, Convert.ToDecimal(param.pageNumber))},
                    { "PageSize", (2, Convert.ToDecimal(param.pageSize)) },
                    { "SearchVal", (3, param.SearchVal.Trim().ToLower()) },
                    { "LoggedUserId", (4, param.LoggedUserId) }
                };

                listQuotation = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_WorkorderFreeQuot, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                listQuotation
            };
        }





        public async Task<object> GetByID(vmCmnParameter cparam)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string wrkOrdrMaster = string.Empty, wrkOrdrDetail = string.Empty, wrkDtl = string.Empty, termsCondition = string.Empty, objFlowDetail = string.Empty;
            try
            {
                var PrcsFlowMgt = new ProcessFlowMgt();
                ht = new Hashtable
                {
                    { "gresult", (0, OracleDbType.Clob, ParameterDirection.Output) },
                    { "gWorkOrderID", (1, OracleDbType.Varchar2, cparam.strId)}
                };
                 //gQuotationId
                wrkOrdrMaster = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutClob(StoredProcedure.Ora_SpGet_WorkOrderMasterById, ht, "gresult", StaticInfos.conStringOracle.ToString());
                if (cparam.strId2 == "CAT000001" || cparam.strId2 == "CAT000002" || cparam.strId2 == "CAT000004" || cparam.strId2 == "CAT000005" || cparam.strId2 == "CAT000009"||
                    cparam.strId2 == "CAT000003" || cparam.strId2 == "CAT000006" || cparam.strId2 == "CAT000007" || cparam.strId2 == "CAT000008"


                    )
                {
                    wrkDtl = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutClob(StoredProcedure.Ora_SpGet_WorkOrderDetailById, ht, "gresult", StaticInfos.conStringOracle.ToString());
                }





                wrkOrdrDetail = wrkDtl.Replace(":.0", ":0.0");
                termsCondition = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutClob(StoredProcedure.Ora_SpGet_WorkOrderTermsConditionById, ht, "gresult", StaticInfos.conStringOracle.ToString());
                //object objFlowDetails = PrcsFlowMgt.GetProcessFlowStepsByCategoryId(cparam).Result;
                object objFlowDetails = PrcsFlowMgt.GetApproveStepsByWorkOrderCatId(cparam).Result;
                JObject objFlowDtl = JObject.FromObject(objFlowDetails);
                objFlowDetail = objFlowDtl["objFlowDetail"].ToString();

               
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                wrkOrdrMaster,
                wrkOrdrDetail,
                termsCondition,
                objFlowDetail
            };
        }


   









        public async Task<object> GetRegularReport(vmReportModel rptm, vmCmnParameter cparam)
        {
            object bytes = null; bool resstate = false;
            try
            {
                dynamic objRes = await GetByID(cparam);
                var dataListMstr = Extension.GetReportDataTable(objRes.wrkOrdrMaster.ToString());
                var dataListDtl = Extension.GetReportDataTable(objRes.wrkOrdrDetail.ToString());
                var dataListTc = Extension.GetReportDataTable(objRes.termsCondition.ToString());
                var dataListPFlow = Extension.GetReportDataTable(objRes.objFlowDetail.ToString());


                dataListMstr = Extension.AddDataSetName(dataListMstr, "DataSet1");
                rptm.DataTableList.Add(dataListMstr);

                dataListDtl = Extension.AddDataSetName(dataListDtl, "DataSet2");
                rptm.DataTableList.Add(dataListDtl);

                dataListTc = Extension.AddDataSetName(dataListTc, "DataSet3");
                rptm.DataTableList.Add(dataListTc);

                dataListPFlow = Extension.AddDataSetName(dataListPFlow, "DataSet4");
                rptm.DataTableList.Add(dataListPFlow);

                bytes = ReportingService.Report(rptm).Result;

                if (bytes != null && bytes != string.Empty)
                {
                    resstate = true;
                }
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                bytes,
                resstate
            };
        }





        public async Task<object> GetWorkOrderReference(vmCmnParameter param)
        {
            string refr = string.Empty; object clientTypeInfo = null;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            try
            {
                //string Todats = Extension.Today.ToString("MMM/yyyy").ToUpper();
                string Todats = Extension.Today.ToString("ddMMyy").ToUpper();
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("gresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("gClientID", OracleDbType.Varchar2).Value = param.strId;
                ocmd.Parameters.Add("gCategoryID", OracleDbType.Varchar2).Value = param.values;
                ocmd.Parameters.Add("gWorkOrderID", OracleDbType.Varchar2).Value = param.strId2;
                ocmd.Parameters.Add("gBrandID", OracleDbType.Varchar2).Value = param.Name;
                ocmd.Parameters.Add("mTodate", OracleDbType.Varchar2).Value = Todats;

                refr = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpGet_WorkOrderRefNo, ocmd, "gresult", StaticInfos.conStringOracle.ToString());
                refr = refr == "null" ? null : refr;

                clientTypeInfo = await GetAllClientType(param.strId);
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }

            return new
            {
                refr,
                clientTypeInfo
            };
        }

        public async Task<object> GetAllClientType(string clieintId)
        {
            object listClientType = null; object result = null;
            try
            {
                using (_ctxOra = new ModelContext())
                {
                    listClientType = await (from tct in _ctxOra.TClientTypes
                                            join clnt in _ctxOra.TClients on tct.Oid equals clnt.ClientType
                                            where clnt.Oid == clieintId
                                            select new
                                            {
                                                oId = tct.Oid,
                                                typeName = tct.TypeTrno + "-" + tct.TypeName
                                            }
                                      ).FirstOrDefaultAsync();
                }
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }

            return result = new
            {
                listClientType
            };
        }


















    }
}