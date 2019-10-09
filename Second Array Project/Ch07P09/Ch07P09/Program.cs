//Another simple project dealing with arrays

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch07P09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] value = new int[11];

            DisplayInstructions();

            InputInformation(value);
            DisplayTable(value);
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("Zack's Counter Computing Device");
            Console.WriteLine("\nThis application will ask a person to entire as many numbers as they" +
                              "\ndesire ranging from 0 - 10. Once the user is done entering numbers" +
                              "\nthe application will display a table of asterisk\'s for every time" +
                              "\nthey entered a specific number.");
            Console.Write("\nPress any key to begin...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void InputInformation(int[] value)
        {
            int input;

            do
            {
                Console.Write("Input a number between 0 and 10: ");
                while(int.TryParse(Console.ReadLine(), out input) == false | input < 0 | input > 10)
                {
                    Console.WriteLine("INVALID INPUT - ENTER ONLY INTEGERS BETWEEN 0 AND 10 - TRY AGAIN");
                    Console.Write("Re-enter a number between 0 and 10: ");
                }
                value[input]++;
            }
            while (MessageBox.Show("Do you want to enter another number?", "Well do you?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        public static void DisplayTable(int[] value)
        {
            string result = "Total number of Values entered: " + value.Sum() + "\n\n";

            result += "Number per value entered:\n";

            for (int i = 0; i < value.Length; i++)
            {
                result += i + " = ";
                for (int val = value[i]; val > 0; val--)
                {
                    result += "*";
                }
                result += "\n";
            }

            MessageBox.Show(result, "Table of Asterisk\'s", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
