using Microsoft.AspNetCore.Mvc;

namespace DotNetCP.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
}
