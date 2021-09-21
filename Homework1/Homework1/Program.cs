using System;
using System.Linq;

namespace Homework1
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var parseResult = Parser.TryParseArguments(
                args, 
                out var val1, 
                out var operation,
                out var val2);

            if (parseResult != 0)
            {
                return parseResult;
            }

            var result = Calculator.Calculate(operation, val1, val2);

            Console.WriteLine($"{args[0]}{args[1]}{args[2]}={result}");
            return 0;
        }
    }
}