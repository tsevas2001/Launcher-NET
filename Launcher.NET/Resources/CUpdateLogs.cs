using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.NET.Resources.forms
{
    public partial class Form_UpdateLog
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UpdateLog));
        
        public Guna.UI2.WinForms.Guna2GradientPanel AddUpdateLogToList(String date, List<Change> change)
        {
            Guna.UI2.WinForms.Guna2GradientPanel pnlDayLog = new Guna.UI2.WinForms.Guna2GradientPanel();

            pnlDayLog.AutoSize = true;
            pnlDayLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            pnlDayLog.Controls.Add(pnlLog1(change));
            pnlDayLog.Controls.Add(pnlTitle1(date));
            pnlDayLog.Dock = System.Windows.Forms.DockStyle.Top;
            pnlDayLog.FillColor = System.Drawing.Color.Transparent;
            pnlDayLog.FillColor2 = System.Drawing.Color.Maroon;
            pnlDayLog.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            pnlDayLog.Location = new System.Drawing.Point(0, 0);
            pnlDayLog.Name = "pnlDayLog";
            pnlDayLog.ShadowDecoration.Parent = pnlDayLog;
            pnlDayLog.Size = new System.Drawing.Size(495, 94);
            pnlDayLog.TabIndex = 3;

            return pnlDayLog;
        }

        public Guna.UI2.WinForms.Guna2Panel pnlLog1(List<Change> change)
        {
            Guna.UI2.WinForms.Guna2Panel panelLog = new Guna.UI2.WinForms.Guna2Panel();

            panelLog.AutoSize = true;
            foreach (var info in change)
            {
                panelLog.Controls.Add(pnlShowLog1(info.status, info.log));
            }
            panelLog.Location = new System.Drawing.Point(9, 60);
            panelLog.Name = "pnlLog";
            panelLog.ShadowDecoration.Parent = panelLog;
            panelLog.Size = new System.Drawing.Size(475, 27);
            panelLog.TabIndex = 1;

            return panelLog;
        }

        public Guna.UI2.WinForms.Guna2GradientPanel pnlShowLog1(String status, String log)
        {
            Guna.UI2.WinForms.Guna2GradientPanel panelShowLog = new Guna.UI2.WinForms.Guna2GradientPanel();

            panelShowLog.AutoSize = true;
            panelShowLog.Controls.Add(lblLog1(log));
            panelShowLog.Controls.Add(pctStatusLog1(status));
            panelShowLog.Dock = System.Windows.Forms.DockStyle.Top;
            if (status == "fix")
                panelShowLog.FillColor2 = System.Drawing.Color.Green;
            else if (status == "feature")
                panelShowLog.FillColor2 = System.Drawing.Color.Yellow;
            else if (status == "improvement")
                panelShowLog.FillColor2 = System.Drawing.Color.Aqua;
            else if (status == "issue")
                panelShowLog.FillColor2 = System.Drawing.Color.Red;
            else if (status == "remove")
                panelShowLog.FillColor2 = System.Drawing.Color.Fuchsia;
            panelShowLog.Location = new System.Drawing.Point(0, 0);
            panelShowLog.Name = "pnlShowLog";
            panelShowLog.ShadowDecoration.Parent = panelShowLog;
            panelShowLog.Size = new System.Drawing.Size(475, 31);
            panelShowLog.TabIndex = 1;

            return panelShowLog;
        }

        public Guna.UI2.WinForms.Guna2HtmlLabel lblLog1(String log)
        {
            Guna.UI2.WinForms.Guna2HtmlLabel labelLog = new Guna.UI2.WinForms.Guna2HtmlLabel();

            labelLog.BackColor = System.Drawing.Color.Transparent;
            labelLog.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelLog.ForeColor = System.Drawing.Color.White;
            labelLog.Location = new System.Drawing.Point(48, 5);
            labelLog.MaximumSize = new System.Drawing.Size(400, 1000);
            labelLog.Name = "lblLog";
            labelLog.Size = new System.Drawing.Size(129, 19);
            labelLog.TabIndex = 1;
            labelLog.Text = log;

            return labelLog;
        }

        public Guna.UI2.WinForms.Guna2CirclePictureBox pctStatusLog1(String status)
        {
            Guna.UI2.WinForms.Guna2CirclePictureBox pctStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();

            pctStatus.BackColor = System.Drawing.Color.Transparent;
            pctStatus.Dock = System.Windows.Forms.DockStyle.Left;
            if (status == "fix")
                pctStatus.Image = Properties.Resources.fix_icon;
            else if (status == "feature")
                pctStatus.Image = Properties.Resources.features_icon;
            else if (status == "improvement")
                pctStatus.Image = Properties.Resources.improvements_icon;
            else if (status == "issue")
                pctStatus.Image = Properties.Resources.knownIssues_icon;
            else if (status == "remove")
                pctStatus.Image = Properties.Resources.removed_icon;
            pctStatus.ImageRotate = 0F;
            pctStatus.Location = new System.Drawing.Point(0, 0);
            pctStatus.Name = "pctStatusLog";
            pctStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pctStatus.ShadowDecoration.Parent = pctStatus;
            pctStatus.Size = new System.Drawing.Size(16, 27);
            pctStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pctStatus.TabIndex = 0;
            pctStatus.TabStop = false;
            pctStatus.UseTransparentBackground = true;

            return pctStatus;
        }

        public Guna.UI2.WinForms.Guna2GradientPanel pnlTitle1(String date)
        {
            Guna.UI2.WinForms.Guna2GradientPanel panelTitle = new Guna.UI2.WinForms.Guna2GradientPanel();

            panelTitle.Controls.Add(lblDate1(date));
            panelTitle.Controls.Add(lblTitleLog1());
            panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitle.FillColor2 = System.Drawing.Color.Maroon;
            panelTitle.Location = new System.Drawing.Point(0, 0);
            panelTitle.Name = "pnlTitle";
            panelTitle.ShadowDecoration.Parent = panelTitle;
            panelTitle.Size = new System.Drawing.Size(495, 54);
            panelTitle.TabIndex = 0;

            return panelTitle;
        }

        public Guna.UI2.WinForms.Guna2HtmlLabel lblDate1(String date)
        {
            Guna.UI2.WinForms.Guna2HtmlLabel labelDate = new Guna.UI2.WinForms.Guna2HtmlLabel();

            labelDate.BackColor = System.Drawing.Color.Transparent;
            labelDate.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDate.ForeColor = System.Drawing.Color.White;
            labelDate.Location = new System.Drawing.Point(397, 29);
            labelDate.Name = "lblDate";
            labelDate.Size = new System.Drawing.Size(80, 22);
            labelDate.TabIndex = 1;
            labelDate.Text = date;

            return labelDate;
        }

        public Guna.UI2.WinForms.Guna2HtmlLabel lblTitleLog1()
        {
            Guna.UI2.WinForms.Guna2HtmlLabel labelTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();

            labelTitle.BackColor = System.Drawing.Color.Transparent;
            labelTitle.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTitle.ForeColor = System.Drawing.Color.White;
            labelTitle.Location = new System.Drawing.Point(3, 3);
            labelTitle.Name = "lblTitleLog";
            labelTitle.Size = new System.Drawing.Size(99, 34);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Changes";

            return labelTitle;
        }

    }
}
