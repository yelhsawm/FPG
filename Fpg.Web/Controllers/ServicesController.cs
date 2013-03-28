using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fpg.Web.Controllers
{
    public class ServicesController : ApiController
    {
        // GET api/services
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/services/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/services
        public void Post([FromBody]string value)
        {
        }

        // PUT api/services/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/services/5
        public void Delete(int id)
        {
        }
    }
}
