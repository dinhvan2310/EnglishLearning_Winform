using BLL.TransferObjects;
using BLL.Workflows;
using CustomControls;
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

        private string _Branch;
        private List<WordModel> _Words;
        public FormTopic_List(string branch)
        {
            InitializeComponent();

            DataManager dm = new DataManager();
            _Branch = branch;
            _Words = dm.EDictionaryManager.GetTopicWord_ByBranch(branch);

            SetupUI();
        }

        private void SetupUI()
        {
            lblBranch.Text = _Branch;

            foreach (WordModel word in _Words)
            {
                panelWord.Controls.Add(CreateWordButton(word.Word));
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

        private void WordFound(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.SwitchForm(new WordForm(((Button)sender).Text.Replace(' ', '_')),
                 FormType.Weak);
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.GoBack();
        }
    }
}
