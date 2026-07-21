using Microsoft.AspNetCore.Mvc;

namespace GeoApp.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
