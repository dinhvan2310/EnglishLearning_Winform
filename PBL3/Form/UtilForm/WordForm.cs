using FontAwesome.Sharp;
using PBLLibrary;
using PBLLibrary.Models;
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

namespace PBL3
{
    public partial class WordForm : Form
    {
        private Form _parentForm;

        private Button _currentTag;
        private Form _currentChildForm;

        private string _word;
        private List<SynsetModel> _synsets;

        public WordForm(Form parentForm, string rawWord)
        {
            _parentForm = parentForm;
            _word = rawWord;

            InitializeComponent();

            ActiveTag(btnMeaning);
            _synsets = GlobalConfig.GetSynset_ByWord(rawWord);
            OpenChildForm(new WordForm_Meaning(rawWord, _synsets));
        }

        public void CloseChildForms()
        {
            if (_currentChildForm != null)
            {
                _currentChildForm.Close();
            }
        }

        private void ActiveTag(Button tag)
        {
            if (_currentTag != null) 
            {
                ResetTag();
            }

            _currentTag = tag;

            _currentTag.BackColor = Color.FromArgb(240, 237, 254);
            _currentTag.ForeColor = Color.FromArgb(48, 48, 87);
            _currentTag.Size = new Size(190, 60);
            _currentTag.Location = new Point(_currentTag.Location.X, _currentTag.Location.Y - 10);
            _currentTag.Enabled = false;
        }

        private void ResetTag()
        {
            _currentTag.BackColor = Color.FromArgb(44, 41, 74);
            _currentTag.ForeColor = Color.FromArgb(240, 237, 254);
            _currentTag.Size = new Size(190, 50);
            _currentTag.Enabled = true;
            _currentTag.Location = new Point(_currentTag.Location.X, _currentTag.Location.Y + 10);
        }

        private void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
            {
                _currentChildForm.Close();
            }

            _currentChildForm = childForm;
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
            OpenChildForm(new WordForm_Meaning(_word, _synsets));
        }

        private void btnGrammar_Click(object sender, EventArgs e)
        {
            ActiveTag((Button)sender);
            OpenChildForm(new WordForm_Grammar());
        }

        private void btnSynonym_Click(object sender, EventArgs e)
        {
            ActiveTag((Button)sender);
            OpenChildForm(new WordForm_Synonym());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ((MainForm)_parentForm).OpenChildForm(FormStack.Pop(), FormStack.FormType.Strong);
        }
    }
}
