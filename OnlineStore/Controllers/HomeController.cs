using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Context;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller
    {
        public static string Name { get; set; } = "Guest";
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
            
        {
            ViewBag.UserName = Name;
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
