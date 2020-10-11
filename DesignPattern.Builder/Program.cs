using System;

namespace DesignPattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            var creator = new LaptopCreator( new AppleLaptopBuilder());
            creator.Create();
            var laptop = creator.GetLaptop();

            Console.WriteLine(laptop.Name);
            Console.WriteLine(laptop.MainBoard);
            Console.WriteLine(laptop.Cpu);
            Console.WriteLine(laptop.Ram);
            Console.WriteLine(laptop.Color);
            Console.WriteLine(laptop.Hdd);
            Console.ReadKey();


        }
    }
}
