using System;

namespace SimpleExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int,int> sq = (x) => x * x;
            Console.WriteLine(sq(7));

            System.Linq.Expressions.Expression<Func<int, int>> e = (x) => x * x ;
            Console.WriteLine(e);

            var a = e.Compile();
            Console.WriteLine(a(5)); 
        }
    }
}