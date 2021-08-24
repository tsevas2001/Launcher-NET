using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace LauncherUpadate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\NoaHax Launcher.exe");
                client.DownloadFile("http://141.95.36.183/noahax/NoahaxLauncher.zip", @"NoahaxLauncher.zip");
                string zipPath = @".\NoahaxLauncher.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\NoahaxLauncher.zip");
                Process.Start(@".\NoaHax Launcher.exe");
                this.Close();
            }
            catch
            {
                Process.Start("NoaHax Launcher.exe");
                this.Close();
            }
        }
    }
}
