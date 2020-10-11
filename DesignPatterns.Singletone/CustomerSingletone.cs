using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singletone
{
    public class CustomerSingletone
    {

        private static CustomerSingletone _instance;
        private static int customerIndex = 0;

        private static readonly object instanceLock = new object();
        private CustomerSingletone()
        {
            customerIndex++;
            Console.WriteLine(customerIndex);
        }

        public static CustomerSingletone Instance
        {
            get
            {

                // double checking 

                if (_instance == null)
                {

                    lock (instanceLock)
                    {
                        if (_instance == null)
                        {

                            _instance = new CustomerSingletone();
                        }
                    }

                }
                return _instance;


            }
        }

        public void PrintName(string name)
        {

            Console.WriteLine($"customer name is {name}");
        }


    }


}

