using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WookTravelProject.Context;

namespace WookTravelProject.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            var username = Session["user"];
            var value = context.Admin.Where(x => x.Username == username).FirstOrDefault();

            return PartialView(value);
        }
        public PartialViewResult PartialMessageNavbar()
        {
            var username = Session["user"];
            var email = context.Admin.Where(x => x.Username == username).Select(y => y.Email).FirstOrDefault();
            var incomingEmails = context.Messages.Where(x => x.ReceiverMail == email).ToList();
            var incomingEmailsCount = context.Messages.Where(x => x.ReceiverMail == email).Count();

            ViewBag.MessageCount = incomingEmailsCount;

            return PartialView(incomingEmails);
        }
        public PartialViewResult PartialDestinationNavbar()
        {
            var last4Destination = context.Destinations.OrderByDescending(d => d.DestinationId).Take(4).ToList();

            return PartialView(last4Destination);
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}