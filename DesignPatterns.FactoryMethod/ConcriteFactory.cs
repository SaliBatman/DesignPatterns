using DesignPatterns.FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class ConcriteFactory : ObjectFactory
    {
        public override IFactory GetVehiclesName(string name)
        {
            switch (name)
            {
                case "Car": return new CarModel();
                case "Bike": return new BikeModel();
                default:
                    return null;
            }
        }
    }
}
