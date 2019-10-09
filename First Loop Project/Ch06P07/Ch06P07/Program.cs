//A simple program when learning about loops for the first time
//which will create a multiplication table

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06P07
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum,
                   lastNum;

            firstNum = InputInformation("the first number");
            lastNum = InputInformation("the last number");

            ComputeTableLayout(firstNum, lastNum);
            Console.ReadKey();
        }

        public static double InputInformation(string info)
        {
            string input;

            double output;

            Console.Write("Please enter {0}: ", info);
            input = Console.ReadLine();

            while (double.TryParse(input, out output) == false)
            {
                Console.WriteLine("That is an invalid input. Please try again");
                Console.Write("Please enter {0}:", info);
                input = Console.ReadLine();
            }

            return output;
        }

        public static void ComputeTableLayout(double first, double last)
        {
            string table = "n\t";

            double row = 1,
                   column = first;

            Console.Clear();

            while (column < last + 1)
            {
                table += (column * row) + "\t";
                column++;
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

            Console.Write(table);
        }
    }
}
