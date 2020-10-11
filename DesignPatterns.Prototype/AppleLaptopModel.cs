using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    public class AppleLaptopModel : ILaptopModel
    {
        public string Name { get; set; }

        public string Hdd { get; set; }
        public string Cpu { get; set; }

        public ILaptopModel Clone()
        {
            //shallow
            return (ILaptopModel)MemberwiseClone();

            //deep 

           // return  this.Clone();
        }
    }
}
