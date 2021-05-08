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
<<<<<<< HEAD
=======
         public IActionResult Index()
        {
            return View();
        }
>>>>>>> f1c5185f045a36b16f5f94aae974ceef2e57a8b0

        public IActionResult Carta()
        {
            return View();
        }
<<<<<<< HEAD

               public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
=======
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
>>>>>>> f1c5185f045a36b16f5f94aae974ceef2e57a8b0
