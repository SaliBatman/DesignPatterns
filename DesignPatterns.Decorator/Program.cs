using System;

namespace DesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new SimpleOrder();
            Console.WriteLine(order.CalculateOrder());

            var discount = new DisocuntOrder(order);
            Console.WriteLine(discount.CalculateOrder());

            Console.ReadLine();
        }
    }
}
