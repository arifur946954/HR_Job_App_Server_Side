using DataFactories.BaseFactory;
using DataFactories.Infrastructure.common.processflow;
using DataModel.EntityModels.OraModel;
using DataModel.ViewModels;
using DataModel.ViewModels.ERPViewModel.Business;
using DataModel.ViewModels.ERPViewModel.Common;
using DataUtility;
using Microsoft.AspNetCore.Http;
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

namespace DataFactories.Infrastructure.business.quotation
{
    public class QuotationMgt
    {
        #region Variable declaration & initialization
        ModelContext _ctxOra = null;
        private IGenericFactoryOracle<vmCmnParameter> OraGeneric_vmCmnParameter = null;
        OracleCommand ocmd = null;
        Hashtable ht = null; OracleParameter[] oprm = null;
        #endregion

        #region All Methods
        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> GetWithPagination(vmCmnParameter param) //vmCmnParameters cmnParam
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

                listQuotation = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_QuotationByPage, ht, StaticInfos.conStringOracle.ToString());
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



        /// <summary>
        /// This method returns data from database as an object using asynchronous operation by an int parameter.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> GetByID(vmCmnParameter cparam)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string quotMaster = string.Empty, quotDetail = string.Empty, qtDtl = string.Empty, termsCondition = string.Empty, objFlowDetail = string.Empty;
            try
            {
                var PrcsFlowMgt = new ProcessFlowMgt();
                ht = new Hashtable
                {
                    { "gresult", (0, OracleDbType.Clob, ParameterDirection.Output) },
                    { "gQuotationId", (1, OracleDbType.Varchar2, cparam.strId)}
                };

                quotMaster = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutClob(StoredProcedure.Ora_SpGet_QuotationMasterById, ht, "gresult", StaticInfos.conStringOracle.ToString());
                if (cparam.strId2 == "CAT000001" || cparam.strId2 == "CAT000002" || cparam.strId2 == "CAT000004" || cparam.strId2 == "CAT000005" || cparam.strId2 == "CAT000009")
                {
                    qtDtl = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutClob(StoredProcedure.Ora_SpGet_QuotationDetailById, ht, "gresult", StaticInfos.conStringOracle.ToString());
                }
                else if (cparam.strId2 == "CAT000007" || cparam.strId2 == "CAT000008")
                {
                    qtDtl = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutClob(StoredProcedure.Ora_SpGet_QuotationDetailMediaById, ht, "gresult", StaticInfos.conStringOracle.ToString());
                }
                else if (cparam.strId2 == "CAT000006")
                {
                    qtDtl = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutClob(StoredProcedure.Ora_SpGet_QuotationDetailPrintById, ht, "gresult", StaticInfos.conStringOracle.ToString());
                }
                else if (cparam.strId2 == "CAT000003")
                {
                    qtDtl = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutClob(StoredProcedure.Ora_SpGet_QuotationDetailBuyingById, ht, "gresult", StaticInfos.conStringOracle.ToString());
                }

                quotDetail = qtDtl.Replace(":.0", ":0.0");
                termsCondition = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutClob(StoredProcedure.Ora_SpGet_QuotationTermsConditionById, ht, "gresult", StaticInfos.conStringOracle.ToString());
                //object objFlowDetails = PrcsFlowMgt.GetProcessFlowStepsByCategoryId(cparam).Result;
                object objFlowDetails = PrcsFlowMgt.GetApproveStepsByQuotCatId(cparam).Result;
                JObject objFlowDtl = JObject.FromObject(objFlowDetails);
                objFlowDetail = objFlowDtl["objFlowDetail"].ToString();

                //ocmd = new OracleCommand();
                //ocmd.Parameters.Add("gresult", OracleDbType.Clob).Direction = ParameterDirection.Output;
                //ocmd.Parameters.Add("gQuotationId", OracleDbType.Varchar2).Value = cparam.strId;
                //quotMaster = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutClob(StoredProcedure.Ora_SpGet_QuotationMasterById, ocmd, "gresult", StaticInfos.conStringOracle.ToString());

                //ocmd = new OracleCommand();
                //ocmd.Parameters.Add("gresult", OracleDbType.Clob).Direction = ParameterDirection.Output;
                //ocmd.Parameters.Add("gQuotationId", OracleDbType.Varchar2).Value = cparam.strId;
                //quotDetail = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutClob(StoredProcedure.Ora_SpGet_QuotationDetailById, ocmd, "gresult", StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                quotMaster,
                quotDetail,
                termsCondition,
                objFlowDetail
            };
        }

        public async Task<object> GetQuotationReference(vmCmnParameter param)
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
                ocmd.Parameters.Add("gQuotationID", OracleDbType.Varchar2).Value = param.strId2;
                ocmd.Parameters.Add("mTodate", OracleDbType.Varchar2).Value = Todats;

                refr = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpGet_QuotationRefNo, ocmd, "gresult", StaticInfos.conStringOracle.ToString());
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

        public async Task<object> GetQuotationReferenceBak(vmCmnParameter param)
        {
            object result = null; string refr = string.Empty, clientId = string.Empty;
            using (_ctxOra = new ModelContext())
            {
                try
                {
                    clientId = string.IsNullOrEmpty(param.strId) ? string.Empty : param.strId;
                    if (!string.IsNullOrEmpty(clientId))
                    {
                        var client = await _ctxOra.TClients.Where(x => x.Oid == clientId).FirstOrDefaultAsync();
                        if (param.id > 0)
                        {
                            var QuoteModel = await _ctxOra.TQuotationMasters.Where(x => x.Numid == param.id).FirstOrDefaultAsync();
                            string refPreview = "E" + QuoteModel.Numid.ToString().PadLeft(4, '0') + "/SBC/" + client.ClientSname + "/" + Convert.ToDateTime(QuoteModel.QuotDate).ToString("ddMMyyyy").ToUpper();
                            refr = refPreview;
                        }
                        else
                        {
                            var MaxID = _ctxOra.TQuotationMasters.DefaultIfEmpty().Max(x => x == null ? 0 : x.Numid) + 1;
                            string refPreview = "E" + MaxID.ToString().PadLeft(4, '0') + "/SBC/" + client.ClientSname + "/" + Extension.Today.ToString("ddMMyyyy").ToUpper();
                            refr = refPreview;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logs.Bug(ex);
                }
            }

            return result = new
            {
                refr
            };
        }

        public async Task<object> SaveUpdateServiceHeadGroup(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            _ctxOra = new ModelContext();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_ServiceHeadGroup, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    var srvHead = _ctxOra.TServiceHeadGroups.Where(x => x.Oid == result).FirstOrDefault();
                    colId = srvHead.Oid;
                    colName = srvHead.HeadGroupName;
                    isSet = true;
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
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateServiceHead(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            _ctxOra = new ModelContext();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_ServiceHead, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    var srvHead = _ctxOra.TServiceHeads.Where(x => x.Oid == result).FirstOrDefault();
                    colId = srvHead.Oid;
                    colName = srvHead.HeadName;
                    isSet = true;
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
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateMediaBroadcast(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            _ctxOra = new ModelContext();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_Broadcast, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    var broadcast = _ctxOra.TMediaBroadcasts.Where(x => x.Oid == result).FirstOrDefault();
                    colId = broadcast.Oid;
                    colName = broadcast.BroadcastName;
                    isSet = true;
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
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateMediaProgram(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            _ctxOra = new ModelContext();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_Program, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    var program = _ctxOra.TMediaPrograms.Where(x => x.Oid == result).FirstOrDefault();
                    colId = program.Oid;
                    colName = program.ProgramName;
                    isSet = true;
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
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdatePrintMediaPublisher(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            _ctxOra = new ModelContext();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_BPublisher, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    var bpublisher = _ctxOra.TBpublishers.Where(x => x.Oid == result).FirstOrDefault();
                    colId = bpublisher.Oid;
                    colName = bpublisher.BpublisherName;
                    isSet = true;
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
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdatePrintMediaSupplement(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            _ctxOra = new ModelContext();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_BSupplements, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    var bsupplement = _ctxOra.TBsupplements.Where(x => x.Oid == result).FirstOrDefault();
                    colId = bsupplement.Oid;
                    colName = bsupplement.BsupplementsName;
                    isSet = true;
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
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdatePrintMediaPlacement(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTran = await _ctxOra.Database.BeginTransactionAsync())
                {
                    try
                    {
                        dynamic model = JsonConvert.DeserializeObject<dynamic>(_JsonData);
                        string MaxID = Extension.Get_OID("T_BPLACEMENT", "OID", "TBP", StaticInfos.conStringOracle);
                        string CustomCode = Extension.GET_CODE("T_BPLACEMENT", "OID", StaticInfos.conStringOracle);
                        var sModel = new TBplacement();
                        sModel.Oid = MaxID;
                        sModel.BplacementTrno = CustomCode;
                        sModel.BplacementName = model.bplacementName;
                        sModel.BplacementSname = model.bplacementSName;
                        //Common
                        bool isActive = Convert.ToBoolean(model.isActive);
                        sModel.Isactive = Extension.BoolVal(isActive);
                        sModel.Iscancel = Extension.BoolVal(false);
                        sModel.Createpc = Extension.Createpc();
                        sModel.Createby = param.LoggedUserId;
                        sModel.Createon = Extension.Today;

                        await _ctxOra.TBplacements.AddAsync(sModel);
                        await _ctxOra.SaveChangesAsync();
                        await _ctxOraTran.CommitAsync();

                        colId = MaxID;
                        colName = sModel.BplacementName;
                        isSet = true;
                        message = MessageConstants.Saved;
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTran.Rollback();
                        Logs.Bug(ex);
                        message = MessageConstants.SavedWarning;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }

            return new
            {
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateMediaGenre(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTran = await _ctxOra.Database.BeginTransactionAsync())
                {
                    try
                    {
                        dynamic model = JsonConvert.DeserializeObject<dynamic>(_JsonData);
                        string MaxID = Extension.Get_OID("T_MEDIA_GENRE", "OID", "TMG", StaticInfos.conStringOracle);
                        string CustomCode = Extension.GET_CODE("T_MEDIA_GENRE", "OID", StaticInfos.conStringOracle);
                        var sModel = new TMediaGenre();
                        sModel.Oid = MaxID;
                        sModel.GenreTrno = CustomCode;
                        sModel.GenreName = model.genreName;
                        sModel.GenreSname = model.genreSName;
                        //Common
                        bool isActive = Convert.ToBoolean(model.isActive);
                        sModel.Isactive = Extension.BoolVal(isActive);
                        sModel.Iscancel = Extension.BoolVal(false);
                        sModel.Createpc = Extension.Createpc();
                        sModel.Createby = param.LoggedUserId;
                        sModel.Createon = Extension.Today;

                        await _ctxOra.TMediaGenres.AddAsync(sModel);
                        await _ctxOra.SaveChangesAsync();
                        await _ctxOraTran.CommitAsync();

                        colId = MaxID;
                        colName = sModel.GenreName;
                        isSet = true;
                        message = MessageConstants.Saved;
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTran.Rollback();
                        Logs.Bug(ex);
                        message = MessageConstants.SavedWarning;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }

            return new
            {
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateMediaAdPosition(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTran = await _ctxOra.Database.BeginTransactionAsync())
                {
                    try
                    {
                        dynamic model = JsonConvert.DeserializeObject<dynamic>(_JsonData);
                        string MaxID = Extension.Get_OID("T_MEDIA_AD_POSITION", "OID", "TMAP", StaticInfos.conStringOracle);
                        string CustomCode = Extension.GET_CODE("T_MEDIA_AD_POSITION", "OID", StaticInfos.conStringOracle);
                        var sModel = new TMediaAdPosition();
                        sModel.Oid = MaxID;
                        sModel.PositionTrno = CustomCode;
                        sModel.PositionName = model.positionName;
                        sModel.PositionSname = model.positionSName;
                        //Common
                        bool isActive = Convert.ToBoolean(model.isActive);
                        sModel.Isactive = Extension.BoolVal(isActive);
                        sModel.Iscancel = Extension.BoolVal(false);
                        sModel.Createpc = Extension.Createpc();
                        sModel.Createby = param.LoggedUserId;
                        sModel.Createon = Extension.Today;

                        await _ctxOra.TMediaAdPositions.AddAsync(sModel);
                        await _ctxOra.SaveChangesAsync();
                        await _ctxOraTran.CommitAsync();

                        colId = MaxID;
                        colName = sModel.PositionName;
                        isSet = true;
                        message = MessageConstants.Saved;
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTran.Rollback();
                        Logs.Bug(ex);
                        message = MessageConstants.SavedWarning;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }

            return new
            {
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateMediaDay(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTran = await _ctxOra.Database.BeginTransactionAsync())
                {
                    try
                    {
                        dynamic model = JsonConvert.DeserializeObject<dynamic>(_JsonData);
                        string MaxID = Extension.Get_OID("T_MEDIA_DAY", "OID", "TMD", StaticInfos.conStringOracle);
                        string CustomCode = Extension.GET_CODE("T_MEDIA_DAY", "OID", StaticInfos.conStringOracle);
                        var sModel = new TMediaDay();
                        sModel.Oid = MaxID;
                        sModel.DayTrno = CustomCode;
                        sModel.DayName = model.dayName;
                        sModel.DaySname = model.daySName;
                        //Common
                        bool isActive = Convert.ToBoolean(model.isActive);
                        sModel.Isactive = Extension.BoolVal(isActive);
                        sModel.Iscancel = Extension.BoolVal(false);
                        sModel.Createpc = Extension.Createpc();
                        sModel.Createby = param.LoggedUserId;
                        sModel.Createon = Extension.Today;

                        await _ctxOra.TMediaDays.AddAsync(sModel);
                        await _ctxOra.SaveChangesAsync();
                        await _ctxOraTran.CommitAsync();

                        colId = MaxID;
                        colName = sModel.DayName;
                        isSet = true;
                        message = MessageConstants.Saved;
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTran.Rollback();
                        Logs.Bug(ex);
                        message = MessageConstants.SavedWarning;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }

            return new
            {
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateMediaDayPart(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTran = await _ctxOra.Database.BeginTransactionAsync())
                {
                    try
                    {
                        dynamic model = JsonConvert.DeserializeObject<dynamic>(_JsonData);
                        string MaxID = Extension.Get_OID("T_MEDIA_DAY_PART", "OID", "TMDP", StaticInfos.conStringOracle);
                        string CustomCode = Extension.GET_CODE("T_MEDIA_DAY_PART", "OID", StaticInfos.conStringOracle);
                        var sModel = new TMediaDayPart();
                        sModel.Oid = MaxID;
                        sModel.DaypartTrno = CustomCode;
                        sModel.DaypartName = model.dayPartName;
                        sModel.DaypartSname = model.dayPartSName;
                        //Common
                        bool isActive = Convert.ToBoolean(model.isActive);
                        sModel.Isactive = Extension.BoolVal(isActive);
                        sModel.Iscancel = Extension.BoolVal(false);
                        sModel.Createpc = Extension.Createpc();
                        sModel.Createby = param.LoggedUserId;
                        sModel.Createon = Extension.Today;

                        await _ctxOra.TMediaDayParts.AddAsync(sModel);
                        await _ctxOra.SaveChangesAsync();
                        await _ctxOraTran.CommitAsync();

                        colId = MaxID;
                        colName = sModel.DaypartName;
                        isSet = true;
                        message = MessageConstants.Saved;
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTran.Rollback();
                        Logs.Bug(ex);
                        message = MessageConstants.SavedWarning;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }

            return new
            {
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateMediaSponsor(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTran = await _ctxOra.Database.BeginTransactionAsync())
                {
                    try
                    {
                        dynamic model = JsonConvert.DeserializeObject<dynamic>(_JsonData);
                        string MaxID = Extension.Get_OID("T_MEDIA_SPONSOR", "OID", "TMS", StaticInfos.conStringOracle);
                        string CustomCode = Extension.GET_CODE("T_MEDIA_SPONSOR", "OID", StaticInfos.conStringOracle);
                        var sModel = new TMediaSponsor();
                        sModel.Oid = MaxID;
                        sModel.SponsorTrno = CustomCode;
                        sModel.SponsorName = model.sponsorName;
                        sModel.SponsorSname = model.sponsorSName;
                        //Common
                        bool isActive = Convert.ToBoolean(model.isActive);
                        sModel.Isactive = Extension.BoolVal(isActive);
                        sModel.Iscancel = Extension.BoolVal(false);
                        sModel.Createpc = Extension.Createpc();
                        sModel.Createby = param.LoggedUserId;
                        sModel.Createon = Extension.Today;

                        await _ctxOra.TMediaSponsors.AddAsync(sModel);
                        await _ctxOra.SaveChangesAsync();
                        await _ctxOraTran.CommitAsync();

                        colId = MaxID;
                        colName = sModel.SponsorName;
                        isSet = true;
                        message = MessageConstants.Saved;
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTran.Rollback();
                        Logs.Bug(ex);
                        message = MessageConstants.SavedWarning;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }

            return new
            {
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateMediaSponsoredProject(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTran = await _ctxOra.Database.BeginTransactionAsync())
                {
                    try
                    {
                        dynamic model = JsonConvert.DeserializeObject<dynamic>(_JsonData);
                        string MaxID = Extension.Get_OID("T_MEDIA_SPONSORED_PROJECT", "OID", "TMSP", StaticInfos.conStringOracle);
                        string CustomCode = Extension.GET_CODE("T_MEDIA_SPONSORED_PROJECT", "OID", StaticInfos.conStringOracle);
                        var sModel = new TMediaSponsoredProject();
                        sModel.Oid = MaxID;
                        sModel.ProjectTrno = CustomCode;
                        sModel.ProjectName = model.projectName;
                        sModel.ProjectSname = model.projectSName;
                        sModel.SponsorOid = model.sponsorId;
                        //Common
                        bool isActive = Convert.ToBoolean(model.isActive);
                        sModel.Isactive = Extension.BoolVal(isActive);
                        sModel.Iscancel = Extension.BoolVal(false);
                        sModel.Createpc = Extension.Createpc();
                        sModel.Createby = param.LoggedUserId;
                        sModel.Createon = Extension.Today;

                        await _ctxOra.TMediaSponsoredProjects.AddAsync(sModel);
                        await _ctxOra.SaveChangesAsync();
                        await _ctxOraTran.CommitAsync();

                        colId = MaxID;
                        colName = sModel.ProjectName;
                        isSet = true;
                        message = MessageConstants.Saved;
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTran.Rollback();
                        Logs.Bug(ex);
                        message = MessageConstants.SavedWarning;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }

            return new
            {
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdatePlatform(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            _ctxOra = new ModelContext();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_BPlatform, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    var bplatform = _ctxOra.TBplatforms.Where(x => x.Oid == result).FirstOrDefault();
                    colId = bplatform.Oid;
                    colName = bplatform.BplatformName;
                    isSet = true;
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
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateParameter(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            _ctxOra = new ModelContext();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_BParameter, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    var bparameter = _ctxOra.TBparameters.Where(x => x.Oid == result).FirstOrDefault();
                    colId = bparameter.Oid;
                    colName = bparameter.BparameterName;
                    isSet = true;
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
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateParameterTask(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            _ctxOra = new ModelContext();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_BParameterTask, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    var bparameterTask = _ctxOra.TBparameterTasks.Where(x => x.Oid == result).FirstOrDefault();
                    colId = bparameterTask.Oid;
                    colName = bparameterTask.BparametertaskName;
                    isSet = true;
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
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateMetrics(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            _ctxOra = new ModelContext();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_BMetrics, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    var bmetric = _ctxOra.TBmetrics.Where(x => x.Oid == result).FirstOrDefault();
                    colId = bmetric.Oid;
                    colName = bmetric.BmetricsName;
                    isSet = true;
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
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> SaveUpdateAssetType(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            object colId = null; string colName = string.Empty; bool isSet = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            _ctxOra = new ModelContext();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_BAssetType, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    var bassetType = _ctxOra.TBassetTypes.Where(x => x.Oid == result).FirstOrDefault();
                    colId = bassetType.Oid;
                    colName = bassetType.BassettypeName;
                    isSet = true;
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
                colId,
                colName,
                isSet,
                message,
                resstate
            };
        }

        public async Task<object> InsertIntoDetails(string _strQuoteDetailList, vmCmnParameter param)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string objQuotation = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("iresult", OracleDbType.Varchar2, 1).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("iJS_DATA", OracleDbType.Clob).Value = _strQuoteDetailList.ToString();
                ocmd.Parameters.Add("iQuotationId", OracleDbType.Decimal).Value = (decimal)param.id;
                ocmd.Parameters.Add("iCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("iCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                objQuotation = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_QuotationDetail, ocmd, "iresult", StaticInfos.conStringOracle.ToString());

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                objQuotation
            };
        }

        public async Task<object> SaveUpdate(string _mJsonData, string _dJsonData, string _tcJsonData, vmCmnParameter param)
        {
            object referenceId = 0; string message = string.Empty; bool resstate = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string result = string.Empty, mstrRes = string.Empty;
            try
            {
                //ocmd = new OracleCommand();
                //ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                //ocmd.Parameters.Add("JsonData_Mstr", OracleDbType.Clob).Value = _mJsonData;
                //ocmd.Parameters.Add("JsonData_Dtl", OracleDbType.Clob).Value = _dJsonData;
                //ocmd.Parameters.Add("JsonData_TCN", OracleDbType.Clob).Value = _tcJsonData;
                //ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                //ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData_Mstr", OracleDbType.Clob).Value = _mJsonData;
                ocmd.Parameters.Add("JsonData_TCN", OracleDbType.Clob).Value = _tcJsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                mstrRes = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_QuotationMaster, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(mstrRes) && mstrRes != "null")
                {
                    ocmd = new OracleCommand();
                    ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                    ocmd.Parameters.Add("Mstr_OID", OracleDbType.Varchar2).Value = mstrRes;
                    ocmd.Parameters.Add("JsonData_Dtl", OracleDbType.Clob).Value = _dJsonData;
                    ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                    ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                    if (param.strId2 == "CAT000001" || param.strId2 == "CAT000002" || param.strId2 == "CAT000004" || param.strId2 == "CAT000005" || param.strId2 == "CAT000009")
                    {
                        result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_QuotationDetail_Common, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                    }
                    else if (param.strId2 == "CAT000007" || param.strId2 == "CAT000008")
                    {
                        result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_QuotationMasterDetail_Media, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                    }
                    else if (param.strId2 == "CAT000006")
                    {
                        result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_QuotationMasterDetail_Print, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                    }
                    else if (param.strId2 == "CAT000003")
                    {
                        result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_QuotationMasterDetail_Buying, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                    }
                }

                if (!string.IsNullOrEmpty(result) && result != "0" && result != "null")
                {
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
        #endregion

        #region Reporting
        public async Task<object> GetRegularReport(vmReportModel rptm, vmCmnParameter cparam)
        {
            object bytes = null; bool resstate = false;
            try
            {
                dynamic objRes = await GetByID(cparam);
                var dataListMstr = Extension.GetReportDataTable(objRes.quotMaster.ToString());
                var dataListDtl = Extension.GetReportDataTable(objRes.quotDetail.ToString());
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

        public async Task<object> GetRegularReports(string reportPath, string repType, vmCmnParameter cparam)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object bytes = null; bool resstate = false; string listTable = string.Empty;
            List<DataTable> listDataTable = new List<DataTable>();
            DataTable dataListMstr = new DataTable();
            DataTable dataListDtl = new DataTable();
            DataTable dataListTc = new DataTable();
            DataTable dataListPFlow = new DataTable();
            string parameterList = string.Empty;
            try
            {
                dynamic objRes = await GetByID(cparam);
                dataListMstr = Extension.GetReportDataTable(objRes.quotMaster.ToString());
                dataListDtl = Extension.GetReportDataTable(objRes.quotDetail.ToString());
                dataListTc = Extension.GetReportDataTable(objRes.termsCondition.ToString());
                dataListPFlow = Extension.GetReportDataTable(objRes.objFlowDetail.ToString());


                dataListMstr = Extension.AddDataSetName(dataListMstr, "DataSet1");
                listDataTable.Add(dataListMstr);

                dataListDtl = Extension.AddDataSetName(dataListDtl, "DataSet2");
                listDataTable.Add(dataListDtl);

                dataListTc = Extension.AddDataSetName(dataListTc, "DataSet3");
                listDataTable.Add(dataListTc);

                dataListPFlow = Extension.AddDataSetName(dataListPFlow, "DataSet4");
                listDataTable.Add(dataListPFlow);

                listTable = JsonConvert.SerializeObject(listDataTable);

                //bytes = ReportingService.Report(listDataTable, parameterList, reportPath, repType);

                //if (bytes != null)
                //{
                //    resstate = true;
                //}
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listDataTable,
                listTable
            };
        }
        #endregion
    }
}
