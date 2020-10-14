using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    class FifteenPercentDiscount : IOfferStrategy
    {
        public string Name => "15%";

        public int GetDiscount()
        {
            return 15;
        }
    }
}
