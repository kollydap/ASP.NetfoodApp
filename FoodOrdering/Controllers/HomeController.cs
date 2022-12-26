using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FoodOrdering.Models;
using Microsoft.AspNetCore.Authorization;

namespace FoodOrdering.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private static List<FoodViewModel> foods = new List<FoodViewModel>();
        
       
        public IActionResult Index()
        {
            var food1 = new FoodViewModel()
            {
                Name = "Rice", Id = 1, Description = "Beautiful Food", Is_available = true, Price = 3000,
                Images = new List<string> { "hello", "rice" }
            };
            var food2 = new FoodViewModel()
            {
                Name = "Beans",
                Id = 2,
                Description = "Beauti Food",
                Is_available = false,
                Price = 9000,
                Images = new List<string> { "hello","rice"}
            };
            foods.Add(food2);
            foods.Add(food1);
            if (User.Identity.IsAuthenticated)
            {
                return View(foods);
            }
            else
            {
                return RedirectToAction("Login", "User");
            }
        }

        public IActionResult Privacy()
        {
           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
