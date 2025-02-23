namespace SelectionLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetAllGray(); //Runs the setgray function
        }

        //Sets all the applicable Labels to gray to start
        void SetAllGray()
        {
            foreach (Label label in this.Controls.OfType<Label>()) //Loops through each label on this program
            {
                if (label.Tag == null) //Checks that the iterated labels tag isn't null
                {
                    //Will Do nothing as nothing is applicable in this scenario
                }
                else
                {

                    label.ForeColor = Color.Gray; //Sets all labels with tags to gray in this function

                }


            }
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            foreach (Label label in this.Controls.OfType<Label>()) //Loops through each label on this program
            {
                if (label.Tag == null) //Checks that the iterated labels tag isn't null
                {
                    //Will Do nothing as nothing is applicable in this scenario
                }
                else
                {
                    if (label.Tag.ToString() == UserInput.Text) //Checks if the iterated labels tag is the same as the input
                    {
                        label.ForeColor = Color.Yellow; //Sets the selected tag group to yellow signifying it was selected
                    }
                    else
                    {
                        label.ForeColor = Color.Gray; //Sets the unselected tag group to gray signifying it was not selected
                    }
                }


            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UserInput.Text = ""; //Resets What is current in the users input box
            SetAllGray(); //Resets the class selection, graying everything out
        }
    }
}
