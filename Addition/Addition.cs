using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Name: Jamil Matheny
 Date: 10/05/2020
 Class: CIS214
 
 */
namespace Addition
{
    public class Addition
    {
        public static void Main(string[] args)
        {
            int number1; // declares the first number to add
            int number2; // declares the second number to add
            int sum; // declares the sum of number1 and number2

            Console.Write("Enter the first integer: "); // prompt the user to enter an integer

            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: "); // prompt the user to enter the second integer

            // this will read the second number from the user
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("The sum is {0}", sum); // This displays the sum 
        } //end Main
    } // end class Addition
}
