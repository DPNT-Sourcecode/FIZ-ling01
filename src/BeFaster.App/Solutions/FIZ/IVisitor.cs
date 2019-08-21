using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.FIZ
{
    interface IVisitor
    {
        void Visit(Element element);
    }

    class FizzVisitor :IVisitor
    {
        public void Visit(Element element)
        {
            NumberElement numberElement = element as NumberElement;

            //check if eligible for "fizz" display
            if (((numberElement.Num % 3) == 0 || numberElement.Num.ToString().Contains("3")))
                numberElement.FizzMsg = "fizz";
        }
    }

    class BuzzVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            NumberElement numberElement = element as NumberElement;

            //check if eligible for "buzz" display
            if ((numberElement.Num % 5) == 0 || (numberElement.Num.ToString().Contains("5")))
                numberElement.BuzzMsg = "buzz";
        }
    }

    class DeluxeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            NumberElement numberElement = element as NumberElement;

            if (((numberElement.Num % 3) == 0 && (numberElement.Num.ToString().Contains("3")))
                || ((numberElement.Num % 5) == 0 && (numberElement.Num.ToString().Contains("5")))
                )
            {
                if (numberElement.Num % 2 == 0)
                    numberElement.DeluxeMsg = "deluxe";
                else
                    numberElement.DeluxeMsg = "fake deluxe";
            }

        }
        private static bool isAllDigitSame(int x)
        {
            int digit = x % 10;
            while (x>0)
            {
                if (x % 10 != digit) return false;
                x = x / 10;
            }
            return true;
        }
    }

    class DefaultVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            NumberElement numberElement = element as NumberElement;

            if (numberElement.FizzMsg == null && numberElement.BuzzMsg == null && numberElement.DeluxeMsg == null)
                numberElement.Msg = numberElement.Num.ToString();
            else if (numberElement.BuzzMsg == null)
                numberElement.Msg = numberElement.FizzMsg + " " + numberElement.DeluxeMsg;
            else
            {
                numberElement.Msg = numberElement.FizzMsg + " "
                                   + numberElement.BuzzMsg + " "
                                   + numberElement.DeluxeMsg;

            }

            numberElement.Msg = numberElement.Msg.Trim();
        }
    }
}
