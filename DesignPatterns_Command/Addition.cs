using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns_Command
{
    class Addition
    {
        private int _amount;
        public Addition(int amount)
        {
            _amount = amount;
        }

        public void Add()
        {
            Thread.Sleep(1000);
            Program.GlobalTest += _amount;
        }

        public void Subtract()
        {
            Thread.Sleep(3000);
            Program.GlobalTest -= _amount;
        }
    }
}
