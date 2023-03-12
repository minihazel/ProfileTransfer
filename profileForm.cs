using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        public string fromFolder;
        public string toFolder;

        public bool isEasy = true;

        public profileForm()
        {
            InitializeComponent();
        }

        private void profileForm_Load(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            constructionTimer.Start();
            
            /*
            string akiServer = Path.Combine(currentDir, "Aki.Server.exe");
            string akiLauncher = Path.Combine(currentDir, "Aki.Launcher.exe");

            if (File.Exists(akiServer) && File.Exists(akiLauncher))
            {
                // SPT installation is in the same folder as the app
                string fullPath = currentDir;
                fromFolder = fullPath;
                isEasy = true;
                // showOptions();
            }
            else
            {
                MessageBox.Show("It appears that you haven\'t placed ProfileFusion in an SPT folder. Please do so and try again." +
                    "\n\n" +
                    "For instructions, please refer to the Workshop page.", "SPT installation not detected", MessageBoxButtons.OK);
                Application.Exit();
            }
            */
        }

        public void showOptions()
        {
            if (isEasy)
            {
                listProfiles(fromFolder, true);
                constructionTimer.Start();
            }
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
                fromFolder = fullPath;

                panelNewOptions.Visible = true;
                // showOptions();
            }
        }

        public void listProfiles(string serverPath, bool isFrom)
        {
            if (isFrom)
            {
                string profilesFolder = Path.Combine(serverPath, "user\\profiles");
                string[] profiles = Directory.GetFiles(profilesFolder);
                if (profiles.Length > 0)
                {
                    for (int i = 0; i < profiles.Length; i++)
                    {
                        try
                        {
                            string activeProfile = Path.Combine(profilesFolder, profiles[i]);
                            string readProfile = File.ReadAllText(activeProfile);
                            JObject parseProfile = JObject.Parse(readProfile);
                            string nickname = parseProfile["characters"]["pmc"]["Info"]["Nickname"].ToString();

                            Label profile = new Label();
                            profile.Name = $"user{i}";
                            profile.AutoSize = false;
                            profile.Cursor = Cursors.Hand;
                            profile.Location = new System.Drawing.Point(easyProfileUserPlaceholder.Location.X, easyProfileUserPlaceholder.Location.Y + (i * 27));
                            profile.Size = new System.Drawing.Size(easyProfileUserPlaceholder.Size.Width, easyProfileUserPlaceholder.Size.Height);
                            profile.BackColor = idleColor;
                            profile.ForeColor = Color.DarkGray;
                            profile.Font = new Font("Bahnschrift Light", 10, FontStyle.Regular);
                            profile.Visible = true;
                            profile.TextAlign = ContentAlignment.MiddleLeft;
                            profile.MouseEnter += new EventHandler(originalProfile_MouseEnter);
                            profile.MouseLeave += new EventHandler(originalProfile_MouseLeave);
                            profile.MouseDown += new MouseEventHandler(originalProfile_MouseDown);
                            profile.MouseUp += new MouseEventHandler(originalProfile_MouseUp);

                            JArray areas = (JArray)parseProfile["characters"]["pmc"]["Hideout"]["Areas"];
                            bool allConstructingFalse = areas.All(area => (bool)area["constructing"] == false);
                            if (allConstructingFalse)
                            {
                                profile.Text = nickname;
                            }
                            else
                            {
                                profile.Text = $"{nickname} [Construction in progress]";
                            }
                            panelProfilesList.Controls.Add(profile);
                            // nameNewServer.Text = Path.GetFileName(serverPath);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"ERROR: {ex}");
                            MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{ex.Message.ToString()}", this.Text, MessageBoxButtons.OK);
                        }
                        
                    }
                }
            }
            else
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

                        Label profile = new Label();
                        profile.Name = $"user{i}";
                        profile.AutoSize = false;
                        profile.Cursor = Cursors.Hand;
                        profile.Location = new System.Drawing.Point(panelProfilesPlaceholder.Location.X, panelProfilesPlaceholder.Location.Y + (i * 27));
                        profile.Size = new System.Drawing.Size(panelProfilesPlaceholder.Size.Width, panelProfilesPlaceholder.Size.Height);
                        profile.BackColor = idleColor;
                        profile.ForeColor = Color.DarkGray;
                        profile.Font = new Font("Bahnschrift Light", 10, FontStyle.Regular);
                        profile.Visible = true;
                        profile.TextAlign = ContentAlignment.MiddleLeft;
                        profile.MouseEnter += new EventHandler(originalProfile_MouseEnter);
                        profile.MouseLeave += new EventHandler(originalProfile_MouseLeave);
                        profile.MouseDown += new MouseEventHandler(originalProfile_MouseDown);
                        profile.MouseUp += new MouseEventHandler(originalProfile_MouseUp);

                        profile.Text = nickname;
                        panelProfileNamesList.Controls.Add(profile);
                    }
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
            foreach (Control component in panelProfilesList.Controls)
            {
                if (component is Label)
                {
                    component.BackColor = idleColor;
                }
            }
        }

        private void tabEasyMethod_Click(object sender, EventArgs e)
        {
            watermarkPanel.Select();

            panelTransferFreely.SendToBack();
            panelTransferTo.BringToFront();
            tabTransferTo.ForeColor = Color.DodgerBlue;
            tabTransferFrom.ForeColor = Color.LightGray;

            showOptions();
        }

        private void tabAdvancedMethod_Click(object sender, EventArgs e)
        {
            watermarkPanel.Select();

            panelTransferTo.SendToBack();
            panelTransferFreely.BringToFront();
            tabTransferFrom.ForeColor = Color.DodgerBlue;
            tabTransferTo.ForeColor = Color.LightGray;
        }

        private void easyProfileClearAllSelections_Click(object sender, EventArgs e)
        {
            foreach (Control component in easyProfileUserList.Controls)
            {
                if (component is Label)
                {
                    component.BackColor = idleColor;
                }
            }
        }

        public void constructionTimer_Tick(object sender, EventArgs e)
        {
            if (panelFromLocation.Text != "")
            {
                // From panel
                List<string> fromProfiles = new List<string>();
                foreach (Control component in panelProfilesList.Controls)
                {
                    if (component is Label && component.BackColor == selectColor && component.Text.ToLower().Contains("construction in progress"))
                    {
                        fromProfiles.Add($"- {component.Text.Replace(" [Construction in progress]", "")}");
                    }
                }
                if (fromProfiles.Count > 0)
                {
                    transferRight.Enabled = false;
                }
                else if (fromProfiles.Count == 0)
                {
                    transferRight.Enabled = true;
                }
            }

            /*
            List<string> conflictingProfiles = new List<string>();

            foreach (Control component in easyProfileUserList.Controls)
            {
                if (component is Label && component.BackColor == selectColor && component.Text.ToLower().Contains("construction in progress"))
                {
                    conflictingProfiles.Add($"- {component.Text.Replace(" [Construction in progress]", "")}");
                }
            }

            if (conflictingProfiles.Count > 0)
            {
                string result = string.Join(Environment.NewLine, conflictingProfiles);
                newOptionsWarning.Text = "Swapping has been disabled, please unselect the following profile(s):" +
                    "\n\n" +
                    $"{result}";

                newOptionsTransfer.Enabled = false;
            }
            else if (conflictingProfiles.Count == 0)
            {
                newOptionsWarning.Text = "";
                newOptionsTransfer.Enabled = true;
            }
            */
        }

        private void panelFromBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ValidateNames = false;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = false;
            ofd.FileName = "Enter the folder and click Open";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fullPath = Path.GetDirectoryName(ofd.FileName);
                panelFromLocation.Text = fullPath;
                fromFolder = fullPath;

                listProfiles(fromFolder, true);
                constructionTimer.Start();
                // panelNewOptions.Visible = true;
                // showOptions();
            }
        }

        private void panelToBrowse_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ValidateNames = false;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = false;
            ofd.FileName = "Enter the folder and click Open";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fullPath = Path.GetDirectoryName(ofd.FileName);
                panelToLocation.Text = fullPath;
                toFolder = fullPath;

                listProfiles(toFolder, false);
                constructionTimer.Start();
            }
            */
        }

        private void panelFromClear_MouseEnter(object sender, EventArgs e)
        {
            panelFromClear.ForeColor = Color.DodgerBlue;
        }

        private void panelFromClear_MouseLeave(object sender, EventArgs e)
        {
            panelFromClear.ForeColor = Color.LightGray;
        }

        public void clearLeftUI()
        {
            for (int i = panelProfilesList.Controls.Count - 1; i >= 0; i--)
            {
                Label selected = panelProfilesList.Controls[i] as Label;
                if (selected != null)
                {
                    try
                    {
                        panelProfilesList.Controls.RemoveAt(i);
                        selected.Dispose();
                    }
                    catch (Exception err)
                    {
                        Debug.WriteLine($"ERROR: {err.Message.ToString()}");
                        MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{err.Message.ToString()}", this.Text, MessageBoxButtons.OK);
                    }
                }
            }

            panelFromLocation.Text = "";
        }

        public void clearRightUI()
        {
            for (int i = panelProfileNamesList.Controls.Count - 1; i >= 0; i--)
            {
                Label selected = panelProfileNamesList.Controls[i] as Label;
                if (selected != null)
                {
                    try
                    {
                        panelProfileNamesList.Controls.RemoveAt(i);
                        selected.Dispose();
                    }
                    catch (Exception err)
                    {
                        Debug.WriteLine($"ERROR: {err.Message.ToString()}");
                        MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{err.Message.ToString()}", this.Text, MessageBoxButtons.OK);
                    }
                }
            }
        }

        /*
        public void TransferProfile(bool method)
        {
            // true = from
            // false = to

            if (method)
            {
                int copies = 0;
                int failedCopies = 0;
                List<string> successfulCopies = new List<string>();
                List<string> failedAttempts = new List<string>();

                foreach (Control profile in panelProfiles.Controls)
                {
                    if (profile is Label && profile.BackColor == selectColor)
                    {
                        if (!profile.Text.Contains("[Construction in progress]"))
                        {

                            string matchedName = "";
                            string fromProfile = "";
                            bool hasConflict = false;

                            string fromServer = panelFromLocation.Text;
                            string fromUserFolder = Path.Combine(fromServer, "user\\profiles");
                            string[] fromProfiles = Directory.GetFiles(fromUserFolder);
                            foreach (string p in fromProfiles)
                            {
                                string fromReadProfile = File.ReadAllText(p);
                                JObject fromParseProfile = JObject.Parse(fromReadProfile);
                                string fromNickname = fromParseProfile["characters"]["pmc"]["Info"]["Nickname"].ToString();

                                if (profile.Text == fromNickname)
                                {
                                    matchedName = fromNickname;
                                    fromProfile = Path.GetFullPath(p);
                                    break;
                                }
                            }



                            string toServer = panelToLocation.Text;
                            string toUserFolder = Path.Combine(toServer, "user\\profiles");
                            string[] toProfiles = Directory.GetFiles(toUserFolder);
                            foreach (string p in toProfiles)
                            {
                                string toReadProfile = File.ReadAllText(p);
                                JObject toParseProfile = JObject.Parse(toReadProfile);
                                string toNickname = toParseProfile["characters"]["pmc"]["Info"]["Nickname"].ToString();

                                if (profile.Text == toNickname)
                                {
                                    hasConflict = true;
                                    break;
                                }
                            }



                            if (matchedName != "" && !hasConflict)
                            {
                                try
                                {
                                    string newProfile = Path.Combine(toUserFolder, Path.GetFileName(fromProfile));
                                    File.Copy(fromProfile, newProfile);
                                    successfulCopies.Add(profile.Text);
                                    copies++;

                                    clearRightUI();
                                    listProfiles(toServer, false);
                                }
                                catch (Exception ex)
                                {
                                    Debug.WriteLine($"ERROR: {ex}");
                                    MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{ex.Message.ToString()}", this.Text, MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Swapping is only allowed with profiles that have no areas in construction!", "ProfileFusion", MessageBoxButtons.OK);
                        }
                    }
                }

                string result = string.Join("\n- ", successfulCopies);

                if (copies == 1)
                {
                    string message = $"{copies} profile copied" +
                        $"\n" +
                        $"- {result}";
                }
                else if (copies > 1)
                {
                    string message = $"{copies} profiles copied" +
                        $"\n" +
                        $"- {result}";
                }
                else
                {
                    MessageBox.Show("Please select one or more profiles to transfer first.", "ProfileFusion", MessageBoxButtons.OK);
                }
            }
            else
            {
                int copies = 0;
                int failedCopies = 0;
                List<string> successfulCopies = new List<string>();
                List<string> failedAttempts = new List<string>();

                foreach (Control profile in panelProfileNames.Controls)
                {
                    if (profile is Label && profile.BackColor == selectColor)
                    {
                        if (!profile.Text.Contains("[Construction in progress]"))
                        {

                            string matchedName = "";
                            string toProfile = "";
                            bool hasConflict = false;

                            string toServer = panelToLocation.Text;
                            string toUserFolder = Path.Combine(toServer, "user\\profiles");
                            string[] toProfiles = Directory.GetFiles(toUserFolder);
                            foreach (string p in toProfiles)
                            {
                                string toReadProfile = File.ReadAllText(p);
                                JObject toParseProfile = JObject.Parse(toReadProfile);
                                string toNickname = toParseProfile["characters"]["pmc"]["Info"]["Nickname"].ToString();

                                if (profile.Text == toNickname)
                                {
                                    matchedName = toNickname;
                                    toProfile = Path.GetFullPath(p);
                                }
                            }



                            string fromServer = panelFromLocation.Text;
                            string fromUserFolder = Path.Combine(fromServer, "user\\profiles");
                            string[] fromProfiles = Directory.GetFiles(fromUserFolder);
                            foreach (string p in fromProfiles)
                            {
                                string fromReadProfile = File.ReadAllText(p);
                                JObject fromParseProfile = JObject.Parse(fromReadProfile);
                                string fromNickname = fromParseProfile["characters"]["pmc"]["Info"]["Nickname"].ToString();

                                if (profile.Text == fromNickname)
                                {
                                    hasConflict = true;
                                    failedCopies++;
                                    failedAttempts.Add(profile.Text);
                                }
                            }



                            if (matchedName != "" && failedCopies == 0)
                            {
                                try
                                {
                                    string newProfile = Path.Combine(toUserFolder, Path.GetFileName(toProfile));
                                    File.Copy(toProfile, newProfile);
                                    successfulCopies.Add(profile.Text);
                                    copies++;

                                    clearLeftUI();
                                    listProfiles(fromServer, true);
                                }
                                catch (Exception ex)
                                {
                                    Debug.WriteLine($"ERROR: {ex}");
                                    MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{ex.Message.ToString()}", this.Text, MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Swapping is only allowed with profiles that have no areas in construction!", "ProfileFusion", MessageBoxButtons.OK);
                        }
                    }
                }

                string message = "";
                string result = string.Join("\n- ", successfulCopies);

                if (failedCopies > 0)
                {
                    string failedResult = string.Join("\n- ", failedAttempts);
                    message = $"{failedCopies} profiles failed to transfer" +
                        $"\n" +
                        $"{failedResult}";
                }
                else if (copies == 1)
                {
                    message = $"{copies} profile copied" +
                        $"\n" +
                        $"{result}";
                }
                else if (copies > 1)
                {
                    message = $"{copies} profiles copied" +
                        $"\n" +
                        $"{result}";
                }
                else
                {
                    MessageBox.Show("Please select one or more profiles to transfer first.", "ProfileFusion", MessageBoxButtons.OK);
                }
            }
        }
        */

        private void transferRight_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to transfer these profiles?", "ProfileFusion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //TransferProfile(true);
            }
        }

        private void transferLeft_Click(object sender, EventArgs e)
        {

        }

        private void profileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            constructionTimer.Stop();
        }

        private void profileForm_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void profileForm_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void profileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelFromList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        public void insertProfiles(string[] profileArray)
        {
            int numLabels = panelProfilesList.Controls.OfType<Label>().Count(lbl => lbl.Name.StartsWith("insertedProfile"));
            int numLabels2 = panelProfileNamesList.Controls.OfType<Label>().Count(lbl => lbl.Name.StartsWith("insertedNickname"));

            if (numLabels > 0)
            {
                Label lastLabel = panelProfilesList.Controls.OfType<Label>()
                    .Where(lbl => lbl.Name.StartsWith("insertedProfile"))
                    .OrderByDescending(lbl => lbl.TabIndex)
                    .First();

                int plastLocationX = lastLabel.Location.X;
                int plastLocationY = lastLabel.Location.Y;

                Label p2lastLabel = panelProfileNamesList.Controls.OfType<Label>()
                    .Where(lbl => lbl.Name.StartsWith("insertedNickname"))
                    .OrderByDescending(lbl => lbl.TabIndex)
                    .First();

                int p2lastLocationX = p2lastLabel.Location.X;
                int p2lastLocationY = p2lastLabel.Location.Y;


                if (profileArray.Length > 0)
                {
                    for (int i = 0; i < profileArray.Length; i++)
                    {
                        try
                        {
                            bool activeProfile = File.Exists(profileArray[i]);

                            if (activeProfile)
                            {
                                string readProfile = File.ReadAllText(profileArray[i]);
                                JObject parseProfile = JObject.Parse(readProfile);

                                string nickname = parseProfile["characters"]["pmc"]["Info"]["Nickname"].ToString();
                                string faction = parseProfile["characters"]["pmc"]["Info"]["Side"].ToString();
                                string level = parseProfile["characters"]["pmc"]["Info"]["Level"].ToString();
                                string profilePath = profileArray[i];


                                Label profile = new Label();
                                profile.Name = $"insertedProfile{i}";
                                profile.AutoSize = false;
                                profile.Cursor = Cursors.Hand;
                                profile.Location = new System.Drawing.Point(plastLocationX, plastLocationY + (i * 27));
                                profile.Size = new System.Drawing.Size(lastLabel.Size.Width, lastLabel.Size.Height);
                                profile.BackColor = idleColor;
                                profile.ForeColor = Color.DarkGray;
                                profile.Font = new Font("Bahnschrift Light", 8, FontStyle.Regular);
                                profile.Visible = true;
                                profile.TextAlign = ContentAlignment.MiddleLeft;
                                profile.MouseEnter += new EventHandler(originalProfile_MouseEnter);
                                profile.MouseLeave += new EventHandler(originalProfile_MouseLeave);
                                profile.MouseDown += new MouseEventHandler(originalProfile_MouseDown);
                                profile.MouseUp += new MouseEventHandler(originalProfile_MouseUp);
                                profile.Text = profileArray[i];



                                Label profileNickname = new Label();
                                profileNickname.Name = $"insertedNickname{i}";
                                profileNickname.AutoSize = false;
                                profileNickname.Cursor = Cursors.Hand;
                                profileNickname.Location = new System.Drawing.Point(p2lastLocationX, p2lastLocationY + (i * 27));
                                profileNickname.Size = new System.Drawing.Size(p2lastLabel.Size.Width, p2lastLabel.Size.Height);
                                profileNickname.BackColor = idleColor;
                                profileNickname.ForeColor = Color.DarkGray;
                                profileNickname.Font = new Font("Bahnschrift Light", 10, FontStyle.Regular);
                                profileNickname.Visible = true;
                                profileNickname.TextAlign = ContentAlignment.MiddleLeft;
                                profileNickname.MouseEnter += new EventHandler(originalProfile_MouseEnter);
                                profileNickname.MouseLeave += new EventHandler(originalProfile_MouseLeave);

                                JArray areas = (JArray)parseProfile["characters"]["pmc"]["Hideout"]["Areas"];
                                bool allConstructingFalse = areas.All(area => (bool)area["constructing"] == false);
                                if (allConstructingFalse)
                                {
                                    profileNickname.Text = $"{nickname} [Level {level} | {faction}]";
                                }
                                else
                                {
                                    profileNickname.Text = $"{nickname} [Construction in progress]";
                                }


                                panelProfilesList.Controls.Add(profile);
                                panelProfileNamesList.Controls.Add(profileNickname);
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"ERROR: {ex}");
                            MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{ex.Message.ToString()}", this.Text, MessageBoxButtons.OK);
                        }

                    }
                }
            }
            else
            {
                if (profileArray.Length > 0)
                {
                    for (int i = 0; i < profileArray.Length; i++)
                    {
                        try
                        {
                            bool activeProfile = File.Exists(profileArray[i]);

                            if (activeProfile)
                            {
                                string readProfile = File.ReadAllText(profileArray[i]);
                                JObject parseProfile = JObject.Parse(readProfile);

                                string nickname = parseProfile["characters"]["pmc"]["Info"]["Nickname"].ToString();
                                string faction = parseProfile["characters"]["pmc"]["Info"]["Side"].ToString();
                                string level = parseProfile["characters"]["pmc"]["Info"]["Level"].ToString();
                                string profilePath = profileArray[i];


                                Label profile = new Label();
                                profile.Name = $"insertedProfile{i}";
                                profile.AutoSize = false;
                                profile.Cursor = Cursors.Hand;
                                profile.Location = new System.Drawing.Point(panelProfilesPlaceholder.Location.X, panelProfilesPlaceholder.Location.Y + (i * 27));
                                profile.Size = new System.Drawing.Size(panelProfilesPlaceholder.Size.Width, panelProfilesPlaceholder.Size.Height);
                                profile.BackColor = idleColor;
                                profile.ForeColor = Color.DarkGray;
                                profile.Font = new Font("Bahnschrift Light", 8, FontStyle.Regular);
                                profile.Visible = true;
                                profile.TextAlign = ContentAlignment.MiddleLeft;
                                profile.MouseEnter += new EventHandler(originalProfile_MouseEnter);
                                profile.MouseLeave += new EventHandler(originalProfile_MouseLeave);
                                profile.MouseDown += new MouseEventHandler(originalProfile_MouseDown);
                                profile.MouseUp += new MouseEventHandler(originalProfile_MouseUp);
                                profile.Text = profileArray[i];



                                Label profileNickname = new Label();
                                profileNickname.Name = $"insertedNickname{i}";
                                profileNickname.AutoSize = false;
                                profileNickname.Cursor = Cursors.Hand;
                                profileNickname.Location = new System.Drawing.Point(panelProfileNamesPlaceholder.Location.X, panelProfileNamesPlaceholder.Location.Y + (i * 27));
                                profileNickname.Size = new System.Drawing.Size(panelProfileNamesPlaceholder.Size.Width, panelProfileNamesPlaceholder.Size.Height);
                                profileNickname.BackColor = idleColor;
                                profileNickname.ForeColor = Color.DarkGray;
                                profileNickname.Font = new Font("Bahnschrift Light", 10, FontStyle.Regular);
                                profileNickname.Visible = true;
                                profileNickname.TextAlign = ContentAlignment.MiddleLeft;
                                profileNickname.MouseEnter += new EventHandler(originalProfile_MouseEnter);
                                profileNickname.MouseLeave += new EventHandler(originalProfile_MouseLeave);

                                JArray areas = (JArray)parseProfile["characters"]["pmc"]["Hideout"]["Areas"];
                                bool allConstructingFalse = areas.All(area => (bool)area["constructing"] == false);
                                if (allConstructingFalse)
                                {
                                    profileNickname.Text = $"{nickname} [Level {level} | {faction}]";
                                }
                                else
                                {
                                    profileNickname.Text = $"{nickname} [Construction in progress]";
                                }


                                panelProfileNamesList.Controls.Add(profileNickname);
                                panelProfilesList.Controls.Add(profile);
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"ERROR: {ex}");
                            MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{ex.Message.ToString()}", this.Text, MessageBoxButtons.OK);
                        }

                    }
                }
            }
        }

        private void panelFromList_DragDrop(object sender, DragEventArgs e)
        {
            List<string> arr = new List<string>();

            string[] items = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (items.Length > 0)
            {
                FileAttributes attr = File.GetAttributes(items[0]);
                if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
                {
                    foreach (string profile in items)
                    {
                        string path = Path.GetFullPath(profile);
                        arr.Add(path);
                    }
                }
                /*
                else
                {
                    clearLeftUI();

                    string fullPath = items[0];
                    panelFromLocation.Text = fullPath;
                    fromFolder = fullPath;

                    listProfiles(fromFolder, true);
                    constructionTimer.Start();
                }
                */
            }
            else
            {
                MessageBox.Show("Please only drag-and-drop one folder at a time.", "ProfileFusion", MessageBoxButtons.OK);
            }

            if (arr.Count > 0)
            {
                string[] profiles = arr.ToArray();
                insertProfiles(profiles);
            }
        }

        private void panelToList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panelToList_DragDrop(object sender, DragEventArgs e)
        {
            /*
            string[] items = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (items.Length > 1)
            {
                MessageBox.Show("Please only drag-and-drop one folder at a time.", "ProfileFusion", MessageBoxButtons.OK);
            }
            else
            {
                FileAttributes attr = File.GetAttributes(items[0]);
                if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
                {
                    MessageBox.Show("Please only drag-and-drop SPT folders", "ProfileFusion", MessageBoxButtons.OK);
                }
                else
                {
                    clearRightUI();

                    string fullPath = items[0];
                    panelToLocation.Text = fullPath;
                    toFolder = fullPath;

                    listProfiles(toFolder, false);
                    constructionTimer.Start();
                }
            }
            */
        }

        private void panelFromLocation_Click(object sender, EventArgs e)
        {
            if (panelFromLocation.Text.Length > 0)
            {
                if (Directory.Exists(panelFromLocation.Text))
                {
                    Process.Start("explorer.exe", panelFromLocation.Text);
                }
                else
                {
                    MessageBox.Show("It appears that we cannot find this folder. Check that the folder exists and try again.", "ProfileFusion", MessageBoxButtons.OK);
                }
            }
        }

    }
}
