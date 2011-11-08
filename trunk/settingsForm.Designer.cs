namespace GWatchNS
{
    partial class settingsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Account");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Alert");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("About");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.settingsTree = new System.Windows.Forms.TreeView();
            this.settingsPanelAlert = new System.Windows.Forms.Panel();
            this.settingsAlertLabel = new System.Windows.Forms.Label();
            this.nativePopupSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.settingsAlertDismissDelay = new System.Windows.Forms.NumericUpDown();
            this.settingsDismissDelayLabel = new System.Windows.Forms.Label();
            this.settingsAlertColor = new System.Windows.Forms.TextBox();
            this.settingsTextColorLabel = new System.Windows.Forms.Label();
            this.settingsAlertImage = new System.Windows.Forms.ComboBox();
            this.settingsBackgroundLabel = new System.Windows.Forms.Label();
            this.settingsAlertOpacityBox = new System.Windows.Forms.NumericUpDown();
            this.settingsOpacityLabel = new System.Windows.Forms.Label();
            this.settingsAlertHorizontalCombo = new System.Windows.Forms.ComboBox();
            this.settingsAlertVerticalCombo = new System.Windows.Forms.ComboBox();
            this.settingsPositionLabel = new System.Windows.Forms.Label();
            this.actionGroupBox = new System.Windows.Forms.GroupBox();
            this.settingsAlertActionPopupChBox = new System.Windows.Forms.CheckBox();
            this.settingsAlertActionGrowlChBox = new System.Windows.Forms.CheckBox();
            this.settingsPanelGeneral = new System.Windows.Forms.Panel();
            this.settingsUpdateOnStartCheckbox = new System.Windows.Forms.CheckBox();
            this.settingsGetLanguagesLink = new System.Windows.Forms.LinkLabel();
            this.settingsLangCombo = new System.Windows.Forms.ComboBox();
            this.settingsLanguageLabel = new System.Windows.Forms.Label();
            this.settingsGeneralLabel = new System.Windows.Forms.Label();
            this.settingsAutoStartCheckbox = new System.Windows.Forms.CheckBox();
            this.settingsPanelAbout = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.settingsAboutText = new System.Windows.Forms.Label();
            this.settingsAboutLabel = new System.Windows.Forms.Label();
            this.settingsPanelAccounts = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.settingsReaderToggler = new System.Windows.Forms.CheckBox();
            this.settingsReaderFreqLabel = new System.Windows.Forms.Label();
            this.settingsReaderFreqBar = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingsMailToggler = new System.Windows.Forms.CheckBox();
            this.settingsMailFreqLabel = new System.Windows.Forms.Label();
            this.settingsMailFreqBar = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settingsAccountLabel = new System.Windows.Forms.Label();
            this.settingsPassSaveChbox = new System.Windows.Forms.CheckBox();
            this.settingsUsernameSaveChbox = new System.Windows.Forms.CheckBox();
            this.settingsPassTextBox = new System.Windows.Forms.TextBox();
            this.settingsUsernameTextBox = new System.Windows.Forms.TextBox();
            this.settingsPasswordLabel = new System.Windows.Forms.Label();
            this.settingsUsernameLabel = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.settingsCancelButton = new System.Windows.Forms.Button();
            this.settingsApplyButton = new System.Windows.Forms.Button();
            this.settingsToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.settingsPanelAlert.SuspendLayout();
            this.nativePopupSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsAlertDismissDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsAlertOpacityBox)).BeginInit();
            this.actionGroupBox.SuspendLayout();
            this.settingsPanelGeneral.SuspendLayout();
            this.settingsPanelAbout.SuspendLayout();
            this.settingsPanelAccounts.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsReaderFreqBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsMailFreqBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Gray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.settingsTree);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Panel1MinSize = 110;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.settingsPanelAccounts);
            this.splitContainer1.Panel2.Controls.Add(this.settingsPanelAlert);
            this.splitContainer1.Panel2.Controls.Add(this.settingsPanelGeneral);
            this.splitContainer1.Panel2.Controls.Add(this.settingsPanelAbout);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(576, 355);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // settingsTree
            // 
            this.settingsTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.settingsTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsTree.FullRowSelect = true;
            this.settingsTree.HideSelection = false;
            this.settingsTree.Indent = 20;
            this.settingsTree.ItemHeight = 22;
            this.settingsTree.Location = new System.Drawing.Point(5, 5);
            this.settingsTree.Margin = new System.Windows.Forms.Padding(0);
            this.settingsTree.Name = "settingsTree";
            treeNode1.Name = "settingsTreeNodeAccounts";
            treeNode1.Text = "Account";
            treeNode2.Name = "settingsTreeNodeAlert";
            treeNode2.Text = "Alert";
            treeNode3.Name = "settingsTreeNodeGeneral";
            treeNode3.Text = "General";
            treeNode4.Name = "settingsTreeNodeAbout";
            treeNode4.Text = "About";
            this.settingsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.settingsTree.ShowLines = false;
            this.settingsTree.ShowPlusMinus = false;
            this.settingsTree.ShowRootLines = false;
            this.settingsTree.Size = new System.Drawing.Size(100, 345);
            this.settingsTree.TabIndex = 1;
            this.settingsTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // settingsPanelAlert
            // 
            this.settingsPanelAlert.AutoScroll = true;
            this.settingsPanelAlert.AutoScrollMinSize = new System.Drawing.Size(463, 0);
            this.settingsPanelAlert.BackColor = System.Drawing.SystemColors.Control;
            this.settingsPanelAlert.Controls.Add(this.settingsAlertLabel);
            this.settingsPanelAlert.Controls.Add(this.nativePopupSettingsGroupBox);
            this.settingsPanelAlert.Controls.Add(this.actionGroupBox);
            this.settingsPanelAlert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanelAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsPanelAlert.Location = new System.Drawing.Point(0, 0);
            this.settingsPanelAlert.Margin = new System.Windows.Forms.Padding(0);
            this.settingsPanelAlert.Name = "settingsPanelAlert";
            this.settingsPanelAlert.Size = new System.Drawing.Size(465, 355);
            this.settingsPanelAlert.TabIndex = 9;
            this.settingsPanelAlert.Visible = false;
            // 
            // settingsAlertLabel
            // 
            this.settingsAlertLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.settingsAlertLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsAlertLabel.Name = "settingsAlertLabel";
            this.settingsAlertLabel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 5);
            this.settingsAlertLabel.Size = new System.Drawing.Size(465, 35);
            this.settingsAlertLabel.TabIndex = 2;
            this.settingsAlertLabel.Text = "Alert";
            this.settingsAlertLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.settingsAlertLabel_Paint);
            // 
            // nativePopupSettingsGroupBox
            // 
            this.nativePopupSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nativePopupSettingsGroupBox.Controls.Add(this.label14);
            this.nativePopupSettingsGroupBox.Controls.Add(this.settingsAlertDismissDelay);
            this.nativePopupSettingsGroupBox.Controls.Add(this.settingsDismissDelayLabel);
            this.nativePopupSettingsGroupBox.Controls.Add(this.settingsAlertColor);
            this.nativePopupSettingsGroupBox.Controls.Add(this.settingsTextColorLabel);
            this.nativePopupSettingsGroupBox.Controls.Add(this.settingsAlertImage);
            this.nativePopupSettingsGroupBox.Controls.Add(this.settingsBackgroundLabel);
            this.nativePopupSettingsGroupBox.Controls.Add(this.settingsAlertOpacityBox);
            this.nativePopupSettingsGroupBox.Controls.Add(this.settingsOpacityLabel);
            this.nativePopupSettingsGroupBox.Controls.Add(this.settingsAlertHorizontalCombo);
            this.nativePopupSettingsGroupBox.Controls.Add(this.settingsAlertVerticalCombo);
            this.nativePopupSettingsGroupBox.Controls.Add(this.settingsPositionLabel);
            this.nativePopupSettingsGroupBox.Location = new System.Drawing.Point(10, 145);
            this.nativePopupSettingsGroupBox.MinimumSize = new System.Drawing.Size(435, 0);
            this.nativePopupSettingsGroupBox.Name = "nativePopupSettingsGroupBox";
            this.nativePopupSettingsGroupBox.Size = new System.Drawing.Size(443, 184);
            this.nativePopupSettingsGroupBox.TabIndex = 3;
            this.nativePopupSettingsGroupBox.TabStop = false;
            this.nativePopupSettingsGroupBox.Text = "Native pop-up settings";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "ms";
            // 
            // settingsAlertDismissDelay
            // 
            this.settingsAlertDismissDelay.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.settingsAlertDismissDelay.Location = new System.Drawing.Point(150, 145);
            this.settingsAlertDismissDelay.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.settingsAlertDismissDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.settingsAlertDismissDelay.Name = "settingsAlertDismissDelay";
            this.settingsAlertDismissDelay.Size = new System.Drawing.Size(73, 23);
            this.settingsAlertDismissDelay.TabIndex = 18;
            this.settingsAlertDismissDelay.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // settingsDismissDelayLabel
            // 
            this.settingsDismissDelayLabel.AutoSize = true;
            this.settingsDismissDelayLabel.Location = new System.Drawing.Point(12, 147);
            this.settingsDismissDelayLabel.Name = "settingsDismissDelayLabel";
            this.settingsDismissDelayLabel.Size = new System.Drawing.Size(94, 17);
            this.settingsDismissDelayLabel.TabIndex = 17;
            this.settingsDismissDelayLabel.Text = "Dismiss delay";
            // 
            // settingsAlertColor
            // 
            this.settingsAlertColor.Location = new System.Drawing.Point(150, 85);
            this.settingsAlertColor.Name = "settingsAlertColor";
            this.settingsAlertColor.Size = new System.Drawing.Size(73, 23);
            this.settingsAlertColor.TabIndex = 15;
            this.settingsAlertColor.Text = "#fff";
            this.settingsToolTip.SetToolTip(this.settingsAlertColor, "html hex color as hex or name, i.e.:\r\n#fff, white, #000000");
            // 
            // settingsTextColorLabel
            // 
            this.settingsTextColorLabel.AutoSize = true;
            this.settingsTextColorLabel.Location = new System.Drawing.Point(12, 87);
            this.settingsTextColorLabel.Name = "settingsTextColorLabel";
            this.settingsTextColorLabel.Size = new System.Drawing.Size(70, 17);
            this.settingsTextColorLabel.TabIndex = 14;
            this.settingsTextColorLabel.Text = "Text color";
            // 
            // settingsAlertImage
            // 
            this.settingsAlertImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsAlertImage.FormattingEnabled = true;
            this.settingsAlertImage.Location = new System.Drawing.Point(150, 54);
            this.settingsAlertImage.Name = "settingsAlertImage";
            this.settingsAlertImage.Size = new System.Drawing.Size(232, 24);
            this.settingsAlertImage.TabIndex = 13;
            this.settingsToolTip.SetToolTip(this.settingsAlertImage, "Display a list of images (png,bmp,jpg,gif) \r\nfrom the \"background\" folder");
            // 
            // settingsBackgroundLabel
            // 
            this.settingsBackgroundLabel.AutoSize = true;
            this.settingsBackgroundLabel.Location = new System.Drawing.Point(12, 57);
            this.settingsBackgroundLabel.Name = "settingsBackgroundLabel";
            this.settingsBackgroundLabel.Size = new System.Drawing.Size(84, 17);
            this.settingsBackgroundLabel.TabIndex = 12;
            this.settingsBackgroundLabel.Text = "Background";
            // 
            // settingsAlertOpacityBox
            // 
            this.settingsAlertOpacityBox.Location = new System.Drawing.Point(150, 115);
            this.settingsAlertOpacityBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.settingsAlertOpacityBox.Name = "settingsAlertOpacityBox";
            this.settingsAlertOpacityBox.Size = new System.Drawing.Size(73, 23);
            this.settingsAlertOpacityBox.TabIndex = 11;
            this.settingsAlertOpacityBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // settingsOpacityLabel
            // 
            this.settingsOpacityLabel.AutoSize = true;
            this.settingsOpacityLabel.Location = new System.Drawing.Point(12, 117);
            this.settingsOpacityLabel.Name = "settingsOpacityLabel";
            this.settingsOpacityLabel.Size = new System.Drawing.Size(56, 17);
            this.settingsOpacityLabel.TabIndex = 10;
            this.settingsOpacityLabel.Text = "Opacity";
            // 
            // settingsAlertHorizontalCombo
            // 
            this.settingsAlertHorizontalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsAlertHorizontalCombo.FormattingEnabled = true;
            this.settingsAlertHorizontalCombo.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right",
            "Custom"});
            this.settingsAlertHorizontalCombo.Location = new System.Drawing.Point(272, 23);
            this.settingsAlertHorizontalCombo.Name = "settingsAlertHorizontalCombo";
            this.settingsAlertHorizontalCombo.Size = new System.Drawing.Size(110, 24);
            this.settingsAlertHorizontalCombo.TabIndex = 9;
            // 
            // settingsAlertVerticalCombo
            // 
            this.settingsAlertVerticalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsAlertVerticalCombo.FormattingEnabled = true;
            this.settingsAlertVerticalCombo.Items.AddRange(new object[] {
            "Top",
            "Middle",
            "Bottom",
            "Custom"});
            this.settingsAlertVerticalCombo.Location = new System.Drawing.Point(150, 23);
            this.settingsAlertVerticalCombo.Name = "settingsAlertVerticalCombo";
            this.settingsAlertVerticalCombo.Size = new System.Drawing.Size(110, 24);
            this.settingsAlertVerticalCombo.TabIndex = 7;
            // 
            // settingsPositionLabel
            // 
            this.settingsPositionLabel.AutoSize = true;
            this.settingsPositionLabel.Location = new System.Drawing.Point(12, 27);
            this.settingsPositionLabel.Name = "settingsPositionLabel";
            this.settingsPositionLabel.Size = new System.Drawing.Size(58, 17);
            this.settingsPositionLabel.TabIndex = 6;
            this.settingsPositionLabel.Text = "Position";
            // 
            // actionGroupBox
            // 
            this.actionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionGroupBox.Controls.Add(this.settingsAlertActionPopupChBox);
            this.actionGroupBox.Controls.Add(this.settingsAlertActionGrowlChBox);
            this.actionGroupBox.Location = new System.Drawing.Point(10, 44);
            this.actionGroupBox.MinimumSize = new System.Drawing.Size(435, 0);
            this.actionGroupBox.Name = "actionGroupBox";
            this.actionGroupBox.Size = new System.Drawing.Size(443, 87);
            this.actionGroupBox.TabIndex = 4;
            this.actionGroupBox.TabStop = false;
            this.actionGroupBox.Text = "Action";
            // 
            // settingsAlertActionPopupChBox
            // 
            this.settingsAlertActionPopupChBox.AutoSize = true;
            this.settingsAlertActionPopupChBox.Location = new System.Drawing.Point(12, 27);
            this.settingsAlertActionPopupChBox.Name = "settingsAlertActionPopupChBox";
            this.settingsAlertActionPopupChBox.Size = new System.Drawing.Size(116, 21);
            this.settingsAlertActionPopupChBox.TabIndex = 6;
            this.settingsAlertActionPopupChBox.Text = "Native pop-up";
            this.settingsAlertActionPopupChBox.UseVisualStyleBackColor = true;
            // 
            // settingsAlertActionGrowlChBox
            // 
            this.settingsAlertActionGrowlChBox.AutoSize = true;
            this.settingsAlertActionGrowlChBox.Location = new System.Drawing.Point(12, 56);
            this.settingsAlertActionGrowlChBox.Name = "settingsAlertActionGrowlChBox";
            this.settingsAlertActionGrowlChBox.Size = new System.Drawing.Size(63, 21);
            this.settingsAlertActionGrowlChBox.TabIndex = 0;
            this.settingsAlertActionGrowlChBox.Text = "Growl";
            this.settingsAlertActionGrowlChBox.UseVisualStyleBackColor = true;
            // 
            // settingsPanelGeneral
            // 
            this.settingsPanelGeneral.AutoScroll = true;
            this.settingsPanelGeneral.AutoScrollMinSize = new System.Drawing.Size(463, 0);
            this.settingsPanelGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.settingsPanelGeneral.Controls.Add(this.settingsUpdateOnStartCheckbox);
            this.settingsPanelGeneral.Controls.Add(this.settingsGetLanguagesLink);
            this.settingsPanelGeneral.Controls.Add(this.settingsLangCombo);
            this.settingsPanelGeneral.Controls.Add(this.settingsLanguageLabel);
            this.settingsPanelGeneral.Controls.Add(this.settingsGeneralLabel);
            this.settingsPanelGeneral.Controls.Add(this.settingsAutoStartCheckbox);
            this.settingsPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanelGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsPanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.settingsPanelGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.settingsPanelGeneral.Name = "settingsPanelGeneral";
            this.settingsPanelGeneral.Size = new System.Drawing.Size(465, 355);
            this.settingsPanelGeneral.TabIndex = 7;
            this.settingsPanelGeneral.Visible = false;
            // 
            // settingsUpdateOnStartCheckbox
            // 
            this.settingsUpdateOnStartCheckbox.AutoSize = true;
            this.settingsUpdateOnStartCheckbox.Location = new System.Drawing.Point(14, 95);
            this.settingsUpdateOnStartCheckbox.Name = "settingsUpdateOnStartCheckbox";
            this.settingsUpdateOnStartCheckbox.Size = new System.Drawing.Size(194, 21);
            this.settingsUpdateOnStartCheckbox.TabIndex = 6;
            this.settingsUpdateOnStartCheckbox.Text = "Check for updates on start";
            this.settingsUpdateOnStartCheckbox.UseVisualStyleBackColor = true;
            // 
            // settingsGetLanguagesLink
            // 
            this.settingsGetLanguagesLink.AutoSize = true;
            this.settingsGetLanguagesLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.settingsGetLanguagesLink.Location = new System.Drawing.Point(262, 57);
            this.settingsGetLanguagesLink.Name = "settingsGetLanguagesLink";
            this.settingsGetLanguagesLink.Size = new System.Drawing.Size(137, 17);
            this.settingsGetLanguagesLink.TabIndex = 5;
            this.settingsGetLanguagesLink.TabStop = true;
            this.settingsGetLanguagesLink.Text = "Get more languages";
            this.settingsGetLanguagesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.settingsGetLanguagesLink_LinkClicked);
            // 
            // settingsLangCombo
            // 
            this.settingsLangCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsLangCombo.FormattingEnabled = true;
            this.settingsLangCombo.Items.AddRange(new object[] {
            "English"});
            this.settingsLangCombo.Location = new System.Drawing.Point(115, 53);
            this.settingsLangCombo.Name = "settingsLangCombo";
            this.settingsLangCombo.Size = new System.Drawing.Size(140, 24);
            this.settingsLangCombo.TabIndex = 4;
            // 
            // settingsLanguageLabel
            // 
            this.settingsLanguageLabel.AutoSize = true;
            this.settingsLanguageLabel.Location = new System.Drawing.Point(11, 57);
            this.settingsLanguageLabel.Name = "settingsLanguageLabel";
            this.settingsLanguageLabel.Size = new System.Drawing.Size(72, 17);
            this.settingsLanguageLabel.TabIndex = 3;
            this.settingsLanguageLabel.Text = "Language";
            // 
            // settingsGeneralLabel
            // 
            this.settingsGeneralLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsGeneralLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.settingsGeneralLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsGeneralLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.settingsGeneralLabel.Name = "settingsGeneralLabel";
            this.settingsGeneralLabel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 5);
            this.settingsGeneralLabel.Size = new System.Drawing.Size(465, 35);
            this.settingsGeneralLabel.TabIndex = 1;
            this.settingsGeneralLabel.Text = "General";
            this.settingsGeneralLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.settingsGeneralLabel_Paint);
            // 
            // settingsAutoStartCheckbox
            // 
            this.settingsAutoStartCheckbox.AutoSize = true;
            this.settingsAutoStartCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsAutoStartCheckbox.Location = new System.Drawing.Point(14, 132);
            this.settingsAutoStartCheckbox.Name = "settingsAutoStartCheckbox";
            this.settingsAutoStartCheckbox.Size = new System.Drawing.Size(133, 21);
            this.settingsAutoStartCheckbox.TabIndex = 0;
            this.settingsAutoStartCheckbox.Text = "Start with system";
            this.settingsToolTip.SetToolTip(this.settingsAutoStartCheckbox, "Add this app to the system start-up list");
            this.settingsAutoStartCheckbox.UseVisualStyleBackColor = true;
            // 
            // settingsPanelAbout
            // 
            this.settingsPanelAbout.AutoScroll = true;
            this.settingsPanelAbout.AutoScrollMinSize = new System.Drawing.Size(463, 0);
            this.settingsPanelAbout.BackColor = System.Drawing.SystemColors.Control;
            this.settingsPanelAbout.Controls.Add(this.linkLabel1);
            this.settingsPanelAbout.Controls.Add(this.settingsAboutText);
            this.settingsPanelAbout.Controls.Add(this.settingsAboutLabel);
            this.settingsPanelAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsPanelAbout.Location = new System.Drawing.Point(0, 0);
            this.settingsPanelAbout.Margin = new System.Windows.Forms.Padding(0);
            this.settingsPanelAbout.Name = "settingsPanelAbout";
            this.settingsPanelAbout.Size = new System.Drawing.Size(465, 355);
            this.settingsPanelAbout.TabIndex = 10;
            this.settingsPanelAbout.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(0, 144);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.linkLabel1.Size = new System.Drawing.Size(207, 37);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "gwatchman.googlecode.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // settingsAboutText
            // 
            this.settingsAboutText.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsAboutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsAboutText.Location = new System.Drawing.Point(0, 35);
            this.settingsAboutText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.settingsAboutText.Name = "settingsAboutText";
            this.settingsAboutText.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.settingsAboutText.Size = new System.Drawing.Size(465, 109);
            this.settingsAboutText.TabIndex = 0;
            this.settingsAboutText.Text = "GWatchman is a freeware app created to kill time and to make a few things easier " +
    "and quicker.\r\n\r\nIf you need more details visit the project\'s website:";
            // 
            // settingsAboutLabel
            // 
            this.settingsAboutLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsAboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.settingsAboutLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsAboutLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.settingsAboutLabel.Name = "settingsAboutLabel";
            this.settingsAboutLabel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 5);
            this.settingsAboutLabel.Size = new System.Drawing.Size(465, 35);
            this.settingsAboutLabel.TabIndex = 6;
            this.settingsAboutLabel.Text = "About GWatchman";
            this.settingsAboutLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.settingsAboutLabel_Paint);
            // 
            // settingsPanelAccounts
            // 
            this.settingsPanelAccounts.AutoScroll = true;
            this.settingsPanelAccounts.AutoScrollMinSize = new System.Drawing.Size(463, 0);
            this.settingsPanelAccounts.BackColor = System.Drawing.SystemColors.Control;
            this.settingsPanelAccounts.Controls.Add(this.groupBox2);
            this.settingsPanelAccounts.Controls.Add(this.groupBox1);
            this.settingsPanelAccounts.Controls.Add(this.settingsAccountLabel);
            this.settingsPanelAccounts.Controls.Add(this.settingsPassSaveChbox);
            this.settingsPanelAccounts.Controls.Add(this.settingsUsernameSaveChbox);
            this.settingsPanelAccounts.Controls.Add(this.settingsPassTextBox);
            this.settingsPanelAccounts.Controls.Add(this.settingsUsernameTextBox);
            this.settingsPanelAccounts.Controls.Add(this.settingsPasswordLabel);
            this.settingsPanelAccounts.Controls.Add(this.settingsUsernameLabel);
            this.settingsPanelAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanelAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsPanelAccounts.Location = new System.Drawing.Point(0, 0);
            this.settingsPanelAccounts.Margin = new System.Windows.Forms.Padding(0);
            this.settingsPanelAccounts.Name = "settingsPanelAccounts";
            this.settingsPanelAccounts.Size = new System.Drawing.Size(465, 355);
            this.settingsPanelAccounts.TabIndex = 8;
            this.settingsPanelAccounts.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.settingsReaderToggler);
            this.groupBox2.Controls.Add(this.settingsReaderFreqLabel);
            this.groupBox2.Controls.Add(this.settingsReaderFreqBar);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(10, 239);
            this.groupBox2.MinimumSize = new System.Drawing.Size(441, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   ";
            // 
            // settingsReaderToggler
            // 
            this.settingsReaderToggler.AutoSize = true;
            this.settingsReaderToggler.Checked = true;
            this.settingsReaderToggler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsReaderToggler.Location = new System.Drawing.Point(12, -2);
            this.settingsReaderToggler.Name = "settingsReaderToggler";
            this.settingsReaderToggler.Size = new System.Drawing.Size(74, 21);
            this.settingsReaderToggler.TabIndex = 8;
            this.settingsReaderToggler.Text = "Reader";
            this.settingsReaderToggler.UseVisualStyleBackColor = true;
            this.settingsReaderToggler.CheckedChanged += new System.EventHandler(this.settingsReaderToggler_CheckedChanged);
            // 
            // settingsReaderFreqLabel
            // 
            this.settingsReaderFreqLabel.AutoSize = true;
            this.settingsReaderFreqLabel.Location = new System.Drawing.Point(89, 22);
            this.settingsReaderFreqLabel.Name = "settingsReaderFreqLabel";
            this.settingsReaderFreqLabel.Size = new System.Drawing.Size(100, 17);
            this.settingsReaderFreqLabel.TabIndex = 2;
            this.settingsReaderFreqLabel.Text = "No auto-check";
            // 
            // settingsReaderFreqBar
            // 
            this.settingsReaderFreqBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsReaderFreqBar.AutoSize = false;
            this.settingsReaderFreqBar.Location = new System.Drawing.Point(80, 54);
            this.settingsReaderFreqBar.Maximum = 9;
            this.settingsReaderFreqBar.Name = "settingsReaderFreqBar";
            this.settingsReaderFreqBar.Size = new System.Drawing.Size(355, 30);
            this.settingsReaderFreqBar.TabIndex = 9;
            this.settingsReaderFreqBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.settingsToolTip.SetToolTip(this.settingsReaderFreqBar, "How often to check your google reader\r\nfor unread feeds");
            this.settingsReaderFreqBar.ValueChanged += new System.EventHandler(this.settingsReaderFreqBar_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GWatchNS.Properties.Resources.reader;
            this.pictureBox2.Location = new System.Drawing.Point(7, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 62);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.settingsMailToggler);
            this.groupBox1.Controls.Add(this.settingsMailFreqLabel);
            this.groupBox1.Controls.Add(this.settingsMailFreqBar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 133);
            this.groupBox1.MinimumSize = new System.Drawing.Size(441, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   ";
            // 
            // settingsMailToggler
            // 
            this.settingsMailToggler.AutoSize = true;
            this.settingsMailToggler.Checked = true;
            this.settingsMailToggler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsMailToggler.Location = new System.Drawing.Point(12, 0);
            this.settingsMailToggler.Name = "settingsMailToggler";
            this.settingsMailToggler.Size = new System.Drawing.Size(52, 21);
            this.settingsMailToggler.TabIndex = 6;
            this.settingsMailToggler.Text = "Mail";
            this.settingsMailToggler.UseVisualStyleBackColor = true;
            this.settingsMailToggler.CheckedChanged += new System.EventHandler(this.settingsMailToggler_CheckedChanged);
            // 
            // settingsMailFreqLabel
            // 
            this.settingsMailFreqLabel.AutoSize = true;
            this.settingsMailFreqLabel.Location = new System.Drawing.Point(89, 22);
            this.settingsMailFreqLabel.Name = "settingsMailFreqLabel";
            this.settingsMailFreqLabel.Size = new System.Drawing.Size(100, 17);
            this.settingsMailFreqLabel.TabIndex = 2;
            this.settingsMailFreqLabel.Text = "No auto-check";
            // 
            // settingsMailFreqBar
            // 
            this.settingsMailFreqBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsMailFreqBar.AutoSize = false;
            this.settingsMailFreqBar.Location = new System.Drawing.Point(80, 54);
            this.settingsMailFreqBar.Maximum = 9;
            this.settingsMailFreqBar.Name = "settingsMailFreqBar";
            this.settingsMailFreqBar.Size = new System.Drawing.Size(355, 30);
            this.settingsMailFreqBar.TabIndex = 7;
            this.settingsMailFreqBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.settingsToolTip.SetToolTip(this.settingsMailFreqBar, "How often to check your mailbox\r\nfor unread messages ");
            this.settingsMailFreqBar.ValueChanged += new System.EventHandler(this.settingsMailFreqBar_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GWatchNS.Properties.Resources.gmail;
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // settingsAccountLabel
            // 
            this.settingsAccountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.settingsAccountLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsAccountLabel.Name = "settingsAccountLabel";
            this.settingsAccountLabel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 5);
            this.settingsAccountLabel.Size = new System.Drawing.Size(465, 35);
            this.settingsAccountLabel.TabIndex = 6;
            this.settingsAccountLabel.Text = "Account";
            this.settingsAccountLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.settingsAccountLabel_Paint);
            // 
            // settingsPassSaveChbox
            // 
            this.settingsPassSaveChbox.AutoSize = true;
            this.settingsPassSaveChbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsPassSaveChbox.Location = new System.Drawing.Point(242, 92);
            this.settingsPassSaveChbox.Name = "settingsPassSaveChbox";
            this.settingsPassSaveChbox.Size = new System.Drawing.Size(222, 21);
            this.settingsPassSaveChbox.TabIndex = 5;
            this.settingsPassSaveChbox.Text = "Remember login and password";
            this.settingsToolTip.SetToolTip(this.settingsPassSaveChbox, "Stores your user name and password \r\nin the config file");
            this.settingsPassSaveChbox.UseVisualStyleBackColor = true;
            this.settingsPassSaveChbox.CheckedChanged += new System.EventHandler(this.settingsPassSaveChbox_CheckedChanged);
            // 
            // settingsUsernameSaveChbox
            // 
            this.settingsUsernameSaveChbox.AutoSize = true;
            this.settingsUsernameSaveChbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsUsernameSaveChbox.Location = new System.Drawing.Point(242, 57);
            this.settingsUsernameSaveChbox.Name = "settingsUsernameSaveChbox";
            this.settingsUsernameSaveChbox.Size = new System.Drawing.Size(152, 21);
            this.settingsUsernameSaveChbox.TabIndex = 4;
            this.settingsUsernameSaveChbox.Text = "Remember my login";
            this.settingsToolTip.SetToolTip(this.settingsUsernameSaveChbox, "Stores your user name in the config file");
            this.settingsUsernameSaveChbox.UseVisualStyleBackColor = true;
            // 
            // settingsPassTextBox
            // 
            this.settingsPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsPassTextBox.Location = new System.Drawing.Point(108, 91);
            this.settingsPassTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.settingsPassTextBox.Name = "settingsPassTextBox";
            this.settingsPassTextBox.Size = new System.Drawing.Size(126, 23);
            this.settingsPassTextBox.TabIndex = 3;
            this.settingsPassTextBox.UseSystemPasswordChar = true;
            // 
            // settingsUsernameTextBox
            // 
            this.settingsUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsUsernameTextBox.Location = new System.Drawing.Point(108, 56);
            this.settingsUsernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.settingsUsernameTextBox.Name = "settingsUsernameTextBox";
            this.settingsUsernameTextBox.Size = new System.Drawing.Size(126, 23);
            this.settingsUsernameTextBox.TabIndex = 2;
            // 
            // settingsPasswordLabel
            // 
            this.settingsPasswordLabel.AutoSize = true;
            this.settingsPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsPasswordLabel.Location = new System.Drawing.Point(11, 94);
            this.settingsPasswordLabel.Margin = new System.Windows.Forms.Padding(5);
            this.settingsPasswordLabel.Name = "settingsPasswordLabel";
            this.settingsPasswordLabel.Size = new System.Drawing.Size(69, 17);
            this.settingsPasswordLabel.TabIndex = 1;
            this.settingsPasswordLabel.Text = "Password";
            // 
            // settingsUsernameLabel
            // 
            this.settingsUsernameLabel.AutoSize = true;
            this.settingsUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsUsernameLabel.Location = new System.Drawing.Point(11, 59);
            this.settingsUsernameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.settingsUsernameLabel.Name = "settingsUsernameLabel";
            this.settingsUsernameLabel.Size = new System.Drawing.Size(77, 17);
            this.settingsUsernameLabel.TabIndex = 0;
            this.settingsUsernameLabel.Text = "User name";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.settingsCancelButton);
            this.buttonPanel.Controls.Add(this.settingsApplyButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 355);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(576, 47);
            this.buttonPanel.TabIndex = 0;
            this.buttonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonPanel_Paint);
            // 
            // settingsCancelButton
            // 
            this.settingsCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.settingsCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsCancelButton.Location = new System.Drawing.Point(469, 12);
            this.settingsCancelButton.Name = "settingsCancelButton";
            this.settingsCancelButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.settingsCancelButton.Size = new System.Drawing.Size(95, 26);
            this.settingsCancelButton.TabIndex = 5;
            this.settingsCancelButton.Text = "Close";
            this.settingsCancelButton.UseVisualStyleBackColor = true;
            this.settingsCancelButton.Click += new System.EventHandler(this.settingsCancelButton_Click);
            // 
            // settingsApplyButton
            // 
            this.settingsApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsApplyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.settingsApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsApplyButton.Location = new System.Drawing.Point(367, 12);
            this.settingsApplyButton.Name = "settingsApplyButton";
            this.settingsApplyButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.settingsApplyButton.Size = new System.Drawing.Size(95, 26);
            this.settingsApplyButton.TabIndex = 4;
            this.settingsApplyButton.Text = "Apply";
            this.settingsApplyButton.UseVisualStyleBackColor = true;
            this.settingsApplyButton.Click += new System.EventHandler(this.settingsApplyButton_Click);
            // 
            // settingsForm
            // 
            this.AcceptButton = this.settingsApplyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.settingsCancelButton;
            this.ClientSize = new System.Drawing.Size(576, 402);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.settingsPanelAlert.ResumeLayout(false);
            this.nativePopupSettingsGroupBox.ResumeLayout(false);
            this.nativePopupSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsAlertDismissDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsAlertOpacityBox)).EndInit();
            this.actionGroupBox.ResumeLayout(false);
            this.actionGroupBox.PerformLayout();
            this.settingsPanelGeneral.ResumeLayout(false);
            this.settingsPanelGeneral.PerformLayout();
            this.settingsPanelAbout.ResumeLayout(false);
            this.settingsPanelAbout.PerformLayout();
            this.settingsPanelAccounts.ResumeLayout(false);
            this.settingsPanelAccounts.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsReaderFreqBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsMailFreqBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button settingsCancelButton;
        private System.Windows.Forms.Button settingsApplyButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView settingsTree;
        private System.Windows.Forms.Panel settingsPanelAccounts;
        private System.Windows.Forms.CheckBox settingsPassSaveChbox;
        private System.Windows.Forms.CheckBox settingsUsernameSaveChbox;
        private System.Windows.Forms.TextBox settingsPassTextBox;
        private System.Windows.Forms.TextBox settingsUsernameTextBox;
        private System.Windows.Forms.Label settingsPasswordLabel;
        private System.Windows.Forms.Label settingsUsernameLabel;
        private System.Windows.Forms.Panel settingsPanelAlert;
        private System.Windows.Forms.Panel settingsPanelGeneral;
        private System.Windows.Forms.CheckBox settingsAutoStartCheckbox;
        private System.Windows.Forms.Label settingsAlertLabel;
        private System.Windows.Forms.Label settingsGeneralLabel;
        private System.Windows.Forms.Label settingsAccountLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar settingsReaderFreqBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar settingsMailFreqBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label settingsReaderFreqLabel;
		private System.Windows.Forms.Label settingsMailFreqLabel;
        private System.Windows.Forms.ToolTip settingsToolTip;
        private System.Windows.Forms.GroupBox actionGroupBox;
        private System.Windows.Forms.GroupBox nativePopupSettingsGroupBox;
        private System.Windows.Forms.NumericUpDown settingsAlertOpacityBox;
        private System.Windows.Forms.Label settingsOpacityLabel;
		private System.Windows.Forms.ComboBox settingsAlertHorizontalCombo;
        private System.Windows.Forms.ComboBox settingsAlertVerticalCombo;
		private System.Windows.Forms.Label settingsPositionLabel;
		private System.Windows.Forms.CheckBox settingsAlertActionPopupChBox;
        private System.Windows.Forms.CheckBox settingsAlertActionGrowlChBox;
        private System.Windows.Forms.ComboBox settingsLangCombo;
        private System.Windows.Forms.Label settingsLanguageLabel;
		private System.Windows.Forms.Panel settingsPanelAbout;
		private System.Windows.Forms.Label settingsAboutLabel;
		private System.Windows.Forms.Label settingsAboutText;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ComboBox settingsAlertImage;
		private System.Windows.Forms.Label settingsBackgroundLabel;
		private System.Windows.Forms.Label settingsTextColorLabel;
		private System.Windows.Forms.TextBox settingsAlertColor;
		private System.Windows.Forms.CheckBox settingsReaderToggler;
		private System.Windows.Forms.CheckBox settingsMailToggler;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown settingsAlertDismissDelay;
		private System.Windows.Forms.Label settingsDismissDelayLabel;
		private System.Windows.Forms.LinkLabel settingsGetLanguagesLink;
		private System.Windows.Forms.CheckBox settingsUpdateOnStartCheckbox;

    }
}