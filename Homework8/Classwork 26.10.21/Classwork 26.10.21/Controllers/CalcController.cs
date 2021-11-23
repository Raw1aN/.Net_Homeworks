using System.Globalization;
using Classwork_26._10._21.Models.Calculator;
using Microsoft.AspNetCore.Mvc;

namespace Classwork_26._10._21.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Calculate([FromServices] ICalculator calc, string val1, string operation, string val2)
        {
            return Content(calc.Calculate(val1, operation, val2));
            //https://localhost:5001/calc/calculate?val1=1&operation=/&val2=2
        }
    }
}