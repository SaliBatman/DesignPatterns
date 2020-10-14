using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class CompositeGoods : Goods, IGoodOperation
    {

        private List<Goods> _goodsList;

        public CompositeGoods(string name , int price) : base(name,price)
        {
            _goodsList = new List<Goods>();
        }
        public void AddGood(Goods goods)
        {

            _goodsList.Add(goods);
        }

        public override int CalculatePrice()
        {
            Console.WriteLine("Calculate Start ....");
            int totalPrice = 0;
            foreach (var item in _goodsList)
            {
                totalPrice += item.CalculatePrice();
            }

            Console.WriteLine("Calculate ENd ....");
            return totalPrice;
        }

        public void Remove(Goods goods)
        {
            _goodsList.Remove(goods);
        }
    }
}
