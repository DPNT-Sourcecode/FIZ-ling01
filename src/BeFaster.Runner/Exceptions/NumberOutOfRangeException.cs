using System;

namespace BeFaster.Runner.Exceptions
{
    public class NumberOutOfRangeException : Exception
    {
        public NumberOutOfRangeException()
            : base("Number has to be between 0 and 100.")
        {
        }
    }
}
