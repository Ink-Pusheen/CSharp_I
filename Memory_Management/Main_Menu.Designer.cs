namespace Memory_Management
{
    partial class Main_Menu
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
            simonsaysBtn = new Button();
            numericalmemoryBtn = new Button();
            alphabeticalmemoryBtn = new Button();
            topscoresLabel = new Label();
            simonHSlabel = new Label();
            numericalmemoryHSlabel = new Label();
            alphabeticalmemoryHSlabel = new Label();
            htpBtn = new Button();
            resetBtn = new Button();
            SuspendLayout();
            // 
            // simonsaysBtn
            // 
            simonsaysBtn.Location = new Point(54, 40);
            simonsaysBtn.Name = "simonsaysBtn";
            simonsaysBtn.Size = new Size(231, 23);
            simonsaysBtn.TabIndex = 0;
            simonsaysBtn.Text = "Simon Says";
            simonsaysBtn.UseVisualStyleBackColor = true;
            simonsaysBtn.Click += simonsaysBtn_Click;
            // 
            // numericalmemoryBtn
            // 
            numericalmemoryBtn.Location = new Point(54, 124);
            numericalmemoryBtn.Name = "numericalmemoryBtn";
            numericalmemoryBtn.Size = new Size(231, 23);
            numericalmemoryBtn.TabIndex = 0;
            numericalmemoryBtn.Text = "Numerical Memory";
            numericalmemoryBtn.UseVisualStyleBackColor = true;
            numericalmemoryBtn.Click += numericalmemoryBtn_Click;
            // 
            // alphabeticalmemoryBtn
            // 
            alphabeticalmemoryBtn.Location = new Point(54, 213);
            alphabeticalmemoryBtn.Name = "alphabeticalmemoryBtn";
            alphabeticalmemoryBtn.Size = new Size(231, 23);
            alphabeticalmemoryBtn.TabIndex = 0;
            alphabeticalmemoryBtn.Text = "Alphabetical Memory";
            alphabeticalmemoryBtn.UseVisualStyleBackColor = true;
            alphabeticalmemoryBtn.Click += alphabeticalmemoryBtn_Click;
            // 
            // topscoresLabel
            // 
            topscoresLabel.AutoSize = true;
            topscoresLabel.Location = new Point(588, 40);
            topscoresLabel.Name = "topscoresLabel";
            topscoresLabel.Size = new Size(66, 15);
            topscoresLabel.TabIndex = 1;
            topscoresLabel.Text = "Best Scores";
            // 
            // simonHSlabel
            // 
            simonHSlabel.AutoSize = true;
            simonHSlabel.Location = new Point(532, 90);
            simonHSlabel.Name = "simonHSlabel";
            simonHSlabel.Size = new Size(79, 15);
            simonHSlabel.TabIndex = 1;
            simonHSlabel.Text = "Simon Says: 0";
            // 
            // numericalmemoryHSlabel
            // 
            numericalmemoryHSlabel.AutoSize = true;
            numericalmemoryHSlabel.Location = new Point(532, 150);
            numericalmemoryHSlabel.Name = "numericalmemoryHSlabel";
            numericalmemoryHSlabel.Size = new Size(122, 15);
            numericalmemoryHSlabel.TabIndex = 1;
            numericalmemoryHSlabel.Text = "Numerical Memory: 0";
            // 
            // alphabeticalmemoryHSlabel
            // 
            alphabeticalmemoryHSlabel.AutoSize = true;
            alphabeticalmemoryHSlabel.Location = new Point(532, 200);
            alphabeticalmemoryHSlabel.Name = "alphabeticalmemoryHSlabel";
            alphabeticalmemoryHSlabel.Size = new Size(133, 15);
            alphabeticalmemoryHSlabel.TabIndex = 1;
            alphabeticalmemoryHSlabel.Text = "Alphabetical Memory: 0";
            // 
            // htpBtn
            // 
            htpBtn.Location = new Point(54, 284);
            htpBtn.Name = "htpBtn";
            htpBtn.Size = new Size(231, 23);
            htpBtn.TabIndex = 0;
            htpBtn.Text = "How to Play";
            htpBtn.UseVisualStyleBackColor = true;
            htpBtn.Click += htpBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(579, 254);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(75, 23);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "Reset Data";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resetBtn);
            Controls.Add(alphabeticalmemoryHSlabel);
            Controls.Add(numericalmemoryHSlabel);
            Controls.Add(simonHSlabel);
            Controls.Add(topscoresLabel);
            Controls.Add(htpBtn);
            Controls.Add(alphabeticalmemoryBtn);
            Controls.Add(numericalmemoryBtn);
            Controls.Add(simonsaysBtn);
            Name = "Main_Menu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button simonsaysBtn;
        private Button numericalmemoryBtn;
        private Button alphabeticalmemoryBtn;
        private Label topscoresLabel;
        private Label simonHSlabel;
        private Label numericalmemoryHSlabel;
        private Label alphabeticalmemoryHSlabel;
        private Button htpBtn;
        private Button resetBtn;
    }
}
