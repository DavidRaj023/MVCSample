using MVCSample.Models;
using MVCSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            if(User.IsInRole(RoleName.CanManageMovies))
                return View("List", movies);
            else
                return View("ReadOnlyList", movies);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            var genre = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genres = genre
            };
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(MovieFormViewModel model)
        {
            _context.Movies.Add(model.Movies);
            _context.SaveChanges();

            return RedirectToAction("index", "Movies");
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return View("Error");

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                Movies = movie,
                Genres = _context.Genres.ToList()
            };
            return View("Update", viewModel);
        }
        public ActionResult Update(MovieFormViewModel model)
        {
            var movieInDb = _context.Movies.Single(m => m.Id == model.Movies.Id);

            movieInDb.Name = model.Movies.Name;
            movieInDb.GenreId = model.Movies.GenreId;
            movieInDb.DateAdded = model.Movies.DateAdded;
            movieInDb.ReleaseDate = model.Movies.ReleaseDate;
            movieInDb.NumberInStock = model.Movies.NumberInStock;
            
            _context.SaveChanges();
            return RedirectToAction("index", "Movies");
        }
    }

}