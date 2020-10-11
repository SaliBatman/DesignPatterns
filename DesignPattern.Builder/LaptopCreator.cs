using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public class LaptopCreator
    {
        private readonly ILaptopBuilder _laptopBuilder;

        public LaptopCreator(ILaptopBuilder laptopBuilder)
        {
            _laptopBuilder = laptopBuilder;
        }

        public void Create() 
        {
            _laptopBuilder.SetMainBoard();
            _laptopBuilder.SetCpu();
            _laptopBuilder.SetHdd();
            _laptopBuilder.SetRam();
            _laptopBuilder.SetColor();
            _laptopBuilder.SetName();

        
        }
        public LaptopModel GetLaptop() 
        {

            return _laptopBuilder.GetLaptopModel();
        }

    }
}
