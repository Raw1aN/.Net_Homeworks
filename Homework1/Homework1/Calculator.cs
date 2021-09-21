namespace Homework1
{
    public static class Calculator
    {
        public static int Calculate(string operation, int val1, int val2)
        {
            var result = operation switch
            {
                "+" => val1 + val2,
                "-" => val1 - val2,
                "*" => val1 * val2,
                "/" => val1 / val2
            };
            return result;
        }
    }
}