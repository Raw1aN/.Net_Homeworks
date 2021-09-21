using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework1;

namespace Homework1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var args = new[] {"1", ".", "3"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var args = new[] {"-","-", "-"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var args = new[] {"10", "+", "10"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var args = new[] {"10", "-", "10"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var args = new[] {"10", "*", "10"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var args = new[] {"10", "/", "10"};
            var result = Program.Main(args);
            Assert.IsTrue(result == 0);
        }
    }
}