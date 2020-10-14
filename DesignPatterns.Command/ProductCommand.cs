using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class ProductCommand : IProductCommand
    {

        private  Product _product;
        private  int _amount;
        private  int _action;

        public ProductCommand(Product product , int amount , int action )
        {
            _product = product;
            _amount = amount;
            _action = action;
        }
        public void Excute()
        {
            // action == 1 increase 
            // action == 2 dec
            if(_action == 1) 
            {

                _product.IncreasePrice(_amount);
                
            }
            else
            {
                _product.DecreasePice(_amount);
            }
        }
    }
}
