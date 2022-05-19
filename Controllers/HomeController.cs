using ConcesionarioChallenge11.Data;
using ConcesionarioChallenge11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConcesionarioChallenge11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ConcesionarioChallenge11Context _context;

        public HomeController(ILogger<HomeController> logger,ConcesionarioChallenge11Context db)
        {
            _logger = logger;
            _context = db;
        }

        public IActionResult Index()
        {
           
            var consulta = _context.Concesionario.Find(1);

            return View(consulta);
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
