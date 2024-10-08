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
using System.Threading.Tasks;

namespace DataFactories.Infrastructure.business.product
{
    public class ProductMgt
    {
        #region Variable declaration & initialization
        ModelContext _ctxOra = null;
        private IGenericFactoryOracle<vmCmnParameter> OraGeneric_vmCmnParameter = null;
        Hashtable ht = null; OracleParameter[] oprm = null;
        #endregion

        //#region All Methods
        ///// <summary>
        ///// Both insert and update can perform by CmnUserRole model in database using asynchronous operation. when id is more than 0 update is performed otherwise insert. it returns an object as status of success or failure.
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public async Task<object> SaveUpdateProductType(vmProductType _productType, vmCmnParameter param)
        //{
        //    object result = null, colId=null; string message = string.Empty, colName = string.Empty; bool resstate = false, isSet = false;
        //    using (_ctxOra = new ModelContext())
        //    {
        //        using (var _ctxOraTransaction = _ctxOra.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                TProductType productType = null;

        //                if (_productType.TypeId > 0)
        //                {
        //                    productType = await _ctxOra.TProductTypes.FirstOrDefaultAsync(x => x.ProductTypeId == _productType.TypeId);
        //                    productType.ProductTypeName = _productType.TypeName;
        //                    productType.Isactive = Extension.BoolVal(_productType.IsActive);
        //                    //Common
        //                    productType.Updatepc = Extension.Createpc();
        //                    productType.Updateby = param.LoggedUserId;
        //                    productType.Updateon = Extension.Today;

        //                    message = MessageConstants.Updated;
        //                    colId = productType.ProductTypeId;
        //                    colName = productType.ProductTypeName;

        //                }
        //                else
        //                {
        //                    var MaxID = _ctxOra.TProductTypes.DefaultIfEmpty().Max(x => x == null ? 0 : x.ProductTypeId) + 1;
        //                    productType = new TProductType();
        //                    productType.ProductTypeId = MaxID;
        //                    productType.ProductTypeName = _productType.TypeName;
        //                    productType.Isactive = Extension.BoolVal(_productType.IsActive);

        //                    //Common
        //                    productType.Createpc = Extension.Createpc();
        //                    productType.Createby = param.LoggedUserId;
        //                    productType.Createon = Extension.Today;

        //                    await _ctxOra.TProductTypes.AddAsync(productType);

        //                    message = MessageConstants.Saved;
        //                    colId = productType.ProductTypeId;
        //                    colName = productType.ProductTypeName;
        //                    isSet = true;
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
        //        colId,
        //        colName,
        //        isSet,
        //        message,
        //        resstate
        //    };
        //}

        //public async Task<object> SaveUpdateProductCategory(vmProductCategory _productCategory, vmCmnParameter param)
        //{
        //    object result = null, colId = null; string message = string.Empty, colName = string.Empty; bool resstate = false, isSet = false;
        //    using (_ctxOra = new ModelContext())
        //    {
        //        using (var _ctxOraTransaction = _ctxOra.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                TProductCategory productCategory = null;

        //                if (_productCategory.CategoryId > 0)
        //                {
        //                    productCategory = await _ctxOra.TProductCategories.FirstOrDefaultAsync(x => x.ProductCategoryId == _productCategory.CategoryId);
        //                    productCategory.ProductCategoryName = _productCategory.CategoryName;
        //                    productCategory.Isactive = Extension.BoolVal(_productCategory.IsActive);
        //                    //Common
        //                    productCategory.Updatepc = Extension.Createpc();
        //                    productCategory.Updateby = param.LoggedUserId;
        //                    productCategory.Updateon = Extension.Today;

        //                    message = MessageConstants.Updated;
        //                    colId = productCategory.ProductCategoryId;
        //                    colName = productCategory.ProductCategoryName;
        //                }
        //                else
        //                {
        //                    var MaxID = _ctxOra.TProductCategories.DefaultIfEmpty().Max(x => x == null ? 0 : x.ProductCategoryId) + 1;
        //                    productCategory = new TProductCategory();
        //                    productCategory.ProductCategoryId = MaxID;
        //                    productCategory.ProductCategoryName = _productCategory.CategoryName;
        //                    productCategory.Isactive = Extension.BoolVal(_productCategory.IsActive);

        //                    //Common
        //                    productCategory.Createpc = Extension.Createpc();
        //                    productCategory.Createby = param.LoggedUserId;
        //                    productCategory.Createon = Extension.Today;

        //                    await _ctxOra.TProductCategories.AddAsync(productCategory);

        //                    message = MessageConstants.Saved;
        //                    colId = productCategory.ProductCategoryId;
        //                    colName = productCategory.ProductCategoryName;
        //                    isSet = true;
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
        //        colId,
        //        colName,
        //        isSet,
        //        message,
        //        resstate
        //    };
        //}

