using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.SUM
{
    public static class SumSolution
    {
        public static int Sum(int x, int y)
        {
            if (!validInput(x, y))
                throw new NumberOutOfRangeException();

            return (x + y);
        }
        private static bool validInput(int x, int y)
        {
            bool isValid = true;

            if ((x >= 0 && x <= 100) && (y >= 0 && y <= 100))
                return isValid;

            isValid = false;
            return isValid;
        }
    }
}
