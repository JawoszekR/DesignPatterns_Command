using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Command
{
    class AddCommand : ICommand
    {
        Addition _addition;

        public AddCommand(Addition addition)
        {
            _addition = addition;
        }

        public void Execute()
        {
            _addition.Add();
        }

        public void Undo()
        {
            _addition.Subtract();
        }
    }
}
