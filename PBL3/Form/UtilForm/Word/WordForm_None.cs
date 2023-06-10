using BLL.Components;
using BLL.TransferObjects;
using BLL.Workflows;
using PBL3.Utilities;
using PBLLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using EFramework.Model;

namespace PBL3
{
    public partial class WordForm_None : Form
    {
        private string _RawWord;
        private bool _IsEE;

        private List<wn_word> _Words;
        private List<word_viet> _VWords;

        public WordForm_None( string rawWord, bool isEE = true)
        {
            _RawWord = rawWord;
            _IsEE = isEE;

            InitializeComponent();

            SetupForm();
            SetupUI();
        }

        #region HELPER FUNCTIONS
        private void SetupForm()
        {
            DataManager dm = new DataManager();
            if (_IsEE)
                _Words = dm.EDictionaryManager.GetWord_ByFilter_Random(_RawWord[0] + "%", 8, true);
            else
                _VWords = dm.VDictionaryManager.GetWord_ByFilter(_RawWord[0] + "%", 8);
        }

        private void SetupUI()
        {
            lblWord.Text = _RawWord;

            int i = 0;
            if (_IsEE)
            {
                foreach (wn_word w in _Words)
                {
                    panel1.Controls.Add(CreateLabelWord(_Words[i++].word));
                }
            }
            else
            {
                foreach (word_viet w in _VWords)
                {
                    panel1.Controls.Add(CreateLabelWord(_VWords[i++].word));
                }
            }
        }

        private Label CreateLabelWord(string text)
        {
            Label l = new Label();

            l.BackColor = Color.FromArgb(240, 237, 254);
            l.ForeColor = Color.FromArgb(48, 48, 87);
            l.Font = new Font("Bahnschrift Light", 13.8f, System.Drawing.FontStyle.Underline);
            l.Text = text;
            l.Cursor = Cursors.Hand;
            l.AutoSize = true;
            l.Dock = DockStyle.Top;
            l.MouseClick += lblWordFound1_MouseClick;

            return l;
        }

        #endregion

        #region EVENTS
        private void lblWordFound1_MouseClick(object sender, MouseEventArgs e)
        {
            if(_IsEE)
            {
                GlobalForm.MainForm.SwitchForm(new WordForm(((Label)sender).Text.Replace(' ', '_')),
                FormType.Weak);
            }
            else
            {
                GlobalForm.MainForm.SwitchForm(new WordForm(((Label)sender).Text, false),
                FormType.Weak);
            }
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.GoBack();
        }

        #endregion
    }
}
