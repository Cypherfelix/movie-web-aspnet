using Microsoft.AspNetCore.Mvc;

namespace MovieWeb.Controllers
{
    public class VideoControler : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
