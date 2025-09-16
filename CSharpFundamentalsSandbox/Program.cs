using System;
using CSharpFundamentalsSandbox.Katas.OOP.Inheritance;

namespace CSharpFundamentalsSandbox
{
    internal class Program
    {
        private static void Helper(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void Main(string[] args)
        {
            var stack = new Stack();

            Helper(() => stack.Push("1"));
            // Helper((() => stack.Push(2)));
            // Helper((() => stack.Push(3)));
            // Helper((() => stack.Push(4)));
            //
            // Helper((() => stack.Pop()));
            // Helper((() => stack.Pop()));
            // Helper((() => stack.Pop()));

            // Helper((() => stack.Clear()));
            //
            // Helper((() => stack.Clear()));
        }

        public class TestClassGeneration
        {
        }
    }
}