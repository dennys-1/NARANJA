using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using NARANJA.Data;
using NARANJA.Models;

namespace NARANJA.Controllers
{
    public class ReservasController : Controller
    {
        private readonly ILogger<ReservasController> _logger;
        
        private readonly ApplicationDbContext _context;

        public ReservasController(ILogger<ReservasController> logger,
        ApplicationDbContext context)
        {
            _logger = logger;
            _context=context;
        }
         
         public IActionResult Reservas()
        { 
           

            var listreservas = _context.DataReservas.ToList();
            ViewData["message"]="";
            return View(listreservas);
        }
         [HttpGet]
        public IActionResult CrearReserva()
        {
            return View();
        }
         [HttpPost]
        public IActionResult CrearReserva(Reservas objReservas)
        {
            _context.Add(objReservas);
            _context.SaveChanges();
            ViewData["Message"] = "El contacto ya esta registrado";
            return View();
        }

        
    }
}
