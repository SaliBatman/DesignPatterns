using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public abstract class OrderWrapper
    {
        protected List<Product> Products = new List<Product>()
        { new Product
                {
        Name = "Egg",
        Price = 40000

                },
        new Product
                {
        Name = "Butter",
        Price = 4000

                }
        };

        public abstract int CalculateOrder();
    }
}
