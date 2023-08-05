using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SSRC
{
    public partial class MainLayout : Form
    {
        WizardHeader header = null;
        WizardFooter footer = null;

        public MainLayout()
        {
            InitializeComponent();
            HelperMethods.RecursivelyFixBuffer(this);

            //Prepare Immediate views
            InitializeHeader();
            InitializeFooter();

            //Prepare workflow
            var orchestrator = new WizardOrchestrator(pnView, header); //This will register to static singleton WizardOrchestrator.Session
            orchestrator.InitializeWorkflow();

            SSRC_Config.LoadConfig();
        }

        public void InitializeHeader()
        {
            header = new WizardHeader();
            HelperMethods.AnchorForm(pnHeader, header);
        }

        public void InitializeFooter()
        {
            footer = new WizardFooter();
            HelperMethods.AnchorForm(pnFooter, footer);
        }
    }
}
