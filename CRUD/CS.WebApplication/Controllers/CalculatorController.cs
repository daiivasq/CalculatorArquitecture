using CS.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS.WebApplication.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OperationsCalculatorModel model)
        {
            decimal Result = 0;

            if (model.Operator == "+")
            {
                Result = model.Parameter1 + model.Parameter2;
            }
            else if (model.Operator == "-")
            {
                Result = model.Parameter1 - model.Parameter2;
            }
            else if (model.Operator == "*")
            {
                Result = model.Parameter1 * model.Parameter2;
            }
            else if (model.Operator == "÷")
            {
                Result = model.Parameter1 / model.Parameter2;
            }
            else if (model.Operator == "%")
            {
                Result = model.Parameter1 % model.Parameter2;
            }
            else if (model.Operator == "^")
            {
                var operation = Math.Pow((double)model.Parameter1, (double)model.Parameter2);
                Result = (decimal)operation;
            }
            else
            {
                Result = -1;
            }

            model.Result = $"El resultado de {model.Parameter1} {model.Operator} {model.Parameter2} = {Result}";
            return View(model);
        }
    }
}