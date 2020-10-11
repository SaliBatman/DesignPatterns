using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod.Models
{
    public class BikeModel : IFactory
    {
        public void Drive(int km) 
        {

            Console.WriteLine($"this bike drived {km} km");
        }
    }
}
