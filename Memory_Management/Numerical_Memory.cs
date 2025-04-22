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
    public partial class Numerical_Memory : Form
    {
        //Reference to the main menu
        Main_Menu menu;

        //Random
        Random rand = new Random();

        //Variables

        string numberList = ""; //List of numbers the user will have to relay

        int roundNum = 1; //Number value for the current round [Default - 1]
        int scoreVal = 0; //Number value for the current score [Default - 0]

        int timerVal = 7; //Timer to complete the current level

        //Booleans

        bool inGame; //Is the currently running?

        public Numerical_Memory(Main_Menu menuInput)
        {
            InitializeComponent();
            menu = menuInput; //References the main menu when this form is created
        }

        //function to full reset the game
        void resetGame()
        {
            numberList = ""; //Resets the input string

            roundNum = 1; //Resets the round number
            scoreVal = 0; //Resets the score value

            roundLabel.Text = $"Round: {roundNum}"; //Resets the round and score labels
            scoreLabel.Text = $"Score: {scoreVal}";

            numberInput.Text = ""; //Resets the current input
        }
        //zach was here
        private void startBtn_Click(object sender, EventArgs e)
        {
            inGame = true; //Sets it so the user is currently playing
            startBtn.Enabled = false; //Makes it so the start button cannot be clicked again

            resetGame(); //Ensure everything is reset
            addValue();
        }

        //Function that adds a new value to the list to remember
        async void addValue()
        {
            int newNum = rand.Next(0, 10); //Generates the new number and adds it the the current numberlist
            numberList += newNum.ToString();

            rememberLabel.Text = "Remeber";
            numberlistLabel.Text = numberList;

            await Task.Delay(3000);

            //Try catch function if the window has already been closed
            try
            {
                rememberLabel.Text = "Repeat";
                timer();

                numberInput.ReadOnly = false; //Makes it so it can be written to
                numberInput.Enabled = true;
            }
            catch //If the application is already closed, just break code line
            {
                return;
            }


        }

        //Function acting as a timer, when it hits zero, it checks the current input, else it loops
        async void timer()
        {
            numberlistLabel.Text = $"Time remaining: {timerVal}";

            await Task.Delay(1000); // Wait a second

            //Try Catch function if the window has already been closed
            try
            {
                timerVal--;

                if (timerVal == 0) //End the loop if time is up
                {
                    numberInput.ReadOnly = true; //Makes it so it cannot be written to anymore



                    numberlistLabel.Text = "Time remaining: 0";

                    await Task.Delay(1000);

                    //Try Catch Function if the window has already been closed
                    try
                    {
                        checkInput();
                    }
                    catch
                    {
                        return;
                    }
                }
                else
                {
                    timer(); //Rerun the loop if there is still time
                }
            }
            catch
            {
                return;
            }
            
        }

        //Function to check if the current input is the same as the current list
        async void checkInput()
        {
            string pInput = numberInput.Text.Trim(); //Grabs what the player currently inputted

            if (pInput == numberList) //Case that the input and current list match
            {
                rememberLabel.Text = "Round Passed, Next Round";
                numberInput.Enabled = false; //Hides the input box

                await Task.Delay(1000);

                //Try Catch Function if the window has already been closed
                try
                {
                    roundNum++; //Adds to the round and score values and then updates them respectively
                    scoreVal++;

                    roundLabel.Text = $"Round: {roundNum}";
                    scoreLabel.Text = $"Score: {scoreVal}";

                    numberInput.Text = ""; //Resets the current input

                    timerVal = 7; //Resets the timer value

                    addValue(); //Adds a new number for the loop
                }
                catch
                {
                    return;
                }
               
            }
            else //Else, initiate game over
            {
                gameOver();
            }
        }

        void gameOver()
        {
            inGame = false; //Sets it so the player is not playing anymore

            rememberLabel.Text = "Game Over"; //Visual Showing of Game Over

            startBtn.Enabled = true; // Re-Enables the start button

            numberInput.ReadOnly = true; //Makes it so no more text can be inputted
            numberInput.Enabled = false;

            //Saves the current score && updates the main menu
            if (File.Exists("nmScore.txt")) //Checks if the file already exists to compare the score
            {
                int savedScore = int.Parse(File.ReadAllText("nmScore.txt"));

                if (scoreVal > savedScore)
                {
                    File.WriteAllText("nmScore.txt", scoreVal.ToString());
                }
            }
            else //If it doesn't, just write the data
            {
                File.WriteAllText("nmScore.txt", scoreVal.ToString());
            }

            menu.loadData();
        }

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
