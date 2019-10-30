using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTask.Models;
using System.Net.Http;

namespace TestTask.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserClass uc)
        {
            if (ModelState.IsValid)
            {
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("http://localhost:56180/api/User");
                var insert = hc.PostAsJsonAsync<UserClass>("User", uc);
                insert.Wait();
                var save = insert.Result;
                if(save.IsSuccessStatusCode)
                {
                    ViewBag.message = "Done .. The User " + uc.Username + " Is Added successfully .. " ;
                }
                else
                {
                    ViewBag.Errormessage = "Error .. please try again.. ";
                }
            }
            else
            {
                ViewBag.Errormessage = "Error .. please insure your data.. ";
            }
                return View();
        }
    }
}