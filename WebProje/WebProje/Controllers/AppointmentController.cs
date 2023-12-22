using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class HastaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
