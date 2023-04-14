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

using BLL.Workflows;

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

            if (LoginWorkflow.Instance.IsLoggedIn())
            {
                UserSetting us = AppSettings.getUserSettings(LoginWorkflow.Instance.GetAccount().AccountID);
                if (us != null)
                {
                    trkVolumn.Value = us.Volume;
                    SoundConfig.ChangeVolumn(trkVolumn.Value * 10);
                    label4.Text = (us.Volume * 10).ToString();
                    cmbVoice.SelectedIndex = (us.Voice == false) ? 0 : 1;
                    SoundConfig.ChangeVoice(cmbVoice.SelectedIndex == 0 ? SoundConfig.Voice.Male : SoundConfig.Voice.Female);
                }
            }
        }

        

        private void trkVolumn_Scroll(object sender, EventArgs e)
        {
            if (LoginWorkflow.Instance.IsLoggedIn())
            {
                AppSettings.setUserSettings(LoginWorkflow.Instance.GetAccount().AccountID, trkVolumn.Value, cmbVoice.SelectedIndex == 0 ? false : true);
            }
            SoundConfig.ChangeVolumn(trkVolumn.Value * 10);
            label4.Text = (trkVolumn.Value * 10).ToString();
        }

        private void cmbVoice_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoginWorkflow.Instance.IsLoggedIn())
            {
                AppSettings.setUserSettings(LoginWorkflow.Instance.GetAccount().AccountID, trkVolumn.Value, cmbVoice.SelectedIndex == 0 ? false : true);
            }
            SoundConfig.ChangeVoice(cmbVoice.SelectedIndex == 0 ? SoundConfig.Voice.Male : SoundConfig.Voice.Female);
        }

    }
}
