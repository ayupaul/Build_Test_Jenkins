﻿using Build_Test_Jenkins.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Build_Test_Jenkins.Controllers
{
    public class HomeController : Controller
    {
      

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}