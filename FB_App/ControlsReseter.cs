using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FB_App
{
    public class ControlsReseter
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.DataSource = null;
                    listBox.Items.Clear();
                }

                if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Image = null;
                }

                if (control is DateTimePicker)
                {
                    DateTimePicker datePicker = (DateTimePicker)control;
                    datePicker.Value = DateTime.Today;
                }

                if (control is Panel)
                {
                    ResetAllControls(control);
                }
            }
        }
    }
}