using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo2
{  
    public class Calculator
    {
        public delegate decimal CalDelegate();

        public decimal Num1 { get; set; }
        public decimal Num2 { get; set; }
        public decimal add() {
            decimal res = Num1 + Num2;
            return res;
        }
        public decimal sub()
        {
            decimal res = Num1 - Num2;
            return res;
        }
        public decimal mul()
        {
            decimal res = Num1 * Num2;
            return res;
        }
        public decimal div()
        {
            decimal res = Num1 / Num2;
            return res;
        }
        public void printRes(CalDelegate d)
        {
            Console.WriteLine(d());
        }

    }
}
