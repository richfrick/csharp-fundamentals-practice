using System;
using System.Linq;

namespace CSharpFundamentalsSandbox
{
    public class WorkingWithText
    {
        //1- Write a program and ask the user to enter a few numbers separated by a hyphen.
        //Work out if the numbers are consecutive.
        //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        public void TextExercise1()
        {
            Console.Write("Enter a hyphen seperated list of numbers (e.g. 4-2-3-1): ");
            var input = Console.ReadLine();
            var numberArray = input.Split('-').Select(int.Parse).ToArray();

            bool isConsecutive = true;

            for (int i = 1; i < numberArray.Length; i++)
            {
                if (Math.Abs(numberArray[i] - numberArray[i - 1]) != 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            Console.WriteLine(isConsecutive? "consecutive" : "Not Consecutive");
        }
    }
}