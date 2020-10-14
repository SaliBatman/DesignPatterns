using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public interface IGoodOperation
    {

        void AddGood(Goods goods);

        void Remove(Goods goods);


    }
}
