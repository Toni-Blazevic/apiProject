using Microsoft.AspNetCore.Mvc;

namespace Projekt.API.Controllers
{
    public class TerrainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
