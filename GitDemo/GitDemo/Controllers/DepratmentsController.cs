using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class DepratmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
