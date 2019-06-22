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
       public ActionResult Index()
        
        {
            int hour = DateTime.Now.Hour;
           // ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Доброго дня";

            if (hour < 12 & hour > 5)
            {
                ViewBag.Greeting = "Доброе утро";
            }

           else if (hour >= 12 & hour < 17)
            {
                ViewBag.Greeting = "Доброе дня";
            }

            else if (hour < 17 | hour <22)
            {
                ViewBag.Greeting = "Добрый вечер";
            }

           else if (hour >22 & hour < 5)
            {
                ViewBag.Greeting = "Добрый ночи";
            }

                return View();
          //  return "Hello, world!";
        }
    }
}