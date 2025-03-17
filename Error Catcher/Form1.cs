namespace Error_Catcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numerical(int value)
        {
            int val = 1; //Current loop of the numerical
            int numericalValue = 1; //Current value of the actual numerical

            while (val < value + 1) //Runs while the value is less than the loops + 1 to ensure it goes through 1 through the value inputted
            {
                numericalValue *= val; //Multiples the numerical to get the new multiplied value

                if (numericalValue >= int.MaxValue || numericalValue <= int.MinValue || numericalValue == 0) //Checks if the new value is out of range or zero, will error out if so
                {
                    throw new ArgumentOutOfRangeException("Value is either out of range or is equal to zero");
                }

                val++; //Adds to the val to continue the loop

            }

            return numericalValue; //Returns the numerical Value
        }


        private void CheckforNumberButton_Click(object sender, EventArgs e)
        {
            try
            {

                int loops = int.Parse(NumberValueInput.Text); //First attempts to parse the input in the text box, will error out if incorrect

                if (loops == 0) //Checks if there is anything inputted, will error out if there is none
                {
                    NumberValueInput.ForeColor = Color.Red;
                    throw new FormatException("Error, input cannot be zero");
                }

                int totalVal = numerical(loops); //Gets the nth degree power value and returns it



                NumberValueInput.ForeColor = Color.Black; //Sets text back to black if turned red by an error
                OutputValue.Text = totalVal.ToString(); //Displays the value of the multiplier

            }
            catch (FormatException ex) //If the format is incorrect or if input equals zero, display
            {
                MessageBox.Show(ex.Message);
                NumberValueInput.ForeColor = Color.Red;
            }
            catch (ArgumentOutOfRangeException ex) //If new multiplier is out of the range of an int value or if it equals zero, display
            {
                MessageBox.Show(ex.Message);
                NumberValueInput.ForeColor = Color.Red;
            }
        }

        void breakString(int loops) //Breaks the input character by character
        {
            int index = 0; //Index of current character

            while(index < loops) //Runs while the index is less than the loop of characters
            {
                Index.Items.Add(StringValueInput.Text[index]); //Adds the index character to the list
                index++; //Adds to the index to continue the loop
            }
        }

        private void BreakStringButton_Click(object sender, EventArgs e)
        {
            Index.Items.Clear(); //Clears the current index

            if(StringValueInput.Text.Length == 0) //Checks if there is anything in the text box before proceeding
            {
                MessageBox.Show("No Input Detected");
                return;
            }

            breakString(StringValueInput.Text.Length); //Runs the function to break up the string
        }
    }
}
