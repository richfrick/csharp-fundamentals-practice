using System;

namespace CSharpFundamentalsSandbox.Katas.OOP.Interfaces___Polymorphism
{
    public class CreateTicket : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Ticket created");
        }
    }
}