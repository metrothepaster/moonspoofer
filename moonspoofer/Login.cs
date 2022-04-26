using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Login : Form
    {

        /*
        * 
        * WATCH THIS VIDEO TO SETUP APPLICATION: https://youtube.com/watch?v=RfDTdiBq4_o
        * 
        */

        /*
Optional Functions:

KeyAuthApp.webhook("lfvbBrbFhIr", "?sellerkey=CUqDqlCIgl&type=resethash");
// send secure request to webhook which is impossible to crack into. the base link set on the website is https://keyauth.com/api/seller/, which nobody except you can see, so the final request is https://keyauth.com/api/seller/?sellerkey=CUqDqlCIgl&type=resethash

// byte[] result = KeyAuthApp.download("902901"); // downloads application file
// File.WriteAllBytes("C:\\Users\\mak\\Downloads\\KeyAuth-CSHARP-Example-main (5)\\KeyAuth-CSHARP-Example-main\\ConsoleExample\\bin\\Debug\\countkeys.txt", result);

MessageBox.Show(KeyAuthApp.var("123456")); // retrieve application variable
*/

        // KeyAuthApp.register("username", "password", "key");
        //KeyAuthApp.login("username", "password"); 

        public static api KeyAuthApp = new api(
            name: "PUT YOUR KEYATUH",
            ownerid: "PUT YOUR KEYATUH",
            secret: "PUT YOUR KEYATUH",
            version: "PUT YOUR KEYATUH"
        );

        public Login()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] ida64 = Process.GetProcessesByName("ida64");
            Process[] ida32 = Process.GetProcessesByName("ida32");
            Process[] ollydbg = Process.GetProcessesByName("ollydbg");
            Process[] ollydbg64 = Process.GetProcessesByName("ollydbg64");
            Process[] loaddll = Process.GetProcessesByName("loaddll");
            Process[] httpdebugger = Process.GetProcessesByName("httpdebugger");
            Process[] windowrenamer = Process.GetProcessesByName("windowrenamer");
            Process[] processhacker = Process.GetProcessesByName("processhacker");
            Process[] processhacker2 = Process.GetProcessesByName("Process Hacker");
            Process[] processhacker3 = Process.GetProcessesByName("ProcessHacker");
            Process[] HxD = Process.GetProcessesByName("HxD");
            Process[] parsecd = Process.GetProcessesByName("parsecd");
            Process[] ida = Process.GetProcessesByName("ida");
            Process[] dnSpy = Process.GetProcessesByName("dnSpy");
            Process[] megadumper = Process.GetProcessesByName("MegaDumper");
            if (ida64.Length != 0 || ida32.Length != 0 || ollydbg.Length != 0 || ollydbg64.Length != 0 || loaddll.Length != 0 || httpdebugger.Length != 0 || windowrenamer.Length != 0 || processhacker.Length != 0 || processhacker2.Length != 0 || processhacker3.Length != 0 || HxD.Length != 0 || ida.Length != 0 || parsecd.Length != 0 || dnSpy.Length != 0 || megadumper.Length != 0)
            {   
                SendKeys.Send("{PRTSC}");
                Image myImage = Clipboard.GetImage();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();

            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);


                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Posiadasz star¹ wersjê programu, pobierz now¹ za pomoc¹ komendy !download z kana³u #cmds na discordzie discord.gg/uran");
                Thread.Sleep(2500);
                Environment.Exit(0);
            }

            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
            // if(KeyAuthApp.checkblack())
            // {
            //     MessageBox.Show("user is blacklisted");
            // }
            // else
            // {
            //     MessageBox.Show("user is not blacklisted");
            // }
            KeyAuthApp.check();
        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }

        private void UpgradeBtn_Click(object sender, EventArgs e)
        {
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text, textBox1.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is invalid!");

            }
        }

        private void RgstrBtn_Click(object sender, EventArgs e)
        {

        }

        private void LicBtn_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(username.Text, textBox1.Text, textBox4.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("License is invalid!");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(username.Text, textBox1.Text, textBox4.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("License is invalid!");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            {
                KeyAuthApp.login(username.Text, textBox1.Text);
                if (KeyAuthApp.response.success)
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password is invalid!");

                }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (guna2Button1.BorderThickness == 0)
            {
                MessageBox.Show("To register please fill in username, password and license (Click the button again)");
                guna2Button1.BorderThickness = 1;

            }
            else
            {
                KeyAuthApp.register(username.Text, textBox1.Text, textBox4.Text);
                if (KeyAuthApp.response.success)
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("License is invalid!");
            }

            guna2Panel1.Show();
        }
    }
}
