using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    class TenPrecentDiscount : IOfferStrategy
    {
        public string Name => "10%";

        public int GetDiscount()
        {
            return 10;
        }
    }
}
