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
            ViewData["Message"] = "Gestionar Contacto.";
            return View();
        }
        public IActionResult RegistrarContacto()
        {
            Contacto obj = new Contacto();

            ViewData["Message"] = "Gestionar Contacto.";
            return View();
        }   

        public IActionResult Ver(int id)
        {
            ViewData["Message"] = "Gracias por contactarte con nosotros";
            return View();
        }
    }
}