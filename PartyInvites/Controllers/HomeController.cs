using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int currentHour = DateTime.Now.Hour;
            string greeting = "Hello";
            if (currentHour < 12) greeting = "Good Morning!";
            else if (currentHour < 18) greeting = "Good Afternoon!";
            else greeting = "Good Evening!";
            ViewBag.Greeting = greeting;
            return View();
        }

        [HttpGet]
        public ViewResult RspvForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RspvForm(GuestLogModel guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to party organizer
                return View("Thanks", guestResponse);
            } else
            {
                return View();
            }
            
        }
    }
}