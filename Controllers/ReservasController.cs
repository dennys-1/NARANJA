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
using OfficeOpenXml;
using OfficeOpenXml.Table;

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
           

            var listreservas = _context.Reservas.ToList();
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

        public IActionResult ExportarExcel()
{
    string excelContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
    var reservas = _context.Reservas.AsNoTracking().ToList();
    using (var libro = new ExcelPackage())
    {
        var worksheet = libro.Workbook.Worksheets.Add("Reservas");
        worksheet.Cells["A1"].LoadFromCollection(reservas, PrintHeaders: true);
        for (var col = 1; col < reservas.Count + 1; col++)
        {
            worksheet.Column(col).AutoFit();
        }

        // Agregar formato de tabla
        var tabla = worksheet.Tables.Add(new ExcelAddressBase(fromRow: 1, fromCol: 1, toRow: reservas.Count + 1, toColumn: 5), "Reservas");
        tabla.ShowHeader = true;
        tabla.TableStyle = TableStyles.Light6;
        tabla.ShowTotal = true;

        return File(libro.GetAsByteArray(), excelContentType, "Reservas.xlsx");
    }
}
    }
}
