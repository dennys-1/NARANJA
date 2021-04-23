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
    public class CartaController : Controller
    {
        private readonly ILogger<CartaController> _logger;

        public CartaController(ILogger<CartaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Carta()
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
