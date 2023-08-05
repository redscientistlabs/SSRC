using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SSRC
{
    public partial class WizardStepRunCorrupt : Form
    {
        public WizardStepRunCorrupt()
        {
            InitializeComponent();
            HelperMethods.RecursivelyFixBuffer(this);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SSRC_Config.SaveConfig();

            WizardOrchestrator.Session.RunCorrupt();
        }

        private void CorruptionMethod_CheckedChanged(object sender, EventArgs e)
        {
            if(rbExecuteWithEmu.Checked)
            {
                WizardOrchestrator.Session.ExecEmu = true;
                WizardOrchestrator.Session.MultipleCorrupt = false;
            }
            else if(rbCreateCorrupted.Checked)
            {
                WizardOrchestrator.Session.ExecEmu = false;
                WizardOrchestrator.Session.MultipleCorrupt = false;
            }
            else if (rbCreateMultiple.Checked)
            {
                WizardOrchestrator.Session.ExecEmu = false;
                WizardOrchestrator.Session.MultipleCorrupt = true;
            }
        }

        private void nmAmountCorrupted_ValueChanged(object sender, EventArgs e)
        {
            WizardOrchestrator.Session.AmountCorruptedFiles = Convert.ToInt32(nmAmountCorrupted.Value);
        }

        private void btnBrowseEmu_Click(object sender, EventArgs e)
        {
            string filePath = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
                else
                    return;

                tbEmuPath.Text = filePath;
            }
        }

        private void tbEmuPath_TextChanged(object sender, EventArgs e)
        {
            WizardOrchestrator.Session.EmuPath = tbEmuPath.Text;
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            string folderPath = null;

            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                openFolderDialog.ShowNewFolderButton = true;

                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    folderPath = openFolderDialog.SelectedPath;
                }
                else
                    return;

                tbCorruptedFolder.Text = folderPath;
            }

        }

        private void tbCorruptedFolder_TextChanged(object sender, EventArgs e)
        {
            WizardOrchestrator.Session.CorruptedFolder = tbCorruptedFolder.Text;
        }

        private void cbFilenameGuid_CheckedChanged(object sender, EventArgs e)
        {
            WizardOrchestrator.Session.UseGuidFilenames = cbFilenameGuid.Checked;
        }

        private void cbAutoKill_CheckedChanged(object sender, EventArgs e)
        {
            WizardOrchestrator.Session.AutoKillEmu = cbAutoKill.Checked;
        }

        private void WizardStepRunCorrupt_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SSRC_Config.CurrentConfig.EmuPath))
            {
                tbEmuPath.Text = SSRC_Config.CurrentConfig.EmuPath;
            }
        }
    }
}
