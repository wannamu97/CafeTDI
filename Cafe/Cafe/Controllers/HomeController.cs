using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cafe.Models;
using Microsoft.AspNetCore.Authorization;

namespace Cafe.Controllers
{
    public class HomeController : Controller
    {
       [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Menu()
        {
            ViewData["Message"] = "List of Menu.";

            return View();
        }

        public IActionResult Staff()
        {
            ViewData["Message"] = "Manage staff.";

            return View();
        }

        public IActionResult ManageMenu()
        {
            ViewData["Message"] = "Manage menu.";

            return View();
        }

        public IActionResult Sale()
        {
            ViewData["Message"] = "View report.";

            return View();
        }

        public IActionResult Order()
        {
            ViewData["Message"] = "Manage order.";

            return View();
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
