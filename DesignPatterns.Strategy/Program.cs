using System;
using System.Runtime.InteropServices;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StrategyContext(1000);

            var startegy = context.GetOfferStrategy(StratgeyDiscountType.Ten);
            context.ApplyStrategy(startegy);


          

        }
    }
}
