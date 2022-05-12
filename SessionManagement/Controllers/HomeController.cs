using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessionManagement.Models;
using SessionManagement.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IProductService productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {

            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var products = productService.GetProducts();
            return View(products);
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
