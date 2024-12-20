using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WookTravelProject.Context;

namespace WookTravelProject.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var a = Session["x"];
            var values = context.Admin.Where(x => x.Username == a).FirstOrDefault();
            return View(values);
        }
    }
}