using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.FIZ
{
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
     class NumberElement : Element
    {
        private int num;
       
        public NumberElement(int num)
        {
            this.num = num;
        }
        
        public  int Num {
            get { return this.num; }
            set { this.num = value; }
        }
        public string FizzMsg { get; set; }
        public string BuzzMsg { get; set; }

        public string DeluxeMsg { get; set; }

        public string Msg { get; set; }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
