namespace JankenBattle
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startButton = new System.Windows.Forms.Button();
            this.gameAreaPanel = new System.Windows.Forms.Panel();
            this.playerLifeProgressBar = new System.Windows.Forms.ProgressBar();
            this.enemyLifeProgressBar = new System.Windows.Forms.ProgressBar();
            this.logoLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rockButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.scissorsButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.paperButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.winLoss1PictureBox = new System.Windows.Forms.PictureBox();
            this.winLoss2PictureBox = new System.Windows.Forms.PictureBox();
            this.winLoss3PictureBox = new System.Windows.Forms.PictureBox();
            this.winLoss4PictureBox = new System.Windows.Forms.PictureBox();
            this.winLoss5PictureBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.enemyHandPictureBox = new System.Windows.Forms.PictureBox();
            this.playerHandPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameAreaPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rockButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHandPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(290, 156);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(260, 40);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "スタート";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameAreaPanel
            // 
            this.gameAreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameAreaPanel.Controls.Add(this.playerLifeProgressBar);
            this.gameAreaPanel.Controls.Add(this.playerHandPictureBox);
            this.gameAreaPanel.Controls.Add(this.enemyLifeProgressBar);
            this.gameAreaPanel.Controls.Add(this.enemyHandPictureBox);
            this.gameAreaPanel.Controls.Add(this.enemyPictureBox);
            this.gameAreaPanel.Location = new System.Drawing.Point(4, 27);
            this.gameAreaPanel.Name = "gameAreaPanel";
            this.gameAreaPanel.Size = new System.Drawing.Size(280, 410);
            this.gameAreaPanel.TabIndex = 1;
            // 
            // playerLifeProgressBar
            // 
            this.playerLifeProgressBar.Location = new System.Drawing.Point(4, 394);
            this.playerLifeProgressBar.Name = "playerLifeProgressBar";
            this.playerLifeProgressBar.Size = new System.Drawing.Size(270, 10);
            this.playerLifeProgressBar.TabIndex = 10;
            // 
            // enemyLifeProgressBar
            // 
            this.enemyLifeProgressBar.Location = new System.Drawing.Point(4, 4);
            this.enemyLifeProgressBar.Name = "enemyLifeProgressBar";
            this.enemyLifeProgressBar.Size = new System.Drawing.Size(270, 10);
            this.enemyLifeProgressBar.TabIndex = 9;
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.LightCyan;
            this.logoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoLabel.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.logoLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.logoLabel.Location = new System.Drawing.Point(290, 30);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(260, 122);
            this.logoLabel.TabIndex = 3;
            this.logoLabel.Text = "じゃんけん\r\nバトル";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(554, 24);
            this.mainMenuStrip.TabIndex = 9;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.gameToolStripMenuItem.Text = "ゲーム(&G)";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "スタート(&S)";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "終了(&Q)";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // rockButtonPictureBox
            // 
            this.rockButtonPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rockButtonPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rockButtonPictureBox.Image = global::JankenBattle.Properties.Resources.rock;
            this.rockButtonPictureBox.Location = new System.Drawing.Point(22, 451);
            this.rockButtonPictureBox.Name = "rockButtonPictureBox";
            this.rockButtonPictureBox.Size = new System.Drawing.Size(80, 80);
            this.rockButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rockButtonPictureBox.TabIndex = 2;
            this.rockButtonPictureBox.TabStop = false;
            this.rockButtonPictureBox.Click += new System.EventHandler(this.rockButtonPictureBox_Click);
            // 
            // scissorsButtonPictureBox
            // 
            this.scissorsButtonPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scissorsButtonPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scissorsButtonPictureBox.Image = global::JankenBattle.Properties.Resources.scissors;
            this.scissorsButtonPictureBox.Location = new System.Drawing.Point(108, 451);
            this.scissorsButtonPictureBox.Name = "scissorsButtonPictureBox";
            this.scissorsButtonPictureBox.Size = new System.Drawing.Size(80, 80);
            this.scissorsButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scissorsButtonPictureBox.TabIndex = 2;
            this.scissorsButtonPictureBox.TabStop = false;
            this.scissorsButtonPictureBox.Click += new System.EventHandler(this.scissorsButtonPictureBox_Click);
            // 
            // paperButtonPictureBox
            // 
            this.paperButtonPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paperButtonPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paperButtonPictureBox.Image = global::JankenBattle.Properties.Resources.paper;
            this.paperButtonPictureBox.Location = new System.Drawing.Point(194, 451);
            this.paperButtonPictureBox.Name = "paperButtonPictureBox";
            this.paperButtonPictureBox.Size = new System.Drawing.Size(80, 80);
            this.paperButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paperButtonPictureBox.TabIndex = 2;
            this.paperButtonPictureBox.TabStop = false;
            this.paperButtonPictureBox.Click += new System.EventHandler(this.paperButtonPictureBox_Click);
            // 
            // winLoss1PictureBox
            // 
            this.winLoss1PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winLoss1PictureBox.Location = new System.Drawing.Point(390, 220);
            this.winLoss1PictureBox.Name = "winLoss1PictureBox";
            this.winLoss1PictureBox.Size = new System.Drawing.Size(60, 60);
            this.winLoss1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winLoss1PictureBox.TabIndex = 4;
            this.winLoss1PictureBox.TabStop = false;
            // 
            // winLoss2PictureBox
            // 
            this.winLoss2PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winLoss2PictureBox.Location = new System.Drawing.Point(390, 280);
            this.winLoss2PictureBox.Name = "winLoss2PictureBox";
            this.winLoss2PictureBox.Size = new System.Drawing.Size(60, 60);
            this.winLoss2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winLoss2PictureBox.TabIndex = 5;
            this.winLoss2PictureBox.TabStop = false;
            // 
            // winLoss3PictureBox
            // 
            this.winLoss3PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winLoss3PictureBox.Location = new System.Drawing.Point(390, 340);
            this.winLoss3PictureBox.Name = "winLoss3PictureBox";
            this.winLoss3PictureBox.Size = new System.Drawing.Size(60, 60);
            this.winLoss3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winLoss3PictureBox.TabIndex = 6;
            this.winLoss3PictureBox.TabStop = false;
            // 
            // winLoss4PictureBox
            // 
            this.winLoss4PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winLoss4PictureBox.Location = new System.Drawing.Point(390, 400);
            this.winLoss4PictureBox.Name = "winLoss4PictureBox";
            this.winLoss4PictureBox.Size = new System.Drawing.Size(60, 60);
            this.winLoss4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winLoss4PictureBox.TabIndex = 7;
            this.winLoss4PictureBox.TabStop = false;
            // 
            // winLoss5PictureBox
            // 
            this.winLoss5PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winLoss5PictureBox.Location = new System.Drawing.Point(390, 460);
            this.winLoss5PictureBox.Name = "winLoss5PictureBox";
            this.winLoss5PictureBox.Size = new System.Drawing.Size(60, 60);
            this.winLoss5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winLoss5PictureBox.TabIndex = 8;
            this.winLoss5PictureBox.TabStop = false;
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyPictureBox.Image")));
            this.enemyPictureBox.Location = new System.Drawing.Point(40, 20);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(200, 160);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyPictureBox.TabIndex = 2;
            this.enemyPictureBox.TabStop = false;
            // 
            // enemyHandPictureBox
            // 
            this.enemyHandPictureBox.Location = new System.Drawing.Point(92, 184);
            this.enemyHandPictureBox.Name = "enemyHandPictureBox";
            this.enemyHandPictureBox.Size = new System.Drawing.Size(100, 100);
            this.enemyHandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyHandPictureBox.TabIndex = 3;
            this.enemyHandPictureBox.TabStop = false;
            // 
            // playerHandPictureBox
            // 
            this.playerHandPictureBox.Location = new System.Drawing.Point(92, 290);
            this.playerHandPictureBox.Name = "playerHandPictureBox";
            this.playerHandPictureBox.Size = new System.Drawing.Size(100, 100);
            this.playerHandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerHandPictureBox.TabIndex = 4;
            this.playerHandPictureBox.TabStop = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.aboutToolStripMenuItem.Text = "情報(&l)";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 531);
            this.Controls.Add(this.winLoss2PictureBox);
            this.Controls.Add(this.winLoss1PictureBox);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.paperButtonPictureBox);
            this.Controls.Add(this.scissorsButtonPictureBox);
            this.Controls.Add(this.rockButtonPictureBox);
            this.Controls.Add(this.gameAreaPanel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "じゃんけんバトル";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gameAreaPanel.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rockButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLoss5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerHandPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel gameAreaPanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.ProgressBar playerLifeProgressBar;
        private System.Windows.Forms.ProgressBar enemyLifeProgressBar;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.PictureBox playerHandPictureBox;
        private System.Windows.Forms.PictureBox enemyHandPictureBox;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox rockButtonPictureBox;
        private System.Windows.Forms.PictureBox scissorsButtonPictureBox;
        private System.Windows.Forms.PictureBox paperButtonPictureBox;
        private System.Windows.Forms.PictureBox winLoss1PictureBox;
        private System.Windows.Forms.PictureBox winLoss2PictureBox;
        private System.Windows.Forms.PictureBox winLoss3PictureBox;
        private System.Windows.Forms.PictureBox winLoss4PictureBox;
        private System.Windows.Forms.PictureBox winLoss5PictureBox;
    }
}

