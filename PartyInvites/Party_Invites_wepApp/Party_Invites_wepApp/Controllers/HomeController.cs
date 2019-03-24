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
    {public ViewResult Index()
        {
            return View ("MyView");
        }
    }
}
