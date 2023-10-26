using gold_sandglass.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace gold_sandglass.Controllers
{
    public class CarteiraController : Controller
    {
        [HttpPost]
        public IActionResult Criacao([FromBody] Carteira carteira)
        {



            return View();
        }
        public IActionResult Atualizacao()
        {
            return View();
        }

        public IActionResult Remocao()
        {
            return View();
        }

        public IActionResult TodasMovimentaocoes()
        { 
            return View(); 
        }
    }
}
