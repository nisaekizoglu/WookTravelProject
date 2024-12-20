using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WookTravelProject.Controllers
{
    public class ErrorPagesController : Controller
    {
        // GET: ErrorPages
        public ActionResult Page404()
        {
            return View();
        }
    }
}