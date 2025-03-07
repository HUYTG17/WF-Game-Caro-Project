﻿namespace Game_Co_Caro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnShow = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Avata = new System.Windows.Forms.PictureBox();
            this.lbRule = new System.Windows.Forms.Label();
            this.ptbPayer = new System.Windows.Forms.PictureBox();
            this.psbCooldownTime = new System.Windows.Forms.ProgressBar();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.pnTableChess = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1VsPlayer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCooldown = new System.Windows.Forms.Timer(this.components);
            this.pnShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayer)).BeginInit();
            this.pnTableChess.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.Color.AliceBlue;
            this.pnShow.Controls.Add(this.label1);
            this.pnShow.Controls.Add(this.Avata);
            this.pnShow.Controls.Add(this.lbRule);
            this.pnShow.Controls.Add(this.ptbPayer);
            this.pnShow.Controls.Add(this.psbCooldownTime);
            this.pnShow.Controls.Add(this.txtNamePlayer);
            this.pnShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnShow.Location = new System.Drawing.Point(589, 0);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(234, 617);
            this.pnShow.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cờ Caro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Avata
            // 
            this.Avata.Image = global::Game_Co_Caro.Properties.Resources.BackGround;
            this.Avata.Location = new System.Drawing.Point(8, 60);
            this.Avata.Name = "Avata";
            this.Avata.Size = new System.Drawing.Size(227, 221);
            this.Avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avata.TabIndex = 0;
            this.Avata.TabStop = false;
            // 
            // lbRule
            // 
            this.lbRule.AutoSize = true;
            this.lbRule.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbRule.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRule.Location = new System.Drawing.Point(0, 465);
            this.lbRule.Name = "lbRule";
            this.lbRule.Size = new System.Drawing.Size(0, 27);
            this.lbRule.TabIndex = 4;
            // 
            // ptbPayer
            // 
            this.ptbPayer.BackColor = System.Drawing.Color.AliceBlue;
            this.ptbPayer.Location = new System.Drawing.Point(6, 292);
            this.ptbPayer.Name = "ptbPayer";
            this.ptbPayer.Size = new System.Drawing.Size(100, 86);
            this.ptbPayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPayer.TabIndex = 3;
            this.ptbPayer.TabStop = false;
            this.ptbPayer.Click += new System.EventHandler(this.ptbPayer_Click);
            // 
            // psbCooldownTime
            // 
            this.psbCooldownTime.BackColor = System.Drawing.Color.AliceBlue;
            this.psbCooldownTime.Location = new System.Drawing.Point(8, 390);
            this.psbCooldownTime.Maximum = 20000;
            this.psbCooldownTime.Name = "psbCooldownTime";
            this.psbCooldownTime.Size = new System.Drawing.Size(223, 41);
            this.psbCooldownTime.Step = 100;
            this.psbCooldownTime.TabIndex = 1;
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePlayer.Location = new System.Drawing.Point(112, 318);
            this.txtNamePlayer.Multiline = true;
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.ReadOnly = true;
            this.txtNamePlayer.Size = new System.Drawing.Size(116, 37);
            this.txtNamePlayer.TabIndex = 10;
            this.txtNamePlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNamePlayer.TextChanged += new System.EventHandler(this.txtNamePlayer_TextChanged);
            // 
            // pnTableChess
            // 
            this.pnTableChess.BackColor = System.Drawing.Color.PowderBlue;
            this.pnTableChess.Controls.Add(this.menuStrip1);
            this.pnTableChess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTableChess.Location = new System.Drawing.Point(0, 0);
            this.pnTableChess.Name = "pnTableChess";
            this.pnTableChess.Size = new System.Drawing.Size(589, 617);
            this.pnTableChess.TabIndex = 3;
            this.pnTableChess.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTableChess_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGame
            // 
            this.menuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewGame,
            this.menuUndo,
            this.menuQuit});
            this.menuGame.Name = "menuGame";
            this.menuGame.Size = new System.Drawing.Size(50, 20);
            this.menuGame.Text = "Menu";
            // 
            // menuNewGame
            // 
            this.menuNewGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.player1VsPlayer2ToolStripMenuItem});
            this.menuNewGame.Name = "menuNewGame";
            this.menuNewGame.Size = new System.Drawing.Size(144, 22);
            this.menuNewGame.Text = "New game";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.playToolStripMenuItem.Text = "Play vs Computer";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.PlayVsComputer);
            // 
            // player1VsPlayer2ToolStripMenuItem
            // 
            this.player1VsPlayer2ToolStripMenuItem.Name = "player1VsPlayer2ToolStripMenuItem";
            this.player1VsPlayer2ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.player1VsPlayer2ToolStripMenuItem.Text = "Player1 vs Player2";
            this.player1VsPlayer2ToolStripMenuItem.Click += new System.EventHandler(this.player1VsPlayer2);
            // 
            // menuUndo
            // 
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuUndo.Size = new System.Drawing.Size(144, 22);
            this.menuUndo.Text = "Undo";
            this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuQuit.Size = new System.Drawing.Size(144, 22);
            this.menuQuit.Text = "Quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click_1);
            // 
            // tmCooldown
            // 
            this.tmCooldown.Tick += new System.EventHandler(this.tmCooldown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 617);
            this.Controls.Add(this.pnTableChess);
            this.Controls.Add(this.pnShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game caro";
            this.pnShow.ResumeLayout(false);
            this.pnShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayer)).EndInit();
            this.pnTableChess.ResumeLayout(false);
            this.pnTableChess.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.Label lbRule;
        private System.Windows.Forms.PictureBox ptbPayer;
        private System.Windows.Forms.ProgressBar psbCooldownTime;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.PictureBox Avata;
        private System.Windows.Forms.Panel pnTableChess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGame;
        private System.Windows.Forms.ToolStripMenuItem menuNewGame;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem player1VsPlayer2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.Timer tmCooldown;
        private System.Windows.Forms.Label label1;
    }
}

