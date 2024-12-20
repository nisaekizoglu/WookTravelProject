using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WookTravelProject.Context;
using WookTravelProject.Entities;

namespace WookTravelProject.Areas.Admin.Controllers
{
    [Authorize]
    public class DestinationController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult DestinationList()
        {
            var values = context.Destinations.ToList();
            return View(values);
        }
        public ActionResult CreateDestination()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDestination(Destination destination)
        {
            context.Destinations.Add(destination);
            context.SaveChanges();
            return RedirectToAction("DestinationList", "Destination", "Admin");
        }

        public ActionResult DeleteDestination(int id)
        {
            var value = context.Destinations.Find(id);
            context.Destinations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("DestinationsList", "Destination", "Admin");
        }
        [HttpGet]

        public ActionResult UpdateDestination(int id)
        {
            var value = context.Destinations.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateDestination(Destination destination)
        {
            var value = context.Destinations.Find(destination.DestinationId);
            value.Description = destination.Description;
            value.City = destination.City;
            value.DayNight = destination.DayNight;
            value.Country = destination.Country;
            value.ImageUrl = destination.ImageUrl;
            value.Price = destination.Price;
            value.Title = destination.Title;
            context.SaveChanges();
            return View("DestinationList", "Destination", "Admin");
        }

    }
}