using MVCFoodPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFoodPortal.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext dbContext = null;
        public HomeController()
        {
            dbContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Index()
        {
            List<Food> foods = dbContext.Food.ToList();

            return View(foods);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var food = dbContext.Food.FirstOrDefault(x => x.Id == id);
            return View(food);

        }
       


    }

 }