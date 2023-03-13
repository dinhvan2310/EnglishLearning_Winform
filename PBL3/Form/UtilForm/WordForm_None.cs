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

namespace PBL3
{
    public partial class WordForm_None : Form
    {
        private string _rawWord;

        private Label[] _lblWords = new Label[8];
        public WordForm_None( string rawWord)
        {
            InitializeComponent();

            _rawWord = rawWord;

            lblWord.Text = rawWord;

            _lblWords[0] = lblWordFound1;
            _lblWords[1] = lblWordFound2;
            _lblWords[2] = lblWordFound3;
            _lblWords[3] = lblWordFound4;
            _lblWords[4] = lblWordFound5;
            _lblWords[5] = lblWordFound6;
            _lblWords[6] = lblWordFound7;
            _lblWords[7] = lblWordFound8;

            List<WordModel> words = GlobalConfig.GetWord_ByFilter_Random(rawWord[0] + "%", 8, true);

            int i = 0;
            foreach (Label lbl in _lblWords)
            {
                lbl.Text = words[i++].Word.Replace('_', ' ');
            }

        }

        private void lblWordFound1_MouseClick(object sender, MouseEventArgs e)
        {
            ((MainForm)Application.OpenForms["MainForm"]).OpenChildForm(new WordForm(((Label)sender).Text.Replace(' ', '_')),
                FormStack.FormType.Neutral);
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            ((MainForm)Application.OpenForms["MainForm"]).OpenChildForm(FormStack.Pop(), FormStack.FormType.Strong);
        }
    }
}
