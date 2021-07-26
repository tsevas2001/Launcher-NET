
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
            this.panelServerList = new Guna.UI2.WinForms.Guna2Panel();
            this.pmlServer1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ping = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPlayerList = new Guna.UI2.WinForms.Guna2Button();
            this.tpBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.status2 = new Guna.UI2.WinForms.Guna2Panel();
            this.TotalPlayers = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnJoin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblServerTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbServerImage = new System.Windows.Forms.PictureBox();
            this.ScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.fpnlServerList = new System.Windows.Forms.FlowLayoutPanel();
            this.gPlayers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelServerList.SuspendLayout();
            this.pmlServer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelServerList
            // 
            this.panelServerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelServerList.Controls.Add(this.pmlServer1);
            this.panelServerList.Controls.Add(this.ScrollBar);
            this.panelServerList.Location = new System.Drawing.Point(83, 38);
            this.panelServerList.Name = "panelServerList";
            this.panelServerList.ShadowDecoration.Parent = this.panelServerList;
            this.panelServerList.Size = new System.Drawing.Size(618, 318);
            this.panelServerList.TabIndex = 1;
            // 
            // pmlServer1
            // 
            this.pmlServer1.Controls.Add(this.ping);
            this.pmlServer1.Controls.Add(this.btnPlayerList);
            this.pmlServer1.Controls.Add(this.tpBar);
            this.pmlServer1.Controls.Add(this.status2);
            this.pmlServer1.Controls.Add(this.TotalPlayers);
            this.pmlServer1.Controls.Add(this.btnJoin);
            this.pmlServer1.Controls.Add(this.lblServerTitle);
            this.pmlServer1.Controls.Add(this.pbServerImage);
            this.pmlServer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pmlServer1.Location = new System.Drawing.Point(0, 0);
            this.pmlServer1.Name = "pmlServer1";
            this.pmlServer1.ShadowDecoration.Parent = this.pmlServer1;
            this.pmlServer1.Size = new System.Drawing.Size(600, 100);
            this.pmlServer1.TabIndex = 1;
            // 
            // ping
            // 
            this.ping.BackColor = System.Drawing.Color.Transparent;
            this.ping.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ping.ForeColor = System.Drawing.Color.White;
            this.ping.Location = new System.Drawing.Point(343, 51);
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
            this.btnPlayerList.Location = new System.Drawing.Point(189, 51);
            this.btnPlayerList.Name = "btnPlayerList";
            this.btnPlayerList.ShadowDecoration.Parent = this.btnPlayerList;
            this.btnPlayerList.Size = new System.Drawing.Size(59, 27);
            this.btnPlayerList.TabIndex = 6;
            this.btnPlayerList.Text = "Show";
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
            this.tpBar.ValueChanged += new System.EventHandler(this.tpBar_ValueChanged);
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
            this.status2.Paint += new System.Windows.Forms.PaintEventHandler(this.status2_Paint);
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
            this.TotalPlayers.Click += new System.EventHandler(this.TotalPlayers_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJoin.Animated = true;
            this.btnJoin.BorderRadius = 20;
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
            this.btnJoin.Location = new System.Drawing.Point(464, 32);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.ShadowDecoration.Parent = this.btnJoin;
            this.btnJoin.Size = new System.Drawing.Size(109, 37);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "OFFLINE";
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
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
            // ScrollBar
            // 
            this.ScrollBar.AutoRoundedCorners = true;
            this.ScrollBar.BindingContainer = this.panelServerList;
            this.ScrollBar.BorderRadius = 8;
            this.ScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScrollBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScrollBar.HoverState.Parent = null;
            this.ScrollBar.InUpdate = false;
            this.ScrollBar.LargeChange = 10;
            this.ScrollBar.Location = new System.Drawing.Point(600, 0);
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.PressedState.Parent = this.ScrollBar;
            this.ScrollBar.ScrollbarSize = 18;
            this.ScrollBar.Size = new System.Drawing.Size(18, 318);
            this.ScrollBar.TabIndex = 0;
            this.ScrollBar.ThumbColor = System.Drawing.Color.Maroon;
            // 
            // fpnlServerList
            // 
            this.fpnlServerList.AutoScroll = true;
            this.fpnlServerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fpnlServerList.Location = new System.Drawing.Point(83, 362);
            this.fpnlServerList.Name = "fpnlServerList";
            this.fpnlServerList.Size = new System.Drawing.Size(610, 229);
            this.fpnlServerList.TabIndex = 3;
            // 
            // gPlayers
            // 
            this.gPlayers.AllowUserToDeleteRows = false;
            this.gPlayers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gPlayers.DefaultCellStyle = dataGridViewCellStyle6;
            this.gPlayers.EnableHeadersVisualStyles = false;
            this.gPlayers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gPlayers.Location = new System.Drawing.Point(830, 38);
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
            this.gPlayers.Size = new System.Drawing.Size(439, 531);
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
            this.gPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
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
            // FormServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1424, 710);
            this.Controls.Add(this.gPlayers);
            this.Controls.Add(this.fpnlServerList);
            this.Controls.Add(this.panelServerList);
            this.Name = "FormServers";
            this.Text = "FormServers";
            this.Load += new System.EventHandler(this.FormServers_Load);
            this.panelServerList.ResumeLayout(false);
            this.pmlServer1.ResumeLayout(false);
            this.pmlServer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelServerList;
        private Guna.UI2.WinForms.Guna2VScrollBar ScrollBar;
        private Guna.UI2.WinForms.Guna2Panel pmlServer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel TotalPlayers;
        private Guna.UI2.WinForms.Guna2ProgressBar tpBar;
        private Guna.UI2.WinForms.Guna2GradientButton btnJoin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblServerTitle;
        private System.Windows.Forms.PictureBox pbServerImage;
        private Guna.UI2.WinForms.Guna2Panel status2;
        private System.Windows.Forms.FlowLayoutPanel fpnlServerList;
        private Guna.UI2.WinForms.Guna2DataGridView gPlayers;
        private Guna.UI2.WinForms.Guna2Button btnPlayerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn tName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMS;
        private Guna.UI2.WinForms.Guna2HtmlLabel ping;
    }
}