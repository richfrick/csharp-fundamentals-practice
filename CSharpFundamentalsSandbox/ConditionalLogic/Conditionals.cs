using System;

namespace CSharpFundamentalsSandbox.ConditionalLogic
{
    public class Conditionals
    {
        public void IsNumberBetweenOneAndTen()
        {
            Console.WriteLine("Enter a number between 1 and 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            
            if (number > 0 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public int WhichNumberIsHigher(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }

        public string PortraitOrLandscape(int heightInInches, int widthInInches)
        {
            return heightInInches > widthInInches ? "Portrait" : "Landscape";
        }
        
    }
}