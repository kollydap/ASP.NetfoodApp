using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrdering.Models;

namespace FoodOrdering.Controllers
{
    public class FoodController : Controller
    {
        private static List<FoodViewModel> foods = new List<FoodViewModel>();
        public IActionResult Index()
        {
            var food1 = new FoodViewModel()
            {
                Name = "Rice",
                Id = 1,
                Description = "Beautiful Food",
                Is_available = true,
                Price = 3000,
                Images = new List<string> { "hello", "rice" }
            };
            var food2 = new FoodViewModel()
            {
                Name = "Beans",
                Id = 2,
                Description = "Beauti Food",
                Is_available = false,
                Price = 9000,
                Images = new List<string> { "hello", "rice" }
            };
            foods.Add(food2);
            foods.Add(food1);
            return View(foods);
        }
    }
}
