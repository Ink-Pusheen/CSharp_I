namespace ColorMixer
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
            ColorInput1 = new Label();
            ColorInput2 = new Label();
            label4 = new Label();
            OutputColor = new Label();
            ColorBox1 = new ComboBox();
            ColorBox2 = new ComboBox();
            ColorCreator = new Button();
            ResetButton = new Button();
            SuspendLayout();
            // 
            // ColorInput1
            // 
            ColorInput1.AutoSize = true;
            ColorInput1.Font = new Font("Segoe UI", 25F);
            ColorInput1.ForeColor = Color.Red;
            ColorInput1.Location = new Point(133, 90);
            ColorInput1.Name = "ColorInput1";
            ColorInput1.Size = new Size(77, 46);
            ColorInput1.TabIndex = 0;
            ColorInput1.Text = "Red";
            // 
            // ColorInput2
            // 
            ColorInput2.AutoSize = true;
            ColorInput2.Font = new Font("Segoe UI", 25F);
            ColorInput2.ForeColor = Color.Red;
            ColorInput2.Location = new Point(562, 90);
            ColorInput2.Name = "ColorInput2";
            ColorInput2.Size = new Size(77, 46);
            ColorInput2.TabIndex = 1;
            ColorInput2.Text = "Red";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F);
            label4.ForeColor = Color.Black;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(336, 219);
            label4.Name = "label4";
            label4.Size = new Size(128, 46);
            label4.TabIndex = 2;
            label4.Text = "Output";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OutputColor
            // 
            OutputColor.AutoSize = true;
            OutputColor.Font = new Font("Segoe UI", 25F);
            OutputColor.ForeColor = Color.Red;
            OutputColor.Location = new Point(332, 265);
            OutputColor.Name = "OutputColor";
            OutputColor.Size = new Size(77, 46);
            OutputColor.TabIndex = 2;
            OutputColor.Text = "Red";
            OutputColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ColorBox1
            // 
            ColorBox1.FormattingEnabled = true;
            ColorBox1.Items.AddRange(new object[] { "Red", "Blue", "Yellow" });
            ColorBox1.Location = new Point(112, 151);
            ColorBox1.Name = "ColorBox1";
            ColorBox1.Size = new Size(121, 23);
            ColorBox1.TabIndex = 3;
            ColorBox1.Text = "Red";
            ColorBox1.SelectedIndexChanged += ColorBox1_SelectedIndexChanged;
            // 
            // ColorBox2
            // 
            ColorBox2.FormattingEnabled = true;
            ColorBox2.Items.AddRange(new object[] { "Red", "Blue", "Yellow" });
            ColorBox2.Location = new Point(536, 151);
            ColorBox2.Name = "ColorBox2";
            ColorBox2.Size = new Size(121, 23);
            ColorBox2.TabIndex = 3;
            ColorBox2.Text = "Red";
            ColorBox2.SelectedIndexChanged += ColorBox2_SelectedIndexChanged;
            // 
            // ColorCreator
            // 
            ColorCreator.AutoSize = true;
            ColorCreator.Font = new Font("Segoe UI", 9F);
            ColorCreator.Location = new Point(353, 151);
            ColorCreator.Name = "ColorCreator";
            ColorCreator.Size = new Size(83, 25);
            ColorCreator.TabIndex = 4;
            ColorCreator.Text = "Create Color";
            ColorCreator.UseVisualStyleBackColor = true;
            ColorCreator.Click += CalcColor_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(353, 337);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(75, 23);
            ResetButton.TabIndex = 5;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(ResetButton);
            Controls.Add(ColorCreator);
            Controls.Add(ColorBox2);
            Controls.Add(ColorBox1);
            Controls.Add(OutputColor);
            Controls.Add(label4);
            Controls.Add(ColorInput2);
            Controls.Add(ColorInput1);
            Name = "Form1";
            Text = "Color Mixer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ColorInput1;
        private Label ColorInput2;
        private Label label4;
        private Label OutputColor;
        private ComboBox ColorBox1;
        private ComboBox ColorBox2;
        private Button ColorCreator;
        private Button ResetButton;
    }
}
