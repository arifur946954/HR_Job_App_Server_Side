using DataFactories.BaseFactory;
using DataModel.EntityModels.OraModel;
using DataModel.ViewModels;
using DataModel.ViewModels.ERPViewModel.Business;
using DataUtility;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataFactories.Infrastructure.common.processflow
{
    public class ProcessFlowMgt
    {
        #region Variable declaration & initialization
        ModelContext _ctxOra = null;
        private IGenericFactoryOracle<vmCmnParameter> OraGeneric_vmCmnParameter = null;
        OracleCommand ocmd = null;
        Hashtable ht = null; OracleParameter[] oprm = null;
        #endregion

        #region All Methods
        #region Process Flow Setup
        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> GetListByhPage(vmCmnParameter param) //vmCmnParameters cmnParam
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string listProcessFlow = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "presult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "PageNumber", (1, Convert.ToDecimal(param.pageNumber))},
                    { "PageSize", (2, Convert.ToDecimal(param.pageSize)) }
                };

                listProcessFlow = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ProcessFlowByPage, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                listProcessFlow
            };
        }

        /// <summary>
        /// This method returns data from database as an object using asynchronous operation by an int parameter.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> GetByID(string id)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string objMaster = string.Empty, objDetail = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "presult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "P_ProcessFlowId", (1, id)}
                };

                objMaster = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ProcessFlowByID, ht, StaticInfos.conStringOracle.ToString());
                objDetail = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ProcessFlowDetailByID, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                objMaster,
                objDetail
            };
        }

        public async Task<object> GetProcessFlowStepsByCategoryId(vmCmnParameter cparam)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string objFlowDetail = string.Empty;
            try
            {
                ht = new Hashtable
                {
                    { "presult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "P_CategoryId", (1, cparam.strId2)}
                };

                objFlowDetail = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ProcessFlowDetailByCategoryID, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                objFlowDetail
            };
        }

        public async Task<object> GetApproveStepsByQuotCatId(vmCmnParameter cparam)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string objFlowDetail = string.Empty;
            try
            {
                ht = new Hashtable
                {
                    { "presult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "P_QuotationId", (1, cparam.strId)},
                    { "P_CategoryId", (2, cparam.strId2)}
                };

                objFlowDetail = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ProcessFlowDetailByQuotCatID, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                objFlowDetail
            };
        }

        //work order process flow
        public async Task<object> GetApproveStepsByWorkOrderCatId(vmCmnParameter cparam)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string objFlowDetail = string.Empty;
            try
            {
                ht = new Hashtable
                {
                    { "presult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "P_QuotationId", (1, cparam.strId)},
                    { "P_CategoryId", (2, cparam.strId2)}
                };

                objFlowDetail = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ProcessFlowById, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                objFlowDetail
            };
        }

        /// <summary>
        /// Both insert and update can perform by CmnUserRole model in database using asynchronous operation. when id is more than 0 update is performed otherwise insert. it returns an object as status of success or failure.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<object> SaveUpdate(string _mJsonData, string _dJsonData, vmCmnParameter param)
        {
            object referenceId = 0; string message = string.Empty; bool resstate = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("presult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData_Mstr", OracleDbType.Clob).Value = _mJsonData;
                ocmd.Parameters.Add("JsonData_Dtl", OracleDbType.Clob).Value = _dJsonData;
                ocmd.Parameters.Add("pCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("pCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_ProcessFlowMasterDetail, ocmd, "presult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0" && result != "null")
                {
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

        //private static readonly Regex rxNonDigits = new Regex(@"[^\d]+");

        public async Task<object> SaveUpdate(vmCmnParameter cparam, vmProcessFlow model, List<vmProcessFlowDetail> DetailList)
        {
            object result = null; string message = string.Empty, MaxID = string.Empty, CustomCode = string.Empty; bool resstate = false; int succtype = 0;

            using (_ctxOra = new ModelContext())
            {
                using (var _ctxTransaction = _ctxOra.Database.BeginTransaction())
                {
                    try
                    {
                        var exconn = await _ctxOra.TProcessFlows.FirstOrDefaultAsync(x => x.Categoryid == model.categoryId);
                        if (!string.IsNullOrEmpty(model.processFlowId))
                        {
                            var pFlow = await _ctxOra.TProcessFlows.FirstOrDefaultAsync(x => x.Processflowid == model.processFlowId);
                            pFlow.Categoryid = model.categoryId;
                            pFlow.Isactive = Extension.BoolVal(model.IsActive);
                            pFlow.Updateby = cparam.LoggedUserId;
                            pFlow.Updateon = Extension.Today;
                            pFlow.Updatepc = Extension.Createpc();
                            var deldetaillist = await _ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == model.processFlowId).ToListAsync();
                            _ctxOra.TProcessFlowDetails.RemoveRange(deldetaillist);
                            await _ctxOra.SaveChangesAsync();
                        }
                        else
                        {
                            if (exconn == null)
                            {
                                MaxID = Extension.Get_OID("T_PROCESS_FLOW", "PROCESSFLOWID", "TPF", StaticInfos.conStringOracle);
                                CustomCode = Extension.GET_CODE("T_PROCESS_FLOW", "PROCESSFLOWID", StaticInfos.conStringOracle);
                                var pFlow = new TProcessFlow();
                                pFlow.Processflowid = MaxID;
                                pFlow.Processflowcode = CustomCode;
                                pFlow.Categoryid = model.categoryId;
                                pFlow.Isactive = Extension.BoolVal(model.IsActive);

                                //Common
                                pFlow.Iscancel = Extension.BoolVal(false);
                                pFlow.Createby = cparam.LoggedUserId;
                                pFlow.Createon = Extension.Today;
                                pFlow.Createpc = Extension.Createpc();

                                await _ctxOra.TProcessFlows.AddAsync(pFlow);
                            }
                        }

                        if ((!string.IsNullOrEmpty(MaxID) && exconn == null) || !string.IsNullOrEmpty(model.processFlowId))
                        {
                            int nMaxDetailId = 0, IncNumber = 1;
                            string MaxDetailId = Extension.Get_OID("T_PROCESS_FLOW_DETAIL", "PROCESSFLOWDETAILID", "TPFD", StaticInfos.conStringOracle);
                            string dtlId = Regex.Replace(MaxDetailId, @"[^\d]", "");
                            nMaxDetailId = Int32.Parse(dtlId);
                            nMaxDetailId -= 1;
                            List<TProcessFlowDetail> newDetailList = new List<TProcessFlowDetail>();
                            foreach (var dl in DetailList)
                            {
                                var pd = new TProcessFlowDetail();
                                pd.Processflowdetailid = Extension.GET_INC_OID("TPFD", nMaxDetailId, IncNumber, StaticInfos.conStringOracle);
                                pd.Processflowid = string.IsNullOrEmpty(MaxID) ? model.processFlowId : MaxID;
                                pd.Processtypeid = dl.processTypeId.ToString();
                                pd.Userid = dl.userId;
                                pd.Categoryid = dl.categoryId;
                                pd.Sequences = dl.sequences;

                                pd.Iscancel = Extension.BoolVal(false);
                                pd.Isactive = Extension.BoolVal(model.IsActive);
                                pd.Createby = cparam.LoggedUserId;
                                pd.Createon = Extension.Today;
                                pd.Createpc = Extension.Createpc();
                                newDetailList.Add(pd);
                                IncNumber++;
                            }

                            if (newDetailList.Count > 0)
                            {
                                await _ctxOra.TProcessFlowDetails.AddRangeAsync(newDetailList);
                            }

                            message = MessageConstants.Saved;
                            succtype = 1;
                        }
                        else
                        {
                            message = MessageConstants.ProcessFlowExist;
                            succtype = 2;
                        }

                        await _ctxOra.SaveChangesAsync();

                        _ctxTransaction.Commit();
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxTransaction.Rollback();
                        Logs.Bug(ex);
                        message = MessageConstants.SavedWarning;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }
            return result = new
            {
                message,
                resstate,
                succtype
            };
        }

        /// <summary>
        /// Delete can perform to CmnUserRole table by int parameter in database using asynchronous operation. It returns an object as status of success or failure.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> DeleteByID(vmCmnParameter param)
        {
            object result = null; string message = string.Empty; bool resstate = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTran = await _ctxOra.Database.BeginTransactionAsync())
                {
                    try
                    {
                        if (param.id > 0)
                        {
                            var delmodel = await _ctxOra.TProcessFlows.Where(x => x.Processflowid == param.strId).FirstOrDefaultAsync();
                            delmodel.Iscancel = Extension.BoolVal(true);
                            delmodel.Updatepc = Extension.Createpc();
                            delmodel.Updateby = param.LoggedUserId;
                            delmodel.Updateon = Extension.Today;

                            var delDtlList = await _ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == param.strId).ToListAsync();
                            foreach (var item in delDtlList)
                            {
                                item.Iscancel = Extension.BoolVal(true);
                                item.Updatepc = Extension.Createpc();
                                item.Updateby = param.LoggedUserId;
                                item.Updateon = Extension.Today;
                            }
                        }

                        await _ctxOra.SaveChangesAsync();
                        _ctxOraTran.Commit();
                        message = MessageConstants.Deleted;
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTran.Rollback();
                        Logs.Bug(ex);
                        message = MessageConstants.DeletedWarning;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }

            return result = new
            {
                message,
                resstate
            };
        }
        #endregion Process Flow Setup

        public async Task<object> GetApprovalComments(vmCmnParameter param)
        {
            object tranMstr = null; string tranDtl = string.Empty;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            try
            {
                using (_ctxOra = new ModelContext())
                {
                    var pTrans = await _ctxOra.TProcessTrans.Where(x => x.Transactionid == param.strId && x.Userid == param.LoggedUserId).FirstOrDefaultAsync();
                    //var quot = await _ctxOra.TQuotationMasters.Where(x => x.Oid == param.strId).FirstOrDefaultAsync();
                    int maxSequence = (int)_ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == pTrans.Processflowid && x.Categoryid == param.strId2).Max(x => x.Sequences);
                    int minSequence = (int)_ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == pTrans.Processflowid && x.Categoryid == param.strId2).Min(x => x.Sequences);
                    int prevSequence = 0;
                    if (pTrans.Isapproved == Extension.BoolVal(true))
                    {
                        prevSequence = (int)_ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == pTrans.Processflowid && x.Categoryid == param.strId2 && x.Sequences < pTrans.Currentsequence).OrderByDescending(x => x.Sequences).FirstOrDefault().Sequences;
                    }
                    else if (pTrans.Isdeclined == Extension.BoolVal(true))
                    {
                        prevSequence = (int)_ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == pTrans.Processflowid && x.Categoryid == param.strId2 && x.Sequences > pTrans.Currentsequence).OrderBy(x => x.Sequences).FirstOrDefault().Sequences;
                    }

                    tranMstr = await (from tpt in _ctxOra.TProcessTrans
                                      where tpt.Transactionid == param.strId && tpt.Userid == param.LoggedUserId
                                      select new
                                      {
                                          transactionId = tpt.Transactionid,
                                          quotationId = tpt.Transactionid,
                                          categoryId = tpt.Categoryid,
                                          processFlowId = tpt.Processflowid,
                                          processFlowDetailId = tpt.Processflowdetailid,
                                          processTypeId = tpt.Processtypeid,
                                          minSequence,
                                          prevSequence,
                                          currentSequence = tpt.Currentsequence,
                                          fromUserId = tpt.Fromuserid,
                                          toUserId = tpt.Touserid,
                                          userId = tpt.Userid,
                                          status = tpt.Status,
                                          isApprovedAll = tpt.Isapprovedall,
                                          isApproved = tpt.Isapproved,
                                          isDeclined = tpt.Isdeclined,
                                          approvedUserId = tpt.Approveduserid,
                                          declinedUserId = tpt.Declineduserid,
                                          comments = "",
                                          forward = tpt.Currentsequence == maxSequence ? "Approve" : "Forward",
                                          backward = tpt.Currentsequence == maxSequence ? "Decline" : "Backward"
                                      }
                                 ).FirstOrDefaultAsync();
                    if (tranMstr != null)
                    {
                        ht = new Hashtable
                        {
                            { "presult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                            { "P_TransactionId", (1, pTrans.Transactionid)}
                        };

                        tranDtl = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_CommentsByID, ht, StaticInfos.conStringOracle.ToString());
                    }


                }
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                tranMstr,
                tranDtl
            };
        }

        public async Task<object> GetApprovalCommentsByLoggedUser(vmCmnParameter cparam)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string commentsList = string.Empty;
            try
            {
                ht = new Hashtable
                {
                    { "presult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "P_LoggedUserId", (1, cparam.LoggedUserId)}
                };

                commentsList = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_CommentsByLoggedUser, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                commentsList
            };
        }

        #region approval first proceedure
        public async Task<object> ProceedFirstForwardToNext(vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false, issuccess = false; object result = null;
            //List<vmIspTeamUser> listIspTeamUser = new List<vmIspTeamUser>();
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxTransaction = _ctxOra.Database.BeginTransaction())
                {
                    try
                    {
                        var quot = _ctxOra.TQuotationMasters.Where(x => x.Oid == param.strId && x.CategoryOid == param.strId2).FirstOrDefault(); //&& x.IsInProcess == false
                        if (quot != null)
                        {
                            var maxTransactionId = Extension.Get_OID("T_PROCESS_TRAN", "TRANSACTIONID", "TPT", StaticInfos.conStringOracle);
                            var maxTransactionDetailId = Extension.Get_OID("T_PROCESS_TRAN_DETAIL", "TRANSACTIONDETAILID", "TPTD", StaticInfos.conStringOracle);

                            //Insert
                            List<TProcessTran> approvalProcesslist = new List<TProcessTran>();
                            List<TProcessTranDetail> approvalProcesslistDetails = new List<TProcessTranDetail>();

                            if (!string.IsNullOrEmpty(quot.Oid))
                            {
                                var objFlowType = _ctxOra.TProcessFlows.Where(x => x.Categoryid == quot.CategoryOid).FirstOrDefault();
                                var strtFlowDtl = _ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == objFlowType.Processflowid).OrderBy(x => x.Sequences).First();
                                //var nexProcess = _ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == objFlowType.Processflowid && x.Sequences > strtProcess.Sequences).OrderBy(x => x.Sequences).First();
                                //var nearest = array.OrderBy(x => Math.Abs((long)x - targetNumber)).First();

                                //var objProcess = (from p in _ctxOra.TProcessFlowDetails where p.Sequences == 1 && p.Processflowid == objFlowType.Processflowid select p).FirstOrDefault();
                                //var objProcessNext = (from p in _ctxOra.TProcessFlowDetails where p.Sequences == (objProcess.Sequences + 1) && p.Processflowid == objFlowType.Processflowid select p).FirstOrDefault();

                                //var ispTeam = _ctx.SalIspTeam.Where(x => x.TeamId == objProcess.TeamId).FirstOrDefault();

                                var cpft = _ctxOra.TProcessTrans.Where(x => x.Transactionid == quot.Oid).FirstOrDefault();
                                bool proceed = false;
                                if (cpft == null)
                                {
                                    proceed = true;
                                }

                                if (proceed)
                                {
                                    //Trnsaction Master table
                                    var objTran = new TProcessTran();
                                    objTran.Transactionid = maxTransactionId;
                                    objTran.Transactionid = quot.Oid;
                                    objTran.Categoryid = quot.CategoryOid;
                                    objTran.Processflowid = strtFlowDtl.Processflowid;
                                    objTran.Processflowdetailid = strtFlowDtl.Processflowdetailid;
                                    objTran.Processtypeid = strtFlowDtl.Processtypeid;
                                    objTran.Currentsequence = strtFlowDtl.Sequences;
                                    objTran.Fromuserid = strtFlowDtl.Userid;
                                    objTran.Touserid = strtFlowDtl.Userid;
                                    objTran.Userid = strtFlowDtl.Userid;
                                    objTran.Status = strtFlowDtl.Sequences;
                                    objTran.Isapprovedall = Extension.BoolVal(false);
                                    objTran.Isapproved = Extension.BoolVal(false);
                                    objTran.Isdeclined = Extension.BoolVal(false);
                                    objTran.Approveduserid = null;
                                    objTran.Declineduserid = null;
                                    objTran.Comments = "";
                                    objTran.Approvedcomments = "";
                                    objTran.Declinedcomments = "";

                                    objTran.Createby = param.LoggedUserId;
                                    objTran.Createon = Extension.Today;
                                    objTran.Createpc = Extension.Createpc();

                                    approvalProcesslist.Add(objTran);

                                    //Trnsaction Log table
                                    var objTranDetail = new TProcessTranDetail();
                                    objTranDetail.Transactiondetailid = maxTransactionDetailId;
                                    objTranDetail.Transactionid = maxTransactionId;
                                    objTranDetail.Transactionid = quot.Oid;
                                    objTranDetail.Categoryid = quot.CategoryOid;
                                    objTranDetail.Processflowid = strtFlowDtl.Processflowid;
                                    objTranDetail.Processflowdetailid = strtFlowDtl.Processflowdetailid;
                                    objTranDetail.Processtypeid = strtFlowDtl.Processtypeid;
                                    objTranDetail.Currentsequence = strtFlowDtl.Sequences;
                                    objTranDetail.Fromuserid = strtFlowDtl.Userid;
                                    objTranDetail.Touserid = strtFlowDtl.Userid;
                                    objTranDetail.Userid = strtFlowDtl.Userid;
                                    objTranDetail.Status = strtFlowDtl.Sequences;
                                    objTranDetail.Isapproved = Extension.BoolVal(false);
                                    objTranDetail.Isdeclined = Extension.BoolVal(false);
                                    objTranDetail.Approveduserid = null;
                                    objTranDetail.Declineduserid = null;
                                    objTranDetail.Comments = "";
                                    objTranDetail.Approvedcomments = "";
                                    objTranDetail.Declinedcomments = "";

                                    objTranDetail.Createby = param.LoggedUserId;
                                    objTranDetail.Createon = Extension.Today;
                                    objTranDetail.Createpc = Extension.Createpc();

                                    approvalProcesslistDetails.Add(objTranDetail);

                                    #region Set Transaction Detail History
                                    TProcessTranDetailHstry cpftdh = new TProcessTranDetailHstry();
                                    cpftdh = SetTransactionDetailHistory(cpftdh, objTranDetail, param.LoggedUserId);
                                    _ctxOra.TProcessTranDetailHstries.Add(cpftdh);
                                    #endregion Set Transaction Detail History
                                    //maxTransactionDetailId++;
                                    //maxTransactionId++;

                                    //vmIspTeamUser objIspTeamUser = new vmIspTeamUser();
                                    //objIspTeamUser.TeamId = ispTeam.TeamId;
                                    //objIspTeamUser.UserId = ispTeam.CmnUserId;
                                    //listIspTeamUser.Add(objIspTeamUser);

                                    quot.Isinprocess = Extension.BoolVal(true);
                                    //quot.Transactiondetailid = maxTransactionDetailId;

                                    message = MessageConstants.ApprovalProceedSuccess;
                                    issuccess = Extension.BoolVal(quot.Isinprocess);
                                }
                                else
                                {
                                    message = MessageConstants.ApprovalProceedError;
                                }
                            }

                            if (approvalProcesslist.Count > 0)
                            {
                                await _ctxOra.TProcessTrans.AddRangeAsync(approvalProcesslist);
                            }

                            if (approvalProcesslistDetails.Count > 0)
                            {
                                await _ctxOra.TProcessTranDetails.AddRangeAsync(approvalProcesslistDetails);
                            }

                            resstate = MessageConstants.SuccessState;
                            await _ctxOra.SaveChangesAsync();
                            _ctxTransaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        //listIspTeamUser = new List<vmIspTeamUser>();
                        _ctxTransaction.Rollback();
                        Logs.Bug(ex);
                        message = MessageConstants.ApprovalProceedError;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }

            return result = new
            {
                message,
                resstate,
                issuccess
            };
        }
        #endregion

        #region approval other proceedure
        private TProcessTranDetailHstry SetTransactionDetailHistory(TProcessTranDetailHstry cpftdh, TProcessTranDetail cpftd, string loggedUserId)
        {
            cpftdh.Transactiondetilhistoryid = Extension.Get_OID("T_PROCESS_TRAN_DETAIL_HSTRY", "TRANSACTIONDETILHISTORYID", "TPTDH", StaticInfos.conStringOracle);
            cpftdh.Transactiondetailid = cpftd.Transactiondetailid;
            cpftdh.Transactionid = cpftd.Transactionid;
            cpftdh.Fromuserid = cpftd.Fromuserid;
            cpftdh.Touserid = cpftd.Touserid;
            cpftdh.Userid = cpftd.Userid;
            cpftdh.Status = cpftd.Status;
            cpftdh.Isapproved = cpftd.Isapproved;
            cpftdh.Comments = cpftd.Comments;
            cpftdh.Isactive = Extension.BoolVal(true);
            cpftdh.Iscancel = Extension.BoolVal(false);
            cpftdh.Createby = loggedUserId;
            cpftdh.Createon = Extension.Today;
            cpftdh.Createpc = Extension.Createpc();
            return cpftdh;
        }

        public async Task<object> ProcessForwardOnly(vmCmnParameter param, vmProcessTransaction vTrn)
        {
            object result = null; string message = string.Empty; bool resstate = false;
            try
            {
                using (_ctxOra = new ModelContext())
                {
                    using (var _ctxTransaction = _ctxOra.Database.BeginTransaction())
                    {
                        try
                        {
                            vmProcessTransaction vPrTran = new vmProcessTransaction();

                            var quot = await _ctxOra.TQuotationMasters.Where(x => x.Oid == param.strId).FirstOrDefaultAsync();
                            //*******************************************
                            var prMtran = _ctxOra.TProcessTrans.SingleOrDefault(x => x.Transactionid == quot.Oid);
                            var prDtran = _ctxOra.TProcessTranDetails.SingleOrDefault(x => x.Transactionid == prMtran.Transactionid && x.Transactionid == quot.Oid && x.Processtypeid == prMtran.Processtypeid && x.Currentsequence == prMtran.Currentsequence && x.Categoryid == prMtran.Categoryid && x.Userid == prMtran.Userid);
                            var prTranDetail = _ctxOra.TProcessTranDetails.SingleOrDefault(x => x.Transactiondetailid == prDtran.Transactiondetailid);
                            if (prTranDetail != null)
                            {
                                //*******************************************
                                vPrTran.sequences = Convert.ToInt32(prTranDetail.Currentsequence);
                                vPrTran.transactionId = prTranDetail.Transactionid;
                                vPrTran.processFlowId = prTranDetail.Processflowid;
                                vPrTran.comment = param.values;//prTranDetail.Comments;

                                int currentSequence = (int)vPrTran.sequences;
                                var prTran = _ctxOra.TProcessTrans.SingleOrDefault(x => x.Transactionid == vPrTran.transactionId);

                                var cpfd = new TProcessFlowDetail();
                                var cpftdh = new TProcessTranDetailHstry();
                                int maxSequence = (int)_ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == vPrTran.processFlowId).Max(x => x.Sequences);
                                if (vPrTran.sequences < maxSequence)
                                {
                                    cpfd = _ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == vPrTran.processFlowId && x.Sequences > vPrTran.sequences).OrderBy(x => x.Sequences).First();
                                    currentSequence = (int)cpfd.Sequences;
                                }
                                else
                                {
                                    prTran.Isapprovedall = Extension.BoolVal(true);
                                }

                                if (Extension.BoolVal(prTran.Isapprovedall) == true)
                                {
                                    if (prTran != null)
                                    {
                                        prTran.Isapproved = Extension.BoolVal(true);
                                        prTran.Isdeclined = Extension.BoolVal(false);
                                        prTran.Comments = vPrTran.comment;
                                        prTran.Approvedcomments = vPrTran.comment;
                                        prTran.Approveduserid = param.LoggedUserId;

                                        //Detail Update
                                        prTranDetail.Isapproved = Extension.BoolVal(true);
                                        prTranDetail.Isdeclined = Extension.BoolVal(false);
                                        prTranDetail.Comments = vPrTran.comment;
                                        prTranDetail.Approvedcomments = vPrTran.comment;
                                        prTranDetail.Approveduserid = param.LoggedUserId;

                                        prTranDetail.Createby = param.LoggedUserId;
                                        prTranDetail.Createon = Extension.Today;
                                        prTranDetail.Createpc = Extension.Createpc();

                                        #region Set Transaction Detail History
                                        cpftdh = SetTransactionDetailHistory(cpftdh, prTranDetail, param.LoggedUserId);
                                        _ctxOra.TProcessTranDetailHstries.Add(cpftdh);
                                        #endregion Set Transaction Detail History
                                    }
                                }
                                else
                                {
                                    if (prTran != null)
                                    {
                                        //Update Transaction Status
                                        prTran.Isapprovedall = Extension.BoolVal(false);
                                        prTran.Isapproved = Extension.BoolVal(true);
                                        prTran.Isdeclined = Extension.BoolVal(false);
                                        prTran.Processflowdetailid = cpfd.Processflowdetailid;
                                        prTran.Processtypeid = cpfd.Processtypeid;
                                        prTran.Currentsequence = currentSequence;
                                        prTran.Status = currentSequence;
                                        prTran.Fromuserid = prTranDetail.Userid;
                                        prTran.Touserid = cpfd.Userid;
                                        prTran.Userid = cpfd.Userid;
                                        prTran.Comments = vPrTran.comment;
                                        prTran.Approvedcomments = vPrTran.comment;
                                        prTran.Approveduserid = param.LoggedUserId;
                                        prTran.Createby = param.LoggedUserId;
                                        prTran.Createon = Extension.Today;
                                        prTran.Createpc = Extension.Createpc();

                                        prTranDetail.Isapproved = Extension.BoolVal(true);
                                        prTranDetail.Isdeclined = Extension.BoolVal(false);
                                        prTranDetail.Comments = vPrTran.comment;
                                        prTranDetail.Approvedcomments = vPrTran.comment;

                                        #region Set Transaction Detail History
                                        cpftdh = SetTransactionDetailHistory(cpftdh, prTranDetail, param.LoggedUserId);
                                        _ctxOra.TProcessTranDetailHstries.Add(cpftdh);
                                        #endregion Set Transaction Detail History

                                        //Insert Log
                                        var exftd = _ctxOra.TProcessTranDetails.Where(x => x.Transactionid == vPrTran.transactionId && x.Processflowid == prTran.Processflowid && x.Processflowdetailid == prTran.Processflowdetailid && x.Currentsequence == prTran.Currentsequence && x.Processtypeid == prTran.Processtypeid && x.Userid == prTran.Userid).FirstOrDefault();
                                        if (exftd == null)
                                        {
                                            string trandtMaxID = Extension.Get_OID("T_PROCESS_TRAN_DETAIL", "TRANSACTIONDETAILID", "TPTD", StaticInfos.conStringOracle);
                                            if (!string.IsNullOrEmpty(trandtMaxID))
                                            {

                                                var objTranDetail = new TProcessTranDetail();
                                                objTranDetail.Transactiondetailid = trandtMaxID;
                                                objTranDetail.Transactionid = prTran.Transactionid;
                                                objTranDetail.Transactionid = prTran.Transactionid;
                                                objTranDetail.Categoryid = prTran.Categoryid;
                                                objTranDetail.Processflowid = prTran.Processflowid;
                                                objTranDetail.Processflowdetailid = prTran.Processflowdetailid;
                                                objTranDetail.Processtypeid = prTran.Processtypeid;
                                                objTranDetail.Currentsequence = prTran.Currentsequence;
                                                objTranDetail.Fromuserid = prTran.Fromuserid;
                                                objTranDetail.Touserid = prTran.Touserid;
                                                objTranDetail.Userid = prTran.Userid;
                                                objTranDetail.Status = prTran.Status;
                                                objTranDetail.Isapproved = Extension.BoolVal(false);
                                                objTranDetail.Isdeclined = Extension.BoolVal(false);
                                                objTranDetail.Comments = vPrTran.comment;
                                                objTranDetail.Approvedcomments = vPrTran.comment;
                                                objTranDetail.Approveduserid = param.LoggedUserId;
                                                objTranDetail.Createby = param.LoggedUserId;
                                                objTranDetail.Createon = Extension.Today;
                                                objTranDetail.Createpc = Extension.Createpc();

                                                await _ctxOra.TProcessTranDetails.AddAsync(objTranDetail);

                                                //quot.Transactiondetailid = trandtMaxID;
                                            }
                                        }
                                    }

                                    //isRadiusSaved = true;
                                }

                                if (prTran.Isapprovedall == Extension.BoolVal(true))
                                {
                                    quot.Isprocesscomplete = prTran.Isapprovedall;
                                }

                                await _ctxOra.SaveChangesAsync();
                                _ctxTransaction.Commit();

                                message = MessageConstants.Saved;
                                resstate = MessageConstants.SuccessState;
                            }
                        }
                        catch (Exception ex)
                        {
                            _ctxTransaction.Rollback();
                            Logs.Bug(ex);
                            message = MessageConstants.SavedWarning;
                            resstate = MessageConstants.ErrorState;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }

            return result = new
            {
                message,
                resstate//,
                //listIspTeamUser
            };
        }

        public async Task<object> ProcessBackwardOnly(vmCmnParameter param, vmProcessTransaction vTrn)
        {
            object result = null; string message = string.Empty; bool resstate = false;
            try
            {
                using (_ctxOra = new ModelContext())
                {
                    using (var _ctxTransaction = _ctxOra.Database.BeginTransaction())
                    {
                        try
                        {
                            vmProcessTransaction vPrTran = new vmProcessTransaction();
                            var quot = await _ctxOra.TQuotationMasters.Where(x => x.Oid == param.strId).FirstOrDefaultAsync();
                            //*******************************************
                            var prMtran = _ctxOra.TProcessTrans.SingleOrDefault(x => x.Transactionid == quot.Oid);
                            var prDtran = _ctxOra.TProcessTranDetails.SingleOrDefault(x => x.Transactionid == prMtran.Transactionid && x.Transactionid == quot.Oid && x.Processtypeid == prMtran.Processtypeid && x.Currentsequence == prMtran.Currentsequence && x.Categoryid == prMtran.Categoryid && x.Userid == prMtran.Userid);
                            var prTranDetail = _ctxOra.TProcessTranDetails.SingleOrDefault(x => x.Transactiondetailid == prDtran.Transactiondetailid);

                            if (prTranDetail != null)
                            {
                                //*******************************************
                                vPrTran.sequences = Convert.ToInt32(prTranDetail.Currentsequence);
                                vPrTran.transactionId = prTranDetail.Transactionid;
                                vPrTran.processFlowId = prTranDetail.Processflowid;
                                vPrTran.comment = param.values;//prTranDetail.Comments;

                                int currentSequence = (int)vPrTran.sequences;
                                var prTran = _ctxOra.TProcessTrans.SingleOrDefault(x => x.Transactionid == vPrTran.transactionId);

                                var cpfd = new TProcessFlowDetail();
                                var cpftdh = new TProcessTranDetailHstry();
                                int maxSequence = (int)_ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == vPrTran.processFlowId).Max(x => x.Sequences);
                                int minSequence = (int)_ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == vPrTran.processFlowId).Min(x => x.Sequences);
                                if (vPrTran.sequences > minSequence)
                                {
                                    if (vPrTran.sequences < maxSequence)
                                    {
                                        cpfd = _ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == vPrTran.processFlowId && x.Sequences < vPrTran.sequences).OrderByDescending(x => x.Sequences).First();
                                    }
                                    else if (vPrTran.sequences == maxSequence)
                                    {
                                        cpfd = _ctxOra.TProcessFlowDetails.Where(x => x.Processflowid == vPrTran.processFlowId && x.Sequences == minSequence).FirstOrDefault();
                                    }

                                    currentSequence = (int)cpfd.Sequences;
                                }

                                if (prTran != null && cpfd != null)
                                {
                                    prTran.Processflowdetailid = cpfd.Processflowdetailid;
                                    prTran.Processtypeid = cpfd.Processtypeid;
                                    prTran.Currentsequence = currentSequence;
                                    prTran.Fromuserid = prTranDetail.Userid;
                                    prTran.Touserid = cpfd.Userid;
                                    prTran.Userid = cpfd.Userid;
                                    prTran.Comments = vPrTran.comment;
                                    prTran.Declinedcomments = vPrTran.comment;
                                    prTran.Declineduserid = param.LoggedUserId;
                                    //prTran.Isapprovedall = Extension.BoolVal(false);
                                    prTran.Isapproved = Extension.BoolVal(false);
                                    prTran.Isdeclined = Extension.BoolVal(true);
                                    prTran.Updateby = param.LoggedUserId;
                                    prTran.Updateon = Extension.Today;
                                    prTran.Updatepc = Extension.Createpc();

                                    //prTranDetail.Isapprovedall= Extension.BoolVal(false);
                                    prTranDetail.Isapproved = Extension.BoolVal(false);
                                    prTranDetail.Isdeclined = Extension.BoolVal(true);
                                    prTranDetail.Comments = vPrTran.comment;
                                    prTranDetail.Declinedcomments = vPrTran.comment;
                                    prTranDetail.Updateby = param.LoggedUserId;
                                    prTranDetail.Updateon = Extension.Today;
                                    prTranDetail.Updatepc = Extension.Createpc();

                                    #region Set Transaction Detail History
                                    cpftdh = SetTransactionDetailHistory(cpftdh, prTranDetail, param.LoggedUserId);
                                    _ctxOra.TProcessTranDetailHstries.Add(cpftdh);
                                    #endregion Set Transaction Detail History
                                }


                                await _ctxOra.SaveChangesAsync();
                                _ctxTransaction.Commit();

                                message = MessageConstants.Saved;
                                resstate = MessageConstants.SuccessState;

                            }
                            else
                            {
                                _ctxTransaction.Rollback();
                                message = MessageConstants.SavedWarning;
                                resstate = MessageConstants.ErrorState;
                            }
                        }
                        catch (Exception ex)
                        {
                            _ctxTransaction.Rollback();
                            Logs.Bug(ex);
                            message = MessageConstants.SavedWarning;
                            resstate = MessageConstants.ErrorState;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }

            return result = new
            {
                message,
                resstate
            };
        }
        #endregion

        #endregion All Methods
    }
}
