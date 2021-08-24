using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher.NET.Resources.forms
{
    public partial class Form_UpdateLog : Form
    {
        static readonly HttpClient client = new HttpClient();
        public Form_UpdateLog()
        {
            InitializeComponent();
        }

        private async void Form_UpdateLog_Load(object sender, EventArgs e)
        {
            UpdateLogInformation Uinfom = new UpdateLogInformation();
            String Lurl = "http://141.95.36.183/noahax/launcherLog.json";
            String ACurl = "http://141.95.36.183/noahax/ACLog.json";
            List<ULogInformation> LUpdateLogs = await Uinfom.UpdateInfo(Lurl);
            List<ULogInformation> ACUpdateLogs = await Uinfom.UpdateInfo(ACurl);

            foreach (var info in LUpdateLogs)
            {
                pnlAddLogs.Controls.Add(AddUpdateLogToList(info.date, info.changes));
            }

            foreach (var info in ACUpdateLogs)
            {
                pnlACAddLogs.Controls.Add(AddUpdateLogToList(info.date, info.changes));             
            }

            //lblLog.Text = "Added procedural underwater labs Added submarines  Turned the exception from a failed 'connect' console command into a warning.It now shows up in the UI and as a warning in the console, instead of in the UI and as red exception text";
        }
    }
}
