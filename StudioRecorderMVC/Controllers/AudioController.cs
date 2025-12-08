using Microsoft.AspNetCore.Mvc;

namespace StudioRecorderMVC.Controllers
{
    public class AudioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
