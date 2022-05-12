using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManagement.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProductToBasket(int id)
        {
            return Json($" {id} idli Ürün sepete eklendi");
        }

    }
}
