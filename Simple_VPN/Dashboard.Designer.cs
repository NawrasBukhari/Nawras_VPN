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
            this.statusPicbox = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CountriesFlgPicBox)).BeginInit();
            this.CMenu.SuspendLayout();
            this.ProtocolGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            resources.ApplyResources(this.ExitBtn, "ExitBtn");
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MiniBtn
            // 
            resources.ApplyResources(this.MiniBtn, "MiniBtn");
            this.MiniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MiniBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.UseVisualStyleBackColor = true;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // SeprLbl
            // 
            resources.ApplyResources(this.SeprLbl, "SeprLbl");
            this.SeprLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SeprLbl.Name = "SeprLbl";
            // 
            // NameLbl
            // 
            resources.ApplyResources(this.NameLbl, "NameLbl");
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(176)))));
            this.NameLbl.Name = "NameLbl";
            // 
            // CountriesCmBox
            // 
            resources.ApplyResources(this.CountriesCmBox, "CountriesCmBox");
            this.CountriesCmBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CountriesCmBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CountriesCmBox.DropDownHeight = 95;
            this.CountriesCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountriesCmBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.CountriesCmBox.FormattingEnabled = true;
            this.CountriesCmBox.Items.AddRange(new object[] {
            resources.GetString("CountriesCmBox.Items"),
            resources.GetString("CountriesCmBox.Items1"),
            resources.GetString("CountriesCmBox.Items2"),
            resources.GetString("CountriesCmBox.Items3"),
            resources.GetString("CountriesCmBox.Items4"),
            resources.GetString("CountriesCmBox.Items5"),
            resources.GetString("CountriesCmBox.Items6"),
            resources.GetString("CountriesCmBox.Items7"),
            resources.GetString("CountriesCmBox.Items8"),
            resources.GetString("CountriesCmBox.Items9"),
            resources.GetString("CountriesCmBox.Items10")});
            this.CountriesCmBox.Name = "CountriesCmBox";
            this.CountriesCmBox.SelectedIndexChanged += new System.EventHandler(this.CountriesCmBox_SelectedIndexChanged);
            // 
            // CountriesFlgPicBox
            // 
            resources.ApplyResources(this.CountriesFlgPicBox, "CountriesFlgPicBox");
            this.CountriesFlgPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.CountriesFlgPicBox.Name = "CountriesFlgPicBox";
            this.CountriesFlgPicBox.TabStop = false;
            this.CountriesFlgPicBox.Click += new System.EventHandler(this.CountriesFlgPicBox_Click);
            // 
            // ConnectBtn
            // 
            resources.ApplyResources(this.ConnectBtn, "ConnectBtn");
            this.ConnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // DisconnectBtn
            // 
            resources.ApplyResources(this.DisconnectBtn, "DisconnectBtn");
            this.DisconnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.NotifyIcon, "NotifyIcon");
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // openApplicationToolStripMenuItem
            // 
            resources.ApplyResources(this.openApplicationToolStripMenuItem, "openApplicationToolStripMenuItem");
            this.openApplicationToolStripMenuItem.Name = "openApplicationToolStripMenuItem";
            this.openApplicationToolStripMenuItem.Click += new System.EventHandler(this.openApplicationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CMenu
            // 
            resources.ApplyResources(this.CMenu, "CMenu");
            this.CMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openApplicationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.CMenu.Name = "CMenu";
            // 
            // InfoBtn
            // 
            resources.ApplyResources(this.InfoBtn, "InfoBtn");
            this.InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // PPTP_rBtn
            // 
            resources.ApplyResources(this.PPTP_rBtn, "PPTP_rBtn");
            this.PPTP_rBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PPTP_rBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.PPTP_rBtn.Name = "PPTP_rBtn";
            this.PPTP_rBtn.UseVisualStyleBackColor = true;
            this.PPTP_rBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PPTP_rBtn_MouseClick);
            // 
            // ProtocolGrpBox
            // 
            resources.ApplyResources(this.ProtocolGrpBox, "ProtocolGrpBox");
            this.ProtocolGrpBox.Controls.Add(this.label2);
            this.ProtocolGrpBox.Controls.Add(this.RecommendedLbl);
            this.ProtocolGrpBox.Controls.Add(this.L2TP_rBtn);
            this.ProtocolGrpBox.Controls.Add(this.PPTP_rBtn);
            this.ProtocolGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.ProtocolGrpBox.Name = "ProtocolGrpBox";
            this.ProtocolGrpBox.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RecommendedLbl
            // 
            resources.ApplyResources(this.RecommendedLbl, "RecommendedLbl");
            this.RecommendedLbl.Name = "RecommendedLbl";
            // 
            // L2TP_rBtn
            // 
            resources.ApplyResources(this.L2TP_rBtn, "L2TP_rBtn");
            this.L2TP_rBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L2TP_rBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(181)))));
            this.L2TP_rBtn.Name = "L2TP_rBtn";
            this.L2TP_rBtn.UseVisualStyleBackColor = true;
            this.L2TP_rBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.L2TP_rBtn_MouseClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(176)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusPicbox
            // 
            resources.ApplyResources(this.statusPicbox, "statusPicbox");
            this.statusPicbox.Name = "statusPicbox";
            this.statusPicbox.TabStop = false;
            this.statusPicbox.Click += new System.EventHandler(this.statusPicbox_Click);
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(28)))), ((int)(((byte)(117)))));
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.ForeColor = System.Drawing.Color.Beige;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1")});
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ControlBox = false;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.statusPicbox);
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
            this.MaximizeBox = false;
            this.Name = "Dashboard";
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
        private System.Windows.Forms.PictureBox statusPicbox;
        private ComboBox comboBox2;
    }
}