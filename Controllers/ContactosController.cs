
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

    
    public class ContactosController : Controller
    {
        private readonly MvcContext _context;

        public ContactosController(MvcContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          
            Console.Write("entroo Index");
            return View();
        }

  public async Task<IActionResult> Contactos()
        {
              Console.Write("entroo Contactos");
             var contactos = from q in _context.Contactos
                 select q;

           
            
            return View(await contactos.ToListAsync());
        }


      
       
         public ActionResult Delete(int dato)
        {
             Console.WriteLine("entroo Delete" + dato);
             Contactos contactos =  _context.Contactos.Find(dato);
            _context.Contactos.Remove(contactos);
            _context.SaveChanges();

            return RedirectToAction("Contactos");
        }

    }

    

}
