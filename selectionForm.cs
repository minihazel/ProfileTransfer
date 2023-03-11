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

namespace ProfileTransfer
{
    public partial class selectionForm : Form
    {

        public selectionForm()
        {
            InitializeComponent();
        }

        public void selectLeft_Click(object sender, EventArgs e)
        {
            profileForm mainForm = new profileForm();
            string fullPath = selectedPath.Text;

            Panel panel1 = (Panel)mainForm.Controls["panelTransferFreely"];
            Panel panel2 = (Panel)panel1.Controls["panelFrom"];
            ((Label)panel2.Controls["panelFromLocation"]).Text = fullPath;

            mainForm.fromFolder = fullPath;
            mainForm.listProfiles(fullPath, true);
            mainForm.constructionTimer.Start();

            this.Close();
            mainForm.Show();
        }

        public void selectRight_Click(object sender, EventArgs e)
        {
            profileForm mainForm = new profileForm();
            string fullPath = selectedPath.Text;

            Panel panel1 = (Panel)mainForm.Controls["panelTransferFreely"];
            Panel panel2 = (Panel)panel1.Controls["panelTo"];
            ((Label)panel2.Controls["panelToLocation"]).Text = fullPath;

            mainForm.toFolder = fullPath;
            mainForm.listProfiles(fullPath, false);
            mainForm.constructionTimer.Start();

            this.Close();
            mainForm.Show();
        }

        private void selectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
