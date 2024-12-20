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
    public class LoginController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(Admin admin)
        {
            var values = context.Admin.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["x"] = values.Username;
                return RedirectToAction("Index", "Profile", new { area = "Admin" });
            }
            else
            {
                return View();
            }
        }
    }
}
