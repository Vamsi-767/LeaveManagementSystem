using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Looks for Views/Test/Index.cshtml
        }

        public IActionResult About()
        {
            return View(); // Looks for Views/Test/About.cshtml
        }
    }
}
