using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class AjaxApiController : ApiController
    {
        // GET: api/AjaxApi
        public string Get(string name)
        {
            return "你好"+name+"，今天天气不错";
        }

        // GET: api/AjaxApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AjaxApi
        public string Post(dynamic name)
        {
            return "你好" + name.name + "，今天天气不错";
        }

        // PUT: api/AjaxApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AjaxApi/5
        public void Delete(int id)
        {
        }
    }
}
