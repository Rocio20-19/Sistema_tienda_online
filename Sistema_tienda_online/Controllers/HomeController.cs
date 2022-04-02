using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sistema_tienda_online.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_tienda_online.Controllers
{
    public class HomeController : Controller
    {

        private readonly BDTiendaContext _context;
        public HomeController(BDTiendaContext context )
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Producto.ToListAsync());
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
