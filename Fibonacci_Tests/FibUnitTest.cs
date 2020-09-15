using Microsoft.VisualStudio.TestTools.UnitTesting;

using Fibonacci;

namespace Fibonacci_Tests
{
    [TestClass]
    public class FibUnitTest
    {
        [TestMethod]
        public void FibTests()
        {
            Assert.AreEqual(Program.Fib(5), 5);

            Assert.AreEqual(Program.Fib(20), 6765);

            Assert.AreEqual(Program.Fib(0), 0);

            Assert.AreEqual(Program.Fib(-7), -1);
        }
    }
}
