using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WookTravelProject.Context;
using WookTravelProject.Entities;

namespace WookTravelProject.Controllers
{
    public class RegisterController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(Admin admin)
        {
            context.Admin.Add(admin);
            context.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
    }
}