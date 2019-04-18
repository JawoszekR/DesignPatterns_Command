using System;

namespace DesignPatterns_Command
{
    class Program
    {
        public static int GlobalTest = 1;
        static void Main(string[] args)
        {
            Multiplication mult = new Multiplication(10);
            Addition add = new Addition(1);

            MultiplyCommand multCom = new MultiplyCommand(mult);
            AddCommand addCom = new AddCommand(add);

            Caller caller = new Caller();

            caller.AddCommand(multCom);
            caller.AddCommand(addCom);

            caller.executeCommands();

            Console.WriteLine(GlobalTest);

            caller.Undo();

            Console.WriteLine(GlobalTest);

            Console.ReadKey();
        }
    }
}
