﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RestaurantList()
        {
            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {


                restaurantList.Add(string.Format("#{0}: {1} {2} {3} {4} {5}", r.RestaurantRanking, r.RestaurantName, r.FavoriteDish, r.RestaurantAddress, r.RestaurantPhone, r.WebsiteLink));
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult AddRestaurant()
        {


            return View();
        }
        [HttpPost]
        public IActionResult AddRestaurant(Restaurant appResponse)
        {
            TempStorage.AddApplication(appResponse);

            return View("Confirmation", appResponse);
        }

        public IActionResult ViewRestaurants()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
