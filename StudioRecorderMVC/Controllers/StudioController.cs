using Microsoft.AspNetCore.Mvc;

namespace StudioRecorderMVC.Controllers
{
    public class StudioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
