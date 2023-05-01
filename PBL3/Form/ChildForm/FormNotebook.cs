using BLL.Components;
using BLL.TransferObjects;
using BLL.Workflows;
using CustomControls;
using EFramework.Model;
using PBL3.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormNotebook : Form
    {
        public FormNotebook()
        {
            InitializeComponent();
        }

        #region HELPER FUNCTIONS
        private void UpdateNotebook()
        {
            List<string> learnedWords = new List<string>();
            panelNotebook.Controls.Clear();

            DataManager dm = new DataManager();
            List<NotebookCard> words = dm.NotebookManager.GetNotebookWord_All(LoginWorkflow.Instance.GetAccount().AccountID);
            words.ForEach(w =>
            {
                if (w.LearnedPercent >= 100)
                {
                    dm.NotebookManager.RemoveWord(LoginWorkflow.Instance.GetAccount().AccountID, w.Word);
                    learnedWords.Add(w.Word);
                }

                panelNotebook.Controls.Add(CreateButtonWord(w.Word, w.LearnedPercent));
            });

            if (learnedWords.Count != 0)
            {
                string s = "";
                foreach (string ss in learnedWords)
                {
                    s += ss + ", ";
                }
                FormMessageBox form = new FormMessageBox("Hoàn thành", "Chúc mừng bạn vừa học được từ:\n"
                    + s, FormMessageBox.MessageType.Info);

                LoginWorkflow.Instance.UpdateLearningStat(0, learnedWords.Count);

                form.ShowDialog();
            }
        }

        private Button CreateButtonWord(string word, int learnedPercent)
        {
            RJButton btn = new RJButton();

            btn.Text = word;
            btn.Name = word;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Size = new Size(150 + Math.Max(0, word.Length - 8) * 15, 100);
            btn.BorderRadius = 20;
            btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(
                "Theme3_" + learnedPercent / 20);
            btn.ForeColor = Color.FromArgb(240, 237, 254);
            btn.BackColor = Color.FromArgb(44, 41, 74);
            btn.BackgroundColor = Color.FromArgb(44, 41, 74);
            btn.Font = new Font("Bahnschrift", 13.8f, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.MouseClick += WordFound_MouseClick;
            panelNotebook.Controls.Add(btn);

            return btn;
        }
        #endregion

        #region EVENTS
        private void btnStatistic_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.SwitchForm(new FormStatistic(),
                FormType.Weak);
        }

        private void FormNotebook_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
                return;

            UpdateNotebook();
        }

        private void WordFound_MouseClick(object sender, EventArgs e)
        {
            GlobalForm.MainForm.SwitchForm(new WordForm(((Button)sender).Text.Replace(' ', '_')), FormType.Weak);
        }

        private void Sort_MouseClick(object sender, MouseEventArgs e)
        {
            panelNotebook.Controls.Clear();

            DataManager dm = new DataManager();
            List<NotebookCard> words = dm.NotebookManager.GetSortedWord_ByPercentLearning(
                LoginWorkflow.Instance.GetAccount().AccountID,
                ((Button)sender).Name);

            words.ForEach(w =>
            {
                panelNotebook.Controls.Add(CreateButtonWord(w.Word, w.LearnedPercent));
            });
        }

        #endregion

    }
}
