using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http;
using Launcher.NET.Resources;
using System.Threading;
using Microsoft.Win32;
using System.Diagnostics;
using System.Reflection;
using System.Net;
using Launcher.NET.Resources.forms;

namespace Launcher.NET
{
    public partial class main : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));

        // Fields
        private Form activeForm;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        public main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Thread td = new Thread(new ThreadStart(this.TaskChecks));
            td.IsBackground = true;
            td.Start();

            Process[] pfivem = Process.GetProcessesByName("FiveM");

            if (pfivem.Length != 0)
            {
                foreach (Process worker in pfivem)
                {
                    worker.Kill();
                    worker.WaitForExit();
                    worker.Dispose();
                }
            }
            //pnlNav.Height = btnServers.Height;
            //pnlNav.Top = btnServers.Top;
            //pnlNav.Left = btnServers.Left;
            //btnServers.BackColor = Color.FromArgb(156, 36, 36);

            //OpenChildForm(new Resources.forms.FormServers());
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void TaskChecks()
        {
            CheckInternetConnection InternetC = new CheckInternetConnection();
            Checks check = new Checks();
            int Iconnect = 0;
            int Wdef = 0;
            int Upd = 0;
            

            while(true)
            {

                Process[] pfivem = Process.GetProcessesByName("FiveM");
                Process[] pcmd = Process.GetProcessesByName("cmd");
                if (pcmd.Length != 0)
                {
                    foreach (Process worker in pcmd)
                    {
                        worker.Kill();
                        worker.WaitForExit();
                        worker.Dispose();
                    }
                }
                if (InternetC.IsConnectedToInternet())
                {
                    pctInternetConnection.Image = Properties.Resources.icons8_ok_48px;
                    prgCStatus.Value += 34;
                    Iconnect = 0;
                }
                else
                {
                    pctInternetConnection.Image = Properties.Resources.icons8_cancel_48px;
                    prgCStatus.Value += 34;
                    if (Iconnect == 0)
                    {
                        Iconnect = 1;
                        Invoke(new Action(() =>
                                {
                                    Alert("Promblem with internet \n connection", Form_Alert.enmType.Disconnect);

                                }
                        ));
                    }
                }

                if (check.checkWindowsDefender())
                {
                    pctWindowsDefender.Image = Properties.Resources.icons8_ok_48px;
                    prgCStatus.Value += 34;
                    Wdef = 0;
                }
                else
                {
                    
                    // close the program while windows defender is off
                    if (pfivem.Length != 0)
                    {
                        foreach(Process worker in pfivem)
                        {
                            worker.Kill();
                            worker.WaitForExit();
                            worker.Dispose();
                        }
                    }
                    pctWindowsDefender.Image = Properties.Resources.icons8_cancel_48px;
                    prgCStatus.Value += 34;
                    if (Wdef == 0)
                    {
                        Wdef = 1;
                        Invoke(new Action(() =>
                                {
                                    Alert("You need to enable the \n windows defender", Form_Alert.enmType.Warning);

                                }
                        ));
                    }
                }
                if (check.CheckForUpdatesAsync())
                {
                    pctUpdated.Image = Properties.Resources.icons8_ok_48px;
                    prgCStatus.Value += 34;
                    Upd = 0;
                }
                else
                {
                    pctUpdated.Image = Properties.Resources.icons8_cancel_48px;
                    prgCStatus.Value += 34;
                    if (Upd == 0)
                    {
                        if (pfivem.Length == 0)
                        {
                            Upd = 1;
                            Invoke(new Action(() =>
                            {
                                Alert("The launcher itsn't updated. \n It will update in 5 seconds!", Form_Alert.enmType.NotUpdated);

                            }
                            ));
                            Thread.Sleep(5000);
                            Process.Start("Noahaxa Update.exe");
                        }
                        
                    }
                }

                DisplayStatusText();

                Thread.Sleep(1000);
            }
        }
        int succ = 0;
        int err = 0;
        private void DisplayStatusText()
        {
            CheckInternetConnection InternetC = new CheckInternetConnection();
            Checks check = new Checks();

           
            if (InternetC.IsConnectedToInternet() && check.checkWindowsDefender() && check.CheckForUpdatesAsync())
            {
                // With this way you can have accesse to an other thread to do changes
                Invoke(new Action(() =>
                        {
                            prgButton.Text = "Everything looks fine!";
                            if (succ == 0)
                            {
                                succ = 1;
                                err = 0;
                                Alert("Everything looks good!", Form_Alert.enmType.Success);

                            }
                        }

                    ));
            }
            else
            {
                Invoke(new Action(() =>
                        {
                            prgButton.Text = "Something is wrong!";
                            if (err == 0)
                            {
                                err = 1;
                                succ = 0;
                                Alert("You are not able to play to our \n servers until you fix the errors", Form_Alert.enmType.Error);
                            }
                        }
                ));  
            }
        }


        private void OpenChildForm (Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    

        private void btnExit_Click(object sender, EventArgs e)
        {
            Process[] pfivem = Process.GetProcessesByName("FiveM");

            if (pfivem.Length != 0)
            {
                foreach (Process worker in pfivem)
                {
                    worker.Kill();
                    worker.WaitForExit();
                    worker.Dispose();
                }
            }

            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnUpdate.Height;
            pnlNav.Top = btnUpdate.Top;
            pnlNav.Left = btnUpdate.Left;
            btnUpdate.BackColor = Color.FromArgb(156, 36, 36);
            Title.Text = "UPDATE LOG";

            OpenChildForm(new Resources.forms.Form_UpdateLog(), sender);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAbout.Height;
            pnlNav.Top = btnAbout.Top;
            pnlNav.Left = btnAbout.Left;
            btnAbout.BackColor = Color.FromArgb(156, 36, 36);
            Title.Text = "ABOUT";

            OpenChildForm(new Resources.forms.FormAbout(), sender);
        }

        private void btnServers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnServers.Height;
            pnlNav.Top = btnServers.Top;
            pnlNav.Left = btnServers.Left;
            btnServers.BackColor = Color.FromArgb(156, 36, 36);
            Title.Text = "SERVERS";
            OpenChildForm(new Resources.forms.FormServers(), sender);
        }

        private void btnUpdate_Leave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void btnAbout_Leave(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void btnServers_Leave(object sender, EventArgs e)
        {
            btnServers.BackColor = Color.FromArgb(30, 30, 30);
        }


    }
}
