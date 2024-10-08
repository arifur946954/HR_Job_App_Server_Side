using DataFactories.Infrastructure.common.dropdown;
using DataModel.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace CTG_ERPWebApi.api.common.dropdown
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class dropdownController : ControllerBase
    {
        #region Variable Declaration & Initialization
        private CommonDropdownMgt _manager = null;
        #endregion

        #region Constructor
        public dropdownController()
        {
            _manager = new CommonDropdownMgt();
        }
        #endregion

        //#region All Http Methods
        //// GET: api/dropdown/getallmodule
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallmodule()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllModule();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getallmenu
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallmenu()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllMenu();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // GET: api/dropdown/getallrole
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getallrole()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllRole();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        //// GET: api/dropdown/getallcustomer
        //[HttpGet("[action]")]//BasicAuthorization
        //public async Task<object> getallcustomer()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllCustomer();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // GET: api/dropdown/getallbrand
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getallbrand()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllBrand();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }






        // GET: api/dropdown/getallclienttype
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getallclienttype()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllClientType();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getallcurrency()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllCurrency();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        //// GET: api/dropdown/getallitemtype
        //[HttpGet("[action]")]//BasicAuthorization
        //public async Task<object> getallitemtype()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllItemType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallitemcategory
        //[HttpGet("[action]")]//BasicAuthorization
        //public async Task<object> getallitemcategory()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllItemCategory();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallitemsubcategory
        //[HttpGet("[action]")]//BasicAuthorization
        //public async Task<object> getallitemsubcategory([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
        //        resdata = await _manager.GetAllItemSubCategory(cparam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallitem
        //[HttpGet("[action]")]//BasicAuthorization
        //public async Task<object> getallitem([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
        //        resdata = await _manager.GetAllItem(cparam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // GET: api/dropdown/getallroleForReopen
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getalluserbycompany([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllUserByCompany(cparam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallcompanyuser
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallcompanyuser([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllCompanyUser(cparam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }


        // GET: api/dropdown/getallReferance
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallReferance()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllRefrence();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }



        // GET: api/dropdown/getallbank
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallbank()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllBank();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallaccounttype
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallaccounttype()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllAccountType();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallclient
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallclient()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllClient();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallbusinesscatergory
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallbusinesscatergory()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllBusinessCatergory();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallbusinesscatergory
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallserviceheadgroup()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllServiceHeadGroup();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallbusinessplatform
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallbusinessplatform([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllBusinessPlatform(cparam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallbusinessparameterbyid
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallbusinessparameterbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllBusinessParameter(cparam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallbusinessparameter
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallbusinessparameter()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllBusinessParameter();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallbusinessparametertaskbyid
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallbusinessparametertaskbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllBusinessParameterTask(cparam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallbusinessmetricsbyid
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallbusinessmetricsbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllBusinessMetrics(cparam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallbusinessassettypebyid
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallbusinessassettypebyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllBusinessAssetType(cparam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallprocesstype
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallprocesstype()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllProcessType();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getalltermscondition
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getalltermscondition()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllTermsConditions();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallpublisherbyid
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallpublisherbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllPublisherByCategory(cparam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallpublisherbyid
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallpublisher()
        {
            object result = null; object resdata = null;
            try
            {                
                resdata = await _manager.GetAllPublisher();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallsupplementsbyid
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallsupplementsbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllSupplements(cparam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallplacementbyid
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallplacementbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllPlacement(cparam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallmediabroadcastbycategory
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallmediabroadcastbycategory([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllMediaBroadcastByCategory(cparam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallmediaprogram
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallmediaprogram()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllMediaProgram();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallmediagenre
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallmediagenre()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllMediaGenre();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallmediaday
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallmediaday()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllMediaDay();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallmediadaypart
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallmediadaypart()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllMediaDayPart();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallmediaadposission
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallmediaadposission()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllMediaAdPosission();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallmediasponsor
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallmediasponsor()
        {
            object result = null; object resdata = null;
            try
            {
                resdata = await _manager.GetAllMediaSponsor();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/dropdown/getallmediasponsoredproject
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getallmediasponsoredproject([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetAllMediaSponsoredProject(cparam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        //// GET: api/dropdown/getallroleForReopen
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallroleforreopengroup([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllRoleFroReopenGroup(cmnParam.id);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}



        //// GET: api/dropdown/getallusertype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallusertype()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllUserType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getalldistrict
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getalldistrict()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllDistricts();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getalldivision
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getalldivision()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllDivisions();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallcountry
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallcountry()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllCountries();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallispprofile
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallispprofile()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllIspProfile();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getactivationprofile
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getactivationprofile([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        //dynamic data = JsonConvert.DeserializeObject(param);
        //        //vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getallactivationprofiles();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getactivationprofilebyuser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getactivationprofilebyuser([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getallactivationprofilesbyuserid(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getactivationprofilewisepackage
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getactivationprofilewisepackage([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetActivationProfileWisePackage(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallusageplantype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallusageplantype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getallusageplantype();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////// GET: api/dropdown/getallpackage
        ///*[HttpGet("[action]")]
        //public async Task<object> getallpackage([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getallpackage();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}*/

        //// GET: api/dropdown/getallpackages
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallpackages([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getallpackages();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getregions
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getregions([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getRegions();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getregionsbyactivationprofileid
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getregionsbyactivationprofileid([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        //before bari
        //        //resdata = await _manager.getRegionsByActivationProfileId(cmnParam.id);
        //        //after bari
        //        resdata = await _manager.getRegions();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getos
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getos([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getOS();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getosbyservice
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getosbyservice([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getOS(cmnParam.id);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getosbyparentservice
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getosbyparentservice([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getOS(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getmemory
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getmemory([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        resdata = await _manager.getmemory(data[0]);
        //        //resdata = await _manager.getallmemories();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallmemory
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallmemory([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        resdata = await _manager.getallmemory();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getstorage
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getstorage([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        resdata = await _manager.getstorage(data[0]); //before baari
        //        //resdata = await _manager.getstorage();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getstorage
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getstorageAll([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        resdata = await _manager.getstorage();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getrootdiskvolume
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getrootdiskvolume([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        resdata = await _manager.getrootdiskvolume(data[0]);
        //        //resdata = await _manager.getrootdiskvolume();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getAllUsagePlans
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getAllUsagePlans()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getAllUsagePlans();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getAllUsagePlans
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getAllUsagePlansByTenant([FromQuery]string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getAllUsagePlansByTenant(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getAllBizContracts
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getAllBizContracts()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getAllBizContracts();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //} 

        //// GET: api/dropdown/getAllBizContracts
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getAllContractsByTenant([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getAllContractsByTenant(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getAllenvironments
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getAllenvironments()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllEnvironments();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //// GET: api/dropdown/getAllenvironments
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallenvironmentsbyregion([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllEnvironments(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getAllenvironments
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getAllenvironment()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllEnvironment();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getcategory
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getcategory([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getcategory(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getsupplier
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getsupplier([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getsupplier(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getmanufacturer
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getmanufacturer([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getmanufacturer(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getunitmeasurment
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getunitmeasurment([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getUnitMeasurment();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getsalestype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getsalestype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getSalesType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getinvcustomer
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getinvcustomer([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getInvCustomer();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getinvstore
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getinvstore([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getInvStore(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getinvzone
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getinvzone([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getAllIspZone();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getinvzone
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getcompanylist([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getCompanyList();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}





        ////GET: api/dropdown/getinvzone
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getinvarea([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getAllIspZoneWiseArea(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getemployee
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getemployee([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getEmployee(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getallispzone
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallispzone()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getAllIspZone();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getallisparea
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallisparea()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllIspArea();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getallcloudarea
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallcloudarea()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllCloudArea();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getisppackagetype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getisppackagetype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetIspPackageType(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getisppackservicetype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getisppackservicetype()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetIspPackServiceType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getisppaymentmethod
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getisppaymentmethod()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetIspPaymentMethod();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getuserlistoptionfilter
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getuserlistoptionfilter()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetUserListOptionFilter();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getispusertype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getispusertype()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        //dynamic data = JsonConvert.DeserializeObject(param);
        //        //vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetIspUserType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        ////GET: api/dropdown/getcloudusertype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getcloudusertype()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetCloudUserType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getcloudleadtype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getcloudleadtype()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetCloudLeadType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getvouchertype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getvouchertype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetVoucherType(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/gettenanttype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> gettenanttype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetTenantType(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getbundlelist
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getbundlelist([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetBundleList();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getcloudbundletype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getcloudbundletype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetCloudBundleType(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////GET: api/dropdown/getcloudbundleexpirationtype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getcloudbundleexpirationtype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetCloudBundleExpirationType(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}





        //// GET: api/dropdown/GetPrimaryGroup
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getPrimaryGroupForGroupHead()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetPrimaryGroupForGroupHead();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/GetPrimaryGroup
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getPrimaryGroup()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetPrimaryGroup();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getcloudplan
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getcloudplan()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getcloudplan();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getcurrency
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getcurrency()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetCurrency();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getclouduser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getclouduser()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetCurrency();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getclouduser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> geteligibleusersubtenant()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.geteligibleusersubtenant();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/gettenant
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> gettenant()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.gettenant();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getsubtenant
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getsubtenant([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getsubtenant(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getclouduser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getalluser()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.getalluser();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getdeploymenttype
        ///*[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getdeploymenttype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetDeploymentType(cmnParam.id);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}*/

        //// GET: api/dropdown/getdeploymentservice
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getdeploymentservice([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetDeploymentService(cmnParam.id);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getscalingpolicy
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getscalingpolicy([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getscalingpolicy();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getsuspensionpolicy
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getsuspensionpolicy([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getsuspensionpolicy();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getagingpolicy
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getagingpolicy([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getagingpolicy();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getdeploycloud
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getdeploycloud([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getDeployCloud();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getclouddeploymentbyuser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getclouddeploymentbyuser([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getCloudDeploymentByUser(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getparentdeploymentservice
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getparentdeploymentservice([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        //dynamic data = JsonConvert.DeserializeObject(param);
        //        //vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetParentDeploymentService();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallpolicytype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallpolicytype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllPolicyType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallpolicy
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallpolicy([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllPolicy(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //#endregion

        //#region CRM cloud
        //// GET: api/dropdown/getticketcategory
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getticketcategory([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllCrmCloudTicketCategory(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //#endregion

        //#region CRM isp
        //// GET: api/dropdown/getispticketcategory
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getispticketcategory([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllCrmIspTicketCategory(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //#endregion

        //#region Sales & Marketing
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallos([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllOs(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallmemories([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllSalesMemories(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallcloudstorage([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllCloudStorage(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallcloudstoragesize([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllDiskVolume(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallcloudpolicies([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllPolicies(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getcloudalladditionservice([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetCloudAdditionService(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //// GET: api/dropdown/getallsalesteamtype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalesteamtype()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesTeamType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalescmnuser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalescmnuser()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesCmnuser();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //// GET: api/dropdown/GetCloudMarketingUser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> GetCloudMarketingUser()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetCloudMarketingUser();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //// GET: api/dropdown/getallsalescmnuser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallispuserbytype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllIspUserByType(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalescampaigntype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalescampaigntype()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesCampaignType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalescampaignstatus
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalescampaignstatus()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesCampaignStatus();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalescampaign
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalescampaign()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesCampaign();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalesaccounttype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalesaccounttype()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesAccountType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalesindustry
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalesindustry()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesIndustry();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalesaccount
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalesaccount()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesAccount();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalescontact
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalescontact()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesContact();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalesopportunitytype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalesopportunitytype()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesOpportunityType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalesopportunitystage
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalesopportunitystage()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesOpportunityStage();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalesopportunitylossreason
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalesopportunitylossreason()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesOpportunityLossReason();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalestaskpriority
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalestaskpriority()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesTaskPriority();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallsalestaskstatus
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallsalestaskstatus()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllSalesTaskStatus();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallispteam
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallispteam([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllISPTeam(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallispfibernetworkdropdown
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallispfibernetworkdropdown()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllIspFiberNetworkDropDown();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallispfibernetworkdropdown
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallispfibernetworkpopname()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllIspFiberNetworkPopName();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        ////// GET: api/dropdown/getallispfibernetworkdropdown
        ////[HttpGet("[action]"), BasicAuthorization]
        ////public async Task<object> getallispfibernetworkponno(string value)
        ////{
        ////    object result = null; object resdata = null;
        ////    try
        ////    {
        ////        resdata = await _manager.GetAllIspFiberNetworkPonNo(value);
        ////    }
        ////    catch (Exception) { }
        ////    return result = new
        ////    {
        ////        resdata
        ////    };
        ////}

        //// GET: api/dropdown/getteammembers
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallispfibernetworkponno([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllIspFiberNetworkPonNo(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getteammembers
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallispfibernetworkdsno([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllIspFiberNetworkDsNo(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getteammembers
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getteammembers([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetTeamMembers(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getopportunities
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getopportunities([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetOpportunities(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //#endregion

        //// GET: api/dropdown/getalltmonths
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getalltmonths([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllMonths();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallconnection
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallconnectiontype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        //dynamic data = JsonConvert.DeserializeObject(param);
        //        //vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllConnectionType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallLeadConnection([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getallLeadConnection(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallpurposetype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallpurposetype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllPurposeType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallworkflowprocesstype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallworkflowprocesstype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        //dynamic data = JsonConvert.DeserializeObject(param);
        //        //vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllWorkflowProcessType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallprocessdepartment
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallprocessdepartment([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        //dynamic data = JsonConvert.DeserializeObject(param);
        //        //vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllProcessDepartment();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //#region biz isp
        //// GET: api/dropdown/getispservices
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getispservices([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetIspServices(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getbizispparentservices
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getbizispparentservices([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetBizIspParentServices(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getbillcollector
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getbillcollector()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetBillCollector();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //#endregion

        #region common
        // GET: api/dropdown/getdatebd
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getdatebd([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetDateBD();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getdatebd
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getdatetimebd([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetDateTimeBD();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        #endregion

        //#region HRM
        //// GET: api/dropdown/getallshifttype
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallshifttype([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllShiftType();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallshiftcategory
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallshiftcategory([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetAllShiftCategory(cmnParam.type);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallweekdays
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallweekdays([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllWeekDays();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getallshift
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getallshift()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllShift();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getalllinemanager
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getalllinemanager()
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetAllLineManager();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/dropdown/getemployeeforleave
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getemployeeforleave([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetEmployeeForLeave(cmnParam);
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