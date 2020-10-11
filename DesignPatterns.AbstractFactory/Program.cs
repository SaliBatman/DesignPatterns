using DesignPatterns.AbstractFactory.Factories;
using System;

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var elgant = new Client(new ElgantFactory());
           var result  =  elgant.WhatIsYourClothToday();
            Console.WriteLine(result);
            var casual = new Client(new CasualFactory());
            Console.WriteLine(casual.WhatIsYourClothToday());
            Console.ReadLine();
        }
    }
}

