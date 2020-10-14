using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class DisocuntOrder : OrderDecorator
    {
        public DisocuntOrder(OrderWrapper order) : base(order)
        {
        }


        public override int CalculateOrder()
        {
            var preOrder = base.CalculateOrder();

            return preOrder - (preOrder * 10) / 100;
            
        }

    }
}
