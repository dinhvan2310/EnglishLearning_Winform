using BLL.Components;
using BLL.Workflows;
using CustomControls;
using EFramework.Model;
using Library;
using PBL3.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormTopic : Form
    {
        private List<Topic> _Topics;

        public FormTopic()
        {
            InitializeComponent();

            DataManager dm = new DataManager();
            _Topics = dm.EDictionaryManager.GetTopic_All();

            SetupUI();
        }

        #region HELPER FUNCTIONS
        private void SetupUI()
        {
            foreach (Topic t in _Topics)
            {
                Button btn = CreateButton(t);
                btn.Location = new Point(panelTopic.Controls.Count * 275, 0);
                panelTopic.Controls.Add(btn);
            }
        }

        private Button CreateButton(Topic topic)
        {
            RJButton b = new RJButton();
            b.BackColor = Color.FromArgb(240, 237, 254);
            if (topic.Background != null)
            {
                using (MemoryStream ms = new MemoryStream(topic.Background))
                {
                    b.BackgroundImage = Image.FromStream(ms);
                }
            }
            b.BackgroundImageLayout = ImageLayout.Zoom;
            b.Cursor = Cursors.Hand;
            b.FlatStyle = FlatStyle.Flat;
            b.BorderSize = 0;
            b.Font = new Font("Bauhaus 93", 24.0f);
            b.Text = topic.TopicName.Replace('_', ' ');
            b.TabStop = false;
            b.Size = new Size(250, 315);
            b.BorderRadius = 30;
            b.ForeColor = Color.FromArgb(44, 41, 74);
            b.MouseClick += OnBranching;

            return b;
        }

        private void OnBranching(object sender, MouseEventArgs e)
        {
            FormTopic_Branch form = new FormTopic_Branch(_Topics
                .Where(p => p.TopicName == ((Button)sender).Text)
                .First().TopicID);

            GlobalForm.MainForm.SwitchForm(form, FormType.Weak);
        }

        #endregion
    }
}
