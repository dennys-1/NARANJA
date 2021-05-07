using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

  
  namespace NARANJA.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }
    public IActionResult PagoCliente()
        {
            return View();
        }
     public IActionResult BoletaCliente()
        {
            return View();
        }
    }
}