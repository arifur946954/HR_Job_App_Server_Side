using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataFactories.Infrastructure.common.menus;
//using DataModels.EntityModels.ERPModel;
using DataModel.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CTG_ERPWebApi.api.common.menus
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class menuController : ControllerBase
    {

        #region Variable Declaration & Initialization
        private MenuMgt _manager = null;
        #endregion

        #region Constructor
        public menuController()
        {
            _manager = new MenuMgt();
        }
        #endregion

        #region All Http Methods
        //// GET: api/menu/getbypage
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getbypage([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetWithPagination(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // GET: api/menu/getmenu
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getmenu([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter pram = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetSideMenu(pram);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        //// GET: api/menu/getsidemenu
        //[HttpGet("[action]")]//, BasicAuthorization
        //public async Task<object> getsidemenu([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameter pram = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
        //        resdata = await _manager.GetSideMenu(pram);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // GET: api/menu/getmenubyparam
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getmenubyparam([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter pram = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetMenuByParam(pram);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/menu/checkmenuifexist
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> checkmenuifexist([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.CheckMenuIfExist(cparam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        //// GET: api/menu/getmenubyrole
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getmenubyrole([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
        //        resdata = await _manager.GetRoleWiseMenu(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // GET: api/menu/getmenubyrole
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getoramenubyrole([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetOraRoleWiseMenu(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        //// GET: api/module/getmodulebyuser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getmenuesbyuser([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetMenuesByUserID(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // GET: api/menu/getparentmenu
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getparentmenu()
        {
            object result = null; object resdata = null;
            try
            {                
                resdata = await _manager.GetParentMenu();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/menu/getsubparentmenu
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getsubparentmenu([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetSubParentMenu(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/menu/getbyid
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetByID((int)cmnParam.id);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // POST: api/menu/saveupdate
        [HttpPost("[action]")]//, BasicAuthorization
        public async Task<object> saveupdate([FromBody]object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter param = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                vmMenues _Menu = JsonConvert.DeserializeObject<vmMenues>(data[1].ToString());
                resdata = await _manager.SaveUpdate(_Menu, param);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }
        
        // DELETE: api/menu/delete
        [HttpDelete("[action]")]//,BasicAuthorization
        public async Task<object> delete([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.Delete(cparam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // POST: api/menu/saveupdate
        [HttpPost("[action]")]//, BasicAuthorization
        public async Task<object> saveupdatepermission([FromBody]object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter param = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                List<vmRoleMenu> pmenu = JsonConvert.DeserializeObject<List<vmRoleMenu>>(data[1].ToString());
                resdata = await _manager.SaveUpdatePermission(pmenu, param);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }
        #endregion

        //// GET: api/menu/getpagePermission
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getpagePermission([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.NOCIspPermission(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
    }
}