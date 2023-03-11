namespace ProfileTransfer
{
    partial class selectionForm
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
            this.selectLeft = new System.Windows.Forms.Button();
            this.selectRight = new System.Windows.Forms.Button();
            this.selectedPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectLeft
            // 
            this.selectLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectLeft.BackColor = System.Drawing.Color.Transparent;
            this.selectLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(98)))));
            this.selectLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.selectLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.selectLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectLeft.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLeft.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectLeft.Location = new System.Drawing.Point(12, 26);
            this.selectLeft.Name = "selectLeft";
            this.selectLeft.Size = new System.Drawing.Size(357, 42);
            this.selectLeft.TabIndex = 10;
            this.selectLeft.Text = "← Left side";
            this.selectLeft.UseVisualStyleBackColor = false;
            this.selectLeft.Click += new System.EventHandler(this.selectLeft_Click);
            // 
            // selectRight
            // 
            this.selectRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectRight.BackColor = System.Drawing.Color.Transparent;
            this.selectRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(98)))));
            this.selectRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.selectRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.selectRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectRight.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRight.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectRight.Location = new System.Drawing.Point(12, 74);
            this.selectRight.Name = "selectRight";
            this.selectRight.Size = new System.Drawing.Size(357, 42);
            this.selectRight.TabIndex = 11;
            this.selectRight.Text = "Right side →";
            this.selectRight.UseVisualStyleBackColor = false;
            this.selectRight.Click += new System.EventHandler(this.selectRight_Click);
            // 
            // selectedPath
            // 
            this.selectedPath.AutoSize = true;
            this.selectedPath.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.selectedPath.Location = new System.Drawing.Point(9, 6);
            this.selectedPath.Name = "selectedPath";
            this.selectedPath.Size = new System.Drawing.Size(85, 17);
            this.selectedPath.TabIndex = 12;
            this.selectedPath.Text = "Placeholder";
            this.selectedPath.Visible = false;
            // 
            // selectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(381, 142);
            this.Controls.Add(this.selectedPath);
            this.Controls.Add(this.selectRight);
            this.Controls.Add(this.selectLeft);
            this.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "selectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select side";
            this.Load += new System.EventHandler(this.selectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedPath;
        public System.Windows.Forms.Button selectLeft;
        public System.Windows.Forms.Button selectRight;
    }
}