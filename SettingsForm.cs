using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(int interval,bool withSaving, bool light)
        {
            InitializeComponent();
            IntervalNumericUpDown.Value = interval / 60000;
            if (withSaving)
                withSavingButton.Checked = true;
            else
                withoutSavingButton.Checked = true;
            if (light)
                LightRadioButton.Checked = true;
            else
                DarkRadioButton.Checked = true;
        }

        private void changeSettingsButton_Click(object sender, EventArgs e)
        {
            (Owner as MainForm).ChangeSettings((int)IntervalNumericUpDown.Value*60000, withSavingButton.Checked,LightRadioButton.Checked);
            this.Close();
        }
    }
}
