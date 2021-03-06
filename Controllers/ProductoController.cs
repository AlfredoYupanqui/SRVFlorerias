using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SRVFlorerias.Context;
using SRVFlorerias.Models;

namespace SRVFlorerias.Controllers
{
    public class ProductoController : Controller
    {
        private readonly SRVFloreriasContext _context;

        public ProductoController(SRVFloreriasContext _context)
        {
            this._context = _context;
        }
        public IActionResult Index()
        {
            ViewData["Message"] = "Gestionar.";
            return View();
        }
        public IActionResult RegistrarProducto()
        {
            Producto obj = new Producto();

            ViewData["Message"] = "Gestionar productos.";
            return View();
        }   
        public IActionResult Lista()
        {
            var catalogo = new CatalogoProductos();
            var productos = catalogo.Listar();
          
          return View(productos);
        }
        public IActionResult Ver(int id)
        {
            var catalogo = new CatalogoProductos();
            var producto = catalogo.ObtenerPorId(id);

            ViewData["producto"] = producto;

          return View(producto);
        }
        public IActionResult Mantenimiento()
        {
          return View();
        }
    }
}