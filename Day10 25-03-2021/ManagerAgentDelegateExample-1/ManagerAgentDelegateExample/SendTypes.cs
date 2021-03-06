using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerAgentDelegateExample
{
    public class SendTypes
    {
        public static bool SendByEmail(Message m) {
            Console.WriteLine($"\"{m.Content}\" is delivered by E-MAIL to \"{m.Address}\"");
            return true;
        }
        public static bool SendByCar(Message m)
        {
            Console.WriteLine($"\"{m.Content}\" is delivered by Car to \"{m.Address}\"");
            return true;
        }
        public static bool SendByShip(Message m)
        {
            Console.WriteLine($"\"{m.Content}\" is delivered by SHIP to \"{m.Address}\"");
            return false;
        }
    }
}
