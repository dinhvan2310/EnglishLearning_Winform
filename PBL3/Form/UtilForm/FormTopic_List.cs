using BLL.TransferObjects;
using BLL.Workflows;
using CustomControls;
using EFramework.Model;
using PBL3.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormTopic_List : Form
    {

        private decimal _SynsetID;
        private List<wn_word> _Words;
        public FormTopic_List(decimal synsetID)
        {
            InitializeComponent();

            _SynsetID = synsetID;

            SetupForm();
            SetupUI();
        }

        #region HELPER FUNCTIONS
        private void SetupForm()
        {
            DataManager dm = new DataManager();
            _Words = dm.EDictionaryManager.GetTopicWord_BySynsetID(_SynsetID);
        }

        private void SetupUI()
        {
            DataManager dm = new DataManager();
            lblBranch.Text = dm.EDictionaryManager.GetBranch_BySynsetID(_SynsetID).BranchName;

            foreach (wn_word word in _Words)
            {
                panelWord.Controls.Add(CreateWordButton(word.word.Replace('_', ' ')));
            }
        }

        private Button CreateWordButton(string word)
        {
            RJButton btn = new RJButton();

            btn.BackgroundImage = Properties.Resources.Theme6;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Text = word;
            btn.Cursor = Cursors.Hand;
            btn.ForeColor = Color.FromArgb(48, 48, 87);
            btn.Font = new Font("Bahnschrift", 13.8f, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.BorderSize = 0;
            btn.TabStop = false;
            btn.Size = new Size(150 + Math.Max(0, word.Length - 8) * 15, 60);
            btn.BorderRadius = 30;
            btn.MouseClick += WordFound;

            return btn;
        }
        #endregion

        #region EVENTS
        private void WordFound(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.SwitchForm(new WordForm(((Button)sender).Text.Replace(' ', '_')),
                 FormType.Weak);
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.GoBack();
        }

        #endregion
    }
}
