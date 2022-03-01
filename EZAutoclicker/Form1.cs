using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZAutoclicker
{
    public partial class EZAutoclicker : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;

        private const int MOUSEEVENTF_LEFTUP = 0x04;

        private const int MOUSEEVENTF_RIGHTUP = 0x012;

        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;

        private const int MYACTION_HOTKEY_ID = 1;

        private const int MYACTION_HOTKEY_ID2 = 1;

        private bool clickon = false;

        private bool rightclick = false;

        private bool checkboxchecked;

        private List<string> Links = new List<string>()
        {
            "https://github.com/Glumboi",
            "https://github.com/Glumboi/EZAutoclicker"
        };

        public EZAutoclicker()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            int speed = Int32.Parse(textBox_speed.Text);
            clickon = true;
            this.Icon = ((System.Drawing.Icon)(Properties.Resources.icon_on1));
            timer_mouseclick.Interval = speed;
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public void DoMouseRightClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }

        private void timer_mouseclick_Tick(object sender, EventArgs e)
        {
            Thread T1 = new Thread(startclick);
            T1.Start();
        }

        private void startclick()
        {

            if (clickon)
            {
                switch (rightclick)
                {
                    case true:
                        DoMouseRightClick();
                        break;
                    case false:
                        DoMouseClick();
                        break;
                }
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            clickon = false;
            this.Icon = ((System.Drawing.Icon)(Properties.Resources.icon_off1));
        }

        protected override void WndProc(ref Message m)
        { 

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                // My hotkey has been typed

                // Do what you want here
                // ...

                switch (clickon)
                {
                    case true:
                        clickon = false;
                        this.Icon = ((System.Drawing.Icon)(Properties.Resources.icon_off1));
                        break;
                    case false:
                        int speed = Int32.Parse(textBox_speed.Text);
                        clickon = true;
                        this.Icon = ((System.Drawing.Icon)(Properties.Resources.icon_on1));
                        timer_mouseclick.Interval = speed;
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void EZAutoclicker_Load(object sender, EventArgs e)
        {

            this.Icon = ((System.Drawing.Icon)(Properties.Resources.icon_off1));
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 6, (int)Keys.F10);

            getsettings();

            switch (checkboxchecked)
            {
                case true:
                    checkBox_rightclick.Checked = true;
                    break;
                case false:
                    checkBox_rightclick.Checked = false;
                    break;
            }
        }

        private void EZAutoclicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            savesettings();
        }

        private void checkBox_rightclick_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox_rightclick.Checked)
            {
                case true:
                    rightclick = true;
                    checkboxchecked = true;
                    break;
                case false:
                    rightclick = false;
                    checkboxchecked = false;
                    break;
            }
        }

        public void getsettings()
        {
            checkboxchecked = Properties.Settings.Default.Checkboxchecked;
        }

        public void savesettings()
        {
            Properties.Settings.Default.Checkboxchecked = checkboxchecked;
            Properties.Settings.Default.Save();
        }

        private void linkLabel_github_Click(object sender, EventArgs e)
        {
            Process.Start(Links[0]);
        }

        private void Update_Tick(object sender, EventArgs e)
        {
        }

        private void linkLabel_version_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Links[1]);
        }
    }
}