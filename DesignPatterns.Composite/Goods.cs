using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public abstract class Goods
    {
        protected string Name;
        protected int Price;

        public Goods(string name , int price )
        {
            Name = name;
            Price = price;
        }
        public abstract int CalculatePrice();
    }
}
