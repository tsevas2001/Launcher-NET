using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Launcher.NET.Resources.forms
{
public partial class FormServers : Form
    {
        
        static readonly HttpClient client = new HttpClient();

        static void main()
        {
            
        }



        public FormServers()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        

        private async void FormServers_Load(object sender, EventArgs e)
        {
            String url = "http://noahax.xyz/noahax";
            ServerInformation inform = new ServerInformation();
            List<ServerIp> ip = await inform.IpInfo(url);
            List<String> p = new List<string>();


            fpnlServerList.Controls.Clear();
            foreach (var info in ip)
            {
                fpnlServerList.Controls.Add(await AddServerToList(info.ip, info.Name));
                //p.Add(info.server.ip);
            }
            //fpnlServerList.Controls.Clear();
            //for (int i = 0; i < ip.Count; i++)
            //{
            //    fpnlServerList.Controls.Add(await AddServerToList(url));
                //fpnlServerList.Controls.Add(await server.AddServerToList(url));
            //}
            
           /* 
            //String url = "http://141.95.36.183:30120/players.json";
            double per;
            ServerInformation information = new ServerInformation();
            List<Players> player = await information.PlayerInfo(url);


            if (await information.PlayerInfo(url) != null)
            {
                btnJoin.Text = information.status;
                if (information.status == "OFFLINE")
                {
                    status2.BackColor = Color.Red;
                    tpBar.Value = 0;
                }
                else
                {
                    per = ((double)player.Count / 128) * 100;
                    status2.BackColor = Color.Green;
                    tpBar.Value = (int)per;
                }

                foreach (var info in player)
                {
                    
                    //item.SubItems.Add(txtName.Text);
                    AddToViewList(info.name, info.id.ToString(), info.ping);

                }
            }

            
            
            //btnJoin.Text = status;
            TotalPlayers.Text = "Total Players " + player.Count + " / 80";
            */
        }

        

        private void TotalPlayers_Click(object sender, EventArgs e)
        {

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {

        }

        

        private void status2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tpBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
