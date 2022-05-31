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

        public IActionResult SecondPage()
        {
            return View();
        }


        [HttpGet]
        public ViewResult rsvpform()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponce guestResponce)
        {
            Repository.AddResponce(guestResponce);
            return View("Thanks", guestResponce);


        }

    }
}
