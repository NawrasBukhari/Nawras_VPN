using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Simple_VPN
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        DateTime endSub = new DateTime(2022, 6, 24);
        private void Information_Load(object sender, EventArgs e)
        {
            TimeSpan subResult = endSub.Subtract(DateTime.Today);
            if (subResult.Days < 0)
                SubLblDyn.Text = "None";
            else
                SubLblDyn.Text = $"{subResult.TotalDays} Days Left";
        }

        private void TelegramPicBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://telegram.me/TheDeveloper360");
        }

        private void InstagramPicBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/nawrasbukhari");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Information_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LatestDynLbl_Click(object sender, EventArgs e)
        {

        }

        private void NameLbl_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
