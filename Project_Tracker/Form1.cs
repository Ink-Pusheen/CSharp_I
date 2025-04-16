using System.Collections;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_Tracker
{
    public partial class Form1 : Form
    {
        string yearSavePath = "year_due.txt"; //Txt file for the saved years
        string monthSavePath = "month_due.txt"; //Txt File for the saved months
        string daySavePath = "day_due.txt"; //Txt File for the saved days

        string assignmentSavePath = "assignments.txt"; //Txt file for the saved assignments

        List<int> listYear = new List<int>(); //Integer lists for comparing where to slot items
        List<int> listMonth = new List<int>();
        List<int> listDay = new List<int>();

        List<string> tempYear = new List<string>(); //String lists for saving the data
        List<string> tempMonth = new List<string>();
        List<string> tempDay = new List<string>();


        private int[] dateVals = { 2025, 3, 4 }; //Values for the years, month, and day for organizational purposes

        private List<string> savedAssignments = new List<string>(); //List of assignment names

        public Form1()
        {
            InitializeComponent();
            loadFiles();
        }

        void loadFiles() //Function that will check if there are files saved and will load them if they do
        {
            if (File.Exists(assignmentSavePath))
            {
                savedAssignments = File.ReadAllLines(assignmentSavePath).ToList(); //Converts the file contents to the list of assignments

                if (savedAssignments.Count == 0) //If there are no detected assignments, it will stop the execution of this code
                {
                    return;
                }

                List<string> tempYear = File.ReadLines(yearSavePath).ToList(); //Creates temporary lists for year month and day for parsing
                List<string> tempMonth = File.ReadLines(monthSavePath).ToList();
                List<string> tempDay = File.ReadLines(daySavePath).ToList();
                
                for (int i = 0; i < savedAssignments.Count; i++) //Loop for parsing the values
                {
                    listYear.Add(int.Parse(tempYear[i])); //Adds the parsed days into their respective lists
                    listMonth.Add(int.Parse(tempMonth[i]));
                    listDay.Add(int.Parse(tempDay[i]));
                }

                for (int i = 0; i < savedAssignments.Count; i++) //Loop for adding the information
                {
                    assignmentList.Items.Add($"'{savedAssignments[i]}' Due: {listYear[i]}-{listMonth[i]}-{listDay[i]} 11:59PM");
                    assignmentsCB.Items.Add(savedAssignments[i]);
                }

            }
            else
            {
                //No File to Load
                MessageBox.Show("No Saved File");

                //Creates the necessary files
                File.WriteAllText(yearSavePath, ""); //Resets the year saves
                File.WriteAllText(monthSavePath, ""); //Resets the month saves
                File.WriteAllText(daySavePath, ""); //Resets the day saves
                File.WriteAllText(assignmentSavePath, ""); //Resets the assignment saves
            }
        }

        void updateFiles() //Function that will update the corresponding files accordingly
        {
            tempYear.Clear(); //Clears these lists before resetting them
            tempMonth.Clear();
            tempDay.Clear();

            for (int i = 0; i < assignmentList.Items.Count; i++)
            {
                tempYear.Add(listYear[i].ToString()); //Adds the time frames to their respective matters
                tempMonth.Add(listMonth[i].ToString());
                tempDay.Add(listDay[i].ToString());
            }

            MessageBox.Show("Formatting");

            File.WriteAllText(yearSavePath, ""); //Resets the year saves
            File.WriteAllText(monthSavePath, ""); //Resets the month saves
            File.WriteAllText(daySavePath, ""); //Resets the day saves

            File.WriteAllText(assignmentSavePath, ""); //Resets the assignment saves

            File.WriteAllLines(yearSavePath, tempYear.ToArray()); //Saves the year values
            File.WriteAllLines(monthSavePath, tempMonth.ToArray()); //Saves the month values
            File.WriteAllLines(daySavePath, tempDay.ToArray()); //Saves the day values

            File.WriteAllLines(assignmentSavePath, savedAssignments.ToArray()); //Saves the assignment names

            
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

                        savedAssignments.Insert(i, nameInput.Text); //Adds the assignment to the saved assignments list in the appropriate index

                        listYear.Insert(i, dateVals[0]); //Adds the prompted year, month, and day in their respective order
                        listMonth.Insert(i, dateVals[1]);
                        listDay.Insert(i, dateVals[2]);

                        MessageBox.Show($"Added at {i} under"); //Indicates if it was placed at the top or middle of the list

                        updateFiles(); //Updates the files list
                        break;
                    }
                    else if (i == assignmentList.Items.Count - 1) //Checks if it is at the last possible loop
                    {
                        assignmentList.Items.Insert(i + 1, $"'{nameInput.Text}' " + $"Due: {calSelection.SelectionRange.Start.ToString("yyyy-MM-dd")} 11:59PM"); //Adds the assignment by the name and proper date to the combobox
                        assignmentsCB.Items.Insert(i + 1, $"{nameInput.Text}"); //Inserts the assignment name into the combobox list

                        savedAssignments.Insert(i + 1, nameInput.Text); //Adds the assignment to the saved assignments list in the appropriate index

                        listYear.Insert(i + 1, dateVals[0]); //Adds the prompted year, month, and day in their respective order
                        listMonth.Insert(i + 1, dateVals[1]);
                        listDay.Insert(i + 1, dateVals[2]);

                        MessageBox.Show($"Added at {i} over"); //Indicates if it was added to the bottom of the list

                        updateFiles(); //Updates the files list
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

                savedAssignments.Add(nameInput.Text); //Adds the assignment to the saved assignments list in the appropriate index

                listYear.Add(dateVals[0]); //Adds the prompted year, month, and day in their respective order
                listMonth.Add(dateVals[1]);
                listDay.Add(dateVals[2]);

                updateFiles(); //Updates the files list
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
            if(assignmentsCB.SelectedIndex == -1) //First checks if there is anything in the list of assignments
            {
                MessageBox.Show("No Assignment to mark as Complete");
                return;
            }

            //Removes the information from their respective slot
            listYear.RemoveAt(assignmentsCB.SelectedIndex);
            listMonth.RemoveAt(assignmentsCB.SelectedIndex);
            listDay.RemoveAt(assignmentsCB.SelectedIndex);

            savedAssignments.RemoveAt(assignmentsCB.SelectedIndex);

            assignmentList.Items.RemoveAt(assignmentsCB.SelectedIndex);
            assignmentsCB.Items.RemoveAt(assignmentsCB.SelectedIndex);

            assignmentsCB.Text = "";

            MessageBox.Show(savedAssignments.Count.ToString());

            updateFiles(); //Updates the files list
        }
    }
}
