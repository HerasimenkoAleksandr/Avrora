using System.Diagnostics;
using Avrora.Models;
using Avrora.Services.Hash;
using Microsoft.AspNetCore.Mvc;

namespace Avrora.Controllers
{
    public class HomeController : Controller
    {

        //Залежність від служби заявляється як private readonly поле
        
        private readonly IHashService _hashService; // DIP-тип зплужності це інтерфуйс

        private readonly ILogger<HomeController> _logger;

        //Конструктор зазначає необхідні залежності, їх передає - Resolve (Injector)

        public HomeController(ILogger<HomeController> logger, IHashService hashService)
        {
            _logger = logger;
            _hashService = hashService;
        }

        public IActionResult Index()
        {
            return View();
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
