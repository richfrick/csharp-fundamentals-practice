using System;

namespace CSharpFundamentalsSandbox.Katas.OOP.Interfaces___Polymorphism
{
    public class ReadyForQa : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Ticket ready for QA");
        }
    }
}