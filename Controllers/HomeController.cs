using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProyectoRepository _proyectoRepository;
        private readonly ISendgridMailService _sendgridMailService;

        public HomeController(ILogger<HomeController> logger, IProyectoRepository proyectoRepository, ISendgridMailService sendgridMailService)
        {
            _logger = logger;
            _proyectoRepository = proyectoRepository;
            _sendgridMailService = sendgridMailService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            _logger.LogInformation("Este es un mensaje de LOG");

            List<Proyecto> proyectos = _proyectoRepository.GetProyectos().Take(3).ToList();
            HomeIndexViewModel homeIndexModel = new HomeIndexViewModel { proyectos = proyectos };

            return View("Index", homeIndexModel);
        }

        [HttpGet]
        public IActionResult Proyectos()
        {
            List<Proyecto> proyectos = _proyectoRepository.GetProyectos().ToList();
            return View(proyectos);
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto (ContactoViewModel contactoViewModel)
        {

            _sendgridMailService.SendEmail(contactoViewModel);

            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias ()
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
