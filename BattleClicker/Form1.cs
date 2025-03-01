namespace BattleClicker
{
    public partial class Form1 : Form
    {
        //Variables
        Random rand = new Random(); //For random implications

        //Stats
        float enemiesKilled = 0; //Display of how enemies have been slain
        int currentGold = 0; //How much gold the user currently has

        int strengthUpgradeCost = 10; //How much it is to upgrade strength again
        int incomeUpgradeCost = 5; //How much it is to upgrade income again

        int curStrength = 1; //Current strength of the player
        int curIncome = 1; //Current income of the player

        //Enemies
        float enemyBaseHealth = 10; //Base health of the enemy when starting <This will be calculated moving forward by a multiplyer of enemies killed>
        float curEnemyHealth = 10; //Current health of the enemy <Base is 10>

        public Form1()
        {
            InitializeComponent();
            EnemyPhoto.Image = enemyPhotoList.Images[rand.Next(0, 6)]; //Displays a random enemy on the screen
        }

        //This functions runs whenever the enemy runs out of health
        void enemyDeath()
        {
            enemiesKilled++; //Adds to the counter of total enemies killed
            currentGold += (curIncome * rand.Next(2, 5)); //Adds to the players gold by income * 2-4

            enemyBaseHealth = 10 + (enemiesKilled * rand.NextSingle()); //Calculates the new health of the next enemy
            curEnemyHealth = enemyBaseHealth; //Sets the new health of the next enemy

            EnemyPhoto.Image = enemyPhotoList.Images[rand.Next(0, 6)]; //Displays a random enemy on the screen
            EnemyHealthLabel.Text = $"{curEnemyHealth.ToString("0.0")}/{enemyBaseHealth.ToString("0.0")}"; //Updates the display of the current enemy health

            checkShop(); //Checks the shop to see if anything can be purchased
            updateStatistics(); //Updates the statistics on the right side of the screen
        }

        //Checks if either button in the shop can be added if the player has enough gold to purchase
        void checkShop()
        {
            if (currentGold >= strengthUpgradeCost) //Checks if the player has enough money to buy a strength upgrade
            {
                upgradeStrengthButton.Enabled = true; //Will enable if true
            }
            else
            {
                upgradeStrengthButton.Enabled = false; //Will disable if false
            }

            if (currentGold >= incomeUpgradeCost) //Checks if the player has enough money to buy an income upgrade
            {
                upgradeIncomeButton.Enabled = true; //Will enable if true
            }
            else
            {
                upgradeIncomeButton.Enabled = false; //Will disable if false
            }
        }

        //Updates the player statistics
        void updateStatistics()
        {
            EnemiesKilledLabel.Text = $"Total Enemies Killed: {enemiesKilled}"; //Updates the display of enemies slain
            CurrentGoldLabel.Text = $"Current Gold Held: {currentGold}"; //Updates the display of how much the player has
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            curEnemyHealth -= rand.Next(curStrength, curStrength + 5); //Damages the enemy by a range of current strength to current strength + 4
            EnemyHealthLabel.Text = $"{curEnemyHealth.ToString("0.0")}/{enemyBaseHealth.ToString("0.0")}"; //Updates the display of the current enemy health

            if (curEnemyHealth <= 0) //Checks if the enemies current health is now equal or less than 0
            {
                enemyDeath(); //Runs the enemy death function if this returns true
            }
        }

        private void upgradeStrengthButton_Click(object sender, EventArgs e)
        {
            currentGold -= strengthUpgradeCost; //Subtracts the cost by held gold
            curStrength++; //Adds to the current strength by one

            strengthUpgradeCost += strengthUpgradeCost / rand.Next(2, 5); //Increases the cost by 1/2 to 1/4 of the current cost
            CurStrengthLabel.Text = $"Current Strength: {curStrength}"; //Displays the new strength level

            upgradeStrengthButton.Text = $"Upgrade Strength - Cost {strengthUpgradeCost}"; //Updates the button to display the new cost

            checkShop(); //Check to see if the button needs to be deactivated
            updateStatistics(); //Updates the UI on both sides respectively
        }

        private void upgradeIncomeButton_Click(object sender, EventArgs e)
        {
            currentGold -= incomeUpgradeCost; //Stracts the cost by held gold
            curIncome++; //Adds to the current income by one

            incomeUpgradeCost += incomeUpgradeCost / rand.Next(2, 5); //Increases the cost by 1/2 to 1/4 of the current cost
            CurIncomeLabel.Text = $"Current Income: {curIncome}"; //Displays the new income level

            upgradeIncomeButton.Text = $"Upgrade Income - Cost {incomeUpgradeCost}"; //Updates the button to display the new cost

            checkShop(); //Check to see if the button needs to be deactivated
            updateStatistics(); //Updates the UI on both sides respectively
        }
    }
}
