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
using BLL.TransferObjects;
using BLL.Workflows;
using PBL3.Utilities;
using EFramework.Model;

namespace PBL3
{
    public partial class WordForm_Synonym : Form
    {
        private string _RawWord;

        private int _CurrentTypeLabelIndex;
        private List<wn_word> _Similars;
        private List<wn_word> _Antonyms;

        public WordForm_Synonym(string rawWord)
        {
            _RawWord = rawWord;

            InitializeComponent();

            SetupForm();
            SetupUI();
        }

        #region HELPER FUNCTIONS

        private void SetupForm()
        {
            DataManager dm = new DataManager();

            _Similars = dm.EDictionaryManager.GetSynonymWord_ByWord(_RawWord);
            _Antonyms = dm.EDictionaryManager.GetAntonymWord_ByWord(_RawWord);
        }

        private void SetupUI()
        {
            UpdatePanel();
        }

        private void UpdatePanel()
        {
            panelWords.Controls.Clear();
            if (_CurrentTypeLabelIndex == 1)
            {
                foreach (wn_word w in _Antonyms)
                {
                    Label b = CreateLabelWord(w.word.Replace('_', ' '));
                    panelWords.Controls.Add(b);
                }
            }
            else
            {
                foreach (wn_word w in _Similars)
                {
                    Label b = CreateLabelWord(w.word.Replace('_', ' '));
                    panelWords.Controls.Add(b);
                }
            }
        }

        private Label CreateLabelWord(string txt)
        {
            Label b = new Label();
            b.BorderStyle = BorderStyle.None;
            b.BackColor = Color.FromArgb(240, 237, 254);
            b.ForeColor = Color.FromArgb(48, 48, 87);
            b.AutoSize = false;
            b.Size = new System.Drawing.Size(250, 30);
            b.Margin = new Padding(3, 0, 3, 0);
            b.Dock = DockStyle.Left;
            b.Cursor = Cursors.Hand;
            b.MouseClick += WordFound;
            b.Font = new Font("Bahnschrift Light", 13.8f, System.Drawing.FontStyle.Underline);
            b.Text = txt;

            return b;
        }

        #endregion

        #region EVENTS

        private void underlineBarAnim_Tick(object sender, EventArgs e)
        {
            if (underlineBar.Location.X == _CurrentTypeLabelIndex * 300 + 62)
            {
                underlineBarAnim.Stop();
                return;
            }

            float smoothValue = (underlineBar.Location.X) * 0.75f + (_CurrentTypeLabelIndex * 300 + 62) * 0.25f;
            underlineBar.Location = new System.Drawing.Point((int)smoothValue, underlineBar.Location.Y);
        }

        private void LabelType_MouseClick(object sender, EventArgs e)
        {
            string type = ((Label)sender).Text;
            int indexInList = type.Equals("ĐỒNG NGHĨA") ? 0 : 1;

            if (indexInList != _CurrentTypeLabelIndex)
            {
                _CurrentTypeLabelIndex = indexInList;
                UpdatePanel();

                underlineBarAnim.Start();
            }
        }

        private void WordFound(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.SwitchForm(new WordForm(((Label)sender).Text.Replace(' ', '_')),
                 FormType.Weak);
        }
        #endregion
    }

}
