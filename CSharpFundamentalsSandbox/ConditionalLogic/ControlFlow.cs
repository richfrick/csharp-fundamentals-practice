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
    }
}