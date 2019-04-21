using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly_webapp.Models;

namespace Vidly_webapp.Controllers
{
    public class MoviesController : Controller
    {
        //get Movies/Random (in url)
        public IActionResult Random()
        {
            Movies movie = new Movies() { Name = "Bee Movie" };

                return View(Movies);
        }
    }
}