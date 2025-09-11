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

        public void SpeedCamera()
        {
            while (true)
            {
                Console.Write("What is the speed limit in kph: ");
                var limitInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(limitInput)) return; 

                Console.Write("What speed is the car travelling at in kph: ");
                var speedInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(speedInput)) return;

                var speedLimit = Convert.ToInt32(limitInput);
                var speed = Convert.ToInt64(speedInput);


                var numberOfPenaltyPoints = (speed - speedLimit)/5;

                if (numberOfPenaltyPoints <= 0)
                {
                    Console.WriteLine("OK");
                    continue;
                }
                else if (numberOfPenaltyPoints < 12)
                {
                    Console.WriteLine("You have {0} penalty points", numberOfPenaltyPoints);
                    continue;
                }
                else
                {
                    Console.WriteLine("Licence suspended!");
                    continue;
                }

                break;
            }

        }
    }
}