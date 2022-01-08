﻿using CalculatorWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWeb.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
        [HttpPost]
        public string SumAandB(int numA, int numB, string math)
        {
            double result = 0;
            string operation;
            switch (math)
            {
                case "*":
                    result = numA * numB;
                    operation = "Mul";
                    break;
                case "/":
                    result = numA / numB;
                    operation = "Div";
                    break;
                case "+":
                    result = numA + numB;
                    operation = "Sum";
                    break;
                case "-":
                    result = numA - numB;
                    operation = "subs";
                    break;
            }
            return $"Sum={result}";
        }
    }
}
