using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KageForwarder
{
    public partial class Credentials : Form
    {
   
		public Credentials(List<Credentials.Browserz> lol = null)
		{
			InitializeComponent();
			int num = 0;
			foreach (Credentials.Browserz browserz in lol)
			{
				bunifuCustomDataGrid1.Rows.Add();
				bunifuCustomDataGrid1.Rows[num].Cells["URL"].Value = browserz.url;
				bunifuCustomDataGrid1.Rows[num].Cells["Browser"].Value = browserz.browser;
				bunifuCustomDataGrid1.Rows[num].Cells["Password"].Value = browserz.password;
				bunifuCustomDataGrid1.Rows[num].Cells["Login"].Value = browserz.login;
				num++;
			}
		}
		private void copyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (bunifuCustomDataGrid1.CurrentRow.Cells["Password"].Value != null)
			{
				Clipboard.SetText(bunifuCustomDataGrid1.CurrentRow.Cells["Password"].Value.ToString());
			}
		}

		private void copyLoginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (bunifuCustomDataGrid1.CurrentRow.Cells["Login"].Value != null)
			{
				Clipboard.SetText(bunifuCustomDataGrid1.CurrentRow.Cells["Login"].Value.ToString());
			}
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (bunifuCustomDataGrid1.CurrentRow.Cells["URL"].Value != null)
			{
				Clipboard.SetText(bunifuCustomDataGrid1.CurrentRow.Cells["URL"].Value.ToString());
			}
		}
		[DataContract]
		public class Browserz
		{
	
			[DataMember]
			public string browser { get; set; }

			[DataMember]
			public string url { get; set; }

			[DataMember]
			public string password { get; set; }

			[DataMember]
			public string login { get; set; }
		}

        private void label2_Click(object sender, EventArgs e)
        {
			Form1.ActiveForm.WindowState = FormWindowState.Minimized;
		}

        private void label1_Click(object sender, EventArgs e)
        {
			Close();
        }
    }
}
