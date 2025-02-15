using Microsoft.AspNetCore.Mvc;

namespace msader.Controllers
{
    public class FotografiaController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
