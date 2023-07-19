namespace DungeonAdventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            swordPlayerBar = new PictureBox();
            bowPlayerBar = new PictureBox();
            clubPlayerBar = new PictureBox();
            bigMixturePlayerBar = new PictureBox();
            smallMixturePlayerBar = new PictureBox();
            HpPanel = new TableLayoutPanel();
            playerHitPoints = new Label();
            bat = new Label();
            batHitPoints = new Label();
            label2 = new Label();
            ghostHitPoints = new Label();
            label3 = new Label();
            reaverHitPoints = new Label();
            label1 = new Label();
            movePanel = new GroupBox();
            moveRightBtn = new Button();
            moveLeftBtn = new Button();
            moveBottomBtn = new Button();
            moveTopBtn = new Button();
            label4 = new Label();
            hitPanel = new GroupBox();
            hitOnRightBtn = new Button();
            hitOnLeftBtn = new Button();
            hitOnBottomBtn = new Button();
            hitOnTopBtn = new Button();
            label5 = new Label();
            playerOnStage = new PictureBox();
            batOnStage = new PictureBox();
            reaperOnStage = new PictureBox();
            bigPotionOnStage = new PictureBox();
            smallPotionOnStage = new PictureBox();
            swordOnStage = new PictureBox();
            bowOnStage = new PictureBox();
            clubOnStage = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)swordPlayerBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bowPlayerBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clubPlayerBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bigMixturePlayerBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)smallMixturePlayerBar).BeginInit();
            HpPanel.SuspendLayout();
            movePanel.SuspendLayout();
            hitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerOnStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)batOnStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reaperOnStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bigPotionOnStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)smallPotionOnStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)swordOnStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bowOnStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clubOnStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // swordPlayerBar
            // 
            swordPlayerBar.BackColor = Color.Transparent;
            swordPlayerBar.Image = (Image)resources.GetObject("swordPlayerBar.Image");
            swordPlayerBar.Location = new Point(311, 623);
            swordPlayerBar.Name = "swordPlayerBar";
            swordPlayerBar.Size = new Size(64, 53);
            swordPlayerBar.SizeMode = PictureBoxSizeMode.Zoom;
            swordPlayerBar.TabIndex = 0;
            swordPlayerBar.TabStop = false;
            swordPlayerBar.Click += pictureBox1_Click;
            // 
            // bowPlayerBar
            // 
            bowPlayerBar.BackColor = Color.Transparent;
            bowPlayerBar.Image = (Image)resources.GetObject("bowPlayerBar.Image");
            bowPlayerBar.Location = new Point(391, 623);
            bowPlayerBar.Name = "bowPlayerBar";
            bowPlayerBar.Size = new Size(66, 53);
            bowPlayerBar.SizeMode = PictureBoxSizeMode.Zoom;
            bowPlayerBar.TabIndex = 1;
            bowPlayerBar.TabStop = false;
            // 
            // clubPlayerBar
            // 
            clubPlayerBar.BackColor = Color.Transparent;
            clubPlayerBar.Image = (Image)resources.GetObject("clubPlayerBar.Image");
            clubPlayerBar.Location = new Point(472, 623);
            clubPlayerBar.Name = "clubPlayerBar";
            clubPlayerBar.Size = new Size(69, 53);
            clubPlayerBar.SizeMode = PictureBoxSizeMode.Zoom;
            clubPlayerBar.TabIndex = 2;
            clubPlayerBar.TabStop = false;
            // 
            // bigMixturePlayerBar
            // 
            bigMixturePlayerBar.BackColor = Color.Transparent;
            bigMixturePlayerBar.Image = (Image)resources.GetObject("bigMixturePlayerBar.Image");
            bigMixturePlayerBar.Location = new Point(565, 624);
            bigMixturePlayerBar.Name = "bigMixturePlayerBar";
            bigMixturePlayerBar.Size = new Size(70, 53);
            bigMixturePlayerBar.SizeMode = PictureBoxSizeMode.Zoom;
            bigMixturePlayerBar.TabIndex = 3;
            bigMixturePlayerBar.TabStop = false;
            // 
            // smallMixturePlayerBar
            // 
            smallMixturePlayerBar.BackColor = Color.Transparent;
            smallMixturePlayerBar.Image = (Image)resources.GetObject("smallMixturePlayerBar.Image");
            smallMixturePlayerBar.Location = new Point(653, 623);
            smallMixturePlayerBar.Name = "smallMixturePlayerBar";
            smallMixturePlayerBar.Size = new Size(70, 53);
            smallMixturePlayerBar.SizeMode = PictureBoxSizeMode.Zoom;
            smallMixturePlayerBar.TabIndex = 4;
            smallMixturePlayerBar.TabStop = false;
            // 
            // HpPanel
            // 
            HpPanel.BackColor = Color.White;
            HpPanel.ColumnCount = 2;
            HpPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            HpPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            HpPanel.Controls.Add(playerHitPoints, 1, 0);
            HpPanel.Controls.Add(bat, 0, 1);
            HpPanel.Controls.Add(batHitPoints, 1, 1);
            HpPanel.Controls.Add(label2, 0, 2);
            HpPanel.Controls.Add(ghostHitPoints, 1, 2);
            HpPanel.Controls.Add(label3, 0, 3);
            HpPanel.Controls.Add(reaverHitPoints, 1, 3);
            HpPanel.Controls.Add(label1, 0, 0);
            HpPanel.Location = new Point(1111, 581);
            HpPanel.Name = "HpPanel";
            HpPanel.RowCount = 4;
            HpPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            HpPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            HpPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            HpPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            HpPanel.Size = new Size(157, 115);
            HpPanel.TabIndex = 5;
            // 
            // playerHitPoints
            // 
            playerHitPoints.AutoSize = true;
            playerHitPoints.Location = new Point(81, 0);
            playerHitPoints.Name = "playerHitPoints";
            playerHitPoints.Size = new Size(70, 28);
            playerHitPoints.TabIndex = 1;
            playerHitPoints.Text = "playerHitPoints";
            // 
            // bat
            // 
            bat.Location = new Point(3, 28);
            bat.Name = "bat";
            bat.Size = new Size(49, 20);
            bat.TabIndex = 2;
            bat.Text = "Bat";
            // 
            // batHitPoints
            // 
            batHitPoints.AutoSize = true;
            batHitPoints.Location = new Point(81, 28);
            batHitPoints.Name = "batHitPoints";
            batHitPoints.Size = new Size(71, 28);
            batHitPoints.TabIndex = 3;
            batHitPoints.Text = "batHitPoints";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 56);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "Ghost";
            // 
            // ghostHitPoints
            // 
            ghostHitPoints.AutoSize = true;
            ghostHitPoints.Location = new Point(81, 56);
            ghostHitPoints.Name = "ghostHitPoints";
            ghostHitPoints.Size = new Size(66, 28);
            ghostHitPoints.TabIndex = 5;
            ghostHitPoints.Text = "ghostHitPoints";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 84);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 6;
            label3.Text = "Reaper";
            // 
            // reaverHitPoints
            // 
            reaverHitPoints.AutoSize = true;
            reaverHitPoints.Location = new Point(81, 84);
            reaverHitPoints.Name = "reaverHitPoints";
            reaverHitPoints.Size = new Size(72, 31);
            reaverHitPoints.TabIndex = 7;
            reaverHitPoints.Text = "reaperHitPoints";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Player";
            // 
            // movePanel
            // 
            movePanel.BackColor = Color.Transparent;
            movePanel.Controls.Add(moveRightBtn);
            movePanel.Controls.Add(moveLeftBtn);
            movePanel.Controls.Add(moveBottomBtn);
            movePanel.Controls.Add(moveTopBtn);
            movePanel.Controls.Add(label4);
            movePanel.Location = new Point(728, 597);
            movePanel.Name = "movePanel";
            movePanel.Size = new Size(175, 99);
            movePanel.TabIndex = 6;
            movePanel.TabStop = false;
            // 
            // moveRightBtn
            // 
            moveRightBtn.Location = new Point(118, 33);
            moveRightBtn.Name = "moveRightBtn";
            moveRightBtn.Size = new Size(51, 51);
            moveRightBtn.TabIndex = 4;
            moveRightBtn.Text = "▶️";
            moveRightBtn.UseVisualStyleBackColor = true;
            // 
            // moveLeftBtn
            // 
            moveLeftBtn.Location = new Point(6, 33);
            moveLeftBtn.Name = "moveLeftBtn";
            moveLeftBtn.Size = new Size(51, 51);
            moveLeftBtn.TabIndex = 3;
            moveLeftBtn.Text = "◀️";
            moveLeftBtn.UseVisualStyleBackColor = true;
            // 
            // moveBottomBtn
            // 
            moveBottomBtn.Location = new Point(58, 59);
            moveBottomBtn.Name = "moveBottomBtn";
            moveBottomBtn.Size = new Size(54, 40);
            moveBottomBtn.TabIndex = 2;
            moveBottomBtn.Text = "🔽";
            moveBottomBtn.UseVisualStyleBackColor = true;
            // 
            // moveTopBtn
            // 
            moveTopBtn.Location = new Point(58, 19);
            moveTopBtn.Name = "moveTopBtn";
            moveTopBtn.Size = new Size(54, 41);
            moveTopBtn.TabIndex = 1;
            moveTopBtn.Text = "🔼";
            moveTopBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(6, 3);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 0;
            label4.Text = "Move";
            // 
            // hitPanel
            // 
            hitPanel.BackColor = Color.Transparent;
            hitPanel.Controls.Add(hitOnRightBtn);
            hitPanel.Controls.Add(hitOnLeftBtn);
            hitPanel.Controls.Add(hitOnBottomBtn);
            hitPanel.Controls.Add(hitOnTopBtn);
            hitPanel.Controls.Add(label5);
            hitPanel.ForeColor = SystemColors.ActiveCaptionText;
            hitPanel.Location = new Point(919, 597);
            hitPanel.Name = "hitPanel";
            hitPanel.Size = new Size(175, 99);
            hitPanel.TabIndex = 7;
            hitPanel.TabStop = false;
            // 
            // hitOnRightBtn
            // 
            hitOnRightBtn.Location = new Point(125, 33);
            hitOnRightBtn.Name = "hitOnRightBtn";
            hitOnRightBtn.Size = new Size(43, 45);
            hitOnRightBtn.TabIndex = 8;
            hitOnRightBtn.Text = "▶️";
            hitOnRightBtn.UseVisualStyleBackColor = true;
            // 
            // hitOnLeftBtn
            // 
            hitOnLeftBtn.Location = new Point(6, 33);
            hitOnLeftBtn.Name = "hitOnLeftBtn";
            hitOnLeftBtn.Size = new Size(53, 45);
            hitOnLeftBtn.TabIndex = 7;
            hitOnLeftBtn.Text = "◀️";
            hitOnLeftBtn.UseVisualStyleBackColor = true;
            // 
            // hitOnBottomBtn
            // 
            hitOnBottomBtn.Location = new Point(65, 59);
            hitOnBottomBtn.Name = "hitOnBottomBtn";
            hitOnBottomBtn.Size = new Size(54, 37);
            hitOnBottomBtn.TabIndex = 6;
            hitOnBottomBtn.Text = "🔽";
            hitOnBottomBtn.UseVisualStyleBackColor = true;
            // 
            // hitOnTopBtn
            // 
            hitOnTopBtn.Location = new Point(65, 19);
            hitOnTopBtn.Name = "hitOnTopBtn";
            hitOnTopBtn.Size = new Size(54, 41);
            hitOnTopBtn.TabIndex = 5;
            hitOnTopBtn.Text = "🔼";
            hitOnTopBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(6, 3);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 0;
            label5.Text = "Hit";
            // 
            // playerOnStage
            // 
            playerOnStage.BackColor = Color.Transparent;
            playerOnStage.Image = (Image)resources.GetObject("playerOnStage.Image");
            playerOnStage.Location = new Point(202, 124);
            playerOnStage.Margin = new Padding(3, 4, 3, 4);
            playerOnStage.Name = "playerOnStage";
            playerOnStage.Size = new Size(95, 93);
            playerOnStage.SizeMode = PictureBoxSizeMode.Zoom;
            playerOnStage.TabIndex = 8;
            playerOnStage.TabStop = false;
            playerOnStage.Visible = false;
            // 
            // batOnStage
            // 
            batOnStage.BackColor = Color.Transparent;
            batOnStage.Image = (Image)resources.GetObject("batOnStage.Image");
            batOnStage.Location = new Point(311, 124);
            batOnStage.Margin = new Padding(3, 4, 3, 4);
            batOnStage.Name = "batOnStage";
            batOnStage.Size = new Size(97, 93);
            batOnStage.SizeMode = PictureBoxSizeMode.Zoom;
            batOnStage.TabIndex = 9;
            batOnStage.TabStop = false;
            batOnStage.Visible = false;
            // 
            // reaperOnStage
            // 
            reaperOnStage.BackColor = Color.Transparent;
            reaperOnStage.Image = (Image)resources.GetObject("reaperOnStage.Image");
            reaperOnStage.Location = new Point(426, 124);
            reaperOnStage.Margin = new Padding(3, 4, 3, 4);
            reaperOnStage.Name = "reaperOnStage";
            reaperOnStage.Size = new Size(103, 93);
            reaperOnStage.SizeMode = PictureBoxSizeMode.Zoom;
            reaperOnStage.TabIndex = 10;
            reaperOnStage.TabStop = false;
            reaperOnStage.Visible = false;
            // 
            // bigPotionOnStage
            // 
            bigPotionOnStage.BackColor = Color.Transparent;
            bigPotionOnStage.Image = (Image)resources.GetObject("bigPotionOnStage.Image");
            bigPotionOnStage.Location = new Point(550, 124);
            bigPotionOnStage.Name = "bigPotionOnStage";
            bigPotionOnStage.Size = new Size(85, 93);
            bigPotionOnStage.SizeMode = PictureBoxSizeMode.Zoom;
            bigPotionOnStage.TabIndex = 11;
            bigPotionOnStage.TabStop = false;
            bigPotionOnStage.Visible = false;
            // 
            // smallPotionOnStage
            // 
            smallPotionOnStage.BackColor = Color.Transparent;
            smallPotionOnStage.Image = (Image)resources.GetObject("smallPotionOnStage.Image");
            smallPotionOnStage.Location = new Point(653, 124);
            smallPotionOnStage.Name = "smallPotionOnStage";
            smallPotionOnStage.Size = new Size(93, 93);
            smallPotionOnStage.SizeMode = PictureBoxSizeMode.Zoom;
            smallPotionOnStage.TabIndex = 12;
            smallPotionOnStage.TabStop = false;
            smallPotionOnStage.Visible = false;
            // 
            // swordOnStage
            // 
            swordOnStage.BackColor = Color.Transparent;
            swordOnStage.Image = (Image)resources.GetObject("swordOnStage.Image");
            swordOnStage.Location = new Point(752, 124);
            swordOnStage.Name = "swordOnStage";
            swordOnStage.Size = new Size(88, 93);
            swordOnStage.SizeMode = PictureBoxSizeMode.Zoom;
            swordOnStage.TabIndex = 13;
            swordOnStage.TabStop = false;
            swordOnStage.Visible = false;
            // 
            // bowOnStage
            // 
            bowOnStage.BackColor = Color.Transparent;
            bowOnStage.Image = (Image)resources.GetObject("bowOnStage.Image");
            bowOnStage.Location = new Point(847, 124);
            bowOnStage.Name = "bowOnStage";
            bowOnStage.Size = new Size(90, 93);
            bowOnStage.SizeMode = PictureBoxSizeMode.Zoom;
            bowOnStage.TabIndex = 14;
            bowOnStage.TabStop = false;
            bowOnStage.Visible = false;
            // 
            // clubOnStage
            // 
            clubOnStage.BackColor = Color.Transparent;
            clubOnStage.Image = (Image)resources.GetObject("clubOnStage.Image");
            clubOnStage.Location = new Point(944, 124);
            clubOnStage.Name = "clubOnStage";
            clubOnStage.Size = new Size(94, 93);
            clubOnStage.SizeMode = PictureBoxSizeMode.Zoom;
            clubOnStage.TabIndex = 15;
            clubOnStage.TabStop = false;
            clubOnStage.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1049, 124);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1456, 705);
            Controls.Add(playerOnStage);
            Controls.Add(pictureBox1);
            Controls.Add(smallPotionOnStage);
            Controls.Add(bigPotionOnStage);
            Controls.Add(reaperOnStage);
            Controls.Add(batOnStage);
            Controls.Add(hitPanel);
            Controls.Add(movePanel);
            Controls.Add(HpPanel);
            Controls.Add(smallMixturePlayerBar);
            Controls.Add(bigMixturePlayerBar);
            Controls.Add(clubPlayerBar);
            Controls.Add(bowPlayerBar);
            Controls.Add(swordPlayerBar);
            Controls.Add(clubOnStage);
            Controls.Add(bowOnStage);
            Controls.Add(swordOnStage);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Dungeon Adventure Game";
            ((System.ComponentModel.ISupportInitialize)swordPlayerBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bowPlayerBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)clubPlayerBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bigMixturePlayerBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)smallMixturePlayerBar).EndInit();
            HpPanel.ResumeLayout(false);
            HpPanel.PerformLayout();
            movePanel.ResumeLayout(false);
            movePanel.PerformLayout();
            hitPanel.ResumeLayout(false);
            hitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerOnStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)batOnStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)reaperOnStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)bigPotionOnStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)smallPotionOnStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)swordOnStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)bowOnStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)clubOnStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox swordPlayerBar;
        private PictureBox bowPlayerBar;
        private PictureBox clubPlayerBar;
        private PictureBox bigMixturePlayerBar;
        private PictureBox smallMixturePlayerBar;
        private TableLayoutPanel HpPanel;
        private Label playerHitPoints;
        private Label label1;
        private Label bat;
        private Label batHitPoints;
        private Label label2;
        private Label ghostHitPoints;
        private Label label3;
        private Label reaverHitPoints;
        private GroupBox movePanel;
        private Button moveRightBtn;
        private Button moveLeftBtn;
        private Button moveBottomBtn;
        private Button moveTopBtn;
        private Label label4;
        private GroupBox hitPanel;
        private Button hitOnRightBtn;
        private Button hitOnLeftBtn;
        private Button hitOnBottomBtn;
        private Button hitOnTopBtn;
        private Label label5;
        private PictureBox playerOnStage;
        private PictureBox batOnStage;
        private PictureBox reaperOnStage;
        private PictureBox bigPotionOnStage;
        private PictureBox smallPotionOnStage;
        private PictureBox swordOnStage;
        private PictureBox bowOnStage;
        private PictureBox clubOnStage;
        private PictureBox pictureBox1;
    }
}