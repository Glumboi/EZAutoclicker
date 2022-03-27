using EZAutoclicker.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;

//Before everything i want to say YES i know i did switches
//that are basically pointless and will be converted to if
//statements anyway by the compiler but i used it to get used to
//using switches in more bigger if statements (thats also the way i learn
//just go into the web look up any question you got look at the solutions 
//and do them over and over even when it is too much or pointless in some cases)
//but i am only 15 and dont even program longer then half a year so ¯\_(ツ)_/¯
//i dont know if anything i say helps anyone xD
//another reason for the switches is that i find them more readable than if statements

namespace EZAutoclicker
{
    public partial class EZAutoclicker : MaterialForm
    {
        //Creates an instance of my logging class for the info log button
        private static Logging.CreateLogs log = new Logging.CreateLogs();

        //Imports mouse_event to simulate mouse clicks
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        //Extern methods used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //Hotkeys
        private const int ACTION_HOTKEY_ID = 1;

        //This one is not used currently but i am planing
        //in using it for a custom hotkey
        //method later down the road probably around V 3.x.x
        private const int ACTION_HOTKEY_ID2 = 1;

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEVENTF_MIDDLEDOWN = 0x020;
        private const int MOUSEVENTF_MIDDLEUP = 0x040;
        private const int MOUSEEVENTF_RIGHTUP = 0x010;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;

        //Variables used frontend
        private bool clickon = false;
        private bool rightclick = false;
        private bool checkboxchecked;
        private bool middleclick;
        private bool checkboxchecked2;
        private string[] Links = 
        { 
            "https://github.com/Glumboi", 
            "https://github.com/Glumboi/EZAutoclicker" 
        };

        public EZAutoclicker()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.MaximumSize = new System.Drawing.Size(479, 283);
            this.MinimumSize = new System.Drawing.Size(479, 283);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            activate();
        }

        //Disables the clicking
        private void deactivate()
        {
            clickon = false;
            base.Icon = Resources.icon_off1;
            pictureBox1.Image = Resources.icon_off2;
        }

