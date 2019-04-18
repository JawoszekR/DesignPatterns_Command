using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Command
{
    class MultiplyCommand : ICommand
    {
        Multiplication _multiplication;

        public MultiplyCommand(Multiplication multiplication)
        {
            _multiplication = multiplication;
        }

        public void Execute()
        {
            _multiplication.Multiply();
        }

        public void Undo()
        {
            _multiplication.Divide();
        }
    }
}
