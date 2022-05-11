using Microsoft.AspNetCore.Mvc;
using Pizzeria_Simone.Models;
using Pizzeria_Simone.Utils;

namespace Pizzeria_Simone.Controllers
{
    
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizza> pizza = PizzaData.GetPizza();
            return View("HomePage", pizza);
        }
    }
}
