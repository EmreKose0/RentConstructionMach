using Microsoft.AspNetCore.Mvc;

namespace RentConstructionMach.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
