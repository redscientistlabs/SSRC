using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SSRC
{
    public partial class WizardStepSelectRom : Form
    {
        public WizardStepSelectRom()
        {
            InitializeComponent();
            HelperMethods.RecursivelyFixBuffer(this);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string rompath = WizardOrchestrator.Session.RomPath;

            if (rompath == null || rompath.Trim() == "")
            {
                MessageBox.Show($"You must select a ROM file before going to the next step");
                return;
            }

            if (rompath.Trim() == "" || !File.Exists(rompath))
            {
                MessageBox.Show($"Could not find ROM file \"{rompath}\"");
                return;
            }

            try
            {
                var data = File.ReadAllBytes(rompath);
                WizardOrchestrator.Session.RomData = data;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Could not read ROM file \"{rompath}\"\n\n{ex.ToString()}");
                return;
            }

            SSRC_Config.SaveConfig();

            WizardOrchestrator.Session.NextStep();
        }

        private void btnBrowseRom_Click(object sender, EventArgs e)
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

                tbRomPath.Text = filePath;
            }
        }

        private void tbRomPath_TextChanged(object sender, EventArgs e)
        {
            WizardOrchestrator.Session.RomPath = tbRomPath.Text;

            WizardOrchestrator.Session.InvalidatePostSelectRomSteps();
        }

        private void WizardStepSelectRom_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(SSRC_Config.CurrentConfig.RomPath))
            {
                tbRomPath.Text = SSRC_Config.CurrentConfig.RomPath;
            }
        }
    }
}
