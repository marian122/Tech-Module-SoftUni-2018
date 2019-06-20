using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CalculatorApp.Controllers;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        [HttpPost]
        public IActionResult Calculate(Calculator calculator)
        {
            if (calculator.RightOperand == 0 && calculator.Operator == "/")
            {
                TempData["WrongDivider"] = "Can not divide by 0";
            }
            else
            {
                calculator.CalculateResult();
                History.HistoryOfCalculations.Add(calculator);
            }

            return RedirectToAction("index", calculator);
        }
        [HttpGet]
        public IActionResult HistoryCalculations()
        {
            return View(History.HistoryOfCalculations);
        }
    }
}
