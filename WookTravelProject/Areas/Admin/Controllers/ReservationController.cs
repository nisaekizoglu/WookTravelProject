using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WookTravelProject.Context;
using WookTravelProject.Entities;

namespace WookTravelProject.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult ReservationList()
        {
            var values = context.Reservations.ToList();
            return View(values);
        }

        public ActionResult CreateReservation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateReservation(Reservation reservations)
        {
            context.Reservations.Add(reservations);
            context.SaveChanges();
            return RedirectToAction("ReservationList", "Reservations", "Admin");
        }

        public ActionResult DeleteReservation(int id)
        {
            var value = context.Categories.Find(id);
            context.Categories.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ReservationList", "Reservations", "Admin");
        }
        [HttpGet]

        public ActionResult UpdateReservation(int id)
        {
            var value = context.Reservations.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateReservation(Reservation reservations)
        {
            var value = context.Reservations.Find(reservations.ReservationsId);
            value.ReservationsId = reservations.ReservationsId;
            value.Name = reservations.Name;
            value.Phone = reservations.Phone;
            value.PersonCount = reservations.PersonCount;
            value.ReservationsDate = reservations.ReservationsDate;
            value.Description = reservations.Description;
            context.SaveChanges();
            return View("ReservationList", "Reservations", "Admin");
        }
    }
}