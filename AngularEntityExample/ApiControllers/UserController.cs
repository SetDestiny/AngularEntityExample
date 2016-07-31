using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularEntityExample.Data;
using AngularEntityExample.DataAccess.Repositories;

namespace AngularEntityExample.ApiControllers
{
    public class UserController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            IHttpActionResult result = null;
            IUserRepository da = new UserRepository();
            IList<User> users = da.GetUsersList();

            if (users.Count > 0)
            {
                result = Ok(users);
            }
            else
            {
                result = NotFound();
            }

            return result;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}