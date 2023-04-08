using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

using BLL.Workflows;
using BLL.TransferObjects;
using PBL3.Utilities;

namespace PBL3
{
    public partial class WordForm : Form
    {
        private Button _CurrentTag;
        private Form _CurrentChildForm;

        private string _Word;
        private List<SynsetModel> _Synsets;

        public WordForm(string rawWord)
        {
            _Word = rawWord;

            InitializeComponent();

            ActiveTag(btnMeaning);

            var dataAccess = new DataManager();
            _Synsets = dataAccess.EDictionaryManager.GetSynset_ByWord(rawWord);
            OpenChildForm(new WordForm_Meaning(rawWord, _Synsets));
        }

        public void CloseChildForms()
        {
            if (_CurrentChildForm != null)
            {
                _CurrentChildForm.Close();
            }
        }

        private void ActiveTag(Button tag)
        {
            if (_CurrentTag != null) 
            {
                ResetTag();
            }

            _CurrentTag = tag;

            _CurrentTag.BackColor = Color.FromArgb(240, 237, 254);
            _CurrentTag.ForeColor = Color.FromArgb(48, 48, 87);
            _CurrentTag.Size = new Size(190, 60);
            _CurrentTag.Location = new Point(_CurrentTag.Location.X, _CurrentTag.Location.Y - 10);
            _CurrentTag.Enabled = false;
        }

        private void ResetTag()
        {
            _CurrentTag.BackColor = Color.FromArgb(44, 41, 74);
            _CurrentTag.ForeColor = Color.FromArgb(240, 237, 254);
            _CurrentTag.Size = new Size(190, 50);
            _CurrentTag.Enabled = true;
            _CurrentTag.Location = new Point(_CurrentTag.Location.X, _CurrentTag.Location.Y + 10);
        }

        private void OpenChildForm(Form childForm)
        {
            if (_CurrentChildForm != null)
            {
                _CurrentChildForm.Close();
            }

            _CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelBase.Controls.Add(childForm); 
            panelBase.Tag = childForm;
            childForm.SendToBack();
            childForm.Show();
        }

        private void btnMeaning_Click(object sender, EventArgs e)
        {
            ActiveTag((Button)sender);
            OpenChildForm(new WordForm_Meaning(_Word, _Synsets));
        }

        private void btnGrammar_Click(object sender, EventArgs e)
        {
            ActiveTag((Button)sender);
            OpenChildForm(new WordForm_Grammar(_Word));
        }

        private void btnSynonym_Click(object sender, EventArgs e)
        {
            ActiveTag((Button)sender);
            OpenChildForm(new WordForm_Synonym(_Word));
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            GlobalForm.MainForm.GoBack();
        }
    }
}
