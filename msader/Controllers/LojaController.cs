using Microsoft.AspNetCore.Mvc;

namespace msader.Controllers
{
    public class LojaController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
