using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PairedProjectApp
{
    class PairedProjectApp
    {
        static void Main(string[] args)
        {
            const double SCORE_CONSTANT = 0.6;

            double difficulty = 0,
                   finalScore = 0;

            bool restart = true;

            double[] scores = new double[7];

            DisplayInstructions();

            do
            {
                InputDifficulty(ref difficulty);
                InputScores(scores);
                CalculateFinalScore(scores, ref finalScore, difficulty, SCORE_CONSTANT);
                DisplayResults(ref restart, finalScore);
            }
            while (restart);
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("\tZack and Parker's Judging Application");
            Console.WriteLine("\nThis application will is to be used during diving competitions to determine" +
                              "\nthe final score of the diver at hand. First, the difficulty of the challenge" +
                              "\nwill be entered, and then the seven judges scores. Afterwards, the largest" +
                              "\nand smallest scores will be removed, the remaining scores summed, and then" +
                              "\nthat sum is multiplied by the challenge difficulty. Then that product is" +
                              "\nmultiplied by a constant of 0.6 to determine the final score.");
            Console.Write("\nPress any key to begin...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void InputDifficulty(ref double difficulty)
        {
            Console.Write("Please enter the difficulty of the diving challenge (between 1.2 - 3.8): ");
            while (double.TryParse(Console.ReadLine(), out difficulty) == false | difficulty < 1.2 | difficulty > 3.8)
            {
                Console.WriteLine("INVALID INPUT - DIFFICULTY RANGE IS BETWEEN 1.2 AND 3.8 - TRY AGAIN");
                Console.Write("Please enter the difficulty of the diving challenge (between 1.2 - 3.8): ");
            }
        }

        public static void InputScores(double[] scores)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("Please enter the score of judge number {0} (0 - 10): ", i + 1);
                while (double.TryParse(Console.ReadLine(), out scores[i]) == false | scores[i] < 0 | scores[i] > 10)
                {
                    Console.WriteLine("INVALID ENTRY - ONLY ENTER NUMBER BETWEEN 0 and 10 - TRY AGAIN");
                    Console.Write("Please enter the score of the judge number {0} (0 - 10): ", i + 1);
                }
            }
        }

        public static void CalculateFinalScore(double[] scores, ref double final, double difficulty, double scoreConstant)
        {
            double sum = 0;

            Array.Sort(scores);

            for (int i = 1; i < scores.Length - 1; i++)
                sum += scores[i];

            final = (sum * difficulty) * scoreConstant;
        }

        public static void DisplayResults(ref bool restart, double final)
        {
            string result = "The final score of the dive challenge is " + final + "\n\nDo you wish to judge another diving challenge?";

            if (MessageBox.Show(result, "Zack and Parker's Judging Calculator", MessageBoxButtons.YesNo) == DialogResult.No)
                restart = false;
            else
                restart = true;

            Console.Clear();
        }
    }
}