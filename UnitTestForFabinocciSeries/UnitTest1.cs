using LogicalProgramme;

namespace UnitTestForFabinocciSeries
{
    [TestClass]
    public class LogicProblemTests
    {
        LogicalProblem logicalProblem;

        [TestInitialize]
        public void Setup()
        {
            logicalProblem = new LogicalProblem();
        }

        [TestMethod]        
        
        [DataRow(8, 55)]
        [DataRow(10,55)]
        [DataRow(9,79)]
        public void Fibonacci_WhenCalled_ReturnsLastFibonacciNumber(int number, int expected)
        {
            int result = LogicalProblem.Fibonacci(number);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5,true)]
        [DataRow(7,true)]
        [DataRow(8,true)]

        public void Prime_WhenNumberCalled_ReturnPrimeNumber(int number, bool expected)
        {
            bool result = LogicalProblem.PrimeNumber(number);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        [DataRow(6, true)]
        [DataRow(5, true)]
        [DataRow(8, false)]
        public void Perfect_WhenNumberCalled_ReturnPerfectNumber(int number, bool expected)
        {
            bool result = LogicalProblem.PerfectNoProgramme(number);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow(668, 868)]
        [DataRow(5436, 6345)]
        [DataRow(88765, 56788)]
        public void Reverse_WhenNumberCalled_ReturnReverseNumber(int number, int expected)
        {
            int result = LogicalProblem.Reversenumber(number);

            Assert.AreEqual(expected, result);
        }

    }
}