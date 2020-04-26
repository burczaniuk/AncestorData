using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AncestorData.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet()]
        public IActionResult Login(string address="")
        {
            var model = new Models.Authentication.LoginModel();
            model.PreviousPage = address;
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}