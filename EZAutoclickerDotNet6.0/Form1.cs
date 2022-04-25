using MaterialSkin;
using MaterialSkin.Controls;
using Octokit;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using EZAutoclicker.Logging;
using EZAutoclickerDotNet6._0.Properties;

namespace EZAutoclickerDotNet6._0
{
    public partial class Form1 : MaterialForm
    {
        //Creates an instance of my logging class for the info log button
        private static EZAutoclicker.Logging.CreateLogs log = new EZAutoclicker.Logging.CreateLogs();

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

        private string[] Links =
        {
            "https://github.com/Glumboi",
            "https://github.com/Glumboi/EZAutoclicker"
        };

        private bool clickon;
        private bool middleclick;
        private bool rightclick;
        private bool checkboxchecked;
        private bool checkboxchecked2;

        public Form1()
        {
            CheckGitHubNewerVersion();
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.Icon = Resources.icon_off;
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID, 6, (int)Keys.F10);

            getsettings();

            //Checks if rightclick is true and checks/unchecks the checkbox
            switch (checkboxchecked)
            {
                case true:
                    Rightclick_CB.Checked = true;
                    break;
                case false:
                    Rightclick_CB.Checked = false;
                    break;
            }

            //Checks if middleclick is true and checks/unchecks the checkbox
            switch (checkboxchecked2)
            {
                case true:
                    Middleclick_CB.Checked = true;
                    break;
                case false:
                    Middleclick_CB.Checked = false;
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            savesettings();
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

        private void Start_BN_Click(object sender, EventArgs e)
        {
            activate();
        }

        //Disables the clicking
        private void deactivate()
        {
            clickon = false;
            base.Icon = Resources.icon_off;
        }

        //Starts the timer which is used to click
        //1000 interval = one click every s
        //1 interval = one click every ms
        private void activate()
        {
            string speed_str = Speed_TB.Text;
            if (string.IsNullOrWhiteSpace(speed_str))
            {
                clickon = true;
                base.Icon = Resources.icon_on;
                Mouseclick_TR.Interval = 1000;
            }
            else
            {
                try
                {
                    int speed = Int32.Parse(speed_str);
                    clickon = true;
                    base.Icon = Resources.icon_on;
                    Mouseclick_TR.Interval = speed;
                    if (!Mouseclick_TR.Enabled)
                    {
                        Mouseclick_TR.Start();
                    }
                }
                catch (Exception)
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

        private void Stop_BN_Click(object sender, EventArgs e)
        {
            deactivate();
        }

        private void Mouseclick_TR_Tick(object sender, EventArgs e)
        {
            Thread T1 = new Thread(startclick);
            T1.Start();
        }

        private void startclick()
        {
            if (clickon)
            {
                if (rightclick)
                {
                    DoMouseRightClick();
                }
                else if (!rightclick && !middleclick)
                {
                    DoMouseClick();
                }
                if (middleclick)
                {
                    DoMiddleClick();
                }
                if (middleclick && rightclick)
                {
                    Mouseclick_TR.Stop();
                    MessageBox.Show("You can't do right and middle click at the same time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //This handles when the hotkey (shift + ctrl + F10) gets pressed
        //i also dont know exactly what this here does since i grabbed it from
        //a stackoverflow post but not knowing something isnt a crime so
        protected override void WndProc(ref Message m)
        {
            string speed_str = Speed_TB.Text;

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID)
            {
                switch (clickon)
                {
                    case true:
                        Mouseclick_TR.Stop();
                        clickon = false;
                        base.Icon = Resources.icon_off;
                        break;
                    case false:
                        if (string.IsNullOrWhiteSpace(speed_str))
                        {
                            clickon = true;
                            base.Icon = Resources.icon_on;
                            Mouseclick_TR.Interval = 1000;
                            Mouseclick_TR.Start();
                        }
                        else
                        {
                            int speed = Int32.Parse(Speed_TB.Text);
                            clickon = true;
                            base.Icon = Resources.icon_on;
                            Mouseclick_TR.Interval = speed;
                            Mouseclick_TR.Start();
                        }
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void Middleclick_CB_CheckedChanged(object sender, EventArgs e)
        {
            switch (Middleclick_CB.Checked)
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

        private void Rightclick_CB_CheckedChanged(object sender, EventArgs e)
        {
            //Checks if right click is checked and updates the variables
            //for the settings and clicks
            switch (Rightclick_CB.Checked)
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

        private async System.Threading.Tasks.Task CheckGitHubNewerVersion()
        {
            //Get all releases from GitHub
            //Source: https://octokitnet.readthedocs.io/en/latest/getting-started/
            GitHubClient client = new GitHubClient(new ProductHeaderValue("EZAC"));
            IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("Glumboi", "EZAutoclicker");

            //Setup the versions
            Version latestGitHubVersion = new Version(releases[0].TagName);
            Assembly Reference = typeof(Form1).Assembly;
            Version Version = Reference.GetName().Version;
            Version localVersion = new Version(Version.ToString()); 
                                                                    

            //Compare the Versions
            //Source: https://stackoverflow.com/questions/7568147/compare-version-numbers-without-using-split-function
            int versionComparison = localVersion.CompareTo(latestGitHubVersion);
            if (versionComparison < 0)
            {
                DialogResult dialogResult = MessageBox.Show("You got an outdated version of EZAC installed would you like to update?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Debug.WriteLine("Outdated");
                    OpenUrl("https://github.com/Glumboi/EZAutoclicker/releases");
                }
                else if (dialogResult == DialogResult.No)
                {
                }
                //The version on GitHub is more up to date than this local release.
            }
            else if (versionComparison > 0)
            {
                //This local version is greater than the release version on GitHub.
            }
            else
            {
                //This local Version and the Version on GitHub are equal.
            }
        }

        private void Log_BN_Click(object sender, EventArgs e)
        {
            log.makeLog("_Info", "Info log created at the ");
        }

        private void Github_LLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl(Links[0]);
        }

        private void Version_LLBL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl(Links[1]);
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else
                {
                    return;
                }
            }
        }
    }
}