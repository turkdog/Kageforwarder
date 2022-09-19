using Microsoft.Win32;
using System;
using System.Collections.Specialized;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KageForwarder
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public static string expiry = "null";
        public Login()
        {
            InitializeComponent();
        }
        private string request(NameValueCollection nvc, string action)
        {
            string @string;
            using (WebClient webClient = new WebClient())
            {
                string str = "http://kageforwarder2.ml/trash";
                byte[] bytes = webClient.UploadValues(str + "/" + action + ".php", nvc);
                @string = Encoding.Default.GetString(bytes);
            }
            return @string;
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
        public string hardwareid()
        {
            string str =  identifier("Win32_DiskDrive", "Model");
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

        private string genhash(string input)
        {
            byte[] array = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder(array.Length * 2);
            foreach (byte b in array)
            {
                stringBuilder.Append(b.ToString("X2"));
            }
            return stringBuilder.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(username.Text == string.Empty))
                {
                    if (!(password.Text == string.Empty))
                    {
                        NameValueCollection nameValueCollection = new NameValueCollection();
                        string text2;
                        string text = text2 = username.Text;
                        string value = genhash(password.Text);
                        string value2 = hardwareid();
                        nameValueCollection["login"] = text2.ToLower();
                        nameValueCollection["password"] = value;
                        nameValueCollection["identifier"] = value2;
                        string text3 = text.ToLower();
                        string text4 = request(nameValueCollection, "login");
                        if (text4.Contains("success"))
                        {
                            string str = text4.Split(new char[]
                            {
                                '|'
                            }, StringSplitOptions.RemoveEmptyEntries)[1];
                            using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
                            {
                                RegistryKey registryKey2 = registryKey;
                                if (registryKey != null)
                                {
                                    registryKey2 = registryKey2.CreateSubKey("trash\\lol");
                                    registryKey2.SetValue("ownr", text3);
                                    registryKey2.SetValue("aut", value);
                                }
                            }
                            MessageBox.Show("Logged in successfully. This account expires at " + str, "login page", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            expiry = expiry.Replace("null", str);
                            base.Hide();
                            new Form1(str)
                            {
                                sad = text3
                            }.ShowDialog();
                        }
                        else if (text4.Contains("stolen"))
                        {
                            MessageBox.Show("This is not your account.", "failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else if (text4.Contains("ban"))
                        {
                            MessageBox.Show("You were been blacklisted.", "blacklist", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            Environment.Exit(0);
                        }
                        else if (text4.Contains("fail"))
                        {
                            MessageBox.Show("Username/password is wrong. Try again", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (text4.Contains("expired"))
                        {
                            MessageBox.Show("This account has expired. Extend your license in our discord(click the picture below register button).", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("This account doesnt even exist");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("maybe you should put your password/username?", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                
                NameValueCollection nameValueCollection = new NameValueCollection();
                nameValueCollection["check"] = "changelog";
                RichTextBox richTextBox = richTextBox1;
                richTextBox.Text += request(nameValueCollection, "info");
            }
            catch
            {
                MessageBox.Show("Can't connect to the server. Is your internet connection operational?");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex("^[a-zA-Z0-9]*$");
                if (!(username.Text == string.Empty))
                {
                    if (!(password.Text == string.Empty))
                    {
                        if (regex.IsMatch(username.Text))
                        {
                            if (regex.IsMatch(password.Text))
                            {
                                NameValueCollection nameValueCollection = new NameValueCollection();
                                string text = username.Text;
                                string value = genhash(password.Text);
                                string value2 = hardwareid();
                                nameValueCollection["login"] = text.ToLower();
                                nameValueCollection["password"] = value;
                                nameValueCollection["identifier"] = value2;
                                string text2 = request(nameValueCollection, "register");
                                if (text2.Contains("success"))
                                {
                                    MessageBox.Show("New account has been registered successfully. You can login now using your username/password!", "Registration successful!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }
                                else if (text2.Contains("overuse"))
                                {
                                    MessageBox.Show("You can't register more than one account at one time!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                                else if (text2.Contains("vpn"))
                                {
                                    MessageBox.Show("Turn off your fucking vpn before attempting to register", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                                else if (text2.Contains("fail"))
                                {
                                    MessageBox.Show("Unknown error occured. Try again", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password must consist only of alphanumeric characters!", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username must consist only of alphanumeric characters!", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("maybe you should put your password?", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("maybe you should put your username?", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Server is dead or your internet is not working. Try again later", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(username.Text == string.Empty))
                {
                    if (!(password.Text == string.Empty))
                    {
                        NameValueCollection nameValueCollection = new NameValueCollection();
                        string text2;
                        string text = text2 = username.Text;
                        string value = genhash(password.Text);
                        string value2 = hardwareid();
                        nameValueCollection["login"] = text2.ToLower();
                        nameValueCollection["password"] = value;
                        nameValueCollection["identifier"] = value2;
                        string text3 = text.ToLower();
                        string text4 = request(nameValueCollection, "login");
                        if (text4.Contains("success"))
                        {
                            string str = text4.Split(new char[]
                            {
                                '|'
                            }, StringSplitOptions.RemoveEmptyEntries)[1];
                            using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
                            {
                                RegistryKey registryKey2 = registryKey;
                                if (registryKey != null)
                                {
                                    registryKey2 = registryKey2.CreateSubKey("trash\\lol");
                                    registryKey2.SetValue("ownr", text3);
                                    registryKey2.SetValue("aut", value);
                                }
                            }
                            MessageBox.Show("Logged in successfully. This account expires at " + str, "login page", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            expiry = expiry.Replace("null", str);
                            base.Hide();
                            new Form1(str)
                            {
                                sad = text3
                            }.ShowDialog();
                        }
                        else if (text4.Contains("stolen"))
                        {
                            MessageBox.Show("This is not your account.", "failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else if (text4.Contains("ban"))
                        {
                            MessageBox.Show("You were been blacklisted.", "blacklist", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            Environment.Exit(0);
                        }
                        else if (text4.Contains("fail"))
                        {
                            MessageBox.Show("Username/password is wrong. Try again", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (text4.Contains("expired"))
                        {
                            MessageBox.Show("Your account has expired. Extend your license in our discord.", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("This account doesnt even exist");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("maybe you should put your password/username?", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex("^[a-zA-Z0-9]*$");
                if (!(username.Text == string.Empty))
                {
                    if (!(password.Text == string.Empty))
                    {
                        if (regex.IsMatch(username.Text))
                        {
                            if (regex.IsMatch(password.Text))
                            {
                                NameValueCollection nameValueCollection = new NameValueCollection();
                                string text = username.Text;
                                string value = genhash(password.Text);
                                string value2 = hardwareid();
                            
                                nameValueCollection["login"] = text.ToLower();
                                nameValueCollection["password"] = value;
                                nameValueCollection["identifier"] = value2;
                                string text2 = request(nameValueCollection, "register");
                                if (text2.Contains("success"))
                                {
                                    MessageBox.Show("New account has been registered successfully. You can login now using your username/password!", "Registration successful!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }
                                else if (text2.Contains("overuse"))
                                {
                                    MessageBox.Show("You can't register more than one account at one time!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                                else if (text2.Contains("vpn"))
                                {
                                    MessageBox.Show("Turn off your fucking vpn before attempting to register", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                                else if (text2.Contains("fail"))
                                {
                                    MessageBox.Show("Unknown error occured. Try again", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password must consist only of alphanumeric characters!", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username must consist only of alphanumeric characters!", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("maybe you should put your password?", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("maybe you should put your username?", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Server is dead or your internet is not working. Try again later", "login page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login.ActiveForm.WindowState = FormWindowState.Minimized;
        }
    }
}
