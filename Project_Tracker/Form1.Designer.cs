namespace Project_Tracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            assignmentList = new ListBox();
            nameLabel = new Label();
            calSelection = new MonthCalendar();
            assignmentaddBtn = new Button();
            duedateLabel = new Label();
            nameInput = new TextBox();
            assignmentsCB = new ComboBox();
            listLabel = new Label();
            completeBtn = new Button();
            SuspendLayout();
            // 
            // assignmentList
            // 
            assignmentList.FormattingEnabled = true;
            assignmentList.ItemHeight = 15;
            assignmentList.Location = new Point(554, 12);
            assignmentList.Name = "assignmentList";
            assignmentList.Size = new Size(234, 424);
            assignmentList.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(38, 46);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(105, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Assignment Name";
            // 
            // calSelection
            // 
            calSelection.Location = new Point(38, 161);
            calSelection.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            calSelection.MinDate = new DateTime(2025, 3, 24, 0, 0, 0, 0);
            calSelection.Name = "calSelection";
            calSelection.TabIndex = 2;
            // 
            // assignmentaddBtn
            // 
            assignmentaddBtn.Location = new Point(38, 349);
            assignmentaddBtn.Name = "assignmentaddBtn";
            assignmentaddBtn.Size = new Size(105, 23);
            assignmentaddBtn.TabIndex = 3;
            assignmentaddBtn.Text = "Add Assignment";
            assignmentaddBtn.UseVisualStyleBackColor = true;
            assignmentaddBtn.Click += assignmentaddBtn_Click;
            // 
            // duedateLabel
            // 
            duedateLabel.AutoSize = true;
            duedateLabel.Location = new Point(38, 137);
            duedateLabel.Name = "duedateLabel";
            duedateLabel.Size = new Size(55, 15);
            duedateLabel.TabIndex = 4;
            duedateLabel.Text = "Due Date";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(38, 74);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(227, 23);
            nameInput.TabIndex = 5;
            // 
            // assignmentsCB
            // 
            assignmentsCB.FormattingEnabled = true;
            assignmentsCB.Location = new Point(427, 46);
            assignmentsCB.Name = "assignmentsCB";
            assignmentsCB.Size = new Size(121, 23);
            assignmentsCB.TabIndex = 6;
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.Location = new Point(427, 9);
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(91, 15);
            listLabel.TabIndex = 7;
            listLabel.Text = "Assignment List";
            // 
            // completeBtn
            // 
            completeBtn.Location = new Point(427, 96);
            completeBtn.Name = "completeBtn";
            completeBtn.Size = new Size(121, 23);
            completeBtn.TabIndex = 8;
            completeBtn.Text = "Mark as Complete";
            completeBtn.UseVisualStyleBackColor = true;
            completeBtn.Click += completeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(completeBtn);
            Controls.Add(listLabel);
            Controls.Add(assignmentsCB);
            Controls.Add(nameInput);
            Controls.Add(duedateLabel);
            Controls.Add(assignmentaddBtn);
            Controls.Add(calSelection);
            Controls.Add(nameLabel);
            Controls.Add(assignmentList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox assignmentList;
        private Label nameLabel;
        private MonthCalendar calSelection;
        private Button assignmentaddBtn;
        private Label duedateLabel;
        private TextBox nameInput;
        private ComboBox assignmentsCB;
        private Label listLabel;
        private Button completeBtn;
    }
}
