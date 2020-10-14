using System;

namespace DesignPatterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var laptop = new SingleGood("MacBook Pro", 1200000000);

            Console.WriteLine(laptop.CalculatePrice()) ;
            var mobile = new SingleGood("IPhone xs", 4000000);

            var bascket = new CompositeGoods("This is Root", 0);
            var egg = new SingleGood("Egg" , 40000);
            var butter = new SingleGood("Butter", 8000);
            bascket.AddGood(egg);
            bascket.AddGood(butter);
            bascket.AddGood(mobile);

            Console.WriteLine($"Total Price Bascket  : {bascket.CalculatePrice()}");

            Console.ReadLine();



        }
    }
}
