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

        public void main()
        {
            
        }



        public FormServers()
        {
            InitializeComponent();
        }
        
        
        private async void FormServers_Load(object sender, EventArgs e)
        {
            String url = "http://141.95.36.183/noahax";
            ServerInformation inform = new ServerInformation();
            List<ServerIp> ip = await inform.IpInfo(url);
            //CheckInternetConnection test = new CheckInternetConnection();
            //String testurl = "45.135.201.28";
            //String icon = "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";

            //ping.Text = test.CheckServerPing("google.com") + " ms";


            //fpnlServerList.Controls.Clear();
            //for (int i = 0; i < 10; i++)
            //{
            //    pnlServerLoad.Controls.Add(await AddServerToList(testurl, 30120, "true", "BlackOut", icon, "https://discord.gg/blackoutrp"));
            //    //fpnlServerList.Controls.Add(await AddServerToList(testurl, "BlackOut", icon, "https://discord.gg/blackoutrp"));
            //}
            int rowCount = 0;
            foreach (var info in ip)
            {
                if (rowCount == 1)
                {
                    lblLoading.Visible = false;
                }
                pnlServerLoad.Controls.Add(await AddServerToList(info.ip, info.port, info.InUpdate, info.Name, info.icon, info.discord));
                rowCount = 1;
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
    }
}
