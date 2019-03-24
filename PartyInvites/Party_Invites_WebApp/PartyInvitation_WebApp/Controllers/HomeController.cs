using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvitation_WebApp.Models;

namespace PartyInvitation_WebApp.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{return "Hello World";}
        public ViewResult Index()  //adding data of view in HomeController.cs using ViewBag object 
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Afternoon";
            return View("MyView");
        }
    }
}
