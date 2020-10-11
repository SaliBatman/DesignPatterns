using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public class MicrosoftLaptopBuilder : ILaptopBuilder
    {
        LaptopModel model = new LaptopModel();
        public LaptopModel GetLaptopModel()
        {
            return model;
        }

        public void SetColor()
        {
            model.Color = "Red";
        }

        public void SetCpu()
        {
            model.Cpu = "Intel i9";
        }

        public void SetHdd()
        {
            model.Hdd = "1 TB SSD";
        }

        public void SetMainBoard()
        {
            model.MainBoard = "Microsoft main board";
        }

        public void SetName()
        {
            model.Name = "Msi ";
        }

        public void SetRam()
        {
            model.Ram = 32;
        }
    }
}
