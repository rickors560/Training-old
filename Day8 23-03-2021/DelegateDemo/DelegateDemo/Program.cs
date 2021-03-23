using System;

namespace DelegateDemo
{
    class Program
    {
        //delegate void myDel(string s);
        static void Main(string[] args)
        {
            //myDel d = new myDel(Notify);
            //abc(d);
            //d = Greet;
            //abc(d);
            BookDB books = new BookDB();
            books.AddBook("Book1", "Author1", 150, true);
            books.AddBook("Book2", "Author2", 250, true);
            books.AddBook("Book3", "Author3", 350, true);
            books.AddBook("Book4", "Author4", 450, true);
            ProcessBookCallbackDelegate d = new ProcessBookCallbackDelegate(SellBook);
            d += RentBook;
            books.ProcessPaperbackBooks(d);
            

        }
        //static void Notify(string s) {
        //    Console.WriteLine($"Notification: {s}");
        //}
        //static void Greet(string s) {
        //    Console.WriteLine($"Greet: {s}");
        //}
        //static void abc(myDel d) {
        //    d("INDIA");
        //}
        static void SellBook(Book book) {
            Console.WriteLine($"SOLD Title: {book.Title} SOLD Price: {book.Price}");
        }
        static void RentBook(Book book)
        {
            Console.WriteLine($"\n---------RENT Title: {book.Title} RENT Price: {book.Price}\n");
        }
    }
}
