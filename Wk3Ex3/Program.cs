using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //This line creates "myString" and assigns it a blank "" as its value for use later
            string myString = "";

            //This initializes the stringLength variable, for use in the for loop. I'm using it to control how long the program runs
            int stringLength = 0;

            //The int variable for the amount of vowels in the string. It will be changed after the for loop is finished
            int vowels = 0;

            //Introduces what the program will be doing
            Console.WriteLine("This program will count the number of vowels in a string.");

            //Prompts the user to enter a string for use in the for loop
            Console.WriteLine("Enter a string: ");

            //Allows the user to input a string to use in for loop
            myString = Console.ReadLine();
            
            //Takes the string's length in terms of letters to initialize how many loops the for loop will do. 
            stringLength = myString.Length;

            //Sets the int variable i to zero, compares it to strenglength, then increments i after a successful run. 
            for (int i = 0; i < stringLength; i++)
            {
                //Sets the input of the string, depending on the assigned vowel, and increments the conter if it is detected.
                if (myString[i] == 'a' || myString[i] == 'e' || myString[i] == 'i' || myString[i] == 'o' || myString[i] == 'u')
                {
                    //increments the vowel integer if the string contains any of the above
                    vowels++;
                }
            }
            //Prints out the string's vowel count
            Console.Write("The numbers of vowels in the string is:  " + vowels);

            //Allows program to stay open after running for the user to read it
            Console.ReadLine();

        }
    }
}
