namespace Error_Catcher
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
            Error1Label = new Label();
            Index = new ListBox();
            NumberValueInput = new TextBox();
            CheckforNumberButton = new Button();
            LoopinstructionsLabel = new Label();
            OutputValueLabel = new Label();
            OutputValue = new Label();
            StringValueInput = new TextBox();
            BreakStringButton = new Button();
            StringOutputslabel = new Label();
            SuspendLayout();
            // 
            // Error1Label
            // 
            Error1Label.AutoSize = true;
            Error1Label.Location = new Point(47, 78);
            Error1Label.Name = "Error1Label";
            Error1Label.Size = new Size(89, 15);
            Error1Label.TabIndex = 0;
            Error1Label.Text = "Input a number";
            // 
            // Index
            // 
            Index.FormattingEnabled = true;
            Index.ItemHeight = 15;
            Index.Location = new Point(572, 78);
            Index.Name = "Index";
            Index.Size = new Size(201, 334);
            Index.TabIndex = 1;
            // 
            // NumberValueInput
            // 
            NumberValueInput.Location = new Point(47, 107);
            NumberValueInput.Name = "NumberValueInput";
            NumberValueInput.Size = new Size(100, 23);
            NumberValueInput.TabIndex = 2;
            // 
            // CheckforNumberButton
            // 
            CheckforNumberButton.Location = new Point(47, 151);
            CheckforNumberButton.Name = "CheckforNumberButton";
            CheckforNumberButton.Size = new Size(100, 23);
            CheckforNumberButton.TabIndex = 3;
            CheckforNumberButton.Text = "Check Value";
            CheckforNumberButton.UseVisualStyleBackColor = true;
            CheckforNumberButton.Click += CheckforNumberButton_Click;
            // 
            // LoopinstructionsLabel
            // 
            LoopinstructionsLabel.AutoSize = true;
            LoopinstructionsLabel.Location = new Point(410, 78);
            LoopinstructionsLabel.Name = "LoopinstructionsLabel";
            LoopinstructionsLabel.Size = new Size(85, 15);
            LoopinstructionsLabel.TabIndex = 0;
            LoopinstructionsLabel.Text = "Input anything";
            // 
            // OutputValueLabel
            // 
            OutputValueLabel.AutoSize = true;
            OutputValueLabel.Location = new Point(47, 189);
            OutputValueLabel.Name = "OutputValueLabel";
            OutputValueLabel.Size = new Size(165, 15);
            OutputValueLabel.TabIndex = 0;
            OutputValueLabel.Text = "Value to the nth power output";
            // 
            // OutputValue
            // 
            OutputValue.AutoSize = true;
            OutputValue.Location = new Point(47, 223);
            OutputValue.Name = "OutputValue";
            OutputValue.Size = new Size(12, 15);
            OutputValue.TabIndex = 0;
            OutputValue.Text = "-";
            // 
            // StringValueInput
            // 
            StringValueInput.Location = new Point(410, 107);
            StringValueInput.Name = "StringValueInput";
            StringValueInput.Size = new Size(100, 23);
            StringValueInput.TabIndex = 2;
            // 
            // BreakStringButton
            // 
            BreakStringButton.Location = new Point(410, 151);
            BreakStringButton.Name = "BreakStringButton";
            BreakStringButton.Size = new Size(100, 23);
            BreakStringButton.TabIndex = 3;
            BreakStringButton.Text = "Break String";
            BreakStringButton.UseVisualStyleBackColor = true;
            BreakStringButton.Click += BreakStringButton_Click;
            // 
            // StringOutputslabel
            // 
            StringOutputslabel.AutoSize = true;
            StringOutputslabel.Location = new Point(572, 45);
            StringOutputslabel.Name = "StringOutputslabel";
            StringOutputslabel.Size = new Size(79, 15);
            StringOutputslabel.TabIndex = 4;
            StringOutputslabel.Text = "String Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StringOutputslabel);
            Controls.Add(BreakStringButton);
            Controls.Add(CheckforNumberButton);
            Controls.Add(StringValueInput);
            Controls.Add(NumberValueInput);
            Controls.Add(Index);
            Controls.Add(LoopinstructionsLabel);
            Controls.Add(OutputValue);
            Controls.Add(OutputValueLabel);
            Controls.Add(Error1Label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Error1Label;
        private ListBox Index;
        private TextBox NumberValueInput;
        private Button CheckforNumberButton;
        private Label LoopinstructionsLabel;
        private Label OutputValueLabel;
        private Label OutputValue;
        private TextBox StringValueInput;
        private Button BreakStringButton;
        private Label StringOutputslabel;
    }
}
