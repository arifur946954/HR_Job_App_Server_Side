using DataFactories.DBService;
using DataFactories.Infrastructure.common.users;
//using DataModels.EntityModels.ERPModel;
using DataModel.ViewModels;
using DataModel.ViewModels.ERPViewModel.Common;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTG_ERPWebApi.api.common.user
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class usersController : ControllerBase
    {
        #region Variable Declaration & Initialization
        private UserMgt _manager = null;
        #endregion

        #region Constructor
        public usersController()
        {
            _manager = new UserMgt();
        }
        #endregion

        #region All Http Methods
        // GET: api/users/getbypage
        [HttpGet("[action]"), BasicAuthorization]
        public async Task<object>getbypage([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                //var cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
                var cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetWithPagination(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/users/getbypagebyusertype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getbypagebyusertype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        var cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetWithPageByUserType(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // GET: api/users/getbyid
        [HttpGet("[action]"), BasicAuthorization]
        public async Task<object> getbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
                resdata = await _manager.GetByID((int)cmnParam.id);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }


        // GET: api/users/getemployeedetailbyid
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getemployeedetailbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetEmployeeDetailByID(cmnParam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // POST: api/menu/saveupdate
        [HttpPost("[action]")]//, BasicAuthorization
        public async Task<object> saveupdate([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdate(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }



        // Post: api/users/saveOraCmnuser
        /* [HttpPost("[action]")]
         public async Task<object> saveUser([FromBody] object[] data, vmCmnParameter param)
         {
             object result = null; object resdata = null;
             try
             {
                 vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
                 resdata = await _manager.SaveUpdate(cmnParam, param);

             }
             catch (Exception) { }
             return result = new
             {
                 resdata
             };
         }*/



        //// GET: api/users/getbyEmpid
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getbyEmpid([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetByEmpID((int)cmnParam.id);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // POST: api/users/saveupdate
        //[HttpPost("[action]"), BasicAuthorization]
        //public async Task<object> saveupdate([FromBody]object[] data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        var _User = JsonConvert.DeserializeObject<vmCmnUser>(data[0].ToString());
        //        var _UserType = JsonConvert.DeserializeObject<List<CmnUserType>>(data[1].ToString());
        //        if (_User != null)
        //        {
        //            resdata = await _manager.SaveUpdate(_User, _UserType);
        //        }
        //    }
        //    catch (Exception) { }

        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // POST: api/users/setmobileattendace
        //[HttpPost("[action]"), BasicAuthorization]
        //public async Task<object> setmobileattendace([FromBody]object[] data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        var _User = JsonConvert.DeserializeObject<vmCmnUser>(data[0].ToString());
        //        if (_User != null)
        //        {
        //            resdata = await _manager.SetMobileAttendace(_User);
        //        }
        //    }
        //    catch (Exception) { }

        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // POST: api/users/saveupdate
        //[HttpPost("[action]"), BasicAuthorization]
        //public async Task<object> save([FromBody]object[] data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        var _User = JsonConvert.DeserializeObject<CmnUser>(data[0].ToString());
        //        if (_User != null)
        //        {
        //            resdata = await _manager.Save(_User);
        //        }
        //    }
        //    catch (Exception) { }

        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // DELETE: api/users/delete
        //[HttpDelete("[action]"), BasicAuthorization]
        //public async Task<object> delete([FromQuery] string param)
        //{
        //    object result = null; object resdata = string.Empty;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.Delete((int)cmnParam.id);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // POST: api/users/changepass
        //[HttpPost("[action]"), BasicAuthorization]
        //public async Task<object> changepass([FromBody]object[] data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        var _User = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        if (_User != null)
        //        {
        //            resdata = await _manager.ChangePassword(_User);
        //        }
        //    }
        //    catch (Exception) { }

        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/users/checkuserexist
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> checkuserexist([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.CheckUserIfExist(cmnParam.userName);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // Post: api/users/saveOraCmnuser
        [HttpPost("[action]")]
        public async Task<object> saveoracmnuser([FromBody]object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
                //resdata = await _manager.TestInsertOracleDbCmnUser(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/users/getorauser
        [HttpGet("[action]")]
        public async Task<object> getorauser([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
                resdata = await _manager.GetOraUser(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // Post: api/users/login
        [HttpPost("[action]")]
        public async Task<object> login([FromBody]object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.VerifyUser(data[0]);
            }
            catch (Exception ex) {
                ex.ToString();
            }
            return result = new
            {
                resdata
            };
        }

        // GET: api/users/loggeduserdetails
        [HttpGet("[action]")]
        public async Task<object> loggeduserdetails([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.LoggedUserDetails(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // Post: api/users/updatepassword
        [HttpPost("[action]")]
        public async Task<object> updatepassword([FromBody]object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());

                resdata = await _manager.UpdatePassword(cparam, data[1]);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        #endregion
    }
}