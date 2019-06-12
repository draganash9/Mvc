using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;

namespace MovieStore.Controllers
{
    public class MovieController : Controller
    {
        public static List<MovieModel> MovieList = new List<MovieModel>
        {
            new MovieModel{
                Id=1,
                Name="Interstellar",
                Genre="Sci-fi",
                Rating=8.7,
                Length=124
            },
            new MovieModel{
                Id=2,
                Name="The Upside",
                Genre="Drama",
                Rating=6.7,
                Length=110
            },
            new MovieModel{
                Id=3,
                Name="Guardians of the galaxy",
                Genre="Sci-fi",
                Rating=7.9,
                Length=124
            },
            new MovieModel{
                Id=4,
                Name="Up",
                Genre="Animation",
                Rating=8.7,
                Length=129
            }
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Movies()
        {
            return View(MovieList);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(MovieModel model)
        {
            MovieList.Add(model);
            return View("Movies",MovieList);
        }
        public IActionResult Edit(int id)
        {
            var movie= MovieList.FirstOrDefault(x => x.Id == id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult UpdateMovie(MovieModel movie)
        {
            var movieIndex = MovieList.FindIndex(m => m.Id == movie.Id);
            MovieList[movieIndex] = movie;
            return View("Movies",MovieList);
        }
        public IActionResult MovieDetails(MovieModel Model)
        {
            var movie = MovieList.FirstOrDefault(m => m.Id == Model.Id);
            return View(movie);
        }
        public IActionResult Remove(int id)
        {
            var movie = MovieList.FirstOrDefault(m => m.Id == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult RemoveMovie(MovieModel movie)
        {
            MovieList.Remove(MovieList[movie.Id]);

            return View("Movies", MovieList);
        }

        public IActionResult File()
        {
            var context = System.IO.File.ReadAllBytes("wwwroot/Movies - moviepdf.pdf");
            return File(context, "application/pdf");
        }
    }
}