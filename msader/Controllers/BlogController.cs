using Microsoft.AspNetCore.Mvc;

namespace msader.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
