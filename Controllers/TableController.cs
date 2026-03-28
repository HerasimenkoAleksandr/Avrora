using Avrora.Models;
using Avrora.Models.Enums;
using Avrora.Models.Price;
using Avrora.Models.TableModel;
using Avrora.Services.Hash;
using Microsoft.AspNetCore.Mvc;

namespace Avrora.Controllers
{
    public class TableController : Controller
    {
        //Залежність від служби заявляється як private readonly поле

        private readonly IHashService _hashService; // DIP-тип зплужності це інтерфуйс

        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _configuration;

        //Конструктор зазначає необхідні залежності, їх передає - Resolve (Injector)

        public TableController(ILogger<HomeController> logger, IHashService hashService, IConfiguration configuration)
        {
            _logger = logger;
            _hashService = hashService;
            _configuration = configuration;
        }


        public IActionResult Table()
        {
            TableViewModel table = new();


                  return View(table);
        }
    }
}
