﻿using System;
using System.Linq;

namespace WordCountUsingLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language. Traditionally, queries against data are expressed as simple strings without type checking at compile time or IntelliSense support. Furthermore, you have to learn a different query language for each type of data source: SQL databases, XML documents, various Web services, and so on. With LINQ, a query is a first-class language construct, just like classes, methods, events. You write queries against strongly typed collections of objects by using language keywords and familiar operators. The LINQ family of technologies provides a consistent query experience for objects (LINQ to Objects), relational databases (LINQ to SQL), and XML (LINQ to XML).";
            char[] delimiters = {' ',',','(',')','-','!','?','/','&'};
            string word = "LINQ";
            var st = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            var a = st.Where((x) => x.Equals(word)).Select(x => x);
            Console.WriteLine($"\"{word}\" Count in Paragraph using Lambda Expression : "+a.ToList().Count());

            var b = from w in st where w.Equals(word) select w;
            Console.WriteLine($"\"{word}\" Count in Paragraph using LINQ Query : " + b.ToList().Count());
        }
    }
}
