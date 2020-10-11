using DesignPatterns.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public abstract class ClothesFactory
    {
        public abstract Shirts CreateShirts();

        public abstract Pants CreatePants();
    }
}
