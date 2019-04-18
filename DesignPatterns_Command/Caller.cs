using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Command
{
    class Caller
    {
        Queue<ICommand> _commandsQueue = new Queue<ICommand>();
        Stack<ICommand> _executedComands = new Stack<ICommand>();
        object obj1 = new object();
        object obj2 = new object();

        public void AddCommand(ICommand command)
        {
            lock (obj1)
            {
                _commandsQueue.Enqueue(command);
            }
        }

        public void executeCommands()
        {
            Console.WriteLine("Command queue lenght " + _commandsQueue.Count);
            Parallel.ForEach(_commandsQueue, c =>
            {
                _commandsQueue.Dequeue();//TODO consider
                c.Execute();
                lock (obj2)
                {
                    _executedComands.Push(c);
                }
            });
            Console.WriteLine("Command queue lenght " + _commandsQueue.Count);
        }

        public void Undo()
        {
            Console.WriteLine("Execution stack lenght " + _executedComands.Count);
            while (_executedComands.Count>0)
            {
                lock (obj2)
                {
                    var execution = _executedComands.Pop();
                    execution.Undo();
                }
            }
            Console.WriteLine("Execution stack lenght " + _executedComands.Count);
        }
    }
}
