using DataFactories.BaseFactory;
//using DataModels.EntityModels.ERPModel;
using DataModel.EntityModels.OraModel;
//using DataModel.EntityModels.ISPModel;
using DataModel.ViewModels;
//using DataModels.ViewModels.ERPViewModel.Business.Cloud;
//using DataModels.ViewModels.ERPViewModel.SalesMarketing;
using DataUtility;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFactories.Infrastructure.common.dropdown
{
    public class CommonDropdownMgt 
    {

        #region Variable declaration & initialization
        //dbRGLERPContext _ctx = null;
        ModelContext _ctxOr = null;
        //radiusContext _ctxRad = null;
        //private IGenericFactory<vmCmnParameters> Generic_vmCmnParameters = null;
        private IGenericFactoryOracle<vmCmnParameter> OraGeneric_vmCmnParameter = null;
        Hashtable ht = null;
        #endregion

        #region security
        /// <summary>
        /// This method returns data from database as a list of Module object using asynchronous operation by an int parameter.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public async Task<object> GetAllModule()
        //{
        //    List<CmnModule> listModule = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listModule = await _ctx.CmnModule
        //                .OrderBy(o => o.ModuleName)
        //                .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listModule
        //    };
        //}

        ///// <summary>
        ///// This method returns data from database as a list of Menu object using asynchronous operation by an int parameter.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public async Task<object> GetAllMenu()
        //{
        //    List<CmnMenu> listMenues = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listMenues = await _ctx.CmnMenu.ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listMenues
        //    };
        //}



        //// GET: api/dropdown/getallroleForReopen
        //public async Task<object> GetAllRoleFroReopenGroup(int id)
        //{
        //    List<CmnUserRole> listUsrRole = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            List<CmnUserRole> role = await _ctx.CmnUserRole
        //                .Join(_ctx.BizIspUserPackServiceReopenGroup, x => x.RoleId, y => y.RoleId, (x, y) => new CmnUserRole { RoleId = x.RoleId, RoleName = x.RoleName, CompanyId = x.CompanyId, IsActive = x.IsActive, CreateDate = x.CreateDate, CreatedBy = x.CreatedBy })
        //                .OrderBy(a => a.RoleName)
        //                .ToListAsync();
        //            listUsrRole = await _ctx.CmnUserRole.Where(x => x.RoleId != StaticInfos.SeedRoleID).Where(c => !role.Contains(c)).ToListAsync();
        //            if (id > 0)
        //            {
        //                var userrole = await _ctx.CmnUserRole.FindAsync(id);
        //                listUsrRole.Add(userrole);
        //            }
        //            //listUsrRole = listUsrRole.Except(role).ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listUsrRole
        //    };
        //}

        ///// <summary>
        ///// This method returns data from database as a list of Role object using asynchronous operation by an int parameter.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public async Task<object> GetAllRoleBak()
        //{
        //    List<CmnUserRole> listUsrRole = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listUsrRole = await _ctx.CmnUserRole
        //                .Where(x => x.RoleId != StaticInfos.SeedRoleID)
        //                .OrderBy(a => a.RoleName)
        //                .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listUsrRole
        //    };
        //}


        //GET ALL BRAND
        public async Task<object> GetAllBrand()
        {
            object listAllBrand = null; object result = null;
            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listAllBrand = await (from tct in _ctxOr.TBrands
                                          select new
                                          {
                                              oId = tct.Oid,
                                              typeName = tct.BrandName,
                                              typeSName = tct.BrandSname
                                          }
                                      ).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }

            return result = new
            {
                listAllBrand
            };
        }




        public async Task<object> GetAllRole()
        {
            object listUsrRole = null; object result = null;
            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listUsrRole = await (from rs in _ctxOr.TRoleSetups
                                         where rs.Roleid != StaticInfos.SeedRoleID
                                         select new
                                         {
                                             roleId = rs.Roleid,
                                             roleName = rs.Rolename
                                         }
                                      ).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }

            return result = new
            {
                listUsrRole
            };
        }

        //public async Task<object> GetAllCustomer()
        //{
        //    object listCustomer = null; object result = null;
        //    try
        //    {
        //        using (_ctxOr = new ModelContext())
        //        {
        //            listCustomer = await (from tc in _ctxOr.TCustomers
        //                                  select new
        //                                  {
        //                                      customerId = tc.CustomerId,
        //                                      customerName = tc.Name,
        //                                      customerShortName = tc.Shortname
        //                                  }
        //                              ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        listCustomer = ex.ToString();
        //        Logs.Bug(ex);
        //    }

        //    return result = new
        //    {
        //        listCustomer
        //    };
        //}

        public async Task<object> GetAllClientType()
        {
            object listClientType = null; object result = null;
            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listClientType = await (from tct in _ctxOr.TClientTypes
                                            select new
                                            {
                                                oId = tct.Oid,
                                                typeName = tct.TypeTrno + "-" + tct.TypeName
                                            }
                                      ).ToListAsync();
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


  



        public async Task<object> GetAllCurrency()
        {
            object listCurrency = null; object result = null;
            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listCurrency = await (from tct in _ctxOr.TCmnCurrencies
                                          select new
                                          {
                                              oId = tct.Oid,
                                              currencyName = tct.Currencyname
                                          }
                                      ).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                //listCurrency = ex.ToString();
                Logs.Bug(ex);
            }

            return result = new
            {
                listCurrency
            };
        }

        //public async Task<object> GetAllItemType()
        //{
        //    object listItemType = null; object result = null;
        //    try
        //    {
        //        using (_ctxOr = new ModelContext())
        //        {
        //            listItemType = await (from pt in _ctxOr.TProductTypes
        //                                  select new
        //                                  {
        //                                      typeId = pt.ProductTypeId,
        //                                      typeName = pt.ProductTypeName
        //                                  }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        listItemType = ex.ToString();
        //    }

        //    return result = new
        //    {
        //        listItemType
        //    };
        //}

        //public async Task<object> GetAllItemCategory()
        //{
        //    object listItemCategory = null; object result = null;
        //    try
        //    {
        //        using (_ctxOr = new ModelContext())
        //        {
        //            listItemCategory = await (from pc in _ctxOr.TProductCategories
        //                                      select new
        //                                      {
        //                                          categoryId = pc.ProductCategoryId,
        //                                          categoryName = pc.ProductCategoryName
        //                                      }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        listItemCategory = ex.ToString();
        //    }

        //    return result = new
        //    {
        //        listItemCategory
        //    };
        //}

        //public async Task<object> GetAllItemSubCategory(vmCmnParameter param)
        //{
        //    object listItemSubCategory = null; object result = null;
        //    try
        //    {
        //        using (_ctxOr = new ModelContext())
        //        {
        //            listItemSubCategory = await (from psc in _ctxOr.TProductSubcategories
        //                                             //where psc.ProductCategoryId==param.id
        //                                         select new
        //                                         {
        //                                             subCategoryId = psc.ProductSubcategoryId,
        //                                             subCategoryName = psc.ProductSubcategoryName
        //                                         }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        listItemSubCategory = ex.ToString();
        //    }

        //    return result = new
        //    {
        //        listItemSubCategory
        //    };
        //}

        //public async Task<object> GetAllItem(vmCmnParameter param)
        //{
        //    object listItem = null; object result = null;
        //    try
        //    {
        //        using (_ctxOr = new ModelContext())
        //        {
        //            listItem = await (from pd in _ctxOr.TProductDetails
        //                                  //where psc.ProductCategoryId==param.id
        //                              select new
        //                              {
        //                                  itemId = pd.ProductId,
        //                                  itemName = pd.ProductName
        //                              }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        listItem = ex.ToString();
        //    }

        //    return result = new
        //    {
        //        listItem
        //    };
        //}

        public async Task<object> GetAllUserByCompany(vmCmnParameter param)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string listUser = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "uresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "s_CompanyID", (1, param.values) }
                };

                listUser = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_UserByCompany, ht, StaticInfos.conStringOracle.ToString());

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                listUser
            };
        }

        public async Task<object> GetAllCompanyUser(vmCmnParameter param)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string listUser = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "uresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "s_CompanyID", (1, param.values) }
                };

                listUser = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_CompanyUser, ht, StaticInfos.conStringOracle.ToString());

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                listUser
            };
        }


        public async Task<object> GetAllRefrence()
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listClient = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listClient = await (from qtn in _ctxOr.TQuotationMasters
                                        where qtn.Isactive == Extension.BoolVal(true) && qtn.Iscancel == Extension.BoolVal(false)
                                        select new
                                        {
                                            quotationId = qtn.Oid,
                                            quotationCatagoryId = qtn.CategoryOid,
                                            quotationCode = qtn.QuotCode,
                                            quotationRef = qtn.QuotRefNo,
                                            quotationType = qtn.QuotType,
                                            clientId = qtn.ClientOid,
                                            catagoryId = qtn.CategoryOid,

                                        }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listClient
            };
        }


        public async Task<object> GetAllBank()
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string listBank = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "p_cursor", (0, OracleDbType.RefCursor, ParameterDirection.Output) }
                };

                listBank = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_AllBank, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                listBank
            };
        }

        public async Task<object> GetAllAccountType()
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string listAccountType = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "p_cursor", (0, OracleDbType.RefCursor, ParameterDirection.Output) }
                };

                listAccountType = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_AllAccountType, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                listAccountType
            };
        }

        public async Task<object> GetAllClient()
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listClient = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listClient = await (from clnt in _ctxOr.TClients
                                        join ctt in _ctxOr.TClientTypes on clnt.ClientType equals ctt.Oid
                                        where clnt.Isactive == Extension.BoolVal(true) && clnt.Iscancel == Extension.BoolVal(false)
                                        select new
                                        {
                                            clientId = clnt.Oid,
                                            clientName = clnt.ClientName,
                                            clientSName = clnt.ClientSname,
                                            clientTypeId = clnt.ClientType,
                                            clientType = ctt.TypeName
                                        }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listClient
            };
        }

        public async Task<object> GetAllBusinessCatergory()
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listCategory = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listCategory = await (from cat in _ctxOr.TCategories
                                          where cat.Isactive == Extension.BoolVal(true) && cat.Iscancel == Extension.BoolVal(false)
                                          select new
                                          {
                                              categoryId = cat.Oid,
                                              categoryName = cat.CategoryName,
                                              categorySName = cat.CategorySname
                                          }
                                ).OrderBy(x => x.categoryId).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listCategory
            };
        }

        public async Task<object> GetAllServiceHeadGroup()
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listSrvHeadGroup = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listSrvHeadGroup = await (from clnt in _ctxOr.TServiceHeadGroups
                                              where clnt.Isactive == Extension.BoolVal(true) && clnt.Iscancel == Extension.BoolVal(false)
                                              select new
                                              {
                                                  srvHeadGroupId = clnt.Oid,
                                                  srvHeadGroupName = clnt.HeadGroupName
                                              }
                                ).OrderBy(x => x.srvHeadGroupId).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
                Logs.Bug(ex);
            }
            return new
            {
                listSrvHeadGroup
            };
        }

        public async Task<object> GetAllBusinessPlatform(string categoryId)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listBPlatform = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listBPlatform = await (from clnt in _ctxOr.TBplatforms
                                           where clnt.CategoryOid == categoryId
                                           && clnt.Isactive == Extension.BoolVal(true)
                                           && clnt.Iscancel == Extension.BoolVal(false)
                                           select new
                                           {
                                               bplatformId = clnt.Oid,
                                               bplatformName = clnt.BplatformName
                                           }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listBPlatform
            };
        }

        public async Task<object> GetAllBusinessParameter(string categoryId)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listBParameter = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listBParameter = await (from clnt in _ctxOr.TBparameters
                                            where clnt.CategoryOid == categoryId
                                            && clnt.Isactive == Extension.BoolVal(true)
                                            && clnt.Iscancel == Extension.BoolVal(false)
                                            select new
                                            {
                                                bparameterId = clnt.Oid,
                                                bparameterName = clnt.BparameterName
                                            }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                //ex.ToString();
                Logs.Bug(ex);
            }
            return new
            {
                listBParameter
            };
        }

        public async Task<object> GetAllBusinessParameter()
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listBParameter = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listBParameter = await (from clnt in _ctxOr.TBparameters
                                            where clnt.Isactive == Extension.BoolVal(true) && clnt.Iscancel == Extension.BoolVal(false)
                                            select new
                                            {
                                                bparameterId = clnt.Oid,
                                                bparameterName = clnt.BparameterName
                                            }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listBParameter
            };
        }

        public async Task<object> GetAllBusinessParameterTask(string categoryId)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listBParameterTask = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listBParameterTask = await (from clnt in _ctxOr.TBparameterTasks
                                                where clnt.CategoryOid == categoryId
                                                && clnt.Isactive == Extension.BoolVal(true)
                                                && clnt.Iscancel == Extension.BoolVal(false)
                                                select new
                                                {
                                                    bparameterTaskId = clnt.Oid,
                                                    bparameterTaskName = clnt.BparametertaskName
                                                }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                //ex.ToString();
                Logs.Bug(ex);
            }
            return new
            {
                listBParameterTask
            };
        }

        public async Task<object> GetAllBusinessMetrics(string categoryId)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listBMetrics = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listBMetrics = await (from clnt in _ctxOr.TBmetrics
                                          where clnt.CategoryOid == categoryId
                                          && clnt.Isactive == Extension.BoolVal(true)
                                          && clnt.Iscancel == Extension.BoolVal(false)
                                          select new
                                          {
                                              bmetricsId = clnt.Oid,
                                              bmetricsName = clnt.BmetricsName,
                                              bmetricsSName=clnt.BmetricsSname,
                                              bmetricsValue = clnt.BmetricsValue
                                          }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                //ex.ToString();
                Logs.Bug(ex);
            }
            return new
            {
                listBMetrics
            };
        }

        public async Task<object> GetAllBusinessAssetType(string categoryId)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listBAssetType = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listBAssetType = await (from clnt in _ctxOr.TBassetTypes
                                            where clnt.CategoryOid == categoryId
                                            && clnt.Isactive == Extension.BoolVal(true)
                                            && clnt.Iscancel == Extension.BoolVal(false)
                                            select new
                                            {
                                                bassetTypeId = clnt.Oid,
                                                bassetTypeName = clnt.BassettypeName
                                            }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                //ex.ToString();
                Logs.Bug(ex);
            }
            return new
            {
                listBAssetType
            };
        }

        public async Task<object> GetAllProcessType()
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listProcessType = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listProcessType = await (from clnt in _ctxOr.TProcessTypes
                                             where clnt.Isactive == Extension.BoolVal(true) && clnt.Isdelete == Extension.BoolVal(false)
                                             select new
                                             {
                                                 processTypeId = clnt.Processtypeid,
                                                 processTypeName = clnt.Processtype
                                             }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listProcessType
            };
        }

        public async Task<object> GetAllTermsConditions()
        {
            object listTrmCon = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listTrmCon = await (from tc in _ctxOr.TTermsConditions
                                        where tc.Isactive == Extension.BoolVal(true) && tc.Iscancel == Extension.BoolVal(false)
                                        select new
                                        {
                                            tcOid = tc.Oid,
                                            termsCondition = tc.Termsconditions
                                        }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listTrmCon
            };
        }

        public async Task<object> GetAllPublisherByCategory(string categoryId)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listPublisher = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listPublisher = await (from pb in _ctxOr.TBpublishers
                                           where pb.CategoryOid == categoryId &&
                                           pb.Isactive == Extension.BoolVal(true) &&
                                           pb.Iscancel == Extension.BoolVal(false)
                                           select new
                                           {
                                               bpublisherId = pb.Oid,
                                               bpublisherName = pb.BpublisherName
                                           }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listPublisher
            };
        }

        public async Task<object> GetAllPublisher()
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listBPublisher = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listBPublisher = await (from pb in _ctxOr.TBpublishers
                                            where pb.Isactive == Extension.BoolVal(true) &&
                                            pb.Iscancel == Extension.BoolVal(false)
                                            select new
                                            {
                                                bpublisherId = pb.Oid,
                                                bpublisherName = pb.BpublisherName
                                            }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listBPublisher
            };
        }

        public async Task<object> GetAllSupplements(string publisherId)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listSupplement = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listSupplement = await (from pb in _ctxOr.TBsupplements
                                            where pb.PublisherOid == publisherId && pb.Isactive == Extension.BoolVal(true) &&
                                            pb.Iscancel == Extension.BoolVal(false)
                                            select new
                                            {
                                                bsupplementsId = pb.Oid,
                                                bsupplementsName = pb.BsupplementsName
                                            }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listSupplement
            };
        }

        public async Task<object> GetAllPlacement(string categoryId)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listPlacement = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listPlacement = await (from pb in _ctxOr.TBplacements
                                            where pb.Isactive == Extension.BoolVal(true) &&
                                            pb.Iscancel == Extension.BoolVal(false)
                                            select new
                                            {
                                                bplacementId = pb.Oid,
                                                bplacementName = pb.BplacementName
                                            }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listPlacement
            };
        }

        public async Task<object> GetAllMediaBroadcastByCategory(string categoryId)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            object listMBroadCast = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listMBroadCast = await (from pb in _ctxOr.TMediaBroadcasts
                                            where pb.CategoryOid == categoryId &&
                                            pb.Isactive == Extension.BoolVal(true) &&
                                            pb.Iscancel == Extension.BoolVal(false)
                                            select new
                                            {
                                                broadcastId = pb.Oid,
                                                broadcastName = pb.BroadcastName
                                            }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listMBroadCast
            };
        }

        public async Task<object> GetAllMediaProgram()
        {
            object listMediaProgram = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listMediaProgram = await (from tc in _ctxOr.TMediaPrograms
                                              where tc.Isactive == Extension.BoolVal(true) && tc.Iscancel == Extension.BoolVal(false)
                                              select new
                                              {
                                                  programId = tc.Oid,
                                                  programName = tc.ProgramName,
                                                  programSName = tc.ProgramSname,
                                                  programBegin = tc.ProgramBegin,
                                                  programEnd = tc.ProgramEnd
                                              }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listMediaProgram
            };
        }

        public async Task<object> GetAllMediaGenre()
        {
            object listMediaGenre = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listMediaGenre = await (from tc in _ctxOr.TMediaGenres
                                            where tc.Isactive == Extension.BoolVal(true) && tc.Iscancel == Extension.BoolVal(false)
                                            select new
                                            {
                                                genreId = tc.Oid,
                                                genreName = tc.GenreName
                                            }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listMediaGenre
            };
        }

        public async Task<object> GetAllMediaDay()
        {
            object listMediaDay = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listMediaDay = await (from tc in _ctxOr.TMediaDays
                                          where tc.Isactive == Extension.BoolVal(true) && tc.Iscancel == Extension.BoolVal(false)
                                          select new
                                          {
                                              dayId = tc.Oid,
                                              dayName = tc.DayName
                                          }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listMediaDay
            };
        }

        public async Task<object> GetAllMediaDayPart()
        {
            object listMediaDayPart = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listMediaDayPart = await (from tc in _ctxOr.TMediaDayParts
                                              where tc.Isactive == Extension.BoolVal(true) && tc.Iscancel == Extension.BoolVal(false)
                                              select new
                                              {
                                                  dayPartId = tc.Oid,
                                                  dayPartName = tc.DaypartName
                                              }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listMediaDayPart
            };
        }

        public async Task<object> GetAllMediaAdPosission()
        {
            object listMediaPosition = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listMediaPosition = await (from tc in _ctxOr.TMediaAdPositions
                                               where tc.Isactive == Extension.BoolVal(true) && tc.Iscancel == Extension.BoolVal(false)
                                               select new
                                               {
                                                   positionId = tc.Oid,
                                                   positionName = tc.PositionName
                                               }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listMediaPosition
            };
        }

        public async Task<object> GetAllMediaSponsor()
        {
            object listMediaSponsor = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listMediaSponsor = await (from tc in _ctxOr.TMediaSponsors
                                              where tc.Isactive == Extension.BoolVal(true) && tc.Iscancel == Extension.BoolVal(false)
                                              select new
                                              {
                                                  sponsorId = tc.Oid,
                                                  sponsorName = tc.SponsorName
                                              }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listMediaSponsor
            };
        }

        public async Task<object> GetAllMediaSponsoredProject(string sponsorId)
        {
            object listMediaProject = string.Empty;

            try
            {
                using (_ctxOr = new ModelContext())
                {
                    listMediaProject = await (from tc in _ctxOr.TMediaSponsoredProjects
                                              where tc.SponsorOid == sponsorId &&
                                              tc.Isactive == Extension.BoolVal(true) &&
                                              tc.Iscancel == Extension.BoolVal(false)
                                              select new
                                              {
                                                  projectId = tc.Oid,
                                                  projectName = tc.ProjectName
                                              }
                                ).ToListAsync();
                }

            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                listMediaProject
            };
        }

        ///// <summary>
        ///// This method returns data from database as a list of UserType object using asynchronous operation by an int parameter.
        ///// </summary>
        ///// <returns></returns>
        //public async Task<object> GetAllUserType()
        //{
        //    object listUserType = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listUserType = await (from ut in _ctx.CmnUserType
        //                                  select new
        //                                  {
        //                                      ut.TypeId,
        //                                      ut.TypeName,
        //                                      ut.IsActive,
        //                                      isChecked = false
        //                                  }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listUserType
        //    };
        //}
        //#endregion

        //#region All Methods 


        ///// <summary>
        ///// This method returns data from database as a list of Module object using asynchronous operation by an int parameter.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public async Task<object> getispusertype()
        //{
        //    List<CmnUserTypeIsp> listUserType = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listUserType = await _ctx.CmnUserTypeIsp.ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listUserType
        //    };
        //}

        ///// <summary>
        ///// This method returns data from database as a list of BizCloudActivationProfile object using asynchronous operation by an int parameter.
        ///// </summary>
        ///// <returns></returns>
        //public async Task<object> getallactivationprofiles()
        //{
        //    List<BizCloudActivationProfile> listCloudActivationProfile = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCloudActivationProfile = await (from x in _ctx.BizCloudActivationProfile
        //                                                where x.TenantId == (from y in _ctx.LookupCloudTenant
        //                                                                     where y.IsDefault == true
        //                                                                     select y.CloudTenantId).SingleOrDefault()
        //                                                select x
        //                                                 ).Where(x => x.CompanyId == StaticInfos.CompanyID).OrderByDescending(d => d.CloudActivationProfileId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listCloudActivationProfile
        //    };
        //}

        //public async Task<object> getallactivationprofilesbyuserid(vmCmnParameters cmnParam)
        //{
        //    List<BizCloudActivationProfile> listCloudActivationProfile = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCloudActivationProfile = await (from x in _ctx.BizCloudActivationProfile
        //                                                join ux in _ctx.BizCloudUserPackage on x.ActivationProfileId equals ux.ActivationProfileId
        //                                                where x.TenantId == (from y in _ctx.LookupCloudTenant
        //                                                                     where y.IsDefault == true
        //                                                                     select y.CloudTenantId).SingleOrDefault() && ux.CloudUserId == cmnParam.id
        //                                                select x
        //                                                 ).Distinct().Where(x => x.CompanyId == StaticInfos.CompanyID).OrderByDescending(d => d.CloudActivationProfileId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listCloudActivationProfile
        //    };
        //}

        //public async Task<object> GetActivationProfileWisePackage(vmCmnParameters cmnparam)
        //{
        //    object listVMPackage = null;
        //    object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listVMPackage = await _ctx.BizCloudPackage.Where(x => x.ActivationProfileId == cmnparam.id).ToListAsync();
        //            //(from bcp in _ctx.BizCloudPackage
        //            // join cuc in _ctx.BizCloudUserPackage on bcp.CloudPackageId equals cuc.CloudPackageId
        //            // where bcp.ActivationProfileId == cmnparam.id && cuc.CloudUserId == cmnparam.UserID
        //            // select bcp).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listVMPackage
        //    };
        //}

        ///// <summary>
        ///// returns list of IspProfile.
        ///// </summary>
        ///// <returns></returns>
        //public async Task<object> GetAllIspProfile()
        //{
        //    object listIspProfile = null;
        //    object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listIspProfile = await (from p in _ctx.BizIspPackService
        //                                    select new
        //                                    {
        //                                        p.Srvid,
        //                                        p.Srvname,
        //                                        Unitprice = p.Unitprice == null ? 0 : p.Unitprice,
        //                                        p.Uprate,
        //                                        p.Downrate,
        //                                        //pt.PackageTypeName
        //                                    }).OrderBy(a => a.Srvname).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listIspProfile
        //    };
        //}

        //public async Task<object> getRegions()
        //{
        //    object listRegion = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listRegion = await (from reg in _ctx.BizCloudRegion
        //                                where reg.IsActive == true && reg.CompanyId == StaticInfos.CompanyID
        //                                select new
        //                                {
        //                                    reg.RegionId,
        //                                    RegionName = reg.RegionName.Replace("PACE_CLD_", " ").Replace("-", " ").Replace("_", " ").Trim(),
        //                                    DisplayName = reg.DisplayNameCustom,
        //                                    Checked = false,
        //                                    isdisabled = reg.RegionId == 4 || reg.RegionId == 8 ? false : true
        //                                }).OrderBy(x => x.RegionId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listRegion
        //    };
        //}

        //public async Task<object> getRegionsByActivationProfileId(int activationprofileid)
        //{
        //    object listRegion = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listRegion = await (from reg in _ctx.BizCloudRegion
        //                                join capr in _ctx.BizCloudActivationProfileRegion on reg.RegionId equals capr.RegionId
        //                                where //reg.IsActive == true && 
        //                                reg.CompanyId == StaticInfos.CompanyID && capr.ActivationProfileId == activationprofileid
        //                                select new
        //                                {
        //                                    reg.RegionId,
        //                                    reg.RegionName,
        //                                    DisplayName = reg.DisplayNameCustom,
        //                                    reg.IsActive
        //                                }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listRegion
        //    };
        //}

        //public async Task<object> getOS()
        //{
        //    object osArray = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            osArray = await (from app in _ctx.BizCloudOs
        //                             where app.IsActive == true && app.CompanyId == StaticInfos.CompanyID
        //                             select new
        //                             {
        //                                 app.AppId,
        //                                 app.AppName,
        //                                 app.Description,
        //                                 app.Version,
        //                                 app.ServiceTierId
        //                             }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        osArray
        //    };
        //}

        //public async Task<object> getOS(int id)
        //{
        //    object osArray = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            //bool IsOs = id == 1 ? true : false;
        //            //bool IsStorage = id == 2 ? true : false;
        //            //bool IsApplication = id == 6 ? true : false;

        //            //osArray = await (from ot in _ctx.BizCloudOstype
        //            //                     select new
        //            //                     {
        //            //                         ot.CloudOstypeId,
        //            //                         ot.TypeName,
        //            //                         osArrayDetail = (from app in _ctx.BizCloudOs
        //            //                                    where app.IsActive == true && app.OstypeId == ot.CloudOstypeId && app.CompanyId == StaticInfos.CompanyID && app.ParentServiceId==id
        //            //                                    select new
        //            //                                    {
        //            //                                        app.AppId,
        //            //                                        app.AppName,
        //            //                                        app.Version,
        //            //                                        app.ServiceTierId
        //            //                                    }).ToList()

        //            //                     }).ToListAsync();

        //            osArray = await (from app in _ctx.BizCloudOs
        //                             where app.IsActive == true && app.CompanyId == StaticInfos.CompanyID && app.ParentServiceId == id
        //                             select new
        //                             {
        //                                 app.AppId,
        //                                 app.AppName,
        //                                 app.Version,
        //                                 app.ServiceTierId
        //                             }).OrderBy(x => x.AppName).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        osArray
        //    };
        //}

        //public async Task<object> getOS(vmCmnParameters cmnparam)
        //{
        //    object osArray = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            //bool IsOs = cmnparam.ServiceId == 1 ? true : false;
        //            //bool IsStorage = cmnparam.ServiceId == 2 ? true : false;
        //            //bool IsApplication = cmnparam.ServiceId == 6 ? true : false;

        //            osArray = await (from app in _ctx.BizCloudOs
        //                             where app.IsActive == true && app.CompanyId == StaticInfos.CompanyID && app.ParentServiceId == cmnparam.ServiceId
        //                             select new
        //                             {
        //                                 app.AppId,
        //                                 app.AppName,
        //                                 app.Version,
        //                                 app.Description,
        //                                 app.ServiceTierId//,
        //                                 //AppType = IsOs == true ? "OS" : IsStorage == true ? "Storage" : "Application"
        //                             }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        osArray
        //    };
        //}

        //public async Task<object> getmemory(dynamic appdata)
        //{
        //    object memorylist = null; object result = null;
        //    try
        //    {
        //        string appid = appdata.appid, regionid = appdata.regionid, version = appdata.appversions;
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            memorylist = await (from mm in _ctx.BizCloudMemory
        //                                where mm.AppId == appid && mm.RegionId == regionid && mm.Version == version
        //                                select new
        //                                {
        //                                    mm.AppId,
        //                                    mm.RegionId,
        //                                    mm.Version,
        //                                    mm.MemoryId,
        //                                    mm.MemoryName,
        //                                    mm.MemoryType,
        //                                    mm.MemorySize,
        //                                    //mm.CostPerHour, //Changed date 13 May 2019
        //                                    //mm.CostPerMonth, //Changed date 13 May 2019
        //                                    CostPerHour = mm.CustomCostPerHour == null ? 0 : mm.CustomCostPerHour,
        //                                    CostPerMonth = mm.CustomCostPerMonth == null ? 0 : mm.CustomCostPerMonth,
        //                                    mm.Cpu,
        //                                    mm.Nic
        //                                }
        //                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        memorylist
        //    };
        //}

        //public async Task<object> getmemory()
        //{
        //    object memorylist = null; object result = null;
        //    try
        //    {

        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            memorylist = await (from mm in _ctx.BizCloudMemory
        //                                select new
        //                                {
        //                                    mm.AppId,
        //                                    mm.RegionId,
        //                                    mm.Version,
        //                                    mm.MemoryId,
        //                                    mm.MemoryName,
        //                                    mm.MemoryType,
        //                                    mm.MemorySize,
        //                                    //mm.CostPerHour, //Changed date 13 May 2019
        //                                    //mm.CostPerMonth, //Changed date 13 May 2019
        //                                    CostPerHour = mm.CustomCostPerHour == null ? 0 : mm.CustomCostPerHour,
        //                                    CostPerMonth = mm.CustomCostPerMonth == null ? 0 : mm.CustomCostPerMonth,
        //                                    mm.Cpu
        //                                }
        //                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        memorylist
        //    };
        //}

        //public async Task<object> getallmemory()
        //{
        //    object resdataCldMemory = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            resdataCldMemory = await _ctx.BizCloudMemory.GroupBy(x => new { x.MemoryName }).Select(x => new
        //            {
        //                x.FirstOrDefault().AppId,
        //                x.FirstOrDefault().RegionId,
        //                x.FirstOrDefault().Version,
        //                x.FirstOrDefault().MemoryId,
        //                x.FirstOrDefault().MemoryName,
        //                x.FirstOrDefault().MemoryType,
        //                x.FirstOrDefault().MemorySize,
        //                x.FirstOrDefault().CostPerHour,
        //                x.FirstOrDefault().CostPerMonth,
        //                x.FirstOrDefault().CustomCostPerHour,
        //                x.FirstOrDefault().CustomCostPerMonth,
        //                x.FirstOrDefault().Cpu
        //            }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        resdataCldMemory
        //    };
        //}

        //public async Task<object> getCompanyList()
        //{
        //    object companyList = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            companyList = await (from c in _ctx.AppCompany

        //                                 select new
        //                                 {
        //                                     c.CompanyId,
        //                                     c.CompanyName
        //                                 }
        //                        ).OrderBy(a => a.CompanyName)
        //                        .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        companyList
        //    };
        //}

        //public async Task<object> getAllIspZoneWiseArea(vmCmnParameters cmnParam)
        //{

        //    object listArea = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listArea = await (from ar in _ctx.BizIsparea
        //                              join znar in _ctx.BizIspPopzoneArea on ar.AreaId equals znar.AreaId
        //                              where ar.IsActive == true && znar.ZoneId == cmnParam.zoneId
        //                              select new
        //                              {
        //                                  ar.AreaId,
        //                                  ar.AreaName
        //                              }
        //                        ).OrderBy(a => a.AreaName)
        //                        .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listArea
        //    };
        //}

        //public async Task<object> getallmemories()
        //{
        //    object memorylist = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            memorylist = await _ctx.BizCloudMemory.GroupBy(x => new { x.MemoryName }).Select(x => new
        //            {
        //                x.FirstOrDefault().AppId,
        //                x.FirstOrDefault().RegionId,
        //                x.FirstOrDefault().Version,
        //                x.FirstOrDefault().MemoryId,
        //                x.FirstOrDefault().MemoryName,
        //                x.FirstOrDefault().MemoryType,
        //                x.FirstOrDefault().MemorySize,
        //                CostPerHour = x.FirstOrDefault().CustomCostPerHour == null ? 0 : x.FirstOrDefault().CustomCostPerHour,
        //                CostPerMonth = x.FirstOrDefault().CustomCostPerMonth == null ? 0 : x.FirstOrDefault().CustomCostPerMonth,
        //                x.FirstOrDefault().Cpu
        //            }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        memorylist
        //    };
        //}

        //public async Task<object> getstorage(dynamic appdata)
        //{
        //    object storagelist = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            string regid = appdata.regionid;
        //            storagelist = await (from mm in _ctx.BizCloudStorage
        //                                 where mm.RegionId == regid
        //                                 select new
        //                                 {
        //                                     mm.StorageId,
        //                                     mm.StorageName,
        //                                     mm.StorageType,
        //                                     mm.MaxVolumeSize,
        //                                     mm.MinVolumeSize,
        //                                     //mm.CostPerHour, //Changed date 13 May 2019
        //                                     //mm.CostPerMonth, //Changed date 13 May 2019
        //                                     CostPerHour = mm.CustomCostPerHour == null ? 0 : mm.CustomCostPerHour,
        //                                     CostPerMonth = mm.CustomCostPerMonth == null ? 0 : mm.CustomCostPerMonth,
        //                                 }
        //                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        storagelist
        //    };
        //}

        //public async Task<object> getstorage()
        //{
        //    object storagelist = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {

        //            storagelist = await _ctx.BizCloudStorage.GroupBy(x => new { x.StorageName, x.StorageType }).Select(x => new
        //            {
        //                x.FirstOrDefault().StorageId,
        //                x.FirstOrDefault().StorageName,
        //                x.FirstOrDefault().StorageType,
        //                x.FirstOrDefault().MaxVolumeSize,
        //                x.FirstOrDefault().MinVolumeSize,
        //                CostPerHour = x.FirstOrDefault().CustomCostPerHour == null ? 0 : x.FirstOrDefault().CustomCostPerHour,
        //                CostPerMonth = x.FirstOrDefault().CustomCostPerMonth == null ? 0 : x.FirstOrDefault().CustomCostPerMonth,
        //            }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        storagelist
        //    };
        //}

        ////before bari
        //public async Task<object> getrootdiskvolume(dynamic appdata)
        //{
        //    object rootdisklist = null, addvollist = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            string regid = appdata.regionid;
        //            rootdisklist = await (from mm in _ctx.BizCloudRootDisk
        //                                  where mm.RegionId == regid
        //                                  select new
        //                                  {
        //                                      mm.CloudRootDiskId,
        //                                      mm.StorageSize,
        //                                      mm.RegionId,
        //                                  }
        //                        ).ToListAsync();

        //            addvollist = await (from mm in _ctx.BizCloudAdditionalVolume
        //                                where mm.RegionId == regid
        //                                select new
        //                                {
        //                                    mm.CloudAdditionalVolumeId,
        //                                    mm.StorageSize,
        //                                    mm.RegionId,
        //                                }
        //                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        rootdisklist,
        //        addvollist
        //    };
        //}

        ////after bari
        //public async Task<object> getrootdiskvolume()
        //{
        //    object rootdisklist = null, addvollist = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            rootdisklist = await (from mm in _ctx.BizCloudRootDisk

        //                                  select new
        //                                  {
        //                                      mm.CloudRootDiskId,
        //                                      mm.StorageSize,
        //                                      mm.RegionId,
        //                                  }
        //                        ).GroupBy(x => new { x.StorageSize }).Select(x => new { x.FirstOrDefault().CloudRootDiskId, x.FirstOrDefault().StorageSize, x.FirstOrDefault().RegionId }).ToListAsync();

        //            addvollist = await (from mm in _ctx.BizCloudAdditionalVolume

        //                                select new
        //                                {
        //                                    mm.CloudAdditionalVolumeId,
        //                                    mm.StorageSize,
        //                                    mm.RegionId,
        //                                }
        //                        ).GroupBy(x => new { x.StorageSize }).Select(x => new { x.FirstOrDefault().CloudAdditionalVolumeId, x.FirstOrDefault().StorageSize, x.FirstOrDefault().RegionId }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        rootdisklist,
        //        addvollist
        //    };
        //}

        ///// <summary>
        ///// This method returns data from database as a list of BizCloudActivationProfile object using asynchronous operation by an int parameter.
        ///// </summary>
        ///// <returns></returns>
        //public async Task<object> getallusageplantype()
        //{
        //    List<LookupCloudUsagePlanType> listCloudUsagePlanType = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCloudUsagePlanType = await _ctx.LookupCloudUsagePlanType.ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listCloudUsagePlanType
        //    };
        //}/// <summary>

        ///// getallpackage can perform to Cisco table by int parameter in database using asynchronous operation. It returns an object as status of success or failure.
        ///// </summary>
        ///// <param name=""></param>
        ///// <returns></returns>
        //public async Task<object> getallpackages()
        //{
        //    object resdata = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            resdata = await _ctx.BizCloudPackage.ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        ///// <summary>
        ///// getAllBizContracts  method is used to retrieve data  from localdb.
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public async Task<object> GetAllEnvironments()
        //{
        //    object result = null; List<BizCloudDeploymentEnvironment> listCloudDepEnv = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCloudDepEnv = await _ctx.BizCloudDeploymentEnvironment.Where(x => x.DisplayName != null).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCloudDepEnv
        //    };
        //}

        //public async Task<object> GetAllEnvironments(vmCmnParameters param)
        //{
        //    object result = null, listCloudDepEnv = null; BizCloudDeploymentEnvironment listCloudUserDepEnv = new BizCloudDeploymentEnvironment();
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            int? CloudUserId = _ctx.BizCloudDeploymentEnvironment.Where(x => x.CloudUserId == param.CloudUserID).FirstOrDefault() == null ? null : _ctx.BizCloudDeploymentEnvironment.Where(x => x.CloudUserId == param.CloudUserID).FirstOrDefault().CloudUserId;

        //            listCloudDepEnv = await (from cde in _ctx.BizCloudDeploymentEnvironment
        //                                     where cde.RegionId.ToString() == param.regionId && cde.CloudUserId == CloudUserId && cde.CountryId == (CloudUserId == null ? null : param.CountryId) && cde.IsActive == true
        //                                     select new
        //                                     {
        //                                         cde.CloudDeploymentEnvId,
        //                                         cde.CustomCostPerHour,
        //                                         cde.DepEnvId,
        //                                         DisplayName = CloudUserId == null ? cde.DisplayName : cde.EnvironmentName,
        //                                         cde.EnvironmentName,
        //                                         cde.RegionId,
        //                                         cde.TotalAppCost,
        //                                         cde.TotalDeployments,
        //                                         cde.TotalJobsCost
        //                                     }
        //                               ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCloudDepEnv
        //    };
        //}

        //public async Task<object> GetAllEnvironment()
        //{
        //    object result = null; object listCloudDepEnv = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCloudDepEnv = await (from dep in _ctx.BizCloudDeploymentEnvironment
        //                                     select new
        //                                     {
        //                                         dep.DepEnvId,
        //                                         dep.DisplayName,
        //                                         dep.EnvironmentName
        //                                     }
        //                                     ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCloudDepEnv
        //    };
        //}

        ///// <summary>
        ///// getAllBizContracts  method is used to retrieve data  from localdb.
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public async Task<object> getAllBizContracts()
        //{
        //    object result = null; List<BizCloudContract> listCloudContract = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {

        //            listCloudContract = await (from x in _ctx.BizCloudContract
        //                                       where x.TenantId == (from y in _ctx.LookupCloudTenant
        //                                                            where y.IsDefault == true
        //                                                            select y.CloudTenantId).SingleOrDefault()
        //                                       select x).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCloudContract
        //    };
        //}//getAllContractsByTenant

        ///// <summary>
        ///// getAllBizContracts  method is used to retrieve data  from localdb.
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public async Task<object> getAllContractsByTenant(vmCmnParameters cmnParam)
        //{
        //    object result = null; List<BizCloudContract> listCloudContract = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            var TenantId = cmnParam.UserID > 0 ? _ctx.LookupCloudTenantSub.Where(x => x.UserId == cmnParam.UserID.ToString()).FirstOrDefault().CloudSubTenantId : cmnParam.TenantId;
        //            listCloudContract = await (from x in _ctx.BizCloudContract
        //                                       where x.TenantId == TenantId
        //                                       select x).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCloudContract
        //    };
        //}

        ///// <summary>
        ///// getAllUsagePlans  method is used to retrieve data  from localdb.
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public async Task<object> getAllUsagePlans()
        //{
        //    object result = null; List<BizCloudUsagePlan> listCloudUsagePlan = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            //await (from x in _ctx.BizCloudUsagePlan
        //            //       where x.TenantId == ((from y in _ctx.LookupCloudTenant
        //            //                             where y.IsDefault == true
        //            //                             select y.CloudTenantId).SingleOrDefault())
        //            //       select x).OrderByDescending(x => x.CloudUsagePlanId).Skip(Conversions.Skip(cmnParam)).Take((int)cmnParam.pageSize).ToListAsync();
        //            //listCloudUsagePlan = await _ctx.BizCloudUsagePlan.ToListAsync();
        //            listCloudUsagePlan = await (from x in _ctx.BizCloudUsagePlan
        //                                        where x.TenantId == (from y in _ctx.LookupCloudTenant
        //                                                             where y.IsDefault == true
        //                                                             select y.CloudTenantId).SingleOrDefault()
        //                                        select x
        //                                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCloudUsagePlan
        //    };
        //}

        ///// <summary>
        ///// getAllUsagePlans  method is used to retrieve data  from localdb.
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public async Task<object> getAllUsagePlansByTenant(vmCmnParameters cmnParam)
        //{
        //    object result = null; List<BizCloudUsagePlan> listCloudUsagePlan = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            var TenantId = cmnParam.UserID > 0 ? _ctx.LookupCloudTenantSub.Where(x => x.UserId == cmnParam.UserID.ToString()).FirstOrDefault().CloudSubTenantId : cmnParam.TenantId;
        //            listCloudUsagePlan = await (from x in _ctx.BizCloudUsagePlan
        //                                        where x.TenantId == TenantId
        //                                        select x
        //                                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCloudUsagePlan
        //    };
        //}

        //public async Task<object> getcategory(vmCmnParameters param)
        //{
        //    object listCategory = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCategory = await (from cat in _ctx.InvCategory
        //                                  where cat.IsActive == true && cat.CompanyId == (param.CompanyID == null ? StaticInfos.CompanyID : param.CompanyID)
        //                                  select new
        //                                  {
        //                                      cat.CategoryId,
        //                                      cat.CategoryName
        //                                  }
        //                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCategory
        //    };
        //}

        //public async Task<object> getsupplier(vmCmnParameters param)
        //{
        //    object listSupplier = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listSupplier = await (from supp in _ctx.InvSupplier
        //                                  where supp.IsActive == true && supp.CompanyId == (param.CompanyID == null ? StaticInfos.CompanyID : param.CompanyID)
        //                                  select new
        //                                  {
        //                                      supp.SupplierId,
        //                                      supp.SupplierName
        //                                  }
        //                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listSupplier
        //    };
        //}

        //public async Task<object> getmanufacturer(vmCmnParameters param)
        //{
        //    object listManufacturer = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listManufacturer = await (from man in _ctx.InvManufacturer
        //                                      where man.IsActive == true && man.CompanyId == (param.CompanyID == null ? StaticInfos.CompanyID : param.CompanyID)
        //                                      select new
        //                                      {
        //                                          man.ManufacturerId,
        //                                          man.ManufacturerName
        //                                      }
        //                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listManufacturer
        //    };
        //}

        //public async Task<object> getUnitMeasurment()
        //{
        //    object listUOM = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listUOM = await (from cum in _ctx.CmnUnitMeasurement
        //                             where cum.IsActive == true && cum.CompanyId == StaticInfos.CompanyID
        //                             select new
        //                             {
        //                                 cum.UnitId,
        //                                 cum.UnitName
        //                             }
        //                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listUOM
        //    };
        //}

        //public async Task<object> getSalesType()
        //{
        //    object listISType = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listISType = await (from iis in _ctx.InvItemSaleType
        //                                where iis.IsActive == true && iis.CompanyId == StaticInfos.CompanyID
        //                                select new
        //                                {
        //                                    iis.SaleTypeId,
        //                                    iis.SaleTypeName
        //                                }
        //                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listISType
        //    };
        //}

        //public async Task<object> getInvCustomer()
        //{
        //    object listICustomer = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listICustomer = await (from ic in _ctx.InvCustomer
        //                                   where ic.IsActive == true && ic.CompanyId == StaticInfos.CompanyID
        //                                   select new
        //                                   {
        //                                       ic.CustomerId,
        //                                       ic.CustomerName
        //                                   }
        //                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listICustomer
        //    };
        //}

        //public async Task<object> getInvStore(vmCmnParameters param)
        //{
        //    object listIStore = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listIStore = await (from str in _ctx.InvStore
        //                                where str.IsActive == true && str.CompanyId == (param.CompanyID == null ? StaticInfos.CompanyID : param.CompanyID)
        //                                select new
        //                                {
        //                                    str.StoreId,
        //                                    str.StoreName
        //                                }
        //                        ).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listIStore
        //    };
        //}

        //public async Task<object> getAllIspZone()
        //{
        //    object listZone = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listZone = await (from zn in _ctx.BizIspPopzone
        //                              where zn.IsActive == true && zn.CompanyId == StaticInfos.CompanyID
        //                              select new
        //                              {
        //                                  zn.ZoneId,
        //                                  zn.ZoneName
        //                              }
        //                        ).OrderBy(a => a.ZoneName)
        //                        .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listZone
        //    };
        //}

        //public async Task<object> GetAllIspArea()
        //{
        //    object listArea = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listArea = await (from o in _ctx.BizIsparea
        //                              where o.IsActive == true && o.CompanyId == StaticInfos.CompanyID
        //                              select new
        //                              {
        //                                  o.AreaId,
        //                                  o.AreaName
        //                              }
        //                        ).OrderBy(a => a.AreaName)
        //                        .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listArea
        //    };
        //}

        //public async Task<object> GetAllCloudArea()
        //{
        //    object listArea = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listArea = await (from o in _ctx.BizCloudArea
        //                              where o.IsActive == true && o.CompanyId == StaticInfos.CompanyID
        //                              select new
        //                              {
        //                                  o.AreaId,
        //                                  o.AreaName
        //                              }
        //                        ).OrderBy(a => a.AreaName)
        //                        .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listArea
        //    };
        //}

        //public async Task<object> getEmployee(vmCmnParameters cmnParam)
        //{
        //    object listCUsr = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCUsr = await (from cu in _ctx.CmnUser
        //                              where cu.IsActive == true && cu.CompanyId == StaticInfos.CompanyID
        //                              && cu.UserTypeId == cmnParam.TypeID
        //                              select new
        //                              {
        //                                  cu.UserId,
        //                                  FullName = ((cu.FrstName == null ? "" : cu.FrstName + " " + (cu.MiddleName == null ? "" : cu.MiddleName)).Trim() + " " + (cu.LastName == null ? "" : cu.LastName)).Trim()
        //                              }
        //                        ).OrderByDescending(x => x.UserId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCUsr
        //    };
        //}

        //public async Task<object> GetIspPackageType(vmCmnParameters cmnParam)
        //{
        //    object listIspPackageType = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            using (var _ctxTransaction = _ctx.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
        //            {
        //                listIspPackageType = await _ctx.BizIspPackageType.ToListAsync();
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listIspPackageType
        //    };
        //}

        //public async Task<object> GetVoucherType(vmCmnParameters cmnParam)
        //{
        //    object listVoucherType = null; object result = null;
        //    try
        //    {
        //        //using (_ctx = new dbRGLERPContext())
        //        //{
        //        //    using (var _ctxTransaction = _ctx.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
        //        //    {
        //        //        listVoucherType = await _ctx.AccVouchersType.ToListAsync();
        //        //    }

        //        //}
        //        var dict = new Dictionary<int, string>();
        //        foreach (var name in Enum.GetNames(typeof(StaticInfos.VoucherPreference)))
        //        {
        //            dict.Add((int)Enum.Parse(typeof(StaticInfos.VoucherPreference), name), name);
        //        }
        //        listVoucherType = dict.Select(x => new { voucherTypeId = x.Key, voucherType = x.Value }).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listVoucherType
        //    };
        //}

        //public async Task<object> GetTenantType(vmCmnParameters cmnParam)
        //{
        //    object listTenantType = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            using (var _ctxTransaction = _ctx.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
        //            {
        //                listTenantType = await _ctx.LookupCloudTenantType.ToListAsync();
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listTenantType
        //    };
        //}
        //public async Task<object> GetBundleList()
        //{
        //    object bundleList = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            using (var _ctxTransaction = _ctx.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
        //            {
        //                bundleList = await (from x in _ctx.BizCloudBundle
        //                                    where x.TenantId == (from y in _ctx.LookupCloudTenant
        //                                                         where y.IsDefault == true
        //                                                         select y.CloudTenantId).SingleOrDefault()
        //                                    select x).ToListAsync();
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        bundleList
        //    };
        //}

        //public async Task<object> GetCloudBundleType(vmCmnParameters cmnParam)
        //{
        //    object listBundleType = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            using (var _ctxTransaction = _ctx.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
        //            {
        //                listBundleType = await _ctx.LookupBundleType.ToListAsync();
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listBundleType
        //    };
        //}

        //public async Task<object> GetCloudBundleExpirationType(vmCmnParameters cmnParam)
        //{
        //    object listBundleExpirationType = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            using (var _ctxTransaction = _ctx.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
        //            {
        //                listBundleExpirationType = await _ctx.LookupBundleExpirationType.ToListAsync();
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listBundleExpirationType
        //    };
        //}
        //public async Task<object> GetPrimaryGroupForGroupHead()
        //{
        //    object result = null; List<AccGroupHead> listAccGroupHead = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {

        //            var ids = new HashSet<int>(_ctx.AccGroupHead.Select(x => (int)x.UnderId).Distinct());

        //            listAccGroupHead = await _ctx.AccGroupHead.Where(x => !x.GroupName.Contains("Retained Earnings")).ToListAsync();
        //            // listAccGroupHead = await _ctx.AccGroupHead.Where(x => !ids.Contains(x.GroupId)).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listAccGroupHead
        //    };
        //}

        //public async Task<object> GetPrimaryGroup()
        //{
        //    object result = null; List<AccGroupHead> listAccGroupHead = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {

        //            var ids = new HashSet<int>(_ctx.AccGroupHead.Select(x => (int)x.UnderId).Distinct());

        //            //listAccGroupHead = await _ctx.AccGroupHead.Where(x => x.GroupId != 14).ToListAsync();
        //            listAccGroupHead = await _ctx.AccGroupHead.Where(x => !ids.Contains(x.GroupId)).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listAccGroupHead
        //    };
        //}

        //public async Task<object> getcloudplan()
        //{
        //    object result = null; List<LookupCloudPlan> listCloudPlan = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCloudPlan = await _ctx.LookupCloudPlan.ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCloudPlan
        //    };
        //}

        //public async Task<object> GetCurrency()
        //{
        //    object result = null; List<LookupCurrency> listCurrency = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCurrency = await _ctx.LookupCurrency.ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCurrency
        //    };
        //}

        //public async Task<object> geteligibleusersubtenant()
        //{
        //    object result = null; List<CmnUserCloud> listUserCloud = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listUserCloud = await (from x in _ctx.CmnUserCloud
        //                                   where x.Type == "STANDARD" &&
        //                                   x.CloudUserId != (from y in _ctx.LookupCloudTenantSub
        //                                                     select Convert.ToInt32(y.UserId)
        //                                                        ).SingleOrDefault()
        //                                                        &&
        //                                                        Convert.ToInt32(x.TenantId) == (from y in _ctx.LookupCloudTenant
        //                                                                                        where y.IsDefault == true
        //                                                                                        select y.CloudTenantId).SingleOrDefault()
        //                                   select x).ToListAsync();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listUserCloud
        //    };
        //}
        //public async Task<object> gettenant()
        //{
        //    object result = null; List<LookupCloudTenant> listCloudTenant = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCloudTenant = await _ctx.LookupCloudTenant.ToListAsync();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCloudTenant
        //    };
        //}
        //public async Task<object> getsubtenant(vmCmnParameters cmnParam)
        //{
        //    object result = null; List<LookupCloudTenantSub> listCloudSubTenant = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCloudSubTenant = await _ctx.LookupCloudTenantSub.Where(x => x.ParentTenantId == cmnParam.TenantId).ToListAsync();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCloudSubTenant
        //    };
        //}
        //public async Task<object> getalluser()
        //{
        //    object result = null; List<CmnUserCloud> listUserCloud = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listUserCloud = await (from x in _ctx.CmnUserCloud
        //                                   where Convert.ToInt32(x.TenantId) == (from y in _ctx.LookupCloudTenant
        //                                                                         where y.IsDefault == true
        //                                                                         select y.CloudTenantId).SingleOrDefault()
        //                                   select x).ToListAsync();
        //            //  await _ctx.CmnUserCloud.ToListAsync();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listUserCloud
        //    };
        //}

        ////public async Task<object> GetDeploymentType(int id)
        ////{
        ////    object result = null, listDeptType = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            //listDeptType = await _ctx.LookupDeployType.ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }

        ////    return result = new
        ////    {
        ////        listDeptType
        ////    };
        ////}

        //public async Task<object> GetDeploymentService(int id)
        //{
        //    object result = null, listDeptService = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listDeptService = await (from lds in _ctx.LookupCloudDeployService
        //                                         //join ldts in _ctx.LookupDeployTypeService on lds.ServiceId equals ldts.ServiceId
        //                                     where lds.IsActive == true
        //                                     //&& ldts.IsActive == true
        //                                     && lds.CompanyId == StaticInfos.CompanyID
        //                                     //&& ldts.CompanyId == StaticInfos.CompanyID
        //                                     && lds.UnderService == id
        //                                     select new
        //                                     {
        //                                         lds.ServiceId,
        //                                         lds.ServiceName,
        //                                         ServiceCost = 0,
        //                                         lds.IsChecked,
        //                                         isdisabled = true
        //                                     }).OrderBy(x => x.ServiceId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listDeptService
        //    };
        //}
        //public async Task<object> getscalingpolicy()
        //{
        //    object result = null, listDeptService = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listDeptService = await (from lds in _ctx.LookupCloudDeployService
        //                                     where lds.IsActive == true
        //                                     && lds.CompanyId == StaticInfos.CompanyID
        //                                     select new
        //                                     {
        //                                         lds.ServiceId,
        //                                         lds.ServiceName,
        //                                         lds.IsChecked
        //                                     }).OrderBy(x => x.ServiceId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listDeptService
        //    };
        //}
        //public async Task<object> getsuspensionpolicy()
        //{
        //    object result = null, listDeptService = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listDeptService = await (from lds in _ctx.LookupCloudDeployService
        //                                     where lds.IsActive == true
        //                                     && lds.CompanyId == StaticInfos.CompanyID
        //                                     select new
        //                                     {
        //                                         lds.ServiceId,
        //                                         lds.ServiceName,
        //                                         lds.IsChecked
        //                                     }).OrderBy(x => x.ServiceId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listDeptService
        //    };
        //}
        //public async Task<object> getagingpolicy()
        //{
        //    object result = null, listDeptService = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listDeptService = await (from lds in _ctx.LookupCloudDeployService
        //                                     where lds.IsActive == true
        //                                     && lds.CompanyId == StaticInfos.CompanyID
        //                                     select new
        //                                     {
        //                                         lds.ServiceId,
        //                                         lds.ServiceName,
        //                                         lds.IsChecked
        //                                     }).OrderBy(x => x.ServiceId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listDeptService
        //    };
        //}

        //public async Task<object> getDeployCloud()
        //{
        //    object result = null, listDeptCloud = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listDeptCloud = await (from ldc in _ctx.LookupDeployCloud
        //                                   where ldc.IsActive == true
        //                                   && ldc.CompanyId == StaticInfos.CompanyID
        //                                   select new
        //                                   {
        //                                       ldc.CloudId,
        //                                       ldc.CloudName,
        //                                       ldc.Icon,
        //                                       ldc.IconColor,
        //                                       ldc.IconGray
        //                                   }).OrderBy(x => x.CloudId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listDeptCloud
        //    };
        //}

        //public async Task<object> getCloudDeploymentByUser(vmCmnParameters param)
        //{
        //    object result = null, listCloudDeployment = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCloudDeployment = await (from bcd in _ctx.BizCloudDeployment
        //                                         where bcd.ServiceId == param.ServiceId
        //                                         && bcd.CloudUserId == param.UserID
        //                                         && bcd.CloudId == param.CloudId
        //                                         && bcd.IsActive == true
        //                                         && bcd.CompanyId == StaticInfos.CompanyID
        //                                         select new
        //                                         {
        //                                             bcd.DeploymentId,
        //                                             bcd.DeploymentName,
        //                                             bcd.CloudUserId,
        //                                             bcd.ServiceId,
        //                                             bcd.CloudId
        //                                         }).OrderBy(x => x.DeploymentId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCloudDeployment
        //    };
        //}

        //public async Task<object> GetParentDeploymentService()
        //{
        //    object result = null, listDeptService = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listDeptService = await (from lds in _ctx.LookupCloudDeployService
        //                                     where lds.IsActive == true
        //                                     && lds.CompanyId == StaticInfos.CompanyID
        //                                     && lds.UnderService == null
        //                                     && lds.ParentType != null
        //                                     select new
        //                                     {
        //                                         lds.ServiceId,
        //                                         lds.ServiceName
        //                                     }).OrderBy(x => x.ServiceId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listDeptService
        //    };
        //}

        //public async Task<object> GetAllPolicyType()
        //{
        //    object result = null, listPolicyType = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listPolicyType = await (from plc in _ctx.BizCloudPolicyType
        //                                    select new
        //                                    {
        //                                        plc.PolicyTypeId,
        //                                        plc.PolicyType
        //                                    }).OrderBy(x => x.PolicyTypeId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listPolicyType
        //    };
        //}
        //public async Task<object> GetAllPolicyTypeList()
        //{
        //    object result = null, listPolicyType = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listPolicyType = await (from plc in _ctx.BizCloudPolicyType
        //                                    select new
        //                                    {
        //                                        plc.PolicyTypeId,
        //                                        plc.PolicyType,
        //                                        isAutoCheck = false
        //                                    }).OrderBy(x => x.PolicyTypeId).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listPolicyType
        //    };
        //}

        ////public async Task<object> GetAllPolicy(vmCmnParameters cmnParameters)
        ////{
        ////    object result = null; List<vmCloudPolicy> listPolicy = null; List<vmCloudPolicy> listPolicyTemp = null; List<BizCloudPolicy> defaultPolicyList = new List<BizCloudPolicy>();
        ////    try
        ////    {

        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            var policyType = _ctx.BizCloudPolicyType.Where(x => x.PolicyType.Trim() == cmnParameters.Name.Trim()).SingleOrDefault();
        ////            if (cmnParameters.UserID > 0)
        ////            {
        ////                defaultPolicyList = _ctx.BizCloudPolicy.Where(x => x.CloudUserId == null && x.PolicyTypeId == policyType.PolicyTypeId).ToList();
        ////                listPolicyTemp = await (from plc in _ctx.BizCloudPolicy
        ////                                        where plc.PolicyTypeId == policyType.PolicyTypeId && plc.CloudUserId == cmnParameters.UserID
        ////                                        select new vmCloudPolicy
        ////                                        {
        ////                                            id = plc.CloudPolicyId,
        ////                                            name = plc.PolicyName,
        ////                                            typeId = plc.PolicyTypeId
        ////                                        }).OrderBy(x => x.id).ToListAsync();
        ////                if (defaultPolicyList.Count > 0)
        ////                {
        ////                    foreach (var item in defaultPolicyList)
        ////                    {
        ////                        vmCloudPolicy depPloicy = new vmCloudPolicy
        ////                        {
        ////                            id = item.CloudPolicyId,
        ////                            name = item.PolicyName,
        ////                            typeId = item.PolicyTypeId
        ////                        };
        ////                        listPolicyTemp.Add(depPloicy);
        ////                    }

        ////                }

        ////                listPolicy = listPolicyTemp.OrderByDescending(x => x.id).ToList();

        ////            }
        ////            else
        ////            {
        ////                listPolicy = await (from plc in _ctx.BizCloudPolicy
        ////                                    where plc.PolicyTypeId == policyType.PolicyTypeId
        ////                                    select new vmCloudPolicy
        ////                                    {
        ////                                        id = plc.CloudPolicyId,
        ////                                        name = plc.PolicyName,
        ////                                        typeId = plc.PolicyTypeId
        ////                                    }).OrderBy(x => x.id).ToListAsync();
        ////            }

        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }

        ////    return result = new
        ////    {
        ////        listPolicy
        ////    };
        ////}

        //public async Task<object> GetAllCrmCloudTicketCategory(vmCmnParameters cmnParameters)
        //{
        //    object result = null, listTicketCategory = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listTicketCategory = await (from tc in _ctx.CrmCloudTicketCategory
        //                                        where tc.IsActive == true
        //                                        select new
        //                                        {
        //                                            tc.CloudTicketCategoryId,
        //                                            tc.TicketCategory
        //                                        }).OrderBy(x => x.TicketCategory).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listTicketCategory
        //    };
        //}

        //public async Task<object> GetAllCrmIspTicketCategory(vmCmnParameters cmnParameters)
        //{
        //    object result = null, listTicketCategory = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listTicketCategory = await (from tc in _ctx.CrmIspTicketCategory
        //                                        where tc.IsActive == true
        //                                        select new
        //                                        {
        //                                            tc.IspTicketCategoryId,
        //                                            tc.TicketCategory
        //                                        }).OrderBy(x => x.TicketCategory).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listTicketCategory
        //    };
        //}
        //#endregion

        ////#region isp sales
        ////public async Task<object> GetAllSalesTeamType()
        ////{
        ////    List<SalIspTeamType> listTeamType = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listTeamType = await _ctx.SalIspTeamType.ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listTeamType
        ////    };
        ////}

        ////public async Task<object> GetAllSalesCmnuser()
        ////{
        ////    object listCmnUser = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listCmnUser = await (from cu in _ctx.CmnUser
        ////                                 join r in _ctx.CmnUserRole on Convert.ToInt32(cu.UserRoleId) equals r.RoleId
        ////                                 select new
        ////                                 {
        ////                                     cu.UserId,
        ////                                     cu.FrstName,
        ////                                     cu.MiddleName,
        ////                                     cu.LastName,
        ////                                     r.RoleName,
        ////                                     r.RoleCode
        ////                                     ,
        ////                                     fullName = (((string.IsNullOrEmpty(cu.FrstName) ? string.Empty : cu.FrstName.Trim()) + " " + (string.IsNullOrEmpty(cu.MiddleName) ? string.Empty : cu.MiddleName.Trim())).Trim() + " " + (string.IsNullOrEmpty(cu.LastName) ? string.Empty : cu.LastName.Trim())).Trim()
        ////                                 }
        ////                                 ).OrderBy(a => a.fullName)
        ////                                 .ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listCmnUser
        ////    };
        ////}

        ////public async Task<object> GetAllIspUserByType(vmCmnParameters param)
        ////{
        ////    object listCmnUserIsp = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listCmnUserIsp = await (from cu in _ctx.CmnUserIsp
        ////                                    where cu.UserTypeId == param.userType
        ////                                    select new
        ////                                    {
        ////                                        cu.UserId,
        ////                                        cu.FirstName,
        ////                                        cu.LastName,
        ////                                        fullName = (cu.FirstName.Trim() + " " + cu.LastName.Trim()).Trim(),
        ////                                        cu.UserTypeId
        ////                                    }
        ////                                 ).ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listCmnUserIsp
        ////    };
        ////}

        ////public async Task<object> GetAllSalesCampaignType()
        ////{
        ////    List<SalIspCampaignType> listCampaignType = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listCampaignType = await _ctx.SalIspCampaignType.ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listCampaignType
        ////    };
        ////}

        ////public async Task<object> GetAllSalesCampaignStatus()
        ////{
        ////    List<SalIspCampaignStatus> listCampaignStatus = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listCampaignStatus = await _ctx.SalIspCampaignStatus.ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listCampaignStatus
        ////    };
        ////}

        ////public async Task<object> GetAllSalesCampaign()
        ////{
        ////    List<SalIspCampaign> listCampaign = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listCampaign = await _ctx.SalIspCampaign.ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listCampaign
        ////    };
        ////}

        ////public async Task<object> GetAllSalesAccountType()
        ////{
        ////    List<SalIspAccountType> listAccountType = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listAccountType = await _ctx.SalIspAccountType
        ////                .OrderBy(a => a.TypeName)
        ////                .ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listAccountType
        ////    };
        ////}

        ////public async Task<object> GetAllSalesIndustry()
        ////{
        ////    List<SalIspIndustry> listIndustry = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listIndustry = await _ctx.SalIspIndustry.ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listIndustry
        ////    };
        ////}

        ////public async Task<object> GetAllSalesContact()
        ////{
        ////    //List<SalIspContact> listContact = null; object result = null;
        ////    object listContact = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listContact = await _ctx.SalIspContact
        ////                .Select
        ////                        (c => new
        ////                        {
        ////                            contactId = c.ContactId,
        ////                            fullName = ((c.FirstName.Trim() + " " + c.MiddleName).Trim() + " " + c.LastName.Trim()).Trim()
        ////                        })
        ////                .OrderBy(a => a.fullName)
        ////                .ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listContact
        ////    };
        ////}

        ////public async Task<object> GetAllSalesAccount()
        ////{
        ////    List<SalIspAccount> listAccount = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listAccount = await _ctx.SalIspAccount
        ////                .OrderBy(d => d.AccountName)
        ////                .ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listAccount
        ////    };
        ////}

        ////public async Task<object> GetAllSalesOpportunityType()
        ////{
        ////    List<SalIspOpportunityType> listOpportunityType = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listOpportunityType = await _ctx.SalIspOpportunityType.ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listOpportunityType
        ////    };
        ////}

        ////public async Task<object> GetAllSalesOpportunityStage()
        ////{
        ////    List<SalIspOpportunityStage> listOpportunityStage = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listOpportunityStage = await _ctx.SalIspOpportunityStage.ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listOpportunityStage
        ////    };
        ////}

        ////public async Task<object> GetAllSalesOpportunityLossReason()
        ////{
        ////    List<SalIspOpportunityLossReason> listOpportunityLossReason = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listOpportunityLossReason = await _ctx.SalIspOpportunityLossReason.ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listOpportunityLossReason
        ////    };
        ////}

        ////public async Task<object> GetAllSalesTaskPriority()
        ////{
        ////    List<SalIspTaskPriority> listPriority = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listPriority = await _ctx.SalIspTaskPriority.ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listPriority
        ////    };
        ////}

        ////public async Task<object> GetAllSalesTaskStatus()
        ////{
        ////    List<SalIspTaskStatus> listStatus = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listStatus = await _ctx.SalIspTaskStatus.ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listStatus
        ////    };
        ////}

        //////public async Task<object> getallLeadConnection(vmCmnParameters param)
        //////{
        //////    object result = null, listLeadConnection = null; _ctx = new dbRGLERPContext();
        //////    try
        //////    {
        //////        listLeadConnection = await (from c in _ctx.SalIspLeadProbableConnection
        //////                                    join opt in _ctx.SalIspOpportunity on c.LeadId equals opt.LeadId
        //////                                    join opc in _ctx.SalIspOpptProbableConnection on (int)opt.OpportunityId equals opc.OpportunityId
        //////                                    join pft in _ctx.CmnProcessFlowTransaction on (int)opc.AccountId equals pft.AccountId.Value
        //////                                         into pftT
        //////                                         from pft in pftT.DefaultIfEmpty()
        //////                                    join sit in _ctx.SalIspTeam on pft.TeamId.Value equals sit.TeamId
        //////                                         into sitT
        //////                                         from sit in sitT.DefaultIfEmpty()


        //////                                    where c.LeadId == param.LeadId

        //////                                    select new
        //////                                    {
        //////                                        c.LeadConnectionId,
        //////                                        c.ConnectionNo,
        //////                                        c.LeadId,
        //////                                        c.LeadUserTypeId,
        //////                                        c.LeadName,
        //////                                        c.ResponsiblePersonName,
        //////                                        c.ContactId,
        //////                                        c.AccountId,
        //////                                        c.Email,
        //////                                        c.PhoneNumber,
        //////                                        c.PhoneExtra,
        //////                                        c.Address,
        //////                                        c.PackServices,
        //////                                        c.ZoneId,
        //////                                        c.ConnectionTypeId,
        //////                                        c.PurposeTypeId,
        //////                                        c.TicketNo,
        //////                                        c.NationalId,
        //////                                        c.IsInProcess,
        //////                                        c.IsProcessComplete,
        //////                                        c.IsSkipApproval,
        //////                                        TeamId=(sit==null?0:sit.TeamId),
        //////                                        sit.TeamName
        //////                                    }
        //////                            ).Distinct().ToListAsync();
        //////    }
        //////    catch (Exception ex)
        //////    {
        //////        Logs.WriteBug(ex);
        //////    }
        //////    return result = new
        //////    {
        //////        listLeadConnection
        //////    };
        //////}
        ////public async Task<object> getallLeadConnection(vmCmnParameters param)
        ////{
        ////    object result = null, listLeadConnection = null; _ctx = new dbRGLERPContext();
        ////    try
        ////    {
        ////        listLeadConnection = await (from c in _ctx.SalIspLead
        ////                                    join lpc in _ctx.SalIspLeadProbableConnection on (int)c.LeadId equals (int)lpc.LeadId
        ////                                    join opt in _ctx.SalIspOpportunity on (int)c.LeadId equals opt.LeadId
        ////                                    join opc in _ctx.SalIspOpptProbableConnection on new { OpportunityId = (int)opt.OpportunityId, lpc.ConnectionNo } equals new { OpportunityId = (int)opc.OpportunityId, opc.ConnectionNo }
        ////                                    where c.LeadId == param.LeadId

        ////                                    select new
        ////                                    {
        ////                                        lpc.LeadConnectionId,
        ////                                        lpc.ConnectionNo,
        ////                                        lpc.LeadId,
        ////                                        lpc.LeadUserTypeId,
        ////                                        lpc.LeadName,
        ////                                        lpc.ResponsiblePersonName,
        ////                                        lpc.ContactId,
        ////                                        lpc.AccountId,
        ////                                        IspUserId = Convert.ToInt32(lpc.IspUserId),
        ////                                        lpc.Email,
        ////                                        lpc.PhoneNumber,
        ////                                        lpc.PhoneExtra,
        ////                                        lpc.Address,
        ////                                        lpc.PackServices,
        ////                                        lpc.ZoneId,
        ////                                        lpc.ConnectionTypeId,
        ////                                        lpc.PurposeTypeId,
        ////                                        lpc.TicketNo,
        ////                                        lpc.NationalId,
        ////                                        lpc.IsInProcess,
        ////                                        lpc.IsProcessComplete,
        ////                                        lpc.IsSkipApproval,
        ////                                        listSaleIspTeam = GetTeamForMarketing(param),
        ////                                        listSaleIspTeamDetails = GetAllTeamDeatil(param),
        ////                                        forwardTeamId = 0,
        ////                                        forwardUserId = 0,
        ////                                        forwardUserList = new ArrayList(),
        ////                                        teamName = GetIspCurrentTeam(opc.OpportunityConnectionId)
        ////                                    }
        ////                            ).Distinct().ToListAsync();
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listLeadConnection
        ////    };
        ////}
        ////public SalIspTeam GetIspTeam(int? id)
        ////{
        ////    SalIspTeam team = null; _ctx = new dbRGLERPContext();
        ////    try
        ////    {
        ////        team = _ctx.SalIspTeam.Where(x => x.IsActive == true && x.TeamId == id).FirstOrDefault();
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }

        ////    return team;
        ////}
        ////public string GetIspCurrentTeam(int? OptConnectionId)
        ////{
        ////    string teamName = string.Empty;
        ////    try
        ////    {
        ////        var teamDetail = (from ilf in _ctx.SalIspLeadFlow
        ////                          join sitd in _ctx.SalIspTeamDetail on ilf.TeamId equals sitd.TeamId
        ////                          join t in _ctx.SalIspTeam on ilf.TeamId equals t.TeamId
        ////                          join u in _ctx.CmnUser on ilf.UserId equals u.UserId
        ////                          into ut
        ////                          from u in ut.DefaultIfEmpty()
        ////                          where ilf.OptConnectionId == OptConnectionId && ilf.IsCurrent == true
        ////                          select new vmSalesIspTeamDetail
        ////                          {
        ////                              UserId = (int)ilf.UserId,
        ////                              FullName = u.FrstName + " " + u.MiddleName + " " + u.LastName,
        ////                              TeamId = (int)ilf.TeamId,
        ////                              TeamName = t.TeamName
        ////                          }
        ////             ).FirstOrDefault();
        ////        if (teamDetail != null)
        ////        {
        ////            if (!string.IsNullOrEmpty(teamDetail.TeamName) && !string.IsNullOrEmpty(teamDetail.FullName))
        ////            {
        ////                teamName = teamDetail.TeamName + '(' + teamDetail.FullName + ')';
        ////            }
        ////            else if (!string.IsNullOrEmpty(teamDetail.TeamName))
        ////            {
        ////                teamName = teamDetail.TeamName;
        ////            }
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }

        ////    return teamName;
        ////}
        ////public List<SalIspTeam> GetTeamForMarketing(vmCmnParameters param)
        ////{
        ////    List<SalIspTeam> teamList = null; _ctx = new dbRGLERPContext();
        ////    try
        ////    {
        ////        teamList = _ctx.SalIspTeam.Where(x => x.IsActive == true && (x.TeamCode == "Survey" || x.TeamCode == "Management")).ToList();
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }

        ////    return teamList;
        ////}
        ////public List<SalIspTeam> GetAllTeam(vmCmnParameters param)
        ////{
        ////    List<SalIspTeam> teamList = null; _ctx = new dbRGLERPContext();
        ////    try
        ////    {
        ////        teamList = _ctx.SalIspTeam.Where(x => x.IsActive == true).ToList();
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }

        ////    return teamList;
        ////}
        ////public List<vmSalesIspTeamDetail> GetAllTeamDeatil(vmCmnParameters param)
        ////{
        ////    List<vmSalesIspTeamDetail> teamDetailList = null; _ctx = new dbRGLERPContext();
        ////    try
        ////    {

        ////        teamDetailList = (from itd in _ctx.SalIspTeamDetail
        ////                          join u in _ctx.CmnUser on itd.UserId equals u.UserId
        ////                          join t in _ctx.SalIspTeam on itd.TeamId equals t.TeamId
        ////                          select new vmSalesIspTeamDetail
        ////                          {
        ////                              UserId = itd.UserId,
        ////                              FullName = (string.IsNullOrEmpty(u.FrstName) ? string.Empty : u.FrstName) + " " + (string.IsNullOrEmpty(u.MiddleName) ? string.Empty : u.MiddleName) + " " + (string.IsNullOrEmpty(u.LastName) ? string.Empty : u.LastName),
        ////                              TeamId = itd.TeamId,
        ////                              TeamName = t.TeamName,
        ////                              TeamDetailId = itd.TeamDetailId
        ////                          }
        ////               ).ToList();
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }

        ////    return teamDetailList;
        ////}
        ////public async Task<object> GetAllProcessDepartment()
        ////{
        ////    object result = null, departments = null; _ctx = new dbRGLERPContext();
        ////    try
        ////    {
        ////        departments = await (from s in _ctx.SalIspTeamType
        ////                             select new
        ////                             {
        ////                                 departmentId = s.TypeId,
        ////                                 departmentName = s.TypeName
        ////                             }
        ////                            ).ToListAsync();
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        departments
        ////    };
        ////}
        ////#endregion

        //#region common
        //public async Task<object> GetAllMonths()
        //{
        //    object result = null; _ctx = new dbRGLERPContext();

        //    //var months = await AsyncEnumerable.Range(1, 12).Select(i => new { I = i, M = DateTimeFormatInfo.CurrentInfo.GetMonthName(i) }).ToList();
        //    var months = await (from m in _ctx.LookupMonth
        //                        select new
        //                        {
        //                            m.MonthId,
        //                            m.MonthName
        //                        }
        //                        ).ToListAsync();

        //    return result = new
        //    {
        //        months
        //    };
        //}

        ///// <summary>
        ///// This method returns data from database as a list of LookupDistrict object using asynchronous operation by an int parameter.
        ///// </summary>
        ///// <returns></returns>
        //public async Task<object> GetAllDistricts()
        //{
        //    object listDistrict = null;//List<LookupDistrict> listDistrict = null;
        //    object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            //listDistrict = await _ctx.LookupDistrict.OrderBy(a => a.DistrictName).ToListAsync();
        //            listDistrict = await _ctx.LookupDistrict.OrderBy(a => a.DistrictName).Select(s => new { s.DistrictId, s.DistrictName }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listDistrict
        //    };
        //}

        ///// <summary>
        ///// This method returns data from database as a list of LookupDivision object using asynchronous operation by an int parameter.
        ///// </summary>
        ///// <returns></returns>
        //public async Task<object> GetAllDivisions()
        //{
        //    List<LookupDivision> listDivision = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            //listDivision = await _ctx.LookupDivision.ToListAsync();
        //            listDivision = await _ctx.LookupDivision.OrderBy(a => a.DivisionName).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listDivision
        //    };
        //}

        ///// <summary>
        ///// This method returns data from database as a list of lookupCountry object using asynchronous operation by an int parameter.
        ///// </summary>
        ///// <returns></returns>
        //public async Task<object> GetAllCountries()
        //{
        //    object listCountry = null; //List<LookupCountry> listCountry = null; 
        //    object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCountry = await _ctx.LookupCountry.Where(x => x.IsActive == true && x.IsVisible == true).OrderBy(a => a.CountryName).Select(s => new { s.CountryId, s.CountryName }).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listCountry
        //    };
        //}

        //public async Task<object> GetDateBD()
        //{
        //    object result = null; string dateBD = string.Empty;
        //    try
        //    {
        //        //var BDStandardTime = Extension.UtcToLocal(StaticInfos.TimeZoneBD);
        //        var BDStandardTime = Extension.UtcToBD(Extension.UtcToday);
        //        dateBD = BDStandardTime.ToString("yyyy-MM-dd");
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    await Task.Yield();
        //    return result = new
        //    {
        //        dateBD
        //    };
        //}

        //public async Task<object> GetDateTimeBD()
        //{
        //    object result = null; string dateTimeBD = string.Empty;
        //    try
        //    {
        //        //var BDStandardTime = Extension.UtcToLocal(StaticInfos.TimeZoneBD);
        //        var BDStandardTime = Extension.UtcToBD(Extension.UtcToday);
        //        dateTimeBD = BDStandardTime.ToString("yyyy-MM-dd HH:mm:ss");
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    await Task.Yield();
        //    return result = new
        //    {
        //        dateTimeBD
        //    };
        //}

        //public async Task<object> GetAllWorkflowProcessType()
        //{
        //    object result = null, ProcessType = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        ProcessType = await (from p in _ctx.CmnProcessType
        //                             select new
        //                             {
        //                                 p.ProcessTypeId,
        //                                 p.ProcessType
        //                             }
        //                            ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        ProcessType
        //    };
        //}
        #endregion

        //#region biz isp
        //public async Task<object> GetAllIspFiberNetworkCableType()
        //{
        //    List<BizIspFiberNetworkCableType> listCableType = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listCableType = await _ctx.BizIspFiberNetworkCableType
        //                .OrderBy(a => a.CableTypeName)
        //                .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listCableType
        //    };
        //}

        //public async Task<object> GetAllIspFiberNetworkColor()
        //{
        //    List<BizIspFiberNetworkColor> listColor = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listColor = await _ctx.BizIspFiberNetworkColor
        //                .OrderBy(a => a.ColorName)
        //                .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listColor
        //    };
        //}

        //public async Task<object> GetAllIspFiberNetworkOlt()
        //{
        //    List<BizIspFiberNetworkOlt> listOlt = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listOlt = await _ctx.BizIspFiberNetworkOlt
        //                .OrderBy(a => a.OltName)
        //                .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listOlt
        //    };
        //}

        //public async Task<object> GetAllIspFiberNetworkPon()
        //{
        //    List<BizIspFiberNetworkPon> listPon = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listPon = await _ctx.BizIspFiberNetworkPon
        //                .OrderBy(a => a.PonName)
        //                .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listPon
        //    };
        //}

        //public async Task<object> GetAllIspFiberNetworkPort()
        //{
        //    List<BizIspFiberNetworkPort> listPort = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listPort = await _ctx.BizIspFiberNetworkPort
        //                .OrderBy(a => a.PortName)
        //                .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listPort
        //    };
        //}

        //public async Task<object> GetAllIspFiberNetworkSlot()
        //{
        //    List<BizIspFiberNetworkSlot> listSlot = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listSlot = await _ctx.BizIspFiberNetworkSlot
        //                .OrderBy(a => a.SlotName)
        //                .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listSlot
        //    };
        //}

        //public async Task<object> GetAllIspFiberNetworkTray()
        //{
        //    List<BizIspFiberNetworkTray> listTray = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listTray = await _ctx.BizIspFiberNetworkTray
        //                .OrderBy(a => a.TrayName)
        //                .ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listTray
        //    };
        //}

        //public async Task<object> GetAllIspFiberNetworkDropDown()
        //{
        //    object result = null;
        //    var listCableType = new List<BizIspFiberNetworkCableType>();
        //    var listColor = new List<BizIspFiberNetworkColor>();
        //    var listOlt = new List<BizIspFiberNetworkOlt>();
        //    var listPon = new List<BizIspFiberNetworkPon>();
        //    var listPort = new List<BizIspFiberNetworkPort>();
        //    var listSlot = new List<BizIspFiberNetworkSlot>();
        //    var listTray = new List<BizIspFiberNetworkTray>();
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            using (var _ctxTransaction = _ctx.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
        //            {
        //                listCableType = await _ctx.BizIspFiberNetworkCableType
        //                .OrderBy(a => a.CableTypeId)
        //                .ToListAsync();

        //                listColor = await _ctx.BizIspFiberNetworkColor
        //                .OrderBy(a => a.ColorName)
        //                .ToListAsync();

        //                listOlt = await _ctx.BizIspFiberNetworkOlt
        //                .OrderBy(a => a.OltId)
        //                .ToListAsync();

        //                listPon = await _ctx.BizIspFiberNetworkPon
        //                .OrderBy(a => a.PonNo)
        //                .ToListAsync();

        //                listPort = await _ctx.BizIspFiberNetworkPort
        //                .OrderBy(a => a.PortNo)
        //                .ToListAsync();

        //                listSlot = await _ctx.BizIspFiberNetworkSlot
        //                .OrderBy(a => a.SlotNo)
        //                .ToListAsync();

        //                listTray = await _ctx.BizIspFiberNetworkTray
        //                .OrderBy(a => a.TrayNo)
        //                .ToListAsync();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listCableType,
        //        listColor,
        //        listOlt,
        //        listPon,
        //        listPort,
        //        listSlot,
        //        listTray
        //    };
        //}

        //public async Task<object> GetAllConnectionType()
        //{
        //    object result = null, connections = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        connections = await (from c in _ctx.BizIspConnectionType
        //                             select new
        //                             {
        //                                 c.ConnectionTypeId,
        //                                 c.ConnectionName
        //                             }
        //                            ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        connections
        //    };
        //}

        //public async Task<object> GetAllPurposeType()
        //{
        //    object result = null, purposes = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        purposes = await (from c in _ctx.BizIspConnectionPurpose
        //                          select new
        //                          {
        //                              c.PurposeTypeId,
        //                              c.PurposeTypeName
        //                          }
        //                            ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        purposes
        //    };
        //}

        //public async Task<object> GetAllISPTeam(vmCmnParameters param)
        //{
        //    object result = null, team = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        team = await (from t in _ctx.SalIspTeam
        //                      where t.TeamType == param.DepartmentID
        //                      select new
        //                      {
        //                          t.TeamId,
        //                          t.TeamName,
        //                          UserId = t.CmnUserId
        //                      }
        //                            ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        team
        //    };
        //}

        //public async Task<object> GetTeamMembers(vmCmnParameters param)
        //{
        //    object result = null, teamMember = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        teamMember = await (from t in _ctx.SalIspTeamDetail
        //                            join u in _ctx.CmnUser on t.UserId equals u.UserId
        //                            where t.TeamId == param.id
        //                            select new
        //                            {
        //                                teamId = t.TeamId,
        //                                memberId = t.UserId,
        //                                fullName = (u.FrstName.Trim() + " " + u.MiddleName.Trim() + " " + u.LastName.Trim()).Trim(),
        //                                opportunityId = t.OpportunityId,
        //                                opportunityName = ""
        //                            }
        //                      ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        teamMember
        //    };
        //}

        //public async Task<object> GetOpportunities(vmCmnParameters param)
        //{
        //    object result = null, opportunity = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        opportunity = await (from t in _ctx.SalIspOpportunity
        //                             where t.IsProcessOn == null || t.IsProcessOn == false
        //                             select new
        //                             {
        //                                 t.OpportunityId,
        //                                 t.OpportunityName
        //                             }
        //                      ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        opportunity
        //    };
        //}

        //public async Task<object> GetIspServices(vmCmnParameters param)
        //{
        //    object result = null, ispservices = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        ispservices = await (from t in _ctx.BizIspService
        //                                 //join ius in _ctx.BizIspUserService on t.IspServiceId equals ius.IspServiceId into ps
        //                                 //from ius in ps.DefaultIfEmpty()
        //                             where t.IsActive == StaticInfos.IsActive
        //                             select new
        //                             {
        //                                 t.IspServiceId,
        //                                 t.ServiceName,
        //                                 t.ServicePrice
        //                             }
        //                      ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        ispservices
        //    };
        //}

        //public async Task<object> GetBizIspParentServices(vmCmnParameters param)
        //{
        //    object result = null, listIspParentPackService = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        listIspParentPackService = await (from ps in _ctx.BizIspPackService
        //                                          where ps.Srvid == ps.ParentSrvid
        //                                          select new
        //                                          {
        //                                              ps.ParentSrvid,
        //                                              ps.ParentSrvname
        //                                          })
        //                      .OrderBy(a => a.ParentSrvname)
        //                      .ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listIspParentPackService
        //    };
        //}

        //public async Task<object> GetIspUserType()
        //{
        //    object result = null, userTypeList = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        userTypeList = await (from t in _ctx.CmnUserTypeIsp
        //                              where t.IsActive == StaticInfos.IsActive
        //                              select new
        //                              {
        //                                  t.UserTypeId,
        //                                  t.UserTypeName,
        //                                  isChecked = false
        //                              }
        //                      ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        userTypeList
        //    };
        //}

        //public async Task<object> GetIspPackServiceType()
        //{
        //    object result = null, listPackServiceType = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        listPackServiceType = await (from t in _ctx.BizIspPackServiceType
        //                                     where t.IsActive == StaticInfos.IsActive
        //                                     select new
        //                                     {
        //                                         t.PackServiceTypeId,
        //                                         t.PackServiceType,
        //                                         isChecked = t.PackServiceTypeId == (int)StaticInfos.ISPPackServices.Radius ? true : false
        //                                     }
        //                      ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listPackServiceType
        //    };
        //}

        //public async Task<object> GetUserListOptionFilter()
        //{
        //    object result = null, listOptionFilter = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listOptionFilter = await (from t in _ctx.BizIspCmnUserOptionFilter
        //                                      where t.IsActive == StaticInfos.IsActive
        //                                      select new
        //                                      {
        //                                          t.FilterAutoId,
        //                                          t.FilterId,
        //                                          t.FilterName,
        //                                          t.IsChecked,
        //                                          t.CreatedBy
        //                                      }
        //                          //).OrderBy(x => x.FilterAutoId).ToListAsync();
        //                          ).OrderBy(x => x.FilterName).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listOptionFilter
        //    };
        //}

        //public async Task<object> GetAllIspFiberNetworkPopName()
        //{
        //    object listFiberNetworkPopName = null; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listFiberNetworkPopName = await (from pn in _ctx.BizIspFiberNetwork
        //                                             select new
        //                                             {
        //                                                 PopName = string.IsNullOrEmpty(pn.PopName) ? "Blank" : pn.PopName
        //                                             }
        //                                             ).Distinct().ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listFiberNetworkPopName
        //    };
        //}

        ////public async Task<object> GetAllIspFiberNetworkPonNo(string PopName)
        ////{
        ////    object listFiberNetworkPonNo = null; object result = null;
        ////    try
        ////    {
        ////        using (_ctx = new dbRGLERPContext())
        ////        {
        ////            listFiberNetworkPonNo = await (from pn in _ctx.BizIspFiberNetwork
        ////                                           where pn.PopName == PopName
        ////                                           select new
        ////                                               {
        ////                                                   PonNo = string.IsNullOrEmpty(pn.PonNo) ? "0" : pn.PonNo
        ////                                               }
        ////                                           ).Distinct().ToListAsync();
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        //Logs.WriteBug(ex);
        ////    }
        ////    return result = new
        ////    {
        ////        listFiberNetworkPonNo
        ////    };
        ////}

        //public async Task<object> GetAllIspFiberNetworkPonNo(vmCmnParameters cmnParam)
        //{
        //    object result = null; object listFiberNetworkPonNo = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listFiberNetworkPonNo = await (from pn in _ctx.BizIspFiberNetwork
        //                                           where pn.PopName == cmnParam.Name
        //                                           select new {
        //                                               PonNo = string.IsNullOrEmpty(pn.PonNo) ? "0" : pn.PonNo
        //                                           }).Distinct().ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listFiberNetworkPonNo
        //    };
        //}

        //public async Task<object> GetAllIspFiberNetworkDsNo(vmCmnParameters cmnParam)
        //{
        //    object result = null; object listFiberNetworkDsNo = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listFiberNetworkDsNo = await (from pn in _ctx.BizIspFiberNetwork
        //                                           where pn.PonNo == cmnParam.values && pn.PopName==cmnParam.Name
        //                                          select new
        //                                           {
        //                                               DsNo = string.IsNullOrEmpty(pn.DsNo) ? "0" : pn.DsNo
        //                                           }).Distinct().ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listFiberNetworkDsNo
        //    };
        //}
        //#endregion

        //public async Task<object> GetIspPaymentMethod()
        //{
        //    object result = null, listPaymentMethod = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        listPaymentMethod = await (from t in _ctx.LookupPaymentMethod
        //                                   where t.IsActive == StaticInfos.IsActive
        //                                   select new
        //                                   {
        //                                       t.MethodId,
        //                                       t.MethodName
        //                                   }
        //                      ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listPaymentMethod
        //    };
        //}
        //#region Sales and Marketing
        //public async Task<object> GetAllSalesMemories(vmCmnParameters cmnParameters)
        //{
        //    object result = null, listOfMemories = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listOfMemories = await (from bc in _ctx.BizCloudUserVminstance
        //                                    select new
        //                                    {
        //                                        bc.UserVminstanceId,
        //                                        bc.Cpu,
        //                                        bc.MemorySize
        //                                    }).GroupBy(g => new { g.Cpu, g.MemorySize }).Select(x => x.FirstOrDefault()).ToListAsync();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listOfMemories
        //    };
        //}

        //public async Task<object> GetAllOs(vmCmnParameters cmnParameters)
        //{
        //    object result = null, listOs = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listOs = await (from bc in _ctx.BizCloudOs
        //                            select new
        //                            {
        //                                bc.CloudOsid,
        //                                bc.ParentServiceId,
        //                                bc.AppId,
        //                                bc.IsOs,
        //                                bc.AppName,
        //                                bc.Version
        //                            }).OrderBy(x => x.AppName).ToListAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listOs
        //    };
        //}
        //public async Task<object> GetAllCloudStorage(vmCmnParameters cmnParameters)
        //{
        //    object result = null, listOfMemories = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listOfMemories = await (from bc in _ctx.BizCloudStorage
        //                                    select new
        //                                    {
        //                                        bc.CloudStorageId,
        //                                        bc.StorageId,
        //                                        bc.StorageName,
        //                                        bc.StorageType,
        //                                        bc.RegionId,
        //                                        bc.MinVolumeSize,
        //                                        bc.MaxVolumeSize
        //                                    }).ToListAsync();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listOfMemories
        //    };
        //}
        //public async Task<object> GetAllDiskVolume(vmCmnParameters cmnParameters)
        //{
        //    object result = null, cloudadditionalvolume = null, cloudrootdisk = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            cloudadditionalvolume = await (from bc in _ctx.BizCloudAdditionalVolume select new { bc.CloudAdditionalVolumeId, bc.RegionId, bc.StorageSize }).ToListAsync();
        //            cloudrootdisk = await (from bc in _ctx.BizCloudRootDisk select new { bc.CloudRootDiskId, bc.RegionId, bc.StorageSize }).ToListAsync();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        cloudadditionalvolume,
        //        cloudrootdisk
        //    };
        //}
        //public async Task<object> GetAllPolicies(vmCmnParameters cmnParameters)
        //{
        //    object result = null, listOfPolicies = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listOfPolicies = await (from cpt in _ctx.BizCloudPolicyType
        //                                    join cp in _ctx.BizCloudPolicy on cpt.PolicyTypeId equals cp.PolicyTypeId
        //                                    select new
        //                                    {
        //                                        cpt.PolicyType,
        //                                        cp.PolicyTypeId,
        //                                        cp.PolicyId,
        //                                        cp.PolicyName,
        //                                        cp.CloudPolicyId
        //                                    }).ToListAsync();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listOfPolicies
        //    };
        //}
        //public async Task<object> GetCloudAdditionService(vmCmnParameters cmnParameters)
        //{
        //    object result = null, listOfAdditionalServices = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listOfAdditionalServices = await (from lcds in _ctx.LookupCloudDeployService
        //                                              join cp in _ctx.LookupCloudDeployService on lcds.UnderService equals cp.ServiceId
        //                                              into ut
        //                                              from PP in ut.DefaultIfEmpty()
        //                                              where lcds.UnderService != null
        //                                              select new
        //                                              {
        //                                                  ServiceId= lcds.ServiceId,
        //                                                  ServiceName=lcds.ServiceName,
        //                                                  ParentType=lcds.ParentType,
        //                                                  UnderService=lcds.UnderService,
        //                                                  ParentServiceName=PP.ServiceName,
        //                                                  ServiceUnit=0
        //                                              }).ToListAsync();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listOfAdditionalServices
        //    };
        //}
        //public async Task<object> GetCloudUserType()
        //{
        //    object result = null, userTypeList = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        userTypeList = await (from t in _ctx.CmnUserTypeCloud
        //                              where t.IsActive == StaticInfos.IsActive
        //                              select new
        //                              {
        //                                  t.TypeId,
        //                                  t.TypeName,
        //                                  isChecked = false
        //                              }
        //                      ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        userTypeList
        //    };
        //}
        //public async Task<object> GetCloudMarketingUser()
        //{
        //    object result = null, listUser = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        listUser = await (from cu in _ctx.CmnUser
        //                             join r in _ctx.CmnUserRole on Convert.ToInt32(cu.UserRoleId) equals r.RoleId
        //                             where r.RoleCode== "Marketing(Cloud)"
        //                             select new
        //                             {
        //                                 cu.UserId,
        //                                 cu.FrstName,
        //                                 cu.MiddleName,
        //                                 cu.LastName,
        //                                 r.RoleName,
        //                                 r.RoleCode
        //                                 ,
        //                                 fullName = (((string.IsNullOrEmpty(cu.FrstName) ? string.Empty : cu.FrstName.Trim()) + " " + (string.IsNullOrEmpty(cu.MiddleName) ? string.Empty : cu.MiddleName.Trim())).Trim() + " " + (string.IsNullOrEmpty(cu.LastName) ? string.Empty : cu.LastName.Trim())).Trim()
        //                             }
        //                                  ).OrderBy(a => a.fullName)
        //                                  .ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listUser
        //    };
        //}
        //public async Task<object> GetCloudLeadType()
        //{
        //    object result = null, leadTypeList = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        leadTypeList = await (from t in _ctx.SalCloudLeadStutus
        //                              where t.IsActive == StaticInfos.IsActive
        //                              select new
        //                              {
        //                                  t.SalCloudLeadStutusId,
        //                                  t.SalCloudLeadStutusName
        //                              }
        //                      ).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        leadTypeList
        //    };
        //}
        //#endregion

        //#region HRM
        //public async Task<object> GetAllShiftType()
        //{
        //    object result = null, shifttype = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        shifttype = await (from s in _ctx.HrmTblCatShift
        //                           select new
        //                           {
        //                               s.ShiftType,
        //                               ShiftDesc = s.ShiftType.ToLower() == "gr" ? "Ramadan" : s.ShiftType.ToLower() == "s" ? "Shifting" : "General"
        //                           }).Distinct().ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        shifttype
        //    };
        //}

        //public async Task<object> GetAllShiftCategory(string type)
        //{
        //    object result = null, shiftcat = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        shiftcat = await (from s in _ctx.HrmTblCatShift
        //                          where s.ShiftType == type
        //                          select new
        //                          {

        //                              ShiftId = _ctx.HrmTblCatShift.Where(x => x.ShiftType == s.ShiftType && x.ShiftCat == s.ShiftCat).OrderBy(x => x.ShiftId).FirstOrDefault().ShiftId,
        //                              s.ShiftCat,
        //                              ShiftDesc = s.ShiftCat.ToLower() == "gr" ? "Ramadan" : s.ShiftCat.ToLower() == "a" ? "Shifting" : s.ShiftCat.ToLower() == "b" ? "Staff Shifting" : "General"
        //                          }).Distinct().ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        shiftcat
        //    };
        //}

        //public async Task<object> GetAllWeekDays()
        //{
        //    object result = null, weekends = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        /*
        //                        weekends = await (from w in _ctx.HrmTblDays
        //                        select new
        //                        {
        //                            w.WeekDayId,
        //                            w.WeekDayName,
        //                            isChecked = false
        //                        }).ToListAsync();
        //                        */
        //        weekends = await (from w in _ctx.HrmWeekDay
        //                          select new
        //                          {
        //                              w.WeekDayId,
        //                              w.WeekDayName,
        //                              isChecked = false
        //                          }).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        weekends
        //    };
        //}

        //public async Task<object> GetAllShift()
        //{
        //    object result = null, listShift = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        listShift = await (from s in _ctx.HrmTblCatShift
        //                           select new
        //                           {
        //                               s.ShiftId,
        //                               s.ShiftName
        //                           }).OrderBy(d => d.ShiftName).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listShift
        //    };
        //}

        //public async Task<object> GetAllLineManager()
        //{
        //    object result = null, listLineManager = null; _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        listLineManager = await
        //            (from e in _ctx.HrmEmployee
        //             join d in (from v in _ctx.HrmVariable where v.VarType == "Designation" select new { v.VarId, v.VarName }) on e.Designation equals d.VarId
        //             where e.IsLineManager == true
        //             select
        //             new
        //             {
        //                 e.EmployeeId,
        //                 e.FullName,
        //                 designationName = d.VarName
        //             }
        //             ).OrderBy(a => a.FullName)
        //             .ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listLineManager
        //    };
        //}

        //public async Task<object> GetEmployeeForLeave(vmCmnParameters model)
        //{
        //    object result = null; string listEmployee = string.Empty;
        //    try
        //    {
        //        Generic_vmCmnParameters = new GenericFactory<vmCmnParameters>();
        //        ht = new Hashtable
        //        {
        //            { "LoggedUserID", StaticInfos.LoggedUserID },
        //            { "RoleID", model.RoleID },
        //            { "isLineManager", model.IsTrue },
        //            { "LineManagerId", model.EmployeeID }
        //        };

        //        listEmployee = await Generic_vmCmnParameters.ExecuteCommandString(StoredProcedure.SpGet_EmployeeForLeave, ht, StaticInfos.conString.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listEmployee
        //    };
        //}

        //public async Task<object> GetBillCollector()
        //{
        //    object result = null; string listBillCollector = string.Empty;
        //    try
        //    {
        //        Generic_vmCmnParameters = new GenericFactory<vmCmnParameters>();
        //        ht = new Hashtable
        //        {
        //            { "LoggedUserID", StaticInfos.LoggedUserID }
        //        };

        //        listBillCollector = await Generic_vmCmnParameters.ExecuteCommandString(StoredProcedure.SpGet_BillCollector, ht, StaticInfos.conString.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listBillCollector
        //    };
        //}
        //#endregion
    }
}
