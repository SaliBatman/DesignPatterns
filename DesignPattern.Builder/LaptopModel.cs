using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public class LaptopModel
    {

        public string Name { get; set; }
        public string Cpu { get; set; }

        public int Ram { get; set; }

        public string Hdd { get; set; }

        public string MainBoard { get; set; }

        public string Color { get; set; }
    }
}
