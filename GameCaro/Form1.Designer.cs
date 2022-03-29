namespace GameCaro
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
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.picbMark = new System.Windows.Forms.PictureBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.picbAvatar = new System.Windows.Forms.PictureBox();
            this.prcbCountDown = new System.Windows.Forms.ProgressBar();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.tmCountDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbAvatar)).BeginInit();
            this.pnlChat.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 27);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(575, 506);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // pnlInformation
            // 
            this.pnlInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlInformation.Controls.Add(this.picbMark);
            this.pnlInformation.Controls.Add(this.lbIP);
            this.pnlInformation.Controls.Add(this.btnPlay);
            this.pnlInformation.Controls.Add(this.txbIP);
            this.pnlInformation.Controls.Add(this.picbAvatar);
            this.pnlInformation.Controls.Add(this.prcbCountDown);
            this.pnlInformation.Controls.Add(this.txbPlayerName);
            this.pnlInformation.Location = new System.Drawing.Point(593, 27);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(287, 200);
            this.pnlInformation.TabIndex = 1;
            // 
            // picbMark
            // 
            this.picbMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picbMark.Location = new System.Drawing.Point(188, 80);
            this.picbMark.Name = "picbMark";
            this.picbMark.Size = new System.Drawing.Size(50, 50);
            this.picbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbMark.TabIndex = 6;
            this.picbMark.TabStop = false;
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(146, 7);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(20, 13);
            this.lbIP.TabIndex = 5;
            this.lbIP.Text = "IP:";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(146, 30);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(136, 22);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseMnemonic = false;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(166, 4);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(116, 20);
            this.txbIP.TabIndex = 3;
            this.txbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picbAvatar
            // 
            this.picbAvatar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbAvatar.Location = new System.Drawing.Point(4, 30);
            this.picbAvatar.Name = "picbAvatar";
            this.picbAvatar.Size = new System.Drawing.Size(136, 136);
            this.picbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbAvatar.TabIndex = 2;
            this.picbAvatar.TabStop = false;
            // 
            // prcbCountDown
            // 
            this.prcbCountDown.Location = new System.Drawing.Point(4, 172);
            this.prcbCountDown.Name = "prcbCountDown";
            this.prcbCountDown.Size = new System.Drawing.Size(136, 23);
            this.prcbCountDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPlayerName.Location = new System.Drawing.Point(4, 7);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.ReadOnly = true;
            this.txbPlayerName.Size = new System.Drawing.Size(136, 20);
            this.txbPlayerName.TabIndex = 0;
            this.txbPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlChat
            // 
            this.pnlChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChat.BackColor = System.Drawing.Color.White;
            this.pnlChat.Controls.Add(this.label2);
            this.pnlChat.Controls.Add(this.label1);
            this.pnlChat.Location = new System.Drawing.Point(593, 228);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(287, 305);
            this.pnlChat.TabIndex = 2;
            // 
            // tmCountDown
            // 
            this.tmCountDown.Tick += new System.EventHandler(this.tmCountDown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Whimsy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Luật chơi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 200);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Người thắng là người đầu\r\ntiên có được một chuỗi liên\r\ntục gồm 5 quân hàng ngan" +
    "g\r\nhoặc dọc, hoặc chéo\r\n\r\n- Mỗi lượt đánh có thời gian\r\nlà 30s. Người chơi nào đ" +
    "ể\r\nhết thời gian sẽ bị xử thua";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 545);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.pnlInformation);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Show);
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbAvatar)).EndInit();
            this.pnlChat.ResumeLayout(false);
            this.pnlChat.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.PictureBox picbAvatar;
        private System.Windows.Forms.ProgressBar prcbCountDown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox picbMark;
        private System.Windows.Forms.Timer tmCountDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

