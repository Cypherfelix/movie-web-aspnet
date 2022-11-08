using Microsoft.AspNetCore.Mvc;
using MovieWeb.Data;

namespace MovieWeb.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbInitializer _appDbInitializer;

        public MoviesController()
        {
            _appDbInitializer = AppDbInitializer.Instance;
        }

        public IActionResult Index()
        {
            var data = _appDbInitializer.TrendingMovies;
            return View(data);
        }

        //GET: Movies/Details/1
        public IActionResult Details(int id)
        {
            var movieDetail = _appDbInitializer.GetMovieById(id);
            return View(movieDetail);
        }
    }
}
