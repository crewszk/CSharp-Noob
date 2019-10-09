using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch09P10
{
    public partial class GameForm : Form
    {
        Random n = new Random();
        private int randomNumber;
        private int counter;

        public GameForm()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int input;

            txtBxGuess.Focus();

            if (int.TryParse(txtBxGuess.Text, out input) == false | input < 1 | input > 50)
            {
                if (txtBxGuess.Text == "")
                    MessageBox.Show("Please guess a number 1 - 50 and enter it into the appropraite box labeled \"Your Guess\".",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Please only enter positive numeric values between 1 - 50.", "Invalid Input",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (input < randomNumber)
                {
                    counter++;
                    txtBxNumberOfGuesses.Text = string.Concat(counter);
                    txtBxVariation.Text = string.Concat(input);
                    txtBxVariation.BackColor = Color.Red;
                    txtBxVariation.ForeColor = Color.White;
                    lblInfo.Text = "Too Low! Try again!";
                    
                }
                else if (input > randomNumber)
                {
                    counter++;
                    txtBxNumberOfGuesses.Text = string.Concat(counter);
                    txtBxVariation.Text = string.Concat(input);
                    txtBxVariation.BackColor = Color.Blue;
                    txtBxVariation.ForeColor = Color.White;
                    lblInfo.Text = "Too High! Try again!";
                    
                }
                else if (input == randomNumber)
                {
                    counter++;
                    txtBxNumberOfGuesses.Text = string.Concat(counter);
                    txtBxVariation.Text = string.Concat(input);
                    txtBxVariation.BackColor = Color.Green;
                    txtBxVariation.ForeColor = Color.White;
                    lblInfo.Text = "SPOT ON! CONGRATULATIONS!";
                    
                    AskForRestart();
                }
            }

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            string loadText = "This is a guessing game application. Your objective is to try and guess\n" +
                              "a number 1 - 50 that the application has picked randomly. The application\n" +
                              "will log how many guesses it takes you, if your guess was too high, and if\n" +
                              "your guess was too low. Are you ready to begin?";

            MessageBox.Show(loadText, "Welcome!", MessageBoxButtons.OK);

            lblInfo.Text = "";
            txtBxGuess.Focus();
            txtBxGuess.Clear();
            txtBxNumberOfGuesses.Clear();
            txtBxVariation.Clear();
            txtBxNumberOfGuesses.ReadOnly = true;
            txtBxVariation.ReadOnly = true;
            txtBxNumberOfGuesses.BackColor = Color.White;
            txtBxVariation.BackColor = Color.White;
            txtBxGuess.BackColor = Color.White;
            counter = 0;
            randomNumber = n.Next(0, 51);
        }

        public void AskForRestart()
        {
            string result = "Congratulations on guessing the number correctly!\n" +
                            "\nCorrect Number: " + randomNumber + "\nNumber of Guesses: " +
                            counter + "\n\nWould you like to play again?";


            if (MessageBox.Show(result, "Congratulations!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RestartApplication();
            }
            else
            {
                Application.Exit();
            }
        }

        public void RestartApplication()
        {
            string restartText = "You have chosen to restart the game! A new random\n" +
                                 "number has been selected from 1 - 50";

            MessageBox.Show(restartText, "Loading...", MessageBoxButtons.OK);
            lblInfo.Text = "";
            txtBxGuess.Focus();
            txtBxGuess.Clear();
            txtBxNumberOfGuesses.Clear();
            txtBxVariation.Clear();
            txtBxNumberOfGuesses.ReadOnly = true;
            txtBxVariation.ReadOnly = true;
            txtBxNumberOfGuesses.BackColor = Color.White;
            txtBxVariation.BackColor = Color.White;
            txtBxGuess.BackColor = Color.White;
            counter = 0;
            randomNumber = n.Next(0, 51);
        }

        private void giveUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string result = "Its a shame you couldn't guess the correct number :(" +
                            "\nBefore you quit you guessed " + counter + " times." +
                            "\n\nThe correct number was " + randomNumber + 
                            "\n\nDo you want to try again?";

            if (MessageBox.Show("Are you sure you want to give up?", "Well are you?", 
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (MessageBox.Show(result, "Too Bad :(", MessageBoxButtons.YesNo, 
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RestartApplication();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to completely restart?\nThe randomized number will not be shown.",
                                "Restart?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RestartApplication();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Well do you?", 
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
