using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KageForwarder
{
    public partial class Information : Form
    {
		public Information(string Bit = null, string ipz = null, string resolution = null, string token = null, string os = null, string user = null)
		{
			InitializeComponent();
			resLabel.Text = resolution;
			ipLabel.Text = ipz;
			computername.Text = user;
			username.Text = os;
			textBox1.Text = token;
			screenshots.Text = Bit;
			if (token != null)
			{
				lastworldl.Text = "Click to copy";
			}
			else
            {
				lastworldl.Text = "Null";
			}
			if (Bit != null)
			{
				screenshots.Text = Bit;
			}
			else
			{
				screenshots.Text = "Null";
			}
			base.FormBorderStyle = FormBorderStyle.None;
		}

        private void label1_Click(object sender, EventArgs e)
        {
			Close();
			
		}

        private void label2_Click(object sender, EventArgs e)
        {
			Form1.ActiveForm.WindowState = FormWindowState.Minimized;
		}

        private void lastworldl_Click(object sender, EventArgs e)
        {
			Clipboard.SetText(textBox1.Text);
        }

        private void screenshots_Click(object sender, EventArgs e)
        {
			//Clipboard.SetText(Screenshottext.Text);
        }
    }
}
