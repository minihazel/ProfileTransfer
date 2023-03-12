namespace ProfileTransfer
{
    partial class profileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profileForm));
            this.watermarkPanel = new System.Windows.Forms.Panel();
            this.watermarkCompatibility = new System.Windows.Forms.Label();
            this.watermarkIcon = new System.Windows.Forms.PictureBox();
            this.watermarkTitle = new System.Windows.Forms.Label();
            this.panelProfiles = new System.Windows.Forms.Panel();
            this.panelProfileNamesList = new System.Windows.Forms.Panel();
            this.panelProfileNamesPlaceholder = new System.Windows.Forms.Label();
            this.serverLocation = new System.Windows.Forms.Label();
            this.panelToTitle = new System.Windows.Forms.Label();
            this.panelClearAllProfiles = new System.Windows.Forms.Label();
            this.panelProfilesList = new System.Windows.Forms.Panel();
            this.panelProfilesPlaceholder = new System.Windows.Forms.Label();
            this.serverLocationTitle = new System.Windows.Forms.Label();
            this.panelFromTitle = new System.Windows.Forms.Label();
            this.panelFromBrowse = new System.Windows.Forms.Button();
            this.panelNewServer = new System.Windows.Forms.Panel();
            this.currentCompatibility = new System.Windows.Forms.Label();
            this.currentLocation = new System.Windows.Forms.Label();
            this.btnBrowseNew = new System.Windows.Forms.Button();
            this.nameNewServer = new System.Windows.Forms.Label();
            this.transferAll = new System.Windows.Forms.Button();
            this.panelToBrowse = new System.Windows.Forms.Button();
            this.tabTransferTo = new System.Windows.Forms.Button();
            this.tabTransferFrom = new System.Windows.Forms.Button();
            this.panelTransferTo = new System.Windows.Forms.Panel();
            this.panelNewOptions = new System.Windows.Forms.Panel();
            this.newOptionsWarning = new System.Windows.Forms.Label();
            this.newOptionsTransfer = new System.Windows.Forms.Button();
            this.easyProfilePanel = new System.Windows.Forms.Panel();
            this.easyProfileClearAllSelections = new System.Windows.Forms.Label();
            this.easyProfileUserList = new System.Windows.Forms.Panel();
            this.easyProfileUserPlaceholder = new System.Windows.Forms.Label();
            this.easyProfileLocation = new System.Windows.Forms.Label();
            this.easyProfileTitle = new System.Windows.Forms.Label();
            this.constructionTimer = new System.Windows.Forms.Timer(this.components);
            this.panelTransferFreely = new System.Windows.Forms.Panel();
            this.panelClearSelected = new System.Windows.Forms.Label();
            this.selectAllProfiles = new System.Windows.Forms.Button();
            this.unSelectAll = new System.Windows.Forms.Button();
            this.watermarkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkIcon)).BeginInit();
            this.panelProfiles.SuspendLayout();
            this.panelProfileNamesList.SuspendLayout();
            this.panelProfilesList.SuspendLayout();
            this.panelNewServer.SuspendLayout();
            this.panelTransferTo.SuspendLayout();
            this.panelNewOptions.SuspendLayout();
            this.easyProfilePanel.SuspendLayout();
            this.easyProfileUserList.SuspendLayout();
            this.panelTransferFreely.SuspendLayout();
            this.SuspendLayout();
            // 
            // watermarkPanel
            // 
            this.watermarkPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.watermarkPanel.Controls.Add(this.watermarkCompatibility);
            this.watermarkPanel.Controls.Add(this.watermarkIcon);
            this.watermarkPanel.Controls.Add(this.watermarkTitle);
            this.watermarkPanel.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.watermarkPanel.Location = new System.Drawing.Point(46, 41);
            this.watermarkPanel.Name = "watermarkPanel";
            this.watermarkPanel.Size = new System.Drawing.Size(341, 69);
            this.watermarkPanel.TabIndex = 1;
            // 
            // watermarkCompatibility
            // 
            this.watermarkCompatibility.AutoSize = true;
            this.watermarkCompatibility.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.watermarkCompatibility.ForeColor = System.Drawing.Color.DarkGray;
            this.watermarkCompatibility.Location = new System.Drawing.Point(83, 43);
            this.watermarkCompatibility.Name = "watermarkCompatibility";
            this.watermarkCompatibility.Size = new System.Drawing.Size(195, 17);
            this.watermarkCompatibility.TabIndex = 2;
            this.watermarkCompatibility.Text = "Supports SPT-AKI 2.0 and up";
            // 
            // watermarkIcon
            // 
            this.watermarkIcon.Image = ((System.Drawing.Image)(resources.GetObject("watermarkIcon.Image")));
            this.watermarkIcon.Location = new System.Drawing.Point(3, 3);
            this.watermarkIcon.Name = "watermarkIcon";
            this.watermarkIcon.Size = new System.Drawing.Size(60, 60);
            this.watermarkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.watermarkIcon.TabIndex = 1;
            this.watermarkIcon.TabStop = false;
            // 
            // watermarkTitle
            // 
            this.watermarkTitle.AutoSize = true;
            this.watermarkTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.watermarkTitle.Location = new System.Drawing.Point(81, 10);
            this.watermarkTitle.Name = "watermarkTitle";
            this.watermarkTitle.Size = new System.Drawing.Size(259, 29);
            this.watermarkTitle.TabIndex = 0;
            this.watermarkTitle.Text = "SPT-AKI Profile Fusion";
            // 
            // panelProfiles
            // 
            this.panelProfiles.Controls.Add(this.panelClearSelected);
            this.panelProfiles.Controls.Add(this.panelProfileNamesList);
            this.panelProfiles.Controls.Add(this.serverLocation);
            this.panelProfiles.Controls.Add(this.panelToTitle);
            this.panelProfiles.Controls.Add(this.panelClearAllProfiles);
            this.panelProfiles.Controls.Add(this.panelProfilesList);
            this.panelProfiles.Controls.Add(this.serverLocationTitle);
            this.panelProfiles.Controls.Add(this.panelFromTitle);
            this.panelProfiles.Location = new System.Drawing.Point(0, 3);
            this.panelProfiles.Name = "panelProfiles";
            this.panelProfiles.Size = new System.Drawing.Size(838, 421);
            this.panelProfiles.TabIndex = 3;
            // 
            // panelProfileNamesList
            // 
            this.panelProfileNamesList.AllowDrop = true;
            this.panelProfileNamesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfileNamesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfileNamesList.Controls.Add(this.panelProfileNamesPlaceholder);
            this.panelProfileNamesList.Location = new System.Drawing.Point(528, 108);
            this.panelProfileNamesList.Name = "panelProfileNamesList";
            this.panelProfileNamesList.Size = new System.Drawing.Size(304, 310);
            this.panelProfileNamesList.TabIndex = 7;
            this.panelProfileNamesList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelToList_DragDrop);
            this.panelProfileNamesList.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelToList_DragEnter);
            // 
            // panelProfileNamesPlaceholder
            // 
            this.panelProfileNamesPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfileNamesPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.panelProfileNamesPlaceholder.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.panelProfileNamesPlaceholder.ForeColor = System.Drawing.Color.DarkGray;
            this.panelProfileNamesPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.panelProfileNamesPlaceholder.Name = "panelProfileNamesPlaceholder";
            this.panelProfileNamesPlaceholder.Size = new System.Drawing.Size(302, 27);
            this.panelProfileNamesPlaceholder.TabIndex = 4;
            this.panelProfileNamesPlaceholder.Text = "dev_raccoon";
            this.panelProfileNamesPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelProfileNamesPlaceholder.Visible = false;
            // 
            // serverLocation
            // 
            this.serverLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverLocation.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.serverLocation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.serverLocation.Location = new System.Drawing.Point(103, 1);
            this.serverLocation.Name = "serverLocation";
            this.serverLocation.Size = new System.Drawing.Size(644, 18);
            this.serverLocation.TabIndex = 9;
            this.serverLocation.Click += new System.EventHandler(this.panelFromLocation_Click);
            this.serverLocation.MouseEnter += new System.EventHandler(this.serverLocation_MouseEnter);
            this.serverLocation.MouseLeave += new System.EventHandler(this.serverLocation_MouseLeave);
            // 
            // panelToTitle
            // 
            this.panelToTitle.AutoSize = true;
            this.panelToTitle.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.panelToTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.panelToTitle.Location = new System.Drawing.Point(525, 70);
            this.panelToTitle.Name = "panelToTitle";
            this.panelToTitle.Size = new System.Drawing.Size(97, 17);
            this.panelToTitle.TabIndex = 3;
            this.panelToTitle.Text = "Profile names";
            // 
            // panelClearAllProfiles
            // 
            this.panelClearAllProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClearAllProfiles.AutoSize = true;
            this.panelClearAllProfiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelClearAllProfiles.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.panelClearAllProfiles.ForeColor = System.Drawing.Color.DarkGray;
            this.panelClearAllProfiles.Location = new System.Drawing.Point(742, 87);
            this.panelClearAllProfiles.Name = "panelClearAllProfiles";
            this.panelClearAllProfiles.Size = new System.Drawing.Size(90, 13);
            this.panelClearAllProfiles.TabIndex = 7;
            this.panelClearAllProfiles.Text = "Clear all profiles";
            this.panelClearAllProfiles.Click += new System.EventHandler(this.sptClearAllSelections_Click);
            this.panelClearAllProfiles.MouseEnter += new System.EventHandler(this.panelFromClear_MouseEnter);
            this.panelClearAllProfiles.MouseLeave += new System.EventHandler(this.panelFromClear_MouseLeave);
            // 
            // panelProfilesList
            // 
            this.panelProfilesList.AllowDrop = true;
            this.panelProfilesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfilesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfilesList.Controls.Add(this.panelProfilesPlaceholder);
            this.panelProfilesList.Location = new System.Drawing.Point(3, 108);
            this.panelProfilesList.Name = "panelProfilesList";
            this.panelProfilesList.Size = new System.Drawing.Size(526, 310);
            this.panelProfilesList.TabIndex = 6;
            this.panelProfilesList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelFromList_DragDrop);
            this.panelProfilesList.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelFromList_DragEnter);
            // 
            // panelProfilesPlaceholder
            // 
            this.panelProfilesPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfilesPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.panelProfilesPlaceholder.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.panelProfilesPlaceholder.ForeColor = System.Drawing.Color.DarkGray;
            this.panelProfilesPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.panelProfilesPlaceholder.Name = "panelProfilesPlaceholder";
            this.panelProfilesPlaceholder.Size = new System.Drawing.Size(524, 27);
            this.panelProfilesPlaceholder.TabIndex = 4;
            this.panelProfilesPlaceholder.Text = "dev_raccoon";
            this.panelProfilesPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelProfilesPlaceholder.Visible = false;
            // 
            // serverLocationTitle
            // 
            this.serverLocationTitle.AutoSize = true;
            this.serverLocationTitle.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.serverLocationTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.serverLocationTitle.Location = new System.Drawing.Point(1, 1);
            this.serverLocationTitle.Name = "serverLocationTitle";
            this.serverLocationTitle.Size = new System.Drawing.Size(96, 13);
            this.serverLocationTitle.TabIndex = 5;
            this.serverLocationTitle.Text = "Transfer Location:";
            // 
            // panelFromTitle
            // 
            this.panelFromTitle.AutoSize = true;
            this.panelFromTitle.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.panelFromTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.panelFromTitle.Location = new System.Drawing.Point(1, 67);
            this.panelFromTitle.Name = "panelFromTitle";
            this.panelFromTitle.Size = new System.Drawing.Size(405, 17);
            this.panelFromTitle.TabIndex = 3;
            this.panelFromTitle.Text = "Drag and drop profiles below, alternatively the \'profiles\' folder";
            // 
            // panelFromBrowse
            // 
            this.panelFromBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFromBrowse.BackColor = System.Drawing.Color.DimGray;
            this.panelFromBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelFromBrowse.FlatAppearance.BorderSize = 0;
            this.panelFromBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelFromBrowse.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFromBrowse.ForeColor = System.Drawing.Color.LightGray;
            this.panelFromBrowse.Location = new System.Drawing.Point(434, 21);
            this.panelFromBrowse.Name = "panelFromBrowse";
            this.panelFromBrowse.Size = new System.Drawing.Size(90, 42);
            this.panelFromBrowse.TabIndex = 8;
            this.panelFromBrowse.Text = "Find";
            this.panelFromBrowse.UseVisualStyleBackColor = false;
            this.panelFromBrowse.Visible = false;
            this.panelFromBrowse.Click += new System.EventHandler(this.panelFromBrowse_Click);
            // 
            // panelNewServer
            // 
            this.panelNewServer.Controls.Add(this.currentCompatibility);
            this.panelNewServer.Controls.Add(this.currentLocation);
            this.panelNewServer.Controls.Add(this.btnBrowseNew);
            this.panelNewServer.Controls.Add(this.nameNewServer);
            this.panelNewServer.Location = new System.Drawing.Point(424, 3);
            this.panelNewServer.Name = "panelNewServer";
            this.panelNewServer.Size = new System.Drawing.Size(414, 95);
            this.panelNewServer.TabIndex = 6;
            // 
            // currentCompatibility
            // 
            this.currentCompatibility.AutoSize = true;
            this.currentCompatibility.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.currentCompatibility.ForeColor = System.Drawing.Color.DodgerBlue;
            this.currentCompatibility.Location = new System.Drawing.Point(3, 70);
            this.currentCompatibility.Name = "currentCompatibility";
            this.currentCompatibility.Size = new System.Drawing.Size(146, 17);
            this.currentCompatibility.TabIndex = 6;
            this.currentCompatibility.Text = "Supported - AKI 3.5.0";
            this.currentCompatibility.Visible = false;
            // 
            // currentLocation
            // 
            this.currentLocation.AutoSize = true;
            this.currentLocation.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.currentLocation.ForeColor = System.Drawing.Color.DarkGray;
            this.currentLocation.Location = new System.Drawing.Point(3, 52);
            this.currentLocation.Name = "currentLocation";
            this.currentLocation.Size = new System.Drawing.Size(51, 13);
            this.currentLocation.TabIndex = 5;
            this.currentLocation.Text = "Location:";
            // 
            // btnBrowseNew
            // 
            this.btnBrowseNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseNew.BackColor = System.Drawing.Color.DimGray;
            this.btnBrowseNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseNew.FlatAppearance.BorderSize = 0;
            this.btnBrowseNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseNew.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseNew.ForeColor = System.Drawing.Color.LightGray;
            this.btnBrowseNew.Location = new System.Drawing.Point(324, 5);
            this.btnBrowseNew.Name = "btnBrowseNew";
            this.btnBrowseNew.Size = new System.Drawing.Size(90, 42);
            this.btnBrowseNew.TabIndex = 2;
            this.btnBrowseNew.Text = "Find";
            this.btnBrowseNew.UseVisualStyleBackColor = false;
            this.btnBrowseNew.Click += new System.EventHandler(this.currentBrowse_Click);
            // 
            // nameNewServer
            // 
            this.nameNewServer.AutoSize = true;
            this.nameNewServer.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.nameNewServer.ForeColor = System.Drawing.Color.DarkGray;
            this.nameNewServer.Location = new System.Drawing.Point(3, 17);
            this.nameNewServer.Name = "nameNewServer";
            this.nameNewServer.Size = new System.Drawing.Size(302, 17);
            this.nameNewServer.TabIndex = 3;
            this.nameNewServer.Text = "Select the new server you want to transfer to";
            // 
            // transferAll
            // 
            this.transferAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transferAll.BackColor = System.Drawing.Color.DimGray;
            this.transferAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferAll.FlatAppearance.BorderSize = 0;
            this.transferAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferAll.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferAll.ForeColor = System.Drawing.Color.LightGray;
            this.transferAll.Location = new System.Drawing.Point(661, 21);
            this.transferAll.Name = "transferAll";
            this.transferAll.Size = new System.Drawing.Size(217, 42);
            this.transferAll.TabIndex = 9;
            this.transferAll.Text = "Transfer profiles";
            this.transferAll.UseVisualStyleBackColor = false;
            this.transferAll.Click += new System.EventHandler(this.transferAll_Click);
            // 
            // panelToBrowse
            // 
            this.panelToBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToBrowse.BackColor = System.Drawing.Color.DimGray;
            this.panelToBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelToBrowse.FlatAppearance.BorderSize = 0;
            this.panelToBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelToBrowse.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelToBrowse.ForeColor = System.Drawing.Color.LightGray;
            this.panelToBrowse.Location = new System.Drawing.Point(539, 21);
            this.panelToBrowse.Name = "panelToBrowse";
            this.panelToBrowse.Size = new System.Drawing.Size(90, 42);
            this.panelToBrowse.TabIndex = 2;
            this.panelToBrowse.Text = "Find";
            this.panelToBrowse.UseVisualStyleBackColor = false;
            this.panelToBrowse.Visible = false;
            this.panelToBrowse.Click += new System.EventHandler(this.panelToBrowse_Click);
            // 
            // tabTransferTo
            // 
            this.tabTransferTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTransferTo.BackColor = System.Drawing.Color.Transparent;
            this.tabTransferTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabTransferTo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(98)))));
            this.tabTransferTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.tabTransferTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.tabTransferTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabTransferTo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTransferTo.ForeColor = System.Drawing.Color.LightGray;
            this.tabTransferTo.Location = new System.Drawing.Point(890, 506);
            this.tabTransferTo.Name = "tabTransferTo";
            this.tabTransferTo.Size = new System.Drawing.Size(20, 42);
            this.tabTransferTo.TabIndex = 8;
            this.tabTransferTo.Text = "Transfer from existing install";
            this.tabTransferTo.UseVisualStyleBackColor = false;
            this.tabTransferTo.Visible = false;
            this.tabTransferTo.Click += new System.EventHandler(this.tabEasyMethod_Click);
            // 
            // tabTransferFrom
            // 
            this.tabTransferFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTransferFrom.BackColor = System.Drawing.Color.Transparent;
            this.tabTransferFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabTransferFrom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(98)))));
            this.tabTransferFrom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.tabTransferFrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.tabTransferFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabTransferFrom.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTransferFrom.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabTransferFrom.Location = new System.Drawing.Point(890, 458);
            this.tabTransferFrom.Name = "tabTransferFrom";
            this.tabTransferFrom.Size = new System.Drawing.Size(20, 42);
            this.tabTransferFrom.TabIndex = 9;
            this.tabTransferFrom.Text = "Transfer profiles from and to";
            this.tabTransferFrom.UseVisualStyleBackColor = false;
            this.tabTransferFrom.Visible = false;
            this.tabTransferFrom.Click += new System.EventHandler(this.tabAdvancedMethod_Click);
            // 
            // panelTransferTo
            // 
            this.panelTransferTo.Controls.Add(this.panelNewOptions);
            this.panelTransferTo.Controls.Add(this.easyProfilePanel);
            this.panelTransferTo.Controls.Add(this.panelNewServer);
            this.panelTransferTo.Location = new System.Drawing.Point(46, 161);
            this.panelTransferTo.Name = "panelTransferTo";
            this.panelTransferTo.Size = new System.Drawing.Size(838, 395);
            this.panelTransferTo.TabIndex = 10;
            // 
            // panelNewOptions
            // 
            this.panelNewOptions.Controls.Add(this.newOptionsWarning);
            this.panelNewOptions.Controls.Add(this.newOptionsTransfer);
            this.panelNewOptions.Location = new System.Drawing.Point(424, 111);
            this.panelNewOptions.Name = "panelNewOptions";
            this.panelNewOptions.Size = new System.Drawing.Size(414, 279);
            this.panelNewOptions.TabIndex = 7;
            this.panelNewOptions.Visible = false;
            // 
            // newOptionsWarning
            // 
            this.newOptionsWarning.Location = new System.Drawing.Point(6, 54);
            this.newOptionsWarning.Name = "newOptionsWarning";
            this.newOptionsWarning.Size = new System.Drawing.Size(404, 212);
            this.newOptionsWarning.TabIndex = 0;
            // 
            // newOptionsTransfer
            // 
            this.newOptionsTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newOptionsTransfer.BackColor = System.Drawing.Color.DimGray;
            this.newOptionsTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newOptionsTransfer.FlatAppearance.BorderSize = 0;
            this.newOptionsTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOptionsTransfer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOptionsTransfer.ForeColor = System.Drawing.Color.LightGray;
            this.newOptionsTransfer.Location = new System.Drawing.Point(6, 0);
            this.newOptionsTransfer.Name = "newOptionsTransfer";
            this.newOptionsTransfer.Size = new System.Drawing.Size(408, 42);
            this.newOptionsTransfer.TabIndex = 3;
            this.newOptionsTransfer.Text = "Transfer profile →";
            this.newOptionsTransfer.UseVisualStyleBackColor = false;
            // 
            // easyProfilePanel
            // 
            this.easyProfilePanel.Controls.Add(this.easyProfileClearAllSelections);
            this.easyProfilePanel.Controls.Add(this.easyProfileUserList);
            this.easyProfilePanel.Controls.Add(this.easyProfileLocation);
            this.easyProfilePanel.Controls.Add(this.easyProfileTitle);
            this.easyProfilePanel.Location = new System.Drawing.Point(0, 3);
            this.easyProfilePanel.Name = "easyProfilePanel";
            this.easyProfilePanel.Size = new System.Drawing.Size(340, 387);
            this.easyProfilePanel.TabIndex = 4;
            // 
            // easyProfileClearAllSelections
            // 
            this.easyProfileClearAllSelections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.easyProfileClearAllSelections.AutoSize = true;
            this.easyProfileClearAllSelections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyProfileClearAllSelections.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.easyProfileClearAllSelections.ForeColor = System.Drawing.Color.DarkGray;
            this.easyProfileClearAllSelections.Location = new System.Drawing.Point(233, 87);
            this.easyProfileClearAllSelections.Name = "easyProfileClearAllSelections";
            this.easyProfileClearAllSelections.Size = new System.Drawing.Size(103, 13);
            this.easyProfileClearAllSelections.TabIndex = 7;
            this.easyProfileClearAllSelections.Text = "Clear all selections";
            this.easyProfileClearAllSelections.Click += new System.EventHandler(this.easyProfileClearAllSelections_Click);
            // 
            // easyProfileUserList
            // 
            this.easyProfileUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easyProfileUserList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.easyProfileUserList.Controls.Add(this.easyProfileUserPlaceholder);
            this.easyProfileUserList.Location = new System.Drawing.Point(3, 108);
            this.easyProfileUserList.Name = "easyProfileUserList";
            this.easyProfileUserList.Size = new System.Drawing.Size(334, 276);
            this.easyProfileUserList.TabIndex = 6;
            // 
            // easyProfileUserPlaceholder
            // 
            this.easyProfileUserPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easyProfileUserPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.easyProfileUserPlaceholder.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.easyProfileUserPlaceholder.ForeColor = System.Drawing.Color.DarkGray;
            this.easyProfileUserPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.easyProfileUserPlaceholder.Name = "easyProfileUserPlaceholder";
            this.easyProfileUserPlaceholder.Size = new System.Drawing.Size(332, 27);
            this.easyProfileUserPlaceholder.TabIndex = 4;
            this.easyProfileUserPlaceholder.Text = "dev_raccoon";
            this.easyProfileUserPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easyProfileUserPlaceholder.Visible = false;
            // 
            // easyProfileLocation
            // 
            this.easyProfileLocation.AutoSize = true;
            this.easyProfileLocation.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.easyProfileLocation.ForeColor = System.Drawing.Color.DarkGray;
            this.easyProfileLocation.Location = new System.Drawing.Point(3, 64);
            this.easyProfileLocation.Name = "easyProfileLocation";
            this.easyProfileLocation.Size = new System.Drawing.Size(51, 13);
            this.easyProfileLocation.TabIndex = 5;
            this.easyProfileLocation.Text = "Location:";
            // 
            // easyProfileTitle
            // 
            this.easyProfileTitle.AutoSize = true;
            this.easyProfileTitle.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.easyProfileTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.easyProfileTitle.Location = new System.Drawing.Point(3, 18);
            this.easyProfileTitle.Name = "easyProfileTitle";
            this.easyProfileTitle.Size = new System.Drawing.Size(271, 17);
            this.easyProfileTitle.TabIndex = 3;
            this.easyProfileTitle.Text = "Select the profile(s) you want to transfer";
            // 
            // constructionTimer
            // 
            this.constructionTimer.Tick += new System.EventHandler(this.constructionTimer_Tick);
            // 
            // panelTransferFreely
            // 
            this.panelTransferFreely.Controls.Add(this.panelProfiles);
            this.panelTransferFreely.Location = new System.Drawing.Point(46, 124);
            this.panelTransferFreely.Name = "panelTransferFreely";
            this.panelTransferFreely.Size = new System.Drawing.Size(838, 432);
            this.panelTransferFreely.TabIndex = 7;
            // 
            // panelClearSelected
            // 
            this.panelClearSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClearSelected.AutoSize = true;
            this.panelClearSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelClearSelected.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.panelClearSelected.ForeColor = System.Drawing.Color.DarkGray;
            this.panelClearSelected.Location = new System.Drawing.Point(753, 6);
            this.panelClearSelected.Name = "panelClearSelected";
            this.panelClearSelected.Size = new System.Drawing.Size(79, 13);
            this.panelClearSelected.TabIndex = 10;
            this.panelClearSelected.Text = "Clear selected";
            this.panelClearSelected.Visible = false;
            this.panelClearSelected.Click += new System.EventHandler(this.panelClearSelected_Click);
            this.panelClearSelected.MouseEnter += new System.EventHandler(this.panelClearSelected_MouseEnter);
            this.panelClearSelected.MouseLeave += new System.EventHandler(this.panelClearSelected_MouseLeave);
            // 
            // selectAllProfiles
            // 
            this.selectAllProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAllProfiles.BackColor = System.Drawing.Color.DimGray;
            this.selectAllProfiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectAllProfiles.FlatAppearance.BorderSize = 0;
            this.selectAllProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAllProfiles.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllProfiles.ForeColor = System.Drawing.Color.LightGray;
            this.selectAllProfiles.Location = new System.Drawing.Point(661, 76);
            this.selectAllProfiles.Name = "selectAllProfiles";
            this.selectAllProfiles.Size = new System.Drawing.Size(101, 42);
            this.selectAllProfiles.TabIndex = 11;
            this.selectAllProfiles.Text = "Select all";
            this.selectAllProfiles.UseVisualStyleBackColor = false;
            this.selectAllProfiles.Click += new System.EventHandler(this.selectAllProfiles_Click);
            // 
            // unSelectAll
            // 
            this.unSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unSelectAll.BackColor = System.Drawing.Color.DimGray;
            this.unSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unSelectAll.FlatAppearance.BorderSize = 0;
            this.unSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unSelectAll.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unSelectAll.ForeColor = System.Drawing.Color.LightGray;
            this.unSelectAll.Location = new System.Drawing.Point(777, 76);
            this.unSelectAll.Name = "unSelectAll";
            this.unSelectAll.Size = new System.Drawing.Size(101, 42);
            this.unSelectAll.TabIndex = 12;
            this.unSelectAll.Text = "Unselect all";
            this.unSelectAll.UseVisualStyleBackColor = false;
            this.unSelectAll.Click += new System.EventHandler(this.unSelectAll_Click);
            // 
            // profileForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(936, 588);
            this.Controls.Add(this.unSelectAll);
            this.Controls.Add(this.selectAllProfiles);
            this.Controls.Add(this.transferAll);
            this.Controls.Add(this.tabTransferFrom);
            this.Controls.Add(this.panelFromBrowse);
            this.Controls.Add(this.tabTransferTo);
            this.Controls.Add(this.panelToBrowse);
            this.Controls.Add(this.watermarkPanel);
            this.Controls.Add(this.panelTransferFreely);
            this.Controls.Add(this.panelTransferTo);
            this.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "profileForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.profileForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.profileForm_FormClosed);
            this.Load += new System.EventHandler(this.profileForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.profileForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.profileForm_DragEnter);
            this.watermarkPanel.ResumeLayout(false);
            this.watermarkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkIcon)).EndInit();
            this.panelProfiles.ResumeLayout(false);
            this.panelProfiles.PerformLayout();
            this.panelProfileNamesList.ResumeLayout(false);
            this.panelProfilesList.ResumeLayout(false);
            this.panelNewServer.ResumeLayout(false);
            this.panelNewServer.PerformLayout();
            this.panelTransferTo.ResumeLayout(false);
            this.panelNewOptions.ResumeLayout(false);
            this.easyProfilePanel.ResumeLayout(false);
            this.easyProfilePanel.PerformLayout();
            this.easyProfileUserList.ResumeLayout(false);
            this.panelTransferFreely.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel watermarkPanel;
        public System.Windows.Forms.Label watermarkCompatibility;
        public System.Windows.Forms.PictureBox watermarkIcon;
        public System.Windows.Forms.Label watermarkTitle;
        public System.Windows.Forms.Label serverLocationTitle;
        public System.Windows.Forms.Label panelFromTitle;
        public System.Windows.Forms.Panel panelNewServer;
        public System.Windows.Forms.Label currentLocation;
        public System.Windows.Forms.Button btnBrowseNew;
        public System.Windows.Forms.Label nameNewServer;
        public System.Windows.Forms.Panel panelProfilesList;
        public System.Windows.Forms.Label currentCompatibility;
        public System.Windows.Forms.Label panelProfilesPlaceholder;
        public System.Windows.Forms.Button panelToBrowse;
        public System.Windows.Forms.Label panelToTitle;
        public System.Windows.Forms.Panel panelProfileNamesList;
        public System.Windows.Forms.Label panelProfileNamesPlaceholder;
        public System.Windows.Forms.Label panelClearAllProfiles;
        public System.Windows.Forms.Button transferAll;
        public System.Windows.Forms.Button tabTransferTo;
        public System.Windows.Forms.Button tabTransferFrom;
        public System.Windows.Forms.Panel panelTransferTo;
        public System.Windows.Forms.Panel easyProfilePanel;
        public System.Windows.Forms.Label easyProfileClearAllSelections;
        public System.Windows.Forms.Panel easyProfileUserList;
        public System.Windows.Forms.Label easyProfileUserPlaceholder;
        public System.Windows.Forms.Label easyProfileLocation;
        public System.Windows.Forms.Label easyProfileTitle;
        public System.Windows.Forms.Panel panelNewOptions;
        public System.Windows.Forms.Button panelFromBrowse;
        public System.Windows.Forms.Button newOptionsTransfer;
        public System.Windows.Forms.Label newOptionsWarning;
        public System.Windows.Forms.Timer constructionTimer;
        public System.Windows.Forms.Label serverLocation;
        public System.Windows.Forms.Panel panelProfiles;
        public System.Windows.Forms.Panel panelTransferFreely;
        public System.Windows.Forms.Label panelClearSelected;
        public System.Windows.Forms.Button selectAllProfiles;
        public System.Windows.Forms.Button unSelectAll;
    }
}

