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
        public FormTopic()
        {
            InitializeComponent();

            SetupUI();
        }

        #region HELPER FUNCTIONS
        private void SetupUI()
        {
            DataManager dm = new DataManager();
            List<Topic> topics = dm.EDictionaryManager.GetTopic_All();

            foreach (Topic t in topics)
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
            using (MemoryStream ms = new MemoryStream(topic.Background))
            {
                b.BackgroundImage = Image.FromStream(ms);
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
            b.TabIndex = topic.TopicID;

            return b;
        }


        public void UpdateTopicBtn()
        {
            DataManager dm = new DataManager();
            List<Topic> topics = dm.EDictionaryManager.GetTopic_All();
            panelTopic.AutoScrollPosition = new Point(0, 0);

            int offset = panelTopic.Controls.Count - topics.Count;
            if (offset < 0)
            {
                for (int i = 0; i < panelTopic.Controls.Count; ++i)
                {
                    panelTopic.Controls[i].Text = topics[i].TopicName.Replace('_', ' ');
                    using (MemoryStream ms = new MemoryStream(topics[i].Background))
                    {
                        panelTopic.Controls[i].BackgroundImage = Image.FromStream(ms);
                    }
                }
                for (int i = 0; i < -offset; ++i)
                {
                    Button btn = CreateButton(topics[panelTopic.Controls.Count]);
                    btn.Location = new Point(panelTopic.Controls.Count * 275 - 0, 0);
                    panelTopic.Controls.Add(btn);
                }
            }
            else
            {
                for (int i = 0; i < topics.Count; ++i)
                {
                    panelTopic.Controls[i].Text = topics[i].TopicName.Replace('_', ' ');
                    using (MemoryStream ms = new MemoryStream(topics[i].Background))
                    {
                        panelTopic.Controls[i].BackgroundImage = Image.FromStream(ms);
                    }
                }

                for (int i = 0; i < offset; ++i)
                {
                    panelTopic.Controls.RemoveAt(panelTopic.Controls.Count - 1);
                }
            }

        }

        #endregion

        #region EVENTS
        private void OnBranching(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            FormTopic_Branch form = new FormTopic_Branch(btn.TabIndex);

            GlobalForm.MainForm.SwitchForm(form, FormType.Weak);
        }
        #endregion
    }
}
