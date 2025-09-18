using System;

namespace CSharpFundamentalsSandbox.Katas.OOP.Interfaces___Polymorphism
{
    public class CreateTicket : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Ticket created");
        }
    }
}