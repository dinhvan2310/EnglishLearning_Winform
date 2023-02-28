using PBLLibrary.Models;
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
using PBLLibrary;

namespace PBL3
{
    public partial class WordForm_Meaning : Form
    {

        private List<Label> _typeLabels = new List<Label>();
        private List<RichTextBox> _definitionTextBoxes = new List<RichTextBox>();

        private int _currentTypeLabelIndex;


        public WordForm_Meaning(string rawWord, List<SynsetModel> synsets)
        {
            InitializeComponent();

            SetupForm(rawWord, synsets);
        }


        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (btnFavorite.IconFont == FontAwesome.Sharp.IconFont.Regular)
            {
                btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
            else
            {
                btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Regular;
            }
        }

        private void WordForm_Meaning_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Hello");
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private void txtDefSet_MouseClick(object sender, MouseEventArgs e)
        {
            HideCaret(((RichTextBox)sender).Handle);
        }

        private void SetupForm(string rawWord, List<SynsetModel> synsets)
        {
            lblWord.Text = rawWord.Replace('_', ' ');

            string txtString = string.Empty;
            string verbText = string.Empty;
            string nounText = string.Empty;
            string adjText = string.Empty;
            string advText = string.Empty;
            foreach (SynsetModel ss in synsets)
            {
                int j = 0;
                int i = ss.Definition.IndexOf(';');
                if (i == -1)
                    txtString += ss.Definition + ".\n\n";
                else
                    txtString += ss.Definition.Substring(j, i) + ".\n\n";

                while (i != -1)
                {
                    j = i;
                    i = ss.Definition.IndexOf(';', j + 1);

                    string sentence = "";
                    if (i == -1)
                        sentence = ss.Definition.Substring(j + 2);
                    else
                        sentence = ss.Definition.Substring(j + 2, i - j - 2);

                    if (sentence.Contains(rawWord))
                    {
                        txtString += "\t• " + sentence.Trim('"') + ".\n\n";
                    }
                }

                int synsetType = ss.ID / 100000000;
                switch (synsetType)
                {
                    case 1:
                        nounText += txtString;
                        break;
                    case 2:
                        verbText += txtString;
                        break;
                    case 3:
                        adjText += txtString;
                        break;
                    case 4:
                        advText += txtString;
                        break;
                }

                txtString = string.Empty;
            }

            if (verbText.Length > 0)
            {
                _typeLabels.Add(InstanceTypeLabel("VERB", new System.Drawing.Point(12 + 200 * _typeLabels.Count, 14)));
                _definitionTextBoxes.Add(InstanceDefinitionTB(verbText));
            }
            if (nounText.Length > 0)
            {
                _typeLabels.Add(InstanceTypeLabel("NOUN", new System.Drawing.Point(12 + 200 * _typeLabels.Count, 14)));
                _definitionTextBoxes.Add(InstanceDefinitionTB(nounText));
            }
            if (adjText.Length > 0)
            {
                _typeLabels.Add(InstanceTypeLabel("ADJECTIVE", new System.Drawing.Point(12 + 200 * _typeLabels.Count , 14)));
                _definitionTextBoxes.Add(InstanceDefinitionTB(adjText));
            }
            if (advText.Length > 0)
            {
                _typeLabels.Add(InstanceTypeLabel("ADVERB", new System.Drawing.Point(12 + 200 * _typeLabels.Count, 14)));
                _definitionTextBoxes.Add(InstanceDefinitionTB(advText));
            }

            _definitionTextBoxes[0].Visible = true;
            _currentTypeLabelIndex = 0;

        }

        private Label InstanceTypeLabel(string name, System.Drawing.Point location)
        {
            Label result = new Label();
            panelInfo.Controls.Add(result);
            result.BackColor = Color.FromArgb(240, 237, 254);
            result.ForeColor = Color.FromArgb(44, 41, 74);
            result.FlatStyle = FlatStyle.Flat;
            result.AutoSize = true;
            result.Text = name;
            result.Font = new Font("Century Gothic", 16.2f,
                System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            result.Size = new System.Drawing.Size(result.Size.Width, 34);
            result.Location = location;
            result.Cursor = Cursors.Hand;
            result.MouseClick += LabelType_MouseClick;
            result.BringToFront();

            return result;
        }

        private RichTextBox InstanceDefinitionTB(string definition)
        {
            RichTextBox result = new RichTextBox();
            panelInfo.Controls.Add(result);
            result.BackColor = Color.FromArgb(240, 237, 254);
            result.ForeColor = Color.FromArgb(44, 41, 74);
            result.BorderStyle = BorderStyle.None;
            result.Font = new Font("Century Gothic", 13.8f);
            result.Multiline = true;
            result.ScrollBars = RichTextBoxScrollBars.Vertical;
            result.Size = new System.Drawing.Size(977, 269);
            result.Location = new System.Drawing.Point(16, 83);
            result.Text = definition;
            result.ReadOnly = true;
            result.TabStop = false;
            result.MouseClick += txtDefSet_MouseClick;
            result.Visible = false;
            result.BringToFront();

            return result;
        }


        private void LabelType_MouseClick(object sender, MouseEventArgs e)
        {
            string type = ((Label)sender).Text;
            int indexInList = _typeLabels.FindIndex(a => a.Text == type);

            if (indexInList != _currentTypeLabelIndex)
            {
                _definitionTextBoxes[indexInList].Visible = true;
                _definitionTextBoxes[_currentTypeLabelIndex].Visible = false;

                _currentTypeLabelIndex = indexInList;

                underlineBarAnim.Start();
            }
        }

        private void underlineBarAnim_Tick(object sender, EventArgs e)
        {
            if (underlineBar.Location.X == _currentTypeLabelIndex * 200 + 15)
            {
                underlineBarAnim.Stop();
                return;
            }

            float smoothValue = (underlineBar.Location.X) * 0.75f + (_currentTypeLabelIndex * 200 + 15) * 0.25f;
            underlineBar.Location = new System.Drawing.Point((int)smoothValue, underlineBar.Location.Y);
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (SoundConfig.IsSpeaking)
            {
                return;
            }

            Task.Run(() => {
                SoundConfig.IsSpeaking = true;
                SoundConfig.Speak(lblWord.Text);
                SoundConfig.IsSpeaking = false;
            });
        }

    }
}
