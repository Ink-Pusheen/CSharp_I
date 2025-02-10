namespace ColorMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Color indexes <Red - 0, Blue - 1, Green -2>
        int color1Index; //Color of the first slot
        int color2Index; //Color of the second slot

        private void ColorBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ColorBox1.Text) //Alteration of the first combo box colors
            {
                case "Red": //Changes the first combo box selection to red
                    ColorInput1.Text = "Red"; //Sets label text to red and colors it red
                    ColorInput1.ForeColor = Color.Red;
                    color1Index = 0; //Sets first index to red
                    break;

                case "Blue": //Changes the first combo box selection to blue
                    ColorInput1.Text = "Blue"; //Sets Lavel text to blue and colors it blue
                    ColorInput1.ForeColor = Color.Blue;
                    color1Index = 1; //Sets first index to blue
                    break;

                case "Yellow": //Changes the first combo box selection to yellow
                    ColorInput1.Text = "Yellow"; //Sets Label text to yellow and colors it yellow
                    ColorInput1.ForeColor = Color.Yellow;
                    color1Index = 2; //Sets first index to yellow
                    break;
            }
        }

        private void ColorBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ColorBox2.Text)
            {
                case "Red": //Changes the second combo box selection to red
                    ColorInput2.Text = "Red"; //Sets label text to red and colors it red
                    ColorInput2.ForeColor = Color.Red;
                    color2Index = 0; //Sets second index to red
                    break;

                case "Blue": //Changes the second combo box selection to blue
                    ColorInput2.Text = "Blue"; //Sets Lavel text to blue and colors it blue
                    ColorInput2.ForeColor = Color.Blue;
                    color2Index = 1; //Sets second index to blue
                    break;

                case "Yellow": //Changes the second combo box selection to yellow
                    ColorInput2.Text = "Yellow"; //Sets Label text to yellow and colors it yellow
                    ColorInput2.ForeColor = Color.Yellow;
                    color2Index = 2; //Sets second index to yellow
                    break;
            }
        }

        private void CalcColor_Click(object sender, EventArgs e) //Formulates the new color
        {
            switch (color1Index) //Switch statement based off the first input
            {
                case 0: //First color is red
                    switch (color2Index)
                    {
                        case 0: //Second Color is red
                            OutputColor.Text = "Red";
                            OutputColor.ForeColor = Color.Red;
                            break;

                        case 1: //Second Color is blue
                            OutputColor.Text = "Purple";
                            OutputColor.ForeColor = Color.Purple;
                            break;

                        case 2: //Secondary color is yellow
                            OutputColor.Text = "Orange";
                            OutputColor.ForeColor = Color.Orange;
                            break;
                    }
                    break;

                case 1: //First color is blue
                    switch (color2Index)
                    {
                        case 0: //Second Color is red
                            OutputColor.Text = "Purple";
                            OutputColor.ForeColor = Color.Purple;
                            break;

                        case 1: //Second Color is blue
                            OutputColor.Text = "Blue";
                            OutputColor.ForeColor = Color.Blue;
                            break;

                        case 2: //Secondary color is yellow
                            OutputColor.Text = "Green";
                            OutputColor.ForeColor = Color.Green;
                            break;
                    }
                    break;

                case 2: //First color is yellow
                    switch (color2Index)
                    {
                        case 0: //Second Color is red
                            OutputColor.Text = "Orange";
                            OutputColor.ForeColor = Color.Orange;
                            break;

                        case 1: //Second Color is blue
                            OutputColor.Text = "Green";
                            OutputColor.ForeColor = Color.Green;
                            break;

                        case 2: //Secondary color is yellow
                            OutputColor.Text = "Yellow";
                            OutputColor.ForeColor = Color.Yellow;
                            break;
                    }
                    break;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ColorBox1.Text = "Red";
            ColorBox2.Text = "Red";

            color1Index = 0;
            color2Index = 0;

            ColorInput1.Text = "Red";
            ColorInput2.Text = "Red";

            ColorInput1.ForeColor = Color.Red;
            ColorInput2.ForeColor = Color.Red;

            OutputColor.Text = "Red";
            OutputColor.ForeColor= Color.Red;
        }
    }
}
