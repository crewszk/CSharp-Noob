/*-----------------------------------------------------------------------------
 * Developer: Zackery Crews
 * Assignment: Chapter 6 Problem 7
 * Page: 380
 * Description: This application will ask the user to input a beginning number
 * and an ending number. It will build a multiplication table of these numbers
 * and all integers in between using 1 - 25.
 *---------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch06P10
{
    class Program
    {
        static void Main(string[] args)
        {
            int start,
                end;

            string result = "n\t";

            bool restart = true;

            DisplayInstructions();

            while (restart)
            {
                InputInformation("the beginning number", out start);
                InputInformation("the ending number", out end);
                BuildTable(start, end, ref result);
                AskForDisplayOptions(result, ref restart);
            }
            
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("\tZack's Ch06P10 Project!!");
            Console.WriteLine("\nThis application will ask you for a starting number and an ending" +
                              "\nnumber, in which it will display a multiplication table of those" +
                              "\ntwo numbers, and every integers in between, multiplied by 1 - 25." +
                              "\nPlease only enter whole numbers.");
            Console.Write("Press any key to begin...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void InputInformation(string whichOne, out int number)
        {
            Console.Write("Please enter {0} for the mutiplication table: ", whichOne);
            while (int.TryParse(Console.ReadLine(), out number) == false | number < 0)
            {
                Console.WriteLine("INVALID ENTRY - PLEASE ENTER WHOLE POSITIVE NUMBERS ONLY");
                Console.Write("Please try again. Enter {0} for the multiplication table: ", whichOne);
            }
        }

        public static void BuildTable(int first, int last, ref string table)
        {
            int row = 1,
                column;
             
            column = first;

            for (; column < last + 1; column++)
            {
                table += column + "\t";
            }

            column = first;
            table += "\n";

            while (row < 26)
            {
                table += "\n" + row + "\t";

                for(; column < last + 1; column++)
                {
                    table += (column * row) + "\t";
                }

                column = first;
                row++;
            }
        }

        public static void AskForDisplayOptions(string result, ref bool restart)
        {
            Console.Write("\nDo you want to view the result in the Console or in a Windows Message Box? (Console/Message): ");

            switch (Console.ReadLine())
            {
                case "console":
                case "Console": Console.WriteLine(result);
                    AskForRepeat(out restart);
                    break;
                case "Message":
                case "message": if (MessageBox.Show(result + "\n\nDo you want to create a new table?", "Zack's Ch06P07 Project", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        restart = false;
                    }
                default: Console.WriteLine("INVALID ENTRY - ")
            }

        public static void DisplayTable(string table)
        {
            MessageBox.Show(table + "\n\nWant to try again?", "Zack's Ch06P10 Project", MessageBoxButtons.YesNo);
        }
    }
}
