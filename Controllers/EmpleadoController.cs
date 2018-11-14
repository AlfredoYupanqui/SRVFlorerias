using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SRVFlorerias.Models;

namespace SRVFlorerias.Models
{

    
    public class EmpleadoController : Controller
    {
        private readonly MvcContext _context;

        public EmpleadoController(MvcContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          
            Console.Write("entroo Index");
            return View();
        }

         public ActionResult Create()
        {
            return View("CrearEmpleado");
        }


  public async Task<IActionResult> Empleado()
        {
              Console.Write("entroo Empleado");
             var empleado = from q in _context.Empleado
                 select q;

           
            
            return View(await empleado.ToListAsync());
        }

   public  async Task<IActionResult> GestionEmpleado()
        {
            Console.Write("entroo GestionEmpleado");
            /* 
            Empleado obj = new Empleado();

            ViewData["Message"] = "Pagina de Gestión de Empleados.";

            return View();
*/
             var empleado = from q in _context.Empleado
                 select q;

           
            
            return View(await empleado.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEmpleado([Bind("nombre","apellidoPaterno","apellidoMaterno","direccion","telefono","correo","TipoEmpleado","numero_documento")] Empleado emp)
        {
          if (ModelState.IsValid)
            {
                _context.Add(emp);
                await _context.SaveChangesAsync();
               return RedirectToAction("GestionEmpleado");
            }
            return View(emp);
        }



         public ActionResult Delete(int dato)
        {
   
            
             Empleado contactos =  _context.Empleado.Find(dato);
            _context.Empleado.Remove(contactos);
            _context.SaveChanges();

            return RedirectToAction("Empleado");
   
        }

         public async Task<IActionResult> Details(string idemple)
        {


            Console.WriteLine("entroo Details" + idemple);

            var empresas = from m in _context.Empleado
                 select m;

            
                empresas= empresas.Where(e => e.numero_documento.Equals(idemple));
                
               
                    }


    }

}

