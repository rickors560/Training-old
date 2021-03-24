using System;

namespace demo
{
    class Program
    {
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            Phone ph = new Phone();
            Email email = new Email();
            InPerson inperson = new InPerson();
            MyDelegate m = ph.CallByPhone;
            m();
        }
    }
}
