using System;
using System.Threading.Tasks;

namespace DesignPatterns.Singletone
{
    class Program
    {
        static void Main(string[] args)
        {

            // No ThreadSafe
            Parallel.Invoke(
                () =>
            {
                PrintSalarName();


            },
            () =>
            {
                PrintRezaName();

            }
            );

            Console.ReadLine();
        }

        private static void PrintSalarName()
        {

            CustomerSingletone.Instance.PrintName("salar");
        }

        private static void PrintRezaName()
        {

            CustomerSingletone.Instance.PrintName("reza");
        }
    }
}
