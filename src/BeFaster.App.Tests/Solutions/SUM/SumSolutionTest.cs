using BeFaster.App.Solutions.SUM;
using NUnit.Framework;
using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class SumSolutionTest
    {
        [TestCase(1, 1, ExpectedResult = 2)]
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(-1, 1)]
        public void TestNumbersValidationSum(int x, int y)
        {
            try
            {
                int n = SumSolution.Sum(x, y);
            }
            catch (NumberOutOfRangeException e)
            {
                Assert.Pass(e.Message);
            }
        }
    }
}
