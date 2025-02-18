namespace SimpleBlackJack
{
    public partial class Form1 : Form
    {
        Random rand; //Random for the psuedo random

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        string[] cards = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        int PCardScores; //Players current score of cards
        List<string> PCardNames = new List<string>(); //String names for the players cards

        int DCardScores; //Dealers current score of cards
        List<string> DCardNames = new List<string>(); //String names for the dealers cards

        bool playerTurn = true; //Is it currently the players turn? <Default True>

        bool playerCalled = false; //Did the player call for this round? <Default False>
        bool dealerCalled = false; //Did the dealer call for this round? <Default False>

        private void HitButton_Click(object sender, EventArgs e)
        {
            if (playerCalled) //If the player has called already, it will display so and nullify and further code
            {
                MessageBox.Show("Already out for round");
                return;
            }

            int randomCard = rand.Next(0, 13); //Generates a value between 0-12 

            AddValues(playerTurn, randomCard); //Adds he new card and value to the player
            playerTurn = false; //Sets it so it isn't the player turn
            UpdatePlayerHand(); //Updates the UI to display the new acquired card

            

            SwapTurn(); //Runs the swap turn function
        }

        private void CallButton_Click(object sender, EventArgs e)
        {
            playerCalled = true;
            PlayerCallStatus.Text = "Called";
            SwapTurn(); //Runs the swap turn function
        }

        //Function that enacts the dealers turn
        void DealerTurn()
        {
            Thread.Sleep(100); //Delay for 1/10 of a second

            if(DCardScores >= 21) //Checks if it has perfect or bust already
            {
                dealerCalled = true; //Sets the dealer called bool to true
                playerTurn = true; //Sets it so it is now the players turn

                DealerCallStatus.Text = "Called"; //Displays that the dealer called for this round

                SwapTurn(); //Runs the swap turn function
                return; //Returns so no further code runs
            }

            if (DCardScores <= 15) //Checks if the dealers score is greater than or equal to 15
            {

                int randomCard = rand.Next(0, 13); //Generates a random number beween 0-12

                AddValues(playerTurn, randomCard); //Adds the new card and value to the dealer
                playerTurn = true; //Sets it so it is now the players turn

                
                SwapTurn(); //Runs the swap turn function
            }
            else
            {
                int choice = rand.Next(0, 5); //Generates a random value to see if the dealer will draw again

                if (choice <= 2) //Checks if the dealer wants to risk another roll
                {

                    int randomCard = rand.Next(0, 13); //Generates a random number between 0-12

                    AddValues(playerTurn, randomCard); //Adds the new card and value to the dealer
                    playerTurn = true; //Sets it so it is now the players turn

                    
                    SwapTurn(); //Runs the swap turn function
                }
                else //Else dealer calls for this round
                {

                    dealerCalled = true; //Sets the dealer called bool to true
                    playerTurn = true; //Sets it to be the players turn

                    DealerCallStatus.Text = "Called"; //Displays that the dealer called for this round

                    SwapTurn(); //Runs the swap turn function
                }
            }
        }

        void SwapTurn()
        {
            bool status = checkCallStatus(playerCalled, dealerCalled); //Returns if both have called

            if (status) //If both sides returned true
            {
                Thread.Sleep(1000); //Delay for 1 second
                RevealDealerHand(); //Function to reveal the dealers hand
                return; //Returns so no other code further runs
            }

            bool yourTurn = TurnStatus(); //Checks if it's the players turn



            switch (yourTurn) //Switch case that swaps between the player and dealers turn accordingly
            {
                case false: //Case dealers turn
                    if (dealerCalled) //Checks if the dealer has already called this round
                    {
                        playerTurn = true; //Sets the player turn to true
                        SwapTurn(); //Runs the swap turn function
                    }
                    else
                    {
                        //TurnLabel.Text = "Dealer Turn"; //Display to show it's the dealers turn

                        DealerTurn(); //Runs the dealers turn
                    }
                    break;

                case true: //Case players turn
                    if (playerCalled) //Checks if the player already called this round
                    {
                        playerTurn = false; //Sets player turn to false
                        SwapTurn(); //Runs the swap turn function again
                    }
                    else
                    {
                        
                    }
                    break;

            }
        }

        //Checks if it is the player or dealers turn
        bool TurnStatus()
        {
            switch (playerTurn) //Switch case that returns if it is the player or dealers turn
            {
                case false: //Case dealers turn
                    return false;

                case true: //Case players turn
                    return true;
            }
        }

        //Returns if both sides have called this round <Parameters of the playerCalled and dealerCalled variables
        bool checkCallStatus(bool playerstatus, bool dealerstatus)
        {
            bool BothCalled = playerstatus && dealerstatus;
            return BothCalled; //Returns true if both are true, else returns false
        }

        //Checks whos turn it is and the value being added
        void AddValues(bool playerTurn, int valueAdded)
        {
            switch (playerTurn) //Checks if it is the players turn
            {
                case false: //Case it is not players turn
                    DCardScores += values[valueAdded]; //Adds to the dealers total score
                    DCardNames.Add(cards[valueAdded]); //Adds to the dealers current cards
                    break;

                case true: //Case it is palyers turn
                    PCardScores += values[valueAdded]; //Adds to the players total score
                    PCardNames.Add(cards[valueAdded]); //Adds to the players current cards


                    break;
            }
        }

        //Function to show the dealers hand before score tally
        void RevealDealerHand()
        {
            DScore.Text = $"{DCardScores}/21"; //Displays the dealers score out of 21

            string dealerCards = ""; //Local string to set the dealers cards

            for (int i = 0; i < DCardNames.Count; i++) //For loop to add to the local string
            {
                dealerCards += DCardNames[i] + " "; //Adds to the local string variable
            }

            DealerHand.Text = dealerCards; //Displays the dealers current cards

            Thread.Sleep(1000); //Delay for 1 second

            CheckScores(); //Runs the check score function to declare the winner
        }

        void UpdatePlayerHand()
        {
            string playerCards = ""; //Local string to set the players cards

            for (int i = 0; i < PCardNames.Count; i++) //For loop to add to the local string
            {
                playerCards += PCardNames[i] + " "; //Adds to the local string variable
            }

            PlayerHand.Text = playerCards; //Displays the players current cards

            PScore.Text = $"{PCardScores}/21"; //Displays the players score out of 21
        }

        //Checks for busts and scores before resetting
        void CheckScores()
        {
            if(PCardScores > 21 && DCardScores > 21)
            {
                MessageBox.Show("Both Sides Bust");
            }
            else if(PCardScores == 21 && DCardScores == 21 || PCardScores == DCardScores)
            {
                MessageBox.Show("Tie");
            }
            else if(PCardScores > 21)
            {
                MessageBox.Show("Player Bust, Dealer Wins");
            }
            else if(DCardScores > 21)
            {
                MessageBox.Show("Dealer Bust, Player Wins");
            }
            else
            {
                if(PCardScores > DCardScores)
                {
                    MessageBox.Show($"Player wins {PCardScores} to {DCardScores}");
                }
                else
                {
                    MessageBox.Show($"Dealer wins {DCardScores} to {PCardScores}");
                }
            }

            ResetGame();

        }

        //Resets the game
        void ResetGame()
        {
            PCardScores = 0; //Resets the players score
            PCardNames.Clear(); //Clears the players hand of strings

            DCardScores = 0; //Resets the dealer score
            DCardNames.Clear(); //Clears the dealers hand of strings

            playerCalled = false; //Resets the players call for the round
            dealerCalled = false; //Resets the dealer call for the round

            DealerHand.Text = "-"; //Resets the dealers hand display
            DScore.Text = "?/21"; //Resets the dealers score display

            PScore.Text = "0/21"; //Resets the players score display
            PlayerHand.Text = "-"; //Resets the players hand display

            PlayerCallStatus.Text = "Still Playing";
            DealerCallStatus.Text = "Still Playing";

            playerTurn = true; //Sets it to be the players turn

            SwapTurn(); //Runs the swap turn funcntion to restart the game
        }
    }
}
