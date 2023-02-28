using PBLLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();

            cmbVoice.Items.Add("Male - David");
            cmbVoice.Items.Add("Female - Zira");

            cmbVoice.Text = "Male - David";
        }

        private void trkVolumn_Scroll(object sender, EventArgs e)
        {
            SoundConfig.ChangeVolumn(trkVolumn.Value * 10);
        }

        private void cmbVoice_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            SoundConfig.ChangeVolumn(cmbVoice.SelectedIndex);
        }

    }
}
