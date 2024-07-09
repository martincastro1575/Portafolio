using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IRepositorioPersona repositorioPersonas;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos, IRepositorioPersona repositorioPersonas)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this.repositorioPersonas = repositorioPersonas;
        }

        public IActionResult Index()
        {


            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var personas = repositorioPersonas.ObtenerPersonas().Take(3).ToList();

            
            
            var modelo = new HomeIndexViewModel()
            {
                Personas = personas,
                Proyectos = proyectos

            };

            
            return View("Index", modelo);
        }

        

        

        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();
            return View("Proyectos",proyectos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}