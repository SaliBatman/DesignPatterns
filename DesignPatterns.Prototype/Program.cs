using System;

namespace DesignPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            var apple = new AppleLaptopModel()
            {
                Name = "Macbook pro retina 2014",
                Cpu = "i7",
                Hdd = "256 ssd"
            };
            Console.WriteLine(apple.Name + " " + apple.Cpu);
            var newApple = (AppleLaptopModel)apple.Clone();
            newApple.Hdd = "500 ssd";
            Console.WriteLine(newApple.Name + " " + newApple.Hdd);
            Console.ReadLine();

        }
    }
}
