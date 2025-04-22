namespace Memory_Management
{
    partial class Simon_Says
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
            oneBtn = new Button();
            twoBtn = new Button();
            threeBtn = new Button();
            fourBtn = new Button();
            fiveBtn = new Button();
            sixBtn = new Button();
            sevenBtn = new Button();
            eightBtn = new Button();
            nineBtn = new Button();
            startBtn = new Button();
            rememberLabel = new Label();
            simonInputLabel = new Label();
            roundLabel = new Label();
            scoreLabel = new Label();
            returnBtn = new Button();
            SuspendLayout();
            // 
            // oneBtn
            // 
            oneBtn.Enabled = false;
            oneBtn.Location = new Point(50, 71);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(99, 94);
            oneBtn.TabIndex = 0;
            oneBtn.Tag = "inputBtn";
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = true;
            oneBtn.Click += oneBtn_Click;
            // 
            // twoBtn
            // 
            twoBtn.Enabled = false;
            twoBtn.Location = new Point(155, 71);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(99, 94);
            twoBtn.TabIndex = 0;
            twoBtn.Tag = "inputBtn";
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = true;
            twoBtn.Click += twoBtn_Click;
            // 
            // threeBtn
            // 
            threeBtn.Enabled = false;
            threeBtn.Location = new Point(260, 71);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(99, 94);
            threeBtn.TabIndex = 0;
            threeBtn.Tag = "inputBtn";
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = true;
            threeBtn.Click += threeBtn_Click;
            // 
            // fourBtn
            // 
            fourBtn.Enabled = false;
            fourBtn.Location = new Point(50, 171);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(99, 94);
            fourBtn.TabIndex = 0;
            fourBtn.Tag = "inputBtn";
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = true;
            fourBtn.Click += fourBtn_Click;
            // 
            // fiveBtn
            // 
            fiveBtn.Enabled = false;
            fiveBtn.Location = new Point(155, 171);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(99, 94);
            fiveBtn.TabIndex = 0;
            fiveBtn.Tag = "inputBtn";
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = true;
            fiveBtn.Click += fiveBtn_Click;
            // 
            // sixBtn
            // 
            sixBtn.Enabled = false;
            sixBtn.Location = new Point(260, 171);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(99, 94);
            sixBtn.TabIndex = 0;
            sixBtn.Tag = "inputBtn";
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = true;
            sixBtn.Click += sixBtn_Click;
            // 
            // sevenBtn
            // 
            sevenBtn.Enabled = false;
            sevenBtn.Location = new Point(50, 271);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(99, 94);
            sevenBtn.TabIndex = 0;
            sevenBtn.Tag = "inputBtn";
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = true;
            sevenBtn.Click += sevenBtn_Click;
            // 
            // eightBtn
            // 
            eightBtn.Enabled = false;
            eightBtn.Location = new Point(155, 271);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(99, 94);
            eightBtn.TabIndex = 0;
            eightBtn.Tag = "inputBtn";
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = true;
            eightBtn.Click += eightBtn_Click;
            // 
            // nineBtn
            // 
            nineBtn.Enabled = false;
            nineBtn.Location = new Point(260, 271);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(99, 94);
            nineBtn.TabIndex = 0;
            nineBtn.Tag = "inputBtn";
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = true;
            nineBtn.Click += nineBtn_Click;
            // 
            // startBtn
            // 
            startBtn.Location = new Point(702, 392);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(75, 23);
            startBtn.TabIndex = 1;
            startBtn.Text = "Start Game";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // rememberLabel
            // 
            rememberLabel.AutoSize = true;
            rememberLabel.Location = new Point(447, 71);
            rememberLabel.Name = "rememberLabel";
            rememberLabel.Size = new Size(65, 15);
            rememberLabel.TabIndex = 2;
            rememberLabel.Text = "Remember";
            // 
            // simonInputLabel
            // 
            simonInputLabel.AutoSize = true;
            simonInputLabel.Location = new Point(447, 100);
            simonInputLabel.Name = "simonInputLabel";
            simonInputLabel.Size = new Size(12, 15);
            simonInputLabel.TabIndex = 2;
            simonInputLabel.Text = "-";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(50, 415);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(54, 15);
            roundLabel.TabIndex = 3;
            roundLabel.Text = "Round: 1";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(311, 415);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.RightToLeft = RightToLeft.Yes;
            scoreLabel.Size = new Size(48, 15);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "Score: 0";
            // 
            // returnBtn
            // 
            returnBtn.Location = new Point(647, 421);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(130, 23);
            returnBtn.TabIndex = 5;
            returnBtn.Text = "Return to Main Menu";
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // Simon_Says
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnBtn);
            Controls.Add(scoreLabel);
            Controls.Add(roundLabel);
            Controls.Add(simonInputLabel);
            Controls.Add(rememberLabel);
            Controls.Add(startBtn);
            Controls.Add(nineBtn);
            Controls.Add(eightBtn);
            Controls.Add(sixBtn);
            Controls.Add(fiveBtn);
            Controls.Add(sevenBtn);
            Controls.Add(threeBtn);
            Controls.Add(fourBtn);
            Controls.Add(twoBtn);
            Controls.Add(oneBtn);
            Name = "Simon_Says";
            Text = "Simon_Says";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button oneBtn;
        private Button twoBtn;
        private Button threeBtn;
        private Button fourBtn;
        private Button fiveBtn;
        private Button sixBtn;
        private Button sevenBtn;
        private Button eightBtn;
        private Button nineBtn;
        private Button startBtn;
        private Label rememberLabel;
        private Label simonInputLabel;
        private Label roundLabel;
        private Label scoreLabel;
        private Button returnBtn;
    }
}