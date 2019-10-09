//A simple program when learning about arrays for the first time
//It will ask the user to enter a number of item names and prices
//and it will mark up the price in a table formate based on certain
//percentages

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch06P06Arrays
{
    class MarkUpApp
    {
        static void Main(string[] args)
        {
            bool restart = true;

            int entries = 0;

            double[] price = new double[1000];
            string[] name = new string[1000];

            DisplayInstructions();

            while (restart)
            {

                Console.Write("Please enter the name of the item: ");
                name[entries] = Console.ReadLine();
                Console.Write("Please enter the price of the item: ");
                while (double.TryParse(Console.ReadLine(), out price[entries]) == false | price[entries] < 0)
                {
                    Console.WriteLine("INVALID ENTRY - PLEASE ENTER POSITIVE NUMBERS ONLY");
                    Console.Write("Please try again. Enter the price of the item: ");
                }
                entries++;
                if (MessageBox.Show("Do you want to enter another item for markup?", "Well do you?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    restart = true;
                else
                    restart = false;
            }

            Console.Clear();
            Console.WriteLine("\t{0,-40}{1,30}", "Item", "Markup Prices");
            Console.WriteLine("{0,-20}{1,8}{2,12}{3,12}{4,12}{5,12}{6,12}{7,12}\n", 
                              "Name", "Price", "5%", "6%", "7%", "8%", "9%", "10%");

            for(int i = 0; i < entries; i++)
            {
                Console.Write("{0,-20}{1,8:C}", name[i], price[i]);
                for(double percent = 1.05; percent < 1.11; percent += 0.01)
                {
                    double markup;

                    markup = price[i] * percent;

                    Console.Write("{0,12:C}", markup);
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("\tZack's Markup Price Calculator!");
            Console.WriteLine("\nThis application will ask you to enter a number of item names and their original prices." +
                              "\nIt will then compute a markup price for 5%, 6%, 7%, 8%, 9%, and 10% markup percentages." +
                              "\nPlease only enter positive numbers for the original price.");
            Console.Write("\nPress any key to begin...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
