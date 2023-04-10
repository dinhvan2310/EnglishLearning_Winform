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

using BLL.TransferObjects;
using PBL3.Utilities;
using BLL.Workflows;

namespace PBL3
{
    public partial class WordForm_Meaning : Form
    {

        private List<Label> _TypeLabels = new List<Label>();
        private List<RichTextBox> _DefinitionTextBoxes = new List<RichTextBox>();

        private int _CurrentTypeLabelIndex;

        readonly private string[] _PartOfSpeech = new string[] { "VERB", "NOUN", "ADJECTIVE", "ADVERB" };


        public WordForm_Meaning(string rawWord)
        {
            InitializeComponent();

            SetupForm(rawWord);
        }

        #region HELPER FUNCTIONS

        private void SetupForm(string rawWord)
        {
            lblWord.Text = rawWord.Replace('_', ' ');

            DataManager dm = new DataManager();
            List<string> definition = dm.EDictionaryManager.GetDefinition_ByWord(rawWord);

            for (int i = 0; i < 4; ++i)
            {
                if (definition[i].Length > 0)
                {
                    _TypeLabels.Add(InstanceTypeLabel(_PartOfSpeech[i],
                        new System.Drawing.Point(12 + 200 * _TypeLabels.Count, 14)));
                    _DefinitionTextBoxes.Add(InstanceDefinitionTB(definition[i]));
                }
            }

            _DefinitionTextBoxes[0].Visible = true;
            _CurrentTypeLabelIndex = 0;
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

        #endregion

        #region EVENTS
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

        private void txtDefSet_MouseClick(object sender, MouseEventArgs e)
        {
            ExternalImport.HideCaret(((RichTextBox)sender).Handle);
        }

        private void LabelType_MouseClick(object sender, MouseEventArgs e)
        {
            string type = ((Label)sender).Text;
            int indexInList = _TypeLabels.FindIndex(a => a.Text == type);

            if (indexInList != _CurrentTypeLabelIndex)
            {
                _DefinitionTextBoxes[indexInList].Visible = true;
                _DefinitionTextBoxes[_CurrentTypeLabelIndex].Visible = false;

                _CurrentTypeLabelIndex = indexInList;

                underlineBarAnim.Start();
            }
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

        #endregion

        #region ANIMATIONS
        private void underlineBarAnim_Tick(object sender, EventArgs e)
        {
            if (underlineBar.Location.X == _CurrentTypeLabelIndex * 200 + 15)
            {
                underlineBarAnim.Stop();
                return;
            }

            float smoothValue = (underlineBar.Location.X) * 0.75f + (_CurrentTypeLabelIndex * 200 + 15) * 0.25f;
            underlineBar.Location = new System.Drawing.Point((int)smoothValue, underlineBar.Location.Y);
        }
        #endregion

    }
}
