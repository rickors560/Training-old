using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
    public class Manager
    {
        public void manage() {
            Console.WriteLine("Task Completed Send Message Now ->");
            Agent agent = new Agent();
            Phone ph = new Phone();
            agent.sendMessage(ph.CallByPhone);
        }
    }
}
