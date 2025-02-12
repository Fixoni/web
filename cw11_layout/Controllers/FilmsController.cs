using cw11_layout.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw11_layout.Controllers
{
    public class FilmsController : Controller
    {
        private readonly MySqlFilmRepo _filmRepo;
        private readonly string? _connectionString;

        public FilmsController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("mysql");
            _filmRepo = new MySqlFilmRepo(_connectionString);
        }

        public ActionResult List()
        {
            return View(_filmRepo.GetAllFilms());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MyFilm film)
        {
            if (ModelState.IsValid)
            {
                _filmRepo.AddFilm(film);
                return RedirectToAction("List");
            }
            return View(film);
        }

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                _filmRepo.DeleteFilm(id.Value);
            }
            return RedirectToAction("List");
        }
    }
}