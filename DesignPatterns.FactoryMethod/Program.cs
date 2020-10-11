using DesignPatterns.FactoryMethod.Models;
using System;

namespace DesignPatterns.FactoryMethod
{

    class Program
    {
        static void Main(string[] args)
        {
            var objectFactory = new ConcriteFactory();
            var car = objectFactory.GetVehiclesName("Car");
            car.Drive(10);
            var bike = objectFactory.GetVehiclesName("Bike");
            bike.Drive(5);
            Console.Read();
        }
    }
}
