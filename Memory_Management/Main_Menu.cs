namespace Memory_Management
{
    public partial class Main_Menu : Form
    {
        string ssScorefile = "ssScore.txt"; //File reference to Simon Says
        string nmScorefile = "nmScore.txt"; //File reference to Numerical Memory
        string amScorefile = "amScore.txt"; //File reference to Alphabetical Memory


        public Main_Menu()
        {
            InitializeComponent();
            loadData(); //Loads the data if there is any found
        }

        //Function to load data if found, ran whenever a game finishes to update it
        public void loadData()
        {
            //If the file exists, it will update the main menu data accordingly

            try
            {
                if (File.Exists(ssScorefile))
                {
                    string ssScore = File.ReadAllText(ssScorefile);
                    simonHSlabel.Text = $"Simon Says: {ssScore}";
                }

                if (File.Exists(nmScorefile))
                {
                    string nmScore = File.ReadAllText(nmScorefile);
                    numericalmemoryHSlabel.Text = $"Numerical Memory: {nmScore}";
                }

                if (File.Exists(amScorefile))
                {
                    string amScore = File.ReadAllText(amScorefile);
                    alphabeticalmemoryHSlabel.Text = $"Alphabetical Memory: {amScore}";
                }
            }
            catch
            {
                throw new Exception("Failed to read file data");
            }
            
        }

        private void htpBtn_Click(object sender, EventArgs e)
        {
            How_to_Play htp = new How_to_Play(); //Displays the how to play screen, disabling input on the main menu until it is closed
            htp.ShowDialog();

        }

        private void simonsaysBtn_Click(object sender, EventArgs e)
        {
            Simon_Says ss = new Simon_Says(this); //Initializes the simon says form and opens it, hiding this one
            ss.Show();

            this.Hide();
        }

        private void numericalmemoryBtn_Click(object sender, EventArgs e)
        {
            Numerical_Memory nm = new Numerical_Memory(this); //Initializes the numberical memory form and opens it, hiding this one
            nm.Show();

            this.Hide();
        }

        private void alphabeticalmemoryBtn_Click(object sender, EventArgs e)
        {
            Alphabetical_Memory am = new Alphabetical_Memory(this); //Initializes alphabetical memory form and opens it, hiding this one
            am.Show();

            this.Hide();
        }

        //Function that will completely wipe the users data and update it
        private void resetBtn_Click(object sender, EventArgs e)
        {
            //If the files exist, they will be overritten
            if (File.Exists(ssScorefile))
            {
                File.WriteAllText(ssScorefile, "0");
            }

            if (File.Exists(nmScorefile))
            {
                File.WriteAllText (nmScorefile, "0");
            }

            if (File.Exists(amScorefile))
            {
                File.WriteAllText(amScorefile, "0");
            }

            loadData(); //Reloads the data of the reset
        }
    }
}