        //Starts the timer which is used to click
        //1000 interval = one click every s
        //1 interval = one click every ms
        private void activate()
        {
            string speed_str = textBox_speed.Text;
            if (string.IsNullOrWhiteSpace(speed_str))
            {
                clickon = true;
                base.Icon = Resources.icon_on1;
                pictureBox1.Image = Resources.icon_on2;
                timer_mouseclick.Interval = 1000;
            }
            else
            {
                try
                {
                    int speed = Int32.Parse(speed_str);
                    clickon = true;
                    base.Icon = Resources.icon_on1;
                    pictureBox1.Image = Resources.icon_on2;
                    timer_mouseclick.Interval = speed;
                    if (!timer_mouseclick.Enabled)
                    {
                        timer_mouseclick.Start();
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("You have to enter a number!", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public void DoMiddleClick()
        {
            //Call the imported function with the cursor's current position
            uint Y = (uint)Cursor.Position.Y;
            uint X = (uint)Cursor.Position.X;
            mouse_event(MOUSEVENTF_MIDDLEDOWN | MOUSEVENTF_MIDDLEUP, X, Y, 0, 0);
        }

        public void DoMouseRightClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }

        //This is the timer used to click 
        private void timer_mouseclick_Tick(object sender, EventArgs e)
        {
            Thread T1 = new Thread(startclick);
            T1.Start();
        }

        /*This is the method the timer executes everytime when ticking
        This works like that: 
        timer ticks and executes the method which does this:
        Is click enabled? If so lets check if it is rightclick
        it is rightlick? Yes? ok lets do a right click then.
        When its not rightclick:
        Huh so rightclick its not. Ok, is it not rightclick 
        and not middleclick? Its not? Ok, lets do a normal left click then.
        When it is middleclick:
        Ok so is it middleclick? Yes? Ok, lets do middleclicks then.
        When it is rightclick and middleclick:
        So it is middle and right click? Yes???? Shoot this
        wont work we need an error here!*/

        //This comment might be too much but i love to explain stuff i did xD.

        //Also the order of the if statements might be weird but changing them results
        //into non working code so i will leave it like that for now
        private void startclick()
        {
            if (clickon)
            {
                if (rightclick)
                {
                    DoMouseRightClick();  
                }
                else if(!rightclick && !middleclick)
                {
                    DoMouseClick();
                }
                if(middleclick)
                {
                    DoMiddleClick();
                }
                if(middleclick && rightclick)
                {
                    timer_mouseclick.Stop();
                    MessageBox.Show("You can't do right and middle click at the same time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            deactivate(); 
        }

        //This handles when the hotkey (shift + ctrl + F10) gets pressed
        //i also dont know exactly what this here does since i grabbed it from
        //a stackoverflow post but not knowing something isnt a crime so
        protected override void WndProc(ref Message m)
        {
            string speed_str = textBox_speed.Text;

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID)
            {
                switch (clickon)
                {
                    case true:
                        clickon = false;
                        base.Icon = Resources.icon_off1;
                        pictureBox1.Image = Resources.icon_off2;
                        break;
                    case false:
                        if (string.IsNullOrWhiteSpace(speed_str))
                        {
                            clickon = true;
                            base.Icon = Resources.icon_on1;
                            pictureBox1.Image = Resources.icon_on2;
                            timer_mouseclick.Interval = 1000;
                        }
                        else
                        {
                            int speed = Int32.Parse(textBox_speed.Text);
                            clickon = true;
                            base.Icon = Resources.icon_on1;
                            pictureBox1.Image = Resources.icon_on2;
                            timer_mouseclick.Interval = speed;
                        }
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void EZAutoclicker_Load(object sender, EventArgs e)
        {
            base.Icon = Resources.icon_off1;
            pictureBox1.Image = Resources.icon_off2;
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID, 6, (int)Keys.F10);

            getsettings();

            //Checks if rightclick is true and checks/unchecks the checkbox
            switch (checkboxchecked)
            {
                case true:
                    checkBox_rightclick.Checked = true;
                    break;
                case false:
                    checkBox_rightclick.Checked = false;
                    break;
            }

            //Checks if middleclick is true and checks/unchecks the checkbox
            switch (checkboxchecked2)
            {
                case true:
                    checkBox_middleclick.Checked = true;
                    break;
                case false:
                    checkBox_middleclick.Checked = false;
                    break;
            }
        }

        private void EZAutoclicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            savesettings();
        }

        private void checkBox_rightclick_CheckedChanged(object sender, EventArgs e)
        {
            //Checks if right click is checked and updates the variables
            //for the settings and clicks
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

        //Assigns checkboxchecked and checkboxchecked2 to the settings
        //and displays an error when a non working config is set
        public void getsettings()
        {
            checkboxchecked = Properties.Settings.Default.Checkboxchecked;
            checkboxchecked2 = Properties.Settings.Default.Checkboxchecked2;
            if (checkboxchecked && checkboxchecked2)
            {
                MessageBox.Show("Warning: You've selected right and middle click this will turn into an error! \nUncheck one of them to keep the autoclicker running", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Assigns the settings and saves them
        public void savesettings()
        {
            Properties.Settings.Default.Checkboxchecked = checkboxchecked;
            Properties.Settings.Default.Checkboxchecked2 = checkboxchecked2;
            Properties.Settings.Default.Save();
        }

        //Opens my Github page
        private void linkLabel_github_Click(object sender, EventArgs e)
        {
            Process.Start(Links[0]);
        }

        //Not used at the moment
        private void Update_Tick(object sender, EventArgs e)
        {
        }

        //Opens the projects Github page
        private void linkLabel_version_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Links[1]);
        }

        //Checks if the middle click checkbox is checked and updates the variables
        //for the settings and clicks
        private void checkBox_middleclick_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox_middleclick.Checked)
            {
                case true:
                    middleclick = true;
                    checkboxchecked2 = true;
                    break;
                case false:
                    middleclick = false;
                    checkboxchecked2 = false;
                    break;
            }
        }

        private void button_logs_Click(object sender, EventArgs e)
        {
            log.makeLog("_Info", "Info log created at the ");
        }
    }
}