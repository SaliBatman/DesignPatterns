using DesignPatterns.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
   public  class Client
    {

        private readonly Shirts _shirts; 
        private readonly Pants _pants;
        public Client(ClothesFactory clothesFactory)
        {
            _shirts = clothesFactory.CreateShirts();
            _pants = clothesFactory.CreatePants();
        }
        public string WhatIsYourClothToday() 
        {

            return $"my cloth today is red {_shirts.GetType().Name} and blue {_pants.GetType().Name}"; 
        
        }

    }
}
