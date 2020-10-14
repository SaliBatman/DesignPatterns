using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class InvokerProduct
    {
        private readonly List<IProductCommand> _productCommands;

        private IProductCommand _command;

        public InvokerProduct()
        {
            _productCommands = new List<IProductCommand>();
        }
        public void SetCommand(IProductCommand command)
        {
            _command = command;

        }

        public void Invoke() 
        {

            _productCommands.Add(_command);
            _command.Excute();
        }


    }
}
