
/* Course: 3280
 * Assignment: 01
 * By
 * Benjamin Medrano 
 * 5/20/20
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280A1
{
    class Program
    {
        static void Main(string[] args)
        {

            var peopleWhoLikedPost = new List<string>(); // List of names that like the post
            bool userFinished = false; //Takes account if a user is finished entering names or not. 

            Console.WriteLine("\t\t\t\t\tAssignment #1: Facebook like simulator.");
            Console.WriteLine("\t\t\t\t\t\tWritten By Benjamin Medrano");

            //This code will continuously prompt the user for names until they decide they are finished. 
            while (!userFinished)
            {
                Console.Write("\nEnter a name: ");
                var enteredName = Console.ReadLine();

                if (String.IsNullOrEmpty(enteredName))
                {
                    userFinished = true;
                }
                else
                {
                    peopleWhoLikedPost.Add(enteredName);
                }
            }
            if(peopleWhoLikedPost.Count > 2)
            {
                Console.WriteLine($"{peopleWhoLikedPost[0]}, {peopleWhoLikedPost[1]} and {peopleWhoLikedPost.Count - 2} others liked your post.");
              

            }
            else if (peopleWhoLikedPost.Count > 1)
            {
                Console.WriteLine(peopleWhoLikedPost[0] + ", " + peopleWhoLikedPost[1] + " liked your post.");
            }
            else
            {
                Console.WriteLine(peopleWhoLikedPost[0] + " liked your post.");
            }


            Console.ReadKey(); 

        }

        static Program()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

    }

}
