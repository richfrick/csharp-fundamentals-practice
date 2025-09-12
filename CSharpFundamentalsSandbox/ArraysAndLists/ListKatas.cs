using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentalsSandbox.ArraysAndLists
{
    public class ListKatas
    {
        // Note: For any of these exercises, ignore input validation unless otherwise directed. Assume the user enters values in the format that the program expects.

        // 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        // If only one person likes your post, it displays: [Friend's Name] likes your post.
        // If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        // If no one likes your post, it doesn't display anything.
        // If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
        // Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        public void Exercise1()
        {
            var friendsList = new List<string>();
            while (true)
            {
                Console.Write("Enter a friends name: ");
                var input = Convert.ToString(Console.ReadLine());
                
                if (!String.IsNullOrWhiteSpace(input))
                {
                    friendsList.Add(input);
                    string nameString = "";
                    if (friendsList.Count < 3)
                    {
                        foreach (var friend in friendsList)
                        {
                            nameString = nameString + " " + friend;
                        }
                        
                        Console.WriteLine(nameString + " likes your post");
                    }
                    else
                    {
                       Console.WriteLine("{0} {1} and {2} others like this", friendsList[0], friendsList[1], friendsList.Count -2); 
                    }
                    continue;
                }
                break;
            }

            
        
        
        }


        // 2- Write a program and ask the user to enter their name.
        // Use an array to reverse the name and then store the result in a new string.
        // Display the reversed name on the console.
        public void Exercise2()
        {
            Console.Write("Enter your name: ");
            var input = Console.ReadLine();

            var nameArray = input.ToCharArray();
            Array.Reverse(nameArray);

            var reversedName = "";

            foreach (var element in nameArray)
            {
                reversedName = reversedName + element;
            }
            
            Console.WriteLine(reversedName);

        }



        // 3- Write a program and ask the user to enter 5 numbers.
        // If a number has been previously entered, display an error message and ask the user to re-try.
        // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.



        // 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        // The list of numbers may include duplicates.
        // Display the unique numbers that the user has entered.



        // 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
    }
}