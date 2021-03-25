using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment9Movies.Models;
using Assignment9Movies.Models.ViewModels;

namespace Assignment9Movies.Controllers
{
    public class HomeController : Controller
    {
        private IMoviesRepository _repository;
        private readonly ILogger<HomeController> _logger;
        private MoviesContext _context { get; set; }
       
        public HomeController(ILogger<HomeController> logger, MoviesContext con, IMoviesRepository respository)
        {
            //connecting the DB to the app
            _logger = logger;
            _repository = respository;
            _context = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movies movie)
        {
            if (movie.Title == "Independence Day")
            {
                ModelState.AddModelError(movie.Title, "Error");
                return View(movie);
            }
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return View("ConfirmationPage", movie);
            }
            return View(movie);
        }

        [HttpPost]
        public IActionResult DeleteMovie(long movieId)
        {
            _context.Movies.Remove(_context.Movies.First(m => m.MovieId == movieId));
            _context.SaveChanges();
            return View("Movies", _context.Movies);
        }

        //edit a movie entry
        [HttpPost]
        public IActionResult EditView(long moviesId)
        {
            Movies movie = _context.Movies.Where(m => m.MovieId == moviesId).First();
            movie.Edited = true;

            return View("EditMovie", movie);
        }
        [HttpPost]
        public IActionResult EditMovie(Movies movie)
        {
            _context.Update(movie);

            _context.SaveChanges();

            return View("Movies", _context.Movies);
        }

        //[HttpPost]
        //public IActionResult EditView(long movieId)
        //{
        //    Movies movie = _context.Movies.Where(m => m.MovieId == movieId).First();
        //    return View("EditMovie", movie);
        //}

        //public IActionResult EditMovie(Movies movie)
        //{
        //    _context.Update(movie);

        //    _context.SaveChanges();

        //    return View("Movies", _context.Movies);
        //}


        public IActionResult Movies()
        {
            return View(_context.Movies);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}