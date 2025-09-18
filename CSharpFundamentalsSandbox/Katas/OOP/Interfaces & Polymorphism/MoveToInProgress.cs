using System;

namespace CSharpFundamentalsSandbox.Katas.OOP.Interfaces___Polymorphism
{
    public class MoveToInProgress : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Ticket moved to in progress");
        }
    }
}