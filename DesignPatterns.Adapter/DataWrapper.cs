using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public static class DataWrapper
    {
        public static List<BankPersonel> GetData() => new List<BankPersonel>() 
        {
         new BankPersonel { Name = "Salar" , Age = 28 , City = "Tehran" },
         new BankPersonel { Name = "Meysam" , Age = 40 , City = "Tehran" },
         new BankPersonel { Name = "Mostafa" , Age = 28 , City = "Tabriz" },

        };

    }
}
