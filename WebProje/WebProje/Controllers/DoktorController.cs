using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class DoktorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
