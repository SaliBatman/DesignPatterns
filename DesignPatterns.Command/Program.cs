using System;

namespace DesignPatterns.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Phone",555,10000);
            var invoker = new InvokerProduct();
            invoker.SetCommand(new ProductCommand(product, 500, 1));
            invoker.Invoke();

            invoker.SetCommand(new ProductCommand(product, 1000, 2));
            invoker.Invoke();
            Console.WriteLine("Hello World!");
        }
    }
}
