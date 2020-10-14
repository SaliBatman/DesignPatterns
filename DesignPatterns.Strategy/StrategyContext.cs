using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class StrategyContext
    {

        private int _price = 0;

        private Dictionary<string, IOfferStrategy> stratgeyContext = new Dictionary<string, IOfferStrategy>();
        public StrategyContext(int price)
        {
            _price = price;


            stratgeyContext.Add("10%", new TenPrecentDiscount());
            stratgeyContext.Add("15%", new FifteenPercentDiscount());
            stratgeyContext.Add("20%", new TwentyPercentDiscount());
        }
        public void ApplyStrategy(IOfferStrategy offerStrategy)
        {
            Console.WriteLine($"Befor startgey Action {_price}");
            int finalPrice = _price - (_price * offerStrategy.GetDiscount());
            Console.WriteLine($"final price {finalPrice}");



        }

        public IOfferStrategy GetOfferStrategy(StratgeyDiscountType type)
        {

            switch (type)
            {
                case StratgeyDiscountType.Ten:
                    return stratgeyContext["10%"];
                case StratgeyDiscountType.Fifteen:
                    return stratgeyContext["15%"];

                case StratgeyDiscountType.Twenty:
                    return stratgeyContext["20%"];

                default:
                    return null;
            }
        }
    }
}
