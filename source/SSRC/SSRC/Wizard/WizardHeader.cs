using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SSRC
{
    public partial class WizardHeader : Form
    {


        public WizardHeader()
        {
            InitializeComponent();
            HelperMethods.RecursivelyFixBuffer(this);
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            Button btnStep = (Button)sender;

            if(btnStep.ForeColor == Color.Gray)
            {
                //Color.Gray means the button is disabled
                return;
            }

            WizardOrchestrator.Session.GoToStep(btnStep.Tag?.ToString());
        }
    }


}
