using System;
using System.Linq;

namespace Homework1
{
    static internal class Parser
    {
        private static readonly string[] SupportedOperations = {
            "+",
            "-",
            "*",
            "/"
        };

        public static int TryParseArguments(string[] args, out int val1, out string operation, out int val2)
        {
            var isVal1Int = int.TryParse(args[0], out val1);
            operation = args[1];
            var isVal2Int = int.TryParse(args[2], out val2);

            if (args.Length != 3)
            {
                Console.WriteLine($"Wrong args length");
                return 5;
            }
            if (!isVal1Int || !isVal2Int)
            {
                Console.WriteLine($"{args[0]}{args[1]}{args[2]} is not a valid calculation syntax");
                return 1;
            }

            if (!SupportedOperations.Contains(operation))
            {
                Console.WriteLine(
                    $"{args[0]}{args[1]}{args[2]} is not a valid calculation syntax. "
                    + $"Supported operations are "
                    + $"{SupportedOperations.Aggregate((c, n) => $"{c} {n}")}");
                return 2;
            }

            if (operation == "/" && args[2]=="0")
            {
                Console.WriteLine(($"Calculator can't devide on 0"));
                return 4;
            }

            return 0;
        }
    }
}