namespace SimpleBlackJack
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
            HitButton = new Button();
            PlayerHand = new Label();
            PHandLabel = new Label();
            PScore = new Label();
            PScoreLabel = new Label();
            DealerHand = new Label();
            DHandLabel = new Label();
            DScore = new Label();
            DScoreLabel = new Label();
            CallButton = new Button();
            DealerCallStatus = new Label();
            PlayerCallStatus = new Label();
            SuspendLayout();
            // 
            // HitButton
            // 
            HitButton.Location = new Point(205, 293);
            HitButton.Name = "HitButton";
            HitButton.Size = new Size(75, 23);
            HitButton.TabIndex = 0;
            HitButton.Text = "Hit";
            HitButton.UseVisualStyleBackColor = true;
            HitButton.Click += HitButton_Click;
            // 
            // PlayerHand
            // 
            PlayerHand.AutoSize = true;
            PlayerHand.Location = new Point(267, 258);
            PlayerHand.Name = "PlayerHand";
            PlayerHand.Size = new Size(12, 15);
            PlayerHand.TabIndex = 1;
            PlayerHand.Text = "-";
            // 
            // PHandLabel
            // 
            PHandLabel.AutoSize = true;
            PHandLabel.Location = new Point(268, 234);
            PHandLabel.Name = "PHandLabel";
            PHandLabel.Size = new Size(71, 15);
            PHandLabel.TabIndex = 1;
            PHandLabel.Text = "Player Hand";
            // 
            // PScore
            // 
            PScore.AutoSize = true;
            PScore.Location = new Point(179, 258);
            PScore.Name = "PScore";
            PScore.Size = new Size(30, 15);
            PScore.TabIndex = 1;
            PScore.Text = "0/21";
            // 
            // PScoreLabel
            // 
            PScoreLabel.AutoSize = true;
            PScoreLabel.Location = new Point(179, 234);
            PScoreLabel.Name = "PScoreLabel";
            PScoreLabel.Size = new Size(71, 15);
            PScoreLabel.TabIndex = 1;
            PScoreLabel.Text = "Player Score";
            // 
            // DealerHand
            // 
            DealerHand.AutoSize = true;
            DealerHand.Location = new Point(267, 95);
            DealerHand.Name = "DealerHand";
            DealerHand.Size = new Size(12, 15);
            DealerHand.TabIndex = 1;
            DealerHand.Text = "-";
            // 
            // DHandLabel
            // 
            DHandLabel.AutoSize = true;
            DHandLabel.Location = new Point(268, 71);
            DHandLabel.Name = "DHandLabel";
            DHandLabel.Size = new Size(72, 15);
            DHandLabel.TabIndex = 1;
            DHandLabel.Text = "Dealer Hand";
            // 
            // DScore
            // 
            DScore.AutoSize = true;
            DScore.Location = new Point(179, 95);
            DScore.Name = "DScore";
            DScore.Size = new Size(29, 15);
            DScore.TabIndex = 1;
            DScore.Text = "?/21";
            // 
            // DScoreLabel
            // 
            DScoreLabel.AutoSize = true;
            DScoreLabel.Location = new Point(179, 71);
            DScoreLabel.Name = "DScoreLabel";
            DScoreLabel.Size = new Size(72, 15);
            DScoreLabel.TabIndex = 1;
            DScoreLabel.Text = "Dealer Score";
            // 
            // CallButton
            // 
            CallButton.Location = new Point(204, 335);
            CallButton.Name = "CallButton";
            CallButton.Size = new Size(75, 23);
            CallButton.TabIndex = 0;
            CallButton.Text = "Call";
            CallButton.UseVisualStyleBackColor = true;
            CallButton.Click += CallButton_Click;
            // 
            // DealerCallStatus
            // 
            DealerCallStatus.AutoSize = true;
            DealerCallStatus.Location = new Point(405, 71);
            DealerCallStatus.Name = "DealerCallStatus";
            DealerCallStatus.Size = new Size(68, 15);
            DealerCallStatus.TabIndex = 2;
            DealerCallStatus.Text = "Still Playing";
            // 
            // PlayerCallStatus
            // 
            PlayerCallStatus.AutoSize = true;
            PlayerCallStatus.Location = new Point(405, 234);
            PlayerCallStatus.Name = "PlayerCallStatus";
            PlayerCallStatus.Size = new Size(68, 15);
            PlayerCallStatus.TabIndex = 2;
            PlayerCallStatus.Text = "Still Playing";
            PlayerCallStatus.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PlayerCallStatus);
            Controls.Add(DealerCallStatus);
            Controls.Add(DScoreLabel);
            Controls.Add(PScoreLabel);
            Controls.Add(DScore);
            Controls.Add(PScore);
            Controls.Add(DHandLabel);
            Controls.Add(DealerHand);
            Controls.Add(PHandLabel);
            Controls.Add(PlayerHand);
            Controls.Add(CallButton);
            Controls.Add(HitButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HitButton;
        private Label PlayerHand;
        private Label PHandLabel;
        private Label PScore;
        private Label PScoreLabel;
        private Label DealerHand;
        private Label DHandLabel;
        private Label DScore;
        private Label DScoreLabel;
        private Button CallButton;
        private Label DealerCallStatus;
        private Label PlayerCallStatus;
    }
}
