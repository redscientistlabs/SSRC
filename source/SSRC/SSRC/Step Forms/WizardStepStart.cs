using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SSRC
{
    public partial class WizardStepStart : Form, IValidatable
    {
        public WizardStepStart()
        {
            InitializeComponent();
            HelperMethods.RecursivelyFixBuffer(this);
        }

        public new bool Validate()
        {
            if(logoTimer != null)
            {
                logoTimer.Stop();
                logoTimer = null;
            }

            if(backupLogo != null)
                pb140.BackgroundImage = backupLogo;

            return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            WizardOrchestrator.Session.NextStep();
        }

        Timer logoTimer = null;
        Image backupLogo = null;
        int logoClicks = 3;
        bool autoplay = false;

        private void pb140_Click(object sender, EventArgs e)
        {
            if(logoClicks <= 0)
            {
                if(logoTimer != null)
                {
                    logoTimer.Stop();
                    logoTimer = null;
                }

                if(autoplay)
                {
                    logoClicks = 2;
                    pb140.BackgroundImage = backupLogo;
                }
                else
                {
                    logoClicks = 10;
                    logoTimer = new Timer();
                    logoTimer.Interval = 1420;
                    logoTimer.Tick += (o, ev) =>
                    {
                        pb140_Click(null, null);
                    };
                    logoTimer.Start();
                }
            }

            if (autoplay && sender != null)
            {
                return;
            }

            Random rnd = new Random((int)DateTime.Now.Ticks);

            if(backupLogo == null)
                backupLogo = (Image)pb140.BackgroundImage.Clone();

            Image img = (Image)backupLogo.Clone();

            using (Graphics g = Graphics.FromImage(img))
            {
                int lines = rnd.Next(69, 420);

                for (int i = 0; i < lines; i++)
                {
                    try
                    {
                        int chance = rnd.Next(100);

                        if (chance > 69)
                        {
                            float penWidth = Convert.ToSingle(rnd.Next(69));

                            int vertical = rnd.Next(100);
                            if (vertical > 50)
                            {
                                int y = rnd.Next(img.Height);
                                Brush b = new SolidBrush(Color.FromArgb(32, 32, 32));
                                Pen p = new Pen(b, penWidth);

                                g.DrawLine(p, new Point(0, y), new Point(img.Width, y));
                            }
                            else
                            {
                                int x = rnd.Next(img.Width);
                                Brush b = new SolidBrush(Color.FromArgb(32, 32, 32));
                                Pen p = new Pen(b, penWidth);

                                g.DrawLine(p, new Point(x, 0), new Point(x, img.Height));
                            }

                        }
                        else
                        {

                            Rectangle source = new Rectangle(rnd.Next(img.Width), rnd.Next(img.Height), rnd.Next(img.Width), rnd.Next(img.Height));
                            Rectangle destination = new Rectangle(rnd.Next(img.Width), rnd.Next(img.Height), rnd.Next(img.Width), rnd.Next(img.Height));

                            g.DrawImage(backupLogo, source, destination, GraphicsUnit.Pixel);
                        }

                    }
                    catch { } //eat it
                }
            }
            pb140.BackgroundImage = null;
            pb140.BackgroundImage = img;
            pb140.Refresh();

            logoClicks--;

        }
    }
}
