using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework1;

namespace Homework1Tests
{
    [TestClass]
    public class Homework1Tests
    {
        [TestMethod]
        public void WrongCalculatorOperation()
        {
            var args = new[] {"1", ".", "3"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 2);
        }
        [TestMethod]
        public void WrongCalculatorSyntax()
        {
            var args = new[] {"-","-", "-"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void AllIsGoodWithAddition()
        {
            var args = new[] {"10", "+", "10"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void AllIsGoodWithSubtraction()
        {
            var args = new[] {"10", "-", "10"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void AllIsGoodWithMultiply()
        {
            var args = new[] {"10", "*", "10"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void AllIsGoodWithDivision()
        {
            var args = new[] {"10", "/", "10"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void WrongArgsLength()
        {
            var args = new[] {"10", "/", "10", "10"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 5);
        }
        
        [TestMethod]
        public void DivisionByZero()
        {
            var args = new[] {"10", "/", "0"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 4);
        }

    }
}