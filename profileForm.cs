using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProfileTransfer
{
    public partial class profileForm : Form
    {
        public Color idleColor = Color.FromArgb(255, 35, 35, 40);
        public Color hoverColor = Color.FromArgb(255, 40, 40, 50);
        public Color selectColor = Color.FromArgb(255, 50, 50, 60);

        public string akiCore;
        public string currentFolder;

        public profileForm()
        {
            InitializeComponent();
        }

        private void profileForm_Load(object sender, EventArgs e)
        {

        }

        private void currentBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ValidateNames = false;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = false;
            ofd.FileName = "Enter the folder and select Open";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fullPath = Path.GetDirectoryName(ofd.FileName);
                currentLocation.Text = $"Location: {fullPath}";
                currentFolder = fullPath;

                listProfiles(fullPath);
                centralPanel.Visible = true;
            }
        }

        public void listProfiles(string serverPath)
        {
            string profilesFolder = Path.Combine(serverPath, "user\\profiles");
            string[] profiles = Directory.GetFiles(profilesFolder);
            if (profiles.Length > 0)
            {
                for (int i = 0; i < profiles.Length; i++)
                {
                    string activeProfile = Path.Combine(profilesFolder, profiles[i]);
                    string readProfile = File.ReadAllText(activeProfile);
                    JObject parseProfile = JObject.Parse(readProfile);
                    string nickname = parseProfile["characters"]["pmc"]["Info"]["Nickname"].ToString();
                    string level = parseProfile["characters"]["pmc"]["Info"]["Level"].ToString();
                    string faction = parseProfile["characters"]["pmc"]["Info"]["Side"].ToString().ToUpper();

                    Label profile = new Label();
                    profile.Name = $"user{i}";
                    profile.AutoSize = false;
                    profile.Cursor = Cursors.Hand;
                    profile.Location = new System.Drawing.Point(sptUserPlaceholder.Location.X, sptUserPlaceholder.Location.Y + (i * 27));
                    profile.Size = new System.Drawing.Size(sptUserPlaceholder.Size.Width, sptUserPlaceholder.Size.Height);
                    profile.BackColor = idleColor;
                    profile.ForeColor = Color.DarkGray;
                    profile.Font = new Font("Bahnschrift Light", 10, FontStyle.Regular);
                    profile.Visible = true;
                    profile.TextAlign = ContentAlignment.MiddleLeft;
                    profile.MouseEnter += new EventHandler(originalProfile_MouseEnter);
                    profile.MouseLeave += new EventHandler(originalProfile_MouseLeave);
                    profile.MouseDown += new MouseEventHandler(originalProfile_MouseDown);
                    profile.MouseUp += new MouseEventHandler(originalProfile_MouseUp);

                    profile.Text = $"{nickname}  (Level {level} | {faction})";
                    sptUserList.Controls.Add(profile);
                }
            }
        }

        public void originalProfile_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor == idleColor)
                {
                    label.BackColor = hoverColor;
                }
                else if (label.BackColor == selectColor)
                {
                    label.BackColor = selectColor;
                }
            }
        }

        public void originalProfile_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor == hoverColor)
                {
                    label.BackColor = idleColor;
                }
                else if (label.BackColor == selectColor)
                {
                    label.BackColor = selectColor;
                }
            }
        }

        public void originalProfile_MouseDown(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor == hoverColor)
                {
                    label.BackColor = selectColor;
                }
                else if (label.BackColor == selectColor)
                {
                    label.BackColor = hoverColor;
                }
            }
        }

        public void originalProfile_MouseUp(object sender, EventArgs e)
        {
            Label label = (Label)sender;
        }

        private void sptClearAllSelections_Click(object sender, EventArgs e)
        {
            foreach (Control component in sptUserList.Controls)
            {
                if (component is Label)
                {
                    component.BackColor = idleColor;
                }
            }
        }
    }
}
