using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AncestorData.Models;
using Microsoft.EntityFrameworkCore;
using AncestorData.EntityFramework;

namespace AncestorData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private GenealogicBaseContext _context;
        public HomeController(ILogger<HomeController> logger, GenealogicBaseContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (_context)
            {
                var user = _context.Users.Take(1).First();
                Console.WriteLine(user);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Regulations()
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
