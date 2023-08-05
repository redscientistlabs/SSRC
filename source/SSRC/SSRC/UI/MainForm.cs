using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SSRC
{
    public partial class MainForm : Form
    {
        MainLayout layout = null;

        public MainForm()
        {
            InitializeComponent();
            HelperMethods.RecursivelyFixBuffer(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeLayout();
        }

        public void InitializeLayout()
        {
            layout = new MainLayout();
            HelperMethods.AnchorForm(this, layout);

            //this.Controls.Clear();
            //layout.TopLevel = false;
            //layout.FormBorderStyle = FormBorderStyle.None;
            //this.Controls.Add(layout);
            //layout.Dock = DockStyle.Fill;
            ////layout.Anchor = (AnchorStyles)15; //Fill
            //layout.Show();
        }
    }
}
