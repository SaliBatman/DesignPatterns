using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod.Models
{
    public class CarModel : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine($"this car drived {km} km");
        }
    }
}
