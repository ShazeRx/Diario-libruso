using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using diario_libruso.Models;

namespace diario_libruso.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string layout)
        {
            if (layout == "layout1")
                ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            else if (layout == "layout2")
                ViewBag.Layout = "~/Views/Shared/_LayoutDark.cshtml";
            else
                ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}