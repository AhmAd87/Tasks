using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestTask.Models;

namespace TestTask.Controllers
{
    public class UserController : ApiController
    {
        public IHttpActionResult AddUser(UserClass uc)
        {
            using (newdbEntities _db = new newdbEntities())
            {
                _db.Users.Add(new User()
                {
                    UserName = uc.Username,
                    Email = uc.Email,
                    Password = uc.Password,
                    Phone = uc.Phone
                });
                _db.SaveChanges();
                return Ok();
            }
        }
    }
}
