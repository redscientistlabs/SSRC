using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SSRC
{
    public partial class WizardStepEngineConfig : Form, IValidatable
    {
        public WizardStepEngineConfig()
        {
            InitializeComponent();
            HelperMethods.RecursivelyFixBuffer(this);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;


            WizardOrchestrator.Session.NextStep();
        }

        public new bool Validate()
        {
            if (WizardOrchestrator.Session.UseCustomValueRange)
            {
                try
                {
                    WizardOrchestrator.Session.CustomValueRange = new CustomRange(tbSpecificRanges.Text, false);
                }
                catch
                {
                    //assume we handled it upstairs.
                    return false;
                }

            }

            return true;
        }

        private void RangeOptions_CheckedChanged(object sender, EventArgs e)
        {
            WizardOrchestrator.Session.UseCustomValueRange = rbSelectRange.Checked;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"How to setup custom ranges and values
---------------------------------------------
Define custom ranges and values in blocks separated by commas.
All values are in Hexadecimal, do not use 0x notation.
Range values separated by a dash -

Lower boundary is inclusive
Upper boundary is exclusive

Range example: 00-1F
Value example: EA

Combo example: 00-1F, 40-4F, 58, 59, 5A, 5B, F0-FF

Spaces are meaningless
Line skips count as range splits (like ,)
Empty lines are legal
Comment lines start with // (only start)
");
        }

        private void nmIntensity_ValueChanged(object sender, EventArgs e)
        {
            WizardOrchestrator.Session.Intensity = Convert.ToInt32(nmIntensity.Value);
        }
    }
}
