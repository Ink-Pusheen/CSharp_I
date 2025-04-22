namespace Memory_Management
{
    partial class Numerical_Memory
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
            startBtn = new Button();
            returnBtn = new Button();
            rememberLabel = new Label();
            numberlistLabel = new Label();
            numberInput = new TextBox();
            roundLabel = new Label();
            scoreLabel = new Label();
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.Location = new Point(713, 387);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(75, 23);
            startBtn.TabIndex = 0;
            startBtn.Text = "Start Game";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // returnBtn
            // 
            returnBtn.Location = new Point(659, 416);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(129, 23);
            returnBtn.TabIndex = 0;
            returnBtn.Text = "Return to Main Menu";
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // rememberLabel
            // 
            rememberLabel.AutoSize = true;
            rememberLabel.Location = new Point(231, 115);
            rememberLabel.Name = "rememberLabel";
            rememberLabel.Size = new Size(65, 15);
            rememberLabel.TabIndex = 1;
            rememberLabel.Text = "Remember";
            // 
            // numberlistLabel
            // 
            numberlistLabel.AutoSize = true;
            numberlistLabel.Location = new Point(231, 143);
            numberlistLabel.Name = "numberlistLabel";
            numberlistLabel.Size = new Size(12, 15);
            numberlistLabel.TabIndex = 1;
            numberlistLabel.Text = "-";
            // 
            // numberInput
            // 
            numberInput.BackColor = SystemColors.Window;
            numberInput.Enabled = false;
            numberInput.Location = new Point(231, 168);
            numberInput.Multiline = true;
            numberInput.Name = "numberInput";
            numberInput.ReadOnly = true;
            numberInput.Size = new Size(419, 211);
            numberInput.TabIndex = 2;
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(21, 416);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(54, 15);
            roundLabel.TabIndex = 3;
            roundLabel.Text = "Round: 1";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(139, 416);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(48, 15);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Score: 0";
            // 
            // Numerical_Memory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreLabel);
            Controls.Add(roundLabel);
            Controls.Add(numberInput);
            Controls.Add(numberlistLabel);
            Controls.Add(rememberLabel);
            Controls.Add(returnBtn);
            Controls.Add(startBtn);
            Name = "Numerical_Memory";
            Text = "Numerical_Memory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startBtn;
        private Button returnBtn;
        private Label rememberLabel;
        private Label numberlistLabel;
        private TextBox numberInput;
        private Label roundLabel;
        private Label scoreLabel;
    }
}