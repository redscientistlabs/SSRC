using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SSRC
{
    public static class HelperMethods
    {
        public static void AnchorForm(Control receiver, Form form)
        {
            receiver.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            receiver.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            //form.Anchor = (AnchorStyles)15; //Fill
            form.Show();
        }

        public static void RecursivelyFixBuffer(Control parent)
        {

            var allControls = RecursivelyGetAllChildrenControls(parent);
            allControls.Add(parent);

            foreach(Control c in allControls)
            {
                if(c is Form f)
                {
                    typeof(Form).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, f, new object[] { true });
                }
                else if (c is Panel p)
                {
                    typeof(Panel).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, p, new object[] { true });
                }
                else if (c is TextBox tb)
                {
                    typeof(TextBox).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, tb, new object[] { true });
                }
                else if (c is Button b)
                {
                    typeof(Button).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, b, new object[] { true });
                }
                else if (c is NumericUpDown nm)
                {
                    typeof(NumericUpDown).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, nm, new object[] { true });
                }
                else if (c is CheckBox cb)
                {
                    typeof(CheckBox).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, cb, new object[] { true });
                }
                else if (c is RadioButton rb)
                {
                    typeof(RadioButton).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, rb, new object[] { true });
                }
                else if (c is ListBox lb)
                {
                    typeof(ListBox).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, lb, new object[] { true });
                }
                else
                {
                    typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, c, new object[] { true });
                }


            }

        }
        public static List<Control> RecursivelyGetAllChildrenControls(Control c)
        {
            List<Control> allControls = new List<Control>();

            foreach (Control sub in c.Controls)
            {
                allControls.AddRange(RecursivelyGetAllChildrenControls(sub));
                allControls.Add(sub);
            }

            return allControls;
        }

    }
}
