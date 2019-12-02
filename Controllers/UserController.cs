using luuga1998.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace luuga1998.Controllers
{
    public class UserController : ApiController
    {

        public UserController()
        
            {

        }

        public class Users
        {
            public string account;
            public string password;
        }

        private static Users[] users = { new Users { account = "test", password = "test" }, new Users { account = "test1", password = "test" }, new Users { account = "test3", password = "test" } };
    
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return users.Select(m=>m.account) ;
        }

        // GET api/<controller>/5
        public Users Get(int id)
        {
            return users[id];
        }

        // POST api/<controller>
        public Response<Users> Post([FromBody]Users user)
        {
            users.Append(user);
            return new Response<Users>(0, "Success", user);
        }

        [HttpPost]
        [Route("api/Users/login")]
        public Response<Boolean> Login([FromBody]Users user)
        {
            if (users.Where(m=>m.account== user.account && m.password == user.password).Any())
            {
                return new Response<Boolean>(0, "Success", true);
            }
            else
            {
                return new Response<Boolean>(0, "Success", false);
            }
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