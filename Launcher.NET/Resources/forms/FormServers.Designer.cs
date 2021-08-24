
namespace Launcher.NET.Resources.forms
{
    partial class FormServers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pmlServer1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ping = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPlayerList = new Guna.UI2.WinForms.Guna2Button();
            this.btnDisc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnJoin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tpBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.status2 = new Guna.UI2.WinForms.Guna2Panel();
            this.TotalPlayers = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblServerTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbServerImage = new System.Windows.Forms.PictureBox();
            this.gPlayers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlServerTab = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlServerLoad = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLoading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pmlServer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPlayers)).BeginInit();
            this.pnlServerTab.SuspendLayout();
            this.pnlServerLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // pmlServer1
            // 
            this.pmlServer1.Controls.Add(this.ping);
            this.pmlServer1.Controls.Add(this.btnPlayerList);
            this.pmlServer1.Controls.Add(this.btnDisc);
            this.pmlServer1.Controls.Add(this.btnJoin);
            this.pmlServer1.Controls.Add(this.tpBar);
            this.pmlServer1.Controls.Add(this.status2);
            this.pmlServer1.Controls.Add(this.TotalPlayers);
            this.pmlServer1.Controls.Add(this.lblServerTitle);
            this.pmlServer1.Controls.Add(this.pbServerImage);
            this.pmlServer1.Location = new System.Drawing.Point(724, 598);
            this.pmlServer1.Name = "pmlServer1";
            this.pmlServer1.ShadowDecoration.Parent = this.pmlServer1;
            this.pmlServer1.Size = new System.Drawing.Size(600, 100);
            this.pmlServer1.TabIndex = 1;
            this.pmlServer1.Visible = false;
            // 
            // ping
            // 
            this.ping.BackColor = System.Drawing.Color.Transparent;
            this.ping.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ping.ForeColor = System.Drawing.Color.White;
            this.ping.Location = new System.Drawing.Point(277, 51);
            this.ping.Name = "ping";
            this.ping.Size = new System.Drawing.Size(60, 22);
            this.ping.TabIndex = 7;
            this.ping.Text = "Ping: 60";
            // 
            // btnPlayerList
            // 
            this.btnPlayerList.Animated = true;
            this.btnPlayerList.AutoRoundedCorners = true;
            this.btnPlayerList.BorderRadius = 12;
            this.btnPlayerList.CheckedState.Parent = this.btnPlayerList;
            this.btnPlayerList.CustomImages.Parent = this.btnPlayerList;
            this.btnPlayerList.DefaultAutoSize = true;
            this.btnPlayerList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayerList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayerList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlayerList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlayerList.DisabledState.Parent = this.btnPlayerList;
            this.btnPlayerList.FillColor = System.Drawing.Color.Maroon;
            this.btnPlayerList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlayerList.ForeColor = System.Drawing.Color.White;
            this.btnPlayerList.HoverState.Parent = this.btnPlayerList;
            this.btnPlayerList.Image = global::Launcher.NET.Properties.Resources.icons8_user_50px;
            this.btnPlayerList.Location = new System.Drawing.Point(189, 51);
            this.btnPlayerList.Name = "btnPlayerList";
            this.btnPlayerList.ShadowDecoration.Parent = this.btnPlayerList;
            this.btnPlayerList.Size = new System.Drawing.Size(79, 27);
            this.btnPlayerList.TabIndex = 6;
            this.btnPlayerList.Text = "Show";
            // 
            // btnDisc
            // 
            this.btnDisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisc.Animated = true;
            this.btnDisc.CheckedState.Parent = this.btnDisc;
            this.btnDisc.CustomImages.Parent = this.btnDisc;
            this.btnDisc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisc.DisabledState.Parent = this.btnDisc;
            this.btnDisc.FillColor = System.Drawing.Color.Red;
            this.btnDisc.FillColor2 = System.Drawing.Color.Black;
            this.btnDisc.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDisc.ForeColor = System.Drawing.Color.White;
            this.btnDisc.HoverState.Parent = this.btnDisc;
            this.btnDisc.Image = global::Launcher.NET.Properties.Resources.icons8_discord_32px;
            this.btnDisc.Location = new System.Drawing.Point(467, 51);
            this.btnDisc.Name = "btnDisc";
            this.btnDisc.ShadowDecoration.Parent = this.btnDisc;
            this.btnDisc.Size = new System.Drawing.Size(109, 29);
            this.btnDisc.TabIndex = 2;
            this.btnDisc.Text = "DISCORD";
            // 
            // btnJoin
            // 
            this.btnJoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJoin.Animated = true;
            this.btnJoin.CheckedState.Parent = this.btnJoin;
            this.btnJoin.CustomImages.Parent = this.btnJoin;
            this.btnJoin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJoin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJoin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJoin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJoin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJoin.DisabledState.Parent = this.btnJoin;
            this.btnJoin.FillColor = System.Drawing.Color.Red;
            this.btnJoin.FillColor2 = System.Drawing.Color.Black;
            this.btnJoin.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnJoin.ForeColor = System.Drawing.Color.White;
            this.btnJoin.HoverState.Parent = this.btnJoin;
            this.btnJoin.Location = new System.Drawing.Point(467, 16);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.ShadowDecoration.Parent = this.btnJoin;
            this.btnJoin.Size = new System.Drawing.Size(109, 29);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "OFFLINE";
            // 
            // tpBar
            // 
            this.tpBar.BorderRadius = 4;
            this.tpBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tpBar.Location = new System.Drawing.Point(121, 84);
            this.tpBar.Name = "tpBar";
            this.tpBar.ProgressColor = System.Drawing.Color.Maroon;
            this.tpBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpBar.ShadowDecoration.Parent = this.tpBar;
            this.tpBar.Size = new System.Drawing.Size(476, 16);
            this.tpBar.TabIndex = 3;
            this.tpBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // status2
            // 
            this.status2.BackColor = System.Drawing.Color.Red;
            this.status2.Dock = System.Windows.Forms.DockStyle.Right;
            this.status2.Location = new System.Drawing.Point(597, 0);
            this.status2.Name = "status2";
            this.status2.ShadowDecoration.Parent = this.status2;
            this.status2.Size = new System.Drawing.Size(3, 100);
            this.status2.TabIndex = 5;
            // 
            // TotalPlayers
            // 
            this.TotalPlayers.AvoidGeometryAntialias = true;
            this.TotalPlayers.BackColor = System.Drawing.Color.Transparent;
            this.TotalPlayers.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPlayers.ForeColor = System.Drawing.Color.White;
            this.TotalPlayers.Location = new System.Drawing.Point(161, 26);
            this.TotalPlayers.Name = "TotalPlayers";
            this.TotalPlayers.Size = new System.Drawing.Size(115, 19);
            this.TotalPlayers.TabIndex = 4;
            this.TotalPlayers.Text = "Total Players 0 / 0";
            // 
            // lblServerTitle
            // 
            this.lblServerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblServerTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerTitle.ForeColor = System.Drawing.Color.White;
            this.lblServerTitle.Location = new System.Drawing.Point(130, 3);
            this.lblServerTitle.Name = "lblServerTitle";
            this.lblServerTitle.Size = new System.Drawing.Size(307, 27);
            this.lblServerTitle.TabIndex = 1;
            this.lblServerTitle.Text = "Noahax Dev Team Game Launcher";
            // 
            // pbServerImage
            // 
            this.pbServerImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbServerImage.Image = global::Launcher.NET.Properties.Resources.ndt;
            this.pbServerImage.Location = new System.Drawing.Point(0, 0);
            this.pbServerImage.Name = "pbServerImage";
            this.pbServerImage.Size = new System.Drawing.Size(121, 100);
            this.pbServerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbServerImage.TabIndex = 0;
            this.pbServerImage.TabStop = false;
            // 
            // gPlayers
            // 
            this.gPlayers.AllowUserToDeleteRows = false;
            this.gPlayers.AllowUserToResizeColumns = false;
            this.gPlayers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.gPlayers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gPlayers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gPlayers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gPlayers.ColumnHeadersHeight = 21;
            this.gPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tName,
            this.tID,
            this.tMS});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gPlayers.DefaultCellStyle = dataGridViewCellStyle6;
            this.gPlayers.EnableHeadersVisualStyles = false;
            this.gPlayers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gPlayers.Location = new System.Drawing.Point(717, 21);
            this.gPlayers.Name = "gPlayers";
            this.gPlayers.ReadOnly = true;
            this.gPlayers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gPlayers.RowHeadersVisible = false;
            this.gPlayers.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gPlayers.Size = new System.Drawing.Size(439, 513);
            this.gPlayers.TabIndex = 4;
            this.gPlayers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gPlayers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gPlayers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gPlayers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gPlayers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gPlayers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gPlayers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gPlayers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gPlayers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gPlayers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gPlayers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gPlayers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gPlayers.ThemeStyle.HeaderStyle.Height = 21;
            this.gPlayers.ThemeStyle.ReadOnly = true;
            this.gPlayers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gPlayers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gPlayers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gPlayers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gPlayers.ThemeStyle.RowsStyle.Height = 22;
            this.gPlayers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gPlayers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gPlayers.Visible = false;
            // 
            // tName
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tName.DefaultCellStyle = dataGridViewCellStyle3;
            this.tName.HeaderText = "Name";
            this.tName.Name = "tName";
            this.tName.ReadOnly = true;
            // 
            // tID
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tID.DefaultCellStyle = dataGridViewCellStyle4;
            this.tID.HeaderText = "ID";
            this.tID.Name = "tID";
            this.tID.ReadOnly = true;
            // 
            // tMS
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tMS.DefaultCellStyle = dataGridViewCellStyle5;
            this.tMS.HeaderText = "MS";
            this.tMS.Name = "tMS";
            this.tMS.ReadOnly = true;
            // 
            // pnlServerTab
            // 
            this.pnlServerTab.BackColor = System.Drawing.Color.Transparent;
            this.pnlServerTab.Controls.Add(this.pnlServerLoad);
            this.pnlServerTab.Controls.Add(this.gPlayers);
            this.pnlServerTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlServerTab.Location = new System.Drawing.Point(53, 2);
            this.pnlServerTab.Name = "pnlServerTab";
            this.pnlServerTab.Radius = 30;
            this.pnlServerTab.ShadowColor = System.Drawing.Color.Red;
            this.pnlServerTab.ShadowShift = 20;
            this.pnlServerTab.Size = new System.Drawing.Size(1224, 561);
            this.pnlServerTab.TabIndex = 0;
            // 
            // pnlServerLoad
            // 
            this.pnlServerLoad.AutoScroll = true;
            this.pnlServerLoad.Controls.Add(this.lblLoading);
            this.pnlServerLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlServerLoad.Location = new System.Drawing.Point(68, 21);
            this.pnlServerLoad.Name = "pnlServerLoad";
            this.pnlServerLoad.ShadowDecoration.Parent = this.pnlServerLoad;
            this.pnlServerLoad.Size = new System.Drawing.Size(539, 513);
            this.pnlServerLoad.TabIndex = 5;
            // 
            // lblLoading
            // 
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Maroon;
            this.lblLoading.Location = new System.Drawing.Point(234, 243);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(81, 23);
            this.lblLoading.TabIndex = 0;
            this.lblLoading.Text = "Loading....";
            // 
            // FormServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1424, 710);
            this.Controls.Add(this.pnlServerTab);
            this.Controls.Add(this.pmlServer1);
            this.Name = "FormServers";
            this.Text = "FormServers";
            this.Load += new System.EventHandler(this.FormServers_Load);
            this.pmlServer1.ResumeLayout(false);
            this.pmlServer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPlayers)).EndInit();
            this.pnlServerTab.ResumeLayout(false);
            this.pnlServerLoad.ResumeLayout(false);
            this.pnlServerLoad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pmlServer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel TotalPlayers;
        private Guna.UI2.WinForms.Guna2ProgressBar tpBar;
        private Guna.UI2.WinForms.Guna2GradientButton btnJoin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblServerTitle;
        private System.Windows.Forms.PictureBox pbServerImage;
        private Guna.UI2.WinForms.Guna2Panel status2;
        private Guna.UI2.WinForms.Guna2DataGridView gPlayers;
        private Guna.UI2.WinForms.Guna2Button btnPlayerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn tName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMS;
        private Guna.UI2.WinForms.Guna2HtmlLabel ping;
        private Guna.UI2.WinForms.Guna2GradientButton btnDisc;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlServerTab;
        private Guna.UI2.WinForms.Guna2Panel pnlServerLoad;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoading;
    }
}