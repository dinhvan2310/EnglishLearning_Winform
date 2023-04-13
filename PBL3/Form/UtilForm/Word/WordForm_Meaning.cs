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

        private string _RawWord;
        private bool _IsEE;

        private List<Label> _TypeLabels = new List<Label>();
        private List<RichTextBox> _DefinitionTextBoxes = new List<RichTextBox>();

        private int _CurrentTypeLabelIndex;

        readonly private string[] _EPoS = new string[] { "VERB", "NOUN", "ADJECTIVE", "ADVERB" };
        readonly private string[] _VPoS = new string[] { "DANH TỪ", "ĐỘNG TỪ", "TÍNH TỪ", "PHÓ TỪ", "THÁN TỪ" };


        public WordForm_Meaning(string rawWord, bool isEE = true)
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
            lblWord.Text = _RawWord.Replace('_', ' ');

            DataManager dm = new DataManager();
            List<string> definition = null;
            if (_IsEE)
                definition = dm.EDictionaryManager.GetDefinition_ByWord(_RawWord);
            else
                definition = dm.VDictionaryManager.GetDefinition_ByWord(_RawWord);

            int count = _IsEE ? 4 : 5;
            for (int i = 0; i < count; ++i)
            {
                if (definition[i].Length > 0)
                {
                    _TypeLabels.Add(InstanceTypeLabel(_IsEE ? _EPoS[i] : _VPoS[i],
                        new System.Drawing.Point(12 + 200 * _TypeLabels.Count, 14)));
                    _DefinitionTextBoxes.Add(InstanceDefinitionTB(definition[i]));
                }
            }

            _DefinitionTextBoxes[0].Visible = true;
            _CurrentTypeLabelIndex = 0;
        }

        private void SetupUI()
        {
            btnFavorite.Visible = _IsEE;

            if (!_IsEE)
                return;

            if (LoginWorkflow.Instance.IsLoggedIn())
            {   
                DataManager dm = new DataManager();
                if (dm.NotebookManager.CheckWordIsExistInNotebook(
                    LoginWorkflow.Instance.GetAccount().AccountID,
                    _RawWord))
                {
                    btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Solid;
                }
            }
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
            FontFamily font = new FontFamily(_IsEE ? "Century Gothic" : "Bahnschrift Condensed");
            result.Font = new Font(font, 16.2f,
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
            FontFamily font = new FontFamily(_IsEE ? "Century Gothic" : "Bahnschrift Condensed");
            result.Font = new Font(font, 13.8f);
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
            if (!LoginWorkflow.Instance.IsLoggedIn())
            {
                FormMessageBox form = new FormMessageBox(
                    "Chưa đăng nhập",
                    "Vui lòng đăng nhập để sử dụng",
                    FormMessageBox.MessageType.Info);

                form.ShowDialog();

                return;
            }
            DataManager dm = new DataManager();

            int UID = LoginWorkflow.Instance.GetAccount().AccountID;

            if (dm.NotebookManager.GetNotebookCount(UID) >= 50)
            {
                FormMessageBox form = new FormMessageBox(
                    "Sổ tay đầy",
                    "Sổ tay của bạn đã đến giới hạn",
                    FormMessageBox.MessageType.Info);

                form.ShowDialog();

                return;
            }
            

            if (btnFavorite.IconFont == FontAwesome.Sharp.IconFont.Regular) // favorite
            {
                btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Solid;
                dm.NotebookManager.AddWord(UID, _RawWord);
            }
            else // unfavorite
            {
                FormMessageBox form = new FormMessageBox(
                    "Xác nhận xoá",
                    "Bạn có muốn xoá khỏi Notebook không?",
                    FormMessageBox.MessageType.Option);

                if (form.ShowDialog() != DialogResult.OK)
                    return;

                btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Regular;
                dm.NotebookManager.RemoveWord(UID, _RawWord);
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
