using MRent.Models;
using MRent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRent.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                //new Movie { Id = 1, Name="Nai Na Vannu La"},
                //new Movie { Id = 2, Name="Terminator 2"},
                //new Movie { Id = 3, Name="Gau Khane Katha"},
                //new Movie { Id = 4, Name="Jiban Sangini"}
            };

            var viewModel = new MovieViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        public ActionResult Details(int Id)
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name="Nai Na Vannu La"},
                new Movie { Id = 2, Name="Terminator 2"},
                new Movie { Id = 3, Name="Gau Khane Katha"},
                new Movie { Id = 4, Name="Jiban Sangini"}
            };

            foreach (var movie in movies)
            {
                if (movie.Id == Id)
                {
                    return View(movie);
                }
            }
            return HttpNotFound();
        }


        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer  {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue) pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}