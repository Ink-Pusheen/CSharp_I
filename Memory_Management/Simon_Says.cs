using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Management
{
    public partial class Simon_Says : Form
    {
        //Randomness
        Random rand = new Random();

        //Variables
        List<string> values = new List<string>(); // List of inputs the player will have to recall

        string displayVal = ""; //Variable that will be displayed to the user (To not loop through the values list every time)

        int index; //Index of the current value to be inputted

        int roundNum; //Value of the current round
        int scoreVal; //Value of the current score

        //Booleans
        bool canInput = false; //This is disabled while the value is displayed [Default - False]

        bool inGame = false; //Boolean to check if the player is still in game, checking if they really wanna leave while the game is still going

        //Public reference to Main Menu
        Main_Menu menu;

        public Simon_Says(Main_Menu menuInput)
        {
            InitializeComponent();
            menu = menuInput;
        }

        void resetGame() //Resets the game entirely
        {
            roundNum = 1; //Resets all integer variables
            scoreVal = 0;
            index = 0;

            displayVal = ""; //Resets both string variables
            values.Clear();
        }

        //Function to start the game
        private void startBtn_Click(object sender, EventArgs e)
        {
            resetGame(); //Resets the variables for a clean state to start

            addNumber(); //Starts by adding a number, disabling the start button, and then enables all the following buttons
            startBtn.Enabled = false;

            inGame = true; //Changes it so the game identifies the player in the middle of a round
        }

        async void addNumber()
        {
            canInput = false; //Ensures no input can be taken [Failsafe]

            int newVal = rand.Next(1, 10); //Creates the new number

            values.Add(newVal.ToString()); //Adds the new number to the list
            displayVal += newVal.ToString(); //Adds the new number to the display

            rememberLabel.Text = "Remember";
            simonInputLabel.Text = displayVal;

            await Task.Delay(3000); //Wait for 3 seconds

            try //Code to be ran if this window is still open
            {
                rememberLabel.Text = "Your turn";
                simonInputLabel.Text = "";

                canInput = true; //Ensures input can be taken

                foreach (Button btn in this.Controls.OfType<Button>()) //Loops through all input buttons and enables them
                {
                    if (btn.Tag?.ToString() == "inputBtn")
                    {
                        btn.Enabled = true;
                    }
                }
            }
            catch //If the window is already closed, relay and stop all code execution
            {
                return;
            }
            
        }

        //Function to check if the sequence is done. If it is, it will progress to the next round after a few seconds
        void checkIndex()
        {
            if (index == values.Count) //Checks if all inputs have been done and moves to the next round if done so
            {
                canInput = false; //Sets it so the player cannot make inputs [failsafe]

                foreach (Button btn in this.Controls.OfType<Button>()) //Loops through each input button and disables them
                {
                    if (btn.Tag?.ToString() == "inputBtn")
                    {
                        btn.Enabled = false;
                    }
                }

                scoreVal++;
                roundNum++;

                startNextRound();
            }
        }

        //Function to start the next round with a 2 second delay
        async void startNextRound()
        {
            rememberLabel.Text = "Round complete, next round"; //Displays the round is over

            index = 0; //Resets the index

            await Task.Delay(2000);

            //Try catch function if the window has already been closed
            try
            {
                roundLabel.Text = $"Round: {roundNum}"; //Updates the round and score labels accordingly
                scoreLabel.Text = $"Score: {scoreVal}";

                addNumber();
            }
            catch
            {
                return;
            }

        }

        //Function to run if the incorrect value was inputted
        void gameOver()
        {
            foreach (Button btn in this.Controls.OfType<Button>()) //Loops through each input button and disables them
            {
                if (btn.Tag?.ToString() == "inputBtn")
                {
                    btn.Enabled = false;
                }
            }

            rememberLabel.Text = "Game Over";

            startBtn.Enabled = true;

            inGame = false;

            //Saves the current score && updates the main menu
            if (File.Exists("ssScore.txt")) //Checks if the file already exists to compare the score
            {
                int savedScore = int.Parse(File.ReadAllText("ssScore.txt"));

                if (scoreVal > savedScore)
                {
                    File.WriteAllText("ssScore.txt", scoreVal.ToString());
                }
            }
            else //If it doesn't, just write the data
            {
                File.WriteAllText("ssScore.txt", scoreVal.ToString());
            }

            menu.loadData();
        }

        void checkInput(string value)
        {
            if (values[index] == value) //Checks if the current index is the same as the buttons display
            {
                index++; //Adds one to the index and checks if that was the last needed input
                checkIndex();
            }
            else //Wrong input will initiate game over
            {
                gameOver();
            }
        }
        #region Buttons
        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (!canInput) return; //Failsafe to make it so you cannot select buttons mid intermission

            checkInput(oneBtn.Text); //Checks the input
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (!canInput) return; //Failsafe to make it so you cannot select buttons mid intermission

            checkInput(twoBtn.Text); //Checks the input
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (!canInput) return; //Failsafe to make it so you cannot select buttons mid intermission

            checkInput(threeBtn.Text); //Checks the input
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (!canInput) return; //Failsafe to make it so you cannot select buttons mid intermission

            checkInput(fourBtn.Text); //Checks the input
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (!canInput) return; //Failsafe to make it so you cannot select buttons mid intermission

            checkInput(fiveBtn.Text); //Checks the input
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (!canInput) return; //Failsafe to make it so you cannot select buttons mid intermission

            checkInput(sixBtn.Text); //Checks the input
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (!canInput) return; //Failsafe to make it so you cannot select buttons mid intermission

            checkInput(sevenBtn.Text); //Checks the input
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (!canInput) return; //Failsafe to make it so you cannot select buttons mid intermission

            checkInput(eightBtn.Text); //Checks the input
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (!canInput) return; //Failsafe to make it so you cannot select buttons mid intermission

            checkInput(nineBtn.Text); //Checks the input
        }

        #endregion

        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (inGame)
            {
                if (MessageBox.Show("You are in the middle of a game, do you wish to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    menu.Show(); //Shows the original Menu and closing this form
                    this.Close();
                }
                else
                {
                    //Null, return empty
                    return;
                }
            }
            else
            {
                menu.Show(); //Shows the original Menu and closing this form
                this.Close();
            }
        }
    }
}
