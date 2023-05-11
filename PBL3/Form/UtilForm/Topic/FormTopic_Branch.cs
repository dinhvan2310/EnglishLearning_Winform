using BLL.Components;
using BLL.EnityFramework.Model;
using BLL.Workflows;
using CustomControls;
using PBL3.Utilities;
using System;
using System.Collections;
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
    public partial class FormTopic_Branch : Form
    {
        private decimal _TopicID;

        public FormTopic_Branch(decimal topicID)
        {
            InitializeComponent();

            _TopicID = topicID;

            SetupUI();
        }

        #region HELPER FUNCTIONS
        private void SetupUI()
        {
            DataManager dm = new DataManager();
            List<Branch> branches = dm.EDictionaryManager.GetBranch_ByTopicID(_TopicID);
            lblTopic.Text = dm.EDictionaryManager.GetTopic_ByTopicID(_TopicID).TopicName.Replace('_', ' ');

            foreach (Branch b in branches)
            {
                panelBranch.Controls.Add(CreateButton(b));
            }
        }

        private Button CreateButton(Branch branch)
        {
            RJButton b = new RJButton();
            b.BackColor = Color.FromArgb(240, 237, 254);
            b.Cursor = Cursors.Hand;
            b.FlatStyle = FlatStyle.Flat;
            b.BorderSize = 0;
            b.Font = new Font("Bauhaus 93", 24.0f);
            b.Text = branch.BranchName;
            b.TabIndex = Convert.ToInt32(branch.SynsetID);
            b.TabStop = false;
            b.Size = new Size(180, 315);
            b.Dock = DockStyle.Left;
            b.BorderRadius = 90;
            b.ForeColor = Color.FromArgb(44, 41, 74);
            b.MouseClick += OnList;

            return b;
        }
        #endregion

        #region EVENTS
        private void OnList(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            FormTopic_List form = new FormTopic_List(btn.TabIndex);
            GlobalForm.MainForm.SwitchForm(form, FormType.Weak);
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.GoBack();
        }

        #endregion
    }
}
