namespace Memory_Management
{
    partial class How_to_Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(How_to_Play));
            ss_htp = new Label();
            label1 = new Label();
            label2 = new Label();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // ss_htp
            // 
            ss_htp.AutoSize = true;
            ss_htp.Location = new Point(12, 24);
            ss_htp.Name = "ss_htp";
            ss_htp.Size = new Size(261, 105);
            ss_htp.TabIndex = 0;
            ss_htp.Text = resources.GetString("ss_htp.Text");
            ss_htp.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 24);
            label1.Name = "label1";
            label1.Size = new Size(262, 120);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(547, 24);
            label2.Name = "label2";
            label2.Size = new Size(212, 105);
            label2.TabIndex = 0;
            label2.Text = "Alphabetical Memory\r\n\r\nWords will be displayed and you have\r\nto decide if the word has shown before\r\nor if it's a new word. Each correct input\r\ngranting a point. One wrong input and\r\nit's game over.";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(368, 279);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 23);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // How_to_Play
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ss_htp);
            Name = "How_to_Play";
            Text = "How_to_Play";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ss_htp;
        private Label label1;
        private Label label2;
        private Button closeBtn;
    }
}