using System;
using System.Threading;
using CSharpFundamentalsSandbox.Katas.OOP;

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
            var timer = new Classes.Stopwatch();

            Helper(() => timer.StartTimer());
            Helper(() => timer.StartTimer());

            Helper(() => timer.StartTimer());
            Thread.Sleep(1000);
            Helper(() => timer.StopTimer());

            Helper(() => timer.StartTimer());
            Thread.Sleep(1000);
            Helper(() => timer.StopTimer());

            Helper(() => timer.StartTimer());
            Thread.Sleep(1000);
            Helper(() => timer.StopTimer());

            Helper(() => timer.StopTimer());
        }
    }
}