using Microsoft.AspNetCore.Mvc;

namespace YourProject.Controllers
{
    public class EditController : Controller
    {
        public ActionResult Hub() { return View(); }
        public ActionResult Cut() { return View(); }
        public ActionResult Volume() { return View(); }
        public ActionResult Mix() { return View(); }
        public ActionResult Export() { return View(); }
    }
}
