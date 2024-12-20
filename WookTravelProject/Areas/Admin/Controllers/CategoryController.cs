using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WookTravelProject.Context;
using WookTravelProject.Entities;

namespace WookTravelProject.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        TravelContext context = new TravelContext();

        [Authorize]
        public ActionResult CategoryList()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("CategoryList", "Category", "Admin");
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = context.Categories.Find(id);
            context.Categories.Remove(value);
            context.SaveChanges();
            return RedirectToAction("CategoryList", "Category", "Admin");
        }
        [HttpGet]

        public ActionResult UpdateCategory(int id)
        {
            var value = context.Categories.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var value = context.Categories.Find(category.CategoryId);
            value.CategoryName = category.CategoryName;
            //value.CategoryStatus = category.CategoryStatus;
            context.SaveChanges();
            return View("CategoryList", "Category", "Admin");
        }
    }
}