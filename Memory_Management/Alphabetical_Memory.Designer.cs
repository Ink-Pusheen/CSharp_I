namespace Memory_Management
{
    partial class Alphabetical_Memory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            shownWord = new Label();
            newBtn = new Button();
            seenBtn = new Button();
            scoreLabel = new Label();
            startBtn = new Button();
            returnBtn = new Button();
            SuspendLayout();
            // 
            // shownWord
            // 
            shownWord.Font = new Font("Segoe UI", 18F);
            shownWord.Location = new Point(274, 153);
            shownWord.Name = "shownWord";
            shownWord.Size = new Size(200, 50);
            shownWord.TabIndex = 0;
            shownWord.Text = "-";
            shownWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newBtn
            // 
            newBtn.Enabled = false;
            newBtn.Location = new Point(263, 206);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(75, 23);
            newBtn.TabIndex = 1;
            newBtn.Text = "New";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // seenBtn
            // 
            seenBtn.Enabled = false;
            seenBtn.Location = new Point(399, 206);
            seenBtn.Name = "seenBtn";
            seenBtn.Size = new Size(75, 23);
            seenBtn.TabIndex = 1;
            seenBtn.Text = "Seen";
            seenBtn.UseVisualStyleBackColor = true;
            seenBtn.Click += seenBtn_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(12, 406);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(48, 15);
            scoreLabel.TabIndex = 2;
            scoreLabel.Text = "Score: 0";
            // 
            // startBtn
            // 
            startBtn.Location = new Point(713, 383);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(75, 23);
            startBtn.TabIndex = 3;
            startBtn.Text = "Start Game";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // returnBtn
            // 
            returnBtn.Location = new Point(658, 415);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(130, 23);
            returnBtn.TabIndex = 3;
            returnBtn.Text = "Return to Main Menu";
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // Alphabetical_Memory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnBtn);
            Controls.Add(startBtn);
            Controls.Add(scoreLabel);
            Controls.Add(seenBtn);
            Controls.Add(newBtn);
            Controls.Add(shownWord);
            Name = "Alphabetical_Memory";
            Text = "Alphabetical_Memory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label shownWord;
        private Button newBtn;
        private Button seenBtn;
        private Label scoreLabel;
        private Button startBtn;
        private Button returnBtn;
    }
}