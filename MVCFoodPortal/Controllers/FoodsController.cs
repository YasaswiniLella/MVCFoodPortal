using MVCFoodPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFoodPortal.Controllers
{
    [RoutePrefix("Foods")]

    public class FoodsController : Controller
    {
        private ApplicationDbContext dbContext = null;
        public FoodsController()
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
        // GET: Food
        public ActionResult Index()
        {
            List<Food> foods = GetFood();

            return View(foods);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            Food f = new Food();
            foreach (var food in GetFood())
            {
                if (food.Id == id)
                {
                    f = food;
                }
            }
            return View();
        }
        //[HttpGet]
        //public ActionResult Create()
        //{
        //    var viewModel = new FoodieViewModel
        //    {
        //        Foods = new Food(),

        //    };
        //    return View("Create", viewModel);
        //}
        //[HttpPost]
        //public ActionResult Create(Foods foods)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var viewModel = new FoodieViewModel
        //        {
        //            Foods = foods

        //        };
        //        return View("Create", viewModel);
        //    }

        //}

        [NonAction]

        public List<Food> GetFood()
        {
            return dbContext.Food.ToList();

        }
       
    }
}