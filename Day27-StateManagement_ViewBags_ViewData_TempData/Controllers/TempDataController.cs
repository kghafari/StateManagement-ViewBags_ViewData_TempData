using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Day27_StateManagement_ViewBags_ViewData_TempData.Controllers
{
    public class TempDataController : Controller
    {
       
        public IActionResult First()
        {
            //setting our temp data
            //this populates the TempData[""]

            //        key        value
            TempData["Jon"] = "JonsCars";
            return View();
        }

        public IActionResult Second()
        {
            //set a variable to our temp data
            // ?? null : sets it to either JonsCars, or null (so we don't get an error)
            var jon = TempData["JonsCars"] ?? null;
            return View();
        }

        public IActionResult Third()
        {
            var jon = TempData["JonsCars"] ?? null;
            return View();
        }

        public IActionResult Fourth()
        {
            var jon = TempData["JonsCars"] ?? null;
            return View();
        }
    }
}