        //public async Task<object> SaveUpdateProductSubCategory(vmProductSubCategory _productSubCategory, vmCmnParameter param)
        //{
        //    object result = null, colId = null; string message = string.Empty, colName = string.Empty; bool resstate = false, isSet = false;
        //    using (_ctxOra = new ModelContext())
        //    {
        //        using (var _ctxOraTransaction = _ctxOra.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                TProductSubcategory productSubCategory = null;

        //                if (_productSubCategory.SubCategoryId > 0)
        //                {
        //                    productSubCategory = await _ctxOra.TProductSubcategories.FirstOrDefaultAsync(x => x.ProductSubcategoryId == _productSubCategory.SubCategoryId);
        //                    //productSubCategory.ProductCategoryId = _productSubCategory.CategoryId;
        //                    productSubCategory.ProductSubcategoryName = _productSubCategory.SubCategoryName;
        //                    productSubCategory.Isactive = Extension.BoolVal(_productSubCategory.IsActive);
        //                    //Common
        //                    productSubCategory.Updatepc = Extension.Createpc();
        //                    productSubCategory.Updateby = param.LoggedUserId;
        //                    productSubCategory.Updateon = Extension.Today;

        //                    message = MessageConstants.Updated;

        //                    colId = productSubCategory.ProductSubcategoryId;
        //                    colName = productSubCategory.ProductSubcategoryName;
        //                }
        //                else
        //                {
        //                    var MaxID = _ctxOra.TProductSubcategories.DefaultIfEmpty().Max(x => x == null ? 0 : x.ProductSubcategoryId) + 1;
        //                    productSubCategory = new TProductSubcategory();
        //                    productSubCategory.ProductSubcategoryId = MaxID;
        //                    //productSubCategory.ProductCategoryId = _productSubCategory.CategoryId;
        //                    productSubCategory.ProductSubcategoryName = _productSubCategory.SubCategoryName;
        //                    productSubCategory.Isactive = Extension.BoolVal(_productSubCategory.IsActive);

        //                    //Common
        //                    productSubCategory.Createpc = Extension.Createpc();
        //                    productSubCategory.Createby = param.LoggedUserId;
        //                    productSubCategory.Createon = Extension.Today;

        //                    await _ctxOra.TProductSubcategories.AddAsync(productSubCategory);

        //                    message = MessageConstants.Saved;
        //                    colId = productSubCategory.ProductSubcategoryId;
        //                    colName = productSubCategory.ProductSubcategoryName;
        //                    isSet = true;
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
        //        colId,
        //        colName,
        //        isSet,
        //        message,
        //        resstate
        //    };
        //}

        //public async Task<object> SaveUpdate(vmProduct _product, vmCmnParameter param)
        //{
        //    object result = null, colId = null; string message = string.Empty, colName = string.Empty; bool resstate = false, isSet = false;
        //    using (_ctxOra = new ModelContext())
        //    {
        //        using (var _ctxOraTransaction = _ctxOra.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                TProductDetail product = null;

        //                if (_product.TypeId > 0)
        //                {
        //                    product = await _ctxOra.TProductDetails.FirstOrDefaultAsync(x => x.ProductId == _product.ItemId);
        //                    product.ProductName = _product.ItemName;
        //                    //product.TypeId = _product.TypeId;
        //                    //product.SubCategoryId = _product.SubCategoryId;
        //                    product.Isactive = Extension.BoolVal(_product.IsActive);
        //                    //Common
        //                    product.Updatepc = Extension.Createpc();
        //                    product.Updateby = param.LoggedUserId;
        //                    product.Updateon = Extension.Today;

        //                    message = MessageConstants.Updated;

        //                    colId = product.ProductId;
        //                    colName = product.ProductName;
        //                }
        //                else
        //                {
        //                    var MaxID = _ctxOra.TProductDetails.DefaultIfEmpty().Max(x => x == null ? 0 : x.ProductId) + 1;
        //                    product = new TProductDetail();
        //                    product.ProductId = MaxID;
        //                    product.ProductName = _product.ItemName;
        //                    //product.TypeId = _product.TypeId;
        //                    //product.SubCategoryId = _product.SubCategoryId;
        //                    product.Isactive = Extension.BoolVal(_product.IsActive);

        //                    //Common
        //                    product.Createpc = Extension.Createpc();
        //                    product.Createby = param.LoggedUserId;
        //                    product.Createon = Extension.Today;

        //                    await _ctxOra.TProductDetails.AddAsync(product);

        //                    message = MessageConstants.Saved;
        //                    colId = product.ProductId;
        //                    colName = product.ProductName;
        //                    isSet = true;
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
        //        colId,
        //        colName,
        //        isSet,
        //        message,
        //        resstate
        //    };
        //}
        //#endregion
    }
}
