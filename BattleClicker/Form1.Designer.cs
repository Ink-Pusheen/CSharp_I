namespace BattleClicker
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            enemyPhotoList = new ImageList(components);
            EnemyPhoto = new PictureBox();
            EnemyHealthLabel = new Label();
            AttackButton = new Button();
            ShopLabel = new Label();
            CurStrengthLabel = new Label();
            upgradeStrengthButton = new Button();
            CurIncomeLabel = new Label();
            upgradeIncomeButton = new Button();
            PlayerStatsLabel = new Label();
            EnemiesKilledLabel = new Label();
            CurrentGoldLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)EnemyPhoto).BeginInit();
            SuspendLayout();
            // 
            // enemyPhotoList
            // 
            enemyPhotoList.ColorDepth = ColorDepth.Depth32Bit;
            enemyPhotoList.ImageStream = (ImageListStreamer)resources.GetObject("enemyPhotoList.ImageStream");
            enemyPhotoList.TransparentColor = Color.Transparent;
            enemyPhotoList.Images.SetKeyName(0, "Archer.PNG");
            enemyPhotoList.Images.SetKeyName(1, "Dwarf.PNG");
            enemyPhotoList.Images.SetKeyName(2, "Fairy Happy.PNG");
            enemyPhotoList.Images.SetKeyName(3, "Jester Upset.PNG");
            enemyPhotoList.Images.SetKeyName(4, "Knight.PNG");
            enemyPhotoList.Images.SetKeyName(5, "Wizard.PNG");
            // 
            // EnemyPhoto
            // 
            EnemyPhoto.Location = new Point(244, 12);
            EnemyPhoto.Name = "EnemyPhoto";
            EnemyPhoto.Size = new Size(288, 285);
            EnemyPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            EnemyPhoto.TabIndex = 0;
            EnemyPhoto.TabStop = false;
            // 
            // EnemyHealthLabel
            // 
            EnemyHealthLabel.AutoSize = true;
            EnemyHealthLabel.Location = new Point(354, 300);
            EnemyHealthLabel.Name = "EnemyHealthLabel";
            EnemyHealthLabel.Size = new Size(54, 15);
            EnemyHealthLabel.TabIndex = 1;
            EnemyHealthLabel.Text = "10.0/10.0";
            // 
            // AttackButton
            // 
            AttackButton.Location = new Point(345, 331);
            AttackButton.Name = "AttackButton";
            AttackButton.Size = new Size(75, 23);
            AttackButton.TabIndex = 2;
            AttackButton.Text = "Attack";
            AttackButton.UseVisualStyleBackColor = true;
            AttackButton.Click += AttackButton_Click;
            // 
            // ShopLabel
            // 
            ShopLabel.AutoSize = true;
            ShopLabel.Location = new Point(22, 12);
            ShopLabel.Name = "ShopLabel";
            ShopLabel.Size = new Size(34, 15);
            ShopLabel.TabIndex = 3;
            ShopLabel.Text = "Shop";
            // 
            // CurStrengthLabel
            // 
            CurStrengthLabel.AutoSize = true;
            CurStrengthLabel.Location = new Point(22, 69);
            CurStrengthLabel.Name = "CurStrengthLabel";
            CurStrengthLabel.Size = new Size(107, 15);
            CurStrengthLabel.TabIndex = 4;
            CurStrengthLabel.Text = "Current Strength: 1";
            // 
            // upgradeStrengthButton
            // 
            upgradeStrengthButton.AutoSize = true;
            upgradeStrengthButton.Enabled = false;
            upgradeStrengthButton.Location = new Point(22, 100);
            upgradeStrengthButton.Name = "upgradeStrengthButton";
            upgradeStrengthButton.Size = new Size(160, 25);
            upgradeStrengthButton.TabIndex = 5;
            upgradeStrengthButton.Text = "Upgrade Strength - Cost 10";
            upgradeStrengthButton.UseVisualStyleBackColor = true;
            upgradeStrengthButton.Click += upgradeStrengthButton_Click;
            // 
            // CurIncomeLabel
            // 
            CurIncomeLabel.AutoSize = true;
            CurIncomeLabel.Location = new Point(22, 154);
            CurIncomeLabel.Name = "CurIncomeLabel";
            CurIncomeLabel.Size = new Size(102, 15);
            CurIncomeLabel.TabIndex = 4;
            CurIncomeLabel.Text = "Current Income: 1";
            // 
            // upgradeIncomeButton
            // 
            upgradeIncomeButton.AutoSize = true;
            upgradeIncomeButton.Enabled = false;
            upgradeIncomeButton.Location = new Point(22, 185);
            upgradeIncomeButton.Name = "upgradeIncomeButton";
            upgradeIncomeButton.Size = new Size(160, 25);
            upgradeIncomeButton.TabIndex = 5;
            upgradeIncomeButton.Text = "Upgrade Income - Cost 5";
            upgradeIncomeButton.UseVisualStyleBackColor = true;
            upgradeIncomeButton.Click += upgradeIncomeButton_Click;
            // 
            // PlayerStatsLabel
            // 
            PlayerStatsLabel.AutoSize = true;
            PlayerStatsLabel.Location = new Point(638, 12);
            PlayerStatsLabel.Name = "PlayerStatsLabel";
            PlayerStatsLabel.Size = new Size(67, 15);
            PlayerStatsLabel.TabIndex = 6;
            PlayerStatsLabel.Text = "Player Stats";
            // 
            // EnemiesKilledLabel
            // 
            EnemiesKilledLabel.AutoSize = true;
            EnemiesKilledLabel.Location = new Point(567, 52);
            EnemiesKilledLabel.Name = "EnemiesKilledLabel";
            EnemiesKilledLabel.Size = new Size(124, 15);
            EnemiesKilledLabel.TabIndex = 7;
            EnemiesKilledLabel.Text = "Total Enemies Killed: 0";
            // 
            // CurrentGoldLabel
            // 
            CurrentGoldLabel.AutoSize = true;
            CurrentGoldLabel.Location = new Point(567, 100);
            CurrentGoldLabel.Name = "CurrentGoldLabel";
            CurrentGoldLabel.Size = new Size(115, 15);
            CurrentGoldLabel.TabIndex = 7;
            CurrentGoldLabel.Text = "Current Gold Held: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CurrentGoldLabel);
            Controls.Add(EnemiesKilledLabel);
            Controls.Add(PlayerStatsLabel);
            Controls.Add(upgradeIncomeButton);
            Controls.Add(upgradeStrengthButton);
            Controls.Add(CurIncomeLabel);
            Controls.Add(CurStrengthLabel);
            Controls.Add(ShopLabel);
            Controls.Add(AttackButton);
            Controls.Add(EnemyHealthLabel);
            Controls.Add(EnemyPhoto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)EnemyPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList enemyPhotoList;
        private PictureBox EnemyPhoto;
        private Label EnemyHealthLabel;
        private Button AttackButton;
        private Label ShopLabel;
        private Label CurStrengthLabel;
        private Button upgradeStrengthButton;
        private Label CurIncomeLabel;
        private Button upgradeIncomeButton;
        private Label PlayerStatsLabel;
        private Label EnemiesKilledLabel;
        private Label CurrentGoldLabel;
    }
}
