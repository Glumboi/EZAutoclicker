using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZAutoclicker.Logging
{
    public class CreateLogs
    {
        //A custom method that is use in another project (not out yet) 
        //but cut down a bit here
        public void makeLog(string Filename, string Start_Close_text)
        {
            //path was really a "path" in my other project but does not
            //work here for some reason so it is used as a name parameter right now
            string path = @"EZAutoclickerLOG__";
            string fileend = ".txt";
            string name = Filename;
            string time = DateTime.Now.ToString("yyyy/MM/dd_HH/mm");
            var os = RuntimeInformation.OSDescription;
            string assemblyversion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            try
            {
                File.WriteAllText(path
                    + time
                    + name
                    + fileend, Start_Close_text
                    + time
                    + "\nWith: "
                    + "\nOs version: "
                    + os
                    + "\nEZAutoclicker version: "
                    + assemblyversion);
            }
            catch
            {
                MessageBox.Show("Could not create logs", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
