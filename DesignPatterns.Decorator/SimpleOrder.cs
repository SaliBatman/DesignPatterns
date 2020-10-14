using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class SimpleOrder : OrderWrapper
    {
        public override int CalculateOrder()
        {
            return Products.Sum(s => s.Price);
        }
    }
}
