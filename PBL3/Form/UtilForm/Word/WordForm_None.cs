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
using System.Windows.Forms;

namespace PBL3
{
    public partial class WordForm_None : Form
    {
        private string _RawWord;

        private Label[] _LblWords = new Label[8];
        public WordForm_None( string rawWord)
        {
            InitializeComponent();

            _RawWord = rawWord;

            lblWord.Text = rawWord;

            _LblWords[0] = lblWordFound1;
            _LblWords[1] = lblWordFound2;
            _LblWords[2] = lblWordFound3;
            _LblWords[3] = lblWordFound4;
            _LblWords[4] = lblWordFound5;
            _LblWords[5] = lblWordFound6;
            _LblWords[6] = lblWordFound7;
            _LblWords[7] = lblWordFound8;

            DataManager dm = new DataManager();
            List<WordModel> words = dm.EDictionaryManager.GetWord_ByFilter_Random(rawWord[0] + "%", 8, true);

            int i = 0;
            foreach (Label lbl in _LblWords)
            {
                lbl.Text = words[i++].Word.Replace('_', ' ');
            }

        }

        private void lblWordFound1_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.SwitchForm(new WordForm(((Label)sender).Text.Replace(' ', '_')),
                FormType.Weak);
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.GoBack();
        }
    }
}
