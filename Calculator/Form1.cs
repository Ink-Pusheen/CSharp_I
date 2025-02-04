namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            valuesnfactors.Add(""); //Adds to the list on initialization for functionality purposes
        }

        //Variables

        List<string> valuesnfactors = new List<string>(); //List of all values and math signs
        int currentslot = 0; //Current slot in the list of values and signs

        bool needsclearing = false; //Failsafe, if the player did a calculation, they need to press A/C before proceeding.

        private void KeyClear_Click(object sender, EventArgs e) //Completely clears the current input of strings in the index, resets it, and resets the failsafe and current index
        {
            valuesnfactors.Clear();
            valuesnfactors.Add("");
            needsclearing = false;
            currentslot = 0;
            updateUI();
        }

        #region Keypresses 0-9

        private void Key1_Click(object sender, EventArgs e) //Adds a 1 to the current index value
        {
            if (needsclearing) return;
            valuesnfactors[currentslot] += "1";
            updateUI();
        }

        private void Key2_Click(object sender, EventArgs e) //Adds a 2 to the current index value
        {
            if (needsclearing) return;
            valuesnfactors[currentslot] += "2";
            updateUI();
        }

        private void Key3_Click(object sender, EventArgs e) //Adds a 3 to the current index value
        {
            if (needsclearing) return;
            valuesnfactors[currentslot] += "3";
            updateUI();
        }

        private void Key4_Click(object sender, EventArgs e) //Adds a 4 to the current index value
        {
            if (needsclearing) return;
            valuesnfactors[currentslot] += "4";
            updateUI();
        }

        private void Key5_Click(object sender, EventArgs e) //Adds a 5 to the current index value
        {
            if (needsclearing) return;
            valuesnfactors[currentslot] += "5";
            updateUI();
        }

        private void Key6_Click(object sender, EventArgs e) //Adds a 6 to the current index value
        {
            if (needsclearing) return;
            valuesnfactors[currentslot] += "6";
            updateUI();
        }

        private void Key7_Click(object sender, EventArgs e) //Adds a 7 to the current index value
        {
            if (needsclearing) return;
            valuesnfactors[currentslot] += "7";
            updateUI();
        }

        private void Key8_Click(object sender, EventArgs e) //Adds a 8 to the current index value
        {
            if (needsclearing) return;
            valuesnfactors[currentslot] += "8";
            updateUI();
        }

        private void Key9_Click(object sender, EventArgs e) //Adds a 9 to the current index value
        {
            if (needsclearing) return;
            valuesnfactors[currentslot] += "9";
            updateUI();
        }

        private void Key0_Click(object sender, EventArgs e) //Adds a 0 to the current index value
        {
            if (needsclearing) return;
            valuesnfactors[currentslot] += "0";
            updateUI();
        }

        private void KeyBackSpace_Click(object sender, EventArgs e) //Removes items from index and from values of the current selection
        {
            if (needsclearing) return; //Ensures program doesn't need a reset

            if (valuesnfactors[currentslot] == "" && valuesnfactors.Count > 2) //Checks if the current index number is empty and if there is currently more than one number in the list
            {
                valuesnfactors.RemoveAt(currentslot); //Removes the number slot
                valuesnfactors.RemoveAt(currentslot - 1); //Removes the mathematical sign slot
                currentslot -= 2; //Moves down two in the index
                updateUI();
            }
            else
            {
                if (valuesnfactors[currentslot].Length == 0) //Checks if the current index character count is equal to zero, if not, it will remove the last character
                {
                    MessageBox.Show("Value to short");
                    return;
                }
                else
                {
                    //First thing researched online, removing the last item from a string, forgot it was a two step process, using the string as a local variable then setting it

                    string removed = valuesnfactors[currentslot].Substring(0, valuesnfactors[currentslot].Length - 1); // Creates a substring from the current string without the last set digit
                    valuesnfactors[currentslot] = removed; // Sets the current arranged value without that deleted number
                    updateUI();
                }

            }
        }

        #endregion

        #region Math Signs
        private void KeyAdd_Click(object sender, EventArgs e)
        {
            if (needsclearing) return; //Ensures program doesn't need a reset

            valuesnfactors.Add("+");
            valuesnfactors.Add("");
            currentslot += 2;
            updateUI();
        }

        private void KeySubtract_Click(object sender, EventArgs e)
        {
            if (needsclearing) return; //Ensures program doesn't need a reset

            valuesnfactors.Add("-");
            valuesnfactors.Add("");
            currentslot += 2;
            updateUI();
        }

        private void KeyMultiply_Click(object sender, EventArgs e)
        {
            if (needsclearing) return; //Ensures program doesn't need a reset

            valuesnfactors.Add("*");
            valuesnfactors.Add("");
            currentslot += 2;
            updateUI();
        }

        private void KeyDivide_Click(object sender, EventArgs e)
        {
            if (needsclearing) return; //Ensures program doesn't need a reset

            valuesnfactors.Add("/");
            valuesnfactors.Add("");
            currentslot += 2;
            updateUI();
        }

        #endregion

        private void KeyEquals_Click(object sender, EventArgs e)
        {
            if (needsclearing) return;
            if (valuesnfactors.Count <= 1) return;
            needsclearing = true;
            MathCalculation();
        }

        void MathCalculation()
        {
            //Second thing researched for this work, Inserting a value at a certain spot of index in a list. Learned that it is (listname).Insert(index of insertion, what's being added)


            #region Sign Checker

            //Correct Version, checking the signs in an order before moving to the next

            if (valuesnfactors.Contains("0"))
            {
                for(int i = 0;  i < valuesnfactors.Count; i++)
                {
                    if(valuesnfactors[i] == "0")
                    {
                        if (i == 0)
                        {
                            //Absolutely nothing
                        }
                        else
                        {
                            if (valuesnfactors[i - 1] == "/")
                            {
                                NewCalcScreen.Text = "Cannot Divide by 0, Press A/C to Reset";
                                valuesnfactors.Clear();
                                return;
                            }
                        }
                        
                    }
                }
            }

            if (valuesnfactors.Contains("*")) //Checks if the index has any * signs
            {
                for(int i = 0; i < valuesnfactors.Count; i++)
                {
                    if (valuesnfactors[i] == "*")
                    {
                        int multVal = Convert.ToInt32(valuesnfactors[i - 1]) * Convert.ToInt32(valuesnfactors[i + 1]); //Get the Multiplied Value of the number indexes left and right of the identified of the sign


                        valuesnfactors.RemoveAt(i + 1); //Removes the second calculated number, sign, and then first calculated number from the registry in that order (Via RemoveAt)

                        valuesnfactors.Insert(i + 1, multVal.ToString()); //Adds the newly multiplied value to the index the second value in this equation was

                        valuesnfactors.RemoveAt(i);
                        valuesnfactors.RemoveAt(i - 1);

                        CheckforOutput(); //Checks the loop
                        return; //Breaks the loop
                    }
                }
            }

            if (valuesnfactors.Contains("/")) //Checks if the index has and / signs
            {
                for(int i = 0; i < valuesnfactors.Count; i++)
                {
                    //Third thing with online research, changing a float to an int.. its stupid. First make a local float using the values in the equation, the changing it with the (int) tag next to the float

                    if(valuesnfactors[i] == "/")
                    {
                        float needtoRound = Convert.ToInt32(valuesnfactors[i - 1]) / Convert.ToInt32(valuesnfactors[i + 1]); //Get the float Divided Value of the number indexes left and right of the identified of the sign
                        int divVal = (int)needtoRound; //Sets the float as an integer within the equation


                        valuesnfactors.RemoveAt(i + 1); //Removes the second calculated number, sign, and then first calculated number from the registry in that order (Via RemoveAt)

                        valuesnfactors.Insert(i + 1, divVal.ToString()); //Adds the newly divided value to the index the second value in this equation was

                        valuesnfactors.RemoveAt(i);
                        valuesnfactors.RemoveAt(i - 1);

                        CheckforOutput(); //Checks the loop
                        return; //Breaks the loop
                    }
                }
            }

            if (valuesnfactors.Contains("+")) //Checks if the index has any + signs
            {
                for(int i = 0;i < valuesnfactors.Count; i++)
                {
                    if (valuesnfactors[i] == "+")
                    {
                        int addVal = Convert.ToInt32(valuesnfactors[i - 1]) + Convert.ToInt32(valuesnfactors[i + 1]); //Get the Added Value of the number indexes left and right of the identified of the sign


                        valuesnfactors.RemoveAt(i + 1); //Removes the second calculated number, sign, and then first calculated number from the registry in that order (Via RemoveAt)

                        valuesnfactors.Insert(i + 1, addVal.ToString()); //Adds the newly added value to the index the second value in this equation was

                        valuesnfactors.RemoveAt(i);
                        valuesnfactors.RemoveAt(i - 1);

                        CheckforOutput(); //Checks the loop
                        return; //Breaks the loop
                    }
                }
            }

            if (valuesnfactors.Contains("-")) //Checks if the index has and - signs
            {
                for(int i = 0; i < valuesnfactors.Count; i++)
                {
                    if(valuesnfactors[i] == "-")
                    {
                        int subVal = Convert.ToInt32(valuesnfactors[i - 1]) - Convert.ToInt32(valuesnfactors[i + 1]); //Get the Subtracted Value of the number indexes left and right of the identified of the sign


                        valuesnfactors.RemoveAt(i + 1); //Removes the second calculated number, sign, and then first calculated number from the registry in that order (Via RemoveAt)

                        valuesnfactors.Insert(i + 1, subVal.ToString()); //Adds the newly subtracted value to the index the second value in this equation was

                        valuesnfactors.RemoveAt(i);
                        valuesnfactors.RemoveAt(i - 1);

                        CheckforOutput(); //Checks the loop
                        return; //Breaks the loop
                    }
                }
            }
            
        }

        #endregion

        void CheckforOutput() //Checks if the index only has one remaining value, if it doesn't, it will run the Math Calculation again until there are only one in the index
        {
            if (valuesnfactors.Count == 1)
            {
                updateUI();
            }
            else
            {
                MathCalculation();
            }
        }

        void updateUI()
        {
            NewCalcScreen.Text = "";

            for (int i = 0; i < valuesnfactors.Count; i++)
            {
                NewCalcScreen.Text += valuesnfactors[i] + " ";
                
            }
        }
    }
}
