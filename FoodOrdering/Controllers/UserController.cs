using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrdering.Models;

namespace FoodOrdering.Controllers
{
    public class UserController : Controller
    {
        private static List<UserViewModel> users = new List<UserViewModel>();
        public IActionResult Login(UserViewModel userViewModel)
        {
           

            return View();
        }

        public IActionResult SignUp()
        {
            UserViewModel user = new UserViewModel();

            return View();
        }
        public IActionResult CreateUser(UserViewModel userViewModel)
        {
            
            users.Add(userViewModel);

            return RedirectToAction(nameof(Login));
        }
        public IActionResult AuthenticateUser(UserViewModel userViewModel,string username, string password)
        {
            
            foreach(var user in users)
            {
                if(user.Username == userViewModel.Username && user.Password == userViewModel.Password)
                {
                    return RedirectToAction("Index","Home");
                }
            }


            return RedirectToAction(nameof(Login));
        }
    }
}
