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

namespace Launcher.NET
{
    public partial class main : Form
    {
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
            //pnlNav.Height = btnServers.Height;
            //pnlNav.Top = btnServers.Top;
            //pnlNav.Left = btnServers.Left;
            //btnServers.BackColor = Color.FromArgb(156, 36, 36);
           
            //OpenChildForm(new Resources.forms.FormServers());
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

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
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnUpdate.Height;
            pnlNav.Top = btnUpdate.Top;
            pnlNav.Left = btnUpdate.Left;
            btnUpdate.BackColor = Color.FromArgb(156, 36, 36);

        
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAbout.Height;
            pnlNav.Top = btnAbout.Top;
            pnlNav.Left = btnAbout.Left;
            btnAbout.BackColor = Color.FromArgb(156, 36, 36);
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
