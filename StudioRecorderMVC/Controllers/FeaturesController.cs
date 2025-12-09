using Microsoft.AspNetCore.Mvc;

namespace StudioRecorderMVC.Controllers
{
    public class FeaturesController : Controller
    {
        public IActionResult Recording()
        {
            return View();
        }

        public IActionResult Editing()
        {
            return View();
        }

        public IActionResult Cloud()
        {
            return View();
        }
    }
}
