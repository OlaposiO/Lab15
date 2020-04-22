using Lab15._2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;



namespace Lab15._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly IDAL dal;

        public MovieController(IDAL dal)
        {
            this.dal = dal;
        }

        [HttpGet]
        public Object Get(string? category)
        {
            IEnumerable<Movie> movieList = null;

            if (string.IsNullOrEmpty(category))
            {
                movieList = dal.GetMovieAll();
            }
            else
            {
                movieList = dal.GetMovieByCategory(category);
            }

            if (movieList is null)
            {
                return new { success = false };
            }

            return new { success = true, movieList };

        }

        [HttpGet("random")]
        public Movie GetRandom(string? category)
        {
            Random r = new Random();
            Movie[] movies = null;

            if (string.IsNullOrEmpty(category))
            {
                movies = dal.GetMovieAll().ToArray();
            }
            else
            {
                movies = dal.GetMovieByCategory(category).ToArray();
            }



            Movie randomMovie = movies[r.Next(movies.Length)];
            return randomMovie;

        }


    }
}