﻿namespace Fall2020_CSC403_Project
{
    partial class Level2
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
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.inventoryboard = new System.Windows.Forms.PictureBox();
            this.selector = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picArrow2 = new System.Windows.Forms.PictureBox();
            this.tmrArrowMove2 = new System.Windows.Forms.Timer(this.components);
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.LVL1potion0 = new System.Windows.Forms.PictureBox();
            this.poisonHealthBar = new System.Windows.Forms.Label();
            this.playerHealthBar = new System.Windows.Forms.Label();
            this.cheetoHealthBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVL1potion0)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(16, 11);
            this.lblInGameTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(60, 24);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // inventoryboard
            // 
            this.inventoryboard.Image = global::Fall2020_CSC403_Project.Properties.Resources.inventoryboard;
            this.inventoryboard.Location = new System.Drawing.Point(176, 113);
            this.inventoryboard.Name = "inventoryboard";
            this.inventoryboard.Size = new System.Drawing.Size(1183, 618);
            this.inventoryboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inventoryboard.TabIndex = 18;
            this.inventoryboard.TabStop = false;
            // 
            // selector
            // 
            this.selector.Image = global::Fall2020_CSC403_Project.Properties.Resources.selectorline;
            this.selector.Location = new System.Drawing.Point(385, 188);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(100, 50);
            this.selector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selector.TabIndex = 22;
            this.selector.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fall2020_CSC403_Project.Properties.Resources.Potion;
            this.pictureBox1.Location = new System.Drawing.Point(156, 696);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(303, 493);
            this.picWall11.Margin = new System.Windows.Forms.Padding(4);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(219, 316);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(999, 1);
            this.picWall2.Margin = new System.Windows.Forms.Padding(4);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(568, 82);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1457, 84);
            this.picWall8.Margin = new System.Windows.Forms.Padding(4);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(109, 805);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(952, 807);
            this.picWall7.Margin = new System.Windows.Forms.Padding(4);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(507, 82);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(111, 1);
            this.picWall1.Margin = new System.Windows.Forms.Padding(4);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(625, 82);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(3, 1);
            this.picWall0.Margin = new System.Windows.Forms.Padding(4);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(109, 478);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(432, 228);
            this.picWall10.Margin = new System.Windows.Forms.Padding(4);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(304, 118);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(705, 79);
            this.picWall9.Margin = new System.Windows.Forms.Padding(4);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(31, 150);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(476, 807);
            this.picWall6.Margin = new System.Windows.Forms.Padding(4);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(477, 82);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(1188, 340);
            this.picWall12.Margin = new System.Windows.Forms.Padding(4);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(271, 139);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(3, 481);
            this.picWall4.Margin = new System.Windows.Forms.Padding(4);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(109, 328);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(3, 807);
            this.picWall5.Margin = new System.Windows.Forms.Padding(4);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(477, 82);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picArrow2
            // 
            this.picArrow2.BackColor = System.Drawing.Color.Transparent;
            this.picArrow2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.arrow_100_40_horizontal;
            this.picArrow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picArrow2.Location = new System.Drawing.Point(314, 487);
            this.picArrow2.Name = "picArrow2";
            this.picArrow2.Size = new System.Drawing.Size(36, 23);
            this.picArrow2.TabIndex = 18;
            this.picArrow2.TabStop = false;
            // 
            // tmrArrowMove2
            // 
            this.tmrArrowMove2.Enabled = true;
            this.tmrArrowMove2.Interval = 10;
            this.tmrArrowMove2.Tick += new System.EventHandler(this.tmrArrowMove_Tick);
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(606, 639);
            this.picEnemyCheeto.Margin = new System.Windows.Forms.Padding(4);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(85, 132);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(156, 111);
            this.picEnemyPoisonPacket.Margin = new System.Windows.Forms.Padding(4);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(84, 118);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(520, 493);
            this.picWall3.Margin = new System.Windows.Forms.Padding(4);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(477, 82);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            this.picWall3.Click += new System.EventHandler(this.picWall3_Click);
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(740, 1);
            this.picBossKoolAid.Margin = new System.Windows.Forms.Padding(4);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(257, 239);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(1377, 91);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(72, 130);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // LVL1potion0
            // 
            this.LVL1potion0.Image = global::Fall2020_CSC403_Project.Properties.Resources.Potion;
            this.LVL1potion0.Location = new System.Drawing.Point(1351, 703);
            this.LVL1potion0.Name = "LVL1potion0";
            this.LVL1potion0.Size = new System.Drawing.Size(92, 88);
            this.LVL1potion0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LVL1potion0.TabIndex = 19;
            this.LVL1potion0.TabStop = false;
            // 
            // poisonHealthBar
            // 
            this.poisonHealthBar.BackColor = System.Drawing.Color.Red;
            this.poisonHealthBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poisonHealthBar.ForeColor = System.Drawing.Color.White;
            this.poisonHealthBar.Location = new System.Drawing.Point(157, 89);
            this.poisonHealthBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.poisonHealthBar.Name = "poisonHealthBar";
            this.poisonHealthBar.Size = new System.Drawing.Size(87, 18);
            this.poisonHealthBar.TabIndex = 21;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.BackColor = System.Drawing.Color.Red;
            this.playerHealthBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealthBar.ForeColor = System.Drawing.Color.White;
            this.playerHealthBar.Location = new System.Drawing.Point(1376, 69);
            this.playerHealthBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(73, 18);
            this.playerHealthBar.TabIndex = 23;
            // 
            // cheetoHealthBar
            // 
            this.cheetoHealthBar.BackColor = System.Drawing.Color.Red;
            this.cheetoHealthBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheetoHealthBar.ForeColor = System.Drawing.Color.White;
            this.cheetoHealthBar.Location = new System.Drawing.Point(606, 619);
            this.cheetoHealthBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cheetoHealthBar.Name = "cheetoHealthBar";
            this.cheetoHealthBar.Size = new System.Drawing.Size(91, 16);
            this.cheetoHealthBar.TabIndex = 24;
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1462, 815);
            this.Controls.Add(this.inventoryboard);
            this.Controls.Add(this.cheetoHealthBar);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.poisonHealthBar);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.LVL1potion0);
            this.Controls.Add(this.picArrow2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Level2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.Level2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVL1potion0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBossKoolAid;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
        private System.Windows.Forms.PictureBox picEnemyCheeto;
        private System.Windows.Forms.PictureBox picWall5;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picWall12;
        private System.Windows.Forms.PictureBox picWall6;
        private System.Windows.Forms.PictureBox picWall9;
        private System.Windows.Forms.PictureBox picWall10;
        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picWall7;
        private System.Windows.Forms.PictureBox picWall8;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall11;
        private System.Windows.Forms.PictureBox picArrow2;
        private System.Windows.Forms.Timer tmrArrowMove2;
        private System.Windows.Forms.PictureBox inventoryboard;
        private System.Windows.Forms.PictureBox LVL1potion0;
        private System.Windows.Forms.PictureBox selector;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label poisonHealthBar;
        private System.Windows.Forms.Label playerHealthBar;
        private System.Windows.Forms.Label cheetoHealthBar;
    }
}