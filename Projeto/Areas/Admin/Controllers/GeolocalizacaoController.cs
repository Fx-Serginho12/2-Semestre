using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Projeto.Areas.Admin.Controllers
{
    [Route("[controller]")]
    public class GeolocalizacaoController : Controller
    {
        private readonly ILogger<GeolocalizacaoController> _logger;

        public GeolocalizacaoController(ILogger<GeolocalizacaoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Geolocalizacao()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}