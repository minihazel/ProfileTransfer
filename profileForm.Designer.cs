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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profileForm));
            this.watermarkPanel = new System.Windows.Forms.Panel();
            this.watermarkCompatibility = new System.Windows.Forms.Label();
            this.watermarkIcon = new System.Windows.Forms.PictureBox();
            this.watermarkTitle = new System.Windows.Forms.Label();
            this.sptPanel = new System.Windows.Forms.Panel();
            this.sptClearAllSelections = new System.Windows.Forms.Label();
            this.sptUserList = new System.Windows.Forms.Panel();
            this.sptUserPlaceholder = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.currentPanel = new System.Windows.Forms.Panel();
            this.currentCompatibility = new System.Windows.Forms.Label();
            this.currentLocation = new System.Windows.Forms.Label();
            this.currentBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.advancedPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newPanel = new System.Windows.Forms.Panel();
            this.newUserList = new System.Windows.Forms.Panel();
            this.newUserPlaceholder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabEasyMethod = new System.Windows.Forms.Button();
            this.tabAdvancedMethod = new System.Windows.Forms.Button();
            this.easyPanel = new System.Windows.Forms.Panel();
            this.easyProfilePanel = new System.Windows.Forms.Panel();
            this.easyProfileClearAllSelections = new System.Windows.Forms.Label();
            this.easyProfileUserList = new System.Windows.Forms.Panel();
            this.easyProfileUserPlaceholder = new System.Windows.Forms.Label();
            this.easyProfileLocation = new System.Windows.Forms.Label();
            this.easyProfileTitle = new System.Windows.Forms.Label();
            this.mainSeparator = new System.Windows.Forms.Panel();
            this.easyServerPanel = new System.Windows.Forms.Panel();
            this.easyServerCompatibility = new System.Windows.Forms.Label();
            this.easyServerLocation = new System.Windows.Forms.Label();
            this.easyServerFind = new System.Windows.Forms.Button();
            this.easyServerTitle = new System.Windows.Forms.Label();
            this.watermarkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkIcon)).BeginInit();
            this.sptPanel.SuspendLayout();
            this.sptUserList.SuspendLayout();
            this.currentPanel.SuspendLayout();
            this.advancedPanel.SuspendLayout();
            this.newPanel.SuspendLayout();
            this.newUserList.SuspendLayout();
            this.easyPanel.SuspendLayout();
            this.easyProfilePanel.SuspendLayout();
            this.easyProfileUserList.SuspendLayout();
            this.easyServerPanel.SuspendLayout();
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
            // sptPanel
            // 
            this.sptPanel.Controls.Add(this.sptClearAllSelections);
            this.sptPanel.Controls.Add(this.sptUserList);
            this.sptPanel.Controls.Add(this.label5);
            this.sptPanel.Controls.Add(this.label6);
            this.sptPanel.Location = new System.Drawing.Point(0, 3);
            this.sptPanel.Name = "sptPanel";
            this.sptPanel.Size = new System.Drawing.Size(340, 387);
            this.sptPanel.TabIndex = 3;
            // 
            // sptClearAllSelections
            // 
            this.sptClearAllSelections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sptClearAllSelections.AutoSize = true;
            this.sptClearAllSelections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sptClearAllSelections.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.sptClearAllSelections.ForeColor = System.Drawing.Color.DarkGray;
            this.sptClearAllSelections.Location = new System.Drawing.Point(233, 87);
            this.sptClearAllSelections.Name = "sptClearAllSelections";
            this.sptClearAllSelections.Size = new System.Drawing.Size(103, 13);
            this.sptClearAllSelections.TabIndex = 7;
            this.sptClearAllSelections.Text = "Clear all selections";
            this.sptClearAllSelections.Click += new System.EventHandler(this.sptClearAllSelections_Click);
            // 
            // sptUserList
            // 
            this.sptUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sptUserList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sptUserList.Controls.Add(this.sptUserPlaceholder);
            this.sptUserList.Location = new System.Drawing.Point(3, 108);
            this.sptUserList.Name = "sptUserList";
            this.sptUserList.Size = new System.Drawing.Size(334, 276);
            this.sptUserList.TabIndex = 6;
            // 
            // sptUserPlaceholder
            // 
            this.sptUserPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sptUserPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.sptUserPlaceholder.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.sptUserPlaceholder.ForeColor = System.Drawing.Color.DarkGray;
            this.sptUserPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.sptUserPlaceholder.Name = "sptUserPlaceholder";
            this.sptUserPlaceholder.Size = new System.Drawing.Size(332, 27);
            this.sptUserPlaceholder.TabIndex = 4;
            this.sptUserPlaceholder.Text = "dev_raccoon";
            this.sptUserPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sptUserPlaceholder.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Location:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Select the profile you wish to transfer";
            // 
            // currentPanel
            // 
            this.currentPanel.Controls.Add(this.currentCompatibility);
            this.currentPanel.Controls.Add(this.currentLocation);
            this.currentPanel.Controls.Add(this.currentBrowse);
            this.currentPanel.Controls.Add(this.label4);
            this.currentPanel.Location = new System.Drawing.Point(470, 41);
            this.currentPanel.Name = "currentPanel";
            this.currentPanel.Size = new System.Drawing.Size(414, 95);
            this.currentPanel.TabIndex = 6;
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
            // currentBrowse
            // 
            this.currentBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentBrowse.BackColor = System.Drawing.Color.DimGray;
            this.currentBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentBrowse.FlatAppearance.BorderSize = 0;
            this.currentBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentBrowse.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBrowse.ForeColor = System.Drawing.Color.LightGray;
            this.currentBrowse.Location = new System.Drawing.Point(321, 5);
            this.currentBrowse.Name = "currentBrowse";
            this.currentBrowse.Size = new System.Drawing.Size(90, 42);
            this.currentBrowse.TabIndex = 2;
            this.currentBrowse.Text = "Find";
            this.currentBrowse.UseVisualStyleBackColor = false;
            this.currentBrowse.Click += new System.EventHandler(this.currentBrowse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Your current SPT-AKI folder";
            // 
            // advancedPanel
            // 
            this.advancedPanel.Controls.Add(this.button3);
            this.advancedPanel.Controls.Add(this.button2);
            this.advancedPanel.Controls.Add(this.newPanel);
            this.advancedPanel.Controls.Add(this.sptPanel);
            this.advancedPanel.Location = new System.Drawing.Point(46, 181);
            this.advancedPanel.Name = "advancedPanel";
            this.advancedPanel.Size = new System.Drawing.Size(838, 395);
            this.advancedPanel.TabIndex = 7;
            this.advancedPanel.Visible = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(346, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Transfer →";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(346, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "← Transfer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newPanel
            // 
            this.newPanel.Controls.Add(this.newUserList);
            this.newPanel.Controls.Add(this.label3);
            this.newPanel.Controls.Add(this.label7);
            this.newPanel.Controls.Add(this.button1);
            this.newPanel.Controls.Add(this.label8);
            this.newPanel.Location = new System.Drawing.Point(498, 3);
            this.newPanel.Name = "newPanel";
            this.newPanel.Size = new System.Drawing.Size(340, 387);
            this.newPanel.TabIndex = 7;
            // 
            // newUserList
            // 
            this.newUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newUserList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newUserList.Controls.Add(this.newUserPlaceholder);
            this.newUserList.Location = new System.Drawing.Point(3, 108);
            this.newUserList.Name = "newUserList";
            this.newUserList.Size = new System.Drawing.Size(334, 276);
            this.newUserList.TabIndex = 7;
            // 
            // newUserPlaceholder
            // 
            this.newUserPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newUserPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.newUserPlaceholder.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.newUserPlaceholder.ForeColor = System.Drawing.Color.DarkGray;
            this.newUserPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.newUserPlaceholder.Name = "newUserPlaceholder";
            this.newUserPlaceholder.Size = new System.Drawing.Size(332, 27);
            this.newUserPlaceholder.TabIndex = 4;
            this.newUserPlaceholder.Text = "dev_raccoon";
            this.newUserPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newUserPlaceholder.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Supported - AKI 3.5.0";
            this.label3.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(3, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Location:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(247, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Your current SPT-AKI folder";
            // 
            // tabEasyMethod
            // 
            this.tabEasyMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEasyMethod.BackColor = System.Drawing.Color.Transparent;
            this.tabEasyMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabEasyMethod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(98)))));
            this.tabEasyMethod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.tabEasyMethod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.tabEasyMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabEasyMethod.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEasyMethod.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabEasyMethod.Location = new System.Drawing.Point(46, 126);
            this.tabEasyMethod.Name = "tabEasyMethod";
            this.tabEasyMethod.Size = new System.Drawing.Size(144, 42);
            this.tabEasyMethod.TabIndex = 8;
            this.tabEasyMethod.Text = "Easy method";
            this.tabEasyMethod.UseVisualStyleBackColor = false;
            this.tabEasyMethod.Visible = false;
            this.tabEasyMethod.Click += new System.EventHandler(this.tabEasyMethod_Click);
            // 
            // tabAdvancedMethod
            // 
            this.tabAdvancedMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAdvancedMethod.BackColor = System.Drawing.Color.Transparent;
            this.tabAdvancedMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabAdvancedMethod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(98)))));
            this.tabAdvancedMethod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.tabAdvancedMethod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.tabAdvancedMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabAdvancedMethod.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdvancedMethod.ForeColor = System.Drawing.Color.LightGray;
            this.tabAdvancedMethod.Location = new System.Drawing.Point(196, 126);
            this.tabAdvancedMethod.Name = "tabAdvancedMethod";
            this.tabAdvancedMethod.Size = new System.Drawing.Size(144, 42);
            this.tabAdvancedMethod.TabIndex = 9;
            this.tabAdvancedMethod.Text = "Advanced method";
            this.tabAdvancedMethod.UseVisualStyleBackColor = false;
            this.tabAdvancedMethod.Visible = false;
            this.tabAdvancedMethod.Click += new System.EventHandler(this.tabAdvancedMethod_Click);
            // 
            // easyPanel
            // 
            this.easyPanel.Controls.Add(this.easyServerPanel);
            this.easyPanel.Controls.Add(this.easyProfilePanel);
            this.easyPanel.Location = new System.Drawing.Point(46, 181);
            this.easyPanel.Name = "easyPanel";
            this.easyPanel.Size = new System.Drawing.Size(838, 395);
            this.easyPanel.TabIndex = 10;
            this.easyPanel.Visible = false;
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
            this.easyProfileTitle.Size = new System.Drawing.Size(309, 34);
            this.easyProfileTitle.TabIndex = 3;
            this.easyProfileTitle.Text = "Drag and drop your profiles into the box below\r\n(xxxxxxxxxxxxxxxxxxxxxxxx.json)";
            // 
            // mainSeparator
            // 
            this.mainSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSeparator.Location = new System.Drawing.Point(46, 180);
            this.mainSeparator.Name = "mainSeparator";
            this.mainSeparator.Size = new System.Drawing.Size(838, 1);
            this.mainSeparator.TabIndex = 11;
            this.mainSeparator.Visible = false;
            // 
            // easyServerPanel
            // 
            this.easyServerPanel.Controls.Add(this.easyServerCompatibility);
            this.easyServerPanel.Controls.Add(this.easyServerLocation);
            this.easyServerPanel.Controls.Add(this.easyServerFind);
            this.easyServerPanel.Controls.Add(this.easyServerTitle);
            this.easyServerPanel.Location = new System.Drawing.Point(498, 3);
            this.easyServerPanel.Name = "easyServerPanel";
            this.easyServerPanel.Size = new System.Drawing.Size(340, 387);
            this.easyServerPanel.TabIndex = 8;
            // 
            // easyServerCompatibility
            // 
            this.easyServerCompatibility.AutoSize = true;
            this.easyServerCompatibility.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.easyServerCompatibility.ForeColor = System.Drawing.Color.DodgerBlue;
            this.easyServerCompatibility.Location = new System.Drawing.Point(3, 82);
            this.easyServerCompatibility.Name = "easyServerCompatibility";
            this.easyServerCompatibility.Size = new System.Drawing.Size(146, 17);
            this.easyServerCompatibility.TabIndex = 6;
            this.easyServerCompatibility.Text = "Supported - AKI 3.5.0";
            this.easyServerCompatibility.Visible = false;
            // 
            // easyServerLocation
            // 
            this.easyServerLocation.AutoSize = true;
            this.easyServerLocation.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.easyServerLocation.ForeColor = System.Drawing.Color.DarkGray;
            this.easyServerLocation.Location = new System.Drawing.Point(3, 64);
            this.easyServerLocation.Name = "easyServerLocation";
            this.easyServerLocation.Size = new System.Drawing.Size(51, 13);
            this.easyServerLocation.TabIndex = 5;
            this.easyServerLocation.Text = "Location:";
            // 
            // easyServerFind
            // 
            this.easyServerFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.easyServerFind.BackColor = System.Drawing.Color.DimGray;
            this.easyServerFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyServerFind.FlatAppearance.BorderSize = 0;
            this.easyServerFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyServerFind.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyServerFind.ForeColor = System.Drawing.Color.LightGray;
            this.easyServerFind.Location = new System.Drawing.Point(247, 5);
            this.easyServerFind.Name = "easyServerFind";
            this.easyServerFind.Size = new System.Drawing.Size(90, 42);
            this.easyServerFind.TabIndex = 2;
            this.easyServerFind.Text = "Find";
            this.easyServerFind.UseVisualStyleBackColor = false;
            // 
            // easyServerTitle
            // 
            this.easyServerTitle.AutoSize = true;
            this.easyServerTitle.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.easyServerTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.easyServerTitle.Location = new System.Drawing.Point(3, 17);
            this.easyServerTitle.Name = "easyServerTitle";
            this.easyServerTitle.Size = new System.Drawing.Size(199, 34);
            this.easyServerTitle.TabIndex = 3;
            this.easyServerTitle.Text = "Select the server you want to\r\ntransfer your profile(s) to";
            // 
            // profileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(936, 588);
            this.Controls.Add(this.mainSeparator);
            this.Controls.Add(this.tabAdvancedMethod);
            this.Controls.Add(this.tabEasyMethod);
            this.Controls.Add(this.currentPanel);
            this.Controls.Add(this.watermarkPanel);
            this.Controls.Add(this.easyPanel);
            this.Controls.Add(this.advancedPanel);
            this.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "profileForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.profileForm_Load);
            this.watermarkPanel.ResumeLayout(false);
            this.watermarkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkIcon)).EndInit();
            this.sptPanel.ResumeLayout(false);
            this.sptPanel.PerformLayout();
            this.sptUserList.ResumeLayout(false);
            this.currentPanel.ResumeLayout(false);
            this.currentPanel.PerformLayout();
            this.advancedPanel.ResumeLayout(false);
            this.newPanel.ResumeLayout(false);
            this.newPanel.PerformLayout();
            this.newUserList.ResumeLayout(false);
            this.easyPanel.ResumeLayout(false);
            this.easyProfilePanel.ResumeLayout(false);
            this.easyProfilePanel.PerformLayout();
            this.easyProfileUserList.ResumeLayout(false);
            this.easyServerPanel.ResumeLayout(false);
            this.easyServerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel watermarkPanel;
        private System.Windows.Forms.Label watermarkCompatibility;
        private System.Windows.Forms.PictureBox watermarkIcon;
        private System.Windows.Forms.Label watermarkTitle;
        private System.Windows.Forms.Panel sptPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel currentPanel;
        private System.Windows.Forms.Label currentLocation;
        private System.Windows.Forms.Button currentBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel sptUserList;
        private System.Windows.Forms.Label currentCompatibility;
        private System.Windows.Forms.Panel advancedPanel;
        private System.Windows.Forms.Label sptUserPlaceholder;
        private System.Windows.Forms.Panel newPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel newUserList;
        private System.Windows.Forms.Label newUserPlaceholder;
        private System.Windows.Forms.Label sptClearAllSelections;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button tabEasyMethod;
        private System.Windows.Forms.Button tabAdvancedMethod;
        private System.Windows.Forms.Panel easyPanel;
        private System.Windows.Forms.Panel easyProfilePanel;
        private System.Windows.Forms.Label easyProfileClearAllSelections;
        private System.Windows.Forms.Panel easyProfileUserList;
        private System.Windows.Forms.Label easyProfileUserPlaceholder;
        private System.Windows.Forms.Label easyProfileLocation;
        private System.Windows.Forms.Label easyProfileTitle;
        private System.Windows.Forms.Panel mainSeparator;
        private System.Windows.Forms.Panel easyServerPanel;
        private System.Windows.Forms.Label easyServerCompatibility;
        private System.Windows.Forms.Label easyServerLocation;
        private System.Windows.Forms.Button easyServerFind;
        private System.Windows.Forms.Label easyServerTitle;
    }
}

