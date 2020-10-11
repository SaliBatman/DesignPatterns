using DesignPatterns.FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
   public abstract class ObjectFactory
    {
        public abstract IFactory GetVehiclesName(string name);
    }
}
