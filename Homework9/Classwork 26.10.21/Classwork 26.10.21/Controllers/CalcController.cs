using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Classwork_26._10._21.Models.Calculator;
using Microsoft.AspNetCore.Mvc;

namespace Classwork_26._10._21.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Calculate( string s)
        {
            var exp = ConvertToExpressionTree(s);
            var result = new CalculatorVisitor().Visit(exp).ToString();
            return Content(result);
            //https://localhost:5001/calc/calculate?s=2 * 3 - 3 * 2
        }
        
        public Expression ConvertToExpressionTree(string s)
        {
            var expressionStack = new Stack<Expression>();
            var operationStack = new Stack<string>();
            var operationStack2 = new Stack<string>();
            var tokens = s.Split();
            foreach (var token in tokens)
            {
                if (double.TryParse(token, out var number))
                {
                    expressionStack.Push(Expression.Constant(number));
                }
                else if (token=="+" || token=="-")
                {
                    while (operationStack.Count != 0 )
                    {
                        GenerateExpression(operationStack.Pop(), expressionStack);
                    }
                    operationStack.Push(token);
                }
                else if (token == "*" || token == "/")
                {
                    operationStack.Push(token);
                }
            }
            foreach (var op in operationStack)
            {
                GenerateExpression(op, expressionStack);
            }
            return expressionStack.Pop();
        }

        public void GenerateExpression(string s, Stack<Expression> stack)
        {
            var val1 = stack.Pop();
            var val2 = stack.Pop();
            switch (s)
            {
                case "+":
                    stack.Push(Expression.Add(val2, val1));
                    break;
                case "-":
                    stack.Push(Expression.Subtract(val2, val1));
                    break;
                case "*":
                    stack.Push(Expression.Multiply(val2, val1));
                    break;
                case "/":
                    stack.Push(Expression.Divide(val2, val1));
                    break;
            }
        }
    }
    public class CalculatorVisitor : ExpressionVisitor
    {
        protected override Expression VisitBinary(BinaryExpression node)
        {
            var first = Task.Run(() => Visit(node.Left));
            var second = Task.Run(() => Visit(node.Right));
            Task.Delay(1000).GetAwaiter().GetResult();
            Task.WhenAll(first, second);

            var firstResult =(ConstantExpression) first.Result;
            var secondResult = (ConstantExpression) second.Result;

            var val1 = (double) firstResult.Value;
            var val2 = (double) secondResult.Value;

            var res = node.NodeType switch
            {
                ExpressionType.Add        => val1 + val2,
                ExpressionType.Subtract   => val1 - val2,
                ExpressionType.Multiply   => val1 * val2,
                ExpressionType.Divide     => val1 / val2,
            };

            return Expression.Constant(res);
        }
    }
}