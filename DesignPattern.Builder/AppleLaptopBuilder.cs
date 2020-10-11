using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public class AppleLaptopBuilder : ILaptopBuilder
    {
        LaptopModel model = new LaptopModel();
        public LaptopModel GetLaptopModel()
        {
            return model;
        }

        public void SetColor()
        {
            model.Color = "Gray";
        }

        public void SetCpu()
        {
            model.Cpu = "Intel i7"; 
        }

        public void SetHdd()
        {
            model.Hdd = "500 GB SSD";
        }

        public void SetMainBoard()
        {
            model.MainBoard = "Apple main board"; 
        }

        public void SetName()
        {
            model.Name = "Mac Book Pro Retina";
        }

        public void SetRam()
        {
            model.Ram = 32;
        }
    }
}
