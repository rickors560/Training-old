using System;
using System.Collections.Generic;
using System.Text;

namespace LinQDemo
{
    public class Distributer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PId { get; set; }
        public Distributer(int dId, string n, int pId)
        {
            Id = dId;
            Name = n;
            PId = pId;
        }
    }
}
