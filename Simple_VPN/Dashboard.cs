﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simple_VPN.Classes;

namespace Simple_VPN
{
    public partial class Dashboard : Form
    {
        [Obsolete]
        public Dashboard()
        {
            InitializeComponent();
        }

        VPN VPN = new VPN();
        private void Form1_Load(object sender, EventArgs e)
        {
            Administrator_Authentication();
            Connection_Authentication();
            CountriesCmBox.SelectedIndex = 0;
            DisconnectBtn_Enabled_False();
        }

        /* 
         * The Below Username & Password Valid Till : April 12, 2022.
         *
         *       !!!  Don't Modify ServerIP & selectedProtocol !!!
         * adapterName : You can choose whatever you like .
         * 
         * userName : Your username & passWord : Your password .
         * preSharedKey : Your PreSharedKey if needed .
         * 
         * You can set your serverAddresses in Classes/ServerSelector.cs .
         * 
         */

        private string serverIP = null;
        private string adapterName = "NawrasVPN";
        private string userName = "nawrasbukhari2018@gmail.com";
        private string passWord = "9*FHVvmnX97fVUQ";
        private string preSharedKey = "seed4me";
        private string selectedProtocol = null;

        private void CountriesCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serverIP = ServerIp(CountriesCmBox.SelectedItem.ToString());
        }

        [Obsolete]
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (CountriesCmBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select a Location", "Error at 0x53", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!PPTP_rBtn.Checked && !L2TP_rBtn.Checked)
                {
                    MessageBox.Show("Please Select a Protocol", "Error at 0x59", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    VPN.setParameters(serverIP, adapterName, userName, passWord, selectedProtocol, preSharedKey);
                    try
                    {
                        VPN.Connect();
                    }
                    catch 
                    {
                        VPN.Connect();
                    }
                    finally
                    {
                        ConnectBtn_Enabled_False();
                        DisconnectBtn_Enabled_True();
                        CountriesCmBox_Enabled_False();
                        statusPicbox.Image = Properties.Resources.Connected_Fire;
                        GC.Collect();
                        // For background work to be done
                        Thread.Sleep(8500);
                        MessageBox.Show("Successfully Connected", "Nawras VPN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Goto_Check_IP();   
                    }
                }
            }
        }

        [Obsolete]
        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                VPN.Disconnect();
            }
            finally
            {
                ConnectBtn_Enabled_True();
                DisconnectBtn_Enabled_False();
                CountriesCmBox_Enabled_True();
                statusPicbox.Image = Properties.Resources.Disconnectpic;
                GC.Collect();
                MessageBox.Show("Successfully DisConnected", "Nawras VPN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            using (Information InfoDialog = new Information())
            {
                InfoDialog.ShowDialog();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            ExitMethod();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            Hide();
            NotifyIcon.Visible = true;
            NotifyIcon.ContextMenuStrip = CMenu;
            NotifyIcon.ShowBalloonTip(1000);
        }

        private void openApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitMethod();
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        private void PPTP_rBtn_MouseClick(object sender, MouseEventArgs e)
        {
            selectedProtocol = "PPTP";
        }

        private void L2TP_rBtn_MouseClick(object sender, MouseEventArgs e)
        {
            selectedProtocol = "L2TP";
        }

        public void ExitMethod()
        {
            if (!ConnectBtn.Enabled)
            {
                MessageBox.Show("Please Disconnect First", "Error at 0x150", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                VPN.Dispose();
                VPN = null;
                GC.Collect();
                Application.Exit();
            }
        }

        private void Connection_Authentication()
        {
            while (!Status.IsConnected())
            {
                DialogResult dResult = MessageBox.Show("You are not Connected to the internet", "No Connection",
                                                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dResult == DialogResult.Cancel)
                {
                    break;
                }
            }

            if (!Status.IsConnected())
            {
                Application.Exit();
            }
        }

        private void Administrator_Authentication()
        {
            if (!Status.IsAdministrator())
            {
                DialogResult dResult = MessageBox.Show("Please Re-start as an Administrator", "Permission Denied",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dResult == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nawrasbukhari");
        }
        

    private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statusPicbox_Click(object sender, EventArgs e)
        {

        }

        private void CountriesFlgPicBox_Click(object sender, EventArgs e)
        {

        }
    }
}