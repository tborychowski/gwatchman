namespace GWatchNS
{
    partial class Popup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenu();
            this.trayMenuCheck = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.trayMenuSettings = new System.Windows.Forms.MenuItem();
            this.trayMenuUpdate = new System.Windows.Forms.MenuItem();
            this.trayMenuAbout = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.trayMenuQuit = new System.Windows.Forms.MenuItem();
            this.mailLabel = new System.Windows.Forms.Label();
            this.readerLabel = new System.Windows.Forms.Label();
            this.mailLogo = new System.Windows.Forms.PictureBox();
            this.readerLogo = new System.Windows.Forms.PictureBox();
            this.mailLoader = new System.Windows.Forms.PictureBox();
            this.readerLoader = new System.Windows.Forms.PictureBox();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.hideActionLink = new System.Windows.Forms.LinkLabel();
            this.mailPanel = new System.Windows.Forms.Panel();
            this.readerPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.mailLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerLoader)).BeginInit();
            this.mailPanel.SuspendLayout();
            this.readerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipTitle = "GWatch";
            this.trayIcon.ContextMenu = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.trayMenuCheck,
            this.menuItem7,
            this.trayMenuSettings,
            this.trayMenuUpdate,
            this.trayMenuAbout,
            this.menuItem6,
            this.trayMenuQuit});
            // 
            // trayMenuCheck
            // 
            this.trayMenuCheck.DefaultItem = true;
            this.trayMenuCheck.Index = 0;
            this.trayMenuCheck.Text = "Check Now";
            this.trayMenuCheck.Click += new System.EventHandler(this.trayCheckNow_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "-";
            // 
            // trayMenuSettings
            // 
            this.trayMenuSettings.Index = 2;
            this.trayMenuSettings.Text = "Settings";
            this.trayMenuSettings.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // trayMenuUpdate
            // 
            this.trayMenuUpdate.Index = 3;
            this.trayMenuUpdate.Text = "Update";
            this.trayMenuUpdate.Click += new System.EventHandler(this.trayCheckForUpdates_Click);
            // 
            // trayMenuAbout
            // 
            this.trayMenuAbout.Index = 4;
            this.trayMenuAbout.Text = "About";
            this.trayMenuAbout.Click += new System.EventHandler(this.trayAbout_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            this.menuItem6.Text = "-";
            // 
            // trayMenuQuit
            // 
            this.trayMenuQuit.Index = 6;
            this.trayMenuQuit.Text = "Quit";
            this.trayMenuQuit.Click += new System.EventHandler(this.trayQuit_Click);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.BackColor = System.Drawing.Color.Transparent;
            this.mailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mailLabel.ForeColor = System.Drawing.Color.White;
            this.mailLabel.Location = new System.Drawing.Point(40, 8);
            this.mailLabel.MinimumSize = new System.Drawing.Size(140, 0);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(140, 17);
            this.mailLabel.TabIndex = 0;
            this.mailLabel.Text = "0";
            this.Tooltip.SetToolTip(this.mailLabel, "Click to check for unread messages");
            this.mailLabel.Click += new System.EventHandler(this.gmailLabel_Click);
            // 
            // readerLabel
            // 
            this.readerLabel.AutoSize = true;
            this.readerLabel.BackColor = System.Drawing.Color.Transparent;
            this.readerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.readerLabel.ForeColor = System.Drawing.Color.White;
            this.readerLabel.Location = new System.Drawing.Point(40, 8);
            this.readerLabel.MinimumSize = new System.Drawing.Size(140, 0);
            this.readerLabel.Name = "readerLabel";
            this.readerLabel.Size = new System.Drawing.Size(140, 17);
            this.readerLabel.TabIndex = 0;
            this.readerLabel.Text = "0";
            this.Tooltip.SetToolTip(this.readerLabel, "Click to check for unread feeds");
            this.readerLabel.Click += new System.EventHandler(this.readerLabel_Click);
            // 
            // mailLogo
            // 
            this.mailLogo.BackColor = System.Drawing.Color.Transparent;
            this.mailLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailLogo.Image = global::GWatchNS.Properties.Resources.gmail32;
            this.mailLogo.Location = new System.Drawing.Point(0, 0);
            this.mailLogo.Name = "mailLogo";
            this.mailLogo.Size = new System.Drawing.Size(32, 32);
            this.mailLogo.TabIndex = 6;
            this.mailLogo.TabStop = false;
            this.Tooltip.SetToolTip(this.mailLogo, "Open Google Mail");
            this.mailLogo.Click += new System.EventHandler(this.gmailImg_Click);
            // 
            // readerLogo
            // 
            this.readerLogo.BackColor = System.Drawing.Color.Transparent;
            this.readerLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readerLogo.Image = global::GWatchNS.Properties.Resources.reader32;
            this.readerLogo.Location = new System.Drawing.Point(0, 0);
            this.readerLogo.Name = "readerLogo";
            this.readerLogo.Size = new System.Drawing.Size(32, 32);
            this.readerLogo.TabIndex = 7;
            this.readerLogo.TabStop = false;
            this.Tooltip.SetToolTip(this.readerLogo, "Open Google Reader");
            this.readerLogo.Click += new System.EventHandler(this.readerImg_Click);
            // 
            // mailLoader
            // 
            this.mailLoader.BackColor = System.Drawing.Color.Transparent;
            this.mailLoader.Image = global::GWatchNS.Properties.Resources.loading;
            this.mailLoader.Location = new System.Drawing.Point(40, 8);
            this.mailLoader.Name = "mailLoader";
            this.mailLoader.Size = new System.Drawing.Size(16, 16);
            this.mailLoader.TabIndex = 8;
            this.mailLoader.TabStop = false;
            this.mailLoader.Visible = false;
            // 
            // readerLoader
            // 
            this.readerLoader.BackColor = System.Drawing.Color.Transparent;
            this.readerLoader.Image = global::GWatchNS.Properties.Resources.loading;
            this.readerLoader.Location = new System.Drawing.Point(40, 8);
            this.readerLoader.Name = "readerLoader";
            this.readerLoader.Size = new System.Drawing.Size(16, 16);
            this.readerLoader.TabIndex = 8;
            this.readerLoader.TabStop = false;
            this.readerLoader.Visible = false;
            // 
            // Tooltip
            // 
            this.Tooltip.AutomaticDelay = 200;
            this.Tooltip.BackColor = System.Drawing.SystemColors.Highlight;
            this.Tooltip.ForeColor = System.Drawing.SystemColors.MenuText;
            // 
            // hideActionLink
            // 
            this.hideActionLink.ActiveLinkColor = System.Drawing.Color.White;
            this.hideActionLink.AutoSize = true;
            this.hideActionLink.BackColor = System.Drawing.Color.Transparent;
            this.hideActionLink.DisabledLinkColor = System.Drawing.Color.Gray;
            this.hideActionLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideActionLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hideActionLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.hideActionLink.LinkColor = System.Drawing.Color.Gray;
            this.hideActionLink.Location = new System.Drawing.Point(343, 0);
            this.hideActionLink.Margin = new System.Windows.Forms.Padding(0);
            this.hideActionLink.Name = "hideActionLink";
            this.hideActionLink.Padding = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.hideActionLink.Size = new System.Drawing.Size(30, 18);
            this.hideActionLink.TabIndex = 9;
            this.hideActionLink.TabStop = true;
            this.hideActionLink.Text = "hide";
            this.Tooltip.SetToolTip(this.hideActionLink, "Minimize to system tray");
            this.hideActionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hideActionLink_LinkClicked);
            // 
            // mailPanel
            // 
            this.mailPanel.AutoSize = true;
            this.mailPanel.BackColor = System.Drawing.Color.Transparent;
            this.mailPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mailPanel.Controls.Add(this.mailLogo);
            this.mailPanel.Controls.Add(this.mailLoader);
            this.mailPanel.Controls.Add(this.mailLabel);
            this.mailPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.mailPanel.Location = new System.Drawing.Point(15, 10);
            this.mailPanel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.mailPanel.Name = "mailPanel";
            this.mailPanel.Size = new System.Drawing.Size(183, 35);
            this.mailPanel.TabIndex = 9;
            this.mailPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.mailPanel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.mailPanel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // readerPanel
            // 
            this.readerPanel.AutoSize = true;
            this.readerPanel.BackColor = System.Drawing.Color.Transparent;
            this.readerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.readerPanel.Controls.Add(this.readerLoader);
            this.readerPanel.Controls.Add(this.readerLogo);
            this.readerPanel.Controls.Add(this.readerLabel);
            this.readerPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.readerPanel.Location = new System.Drawing.Point(15, 50);
            this.readerPanel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.readerPanel.Name = "readerPanel";
            this.readerPanel.Size = new System.Drawing.Size(183, 35);
            this.readerPanel.TabIndex = 10;
            this.readerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.readerPanel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.readerPanel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.mailPanel);
            this.flowLayoutPanel1.Controls.Add(this.readerPanel);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(373, 166);
            this.flowLayoutPanel1.TabIndex = 11;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.flowLayoutPanel1.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.flowLayoutPanel1.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(373, 166);
            this.Controls.Add(this.hideActionLink);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GWatchman";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GWatch_FormClosing);
            this.Load += new System.EventHandler(this.GWatch_Load);
            this.ResizeEnd += new System.EventHandler(this.GWatch_ResizeEnd);
            this.Resize += new System.EventHandler(this.GWatch_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.mailLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerLoader)).EndInit();
            this.mailPanel.ResumeLayout(false);
            this.mailPanel.PerformLayout();
            this.readerPanel.ResumeLayout(false);
            this.readerPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label readerLabel;
        private System.Windows.Forms.PictureBox mailLogo;
        private System.Windows.Forms.PictureBox readerLogo;
        private System.Windows.Forms.PictureBox mailLoader;
        private System.Windows.Forms.PictureBox readerLoader;
		private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.Panel mailPanel;
		private System.Windows.Forms.LinkLabel hideActionLink;
		private System.Windows.Forms.Panel readerPanel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.ContextMenu trayMenu;
		private System.Windows.Forms.MenuItem trayMenuCheck;
		private System.Windows.Forms.MenuItem trayMenuSettings;
		private System.Windows.Forms.MenuItem trayMenuUpdate;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem trayMenuAbout;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem trayMenuQuit;
    }
}

