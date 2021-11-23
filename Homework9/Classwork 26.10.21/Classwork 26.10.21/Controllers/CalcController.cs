using System.Globalization;
using Classwork_26._10._21.Models.Calculator;
using Microsoft.AspNetCore.Mvc;

namespace Classwork_26._10._21.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Calculate([FromServices] ICalculator calc, string s)
        {
            return Content("0");
            //https://localhost:5001/calc/calculate?s= (2+3) / 12 * 7 + 8 * 9
        }
    }
}