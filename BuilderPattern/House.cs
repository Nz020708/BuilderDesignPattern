using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class House
    {
        public int Window { get; set; }
        public int Door { get; set; }
        public int Room { get; set; }
        public bool hasGarage { get; set; }
        public bool hasSwimPool { get; set; }
        public bool hasStatues { get; set; }
        public bool hasGarden { get; set; }
    }
}
