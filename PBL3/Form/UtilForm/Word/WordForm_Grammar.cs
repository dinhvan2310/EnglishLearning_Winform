using BLL.TransferObjects;
using BLL.Workflows;
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
        private List<WordModel> _Deriveds;
        public WordForm_Grammar(string rawWord)
        {
            InitializeComponent();

            DataManager dm = new DataManager();
            _VerbFrames = dm.EDictionaryManager.GetVerbFrame_ByWord(rawWord);
            _Deriveds = dm.EDictionaryManager.GetWord_ByDerived(rawWord);

            SetupUI();
        }

        private void SetupUI()
        {
            foreach (string s in _VerbFrames)
            {
                Label b = CreateLabel(s);
                panelFrames.Controls.Add(b);
            }

            foreach (WordModel d in _Deriveds)
            {
                Label b = CreateLabel(d.Word.Replace('_', ' '), true);
                panelDeriveds.Controls.Add(b);
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
                b.Cursor = Cursors.Hand;
                b.MouseClick += WordFound;
            }

            return b;
        }

        private void WordFound(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.OpenChildForm(new WordForm(((Label)sender).Text.Replace(' ', '_')),
                 FormType.Neutral);
        }
    }

}
