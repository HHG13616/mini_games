namespace 推箱子
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
            this.gameArea = new System.Windows.Forms.Panel();
            this.playArea = new 推箱子.Renderer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.Panel();
            this.left = new System.Windows.Forms.Panel();
            this.top = new System.Windows.Forms.Panel();
            this.bottom = new System.Windows.Forms.Panel();
            this.palQuit = new System.Windows.Forms.Panel();
            this.lblQuit = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.palTime = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.palLevels = new System.Windows.Forms.FlowLayoutPanel();
            this.star = new System.Windows.Forms.PictureBox();
            this.palScore = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.palLevel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PalRemainds = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRemaineds = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gameArea.SuspendLayout();
            this.playArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.palQuit.SuspendLayout();
            this.palTime.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.palLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star)).BeginInit();
            this.palScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.palLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.PalRemainds.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.Color.Transparent;
            this.gameArea.BackgroundImage = global::推箱子.Properties.Resources.大海背景2;
            this.gameArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameArea.Controls.Add(this.playArea);
            this.gameArea.Controls.Add(this.right);
            this.gameArea.Controls.Add(this.left);
            this.gameArea.Controls.Add(this.top);
            this.gameArea.Controls.Add(this.bottom);
            this.gameArea.Location = new System.Drawing.Point(261, 0);
            this.gameArea.Margin = new System.Windows.Forms.Padding(0);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(560, 560);
            this.gameArea.TabIndex = 0;
            // 
            // playArea
            // 
            this.playArea.BackColor = System.Drawing.Color.Transparent;
            this.playArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playArea.Controls.Add(this.pictureBox1);
            this.playArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playArea.GridSize = new System.Drawing.Size(83, 83);
            this.playArea.Location = new System.Drawing.Point(32, 32);
            this.playArea.Name = "playArea";
            this.playArea.Size = new System.Drawing.Size(496, 496);
            this.playArea.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::推箱子.Properties.Resources.level_next;
            this.pictureBox1.Location = new System.Drawing.Point(128, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // right
            // 
            this.right.BackgroundImage = global::推箱子.Properties.Resources.border_ver;
            this.right.Dock = System.Windows.Forms.DockStyle.Right;
            this.right.Location = new System.Drawing.Point(528, 32);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(32, 496);
            this.right.TabIndex = 3;
            // 
            // left
            // 
            this.left.BackgroundImage = global::推箱子.Properties.Resources.border_ver;
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 32);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(32, 496);
            this.left.TabIndex = 2;
            // 
            // top
            // 
            this.top.BackgroundImage = global::推箱子.Properties.Resources.border_hor;
            this.top.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.top.Location = new System.Drawing.Point(0, 528);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(560, 32);
            this.top.TabIndex = 1;
            // 
            // bottom
            // 
            this.bottom.BackgroundImage = global::推箱子.Properties.Resources.border_hor;
            this.bottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottom.Location = new System.Drawing.Point(0, 0);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(560, 32);
            this.bottom.TabIndex = 0;
            // 
            // palQuit
            // 
            this.palQuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.palQuit.BackColor = System.Drawing.Color.Transparent;
            this.palQuit.Controls.Add(this.lblQuit);
            this.palQuit.Controls.Add(this.btnQuit);
            this.palQuit.Location = new System.Drawing.Point(40, 32);
            this.palQuit.Name = "palQuit";
            this.palQuit.Size = new System.Drawing.Size(62, 53);
            this.palQuit.TabIndex = 23;
            // 
            // lblQuit
            // 
            this.lblQuit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuit.AutoSize = true;
            this.lblQuit.BackColor = System.Drawing.Color.Transparent;
            this.lblQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.lblQuit.Location = new System.Drawing.Point(4, 39);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(53, 12);
            this.lblQuit.TabIndex = 21;
            this.lblQuit.Text = "退出游戏";
            this.lblQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuit.Click += new System.EventHandler(this.lblQuit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = global::推箱子.Properties.Resources.btn_quit;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(0, 0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(61, 36);
            this.btnQuit.TabIndex = 20;
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // palTime
            // 
            this.palTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.palTime.AutoSize = true;
            this.palTime.BackColor = System.Drawing.Color.Transparent;
            this.palTime.Controls.Add(this.panel5);
            this.palTime.Controls.Add(this.pictureBox2);
            this.palTime.Location = new System.Drawing.Point(41, 460);
            this.palTime.Name = "palTime";
            this.palTime.Size = new System.Drawing.Size(147, 88);
            this.palTime.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::推箱子.Properties.Resources.btnTime;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(144, 52);
            this.panel5.TabIndex = 14;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.Font = new System.Drawing.Font("Adobe 黑体 Std R", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Yellow;
            this.lblTime.Location = new System.Drawing.Point(2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(144, 52);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "时间：120s";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::推箱子.Properties.Resources.timer;
            this.pictureBox2.Location = new System.Drawing.Point(56, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::推箱子.Properties.Resources.palScore;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.palLevels);
            this.panel2.Location = new System.Drawing.Point(35, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 147);
            this.panel2.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label15.Location = new System.Drawing.Point(106, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 19);
            this.label15.TabIndex = 22;
            this.label15.Text = "0";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(123, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "分";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(63, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 33);
            this.label7.TabIndex = 20;
            this.label7.Text = "0%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "的玩家！";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "超过了";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "当前积分：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "LV.1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palLevels
            // 
            this.palLevels.Controls.Add(this.star);
            this.palLevels.Location = new System.Drawing.Point(48, 9);
            this.palLevels.Name = "palLevels";
            this.palLevels.Size = new System.Drawing.Size(91, 22);
            this.palLevels.TabIndex = 0;
            // 
            // star
            // 
            this.star.Image = global::推箱子.Properties.Resources.star;
            this.star.Location = new System.Drawing.Point(0, 0);
            this.star.Margin = new System.Windows.Forms.Padding(0);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(20, 20);
            this.star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star.TabIndex = 0;
            this.star.TabStop = false;
            // 
            // palScore
            // 
            this.palScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.palScore.AutoSize = true;
            this.palScore.BackColor = System.Drawing.Color.Transparent;
            this.palScore.Controls.Add(this.pictureBox3);
            this.palScore.Controls.Add(this.panel4);
            this.palScore.Location = new System.Drawing.Point(40, 350);
            this.palScore.Name = "palScore";
            this.palScore.Size = new System.Drawing.Size(147, 89);
            this.palScore.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::推箱子.Properties.Resources.diamond;
            this.pictureBox3.Location = new System.Drawing.Point(56, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::推箱子.Properties.Resources.btnScore;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(144, 52);
            this.panel4.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Adobe 黑体 Std R", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 52);
            this.label9.TabIndex = 0;
            this.label9.Text = "积分：0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::推箱子.Properties.Resources.palLevel;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(889, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 96);
            this.panel3.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(54, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 22);
            this.label14.TabIndex = 22;
            this.label14.Text = "积分";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label13.Location = new System.Drawing.Point(21, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 27);
            this.label13.TabIndex = 21;
            this.label13.Text = "0";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "距第一级还需";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palLevel
            // 
            this.palLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.palLevel.AutoSize = true;
            this.palLevel.BackColor = System.Drawing.Color.Transparent;
            this.palLevel.Controls.Add(this.button3);
            this.palLevel.Controls.Add(this.pictureBox4);
            this.palLevel.Location = new System.Drawing.Point(884, 329);
            this.palLevel.Name = "palLevel";
            this.palLevel.Size = new System.Drawing.Size(147, 87);
            this.palLevel.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::推箱子.Properties.Resources.btnLevel;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Adobe 黑体 Std R", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(0, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 52);
            this.button3.TabIndex = 15;
            this.button3.Text = "级别：简单";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::推箱子.Properties.Resources.leaf;
            this.pictureBox4.Location = new System.Drawing.Point(57, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // PalRemainds
            // 
            this.PalRemainds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PalRemainds.AutoSize = true;
            this.PalRemainds.BackColor = System.Drawing.Color.Transparent;
            this.PalRemainds.Controls.Add(this.panel6);
            this.PalRemainds.Controls.Add(this.pictureBox5);
            this.PalRemainds.Location = new System.Drawing.Point(884, 441);
            this.PalRemainds.Name = "PalRemainds";
            this.PalRemainds.Size = new System.Drawing.Size(147, 87);
            this.PalRemainds.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::推箱子.Properties.Resources.btnRemainds;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.lblRemaineds);
            this.panel6.Location = new System.Drawing.Point(0, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(144, 52);
            this.panel6.TabIndex = 19;
            // 
            // lblRemaineds
            // 
            this.lblRemaineds.Font = new System.Drawing.Font("Adobe 黑体 Std R", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRemaineds.ForeColor = System.Drawing.Color.Yellow;
            this.lblRemaineds.Location = new System.Drawing.Point(0, 0);
            this.lblRemaineds.Name = "lblRemaineds";
            this.lblRemaineds.Size = new System.Drawing.Size(144, 52);
            this.lblRemaineds.TabIndex = 1;
            this.lblRemaineds.Text = "剩余：7个";
            this.lblRemaineds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Image = global::推箱子.Properties.Resources.counter;
            this.pictureBox5.Location = new System.Drawing.Point(62, 1);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(937, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "新手指引";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::推箱子.Properties.Resources.help;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(941, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 42);
            this.button2.TabIndex = 30;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::推箱子.Properties.Resources.大海背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PalRemainds);
            this.Controls.Add(this.palLevel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.palScore);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.palTime);
            this.Controls.Add(this.palQuit);
            this.Controls.Add(this.gameArea);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "搬箱子";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.gameArea.ResumeLayout(false);
            this.playArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.palQuit.ResumeLayout(false);
            this.palQuit.PerformLayout();
            this.palTime.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.palLevels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.star)).EndInit();
            this.palScore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.palLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.PalRemainds.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.Panel right;
        private System.Windows.Forms.Panel left;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Panel bottom;
        private Renderer playArea;
        private System.Windows.Forms.Panel palQuit;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel palTime;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel palLevels;
        private System.Windows.Forms.Panel palScore;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel palLevel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel PalRemainds;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblRemaineds;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox star;
    }
}