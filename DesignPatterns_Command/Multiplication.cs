using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns_Command
{
    class Multiplication
    {
        private int _amount;
        public Multiplication(int amount)
        {
            _amount = amount;
        }

        public void Multiply()
        {
            Thread.Sleep(3000);
            Program.GlobalTest *= _amount;
        }

        public void Divide()
        {
            Thread.Sleep(1000);
            Program.GlobalTest /= _amount;
        }
    }
}
