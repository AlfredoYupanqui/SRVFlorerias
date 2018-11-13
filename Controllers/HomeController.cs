using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SRVFlorerias.Context;
using SRVFlorerias.Models;

namespace SRVFlorerias.Controllers
{
    public class HomeController : Controller
    {
        private readonly SRVFloreriasContext _context;
        public HomeController(SRVFloreriasContext _context)
        {
            this._context = _context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        public IActionResult GestionEmpleado()
        {
            Empleado obj = new Empleado();

            ViewData["Message"] = "Pagina de Gestión de Empleados.";

            return View();
        }

        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
