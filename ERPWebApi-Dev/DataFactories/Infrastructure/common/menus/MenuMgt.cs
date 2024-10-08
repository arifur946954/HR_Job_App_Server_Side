//using DataModels.EntityModels.ERPModel;
using DataModel.ViewModels;
using DataUtility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFactories.BaseFactory;
using System.Collections;
using System.Data.SqlClient;
//using DataModels.ViewModels.ERPViewModel.NOC;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using DataModel.EntityModels.OraModel;
using DataModel.ViewModels.ERPViewModel.Common;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using Newtonsoft.Json;

namespace DataFactories.Infrastructure.common.menus
{
    public class MenuMgt
    {
        #region Variable declaration & initialization
        //dbRGLERPContext _ctx = null;
        ModelContext _ctxOra = null;
        Hashtable ht = null; OracleParameter[] oprm = null;
        private IGenericFactory<vmRoleMenu> Generic_vmRoleMenu = null;
        private IGenericFactoryOracle<vmRoleMenu> OraGeneric_vmRoleMenu = null;
        #endregion

        #region All Methods

        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> GetOraRoleWiseMenu(vmCmnParameter param)
        {
            OraGeneric_vmRoleMenu = new GenericFactoryOracle<vmRoleMenu>();
            string listRoleMenu = string.Empty;
            object result = null; int recordsTotal = 0;
            try
            {
                ht = new Hashtable
                {
                    { "rresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "p_RoleId", (1, param.id) },
                    { "PageNumber", (2, Convert.ToDecimal(param.pageNumber))},
                    { "PageSize", (3, Convert.ToDecimal(param.pageSize)) }
                };

                listRoleMenu = await OraGeneric_vmRoleMenu.ExecuteCommandString(StoredProcedure.Ora_SpGet_Menu_By_RoleID, ht, StaticInfos.conStringOracle.ToString());

                //oprm = new OracleParameter[] {
                //    new OracleParameter{ ParameterName="rresult", OracleDbType=OracleDbType.RefCursor, Direction=ParameterDirection.Output },
                //    new OracleParameter{ ParameterName="p_RoleId", OracleDbType=OracleDbType.NVarchar2, Value=param.RoleIDs },
                //    new OracleParameter{ ParameterName="PageNumber", OracleDbType=OracleDbType.Decimal, Value=Convert.ToDecimal(param.pageNumber) },
                //    new OracleParameter{ ParameterName="PageSize", OracleDbType=OracleDbType.Decimal, Value=Convert.ToDecimal(param.pageSize) },
                //};

                //listRoleMenu = await OraGeneric_vmRoleMenu.ExecuteCommandString(StoredProcedure.SpGet_OraRoleWiseMenu, oprm, StaticInfos.conStringOracle.ToString());                
            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }
            return result = new
            {
                listRoleMenu,
                recordsTotal
            };
        }

        /// <summary>
        /// This method returns an object from database using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> GetMenu(vmCmnParameter param)
        {
            OraGeneric_vmRoleMenu = new GenericFactoryOracle<vmRoleMenu>();
            string menues = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "sresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "s_UserId", (1, param.UserID) },
                    { "s_RoleId", (2, param.id) }
                };

                menues = await OraGeneric_vmRoleMenu.ExecuteCommandString(StoredProcedure.Ora_SpGET_CmnMenu, ht, StaticInfos.conStringOracle.ToString());

                //ht = new Hashtable
                //{
                //    { "UserID", cmnParam.UserID },
                //    { "RoleID", cmnParam.id },
                //    { "ModuleID", cmnParam.ModuleID},
                //    { "CompanyID", cmnParam.CompanyID }
                //};

                //menues = await Generic_vmRoleMenu.ExecuteCommandString(StoredProcedure.SpGet_Menu, ht, StaticInfos.conString.ToString());
            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }
            return result = new
            {
                menues
            };
        }

