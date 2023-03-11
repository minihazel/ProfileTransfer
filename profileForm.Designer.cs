﻿namespace ProfileTransfer
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
            this.panelFrom = new System.Windows.Forms.Panel();
            this.panelFromLocation = new System.Windows.Forms.Label();
            this.panelFromBrowse = new System.Windows.Forms.Button();
            this.panelFromClear = new System.Windows.Forms.Label();
            this.panelFromList = new System.Windows.Forms.Panel();
            this.panelFromPlaceholder = new System.Windows.Forms.Label();
            this.panelFromLocationTitle = new System.Windows.Forms.Label();
            this.panelFromTitle = new System.Windows.Forms.Label();
            this.panelNewServer = new System.Windows.Forms.Panel();
            this.currentCompatibility = new System.Windows.Forms.Label();
            this.currentLocation = new System.Windows.Forms.Label();
            this.btnBrowseNew = new System.Windows.Forms.Button();
            this.nameNewServer = new System.Windows.Forms.Label();
            this.panelTransferFreely = new System.Windows.Forms.Panel();
            this.transferRight = new System.Windows.Forms.Button();
            this.transferLeft = new System.Windows.Forms.Button();
            this.panelTo = new System.Windows.Forms.Panel();
            this.panelToLocation = new System.Windows.Forms.Label();
            this.panelToClear = new System.Windows.Forms.Label();
            this.panelToList = new System.Windows.Forms.Panel();
            this.panelToPlaceholder = new System.Windows.Forms.Label();
            this.panelToLocationTitle = new System.Windows.Forms.Label();
            this.panelToBrowse = new System.Windows.Forms.Button();
            this.panelToTitle = new System.Windows.Forms.Label();
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
            this.watermarkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkIcon)).BeginInit();
            this.panelFrom.SuspendLayout();
            this.panelFromList.SuspendLayout();
            this.panelNewServer.SuspendLayout();
            this.panelTransferFreely.SuspendLayout();
            this.panelTo.SuspendLayout();
            this.panelToList.SuspendLayout();
            this.panelTransferTo.SuspendLayout();
            this.panelNewOptions.SuspendLayout();
            this.easyProfilePanel.SuspendLayout();
            this.easyProfileUserList.SuspendLayout();
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
            // panelFrom
            // 
            this.panelFrom.Controls.Add(this.panelFromLocation);
            this.panelFrom.Controls.Add(this.panelFromBrowse);
            this.panelFrom.Controls.Add(this.panelFromClear);
            this.panelFrom.Controls.Add(this.panelFromList);
            this.panelFrom.Controls.Add(this.panelFromLocationTitle);
            this.panelFrom.Controls.Add(this.panelFromTitle);
            this.panelFrom.Location = new System.Drawing.Point(0, 3);
            this.panelFrom.Name = "panelFrom";
            this.panelFrom.Size = new System.Drawing.Size(340, 387);
            this.panelFrom.TabIndex = 3;
            // 
            // panelFromLocation
            // 
            this.panelFromLocation.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.panelFromLocation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panelFromLocation.Location = new System.Drawing.Point(51, 52);
            this.panelFromLocation.Name = "panelFromLocation";
            this.panelFromLocation.Size = new System.Drawing.Size(285, 34);
            this.panelFromLocation.TabIndex = 9;
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
            this.panelFromBrowse.Location = new System.Drawing.Point(247, 6);
            this.panelFromBrowse.Name = "panelFromBrowse";
            this.panelFromBrowse.Size = new System.Drawing.Size(90, 42);
            this.panelFromBrowse.TabIndex = 8;
            this.panelFromBrowse.Text = "Find";
            this.panelFromBrowse.UseVisualStyleBackColor = false;
            this.panelFromBrowse.Click += new System.EventHandler(this.panelFromBrowse_Click);
            // 
            // panelFromClear
            // 
            this.panelFromClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFromClear.AutoSize = true;
            this.panelFromClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelFromClear.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.panelFromClear.ForeColor = System.Drawing.Color.DarkGray;
            this.panelFromClear.Location = new System.Drawing.Point(234, 87);
            this.panelFromClear.Name = "panelFromClear";
            this.panelFromClear.Size = new System.Drawing.Size(103, 13);
            this.panelFromClear.TabIndex = 7;
            this.panelFromClear.Text = "Clear all selections";
            this.panelFromClear.Click += new System.EventHandler(this.sptClearAllSelections_Click);
            this.panelFromClear.MouseEnter += new System.EventHandler(this.panelFromClear_MouseEnter);
            this.panelFromClear.MouseLeave += new System.EventHandler(this.panelFromClear_MouseLeave);
            // 
            // panelFromList
            // 
            this.panelFromList.AllowDrop = true;
            this.panelFromList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFromList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFromList.Controls.Add(this.panelFromPlaceholder);
            this.panelFromList.Location = new System.Drawing.Point(3, 108);
            this.panelFromList.Name = "panelFromList";
            this.panelFromList.Size = new System.Drawing.Size(334, 276);
            this.panelFromList.TabIndex = 6;
            this.panelFromList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelFromList_DragDrop);
            this.panelFromList.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelFromList_DragEnter);
            // 
            // panelFromPlaceholder
            // 
            this.panelFromPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFromPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.panelFromPlaceholder.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.panelFromPlaceholder.ForeColor = System.Drawing.Color.DarkGray;
            this.panelFromPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.panelFromPlaceholder.Name = "panelFromPlaceholder";
            this.panelFromPlaceholder.Size = new System.Drawing.Size(332, 27);
            this.panelFromPlaceholder.TabIndex = 4;
            this.panelFromPlaceholder.Text = "dev_raccoon";
            this.panelFromPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelFromPlaceholder.Visible = false;
            // 
            // panelFromLocationTitle
            // 
            this.panelFromLocationTitle.AutoSize = true;
            this.panelFromLocationTitle.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.panelFromLocationTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.panelFromLocationTitle.Location = new System.Drawing.Point(3, 52);
            this.panelFromLocationTitle.Name = "panelFromLocationTitle";
            this.panelFromLocationTitle.Size = new System.Drawing.Size(51, 13);
            this.panelFromLocationTitle.TabIndex = 5;
            this.panelFromLocationTitle.Text = "Location:";
            // 
            // panelFromTitle
            // 
            this.panelFromTitle.AutoSize = true;
            this.panelFromTitle.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.panelFromTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.panelFromTitle.Location = new System.Drawing.Point(3, 18);
            this.panelFromTitle.Name = "panelFromTitle";
            this.panelFromTitle.Size = new System.Drawing.Size(209, 17);
            this.panelFromTitle.TabIndex = 3;
            this.panelFromTitle.Text = "Select existing SPT installation";
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
            // panelTransferFreely
            // 
            this.panelTransferFreely.Controls.Add(this.transferRight);
            this.panelTransferFreely.Controls.Add(this.transferLeft);
            this.panelTransferFreely.Controls.Add(this.panelTo);
            this.panelTransferFreely.Controls.Add(this.panelFrom);
            this.panelTransferFreely.Location = new System.Drawing.Point(46, 161);
            this.panelTransferFreely.Name = "panelTransferFreely";
            this.panelTransferFreely.Size = new System.Drawing.Size(838, 395);
            this.panelTransferFreely.TabIndex = 7;
            // 
            // transferRight
            // 
            this.transferRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transferRight.BackColor = System.Drawing.Color.DimGray;
            this.transferRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferRight.FlatAppearance.BorderSize = 0;
            this.transferRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferRight.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferRight.ForeColor = System.Drawing.Color.LightGray;
            this.transferRight.Location = new System.Drawing.Point(346, 202);
            this.transferRight.Name = "transferRight";
            this.transferRight.Size = new System.Drawing.Size(146, 42);
            this.transferRight.TabIndex = 9;
            this.transferRight.Text = "→ Transfer →";
            this.transferRight.UseVisualStyleBackColor = false;
            this.transferRight.Click += new System.EventHandler(this.transferRight_Click);
            // 
            // transferLeft
            // 
            this.transferLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transferLeft.BackColor = System.Drawing.Color.DimGray;
            this.transferLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferLeft.FlatAppearance.BorderSize = 0;
            this.transferLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferLeft.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferLeft.ForeColor = System.Drawing.Color.LightGray;
            this.transferLeft.Location = new System.Drawing.Point(346, 260);
            this.transferLeft.Name = "transferLeft";
            this.transferLeft.Size = new System.Drawing.Size(146, 42);
            this.transferLeft.TabIndex = 8;
            this.transferLeft.Text = "← Transfer ←";
            this.transferLeft.UseVisualStyleBackColor = false;
            this.transferLeft.Click += new System.EventHandler(this.transferLeft_Click);
            // 
            // panelTo
            // 
            this.panelTo.Controls.Add(this.panelToLocation);
            this.panelTo.Controls.Add(this.panelToClear);
            this.panelTo.Controls.Add(this.panelToList);
            this.panelTo.Controls.Add(this.panelToLocationTitle);
            this.panelTo.Controls.Add(this.panelToBrowse);
            this.panelTo.Controls.Add(this.panelToTitle);
            this.panelTo.Location = new System.Drawing.Point(498, 3);
            this.panelTo.Name = "panelTo";
            this.panelTo.Size = new System.Drawing.Size(340, 387);
            this.panelTo.TabIndex = 7;
            // 
            // panelToLocation
            // 
            this.panelToLocation.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.panelToLocation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panelToLocation.Location = new System.Drawing.Point(51, 52);
            this.panelToLocation.Name = "panelToLocation";
            this.panelToLocation.Size = new System.Drawing.Size(285, 34);
            this.panelToLocation.TabIndex = 10;
            // 
            // panelToClear
            // 
            this.panelToClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToClear.AutoSize = true;
            this.panelToClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelToClear.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.panelToClear.ForeColor = System.Drawing.Color.DarkGray;
            this.panelToClear.Location = new System.Drawing.Point(234, 87);
            this.panelToClear.Name = "panelToClear";
            this.panelToClear.Size = new System.Drawing.Size(103, 13);
            this.panelToClear.TabIndex = 10;
            this.panelToClear.Text = "Clear all selections";
            this.panelToClear.MouseEnter += new System.EventHandler(this.panelToClear_MouseEnter);
            this.panelToClear.MouseLeave += new System.EventHandler(this.panelToClear_MouseLeave);
            // 
            // panelToList
            // 
            this.panelToList.AllowDrop = true;
            this.panelToList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToList.Controls.Add(this.panelToPlaceholder);
            this.panelToList.Location = new System.Drawing.Point(3, 108);
            this.panelToList.Name = "panelToList";
            this.panelToList.Size = new System.Drawing.Size(334, 276);
            this.panelToList.TabIndex = 7;
            this.panelToList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelToList_DragDrop);
            this.panelToList.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelToList_DragEnter);
            // 
            // panelToPlaceholder
            // 
            this.panelToPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.panelToPlaceholder.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.panelToPlaceholder.ForeColor = System.Drawing.Color.DarkGray;
            this.panelToPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.panelToPlaceholder.Name = "panelToPlaceholder";
            this.panelToPlaceholder.Size = new System.Drawing.Size(332, 27);
            this.panelToPlaceholder.TabIndex = 4;
            this.panelToPlaceholder.Text = "dev_raccoon";
            this.panelToPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelToPlaceholder.Visible = false;
            // 
            // panelToLocationTitle
            // 
            this.panelToLocationTitle.AutoSize = true;
            this.panelToLocationTitle.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.panelToLocationTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.panelToLocationTitle.Location = new System.Drawing.Point(3, 52);
            this.panelToLocationTitle.Name = "panelToLocationTitle";
            this.panelToLocationTitle.Size = new System.Drawing.Size(51, 13);
            this.panelToLocationTitle.TabIndex = 5;
            this.panelToLocationTitle.Text = "Location:";
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
            this.panelToBrowse.Location = new System.Drawing.Point(247, 6);
            this.panelToBrowse.Name = "panelToBrowse";
            this.panelToBrowse.Size = new System.Drawing.Size(90, 42);
            this.panelToBrowse.TabIndex = 2;
            this.panelToBrowse.Text = "Find";
            this.panelToBrowse.UseVisualStyleBackColor = false;
            this.panelToBrowse.Click += new System.EventHandler(this.panelToBrowse_Click);
            // 
            // panelToTitle
            // 
            this.panelToTitle.AutoSize = true;
            this.panelToTitle.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.panelToTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.panelToTitle.Location = new System.Drawing.Point(3, 17);
            this.panelToTitle.Name = "panelToTitle";
            this.panelToTitle.Size = new System.Drawing.Size(209, 17);
            this.panelToTitle.TabIndex = 3;
            this.panelToTitle.Text = "Select existing SPT installation";
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
            this.tabTransferFrom.Location = new System.Drawing.Point(607, 49);
            this.tabTransferFrom.Name = "tabTransferFrom";
            this.tabTransferFrom.Size = new System.Drawing.Size(277, 42);
            this.tabTransferFrom.TabIndex = 9;
            this.tabTransferFrom.Text = "Transfer profiles from and to";
            this.tabTransferFrom.UseVisualStyleBackColor = false;
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
            // profileForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(936, 588);
            this.Controls.Add(this.tabTransferFrom);
            this.Controls.Add(this.tabTransferTo);
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
            this.panelFrom.ResumeLayout(false);
            this.panelFrom.PerformLayout();
            this.panelFromList.ResumeLayout(false);
            this.panelNewServer.ResumeLayout(false);
            this.panelNewServer.PerformLayout();
            this.panelTransferFreely.ResumeLayout(false);
            this.panelTo.ResumeLayout(false);
            this.panelTo.PerformLayout();
            this.panelToList.ResumeLayout(false);
            this.panelTransferTo.ResumeLayout(false);
            this.panelNewOptions.ResumeLayout(false);
            this.easyProfilePanel.ResumeLayout(false);
            this.easyProfilePanel.PerformLayout();
            this.easyProfileUserList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel watermarkPanel;
        public System.Windows.Forms.Label watermarkCompatibility;
        public System.Windows.Forms.PictureBox watermarkIcon;
        public System.Windows.Forms.Label watermarkTitle;
        public System.Windows.Forms.Label panelFromLocationTitle;
        public System.Windows.Forms.Label panelFromTitle;
        public System.Windows.Forms.Panel panelNewServer;
        public System.Windows.Forms.Label currentLocation;
        public System.Windows.Forms.Button btnBrowseNew;
        public System.Windows.Forms.Label nameNewServer;
        public System.Windows.Forms.Panel panelFromList;
        public System.Windows.Forms.Label currentCompatibility;
        public System.Windows.Forms.Panel panelTransferFreely;
        public System.Windows.Forms.Label panelFromPlaceholder;
        public System.Windows.Forms.Panel panelTo;
        public System.Windows.Forms.Label panelToLocationTitle;
        public System.Windows.Forms.Button panelToBrowse;
        public System.Windows.Forms.Label panelToTitle;
        public System.Windows.Forms.Panel panelToList;
        public System.Windows.Forms.Label panelToPlaceholder;
        public System.Windows.Forms.Label panelFromClear;
        public System.Windows.Forms.Button transferLeft;
        public System.Windows.Forms.Button transferRight;
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
        public System.Windows.Forms.Label panelToClear;
        public System.Windows.Forms.Button newOptionsTransfer;
        public System.Windows.Forms.Label newOptionsWarning;
        public System.Windows.Forms.Timer constructionTimer;
        public System.Windows.Forms.Label panelFromLocation;
        public System.Windows.Forms.Label panelToLocation;
        public System.Windows.Forms.Panel panelFrom;
    }
}

