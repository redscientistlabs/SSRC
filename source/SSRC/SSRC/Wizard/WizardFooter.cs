using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SSRC
{
    public partial class WizardFooter : Form
    {
        public WizardFooter()
        {
            InitializeComponent();
            HelperMethods.RecursivelyFixBuffer(this);
        }
    }
}
