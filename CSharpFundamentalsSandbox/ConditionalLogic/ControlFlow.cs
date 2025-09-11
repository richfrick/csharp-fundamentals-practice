using System;

namespace CSharpFundamentalsSandbox.ConditionalLogic
{
    public class ControlFlow
    {
        public void NumberDivisibleByThree()
        {
            var counter = 0;
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("The count of numbers divisible by 3 is: " + counter);
        }

        public void EnterNumberOrOk()
        {
            while (true)
            {
                Console.Write("Enter a Number or Ok to exit: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Your number is: " + input);
                    continue;
                }

                break;
            }
        }

        public void GetFactorialOfNumber()
        {

                Console.Write("Enter a number and I'll work out the factorial: ");
                var input = Convert.ToInt32(Console.ReadLine());
                var factorialValue = 1;
                    for (var i = 1; i <= input; i++)
                    {
                        factorialValue *= i;
                    }

                    Console.WriteLine("Factorial value is: "  + factorialValue);
  
            
        }

        public void GuessSecretNumber()
        {
            var numberBetweenOneAndTen = new Random().Next(1, 10);
                Console.WriteLine(numberBetweenOneAndTen);

                for (var i = 0; i < 4; i++)
                {
                    Console.Write("Guess a number between 1 and 10: ");
                    var guessedNumber = Convert.ToInt32(Console.ReadLine());

                    if (guessedNumber != numberBetweenOneAndTen) continue;
                    Console.WriteLine("You won");
                    return;

                }
                Console.WriteLine("You Lost");
        }

        public void FindMaxNumber()
        {
            Console.Write("Enter a list of comma seperated numbers: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var maxNumber = Convert.ToInt32(numbers[0]);

            foreach (var number in numbers)
            {
                var currentNumber = Convert.ToInt32(number);
                if (maxNumber < currentNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            Console.WriteLine("max number is " + maxNumber);
        }
    }
}