        public async Task<object> GetSideMenu(vmCmnParameter param)
        {
            OraGeneric_vmRoleMenu = new GenericFactoryOracle<vmRoleMenu>();
            string mainMenues = string.Empty, childMenues = string.Empty, subChildMenues = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "sresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "s_UserId", (1, param.UserID) },
                    { "s_RoleId", (2, param.id) }
                };

                mainMenues = await OraGeneric_vmRoleMenu.ExecuteCommandString(StoredProcedure.Ora_SpGET_MainMenu, ht, StaticInfos.conStringOracle.ToString());
                childMenues = await OraGeneric_vmRoleMenu.ExecuteCommandString(StoredProcedure.Ora_SpGET_ChildMenu, ht, StaticInfos.conStringOracle.ToString());
                subChildMenues = await OraGeneric_vmRoleMenu.ExecuteCommandString(StoredProcedure.Ora_SpGET_SubChildMenu, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }
            return result = new
            {
                mainMenues,
                childMenues,
                subChildMenues
            };
        }

        public async Task<object> GetMenuByParam(vmCmnParameter param)
        {
            object result = null, userMenu = null;
            try
            {
                using (_ctxOra = new ModelContext())
                {
                    if (param.id == 1)//Role ID
                    {
                        userMenu = await (from tcm in _ctxOra.TCmnmenus
                                          where tcm.Menupath == param.values
                                          select new
                                          {
                                              menuId = tcm.Menuid,
                                              menuName = tcm.Menuname,
                                              menuPath = tcm.Menupath,
                                              menuIcon = tcm.Menuicon,
                                              menuSequence = tcm.Sequence,
                                              userId = param.UserID,
                                              isView = true,
                                              isInsert = true,
                                              isUpdate = true,
                                              isDelete = true,
                                              isEdit = false,
                                              isViewOnly = false,
                                              isSubParent = tcm.Issubparent
                                          }).FirstOrDefaultAsync();
                    }
                    else
                    {
                        userMenu = await (from tcm in _ctxOra.TCmnmenus
                                          join tcmp in _ctxOra.TCmnmenupermissions on tcm.Menuid equals tcmp.Menuid
                                          join ur in _ctxOra.TUserRoles on tcmp.Roleid equals ur.RoleId
                                          where tcm.Menupath == param.values && ur.RoleId == param.id && ur.UserId == param.UserID
                                          && (tcmp.Enableinsert == Extension.BoolVal(true) || tcmp.Enableinsert == Extension.BoolVal(true) ||
                                          tcmp.Enableupdate == Extension.BoolVal(true) || tcmp.Enabledelete == Extension.BoolVal(true))
                                          select new
                                          {
                                              menuId = tcm.Menuid,
                                              menuName = tcm.Menuname,
                                              menuPath = tcm.Menupath,
                                              menuIcon = tcm.Menuicon,
                                              menuSequence = tcm.Sequence,
                                              userId = ur.UserId,
                                              isView = Extension.BoolVal(tcmp.Enableview),
                                              isInsert = Extension.BoolVal(tcmp.Enableinsert),
                                              isUpdate = Extension.BoolVal(tcmp.Enableupdate),
                                              isDelete = Extension.BoolVal(tcmp.Enabledelete),
                                              isEdit = false,
                                              isViewOnly = false,
                                              isSubParent = tcm.Issubparent
                                          }).FirstOrDefaultAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }

            return result = new
            {
                userMenu
            };
        }


        public async Task<object> CheckMenuIfExist(vmCmnParameter param)
        {
            object result = null; bool canNavigate = false;
            try
            {
                using (_ctxOra = new ModelContext())
                {
                    canNavigate = param.id == StaticInfos.SeedRoleID ? true : await (from tcm in _ctxOra.TCmnmenus
                                                                                     join tcmp in _ctxOra.TCmnmenupermissions on tcm.Menuid equals tcmp.Menuid
                                                                                     join ur in _ctxOra.TUserRoles on tcmp.Roleid equals ur.RoleId
                                                                                     where tcm.Menupath == param.values && ur.RoleId == param.id && ur.UserId == param.UserID
                                                                                     && (tcmp.Enableview == Extension.BoolVal(true) || tcmp.Enableinsert == Extension.BoolVal(true) ||
                                                                                     tcmp.Enableupdate == Extension.BoolVal(true) || tcmp.Enabledelete == Extension.BoolVal(true))
                                                                                     select new { tcm.Menuid }).FirstOrDefaultAsync() != null ? true : false;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                //Logs.Bug(ex);
            }

            return result = new
            {
                canNavigate
            };
        }

        /// <summary>
        /// This method returns an object from database using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        //public async Task<object> GetMenuesByUserID(vmCmnParameters cmnParam)
        //{
        //    Generic_vmRoleMenu = new GenericFactory<vmRoleMenu>();
        //    string listMenues = string.Empty;
        //    object result = null;
        //    try
        //    {
        //        ht = new Hashtable
        //        {
        //            { "UserID", cmnParam.UserID },
        //            { "RoleID", cmnParam.RoleID },
        //            { "CompanyID", cmnParam.CompanyID }
        //        };

        //        listMenues = await Generic_vmRoleMenu.ExecuteCommandString(StoredProcedure.SpGet_AllMenu, ht, StaticInfos.conString.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listMenues
        //    };
        //}

        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        //public async Task<object> GetWithPagination(vmCmnParameters cmnParam)
        //{
        //    List<CmnMenu> listMenu = null; object result = null; int recordsTotal = 0;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            listMenu = await _ctx.CmnMenu.OrderByDescending(x => x.MenuId).Skip((int)cmnParam.pageNumber).Take((int)cmnParam.pageSize).ToListAsync();
        //            recordsTotal = await _ctx.CmnMenu.CountAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        listMenu,
        //        recordsTotal
        //    };
        //}

        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> GetParentMenu()
        {
            object result = null; object listParentMenu = null;
            try
            {
                using (_ctxOra = new ModelContext())
                {
                    listParentMenu = await (from tcm in _ctxOra.TCmnmenus
                                            where tcm.Parentid == 0 && tcm.Subparentid == 0
                                            select new
                                            {
                                                menuId = tcm.Menuid,
                                                menuName = tcm.Menuname
                                            }
                                            ).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }

            return result = new
            {
                listParentMenu
            };
        }

        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> GetSubParentMenu(vmCmnParameter cmnParam)
        {
            object result = null; object listSubParentMenu = null;
            try
            {
                using (_ctxOra = new ModelContext())
                {
                    listSubParentMenu = await (from tcm in _ctxOra.TCmnmenus
                                               where tcm.Parentid == cmnParam.id && tcm.Subparentid == 0
                                               select new
                                               {
                                                   menuId = tcm.Menuid,
                                                   menuName = tcm.Menuname
                                               }).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }

            return result = new
            {
                listSubParentMenu
            };
        }

        /// <summary>
        /// This method returns data from database as an object using asynchronous operation by an int parameter.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> GetByID(int id)
        {
            object result = null; object objMenu = null;
            try
            {
                using (_ctxOra = new ModelContext())
                {
                    //objMenu = await _ctxOra.TCmnmenu.Where(x => x.Menuid == id).FirstOrDefaultAsync();
                    objMenu = await (from tcm in _ctxOra.TCmnmenus
                                     where tcm.Menuid == id
                                     select new
                                     {
                                         menuId = tcm.Menuid,
                                         menuName = tcm.Menuname,
                                         menuPath = tcm.Menupath,
                                         parentId = tcm.Parentid,
                                         subParentId = tcm.Subparentid,
                                         menuIcon = tcm.Menuicon,
                                         menuSequence = tcm.Sequence,
                                         isSubParent = Extension.BoolVal(tcm.Issubparent),
                                         isActive = Extension.BoolVal(tcm.Isactive)
                                     }
                                     ).FirstOrDefaultAsync();
                }

                //using (_ctx = new dbRGLERPContext())
                //{
                //    objMenu = await _ctx.CmnMenu.Where(x => x.MenuId == id).FirstOrDefaultAsync();
                //}
            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }

            return result = new
            {
                objMenu
            };
        }



        /// <summary>
        /// Both insert and update can perform by CmnMenu model in database using asynchronous operation. when id is more than 0 update is performed otherwise insert. it returns an object as status of success or failure.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<object> SaveUpdate(vmMenues model, vmCmnParameter param)
        {
            object result = null; string message = string.Empty; bool resstate = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxTransactionOra = _ctxOra.Database.BeginTransaction())
                {
                    try
                    {
                        if (model.menuId > 0)
                        {
                            var menu = await _ctxOra.TCmnmenus.FirstOrDefaultAsync(x => x.Menuid == model.menuId);
                            menu.Parentid = model.parentId == null ? 0 : model.parentId;
                            menu.Subparentid = model.subParentId == null ? 0 : model.subParentId;
                            menu.Menuname = model.menuName.Trim();
                            menu.Menuicon = model.menuIcon.Trim();
                            menu.Menupath = model.menuPath.Trim();
                            menu.Sequence = model.menuSequence;
                            menu.Isactive = Extension.BoolVal(model.isActive);
                            menu.Issubparent = Extension.BoolVal(model.isSubparent);
                            //Common
                            menu.Updatepc = Extension.Createpc();
                            menu.Updateby = param.LoggedUserId;
                            menu.Updateon = DateTime.Now;

                            message = MessageConstants.Updated;
                        }
                        else
                        {
                            var MaxID = _ctxOra.TCmnmenus.DefaultIfEmpty().Max(x => x == null ? 0 : x.Menuid) + 1;
                            var menu = new TCmnmenu();
                            menu.Menuid = MaxID;
                            //menu.Moduleid = model.moduleId;
                            menu.Parentid = model.parentId == null ? 0 : model.parentId;
                            menu.Subparentid = model.subParentId == null ? 0 : model.subParentId;
                            menu.Menuname = model.menuName.Trim();
                            menu.Menuicon = model.menuIcon.Trim();
                            menu.Menupath = model.menuPath.Trim();
                            menu.Sequence = model.menuSequence;
                            menu.Isactive = Extension.BoolVal(model.isActive);
                            menu.Issubparent = Extension.BoolVal(model.isSubparent);
                            //Common
                            menu.Createpc = Extension.Createpc();
                            menu.Createby = param.LoggedUserId;
                            menu.Createon = DateTime.Now;

                            await _ctxOra.TCmnmenus.AddAsync(menu);

                            message = MessageConstants.Saved;
                        }

                        if (model.subParentId != null && model.subParentId != 0)
                        {
                            var subparent = await _ctxOra.TCmnmenus.Where(x => x.Menuid == model.subParentId).FirstOrDefaultAsync();
                            if (subparent != null)
                            {
                                subparent.Issubparent = Extension.BoolVal(true);
                            }
                        }

                        await _ctxOra.SaveChangesAsync();

                        _ctxTransactionOra.Commit();
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxTransactionOra.Rollback();
                        ////Logs.WriteBug(ex);
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

        /// <summary>
        /// Delete can perform to CmnMenu table by int parameter in database using asynchronous operation. It returns an object as status of success or failure.
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
                            var delperm = await _ctxOra.TCmnmenupermissions.Where(x => x.Menuid == param.id).ToListAsync();
                            foreach (var item in delperm)
                            {
                                item.Isdelete = Extension.BoolVal(true);
                                item.Deletepc = Extension.Createpc();
                                item.Deleteby = param.LoggedUserId;
                                item.Deleteon = Extension.Today;
                            }

                            var delmodel = await _ctxOra.TCmnmenus.Where(x => x.Menuid == param.id).FirstOrDefaultAsync();
                            delmodel.Isdelete = Extension.BoolVal(true);
                            delmodel.Deletepc = Extension.Createpc();
                            delmodel.Deleteby = param.LoggedUserId;
                            delmodel.Deleteon = Extension.Today;
                        }

                        await _ctxOra.SaveChangesAsync();
                        _ctxOraTran.Commit();
                        message = MessageConstants.Deleted;
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTran.Rollback();
                        //Logs.WriteBug(ex);
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


        public async Task<object> SaveUpdatePermission(List<vmRoleMenu> model, vmCmnParameter param)
        {
            object result = null; string message = string.Empty; bool resstate = false; List<CmnMenuPermission> cmPermision = new List<CmnMenuPermission>();
            List<vmRoleMenu> pr = new List<vmRoleMenu>();

            using (_ctxOra = new ModelContext())
            {
                using (var _ctxTransactionOra = _ctxOra.Database.BeginTransaction())
                {
                    try
                    {
                        //var smodelList = model.Where(x => x.HasChild == false && x.IsSubParent == false && x.ParentID == 0).ToList();

                        //Filter=> Filter only menu without parent and sub parent
                        model = model.Where(x => (x.ParentID > 0 && x.IsSubParent == false) || (x.HasChild == false && x.IsSubParent == false && x.ParentID == 0)).ToList();
                        //Filter

                        #region Set Put Sub-Menu/Menu
                        await SetPutMenuPermission(model, param);
                        #endregion Set Put Sub-Menu/Menu

                        #region Set Sub Parent
                        //Filter=> Filter and get only unique sub parent menu using 'GroubBy'
                        var nmodel = model.Where(x => x.SubParentID > 0).GroupBy(s => new { s.SubParentID }).Select(x => new vmRoleMenu { RoleID = x.FirstOrDefault().RoleID, SubParentID = x.FirstOrDefault().SubParentID, IsView = x.FirstOrDefault().IsView == true || x.FirstOrDefault().IsInsert == true || x.FirstOrDefault().IsUpdate == true || x.FirstOrDefault().IsDelete == true ? true : false }).ToList();
                        //Filter
                        if (nmodel.Count > 0)
                        {
                            await SetPutSubParentMenuPermission(nmodel, param);
                        }
                        #region Set Sub Parent Commented Code
                        //foreach (var nm in nmodel)
                        //{
                        //    int getval = 0; //bool IsBool = true;
                        //    var cm = _ctx.CmnMenu.Where(x => x.MenuId == nm.SubParentID).FirstOrDefault();
                        //    if (cm != null)
                        //    {
                        //        if (nm.IsView == false)
                        //        {
                        //            var mbyp = _ctx.CmnMenu.Where(x => x.SubParentId == cm.MenuId && x.IsSubParent != true).ToList();
                        //            if (mbyp.Count > 0)
                        //            {
                        //                foreach (var mb in mbyp)
                        //                {
                        //                    bool isTrue = _ctx.CmnMenuPermission.Where(x => x.UserRole == nm.RoleID && x.MenuId == mb.MenuId && (x.CanView == true || x.CanCreate == true || x.CanEdit == true || x.CanDelete == true)).FirstOrDefault() == null ? false : true;
                        //                    if (isTrue == true)
                        //                    {
                        //                        getval++;
                        //                        break;
                        //                    }
                        //                }

                        //                if (getval > 0)
                        //                {
                        //                    nm.IsView = true;
                        //                }
                        //                //else
                        //                //{
                        //                //IsBool = false;
                        //                //}
                        //            }
                        //        }

                        //        //var exm = model.Where(x => x.MenuId == cm.MenuId && (x.IsView == IsBool || x.IsInsert == IsBool || x.IsUpdate == IsBool || x.IsDelete == IsBool)).FirstOrDefault();
                        //        //if (exm == null)
                        //        //{
                        //        if (cm != null)
                        //        {
                        //            var nsubpr = new vmRoleMenu();
                        //            nsubpr.MenuId = cm.MenuId;
                        //            nsubpr.RoleID = nm.RoleID;
                        //            nsubpr.IsView = nm.IsView;
                        //            nsubpr.IsInsert = nm.IsView;
                        //            nsubpr.IsUpdate = nm.IsView;
                        //            nsubpr.IsDelete = nm.IsView;

                        //            subpr.Add(nsubpr);
                        //        }
                        //        //}
                        //    }
                        //}

                        //if (subpr.Count > 0)
                        //{
                        //    newModel = new List<vmRoleMenu>();
                        //    newModel.AddRange(subpr);
                        //    await SetPutMenuPermission(newModel, cmnParam);
                        //}
                        #endregion Set Sub Parent Commented Code
                        #endregion Set Sub Parent                        

                        #region Set Parent
                        //Filter=> Filter and get only unique parent menu using 'GroubBy'
                        var npmodel = model.Where(x => x.ParentID > 0).GroupBy(s => new { s.ParentID }).Select(x => new vmRoleMenu { RoleID = x.FirstOrDefault().RoleID, ParentID = x.FirstOrDefault().ParentID, IsView = x.FirstOrDefault().IsView == true || x.FirstOrDefault().IsInsert == true || x.FirstOrDefault().IsUpdate == true || x.FirstOrDefault().IsDelete == true ? true : false }).ToList();
                        //Filter
                        if (npmodel.Count > 0)
                        {
                            await SetPutParentMenuPermission(npmodel, param);
                        }
                        #region Set Parent Commented Code
                        //foreach (var npm in npmodel)
                        //{
                        //    int getval = 0; //bool IsBool = true;
                        //    var cpm = _ctx.CmnMenu.Where(x => x.MenuId == npm.ParentID).FirstOrDefault();
                        //    if (cpm != null)
                        //    {
                        //        if (npm.IsView == false)
                        //        {
                        //            var mbyp = _ctx.CmnMenu.Where(x => x.ParentId == cpm.MenuId).ToList();
                        //            if (mbyp.Count > 0)
                        //            {
                        //                foreach (var mb in mbyp)
                        //                {
                        //                    bool isTrue = _ctx.CmnMenuPermission.Where(x => x.UserRole == npm.RoleID && x.MenuId == mb.MenuId && (x.CanView == true || x.CanCreate == true || x.CanEdit == true || x.CanDelete == true)).FirstOrDefault() == null ? false : true;
                        //                    if (isTrue == true)
                        //                    {
                        //                        getval++;
                        //                        break;
                        //                    }
                        //                }

                        //                if (getval > 0)
                        //                {
                        //                    npm.IsView = true;
                        //                }
                        //                //else
                        //                //{
                        //                //IsBool = false;
                        //                //}
                        //            }
                        //        }

                        //        //var expm = model.Where(x => x.MenuId == cpm.MenuId && (x.IsView== IsBool || x.IsInsert == IsBool || x.IsUpdate == IsBool || x.IsDelete == IsBool)).FirstOrDefault();
                        //        //if (expm == null)
                        //        //{
                        //        if (cpm != null)
                        //        {
                        //            var npr = new vmRoleMenu();
                        //            npr.MenuId = cpm.MenuId;
                        //            npr.RoleID = npm.RoleID;
                        //            npr.IsView = npm.IsView;
                        //            npr.IsInsert = npm.IsView;
                        //            npr.IsUpdate = npm.IsView;
                        //            npr.IsDelete = npm.IsView;

                        //            pr.Add(npr);
                        //        }
                        //        //}
                        //    }
                        //}

                        //if (pr.Count > 0)
                        //{
                        //    newModel = new List<vmRoleMenu>();
                        //    newModel.AddRange(pr);
                        //    await SetPutMenuPermission(newModel, cmnParam);
                        //}
                        #endregion Set Parent Commented Code
                        #endregion Set Parent

                        _ctxTransactionOra.Commit();
                        message = MessageConstants.Saved;
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxTransactionOra.Rollback();
                        //Logs.WriteBug(ex);
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

        private async Task<int> SetPutMenuPermission(List<vmRoleMenu> model, vmCmnParameter param)
        {
            List<TCmnmenupermission> cmPermision = new List<TCmnmenupermission>();
            var exRoleMenu = await _ctxOra.TCmnmenupermissions.Where(x => x.Roleid == param.id).ToListAsync();
            var MaxID = _ctxOra.TCmnmenupermissions.DefaultIfEmpty().Max(x => x == null ? 0 : x.Menupermissionid) + 1;

            if (exRoleMenu.Count > 0)
            {
                foreach (var _RMenu in model)
                {
                    var _RM = exRoleMenu.Where(x => x.Menuid == _RMenu.MenuId).FirstOrDefault();
                    if (_RM != null)
                    {
                        _RM.Enableview = Extension.BoolVal(_RMenu.IsView);
                        _RM.Enableinsert = Extension.BoolVal(_RMenu.IsInsert);
                        _RM.Enableupdate = Extension.BoolVal(_RMenu.IsUpdate);
                        _RM.Enabledelete = Extension.BoolVal(_RMenu.IsDelete);
                        //Common
                        _RM.Updatepc = Extension.Createpc();
                        _RM.Updateby = param.LoggedUserId;
                        _RM.Updateon = Extension.Today;
                    }
                    else
                    {
                        var mPer = new TCmnmenupermission();
                        mPer.Menupermissionid = MaxID;
                        mPer.Roleid = Convert.ToDecimal(_RMenu.RoleID);
                        mPer.Menuid = _RMenu.MenuId;
                        mPer.Enableview = Extension.BoolVal(_RMenu.IsView);
                        mPer.Enableinsert = Extension.BoolVal(_RMenu.IsInsert);
                        mPer.Enableupdate = Extension.BoolVal(_RMenu.IsUpdate);
                        mPer.Enabledelete = Extension.BoolVal(_RMenu.IsDelete);

                        //Common
                        mPer.Createpc = Extension.Createpc();
                        mPer.Createby = param.LoggedUserId;
                        mPer.Createon = Extension.Today;
                        cmPermision.Add(mPer);
                        MaxID++;
                    }
                }
            }
            else
            {
                foreach (var _RMenu in model)
                {
                    var mPer = new TCmnmenupermission();
                    mPer.Menupermissionid = MaxID;
                    mPer.Roleid = Convert.ToDecimal(_RMenu.RoleID);
                    mPer.Menuid = _RMenu.MenuId;
                    mPer.Enableview = Extension.BoolVal(_RMenu.IsView);
                    mPer.Enableinsert = Extension.BoolVal(_RMenu.IsInsert);
                    mPer.Enableupdate = Extension.BoolVal(_RMenu.IsUpdate);
                    mPer.Enabledelete = Extension.BoolVal(_RMenu.IsDelete);

                    //Common
                    mPer.Createpc = Extension.Createpc();
                    mPer.Createby = param.LoggedUserId;
                    mPer.Createon = Extension.Today;
                    cmPermision.Add(mPer);
                    MaxID++;
                }
            }

            if (cmPermision.Count > 0)
            {
                await _ctxOra.TCmnmenupermissions.AddRangeAsync(cmPermision);
            }

            await _ctxOra.SaveChangesAsync();
            return 0;
        }

        /// <summary>
        /// If any child menu under this sub parent menu got remain permitted
        /// then sub parent menu must be permitted that means permission of this
        /// menu assigned as true otherwise prohibitted or false
        /// </summary>
        /// <param name="nmodel"></param>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        private async Task<int> SetPutSubParentMenuPermission(List<vmRoleMenu> nmodel, vmCmnParameter param)
        {
            List<vmRoleMenu> subParentModel = new List<vmRoleMenu>();
            foreach (var nm in nmodel)
            {
                //Filter=> Filter and get sub parent menu
                var cm = _ctxOra.TCmnmenus.Where(x => x.Menuid == nm.SubParentID).FirstOrDefault();
                //Filter
                if (cm != null)
                {
                    if (nm.IsView == false)
                    {
                        //Filter=> Filter and check if any child menu remain permitted or not  in permission table.
                        nm.IsView = (from cnm in _ctxOra.TCmnmenus
                                     join cmp in _ctxOra.TCmnmenupermissions on cnm.Menuid equals cmp.Menuid
                                     where cnm.Subparentid == cm.Menuid && cmp.Roleid == nm.RoleID
                                     && (cmp.Enableview == Extension.BoolVal(true) || cmp.Enableinsert == Extension.BoolVal(true) || cmp.Enableupdate == Extension.BoolVal(true) || cmp.Enabledelete == Extension.BoolVal(true))
                                     select cnm).FirstOrDefault() == null ? false : true;
                        //Filter
                    }

                    if (cm != null)
                    {
                        var nsubpr = new vmRoleMenu
                        {
                            MenuId = (int)cm.Menuid,
                            RoleID = nm.RoleID,
                            IsView = nm.IsView,
                            IsInsert = false,
                            IsUpdate = false,
                            IsDelete = false
                        };

                        subParentModel.Add(nsubpr);
                    }
                }
            }

            if (subParentModel.Count > 0)
            {
                await SetPutMenuPermission(subParentModel, param);
            }

            return 1;
        }

        /// <summary>
        /// If any child menu under this parent menu got remain permitted
        /// then parent menu must be permitted that means permission of this
        /// menu assigned as true otherwise prohibitted or false
        /// </summary>
        /// <param name="nmodel"></param>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        private async Task<int> SetPutParentMenuPermission(List<vmRoleMenu> nmodel, vmCmnParameter param)
        {
            List<vmRoleMenu> parentModel = new List<vmRoleMenu>();
            foreach (var npm in nmodel)
            {
                //Filter=> Filter and get parent menu
                var cpm = _ctxOra.TCmnmenus.Where(x => x.Menuid == npm.ParentID).FirstOrDefault();
                //Filter
                if (cpm != null)
                {
                    if (npm.IsView == false)
                    {
                        //Filter=> Filter and check if any child menu remain permitted or not  in permission table.
                        npm.IsView = (from cm in _ctxOra.TCmnmenus
                                      join cmp in _ctxOra.TCmnmenupermissions on cm.Menuid equals cmp.Menuid
                                      where cm.Parentid == cpm.Menuid && cmp.Roleid == npm.RoleID
                                      && (cmp.Enableview == Extension.BoolVal(true) || cmp.Enableinsert == Extension.BoolVal(true) || cmp.Enableupdate == Extension.BoolVal(true) || cmp.Enabledelete == Extension.BoolVal(true))
                                      select cm).FirstOrDefault() == null ? false : true;
                        //Filter
                    }

                    if (cpm != null)
                    {
                        var npr = new vmRoleMenu
                        {
                            MenuId = (int)cpm.Menuid,
                            RoleID = npm.RoleID,
                            IsView = npm.IsView,
                            IsInsert = false,
                            IsUpdate = false,
                            IsDelete = false
                        };

                        parentModel.Add(npr);
                    }
                }
            }

            if (parentModel.Count > 0)
            {
                await SetPutMenuPermission(parentModel, param);
            }

            return 1;
        }
        #endregion
    }
}
