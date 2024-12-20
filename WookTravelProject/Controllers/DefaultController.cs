using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WookTravelProject.Context;
using WookTravelProject.Entities;
using PagedList;
using System.Web.UI;

namespace WookTravelProject.Controllers
{
    public class DefaultController : Controller
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
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialBanner()
        {
            var last4Destination = context.Destinations.OrderByDescending(d => d.DestinationId).Take(4).ToList();
            return PartialView(last4Destination);
        }
        public PartialViewResult PartialCountry(int page = 1)
        {
            int pageSize = 3;
            var values = context.Destinations
                                .OrderByDescending(d => d.DestinationId)
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = Math.Ceiling((double)context.Destinations.Count() / pageSize);

            return PartialView(values);
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialDetail(int id)
        {
            var values = context.Destinations.Where(x => x.DestinationId == id).ToList();
            return PartialView(values);
        }
        [HttpGet]
        public ActionResult Reservation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Reservation(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                context.Reservations.Add(reservation);
                context.SaveChanges();
                TempData["SuccessMessage"] = "Rezervasyon işlemi başarılı!";
                return RedirectToAction("Index"); 
            }
            return View(reservation);
        }
    }
}