using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
   public class Product
    {

        public string Name { get; set; }
        public int Code { get; set; }
        public int Price { get; set; }

        public Product(string name , int code , int price)
        {
            Name = name;
            Price = price;
            Code = code;
        }


        public void IncreasePrice(int amount) 
        {

            Price += amount;
            Console.WriteLine($"Inc {Price} ");

        }

        public void DecreasePice(int amount) 
        {

            Price -= amount;
            Console.WriteLine($"Dec {Price} ");

        }

    }
}
