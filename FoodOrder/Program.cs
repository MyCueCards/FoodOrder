/********************************************************************
 * Assignment from SDEV 240                                         *
 * Coded by: Harley Ehrman                                          *
 *                                                                  *
 * From book:                                                       *
 * Microsoft Visual C# 2015:                                        *
 * An Introduction to Object-Oriented Programming 6th Edition       *
 * by Joyce Farrell                                                 *
 *                                                                  *
 * Instructions (Page 349, Exercise 3):                             *
 * Create a program for The Cactus Cantina named FoodOrder that     *
 * accepts a user’s choice from the options in the accompanying     *
 * table. Allow the user to enter either an integer item number or  *
 * a string description. Pass the user’s entry to one of two        *
 * overloaded GetDetails() methods, and then display a returned     *
 * string with all the order details. The method version that       *
 * accepts an integer looks up the description and price; the       *
 * version that accepts a string description looks up the item      *
 * number and price. The methods return an appropriate message if   *
 * the item is not found.                                           *
 *  Item number	     Description	  Price                         *
 *      20             Enchilada       2.95                         *
 *      23             Burrito         1.95                         *
 *      25             Taco            2.25                         *
 *      31             Tostada         3.10                         *
 ********************************************************************/
using System;

namespace FoodOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare arrays
            int[] item = { 20, 23, 25, 31 };
            string[] desc = { "Enchilada", "Burrito", "Taco", "Tostada" };
            double[] price = { 2.95, 1.95, 2.25, 3.10 };

            //display menu
            Console.WriteLine("{0,-8}{1,-15}{2,-10}", "Item", "Description", "Price");
            int x;
            for (x = 0; x < item.Length; ++x)
            {
                Console.Write("{0, -8}{1, -15}{2, -10}", Convert.ToString(item[x]), desc[x], price[x].ToString("C"));
                Console.WriteLine();
            }

            //ask user for input
            Console.Write("Enter your selection: ");
            string selection = Console.ReadLine();

            //determine selection
            int choice;

            if (int.TryParse(selection, out choice))
            {
                GetDetails(choice, item, desc, price);
            }
            else
            {
                GetDetails(selection, item, desc, price);
            }
        }

        //method for item number chosen
        private static void GetDetails(int choice, int[] item, string[] desc, double[] price)
        {
            int index = Array.IndexOf(item, choice);
            if (index == -1)
            {
                Console.WriteLine("Selection not found");
            }
            else
            {
                Console.WriteLine("The {0} costs {1}!", desc[index], price[index].ToString("C"));
            }

            //stops program from automatically closing after above text displays.
            Console.ReadLine();
        }

        //method for selection string chosen
        private static void GetDetails(string selection, int[] item, string[] desc, double[] price)
        {
            int index = Array.IndexOf(desc, selection);
            if (index == -1)
            {
                Console.WriteLine("Selection not found");
            }
            else
            {
                Console.WriteLine("The {0} costs {1}!", desc[index], price[index].ToString("C"));
            }

            //stops program from automatically closing after above text displays.
            Console.ReadLine();
        }
    }
}
