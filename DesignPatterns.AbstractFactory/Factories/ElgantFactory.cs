using DesignPatterns.AbstractFactory.AbstractProducts;
using DesignPatterns.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Factories
{
    class ElgantFactory : ClothesFactory
    {
        public override Pants CreatePants()
        {
            return new FormalPant();
        }

        public override Shirts CreateShirts()
        {
            return new Dress();
        }
    }
}
