using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WookTravelProject.Areas.Admin.Controllers
{
    public class LogOutController : Controller
    {
        // GET: Admin/LogOut
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult IndexPost()
        //{
        //    Session.Abandon();
        //    FormsAuthentication.SignOut();
        //    return RedirectToAction("Login", "Index");  
        //}
    }
}