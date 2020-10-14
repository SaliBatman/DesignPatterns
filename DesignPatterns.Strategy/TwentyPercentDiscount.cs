using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    class TwentyPercentDiscount : IOfferStrategy
    {
        public string Name => "20%";

        public int GetDiscount()
        {
            return 20;
        }
    }
}
