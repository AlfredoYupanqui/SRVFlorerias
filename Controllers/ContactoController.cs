using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SRVFlorerias.Models;

namespace SRVFlorerias.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Index()
        {
            return View();  

        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

    }
}