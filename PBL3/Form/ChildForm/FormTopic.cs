using BLL.Components;
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
    public partial class FormTopic : Form
    {
        private List<string> _TopicName;

        public FormTopic()
        {
            InitializeComponent();

            DataManager dm = new DataManager();
            _TopicName = dm.EDictionaryManager.GetTopicName_All();

            SetupUI();
        }

        private void SetupUI()
        {
            foreach (string t in _TopicName)
            {
                Button btn = CreateButton(t);
                btn.Location = new Point(panelTopic.Controls.Count * 275, 0);
                panelTopic.Controls.Add(btn);
            }
        }

        private Button CreateButton(string topic)
        {
            RJButton b = new RJButton();
            b.BackColor = Color.FromArgb(240, 237, 254);
            b.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(topic.Replace(' ', '_'));
            b.BackgroundImageLayout = ImageLayout.Zoom;
            b.Cursor = Cursors.Hand;
            b.FlatStyle = FlatStyle.Flat;
            b.BorderSize = 0;
            b.Font = new Font("Bauhaus 93", 24.0f);
            b.Text = topic;
            b.TabStop = false;
            b.Size = new Size(250, 315);
            b.BorderRadius = 30;
            b.ForeColor = Color.FromArgb(44, 41, 74);
            b.MouseClick += OnBranching;

            return b;
        }

        private void OnBranching(object sender, MouseEventArgs e)
        {
            FormTopic_Branch form = new FormTopic_Branch(((Button)sender).Text);

            GlobalForm.MainForm.SwitchForm(form, FormType.Weak);
        }
    }
}
