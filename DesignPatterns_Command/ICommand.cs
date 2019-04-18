using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Command
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
