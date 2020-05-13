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
            
            ArrayList peopleWhoLikedPost = new ArrayList(); // List of names that like the post
            var enteredName = "";   //Collects name from user input
            bool userFinished = false; //Takes account if a user is finished entering names or not. 

            Console.WriteLine("\t\t\t\t\tAssignment #1: Facebook like simulator.");
            Console.WriteLine("\t\t\t\t\t\tWritten By Benjmin Medrano");

            //While the user is not finished(userFinished == false), 
            //continue prompting the user for names. 
            while(userFinished == false)
            {
                Console.WriteLine("\nEnter a name: ");
                enteredName = Console.ReadLine();
                if (enteredName == "") userFinished = true;
                else
                {
                    peopleWhoLikedPost.Add(enteredName); 
                    //For every userThatLikedPost in peopleWhoLikedPost ArrayList, print it
                    foreach(var userThatLikedPost in peopleWhoLikedPost)
                    {
                        Console.Write(userThatLikedPost + ", ");
                    }
                    //for(int i = 0; i < peopleWhoLikedPost.Count; i++)
                    //{
                     //   Console.Write(peopleWhoLikedPost[i] + ", ");
                    //}
                   
                }


            }

            Console.WriteLine("Complete");
            Console.ReadKey(); 

        }
    }
}
