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
            ConsoleColor textColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = textColor;

            ArrayList peopleWhoLikedPost = new ArrayList(); // List of names that like the post
            var enteredName = "";   //Collects name from user input
            bool userFinished = false; //Takes account if a user is finished entering names or not. 

            Console.WriteLine("\t\t\t\t\tAssignment #1: Facebook like simulator.");
            Console.WriteLine("\t\t\t\t\t\tWritten By Benjamin Medrano");

            while(userFinished == false)
            {
                Console.WriteLine("\nEnter a name: ");
                enteredName = Console.ReadLine();

                if (enteredName == "") userFinished = true;
                else
                {
                    peopleWhoLikedPost.Add(enteredName);
                }
            }
            if(peopleWhoLikedPost.Count == 1)
            {
                Console.WriteLine(peopleWhoLikedPost[0] + " liked your post."); 
            }
            else if (peopleWhoLikedPost.Count > 1)
            {
                Console.WriteLine($"{peopleWhoLikedPost[0]}, {peopleWhoLikedPost[1]} and {peopleWhoLikedPost.Count - 2} others liked your post.");
            }


            Console.ReadKey(); 

        }
    }
}
