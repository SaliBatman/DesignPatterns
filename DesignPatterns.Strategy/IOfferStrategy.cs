using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public interface IOfferStrategy
    {

        string Name { get; }
        int GetDiscount();

    }
}
