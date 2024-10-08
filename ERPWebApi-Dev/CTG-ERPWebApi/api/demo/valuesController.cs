using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RGL_ERPWebApi.api.demo
{
    [Route("api/demo/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class valuesController : ControllerBase
    {
        // GET api/demo/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/demo/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/demo/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/demo/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/demo/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}