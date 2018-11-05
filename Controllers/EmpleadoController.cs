using System;
EmpleadoController.cs

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SRVFlorerias.Models;

namespace SRVFlorerias.Controllers
{
    public class EmpleadoController : Controller
    {

         public IActionResult Index()
        {
            return View();
        }


   public IActionResult GestionEmpleado()
        {
            
            Empleado obj = new Empleado();

            ViewData["Message"] = "Pagina de Gestión de Empleados.";

            return View();
        }
        

    }
    
}

