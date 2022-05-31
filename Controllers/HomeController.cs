using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NiceTry.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace NiceTry.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        

        [HttpGet]
        public ViewResult SecondPage()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SecondPage(GuestResponse guestResponce)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponce(guestResponce);
                return View("Thanks", guestResponce);
            }
            else 
            {
                return View();
            }

        }
        
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where( r => r.willAttend == true));
        }

    }
}
