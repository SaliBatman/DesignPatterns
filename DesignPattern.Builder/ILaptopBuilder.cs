using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public interface ILaptopBuilder
    {

        void SetMainBoard();
        void SetCpu();
        void SetRam();
        void SetHdd();

        void SetColor();

        void SetName();

        LaptopModel GetLaptopModel();



    }
}
