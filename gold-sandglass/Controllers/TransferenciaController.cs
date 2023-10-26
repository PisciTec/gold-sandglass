using Microsoft.AspNetCore.Mvc;

namespace gold_sandglass.Controllers
{
    public class TransferenciaController : Controller
    {
        public IActionResult Criacao()
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
