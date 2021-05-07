using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NARANJA.Models;

namespace NARANJA.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly ILogger<AdministradorController> _logger;

        public AdministradorController(ILogger<AdministradorController> logger)
        {
            _logger = logger;
        }
         public IActionResult Index()
        {
            return View();
        }

        public IActionResult Carta()
        {
            return View();
        }
         public IActionResult Reservas()
        {
            return View();
        }
         public IActionResult Horario()
        {
            return View();
        }
        public IActionResult Miperfil()
        {
            return View();
        }
        


       
    }
}
