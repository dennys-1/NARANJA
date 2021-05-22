using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using NARANJA.Data;
using NARANJA.Models;
namespace NARANJA.Controllers
{
    public class PlatosController :Controller
    {
        
        private readonly ILogger<PlatosController> _logger;
        
        private readonly ApplicationDbContext _context;

        public PlatosController(ILogger<PlatosController> logger,
        ApplicationDbContext context)
        {
            _logger = logger;
            _context=context;
        }

        public IActionResult Platos()
        { 
            var listplatos = _context.DataPlatos.ToList();
            ViewData["message"]="";
            return View(listplatos);
        }
        
         
    }
}