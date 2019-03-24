using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Party_Invites_wepApp.Models;

namespace Party_Invites_wepApp.Controllers
{
    public class HomeController : Controller
    {
       public ViewResult Index() //adding data of view in HomeController.cs using ViewBag object 
                  
       {
            int hour = DataTime.Now.Hour;
            ViewBag.Greeting  = hour <12? "Good Morning": "Good Afternoon";
            return View ("MyView");
       }
       
    

    }
}
