using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class SingleGood : Goods
    {

        public SingleGood(string name , int price) : base(name , price)
        {

        }
        public override int CalculatePrice()
        {
            return Price;
        }
    }
}
