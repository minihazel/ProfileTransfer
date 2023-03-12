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
        public Color conflictingColor = Color.IndianRed;

        public string akiCore;
        public string fromFolder;
        public string toFolder;

        public bool isEasy = true;
        public bool noSelectedProfiles = false;

        public profileForm()
        {
            InitializeComponent();
        }

        private void profileForm_Load(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            bool akiServer = File.Exists(Path.Combine(currentDir, "Aki.Server.exe"));
            bool akiLauncher = File.Exists(Path.Combine(currentDir, "Aki.Launcher.exe"));

            if (!akiServer || !akiLauncher)
            {
                MessageBox.Show("We couldn\'t find the Aki server or launcher, please place ProfileFusion in your NEW SPT folder and try again." +
                    "\n\n\n" +
                    "For instructions, please refer to the Workshop page.", "ProfileFusion", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
            {
                serverLocation.Text = Path.Combine(currentDir, "user\\profiles");
                constructionTimer.Start();
            }
            
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
            if (MessageBox.Show("Clear all profiles?", "ProfileFusion", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            if (serverLocation.Text != "")
            {
                bool noLabelHasBackColor = !panelProfilesList.Controls.OfType<Label>().Any(label => label.BackColor == selectColor);
                if (noLabelHasBackColor)
                {
                    noSelectedProfiles = true;
                }
                else
                {
                    noSelectedProfiles = false;
                }

                /*
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
                    transferAll.Enabled = false;
                }
                else if (fromProfiles.Count == 0)
                {
                    transferAll.Enabled = true;
                }
                */
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
            /*
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ValidateNames = false;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = false;
            ofd.FileName = "Enter the folder and click Open";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fullPath = Path.GetDirectoryName(ofd.FileName);
                serverLocation.Text = fullPath;
                fromFolder = fullPath;

                listProfiles(fromFolder, true);
                constructionTimer.Start();
                // panelNewOptions.Visible = true;
                // showOptions();
            }
            */
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
            panelClearAllProfiles.ForeColor = Color.DodgerBlue;
        }

        private void panelFromClear_MouseLeave(object sender, EventArgs e)
        {
            panelClearAllProfiles.ForeColor = Color.LightGray;
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

            serverLocation.Text = "";
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

        public void transferAllProfiles(string profilesDirectory)
        {
            int successfulAttempts = 0;
            int duplicateAttempts = 0;
            int failedAttempts = 0;

            List<string> successfulProfiles = new List<string>();
            List<string> duplicateProfiles = new List<string>();
            List<string> conflictingProfiles = new List<string>();

            foreach (Control component in panelProfilesList.Controls)
            {
                if (component is Label)
                {
                    if (component.ForeColor != conflictingColor && component.BackColor == selectColor)
                    {
                        string profileFile = Path.GetFileName(component.Text);
                        bool profileExists = Directory.GetFiles(profilesDirectory).Any(filePath => Path.GetFileName(filePath) == profileFile);

                        if (!profileExists)
                        {
                            try
                            {
                                string readProfile = File.ReadAllText(component.Text);
                                JObject parseProfile = JObject.Parse(readProfile);
                                string nickname = parseProfile["characters"]["pmc"]["Info"]["Nickname"].ToString();

                                bool containsNick = panelProfileNamesList.Controls.OfType<Label>().Any(lbl => lbl.Text == nickname);

                                if (!containsNick)
                                {
                                    File.Copy(component.Text, Path.Combine(profilesDirectory, profileFile));
                                    successfulProfiles.Add(nickname);
                                    successfulAttempts++;
                                }
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine($"ERROR: {ex}");
                                MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{ex.Message.ToString()}", this.Text, MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            string readProfile = File.ReadAllText(component.Text);
                            JObject parseProfile = JObject.Parse(readProfile);
                            string nickname = parseProfile["characters"]["pmc"]["Info"]["Nickname"].ToString();

                            duplicateProfiles.Add(nickname);
                            duplicateAttempts++;
                        }
                    }
                    else if (component.ForeColor == conflictingColor)
                    {
                        if (component.BackColor == selectColor)
                        {
                            string readProfile = File.ReadAllText(component.Text);
                            JObject parseProfile = JObject.Parse(readProfile);
                            string nickname = parseProfile["characters"]["pmc"]["Info"]["Nickname"].ToString();
                            conflictingProfiles.Add(nickname);
                            failedAttempts++;
                        }
                        continue;
                    }
                }
            }

            if (successfulAttempts > 0)
            {
                if (serverLocation.Text != "")
                {
                    string userFolder = Path.GetDirectoryName(serverLocation.Text);
                    string baseFolder = Path.GetDirectoryName(userFolder);

                    string result = $"Successfully transferred {successfulAttempts} profile to SPT install {Path.GetFileName(baseFolder)}:\n\n";

                    if (successfulProfiles.Count == 1)
                    {
                        result += $"- {string.Join("", successfulProfiles)}\n\n";
                    }
                    else if (successfulProfiles.Count > 1)
                    {
                        result += $"- {string.Join("\n- ", successfulProfiles)}\n\n";
                    }


                    if (duplicateProfiles.Count == 1)
                    {
                        result += $"Duplicate profile (was not transferred):\n- {string.Join("", duplicateProfiles)}\n\n";
                    }
                    else if (duplicateProfiles.Count > 1)
                    {
                        result += $"Duplicate profiles (were not transferred):\n- {string.Join("\n- ", duplicateProfiles)}\n\n";
                    }


                    if (conflictingProfiles.Count == 1)
                    {
                        result += $"Conflicting profile (was not transferred):\n- {string.Join("", conflictingProfiles)}\n\n";
                    }
                    else if (conflictingProfiles.Count > 1)
                    {
                        result += $"Conflicting profiles (were not transferred):\n- {string.Join("\n- ", conflictingProfiles)}\n\n";
                    }

                    MessageBox.Show(result, "ProfileFusion", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (serverLocation.Text != "")
                {
                    string userFolder = Path.GetDirectoryName(serverLocation.Text);
                    string baseFolder = Path.GetDirectoryName(userFolder);

                    string result = $"Failed to transfer any profiles to SPT install {Path.GetFileName(baseFolder)}:\n\n";


                    if (duplicateProfiles.Count == 1)
                    {
                        result += $"Duplicate profile (was not transferred):\n- {string.Join("", duplicateProfiles)}\n\n";
                    }
                    else if (duplicateProfiles.Count > 1)
                    {
                        result += $"Duplicate profiles (were not transferred):\n- {string.Join("\n- ", duplicateProfiles)}\n\n";
                    }


                    if (conflictingProfiles.Count == 1)
                    {
                        result += $"Conflicting profile (was not transferred):\n- {string.Join("", conflictingProfiles)}\n\n";
                    }
                    else if (conflictingProfiles.Count > 1)
                    {
                        result += $"Conflicting profiles (were not transferred):\n- {string.Join("\n- ", conflictingProfiles)}\n\n";
                    }

                    MessageBox.Show(result, "ProfileFusion", MessageBoxButtons.OK);
                }
            }
        }

        private void transferAll_Click(object sender, EventArgs e)
        {
            if (noSelectedProfiles)
            {
                MessageBox.Show("Please select one or more profiles to transfer first!", "ProfileFusion", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to transfer these profiles?", "ProfileFusion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    transferAllProfiles(serverLocation.Text);
                    unSelectAll.PerformClick();
                }
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
                int plastLocationY = lastLabel.Location.Y + 27;

                Label p2lastLabel = panelProfileNamesList.Controls.OfType<Label>()
                    .Where(lbl => lbl.Name.StartsWith("insertedNickname"))
                    .OrderByDescending(lbl => lbl.TabIndex)
                    .First();

                int p2lastLocationX = p2lastLabel.Location.X;
                int p2lastLocationY = p2lastLabel.Location.Y + 27;


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
                                profileNickname.BackColor = idleColor;
                                profileNickname.ForeColor = Color.DarkGray;
                                profileNickname.Font = new Font("Bahnschrift Light", 8, FontStyle.Regular);
                                profileNickname.Visible = true;
                                profileNickname.TextAlign = ContentAlignment.MiddleLeft;
                                profileNickname.MouseEnter += new EventHandler(originalProfile_MouseEnter);
                                profileNickname.MouseLeave += new EventHandler(originalProfile_MouseLeave);

                                JArray areas = (JArray)parseProfile["characters"]["pmc"]["Hideout"]["Areas"];
                                bool allConstructingFalse = areas.All(area => (bool)area["constructing"] == false);
                                if (allConstructingFalse)
                                {
                                    profile.Location = new System.Drawing.Point(plastLocationX, plastLocationY + (i * 27));
                                    profile.Size = new System.Drawing.Size(lastLabel.Size.Width, lastLabel.Size.Height);
                                    profileNickname.Location = new System.Drawing.Point(p2lastLocationX, p2lastLocationY + (i * 27));
                                    profileNickname.Size = new System.Drawing.Size(p2lastLabel.Size.Width, p2lastLabel.Size.Height);

                                    profileNickname.Text = $"{nickname} [Level {level} | {faction}]";
                                    panelProfileNamesList.Controls.Add(profileNickname);
                                    panelProfilesList.Controls.Add(profile);
                                }
                                else
                                {

                                    // profileNickname.Text = $"{nickname} [Construction in progress]";
                                }
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
                                profile.BackColor = idleColor;
                                profile.Font = new Font("Bahnschrift Light", 8, FontStyle.Regular);
                                profile.Visible = true;
                                profile.TextAlign = ContentAlignment.MiddleLeft;
                                profile.MouseEnter += new EventHandler(originalProfile_MouseEnter);
                                profile.MouseLeave += new EventHandler(originalProfile_MouseLeave);
                                profile.MouseDown += new MouseEventHandler(originalProfile_MouseDown);
                                profile.MouseUp += new MouseEventHandler(originalProfile_MouseUp);
                                profile.Location = new System.Drawing.Point(panelProfilesPlaceholder.Location.X, panelProfilesPlaceholder.Location.Y + (i * 27));
                                profile.Size = new System.Drawing.Size(panelProfilesPlaceholder.Size.Width, panelProfilesPlaceholder.Size.Height);
                                profile.Text = profileArray[i];



                                Label profileNickname = new Label();
                                profileNickname.Name = $"insertedNickname{i}";
                                profileNickname.AutoSize = false;
                                profileNickname.Cursor = Cursors.Hand;
                                profileNickname.BackColor = idleColor;
                                profileNickname.Font = new Font("Bahnschrift Light", 8, FontStyle.Regular);
                                profileNickname.Visible = true;
                                profileNickname.TextAlign = ContentAlignment.MiddleLeft;
                                profileNickname.MouseEnter += new EventHandler(originalProfile_MouseEnter);
                                profileNickname.MouseLeave += new EventHandler(originalProfile_MouseLeave);
                                profileNickname.Location = new System.Drawing.Point(panelProfileNamesPlaceholder.Location.X, panelProfileNamesPlaceholder.Location.Y + (i * 27));
                                profileNickname.Size = new System.Drawing.Size(panelProfileNamesPlaceholder.Size.Width, panelProfileNamesPlaceholder.Size.Height);


                                JArray areas = (JArray)parseProfile["characters"]["pmc"]["Hideout"]["Areas"];
                                bool allConstructingFalse = areas.All(area => (bool)area["constructing"] == false);
                                if (allConstructingFalse)
                                {
                                    profileNickname.Text = $"{nickname} [Level {level} | {faction}]";
                                    profileNickname.ForeColor = Color.DarkGray;
                                    profile.ForeColor = Color.DarkGray;
                                }
                                else
                                {
                                    profileNickname.Text = $"{nickname} [Construction in progress]";
                                    profileNickname.ForeColor = conflictingColor;
                                    profile.ForeColor = conflictingColor;
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
                foreach (string profile in items)
                {
                    FileAttributes attr = File.GetAttributes(profile);
                    if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
                    {
                        if (profile.Contains(serverLocation.Text))
                        {
                            MessageBox.Show("You cannot transfer profiles to the same folder." +
                                "\n\n" +
                                "Please get profiles from another SPT installation and try again.", "ProfileFusion", MessageBoxButtons.OK);
                            break;
                        }

                        string path = Path.GetFullPath(profile);
                        arr.Add(path);
                    }
                    else
                    {
                        if (Path.GetFileName(profile) == "profiles")
                        {
                            if (profile.Contains(serverLocation.Text))
                            {
                                MessageBox.Show("You cannot transfer profiles to the same folder." +
                                    "\n\n" +
                                    "Please get profiles from another SPT installation and try again.", "ProfileFusion", MessageBoxButtons.OK);
                                break;
                            }
                            else
                            {
                                string[] files = Directory.GetFiles(profile);
                                foreach (string file in files)
                                {
                                    string path = Path.GetFullPath(file);
                                    arr.Add(path);
                                }
                            }
                        }
                    }
                }
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
            if (serverLocation.Text.Length > 0)
            {
                if (Directory.Exists(serverLocation.Text))
                {
                    Process.Start("explorer.exe", serverLocation.Text);
                }
                else
                {
                    MessageBox.Show("It appears that we cannot find this folder. Check that the folder exists and try again.", "ProfileFusion", MessageBoxButtons.OK);
                }
            }
        }

        private void transferSelected_Click(object sender, EventArgs e)
        {

        }

        private void panelClearSelected_MouseEnter(object sender, EventArgs e)
        {
            panelClearSelected.ForeColor = Color.DodgerBlue;
        }

        private void panelClearSelected_MouseLeave(object sender, EventArgs e)
        {
            panelClearSelected.ForeColor = Color.LightGray;
        }

        private void panelClearSelected_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear selected profiles?", "ProfileFusion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = panelProfilesList.Controls.Count - 1; i >= 0; i--)
                {
                    Label selected = panelProfilesList.Controls[i] as Label;
                    if (selected != null)
                    {
                        if (selected.ForeColor == conflictingColor)
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
                }

                for (int i = panelProfileNamesList.Controls.Count - 1; i >= 0; i--)
                {
                    Label selected = panelProfileNamesList.Controls[i] as Label;
                    if (selected != null)
                    {
                        if (selected.ForeColor == conflictingColor)
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

                List<string> profileFiles = new List<string>();

                foreach (Control component in panelProfilesList.Controls)
                {
                    profileFiles.Add(component.Text);
                }


                clearLeftUI();
                clearRightUI();

                string[] pFiles = profileFiles.ToArray();
                insertProfiles(pFiles);
            }
        }

        private void serverLocation_MouseEnter(object sender, EventArgs e)
        {
            serverLocation.ForeColor = Color.CornflowerBlue;
        }

        private void serverLocation_MouseLeave(object sender, EventArgs e)
        {
            serverLocation.ForeColor = Color.DodgerBlue;
        }

        private void selectAllProfiles_Click(object sender, EventArgs e)
        {
            if (panelProfilesList.Controls.Count > 0)
            {
                foreach (Control component in panelProfilesList.Controls)
                {
                    if (component is Label && component.Name.ToLower() != "panelprofilesplaceholder")
                    {
                        component.BackColor = selectColor;
                    }
                }
            }
        }

        private void unSelectAll_Click(object sender, EventArgs e)
        {
            if (panelProfilesList.Controls.Count > 0)
            {
                foreach (Control component in panelProfilesList.Controls)
                {
                    if (component is Label)
                    {
                        component.BackColor = idleColor;
                    }
                }
            }
        }
    }
}
