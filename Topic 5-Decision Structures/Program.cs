using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5_Decision_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operator Meaning
            //== equals
            //< less than
            //<= less than or equal to
            //> greater than
            //>= greater than or equal to
            //!= not equal to

            //if (condional)
            //{
            //    //code to execute if condition is true
            //}
            //else
            //{
            //    //code to execute if condition is false


            //}

            //Note: the final and optional
            //‘else’ will be done if all prior
            //conditions are False

            //1) Print “Good Job” to the screen if the value in an integer variable called grade is greater than or
            //  equal to 80.

            int grade = 85;

            if (grade >= 80)
            {
                Console.WriteLine("Good Job");


            }

            //2) Print “You guessed it!” to the screen if the value stored in the integer variable guess is equal to
            // 12.

            int guess = 12;

            if (guess == 12)
            {
                Console.WriteLine("You guessed it!");

            }

            //  3) Print “Good Job!” to the screen if the value stored in the integer variable called grade is greater
            //than or equal to 80, and print “Study Harder!” to the screen if grade is less than 80.


            int grade2 = 75;

            if (grade2 >= 80)
            {
                Console.WriteLine("Good Job!");
            }
            else
            {
                Console.WriteLine("Study Harder!");

            }

            //2) Print “Negative radii are illegal!” if the value stored in the integer variable radius is negative,
            // print “The diameter is [what the diameter would be]“ if radius is 1 or greater, and print “You
            // have a dot” if radius is zero.

            int radius = 0;
            int diameter = radius * 2;
            int area = radius * radius * 3;

            if (radius < 0)
            {
                Console.WriteLine("Negative radii are illegal!");
            }
            else if (radius >= 1)
            {
                Console.WriteLine($"The diameter is {diameter}");
            }
            else
            {
                Console.WriteLine("You have a dot");

            }

            //  ** LOGICAL OPERATORS **
            //            Operator Meaning
            //  && AND
            //   || OR
            //  ! NOT


            //    if (Int32.TryParse(someString, out min))
            {
                //Code here for valid input, additional error checking may occur
                //here as well
            }
            //     else
            {
                //Error message and handling
            }

            //  ** Decision Structures Exercises **

            //*EASY*

            int personOne = 30;
            int personTwo = 25;
            int personThree = 25;

            if (personOne > personTwo)
            {
                Console.WriteLine("Person One is older than Person Two");
            }

            if (personOne > personThree)
            {
                Console.WriteLine("Person Three is younger than Person One");
            }

            if (personTwo == personThree)
            {
                Console.WriteLine("Person Two and Person Three are the same age");

            }

            //*MEDIUM*

            if (personTwo < personOne && personTwo < personThree)
            {
                Console.WriteLine("Person Two is younger than Person One and Person Three");
            }

            if (personOne > personTwo && personOne > personThree)
            {
                Console.WriteLine("Person One is older than Person Two and Person Three");
            }

            //*HARDER MEDIUM*

            if (personTwo == personOne && personThree != personOne)
            {
                Console.WriteLine("Person Two is the same age as Person One, but Person Three is not");

            }

            if (personOne != personTwo && personOne != personThree)
            {
                Console.WriteLine("Person One is not the same age as Person Two or Person Three");
            }


            if (personOne == personTwo && personOne == personThree)
            {
                Console.WriteLine("All three people are the same age");
            }


            if (personOne != personTwo && personOne != personThree && personTwo != personThree)
            {
                Console.WriteLine("Nobody is the same page!");
            }
















        }
}   }  
