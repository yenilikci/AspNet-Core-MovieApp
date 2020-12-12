﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Data;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ProductRepository.Movies
            //CategoryRepository.Categories

            //MovieCategoryModel model = new MovieCategoryModel();
            //model.Categories = CategoryRepository.Categories;
            //model.Movies = MovieRepository.Movies;
            return View(MovieRepository.Movies);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            //MovieCategoryModel model = new MovieCategoryModel();
            //model.Categories = CategoryRepository.Categories;
            //model.Movie = MovieRepository.GetById(id);

            return View(MovieRepository.GetById(id));
        }
    }
}
