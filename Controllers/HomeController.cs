using Avrora.Models;
using Avrora.Models.Enums;
using Avrora.Models.Price;
using Avrora.Services.Hash;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.Diagnostics;
using System.Text.Json;

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
           PriceViewModel price = new PriceViewModel();

           return View(price);
        }
        public IActionResult SingUp()
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
