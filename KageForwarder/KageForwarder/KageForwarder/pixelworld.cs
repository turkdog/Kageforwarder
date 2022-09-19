using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KageForwarder
{
    public partial class pixelworld : Form
    {
        public pixelworld(string pc, string cognito, string lastlogin)
        {
            InitializeComponent();
            userkek.Text = pc;
            lastlogintext.Text = lastlogin;
            cognitotext.Text = cognito;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void apply_Click(object sender, EventArgs e)
        {
            RegistryKey gtreg;

            gtreg = Registry.CurrentUser.OpenSubKey(@"Software\Kukouri\Pixel Worlds", true);
            if (gtreg != null)
            {
                foreach (string key in gtreg.GetValueNames())
                {
                    if (key.Contains("CognitoIdentity:IdentityId"))
                    {
                        
                        gtreg.SetValue(key, Encoding.UTF8.GetBytes(cognitotext.Text), RegistryValueKind.Binary);
                    }
                    if (key.Contains("lastLoginKey"))
                    {
                        gtreg.SetValue(key, Encoding.UTF8.GetBytes(lastlogintext.Text), RegistryValueKind.Binary);

                    }
                }
                MessageBox.Show("KageForwarder", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
