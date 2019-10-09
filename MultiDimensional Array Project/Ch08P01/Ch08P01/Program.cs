//This simple program is the first time I learned to impliment multidimensional
//arrays in C#

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch08P01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDimensional = new int[12, 5] { { 4, 4, 4, 7, 5 }, { 4, 7, 5, 5, 4 }, { 4, 4, 5, 5, 4 }, 
                                               { 4, 4, 4, 7, 5 }, { 4, 7, 5, 5, 4 }, { 4, 4, 5, 5, 4 }, 
                                               { 4, 4, 4, 7, 5 }, { 4, 7, 5, 5, 4 }, { 4, 4, 5, 5, 4 }, 
                                               { 4, 4, 4, 7, 5 }, { 4, 7, 5, 5, 4 }, { 4, 4, 5, 5, 4 } };
            int[] oneDimensional = new int[60];

            DisplayInstructions();

            GenerateScheduleTable(twoDimensional);
            GenerateOneDimensional(twoDimensional, oneDimensional);
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("Zack's Array Generator Computing Device");
            Console.WriteLine("\nThis application will generate a one dimensional array from a two dimensional" +
                              "\narray in the form of a schedule. The user need not do anything but progress" +
                              "\nthe application when it asks.");
            Console.Write("\nPress any key to begin...");
            Console.ReadKey();
        }

        public static void GenerateScheduleTable(int[,] twoD)
        {
            string result = "\t" + string.Format("{0,5}", 'M') + string.Format("{0,5}", 'T') + string.Format("{0,5}", 'W') + 
                            string.Format("{0,5}", 'H') + string.Format("{0,5}", 'F') + "\n";

            for (int r = 0; r < twoD.GetLength(0); r++)
            {
                result += "Week " + (r + 1) + "\t";
                for (int c = 0; c < twoD.GetLength(1); c++)
                {
                    result += string.Format("{0,6}", twoD[r, c]);
                }
                result += "\n";
            }

            result += "\nPress OK to continue...";

            MessageBox.Show(result, "Two Dimensional Array Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void GenerateOneDimensional(int[,] twoD, int[] oneD)
        {
            string result = "This is the two dimensional array slammed into a one dimensional array:\n";

            int counter = 0;

            for (int r = 0; r < twoD.GetLength(0); r++)
            {
                for (int c = 0; c < twoD.GetLength(1); c++)
                {
                    oneD[counter] = twoD[r, c];
                    counter++;
                }
            }

            for (int i = 0; i < oneD.Length; i++)
            {
                result += oneD[i] + " ";
            }

            MessageBox.Show(result, "One Dimensional Array", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
