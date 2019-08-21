using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;
using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Tests.Solutions.FIZ
{
    [TestFixture]
    public class FizSolutionTest
    {
        [TestCase(72, ExpectedResult = "fizz")]
        public string TestForMultipleOf3(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

        [TestCase(43, ExpectedResult = "fizz")]
        public string TestForNumberContains3(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

        [TestCase(10, ExpectedResult = "buzz")]
        public string TestForMultipleOf5(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

        [TestCase(52, ExpectedResult = "buzz")]
        public string TestForNumberContains5(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

        [TestCase(546, ExpectedResult = "fizz buzz")]
        public string TestForNumberMultipleOf3AndContains5(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

        //[TestCase(15, ExpectedResult = "fizz buzz")]
        //public string TestForMultipleOf3And5(int x)
        //{
        //    return FizzBuzzSolution.FizzBuzz(x);
        //}

        [TestCase(112, ExpectedResult = "112")]
        public string TestForDefault(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

        //[TestCase(30, ExpectedResult = "deluxe")]
        //public string TestForDeluxeOnly(int x)
        //{
        //    return FizzBuzzSolution.FizzBuzz(x);
        //}

        [TestCase(36, ExpectedResult = "fizz deluxe")]
        public string TestForFizzDeluxe(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

        [TestCase(231, ExpectedResult = "fizz fake deluxe")]
        public string TestForFizzFakeDeluxe(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

        [TestCase(50, ExpectedResult = "buzz deluxe")]
        public string TestForBuzzDeluxe(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

        [TestCase(55, ExpectedResult = "buzz fake deluxe")]
        public string TestForBuzzFakeDeluxe(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

        [TestCase(345, ExpectedResult = "fizz buzz fake deluxe")]
        public string TestForFizzBuzzFakeDeluxe(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }


        [TestCase(360, ExpectedResult = "fizz buzz deluxe")]
        public string TestForFizzBuzzDeluxe(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

        //[TestCase(1, ExpectedResult = "fake deluxe")]
        //public string TestForFakeDeluxeOnly(int x)
        //{
        //    return FizzBuzzSolution.FizzBuzz(x);
        //}
    }
}
