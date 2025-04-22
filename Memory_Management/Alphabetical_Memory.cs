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
    public partial class Alphabetical_Memory : Form
    {
        //List of all possible words that can appear and the list it will be saved to
        string[] words = {"ad-lib", "air", "aircraft", "amok", "among", "any", "anybody", "arsenic", "arson", "attribute", "auction", "bacterium", "bad", "bask", "bassoon", "beret", "berry", "blackmail", "blackout"
        , "bogus", "boil", "breach", "bread", "budget", "buff", "cabinet", "cable", "care", "career", "cerebral", "cerebrum", "chilly", "chime", "clash", "clasp", "coerce", "coffee", "company", "compare", "congradulate"
        , "congregate", "convection", "convene", "counterpart", "countersign", "crow", "dance", "dandelion", "defect", "defend", "descend", "describe", "dilemma", "diligent", "dispatch", "dispense", "door", "dope"
        , "drum", "drumstick", "edgewise", "edgy", "emulate", "emulsion", "erratic", "erroneous", "exodus", "exonerate", "fad", "fade", "feign", "felicitate", "firework", "firm", "flush", "fluster", "forthright"
        , "fortify", "full-fledged", "fumble", "gave", "gavel", "glass", "glaucoma", "gram", "grammar", "guard", "guardian", "handicap", "handicraft", "heartless", "heartwarming", "hoarse", "hoax", "hum", "human"
        , "image", "imaginary", "inconvenience", "incorporate", "insane", "inscribe", "invertebrate", "invest", "job", "jockey", "knight", "lazy", "limp", "line", "loyal", "lubricate", "manage", "mandate", "me"
        , "meadow", "metric", "missionary", "misspell", "motion", "name", "namely", "nineteen", "ninety", "obese", "obey", "opportunism", "opportunity", "oversight", "overtake", "parley", "parliament", "pelvis"
        , "pen", "photograph", "phrase", "platform", "platinum", "pope", "popular", "premise", "premium", "prod", "prodigal", "psychiatry", "psychic", "queue", "quibble", "rational", "rationale", "refer", "referee"
        , "remote", "resume", "ripe", "ripple", "runaway", "rung", "scalp", "scamper", "seesaw", "segment", "sharp", "shatter", "silver", "similar", "smash", "smear", "south", "southeast", "sprite", "sprout"
        , "sterile", "stern", "studio", "studious", "sure", "surely", "tag", "tension", "tent", "tick", "ticket", "tough", "tour", "trip", "triple", "tzar", "uninteresting", "union", "vaccine", "vacuum", "vigil"
        , "vigilant", "war", "warble", "weight", "weird", "wife", "wig", "work", "workday", "x-ray", "yeasty", "yell", "zero"};

        List<string> seenWords = new List<string>(); //List that accumulates all words that have been seen

        //Randomness

        Random rand = new Random();

        //Variables

        int scoreVal = 0; //Current score of the game [Default - 0]

        int index; //Currently selected index

        //Booleans

        bool inGame = false; //Is the player currently playing?

        //Reference to the main menu

        Main_Menu menu;

        public Alphabetical_Memory(Main_Menu menuInput)
        {
            InitializeComponent();
            menu = menuInput;
        }

        //Function to full reset the game before starting
        void resetGame()
        {
            seenWords.Clear(); //Clears the seen words list
            scoreVal = 0; //Resets the score
        }

        //Function to start the applications
        private void startBtn_Click(object sender, EventArgs e)
        {
            resetGame(); //Resets the game before starting it

            startBtn.Enabled = false; //Disables the start button

            seenBtn.Enabled = true; //Enables the seen and new buttons
            newBtn.Enabled = true;

            inGame = true; //Makes it so it registers the user as playing

            displayWord(); //Runs the display word function to display a new word
        }

        //Function to show a word from the entire list
        void displayWord()
        {
            if (scoreVal > 1)
            {
                int repeat = rand.Next(1, 5); //Generates a value between 1 and 4

                if (repeat == 4) //If the random returns a 4, it will show a word that was already displayed
                {
                    int selection = rand.Next(0, seenWords.Count); //Generates a random value between 0 and the currently seen words

                    index = Array.IndexOf(words, seenWords[selection]); //Finds the index of the word that already been shown

                    shownWord.Text = words[index]; //Displays the given word with the newly assigned index
                }
                else //Else it gives the user a new word to remember
                {
                    index = rand.Next(0, words.Length); //Gets a random word from 0 to the length of the array

                    shownWord.Text = words[index]; //Displays the given word with the newly assigned index
                }
            }
            else
            {
                index = rand.Next(0, words.Length); //Gets a random word from 0 to the length of the array

                shownWord.Text = words[index]; //Displays the given word with the newly assigned index
            }
        }

        //Function to initiate game over
        void gameOver()
        {
            startBtn.Enabled = true; //Enables the start button

            seenBtn.Enabled = false; //Disables the seen and new buttons
            newBtn.Enabled = false;

            inGame = false; //Makes it so it registers that the player isn't playing anymore

            //Saves the current score && updates the main menu
            if (File.Exists("amScore.txt")) //Checks if the file already exists to compare the score
            {
                int savedScore = int.Parse(File.ReadAllText("amScore.txt"));

                if (scoreVal > savedScore)
                {
                    File.WriteAllText("amScore.txt", scoreVal.ToString());
                }
            }
            else //If it doesn't, just write the data
            {
                File.WriteAllText("amScore.txt", scoreVal.ToString());
            }

            menu.loadData();
        }

        //Function that runs if the new word button was clicked
        private void newBtn_Click(object sender, EventArgs e)
        {
            if (!seenWords.Contains(words[index])) //Case this word has not been seen yet
            {
                seenWords.Add(words[index]);

                scoreVal++; //Adds to the score and updates the score value
                scoreLabel.Text = $"Score: {scoreVal}";

                displayWord(); //Display a new Word
            }
            else //Case this word has already been seen
            {
                //Initiate Game Over
                gameOver();

                shownWord.Text = "Game Over"; //Display Game Over
            }
        }

        //Function that runs if the seen word button was clicked
        private void seenBtn_Click(object sender, EventArgs e)
        {
            if (seenWords.Contains(words[index])) //Case this word has been seen
            {
                scoreVal++; //Adds to the score and updates the score value
                scoreLabel.Text = $"Score: {scoreVal}";

                displayWord(); //Display a new Word
            }
            else //Case this word has not been seen
            {
                //Initiate Game Over
                gameOver();

                shownWord.Text = "Game Over"; //Display Game Over
            }
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
