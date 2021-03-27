using System;
using System.Collections.Generic;
using System.Text;

namespace LinQDemo
{
    public class Cal<T>
    {
        public T echo { get; set; }
        public void Display(Action t) {
            t();
        }
    }
}