namespace Calculator
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
            CalculatorScreen = new Label();
            Key1 = new Button();
            Key2 = new Button();
            Key3 = new Button();
            Key6 = new Button();
            Key5 = new Button();
            Key4 = new Button();
            Key9 = new Button();
            Key8 = new Button();
            Key7 = new Button();
            Key0 = new Button();
            KeyBackSpace = new Button();
            KeyClear = new Button();
            KeyDivide = new Button();
            KeyMultiply = new Button();
            KeySubtract = new Button();
            KeyAdd = new Button();
            NewCalcScreen = new Label();
            KeyEquals = new Button();
            SuspendLayout();
            // 
            // CalculatorScreen
            // 
            CalculatorScreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CalculatorScreen.BackColor = SystemColors.ActiveCaption;
            CalculatorScreen.Location = new Point(46, 9);
            CalculatorScreen.MaximumSize = new Size(1000, 1000);
            CalculatorScreen.Name = "CalculatorScreen";
            CalculatorScreen.Size = new Size(0, 15);
            CalculatorScreen.TabIndex = 0;
            CalculatorScreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Key1
            // 
            Key1.BackColor = SystemColors.ActiveCaption;
            Key1.Location = new Point(46, 144);
            Key1.Name = "Key1";
            Key1.Size = new Size(100, 55);
            Key1.TabIndex = 1;
            Key1.Text = "1";
            Key1.UseVisualStyleBackColor = false;
            Key1.Click += Key1_Click;
            // 
            // Key2
            // 
            Key2.BackColor = SystemColors.ActiveCaption;
            Key2.Location = new Point(224, 144);
            Key2.Name = "Key2";
            Key2.Size = new Size(100, 55);
            Key2.TabIndex = 2;
            Key2.Text = "2";
            Key2.UseVisualStyleBackColor = false;
            Key2.Click += Key2_Click;
            // 
            // Key3
            // 
            Key3.BackColor = SystemColors.ActiveCaption;
            Key3.Location = new Point(416, 144);
            Key3.Name = "Key3";
            Key3.Size = new Size(100, 55);
            Key3.TabIndex = 3;
            Key3.Text = "3";
            Key3.UseVisualStyleBackColor = false;
            Key3.Click += Key3_Click;
            // 
            // Key6
            // 
            Key6.BackColor = SystemColors.ActiveCaption;
            Key6.Location = new Point(416, 225);
            Key6.Name = "Key6";
            Key6.Size = new Size(100, 55);
            Key6.TabIndex = 6;
            Key6.Text = "6";
            Key6.UseVisualStyleBackColor = false;
            Key6.Click += Key6_Click;
            // 
            // Key5
            // 
            Key5.BackColor = SystemColors.ActiveCaption;
            Key5.Location = new Point(224, 225);
            Key5.Name = "Key5";
            Key5.Size = new Size(100, 55);
            Key5.TabIndex = 5;
            Key5.Text = "5";
            Key5.UseVisualStyleBackColor = false;
            Key5.Click += Key5_Click;
            // 
            // Key4
            // 
            Key4.BackColor = SystemColors.ActiveCaption;
            Key4.Location = new Point(46, 225);
            Key4.Name = "Key4";
            Key4.Size = new Size(100, 55);
            Key4.TabIndex = 4;
            Key4.Text = "4";
            Key4.UseVisualStyleBackColor = false;
            Key4.Click += Key4_Click;
            // 
            // Key9
            // 
            Key9.BackColor = SystemColors.ActiveCaption;
            Key9.Location = new Point(416, 306);
            Key9.Name = "Key9";
            Key9.Size = new Size(100, 55);
            Key9.TabIndex = 9;
            Key9.Text = "9";
            Key9.UseVisualStyleBackColor = false;
            Key9.Click += Key9_Click;
            // 
            // Key8
            // 
            Key8.BackColor = SystemColors.ActiveCaption;
            Key8.Location = new Point(224, 306);
            Key8.Name = "Key8";
            Key8.Size = new Size(100, 55);
            Key8.TabIndex = 8;
            Key8.Text = "8";
            Key8.UseVisualStyleBackColor = false;
            Key8.Click += Key8_Click;
            // 
            // Key7
            // 
            Key7.BackColor = SystemColors.ActiveCaption;
            Key7.Location = new Point(46, 306);
            Key7.Name = "Key7";
            Key7.Size = new Size(100, 55);
            Key7.TabIndex = 7;
            Key7.Text = "7";
            Key7.UseVisualStyleBackColor = false;
            Key7.Click += Key7_Click;
            // 
            // Key0
            // 
            Key0.BackColor = SystemColors.ActiveCaption;
            Key0.Location = new Point(224, 383);
            Key0.Name = "Key0";
            Key0.Size = new Size(100, 55);
            Key0.TabIndex = 10;
            Key0.Text = "0";
            Key0.UseVisualStyleBackColor = false;
            Key0.Click += Key0_Click;
            // 
            // KeyBackSpace
            // 
            KeyBackSpace.BackColor = SystemColors.ActiveCaption;
            KeyBackSpace.Location = new Point(416, 383);
            KeyBackSpace.Name = "KeyBackSpace";
            KeyBackSpace.Size = new Size(100, 55);
            KeyBackSpace.TabIndex = 12;
            KeyBackSpace.Text = "<<";
            KeyBackSpace.UseVisualStyleBackColor = false;
            KeyBackSpace.Click += KeyBackSpace_Click;
            // 
            // KeyClear
            // 
            KeyClear.BackColor = SystemColors.ActiveCaption;
            KeyClear.Location = new Point(46, 383);
            KeyClear.Name = "KeyClear";
            KeyClear.Size = new Size(100, 55);
            KeyClear.TabIndex = 11;
            KeyClear.Text = "A/C";
            KeyClear.UseVisualStyleBackColor = false;
            KeyClear.Click += KeyClear_Click;
            // 
            // KeyDivide
            // 
            KeyDivide.BackColor = SystemColors.ActiveCaption;
            KeyDivide.Location = new Point(615, 255);
            KeyDivide.Name = "KeyDivide";
            KeyDivide.Size = new Size(100, 75);
            KeyDivide.TabIndex = 16;
            KeyDivide.Text = "/";
            KeyDivide.UseVisualStyleBackColor = false;
            KeyDivide.Click += KeyDivide_Click;
            // 
            // KeyMultiply
            // 
            KeyMultiply.BackColor = SystemColors.ActiveCaption;
            KeyMultiply.Location = new Point(615, 174);
            KeyMultiply.Name = "KeyMultiply";
            KeyMultiply.Size = new Size(100, 75);
            KeyMultiply.TabIndex = 15;
            KeyMultiply.Text = "*";
            KeyMultiply.UseVisualStyleBackColor = false;
            KeyMultiply.Click += KeyMultiply_Click;
            // 
            // KeySubtract
            // 
            KeySubtract.BackColor = SystemColors.ActiveCaption;
            KeySubtract.Location = new Point(615, 93);
            KeySubtract.Name = "KeySubtract";
            KeySubtract.Size = new Size(100, 75);
            KeySubtract.TabIndex = 14;
            KeySubtract.Text = "-";
            KeySubtract.UseVisualStyleBackColor = false;
            KeySubtract.Click += KeySubtract_Click;
            // 
            // KeyAdd
            // 
            KeyAdd.BackColor = SystemColors.ActiveCaption;
            KeyAdd.Location = new Point(615, 12);
            KeyAdd.Name = "KeyAdd";
            KeyAdd.Size = new Size(100, 75);
            KeyAdd.TabIndex = 13;
            KeyAdd.Text = "+";
            KeyAdd.UseVisualStyleBackColor = false;
            KeyAdd.Click += KeyAdd_Click;
            // 
            // NewCalcScreen
            // 
            NewCalcScreen.BackColor = SystemColors.ActiveCaption;
            NewCalcScreen.Location = new Point(46, 9);
            NewCalcScreen.Name = "NewCalcScreen";
            NewCalcScreen.Size = new Size(470, 123);
            NewCalcScreen.TabIndex = 17;
            NewCalcScreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KeyEquals
            // 
            KeyEquals.BackColor = SystemColors.ActiveCaption;
            KeyEquals.Location = new Point(615, 363);
            KeyEquals.Name = "KeyEquals";
            KeyEquals.Size = new Size(100, 75);
            KeyEquals.TabIndex = 18;
            KeyEquals.Text = "=";
            KeyEquals.UseVisualStyleBackColor = false;
            KeyEquals.Click += KeyEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(KeyEquals);
            Controls.Add(NewCalcScreen);
            Controls.Add(KeyDivide);
            Controls.Add(KeyMultiply);
            Controls.Add(KeySubtract);
            Controls.Add(KeyAdd);
            Controls.Add(KeyBackSpace);
            Controls.Add(KeyClear);
            Controls.Add(Key0);
            Controls.Add(Key9);
            Controls.Add(Key8);
            Controls.Add(Key7);
            Controls.Add(Key6);
            Controls.Add(Key5);
            Controls.Add(Key4);
            Controls.Add(Key3);
            Controls.Add(Key2);
            Controls.Add(Key1);
            Controls.Add(CalculatorScreen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label CalculatorScreen;
        private Button Key1;
        private Button Key2;
        private Button Key3;
        private Button Key6;
        private Button Key5;
        private Button Key4;
        private Button Key9;
        private Button Key8;
        private Button Key7;
        private Button Key0;
        private Button KeyBackSpace;
        private Button KeyClear;
        private Button KeyDivide;
        private Button KeyMultiply;
        private Button KeySubtract;
        private Button KeyAdd;
        private Label NewCalcScreen;
        private Button KeyEquals;
    }
}
