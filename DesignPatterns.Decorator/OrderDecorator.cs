using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class OrderDecorator : OrderWrapper
    {

        protected OrderWrapper _order;
        public OrderDecorator(OrderWrapper order)
        {

            _order = order;
        }
        public override int CalculateOrder()
        {

            return _order.CalculateOrder();
        }
    }
}
