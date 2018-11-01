using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AulasAspNet.Controllers
{
    public class HomeController : Controller
    {
        // http://localhost:123/Home/Index
        // http://localhost:123/Home/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Soma(int a, int b)
        {
            int c = a + b;
            string resp = "A soma de A com B é:" + c;
            return View("Soma", resp);
        }

    }

}