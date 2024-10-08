using DataFactories.BaseFactory;
using DataModel.EntityModels.OraModel;
using DataModel.ViewModels;
using DataModel.ViewModels.ERPViewModel.Business;
using DataUtility;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataFactories.Infrastructure.business.client
{
    public class ClientMgt
    {
        #region Variable declaration & initialization
        ModelContext _ctxOra = null;
        private IGenericFactoryOracle<vmCmnParameter> OraGeneric_vmCmnParameter = null;
        OracleCommand ocmd = null;
        Hashtable ht = null; OracleParameter[] oprm = null;
        #endregion

        #region All Methods
        #region Client
        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> GetWithPagination(vmCmnParameter param) //vmCmnParameters cmnParam
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string listClient = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "cresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "PageNumber", (1, Convert.ToDecimal(param.pageNumber))},
                    { "PageSize", (2, Convert.ToDecimal(param.pageSize)) }
                };

                listClient = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ClientByPage, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                listClient
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
            string objClient = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "gresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "gClientTypeId", (1, id)}
                };

                objClient = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ClientById, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                objClient
            };
        }

        /// <summary>
        /// Both insert and update can perform by CmnUserRole model in database using asynchronous operation. when id is more than 0 update is performed otherwise insert. it returns an object as status of success or failure.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<object> SaveUpdate(vmClient _client, vmCmnParameter param)
        {
            object result = null; string message = string.Empty; bool resstate = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTransaction = _ctxOra.Database.BeginTransaction())
                {
                    try
                    {
                        TClient clnt = null;

                        if (! string.IsNullOrEmpty(_client.Oid))
                        {
                            clnt = await _ctxOra.TClients.FirstOrDefaultAsync(x => x.Oid == _client.Oid);
                            clnt.Oid = _client.Oid;
                            clnt.ClientCode = _client.ClientCode;
                            clnt.ClientName = _client.ClientName;
                            clnt.ClientBname = _client.ClientBname;
                            clnt.ClientOwner = _client.ClientOwner;
                            clnt.ClientContactPerson = _client.ClientContactPerson;
                            clnt.ClientEmail = _client.ClientEmail;
                            clnt.ClientMobile = _client.ClientMobile;
                            clnt.ClientFax = _client.ClientFax;
                            clnt.ClientAddress = _client.ClientAddress;
                            clnt.ClientBaddress = _client.ClientBaddress;
                            clnt.ClientAddress2 = _client.ClientAddress2;
                            clnt.ClientBaddress2 = _client.ClientBaddress2;
                            clnt.ClientBin = _client.ClientBin;
                            clnt.ClientTin = _client.ClientTin;
                            clnt.ClientCreditLimit = _client.ClientCreditLimit;
                            clnt.ClientEnrolldate = _client.ClientEnrolldate;
                            clnt.ClientType = _client.ClientType;
                            clnt.Isactive = Extension.BoolVal(_client.Isactive);

                            //Common
                            clnt.Updatepc = Extension.Createpc();
                            clnt.Updateby = param.LoggedUserId;
                            clnt.Updateon = Extension.Today;

                            message = MessageConstants.Updated;
                        }
                        else
                        {
                            //var MaxID = _ctxOra.TClients.DefaultIfEmpty().Max(x => x == null ? 0 : x.CustomerId) + 1;
                            clnt = new TClient();
                            clnt.Oid = _client.Oid;
                            clnt.ClientCode = _client.ClientCode;
                            clnt.ClientName = _client.ClientName;
                            clnt.ClientBname = _client.ClientBname;
                            clnt.ClientOwner = _client.ClientOwner;
                            clnt.ClientContactPerson = _client.ClientContactPerson;
                            clnt.ClientEmail = _client.ClientEmail;
                            clnt.ClientMobile = _client.ClientMobile;
                            clnt.ClientFax = _client.ClientFax;
                            clnt.ClientAddress = _client.ClientAddress;
                            clnt.ClientBaddress = _client.ClientBaddress;
                            clnt.ClientAddress2 = _client.ClientAddress2;
                            clnt.ClientBaddress2 = _client.ClientBaddress2;
                            clnt.ClientBin = _client.ClientBin;
                            clnt.ClientTin = _client.ClientTin;
                            clnt.ClientCreditLimit = _client.ClientCreditLimit;
                            clnt.ClientEnrolldate = _client.ClientEnrolldate;
                            clnt.ClientType = _client.ClientType;
                            clnt.Isactive = Extension.BoolVal(_client.Isactive);

                            //Common
                            clnt.Createpc = Extension.Createpc();
                            clnt.Createby = param.LoggedUserId;
                            clnt.Createon = Extension.Today;

                            await _ctxOra.TClients.AddAsync(clnt);

                            message = MessageConstants.Saved;
                        }

                        await _ctxOra.SaveChangesAsync();

                        _ctxOraTransaction.Commit();                        
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTransaction.Rollback();
                        Logs.Bug(ex);
                        message = MessageConstants.SavedWarning;
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

        public async Task<object> SaveUpdate(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_Client, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
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

        /// <summary>
        /// Delete can perform to CmnUserRole table by int parameter in database using asynchronous operation. It returns an object as status of success or failure.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> Delete(vmCmnParameter param)
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
                            var delmodel = await _ctxOra.TClients.Where(x => x.Oid == param.strId).FirstOrDefaultAsync();
                            delmodel.Iscancel = Extension.BoolVal(true);
                            delmodel.Updatepc = Extension.Createpc();
                            delmodel.Updateby = param.LoggedUserId;
                            delmodel.Updateon = Extension.Today;
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
        #endregion Client

        #region Client Type
        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> GetClientTypeWithPage(vmCmnParameter param) //vmCmnParameters cmnParam
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string listClientType = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "cresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "PageNumber", (1, Convert.ToDecimal(param.pageNumber))},
                    { "PageSize", (2, Convert.ToDecimal(param.pageSize)) }
                };

                listClientType = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ClientTypeByPage, ht, StaticInfos.conStringOracle.ToString());
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

        /// <summary>
        /// This method returns data from database as an object using asynchronous operation by an int parameter.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> GetClientTypeByID(string id)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string objClientType = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "gresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "gClientTypeId", (1, id)}
                };

                objClientType = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ClientTypeById, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                objClientType
            };
        }

        /// <summary>
        /// Both insert and update can perform by CmnUserRole model in database using asynchronous operation. when id is more than 0 update is performed otherwise insert. it returns an object as status of success or failure.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<object> SaveUpdateClientType(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_ClientType, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
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

        /// <summary>
        /// Delete can perform to CmnUserRole table by int parameter in database using asynchronous operation. It returns an object as status of success or failure.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> DeleteClientType(vmCmnParameter param)
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
                            var delmodel = await _ctxOra.TClientTypes.Where(x => x.Oid == param.strId).FirstOrDefaultAsync();
                            delmodel.Iscancel = Extension.BoolVal(true);
                            delmodel.Updatepc = Extension.Createpc();
                            delmodel.Updateby = param.LoggedUserId;
                            delmodel.Updateon = Extension.Today;
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
        #endregion Client Type

        #region Client Bank
        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> GetClientBankWithPage(vmCmnParameter param) //vmCmnParameters cmnParam
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string listClientBank = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "cresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "PageNumber", (1, Convert.ToDecimal(param.pageNumber))},
                    { "PageSize", (2, Convert.ToDecimal(param.pageSize)) }
                };

                listClientBank = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ClientBankByPage, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                listClientBank
            };
        }

        /// <summary>
        /// This method returns data from database as an object using asynchronous operation by an int parameter.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> GetClientBankByID(string id)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string objClientBank = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "gresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "gClientBankInfoId", (1, id)}
                };

                objClientBank = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_ClientBankById, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                objClientBank
            };
        }

        /// <summary>
        /// Both insert and update can perform by CmnUserRole model in database using asynchronous operation. when id is more than 0 update is performed otherwise insert. it returns an object as status of success or failure.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<object> SaveUpdateClientBank(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();

                result = await OraGeneric_vmCmnParameter.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_ClientBank, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
                if (!string.IsNullOrEmpty(result) && result != "0")
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

        /// <summary>
        /// Delete can perform to CmnUserRole table by int parameter in database using asynchronous operation. It returns an object as status of success or failure.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> DeleteClientBank(vmCmnParameter param)
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
                            var delmodel = await _ctxOra.TClientBanks.Where(x => x.Oid == param.strId).FirstOrDefaultAsync();
                            delmodel.Iscancel = Extension.BoolVal(true);
                            delmodel.Updatepc = Extension.Createpc();
                            delmodel.Updateby = param.LoggedUserId;
                            delmodel.Updateon = Extension.Today;
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
        #endregion Client Bank
        #endregion





    }
}
