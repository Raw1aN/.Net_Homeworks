using System;

namespace Classwork_26._10._21.Models.Calculator
{
    public class Calculator : ICalculator
    {
        public string Calculate(string val1, string operation, string val2)
        {
            var val1Double = double.TryParse(val1, out var valu1);
            var val2Double = double.TryParse(val2, out var valu2);
            if (val1Double == false || val2Double == false)
                return "Wrong arguments";
            var value1 = double.Parse(val1);
            var value2 = double.Parse(val2);
            if (val2 == "0" & operation == "/")
                return "Divide by zero";
            var result = operation switch
            {
                "+" => (value1 + value2).ToString(),
                "-" => (value1 - value2).ToString(),
                "*" => (value1 * value2).ToString(),
                "/" => (value1 / value2).ToString(),
                _ => "Wrong operation"
            };
            return result.ToString();
        }
    }
}