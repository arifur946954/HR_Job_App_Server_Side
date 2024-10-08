using DataFactories.BaseFactory;
using DataModel.EntityModels.OraModel;
using DataModel.ViewModels;
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

namespace DataFactories.Infrastructure.business.customer
{
    public class CustomerMgt
    {
        #region Variable declaration & initialization
        ModelContext _ctxOra = null;
        private IGenericFactoryOracle<vmCmnParameter> OraGeneric_vmCmnParameter = null;
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
            string listCustomer = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "cresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "PageNumber", (1, Convert.ToDecimal(param.pageNumber))},
                    { "PageSize", (2, Convert.ToDecimal(param.pageSize)) }
                };

                listCustomer = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_CustomerByPage, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                listCustomer
            };
        }
       


        /// <summary>
        /// This method returns data from database as an object using asynchronous operation by an int parameter.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> GetByID(int id)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string objCustomer = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "gresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "gCustomerId", (1, Convert.ToDecimal(id))}
                };

                objCustomer = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_CustomerById, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                objCustomer
            };
        }



        ///// <summary>
        ///// Both insert and update can perform by CmnUserRole model in database using asynchronous operation. when id is more than 0 update is performed otherwise insert. it returns an object as status of success or failure.
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public async Task<object> SaveUpdate(vmCustomer _customer, List<vmContactPerson> _contactList, vmCmnParameter param)
        //{
        //    object result = null; string message = string.Empty; bool resstate = false;
        //    using (_ctxOra = new ModelContext())
        //    {
        //        using (var _ctxOraTransaction = _ctxOra.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                List<TCustomerConPer> ncontactList = new List<TCustomerConPer>();
        //                TCustomer cust = null;

        //                if (_customer.CustomerId > 0)
        //                {
        //                    cust = await _ctxOra.TCustomers.FirstOrDefaultAsync(x => x.CustomerId == _customer.CustomerId);
        //                    cust.Name = _customer.Name;
        //                    cust.Shortname = _customer.ShortName;
        //                    cust.Address = _customer.Address;
        //                    cust.Phone = _customer.Phone;
        //                    cust.Email = _customer.Email;
        //                    cust.Website = _customer.Website;
        //                    cust.Isactive = Extension.BoolVal(_customer.IsActive);
        //                    //Common
        //                    cust.Updatepc = Extension.Createpc(); 
        //                    cust.Updateby = param.LoggedUserId;
        //                    cust.Updateon = Extension.Today;

        //                    if (_contactList.Count > 0) {
        //                        var nContList = _contactList.Where(x => x.CustConPerId == 0).ToList();
        //                        var uContList = _contactList.Where(x => x.CustConPerId > 0).ToList();

        //                        if (nContList.Count > 0) {
        //                            var CMaxID = _ctxOra.TCustomerConPers.DefaultIfEmpty().Max(x => x == null ? 0 : x.CustConPerId) + 1;
        //                            foreach (var cont in nContList)
        //                            {
        //                                var contact = new TCustomerConPer();
        //                                contact.CustConPerId = CMaxID;
        //                                contact.CustId = cust.CustomerId;
        //                                contact.ConPerName = cont.ConPerName;
        //                                contact.ConPerPhone = cont.ConPerPhone;

        //                                //Common
        //                                contact.Isactive = Extension.BoolVal(cont.IsActive);
        //                                contact.Isdelete = Extension.BoolVal(cont.IsDelete);
        //                                contact.Createpc = cust.Createpc;
        //                                contact.Createby = cust.Createby;
        //                                contact.Createon = cust.Createon;

        //                                ncontactList.Add(contact);
        //                                CMaxID++;
        //                            }
        //                        }

        //                        if (uContList.Count > 0)
        //                        {
        //                            var conList = await _ctxOra.TCustomerConPers.Where(x => x.CustId == cust.CustomerId).ToListAsync();
        //                            foreach (var con in uContList) {
        //                                var ucon = conList.Where(x => x.CustConPerId == con.CustConPerId && x.CustId==con.CustomerId).FirstOrDefault();
        //                                ucon.ConPerName = con.ConPerName;
        //                                ucon.ConPerPhone = con.ConPerPhone;

        //                                //common
        //                                ucon.Isactive = Extension.BoolVal(con.IsActive);
        //                                ucon.Isdelete = Extension.BoolVal(con.IsDelete);
        //                                ucon.Updatepc = cust.Updatepc;
        //                                ucon.Updateby = cust.Updateby;
        //                                ucon.Updateon = cust.Updateon;
        //                            }
        //                        }
        //                    }

        //                    message = MessageConstants.Updated;
        //                }
        //                else
        //                {
        //                    var MaxID = _ctxOra.TCustomers.DefaultIfEmpty().Max(x => x == null ? 0 : x.CustomerId) + 1;
        //                    cust = new TCustomer();
        //                    cust.CustomerId = MaxID;
        //                    cust.Name = _customer.Name;
        //                    cust.Shortname = _customer.ShortName;
        //                    cust.Address = _customer.Address;
        //                    cust.Phone = _customer.Phone;
        //                    cust.Email = _customer.Email;
        //                    cust.Website = _customer.Website;
        //                    cust.Isactive = Extension.BoolVal(_customer.IsActive);

        //                    //Common
        //                    cust.Createpc = Extension.Createpc();
        //                    cust.Createby = param.LoggedUserId;
        //                    cust.Createon = Extension.Today;

        //                    if (_contactList.Count > 0)
        //                    {
        //                        var CMaxID = _ctxOra.TCustomerConPers.DefaultIfEmpty().Max(x => x == null ? 0 : x.CustConPerId) + 1;
        //                        foreach (var cont in _contactList)
        //                        {
        //                            var contact = new TCustomerConPer();
        //                            contact.CustConPerId = CMaxID;
        //                            contact.CustId = MaxID;
        //                            contact.ConPerName = cont.ConPerName;
        //                            contact.ConPerPhone = cont.ConPerPhone;

        //                            //Common
        //                            contact.Isactive = Extension.BoolVal(cont.IsActive);
        //                            contact.Isdelete = Extension.BoolVal(cont.IsDelete);
        //                            contact.Createpc= cust.Createpc;
        //                            contact.Createby= cust.Createby;
        //                            contact.Createon= cust.Createon;

        //                            ncontactList.Add(contact);
        //                            CMaxID++;
        //                        }
        //                    }

        //                    await _ctxOra.TCustomers.AddAsync(cust);

        //                    message = MessageConstants.Saved;
        //                }

        //                if (ncontactList.Count > 0) {
        //                    await _ctxOra.TCustomerConPers.AddRangeAsync(ncontactList);
        //                }

        //                await _ctxOra.SaveChangesAsync();

        //                _ctxOraTransaction.Commit();                        
        //                resstate = MessageConstants.SuccessState;
        //            }
        //            catch (Exception ex)
        //            {
        //                _ctxOraTransaction.Rollback();
        //                Logs.Bug(ex);
        //                message = MessageConstants.SavedWarning;
        //                resstate = MessageConstants.ErrorState;
        //            }
        //        }
        //    }
        //    return result = new
        //    {
        //        message,
        //        resstate
        //    };
        //}


        ///// <summary>
        ///// Delete can perform to CmnUserRole table by int parameter in database using asynchronous operation. It returns an object as status of success or failure.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public async Task<object> Delete(vmCmnParameter param)
        //{
        //    object result = null; string message = string.Empty; bool resstate = false;
        //    using (_ctxOra = new ModelContext())
        //    {
        //        using (var _ctxOraTran = await _ctxOra.Database.BeginTransactionAsync())
        //        {
        //            try
        //            {
        //                if (param.id > 0)
        //                {
        //                    var delmodel = await _ctxOra.TCustomers.Where(x => x.CustomerId == param.id).FirstOrDefaultAsync();
        //                    delmodel.Isdelete = Extension.BoolVal(true);
        //                    delmodel.Deletepc = Extension.Createpc();
        //                    delmodel.Deleteby = param.LoggedUserId;
        //                    delmodel.Deleteon = Extension.Today;

        //                    var delChildModelList = await _ctxOra.TCustomerConPers.Where(x => x.CustId == param.id).ToListAsync();

        //                    foreach (var tcon in delChildModelList) {
        //                        tcon.Isdelete = delmodel.Isdelete;
        //                        tcon.Deletepc = delmodel.Deletepc;
        //                        tcon.Deleteby = delmodel.Deleteby;
        //                        tcon.Deleteon = delmodel.Deleteon;
        //                    }
        //                }

        //                await _ctxOra.SaveChangesAsync();
        //                _ctxOraTran.Commit();
        //                message = MessageConstants.Deleted;
        //                resstate = MessageConstants.SuccessState;
        //            }
        //            catch (Exception ex)
        //            {
        //                _ctxOraTran.Rollback();
        //                Logs.Bug(ex);
        //                message = MessageConstants.DeletedWarning;
        //                resstate = MessageConstants.ErrorState;
        //            }
        //        }
        //    }

        //    return result = new
        //    {
        //        message,
        //        resstate
        //    };
        //}
        #endregion





    }
}
