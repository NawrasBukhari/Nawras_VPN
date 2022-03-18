using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Simple_VPN
{
    partial class Dashboard
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.SeprLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.CountriesCmBox = new System.Windows.Forms.ComboBox();
            this.CountriesFlgPicBox = new System.Windows.Forms.PictureBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.openApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InfoBtn = new System.Windows.Forms.Button();
            this.PPTP_rBtn = new System.Windows.Forms.RadioButton();
            this.ProtocolGrpBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RecommendedLbl = new System.Windows.Forms.Label();
            this.L2TP_rBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusPicbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CountriesFlgPicBox)).BeginInit();
            this.CMenu.SuspendLayout();
            this.ProtocolGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.ExitBtn.Location = new System.Drawing.Point(405, 4);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(33, 32);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiniBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.MiniBtn.Location = new System.Drawing.Point(368, 4);
            this.MiniBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.Size = new System.Drawing.Size(33, 32);
            this.MiniBtn.TabIndex = 1;
            this.MiniBtn.Text = "_";
            this.MiniBtn.UseVisualStyleBackColor = true;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // SeprLbl
            // 
            this.SeprLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SeprLbl.Location = new System.Drawing.Point(4, 43);
            this.SeprLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeprLbl.Name = "SeprLbl";
            this.SeprLbl.Size = new System.Drawing.Size(435, 1);
            this.SeprLbl.TabIndex = 2;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(176)))));
            this.NameLbl.Location = new System.Drawing.Point(0, 10);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(138, 23);
            this.NameLbl.TabIndex = 3;
            this.NameLbl.Text = "UlTIMATE VPN";
            // 
            // CountriesCmBox
            // 
            this.CountriesCmBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CountriesCmBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CountriesCmBox.DropDownHeight = 95;
            this.CountriesCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountriesCmBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountriesCmBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountriesCmBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.CountriesCmBox.FormattingEnabled = true;
            this.CountriesCmBox.IntegralHeight = false;
            this.CountriesCmBox.ItemHeight = 30;
            this.CountriesCmBox.Items.AddRange(new object[] {
            "Select",
            "Argentina",
            "Australia",
            "Belgium",
            "Canada",
            "France",
            "Georgia",
            "Germany",
            "Netherlands",
            "United Arab Emirate",
            "United States"});
            this.CountriesCmBox.Location = new System.Drawing.Point(16, 351);
            this.CountriesCmBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CountriesCmBox.Name = "CountriesCmBox";
            this.CountriesCmBox.Size = new System.Drawing.Size(357, 38);
            this.CountriesCmBox.TabIndex = 4;
            this.CountriesCmBox.SelectedIndexChanged += new System.EventHandler(this.CountriesCmBox_SelectedIndexChanged);
            // 
            // CountriesFlgPicBox
            // 
            this.CountriesFlgPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.CountriesFlgPicBox.Location = new System.Drawing.Point(381, 351);
            this.CountriesFlgPicBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CountriesFlgPicBox.Name = "CountriesFlgPicBox";
            this.CountriesFlgPicBox.Size = new System.Drawing.Size(45, 38);
            this.CountriesFlgPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CountriesFlgPicBox.TabIndex = 5;
            this.CountriesFlgPicBox.TabStop = false;
            this.CountriesFlgPicBox.Click += new System.EventHandler(this.CountriesFlgPicBox_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.ConnectBtn.Location = new System.Drawing.Point(16, 399);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(207, 53);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisconnectBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.DisconnectBtn.Location = new System.Drawing.Point(227, 399);
            this.DisconnectBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(200, 53);
            this.DisconnectBtn.TabIndex = 7;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyIcon.BalloonTipText = "Running in background";
            this.NotifyIcon.BalloonTipTitle = "Nawras VPN";
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Nawras VPN";
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // openApplicationToolStripMenuItem
            // 
            this.openApplicationToolStripMenuItem.Name = "openApplicationToolStripMenuItem";
            this.openApplicationToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.openApplicationToolStripMenuItem.Text = "Open Application";
            this.openApplicationToolStripMenuItem.Click += new System.EventHandler(this.openApplicationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CMenu
            // 
            this.CMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openApplicationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.CMenu.Name = "CMenu";
            this.CMenu.Size = new System.Drawing.Size(196, 52);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.InfoBtn.Location = new System.Drawing.Point(331, 4);
            this.InfoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(33, 32);
            this.InfoBtn.TabIndex = 12;
            this.InfoBtn.Text = "?";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // PPTP_rBtn
            // 
            this.PPTP_rBtn.AutoSize = true;
            this.PPTP_rBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PPTP_rBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPTP_rBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.PPTP_rBtn.Location = new System.Drawing.Point(55, 16);
            this.PPTP_rBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PPTP_rBtn.Name = "PPTP_rBtn";
            this.PPTP_rBtn.Size = new System.Drawing.Size(86, 34);
            this.PPTP_rBtn.TabIndex = 13;
            this.PPTP_rBtn.Text = "PPTP";
            this.PPTP_rBtn.UseVisualStyleBackColor = true;
            this.PPTP_rBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PPTP_rBtn_MouseClick);
            // 
            // ProtocolGrpBox
            // 
            this.ProtocolGrpBox.Controls.Add(this.label2);
            this.ProtocolGrpBox.Controls.Add(this.RecommendedLbl);
            this.ProtocolGrpBox.Controls.Add(this.L2TP_rBtn);
            this.ProtocolGrpBox.Controls.Add(this.PPTP_rBtn);
            this.ProtocolGrpBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProtocolGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.ProtocolGrpBox.Location = new System.Drawing.Point(16, 287);
            this.ProtocolGrpBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProtocolGrpBox.Name = "ProtocolGrpBox";
            this.ProtocolGrpBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProtocolGrpBox.Size = new System.Drawing.Size(411, 57);
            this.ProtocolGrpBox.TabIndex = 14;
            this.ProtocolGrpBox.TabStop = false;
            this.ProtocolGrpBox.Text = "Protocol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "(safer)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RecommendedLbl
            // 
            this.RecommendedLbl.AutoSize = true;
            this.RecommendedLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecommendedLbl.Location = new System.Drawing.Point(139, 27);
            this.RecommendedLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RecommendedLbl.Name = "RecommendedLbl";
            this.RecommendedLbl.Size = new System.Drawing.Size(50, 18);
            this.RecommendedLbl.TabIndex = 15;
            this.RecommendedLbl.Text = "(faster)";
            // 
            // L2TP_rBtn
            // 
            this.L2TP_rBtn.AutoSize = true;
            this.L2TP_rBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L2TP_rBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2TP_rBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.L2TP_rBtn.Location = new System.Drawing.Point(251, 16);
            this.L2TP_rBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.L2TP_rBtn.Name = "L2TP_rBtn";
            this.L2TP_rBtn.Size = new System.Drawing.Size(84, 34);
            this.L2TP_rBtn.TabIndex = 14;
            this.L2TP_rBtn.Text = "L2TP";
            this.L2TP_rBtn.UseVisualStyleBackColor = true;
            this.L2TP_rBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.L2TP_rBtn_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(99, 479);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Powered by Nawras Bukhari";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(0, 510);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "1.0.0";
            // 
            // statusPicbox
            // 
            this.statusPicbox.Image = ((System.Drawing.Image)(resources.GetObject("statusPicbox.Image")));
            this.statusPicbox.Location = new System.Drawing.Point(103, 56);
            this.statusPicbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusPicbox.Name = "statusPicbox";
            this.statusPicbox.Size = new System.Drawing.Size(241, 223);
            this.statusPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statusPicbox.TabIndex = 8;
            this.statusPicbox.TabStop = false;
            this.statusPicbox.Click += new System.EventHandler(this.statusPicbox_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(443, 534);
            this.ControlBox = false;
            this.Controls.Add(this.statusPicbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProtocolGrpBox);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.CountriesFlgPicBox);
            this.Controls.Add(this.CountriesCmBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.SeprLbl);
            this.Controls.Add(this.MiniBtn);
            this.Controls.Add(this.ExitBtn);
            this.ForeColor = System.Drawing.Color.LightCoral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CountriesFlgPicBox)).EndInit();
            this.CMenu.ResumeLayout(false);
            this.ProtocolGrpBox.ResumeLayout(false);
            this.ProtocolGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.Label SeprLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ComboBox CountriesCmBox;
        private System.Windows.Forms.PictureBox CountriesFlgPicBox;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem openApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMenu;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.RadioButton PPTP_rBtn;
        private System.Windows.Forms.GroupBox ProtocolGrpBox;
        private System.Windows.Forms.RadioButton L2TP_rBtn;
        private System.Windows.Forms.Label RecommendedLbl;


        public void DisconnectBtn_Enabled_False()
        {
            DisconnectBtn.Enabled = false;
            DisconnectBtn.ForeColor = Color.FromArgb(93, 97, 105);
            DisconnectBtn.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void DisconnectBtn_Enabled_True()
        {
            DisconnectBtn.Enabled = true;
            DisconnectBtn.ForeColor = Color.FromArgb(244, 80, 176);
            DisconnectBtn.BackColor = Color.Transparent;
        }

        public void ConnectBtn_Enabled_False()
        {
            ConnectBtn.Enabled = false;
            ConnectBtn.ForeColor = Color.FromArgb(93, 97, 105);
            ConnectBtn.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void Goto_Check_IP()
        {
            
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = "https://www.whatismyip.com/";
            proc.Start();
        }

        public void ConnectBtn_Enabled_True()
        {
            ConnectBtn.Enabled = true;
            ConnectBtn.ForeColor = Color.FromArgb(244, 80, 176);
            ConnectBtn.BackColor = Color.Transparent;
        }

        public void ExitBtn_Enabled_False()
        {
            ExitBtn.Enabled = false;
            ExitBtn.ForeColor = Color.FromArgb(93, 97, 105);
            ExitBtn.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void ExitBtn_Enabled_True()
        {
            ExitBtn.Enabled = true;
            ExitBtn.ForeColor = Color.FromArgb(244, 80, 176);
            ExitBtn.BackColor = Color.Transparent;
        }

        public void CountriesCmBox_Enabled_False()
        {
            CountriesCmBox.Enabled = false;
            CountriesCmBox.ForeColor = Color.FromArgb(93, 97, 105);
            CountriesCmBox.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void CountriesCmBox_Enabled_True()
        {
            CountriesCmBox.Enabled = true;
            CountriesCmBox.ForeColor = Color.FromArgb(244, 80, 176);
            CountriesCmBox.BackColor = Color.FromArgb(22, 27, 33);
        }

        public string ServerIp(string locationName)
        {
            string IP = null;
            switch (locationName)
            {
                case "Argentina":
                    IP = "ar.seed4.me";
                    CountriesFlgPicBox.Image = Properties.Resources.ArgentinaFlg;
                    break;

                case "Australia":
                    IP = "au.seed4.me";
                    CountriesFlgPicBox.Image = Properties.Resources.AustraliaFlag;
                    break;

                case "Belgium":
                    IP = "be.seed4.me";
                    CountriesFlgPicBox.Image = Properties.Resources.BelgiumFlag;
                    break;

                case "Canada":
                    IP = "ca.seed4.me";
                    CountriesFlgPicBox.Image = Properties.Resources.CanadaFlg;
                    break;

                case "France":
                    IP = "fr.seed4.me";
                    CountriesFlgPicBox.Image = Properties.Resources.FranceFlg;
                    break;

                case "Georgia":
                    IP = "ge.seed4.me";
                    CountriesFlgPicBox.Image = Properties.Resources.GeorgiaFlag;
                    break;

                case "Germany":
                    IP = "de.seed4.me";
                    CountriesFlgPicBox.Image = Properties.Resources.GermanyFlg;
                    break;
                
                case "Netherlands":
                    IP = "nl.seed4.me";
                    CountriesFlgPicBox.Image = Properties.Resources.NetherlandsFlg;
                    break;

                case "United Arab Emirate":
                    IP = "ae.seed4.me";
                    CountriesFlgPicBox.Image = Properties.Resources.united_arab_emirates;
                    break;

                case "United States":
                    IP = "us.seed4.me";
                    CountriesFlgPicBox.Image = Properties.Resources.UsaFlg;
                    break;
                
                default:
                    IP = string.Empty;
                    CountriesFlgPicBox.Image = Properties.Resources.question__1_;
                    break;
            }
            return IP;
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox statusPicbox;
    }
}