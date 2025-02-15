using Microsoft.AspNetCore.Mvc;

namespace msader.Controllers
{
    public class TecnologiaController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
