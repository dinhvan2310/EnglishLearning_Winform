using BLL.Components;
using BLL.TransferObjects;
using BLL.Workflows;
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
using System.Windows.Forms;

namespace PBL3
{
    public partial class WordForm_Grammar : Form
    {
        private List<string> _VerbFrames;
        private List<wn_word> _Deriveds;
        public WordForm_Grammar(string rawWord)
        {
            InitializeComponent();

            DataManager dm = new DataManager();
            _VerbFrames = dm.EDictionaryManager.GetVerbFrame_ByWord(rawWord);
            _Deriveds = dm.EDictionaryManager.GetDerivedWord_ByWord(rawWord);

            SetupUI();
        }

        private void SetupUI()
        {
            foreach (string s in _VerbFrames)
            {
                Label label = CreateLabel(s);
                panelFrames.Controls.Add(label);
            }

            foreach (wn_word w in _Deriveds)
            {
                Label label = CreateLabel(w.word.Replace('_', ' '), true);
                panelDeriveds.Controls.Add(label);
            }

            if (_VerbFrames.Count == 0)
            {
                Label label = CreateLabel("Không có!!");
                panelFrames.Controls.Add(label);
            }
            if (_Deriveds.Count == 0)
            {
                Label label = CreateLabel("Không có!!");
                panelDeriveds.Controls.Add(label);
            }
        }

        private Label CreateLabel(string txt, bool wordLabel = false)
        {
            Label b = new Label();
            b.BorderStyle = BorderStyle.None;
            b.BackColor = Color.FromArgb(240, 237, 254);
            b.ForeColor = Color.FromArgb(48, 48, 87);
            b.AutoSize = false;
            b.Size = new System.Drawing.Size(250, 30);
            b.Margin = new Padding(3, 0, 3, 0);
            b.Dock = DockStyle.Left;
            b.Font = new Font("Bahnschrift Light", 13.8f);
            b.Text = txt;
            if (wordLabel)
            {
                b.Font = new Font("Bahnschrift Light", 13.8f, FontStyle.Underline);
                b.Cursor = Cursors.Hand;
                b.MouseClick += WordFound;
            }

            return b;
        }

        private void WordFound(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.SwitchForm(new WordForm(((Label)sender).Text.Replace(' ', '_')),
                 FormType.Weak);
        }
    }

}
