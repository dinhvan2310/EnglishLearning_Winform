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
        private string _Topic;
        private List<string> _Branches;

        public FormTopic_Branch(string topic)
        {
            InitializeComponent();

            _Topic = topic;

            DataManager dm = new DataManager();
            _Branches = dm.EDictionaryManager.GetBranchName_ByTopic(_Topic);

            SetupUI();
        }

        private void SetupUI()
        {
            lblTopic.Text = _Topic;

            foreach (string b in _Branches)
            {
                panelBranch.Controls.Add(CreateButton(b));
            }
        }

        private Button CreateButton(string branch)
        {
            RJButton b = new RJButton();
            b.BackColor = Color.FromArgb(240, 237, 254);
            b.Cursor = Cursors.Hand;
            b.FlatStyle = FlatStyle.Flat;
            b.BorderSize = 0;
            b.Font = new Font("Bauhaus 93", 24.0f);
            b.Text = branch;
            b.TabStop = false;
            b.Size = new Size(180, 315);
            b.Dock = DockStyle.Left;
            b.BorderRadius = 90;
            b.ForeColor = Color.FromArgb(44, 41, 74);
            b.MouseClick += OnList;

            return b;
        }

        private void OnList(object sender, MouseEventArgs e)
        {
            FormTopic_List form = new FormTopic_List(((Button)sender).Text);
            GlobalForm.MainForm.SwitchForm(form, FormType.Weak);
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.GoBack();
        }
    }
}
