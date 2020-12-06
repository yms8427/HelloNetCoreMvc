using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hello.Web.Models;

namespace Hello.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Campaign()
        {
            var packages = new List<Package>
            {
                new Package(1, "Ücretsiz") { Storage = 10, UserCount = 20, SupportType = "E-posta hizmeti" },
                new Package(2, "Profesyonel") { Price = 40, Storage = 20, UserCount = 40, SupportType = "E-posta ve arama hizmeti" },
                new Package(3, "Kurumsal") { Price = 80, Storage = 40, UserCount = 120, SupportType = "E-posta, arama ve teknik destek hizmeti" }
            };
            return View(packages);
        }

        public IActionResult Contact()
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
