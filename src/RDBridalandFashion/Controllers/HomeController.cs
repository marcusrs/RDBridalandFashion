using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RDBridalandFashion.Controllers
{
    public class HomeController : Controller
    {
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

        public IActionResult Wedding()
        {

            ViewData["Message"] = "Wedding Gowns";

            return View();

        }


        public IActionResult Tuxedos()
        {

            ViewData["Message"] = "Mens and Boys Tuxedos";

            return View();

        }


        public IActionResult Formal()
        {

            ViewData["Message"] = "Formal Dresses and Gowns";

            return View();

        }


        public IActionResult Communion()
        {

            ViewData["Message"] = "	COMMUNION AND QUINCENIERAS outfits for Boys and Girls ";

            return View();

        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
