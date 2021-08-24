using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher.NET.Resources.forms
{
    public partial class FormServers
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServers));
        public async Task<Guna.UI2.WinForms.Guna2Panel> AddServerToList(String ip, int port, String InUpdate, String Title, String icon, String Discord)
        {
            
            
            Guna.UI2.WinForms.Guna2Panel pnlServer = new Guna.UI2.WinForms.Guna2Panel();
            ServerInformation information = new ServerInformation();
            double per;

           

            pnlServer.Name = "pnlServer";
            pnlServer.Dock = System.Windows.Forms.DockStyle.Top;
            pnlServer.Location = new System.Drawing.Point(0, 0);
            pnlServer.ShadowDecoration.Parent = pnlServer;
            pnlServer.Size = new System.Drawing.Size(600, 100);
            pnlServer.TabIndex = 1;

            if (await information.PlayerInfo(ip, port) != null)
            {
                
                
                if (information.status == "OFFLINE")
                {
                    Image image = LoadBase64(icon);
                    pnlServer.Controls.Add(tpBar1(0));
                    pnlServer.Controls.Add(status21(information.status, InUpdate));
                    pnlServer.Controls.Add(TotalPlayers1(0, 0));
                    pnlServer.Controls.Add(btnJoin1(information.status, InUpdate, ip, port));
                    pnlServer.Controls.Add(lblServerTitle1(Title));
                    pnlServer.Controls.Add(pbServerImage1(image));
                    pnlServer.Controls.Add(Show_players(ip, port));
                    pnlServer.Controls.Add(DiscordButton(Discord));

                }
                else
                {
                    CheckInternetConnection TakeRespone = new CheckInternetConnection();
                    List<Players> player = await information.PlayerInfo(ip, port);
                    ServerInfo server = await information.SInfo(ip, port);

                    Image image = LoadBase64(icon);
                    per = ((double)player.Count / 128) * 100;
                    pnlServer.Controls.Add(tpBar1((int)per));
                    pnlServer.Controls.Add(status21(information.status, InUpdate));
                    pnlServer.Controls.Add(TotalPlayers1(player.Count, server.vars.sv_maxClients));  
                    pnlServer.Controls.Add(btnJoin1(information.status, InUpdate, ip, port));
                    pnlServer.Controls.Add(lblServerTitle1(Title));
                    pnlServer.Controls.Add(pbServerImage1(image));
                    pnlServer.Controls.Add(Show_players(ip, port));
                    pnlServer.Controls.Add(DiscordButton(Discord));
                    pnlServer.Controls.Add(CurrentMS(TakeRespone.CheckServerPing(ip)));
                    

                }
                
            }
            return pnlServer;
        }

        // The button to join on the server 
        public Guna.UI2.WinForms.Guna2GradientButton btnJoin1(String status, String InUpdate, String ip, int port)
        {
            Guna.UI2.WinForms.Guna2GradientButton button = new Guna.UI2.WinForms.Guna2GradientButton();


            button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            button.Animated = true;
            button.CheckedState.Parent = button;
            button.CustomImages.Parent = button;
            button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            button.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            button.DisabledState.Parent = button;
            if ( InUpdate == "true")
            {
                button.FillColor = System.Drawing.Color.Yellow;
                button.Text = "UPDATING";
            }
            else
            {
                button.FillColor = System.Drawing.Color.Red;
                button.Text = status;
            }
            button.FillColor2 = System.Drawing.Color.Black;
            button.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            button.ForeColor = System.Drawing.Color.White;
            button.HoverState.Parent = button;
            button.Location = new System.Drawing.Point(467, 16);
            button.Name = "btnJoin";
            button.ShadowDecoration.Parent = button;
            button.Size = new System.Drawing.Size(109, 29);
            button.TabIndex = 2;
            button.Click += (sender, e) => button_Click(sender, e, ip, port);

            
            return button;
        }

        private void button_Click(object sender, EventArgs e, String ip, int port)
        {
            Form_Alert frm = new Form_Alert();
            
            Checks check = new Checks();
            if (check.checkWindowsDefender())
                System.Diagnostics.Process.Start($"fivem://connect/cfx.re/join/" + ip + ":" + port);
            else
                frm.showAlert("You cann't play until you enable the \n windows defender!", Form_Alert.enmType.Warning);
        }

        // The progress Bar that show current % of players are currently online 
        public Guna.UI2.WinForms.Guna2ProgressBar tpBar1(int value)
        {
            Guna.UI2.WinForms.Guna2ProgressBar progBar = new Guna.UI2.WinForms.Guna2ProgressBar();

            progBar.BorderRadius = 4;
            progBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            progBar.Location = new System.Drawing.Point(121, 84);
            progBar.ProgressColor = System.Drawing.Color.Maroon;
            progBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            progBar.ShadowDecoration.Parent = progBar;
            progBar.Size = new System.Drawing.Size(476, 16);
            progBar.Value = value;
            progBar.TabIndex = 3;
            progBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

            return progBar;
        }

        // The Red/Green Status server
        public Guna.UI2.WinForms.Guna2Panel status21 (String status, String InUpdate)
        {
            Guna.UI2.WinForms.Guna2Panel Color_Status = new Guna.UI2.WinForms.Guna2Panel();

            if (InUpdate == "true")
                Color_Status.BackColor = System.Drawing.Color.Yellow;
            else if (status == "ONLINE")
                Color_Status.BackColor = System.Drawing.Color.Green;
            else if (status == "OFFLINE")
                Color_Status.BackColor = System.Drawing.Color.Red;
            Color_Status.Dock = System.Windows.Forms.DockStyle.Right;
            Color_Status.Location = new System.Drawing.Point(597, 0);
            Color_Status.Name = "status2";
            Color_Status.ShadowDecoration.Parent = Color_Status;
            Color_Status.Size = new System.Drawing.Size(3, 100);
            Color_Status.TabIndex = 5;

            return Color_Status;
        }
        //Shows the current players online on the server
        public Guna.UI2.WinForms.Guna2HtmlLabel TotalPlayers1 (int current, int max)
        {
            Guna.UI2.WinForms.Guna2HtmlLabel TotalP = new Guna.UI2.WinForms.Guna2HtmlLabel();

            TotalP.AutoSize = true;
            TotalP.BackColor = System.Drawing.Color.Transparent;
            TotalP.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TotalP.ForeColor = System.Drawing.Color.White;
            TotalP.Location = new System.Drawing.Point(161, 26);
            TotalP.Size = new System.Drawing.Size(115, 19);
            TotalP.TabIndex = 4;
            TotalP.Text = "Total Players " + current + " / " + max;
            
            

            return TotalP;
        }
        // This is the button where shows us the players of the server 
        public Guna.UI2.WinForms.Guna2Button Show_players (string ip, int port)
        {
            Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();

            btn.Animated = true;
            btn.AutoRoundedCorners = true;
            btn.BorderRadius = 12;
            btn.CheckedState.Parent = btn;
            btn.CustomImages.Parent = btn;
            btn.DefaultAutoSize = true;
            btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.DisabledState.Parent = btn;
            btn.FillColor = System.Drawing.Color.Maroon;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            btn.ForeColor = System.Drawing.Color.White;
            btn.HoverState.Parent = btn;
            btn.Image = global::Launcher.NET.Properties.Resources.icons8_user_50px;
            btn.Location = new System.Drawing.Point(189, 51);
            btn.Name = "btnPlayerList";
            btn.ShadowDecoration.Parent = btn;
            btn.Size = new System.Drawing.Size(59, 27);
            btn.TabIndex = 6;
            btn.Text = "Show";
            btn.Click += (sender, e) => btn_Click(sender, e, ip, port);

            return btn;
        }
        //This button shows us the player list of the server 
        private async void btn_Click(object sender, EventArgs e, string ip, int port)
        {
            ServerInformation information = new ServerInformation();
            List<Players> player = await information.PlayerInfo(ip, port);
            gPlayers.Rows.Clear();
            gPlayers.Refresh();
            gPlayers.Visible = true;

            foreach (var info in player)
            {

                //item.SubItems.Add(txtName.Text);
                AddToViewList(info.name, info.id.ToString(), info.ping);

            }

        }

        private void AddToViewList(string name, string id, int ms)
        {
            /* 
             ListViewItem Name = new ListViewItem(name);
             ListViewItem.ListViewSubItem ID = new ListViewItem.ListViewSubItem(Name, id);

             Name.SubItems.Add(ID);
             listView1.Items.Add(Name);
            */

            DataGridViewRow row = (DataGridViewRow)gPlayers.Rows[0].Clone();
            row.Cells[0].Value = name;
            row.Cells[1].Value = id;
            row.Cells[2].Value = ms;

            gPlayers.Rows.Add(row);

        }

        //This shows us the Title of the server 
        public Guna.UI2.WinForms.Guna2HtmlLabel lblServerTitle1 (String name)
        {
            Guna.UI2.WinForms.Guna2HtmlLabel Stitle = new Guna.UI2.WinForms.Guna2HtmlLabel();

            Stitle.AutoSize = true;
            Stitle.BackColor = System.Drawing.Color.Transparent;
            Stitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Stitle.ForeColor = System.Drawing.Color.White;
            Stitle.Location = new System.Drawing.Point(130, 3);
            Stitle.Size = new System.Drawing.Size(307, 27);
            Stitle.TabIndex = 1;
            Stitle.Text = name;

            return Stitle;
        }

        public PictureBox pbServerImage1 (Image image)
        {
            PictureBox ServerImage = new PictureBox();

            ServerImage.Dock = System.Windows.Forms.DockStyle.Left;
            ServerImage.Image = image;
            ServerImage.Location = new System.Drawing.Point(0, 0);
            ServerImage.Size = new System.Drawing.Size(121, 100);
            ServerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ServerImage.TabIndex = 0;
            ServerImage.TabStop = false;

            return ServerImage;
        }
        // This convert base64 to image
        public static Image LoadBase64(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }
        // Creating a button where called discord
        public Guna.UI2.WinForms.Guna2GradientButton DiscordButton (String url)
        {
            Guna.UI2.WinForms.Guna2GradientButton btnDisc = new Guna.UI2.WinForms.Guna2GradientButton();

            btnDisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnDisc.Animated = true;
            btnDisc.CheckedState.Parent = btnDisc;
            btnDisc.CustomImages.Parent = btnDisc;
            btnDisc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnDisc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnDisc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnDisc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnDisc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnDisc.DisabledState.Parent = btnDisc;
            btnDisc.FillColor = System.Drawing.Color.Red;
            btnDisc.FillColor2 = System.Drawing.Color.Black;
            btnDisc.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            btnDisc.ForeColor = System.Drawing.Color.White;
            btnDisc.HoverState.Parent = btnDisc;
            btnDisc.Image = global::Launcher.NET.Properties.Resources.icons8_discord_32px;
            btnDisc.Location = new System.Drawing.Point(467, 51);
            btnDisc.Name = "btnDisc";
            btnDisc.ShadowDecoration.Parent = btnDisc;
            btnDisc.Size = new System.Drawing.Size(109, 29);
            btnDisc.TabIndex = 2;
            btnDisc.Text = "DISCORD";
            btnDisc.Click += (sender, e) => btnDisc_Click(sender, e, url);

            return btnDisc;
        }
        // This is Discord button event where it opens the discord url 
        private void btnDisc_Click(object sender, EventArgs e, string url)
        {
            System.Diagnostics.Process.Start(url);

        }
        // This label show us the current ms we have with the server
        public Guna.UI2.WinForms.Guna2HtmlLabel CurrentMS (String ms)
        {
            Guna.UI2.WinForms.Guna2HtmlLabel lblMs = new Guna.UI2.WinForms.Guna2HtmlLabel();
             
            lblMs.AutoSize = true;
            lblMs.BackColor = System.Drawing.Color.Transparent;
            lblMs.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMs.ForeColor = System.Drawing.Color.White;
            lblMs.Location = new System.Drawing.Point(277, 51);
            lblMs.Size = new System.Drawing.Size(60, 22);
            lblMs.TabIndex = 7;
            lblMs.Text = ms + " ms";

            return lblMs;
        }
    }
}
