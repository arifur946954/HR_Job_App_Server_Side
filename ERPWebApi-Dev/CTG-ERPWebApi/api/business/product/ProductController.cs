using DataFactories.Infrastructure.business.product;
//using DataModel.EntityModels.ERPModel;
using DataModel.ViewModels;
using DataModel.ViewModels.ERPViewModel.Business;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CTG_ERPWebApi.api.business.product
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class productController : ControllerBase
    {

        #region Variable Declaration & Initialization
        private ProductMgt _manager = null;
        #endregion

        #region Constructor
        public productController()
        {
            _manager = new ProductMgt();
        }
        #endregion

        //#region All Http Methods
        //// POST: api/product/saveupdateproducttype
        //[HttpPost("[action]")]//BasicAuthorization
        //public async Task<object> saveupdateproducttype([FromBody]object[] data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
        //        vmProductType _productType = JsonConvert.DeserializeObject<vmProductType>(data[1].ToString());
        //        if (_productType != null)
        //        {
        //            resdata = await _manager.SaveUpdateProductType(_productType, cparam);
        //        }
        //    }
        //    catch (Exception) { }

        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// POST: api/product/saveupdateproductcategory
        //[HttpPost("[action]")]//BasicAuthorization
        //public async Task<object> saveupdateproductcategory([FromBody] object[] data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
        //        vmProductCategory _productCategory = JsonConvert.DeserializeObject<vmProductCategory>(data[1].ToString());
        //        if (_productCategory != null)
        //        {
        //            resdata = await _manager.SaveUpdateProductCategory(_productCategory, cparam);
        //        }
        //    }
        //    catch (Exception) { }

        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// POST: api/product/saveupdateproductsubcategory
        //[HttpPost("[action]")]//BasicAuthorization
        //public async Task<object> saveupdateproductsubcategory([FromBody] object[] data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
        //        vmProductSubCategory _productSubCategory = JsonConvert.DeserializeObject<vmProductSubCategory>(data[1].ToString());
        //        if (_productSubCategory != null)
        //        {
        //            resdata = await _manager.SaveUpdateProductSubCategory(_productSubCategory, cparam);
        //        }
        //    }
        //    catch (Exception) { }

        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// POST: api/product/saveupdate
        //[HttpPost("[action]")]//BasicAuthorization
        //public async Task<object> saveupdate([FromBody] object[] data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
        //        vmProduct _product = JsonConvert.DeserializeObject<vmProduct>(data[1].ToString());
        //        if (_product != null)
        //        {
        //            resdata = await _manager.SaveUpdate(_product, cparam);
        //        }
        //    }
        //    catch (Exception) { }

        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //#endregion
    }
}
