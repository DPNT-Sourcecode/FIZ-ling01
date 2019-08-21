using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            NumberElement e = new NumberElement(number);
            e.Accept(new FizzVisitor());
            e.Accept(new BuzzVisitor());
            e.Accept(new DeluxeVisitor());
            e.Accept(new DefaultVisitor());

            return e.Msg;
        }
    }
}
