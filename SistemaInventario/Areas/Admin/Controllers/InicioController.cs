using Microsoft.AspNetCore.Mvc;

namespace SistemaInventario.Areas.Admin.Controllers
{
    public class InicioController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
