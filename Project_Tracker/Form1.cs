using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_Tracker
{
    public partial class Form1 : Form
    {


        List<int> listYear = new List<int>();
        List<int> listMonth = new List<int>();
        List<int> listDay = new List<int>();


        private int[] dateVals = { 2025, 3, 4 }; //Values for the years, month, and day for organizational purposes

        public Form1()
        {
            InitializeComponent();
        }

        private void organizeList() //Organize function which afterwards adds the new date and assignment
        {
            if (assignmentList.Items.Count >= 1) //Will run this if there are one or more items in the list
            {
                for (int i = 0; i < assignmentList.Items.Count; i++) //Runs a loop for how many items are in the combobox
                {
                    if (dateVals[0] <= listYear[i] && dateVals[1] <= listMonth[i] && dateVals[2] <= listDay[i]) //Checks if the assignment is on the same day or is less than what the next assignment is
                    {
                        assignmentList.Items.Insert(i, $"'{nameInput.Text}' " + $"Due: {calSelection.SelectionRange.Start.ToString("yyyy-MM-dd")} 11:59PM"); //Adds the assignment by the name and proper date to the combobox
                        assignmentsCB.Items.Insert(i, $"{nameInput.Text}"); //Inserts the assignment name into the combobox list

                        listYear.Insert(i, dateVals[0]); //Adds the prompted year, month, and day in their respective order
                        listMonth.Insert(i, dateVals[1]);
                        listDay.Insert(i, dateVals[2]);

                        MessageBox.Show($"Added at {i} under"); //Indicates if it was placed at the top or middle of the list
                        break;
                    }
                    else if (i == assignmentList.Items.Count - 1) //Checks if it is at the last possible loop
                    {
                        assignmentList.Items.Insert(i + 1, $"'{nameInput.Text}' " + $"Due: {calSelection.SelectionRange.Start.ToString("yyyy-MM-dd")} 11:59PM"); //Adds the assignment by the name and proper date to the combobox
                        assignmentsCB.Items.Insert(i + 1, $"{nameInput.Text}"); //Inserts the assignment name into the combobox list

                        listYear.Insert(i + 1, dateVals[0]); //Adds the prompted year, month, and day in their respective order
                        listMonth.Insert(i + 1, dateVals[1]);
                        listDay.Insert(i + 1, dateVals[2]);

                        MessageBox.Show($"Added at {i} over"); //Indicates if it was added to the bottom of the list
                        break;
                    }
                    else
                    {
                        continue; //Continues to the next iteration if nothing applied
                    }
                }
            }
            else
            {
                assignmentList.Items.Add($"'{nameInput.Text}' " + $"Due: {calSelection.SelectionRange.Start.ToString("yyyy-MM-dd")} 11:59PM"); //Adds the assignment by the name and proper date to the combobox
                assignmentsCB.Items.Add($"{nameInput.Text}"); //Inserts the assignment name into the combobox list
                assignmentsCB.SelectedIndex = 0;

                listYear.Add(dateVals[0]); //Adds the prompted year, month, and day in their respective order
                listMonth.Add(dateVals[1]);
                listDay.Add(dateVals[2]);
            }


        }

        private void assignmentaddBtn_Click(object sender, EventArgs e)
        {
            if (nameInput.Text == "") //First checks if there is anything inputted in the text field
            {
                MessageBox.Show("No Assignment Name Found");
                return;
            }

            dateVals[0] = calSelection.SelectionRange.Start.Year; //Sets the value of the year, month, and day to the array in their respective spots for organization
            dateVals[1] = calSelection.SelectionRange.Start.Month;
            dateVals[2] = calSelection.SelectionRange.Start.Day;

            organizeList(); //Runs the organize function which afterwards adds the new date and assignment


        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            if(assignmentsCB.Items.Count == 0) //First checks if there is anything in the list of assignments
            {
                MessageBox.Show("No Assignment to mark as Complete");
                return;
            }

            //Removes the information from their respective slot
            listYear.RemoveAt(assignmentsCB.SelectedIndex);
            listMonth.RemoveAt(assignmentsCB.SelectedIndex);
            listDay.RemoveAt(assignmentsCB.SelectedIndex);

            assignmentList.Items.RemoveAt(assignmentsCB.SelectedIndex);
            assignmentsCB.Items.RemoveAt(assignmentsCB.SelectedIndex);

            assignmentsCB.Text = "";

        }
    }
}
