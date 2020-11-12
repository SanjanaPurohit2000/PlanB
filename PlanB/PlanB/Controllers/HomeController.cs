using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
=======
>>>>>>> 351c46abc4f269c891d4af46a8e693a80b2dee5d
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlanB.Models;

namespace PlanB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
<<<<<<< HEAD
        [Authorize]
=======

>>>>>>> 351c46abc4f269c891d4af46a8e693a80b2dee5d
        public IActionResult Index()
        {
            return View();
        }
<<<<<<< HEAD
        [Authorize]
=======
>>>>>>> 351c46abc4f269c891d4af46a8e693a80b2dee5d

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
