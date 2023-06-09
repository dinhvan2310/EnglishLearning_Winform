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
using BLL.Components;

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

        #region EVENTS

        private void trkVolumn_Scroll(object sender, EventArgs e)
        {
            
            if (LoginWorkflow.Instance.IsLoggedIn())
            {
                SettingWorkflow.Instance.SetUserSettings(LoginWorkflow.Instance.GetAccount().AccountID, trkVolumn.Value, cmbVoice.SelectedIndex == 0 ? false : true);
            }
            SettingWorkflow.Instance.ChangeVolumn(trkVolumn.Value * 10);
            label4.Text = (trkVolumn.Value * 10).ToString();
        }

        private void cmbVoice_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoginWorkflow.Instance.IsLoggedIn())
            {
                SettingWorkflow.Instance.SetUserSettings(LoginWorkflow.Instance.GetAccount().AccountID, trkVolumn.Value, cmbVoice.SelectedIndex == 0 ? false : true);
            }
            SettingWorkflow.Instance.ChangeVoice(cmbVoice.SelectedIndex == 0 ? Voice.Male : Voice.Female);
        }

        private void FormSetting_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
                return;

            

            if (LoginWorkflow.Instance.IsLoggedIn())
            {
                UserSetting us = SettingWorkflow.Instance.GetUserSettings(LoginWorkflow.Instance.GetAccount().AccountID);
                if (us != null)
                {
                    trkVolumn.Value = us.Volume;
                    SettingWorkflow.Instance.ChangeVolumn(trkVolumn.Value * 10);
                    label4.Text = (us.Volume * 10).ToString();
                    cmbVoice.SelectedIndex = (us.Voice == false) ? 0 : 1;
                    SettingWorkflow.Instance.ChangeVoice(cmbVoice.SelectedIndex == 0 ? Voice.Male : Voice.Female);
                }
            }
        }

        #endregion
    }
}
