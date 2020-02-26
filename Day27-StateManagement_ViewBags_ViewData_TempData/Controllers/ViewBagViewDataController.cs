using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Day27_StateManagement_ViewBags_ViewData_TempData.Controllers
{
    public class ViewBagViewDataController : Controller
    {
        public IActionResult Index()
        {
            //creating viewbags:
            ViewBag.Cats = "Spaghetti";
            ViewBag.Dogs = "Mojo";

            //ViewBags & ViewData with the same key(name) point to the same piece of memory.
            ViewData["Cats"] = "Toad"; //points to the EXACT same piece of memory as ViewBag.Cats

            //HTML will print "Toat, Mojo, Toad"
            return View();
        }

        public IActionResult ListCatsWithViewBag()
        {
            //"gross"
            ViewBag.Cats = new List<string> 
            {
                "Spaghetti", "Mojo", "Sprinkles"
            };
            return View();
        }
    }
}