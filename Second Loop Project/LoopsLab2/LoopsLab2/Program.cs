//This is a simple program for testing out loops
//It will ask the user for a series of numbers, then compute the sum,
//average, the smallest and largest numbers in the series, without using
//an array

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopsLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallest = 0,
                   largest = 0,
                   sum = 0,
                   average = 0,
                   output = 0;

            string input;

            int counter = 0;

            DisplayInstructions();

            InputInformation(out input);

            LoopInstructions(ref input, ref output, ref counter, ref sum, ref smallest, ref largest);

            average = sum / counter;

            DisplayResults(counter, sum, average, smallest, largest);

        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("\tZack and Glen's Integer Inputter Computing Device");
            Console.WriteLine("\nThis computing device will ask you to input as many numbers as you deem neccessary." +
                              "\nAfterwards it will them sum, average, and display the smallest and largest number" +
                              "\nof all the numbers you have entered. Please only enter numeric characters above 0" +
                              "\nand enter -99 to exit the number imput process.");
            Console.Write("\nPress any key to start the application...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void InputInformation(out string inputInfo)
        {
            Console.WriteLine("Input a value: ");
            inputInfo = Console.ReadLine();
        }

        public static void LoopInstructions(ref string inputVal, ref double outputVal, ref int count, 
                                            ref double sumVal, ref double small, ref double large)
        {
            while (inputVal != "-99")
            {
                if (double.TryParse(inputVal, out outputVal) == false | outputVal < 0)
                {
                    if (outputVal != -99)
                        Console.WriteLine("Please only enter numeric characters at 0 and above.");
                }
                else
                {
                    count++;
                    sumVal += outputVal;
                    DetermineSmallAndLarge(ref small, ref large, ref outputVal, ref count);
                }

                InputInformation(out inputVal);
            }

        }

        public static void DetermineSmallAndLarge(ref double small, ref double large, ref double outputVal, 
                                                  ref int count)
        {
            if (count == 1)
            {
                small = outputVal;
                large = outputVal;
            }
            else
            {
                if (outputVal < small)
                    small = outputVal;
                if (outputVal > large)
                    large = outputVal;
            }
        }
        public static void DisplayResults(int count, double sumVal, double averageVal, double small, double large)
        {
            string result = "Total Entered Values: " + count + "\nSum of Values: " + sumVal + "\nAverage of Values: " + 
                            averageVal + "\nSmallest Value: " + small + "\nLargest Value: " + large;
            Console.Clear();
            MessageBox.Show(result, "Zack and Glen's Integer Inputter Computing Device", MessageBoxButtons.OK);
        }
    }
}
