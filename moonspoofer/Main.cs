using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace KeyAuth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Login.KeyAuthApp.check();
            nazwa.Text = "" + Login.KeyAuthApp.user_data.username;
            dokiedy.Text = Login.KeyAuthApp.expirydaysleft();
            createDate.Text = "" + UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.createdate));
            version.Text = Login.KeyAuthApp.app_data.version;

        }


        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void subscriptionDaysLabel_Click(object sender, EventArgs e)
        {

        }

        private void expiry_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will be introduced in 3.0");
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void key_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        }


        private void guna2Button3_Click_2(object sender, EventArgs e)
        { }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"echo off");
                writer.WriteLine(@"taskkill / f / im Steam.exe / t");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q % LocalAppData%\DigitalEntitlements");
                writer.WriteLine(@"taskkill / f / im Steam.exe / t");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q % userprofile %\AppData\Roaming\CitizenFX");
                writer.WriteLine(@"taskkill / f / im Steam.exe / t");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"set hostspath =% windir %\System32\drivers\etc\hosts");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"echo 127.0.0.1 xboxlive.com >> % hostspath %");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\HardwareID / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\Store / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_chrome.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_372.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_1604.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_1868.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_2060.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_2189.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\botan.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\asi - five.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\steam.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\steam_api64.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenGame.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\profiles.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cfx_curl_x86_64.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX.ini");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\caches.XML");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\adhesive.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"taskkill / f / im Steam.exe / t");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\discord.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"RENAME % userprofile %\AppData\Roaming\discord\0.0.309\modules\discord_rpc STARCHARMS_SPOOFER");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\Browser");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\db");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\dunno");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\priv");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\servers");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\subprocess");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\unconfirmed");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\authbrowser");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\crashometry");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\launcher_skip");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\launcher_skip_mtl2");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\crashes\*.* ");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\logs\*.* ");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\mods\*.* ");
                writer.WriteLine(@":folderclean");
                writer.WriteLine(@"call :getDiscordVersion");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"goto :xboxclean");
                writer.WriteLine(@": getDiscordVersion");
                writer.WriteLine(@"for / d %% a in (' % appdata%\Discord\*') do (");
                writer.WriteLine(@"     set 'varLoc =%%a'");
                writer.WriteLine(@"   goto :d1");
                writer.WriteLine(@")");
                writer.WriteLine(@":d1");
                writer.WriteLine(@"for / f 'delims =\ tokens=7' %% z in ('echo %varLoc%') do (");
                writer.WriteLine(@"     set 'discordVersion =%%z'");
                writer.WriteLine(@")");
                writer.WriteLine(@"goto :EOF");
                writer.WriteLine(@": xboxclean");
                writer.WriteLine(@" cls");
                writer.WriteLine(@"powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
                writer.WriteLine(@"sc stop XblAuthManager");
                writer.WriteLine(@"sc stop XblGameSave");
                writer.WriteLine(@"sc stop XboxNetApiSvc");
                writer.WriteLine(@"sc stop XboxGipSvc");
                writer.WriteLine(@"sc delete XblAuthManager");
                writer.WriteLine(@"sc delete XblGameSave");
                writer.WriteLine(@"sc delete XboxNetApiSvc");
                writer.WriteLine(@"sc delete XboxGipSvc");
                writer.WriteLine(@"reg delete 'HKLM\SYSTEM\CurrentControlSet\Services\xbgm' / f");
                writer.WriteLine(@"schtasks / Change / TN 'Microsoft\XblGameSave\XblGameSaveTask' / disable");
                writer.WriteLine(@"schtasks / Change / TN 'Microsoft\XblGameSave\XblGameSaveTaskLogon' / disableL");
                writer.WriteLine(@"reg add 'HKLM\SOFTWARE\Policies\Microsoft\Windows\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"set hostspath =% windir %\System32\drivers\etc\hosts");
                writer.WriteLine(@"   echo 127.0.0.1 xboxlive.com >> % hostspath %");
                writer.WriteLine(@"   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
                writer.WriteLine(@"   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
                writer.WriteLine(@"   rd % userprofile %\AppData\Local\DigitalEntitlements / q / s");
                writer.WriteLine(@"exit");
                writer.WriteLine(@"goto :eof");

            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Unlinked successfully");
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will be introduced in 3.0");
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"echo off");
                writer.WriteLine("cls");
                writer.WriteLine("taskkill /f /im Steam.exe /t");
                writer.WriteLine("cls");
                writer.WriteLine(@"set hostspath=%windir%\System32\drivers\etc\hosts");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\HardwareID / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\Store / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cfx_curl_x86_64.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\Browser");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\db");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\dunno");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\priv");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\servers");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\subprocess");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\unconfirmed");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\steam_api64.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\authbrowser");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\crashometry");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\launcher_skip");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cache\launcher_skip_mtl2");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\DigitalEntitlements");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\profiles.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_chrome.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_372.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_1604.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_1868.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_2060.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX_SubProcess_game_2189.bin");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\logs\*.* ");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenGame.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\cfx_curl_x86_64.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\steam.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"rmdir / s / q % userprofile %\AppData\Roaming\CitizenFX");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\asi - five.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\CitizenFX.ini");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\caches.XML");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\adhesive.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f % LocalAppData %\FiveM\FiveM.app\discord.dll");
                writer.WriteLine("cls");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\crashes\*.* ");
                writer.WriteLine("cls");
                writer.WriteLine(@"RENAME % userprofile %\AppData\Roaming\discord\0.0.309\modules\discord_rpc moonSpoofer");
                writer.WriteLine("cls");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Spoofed successfully");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hwidlabel_Click(object sender, EventArgs e)
        {

        }

        private void createDate_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            homeBTN.Checked = false;
            settingsBTN.Checked = true;
            SPOOFPANEL.Show();
            cleanPANEL.Hide();
            cleanBTN.Checked = false;
        }

        private void homeBTN_Click(object sender, EventArgs e)
        {
            settingsBTN.Checked = false;
            homeBTN.Checked = true;
            PANELhome.Show();
            SPOOFPANEL.Hide();
            cleanBTN.Checked = false;
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click_3(object sender, EventArgs e)
        {
        }



        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Font NormalFont = new Font("Arial", 12);
            Font BoldFont = new Font("Arial", 12, FontStyle.Bold);
            if (guna2Button6.Text == "SHOW")
            {

                guna2Button6.Text = "HIDE";
                hwidlabel.Text = Login.KeyAuthApp.user_data.hwid;
                hwidlabel.Font = NormalFont;
            }
            else
            {
                hwidlabel.Text = "HIDDEN";
                guna2Button6.Text = "SHOW";
                hwidlabel.Font = BoldFont;
            }

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://discord.gg/moonspoofer");
        }

        private void checkbox_Click_1(object sender, EventArgs e)
        {
            {
                if (checkbox.FillColor == Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255))))))
                {
                    checkbox.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                }
                else
                {
                    checkbox.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                }
            }
        }

        private void guna2Button2_Click_4(object sender, EventArgs e)
        {
            {
                if (guna2Button2.FillColor == Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255))))))
                {
                    guna2Button2.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                }
                else
                {
                    guna2Button2.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                }
            }
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            {
                if (guna2Button5.FillColor == Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10))))))
                {
                    guna2Button5.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                    guna2Button9.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                    guna2Button8.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                    guna2Button2.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                    checkbox.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));

                }
                else
                {
                    guna2Button5.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                    guna2Button9.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                    guna2Button8.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                    guna2Button2.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                    checkbox.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                }
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            {
                if (guna2Button9.FillColor == Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255))))))
                {
                    guna2Button9.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                }
                else
                {
                    guna2Button9.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                }
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            {
                if (guna2Button8.FillColor == Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255))))))
                {
                    guna2Button8.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                }
                else
                {
                    guna2Button8.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                }
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            {
                if (guna2Button12.FillColor == Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10))))))
                {
                    guna2Button10.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                    guna2Button11.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                    guna2Button14.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                    guna2Button13.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                    guna2Button12.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));

                }
                else
                {
                    guna2Button10.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                    guna2Button11.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                    guna2Button14.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                    guna2Button13.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                    guna2Button12.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                }
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            {
                if (guna2Button10.FillColor == Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255))))))
                {
                    guna2Button10.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                }
                else
                {
                    guna2Button10.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                }
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            {
                if (guna2Button11.FillColor == Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255))))))
                {
                    guna2Button11.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                }
                else
                {
                    guna2Button11.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                }
            }
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            {
                if (guna2Button14.FillColor == Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255))))))
                {
                    guna2Button14.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                }
                else
                {
                    guna2Button14.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                }
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            {
                if (guna2Button13.FillColor == Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255))))))
                {
                    guna2Button13.FillColor = Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
                }
                else
                {
                    guna2Button13.FillColor = Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
                }
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon | discord.gg/moonspoofer");
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon | discord.gg/moonspoofer");
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            settingsBTN.Checked = false;
            homeBTN.Checked = false;
            SPOOFPANEL.Show();
        }

        private void guna2Button17_Click_1(object sender, EventArgs e)
        {

            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"@echo off");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"rmdir /s /q %LocalAppData%\FiveM\FiveM.app\data");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Cache has been cleared");
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {

            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"@echo off");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"echo Wait...");
                writer.WriteLine(@"rmdir /s /q %LocalAppData%\FiveM\FiveM.app\citizen");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Citizen has been cleared");
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine(@"rmdir / s / q C:\Program Files\Epic Games\GTAV\reshade-shaders");
                writer.WriteLine(@"del / s / q / f C:\Program Files\Epic Games\GTAV\Dxgi.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files\Epic Games\GTAV\D3d10.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files\Epic Games\GTAV\d3d9.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files\Epic Games\GTAV\d3d8.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files\Epic Games\GTAV\Dxgi.txt");
                writer.WriteLine(@"rmdir / s / q D:\Program Files\Epic Games\GTAV\reshade-shaders");
                writer.WriteLine(@"del / s / q / f D:\Program Files\Epic Games\GTAV\Dxgi.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files\Epic Games\GTAV\D3d10.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files\Epic Games\GTAV\d3d9.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files\Epic Games\GTAV\d3d8.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files\Epic Games\GTAV\dxgi.log");
                writer.WriteLine(@"rmdir / s / q C:\Program Files (x86)\Steam\steamapps\common\Grand Theft Auto V\reshade-shaders");
                writer.WriteLine(@"del / s / q / f C:\Program Files (x86)\Steam\steamapps\common\Grand Theft Auto V\Dxgi.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files (x86)\Steam\steamapps\common\Grand Theft Auto V\D3d10.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files (x86)\Steam\steamapps\common\Grand Theft Auto V\d3d9.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files (x86)\Steam\steamapps\common\Grand Theft Auto V\d3d8.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files (x86)\Steam\steamapps\common\Grand Theft Auto V\Dxgi.txt");
                writer.WriteLine(@"del / s / q / f D:\Program Files (x86)\Steam\steamapps\common\Grand Theft Auto V\Dxgi.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files (x86)\Steam\steamapps\common\Grand Theft Auto V\D3d10.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files (x86)\Steam\steamapps\common\Grand Theft Auto V\d3d9.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files (x86)\Steam\steamapps\common\Grand Theft Auto V\d3d8.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files (x86)\Steam\steamapps\common\Grand Theft Auto V\Dxgi.txt");
                writer.WriteLine(@"rmdir / s / q C:\Program Files\Rockstar Games\Grand Theft Auto V\reshade-shaders");
                writer.WriteLine(@"del / s / q / f C:\Program Files\Rockstar Games\Grand Theft Auto V\Dxgi.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files\Rockstar Games\Grand Theft Auto V\D3d10.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files\Rockstar Games\Grand Theft Auto V\d3d9.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files\Rockstar Games\Grand Theft Auto V\d3d8.dll");
                writer.WriteLine(@"del / s / q / f C:\Program Files\Rockstar Games\Grand Theft Auto V\Dxgi.txt");
                writer.WriteLine(@"rmdir / s / q D:\Program Files\Rockstar Games\Grand Theft Auto V\reshade-shaders");
                writer.WriteLine(@"del / s / q / f D:\Program Files\Rockstar Games\Grand Theft Auto V\Dxgi.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files\Rockstar Games\Grand Theft Auto V\D3d10.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files\Rockstar Games\Grand Theft Auto V\d3d9.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files\Rockstar Games\Grand Theft Auto V\d3d8.dll");
                writer.WriteLine(@"del / s / q / f D:\Program Files\Rockstar Games\Grand Theft Auto V\Dxgi.txt");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\reshade-shaders");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\Dxgi.dll");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\D3d10.dll");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\d3d9.dll");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\d3d8.dll");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\Dxgi.txt");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Reshade has been cleared");
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine(@"del /s /q %systemdrive%\Windows\Temp\*.*");
                writer.WriteLine(@"del / s / q % userprofile %\AppData\Local\Temp\*.* ");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Temp has been cleared");
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine(@"ipconfig /flushdns");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Dns cache has been cleared");
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine(@"del /s /q %systemdrive%\$Recycle.bin\*.*");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Recycle bin has been cleared");
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine(@"set tmp2 = C:\Windows\Temp\moonhelper.bat");
                writer.WriteLine(@"echo @echo off > % tmp2 % ");
                writer.WriteLine(@"echo title Zyorby Cleaner V2 \ Background Apps Help >> % tmp2 %");
                writer.WriteLine(@"echo color 03 >> % tmp2 % ");
                writer.WriteLine(@"echo mode con:cols = 100 lines = 20 >> % tmp2 %");
                writer.WriteLine(@"echo echo Hello if you dont know what to do in the backgound apps setting then read this: >> % tmp2 % ");
                writer.WriteLine(@"echo echo If you want MAX Performance switch the Let apps run in the background settings to OFF >> % tmp2 %");
                writer.WriteLine(@"echo echo. >> % tmp2 % ");
                writer.WriteLine(@"echo echo If you want some of the apps running that you see you like leave those On and turn the rest OFF >> % tmp2 %");
                writer.WriteLine(@"echo echo. >> % tmp2 % ");
                writer.WriteLine(@"echo echo. >> % tmp2 %");
                writer.WriteLine(@"echo echo. >> % tmp2 % ");
                writer.WriteLine(@"echo echo. >> % tmp2 %");
                writer.WriteLine(@"echo echo Please Close This Window Once You Are Done >> % tmp2 % ");
                writer.WriteLine(@"echo set / p read = "" >> % tmp2 %");
                writer.WriteLine(@"start C:\Windows\Temp\zyorbybghelper.bat");
                writer.WriteLine(@"start ms - settings:privacy - backgroundapps");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Bg Apps has been disabled");
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine(@"set tmp3 = C:\Windows\Temp\moon2helper.bat");
                writer.WriteLine(@"echo @echo off > % tmp3 % ");
                writer.WriteLine(@"echo title Zyorby Cleaner V2 \ Startup Apps Help >> % tmp3 %");
                writer.WriteLine(@"echo color 03 >> % tmp3 % ");
                writer.WriteLine(@"echo mode con:cols = 100 lines = 20 >> % tmp3 %");
                writer.WriteLine(@"echo echo Hello if you dont know what to do in the startup apps setting then read this: >> % tmp3 % ");
                writer.WriteLine(@"echo echo. >> % tmp3 %");
                writer.WriteLine(@"echo echo What most do here is switch all uneccesary apps off on startup >> % tmp3 % ");
                writer.WriteLine(@"echo echo Like i turn off discord, steam, and all my peripheral apps >> % tmp3 %");
                writer.WriteLine(@" echo echo. >> % tmp3 % ");
                writer.WriteLine(@"echo echo. >> % tmp3 %");
                writer.WriteLine(@"echo echo. >> % tmp3 %");
                writer.WriteLine(@"echo echo. >> % tmp3 %");
                writer.WriteLine(@"echo echo Please Close This Window Once You Are Done >> % tmp3 % ");
                writer.WriteLine(@"echo set / p read = "" >> % tmp3 %");
                writer.WriteLine(@"start C:\Windows\Temp\zyorbystartupappshelper.bat");
                writer.WriteLine(@"start ms - settings:startupapps");


            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Bg Apps has been disabled");
        }

        private void guna2Button17_Click_2(object sender, EventArgs e)
        {
            SPOOFPANEL.Show();
            homeBTN.Checked = false;
            settingsBTN.Checked = false;

        }

        private void guna2Button17_Click_3(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button17_Click_4(object sender, EventArgs e)
        {
        }


        private void hotandcoldBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mega.nz/file/OJgBFSSR#-I7eZ-QLiSyGtM_x4nzMJunJkKME9xqitV4DVL7EL9c");
        }

        private void redcloudsBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mediafire.com/file/73bawwffq98bp35/SuperCottonCandy-Cheeco#1111.rar/file");
        }

        private void blueskyBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mediafire.com/file/7kmhpz6bar3e4br/feaR+V3+Visual+Pack.rar/file");
        }

        private void bluelightBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://megawrzuta.pl/download/7f4178eb578dbfb19218a9800e020b01.html");
        }

        private void nazwa_Click(object sender, EventArgs e)
        {

        }

        private void dokiedy_Click(object sender, EventArgs e)
        {

        }

        private void SPOOFPANEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button16_Click_1(object sender, EventArgs e)
        {
            SPOOFPANEL.Show();
            cleanPANEL.Show();
            settingsBTN.Checked = false;
            homeBTN.Checked = false;
            cleanBTN.Checked = true;
        }

        private void guna2Button16_Click_2(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\browser");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\db");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\priv");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\servers");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\subprocess");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\cache\unconfirmed");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\crashometry");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\launcher_skip_mtl2");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\session");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\plugins");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\mods");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\logs");
                writer.WriteLine(@"rmdir / s / q %LocalAppData%\FiveM\FiveM.app\crashes");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\caches.XML");
                writer.WriteLine(@"del / s / q / f %LocalAppData%\FiveM\FiveM.app\adhesive.dll");


            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Fivem Cache has been cleared");
        }

        private void guna2Button18_Click_1(object sender, EventArgs e)
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine(@"powercfg - s 8c5e7fda - e8bf - 4a96 - 9a85 - a6e23a8c635c");
                writer.WriteLine(@"taskkill / f / im GTAVLauncher.exe");
                writer.WriteLine(@"wmic process where name = FiveM_b2189_GTAProcess.exe CALL setpriority 128");
                writer.WriteLine(@"taskkill / f / im wmpnetwk.exe.exe");
                writer.WriteLine(@"taskkill / f / im OneDrive.exe");
                writer.WriteLine(@"taskkill / f / im speedfan.exe");
                writer.WriteLine(@"taskkill / f / im TeamWiever_Service.exe");
                writer.WriteLine(@"taskkill / f / im opera.exe");
                writer.WriteLine(@"taskkill / f / im java.exed");



            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);
            MessageBox.Show("MOONSPOOFER: Windows for fivem has been optimized");
        }

        private void guna2Button19_Click_1(object sender, EventArgs e)
        {
                // enable auto-complete in Run Dialog 
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);

                // show all tray icons
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);

                // disable Remote Assistance
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);

                // disable shaking to minimize
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);

                Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
                Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");

                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DiagTrack", "Start", "4", RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\diagsvc", "Start", "4", RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", "1", RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "GPU Priority", 8, RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Priority", 6, RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Scheduling Category", "High", RegistryValueKind.String);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "SFIO Priority", "High", RegistryValueKind.String);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", "Priority", 8, RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\AutoComplete", true).DeleteValue("Append Completion", false);
            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\AutoComplete", true).DeleteValue("AutoSuggest", false);

            // hide tray icons
            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer", true).DeleteValue("EnableAutoTray", false);

            // enable Remote Assistance
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);

            // enable shaking to minimize
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);

            Registry.ClassesRoot.DeleteSubKeyTree(@"AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", false);
            Registry.ClassesRoot.DeleteSubKeyTree(@"AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", false);

            Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true).DeleteValue("AutoEndTasks", false);
            Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true).DeleteValue("HungAppTimeout", false);
            Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
            Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);

            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");

            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true).DeleteValue("NoResolveSearch", false);
            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true).DeleteValue("NoResolveTrack", false);
            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true).DeleteValue("NoInternetOpenWith", false);

            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DiagTrack", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", "0", RegistryValueKind.DWord);
            //Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSuperHidden", "0", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", true).DeleteValue("GPU Priority", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", true).DeleteValue("Priority", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", true).DeleteValue("Scheduling Category", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", true).DeleteValue("SFIO Priority", false);

            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", true).DeleteValue("GPU Priority", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", true).DeleteValue("Priority", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", true).DeleteValue("Scheduling Category", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", true).DeleteValue("SFIO Priority", false);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\SQMClient\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\AutoLogger\SQMLogger", "Start", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\current\device\System", "AllowExperimentation", 0);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Signature Updates", "ForceUpdateFromMU", 0);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Spynet", "DisableBlockAtFirstSeen", 1);

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows Defender\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows Defender\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
            Registry.ClassesRoot.DeleteSubKeyTree(@"\CLSID\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
            MessageBox.Show("MOONSPOOFER: Windows has been optimized!");

        }

        private void guna2Button20_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/" + textBox1.Text);
        }
    }
}

