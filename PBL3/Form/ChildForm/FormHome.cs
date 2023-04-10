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

using BLL.TransferObjects;
using BLL.Workflows;
using PBL3.Utilities;
using BLL.Components;

namespace PBL3
{
    public partial class FormHome : Form
    {
        private const int _SuggestedWordCount = 10;

        private int _CurrentWordEveryDayIndex = 0;
        private List<WordModel> _WordsEveryDay;

        private bool _ReverseState = false;

        public FormHome()
        {
            InitializeComponent();

            SetupForm();
            SetupUI();

        }

        #region HELPER FUNCTIONS
        private void SetupForm()
        {
            InitializeVariables();
        }
        private void SetupUI()
        {
            btnSugWord.Text = _WordsEveryDay[0].Word;
        }

        private void InitializeVariables()
        {
            DataManager dm = new DataManager();
            _WordsEveryDay = dm.EDictionaryManager.GetWord_Random(_SuggestedWordCount);
            foreach (WordModel word in _WordsEveryDay)
            {
                word.Word = word.Word.ToUpper().Replace('_', ' ');
            }
        }

        private bool IsSuggestWordAnimation()
        {
            return sugWordLeftAnim.Enabled || sugWordRightAnim.Enabled;
        }
        #endregion

        #region EVENTS
        private void btnForward_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsSuggestWordAnimation())
                return;
            _CurrentWordEveryDayIndex = (_CurrentWordEveryDayIndex + 1) % _WordsEveryDay.Count;

            _ReverseState = false;
            sugWordLeftAnim.Start();
        }

        private void btnBackward_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsSuggestWordAnimation())
                return;
            _CurrentWordEveryDayIndex = (_CurrentWordEveryDayIndex - 1) < 0 ? _WordsEveryDay.Count - 1 : (_CurrentWordEveryDayIndex - 1);

            _ReverseState = false;
            sugWordRightAnim.Start();
        }
        private void btnSugWord_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.SwitchForm(new WordForm(btnSugWord.Text.Replace(' ', '_').ToLower()),
                FormType.Weak);
        }

        private void btnSetGoal_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.SwitchForm(new FormSetGoal(), FormType.Weak);
        }
        #endregion

        #region ANIMATIONS
        private void swapWordAnim_Tick(object sender, EventArgs e)
        {
            if (IsSuggestWordAnimation())
                return;
            _CurrentWordEveryDayIndex = (_CurrentWordEveryDayIndex + 1) % _WordsEveryDay.Count;

            _ReverseState = false;
            sugWordLeftAnim.Start();
        }

        
        private void sugWordLeftAnim_Tick(object sender, EventArgs e)
        {
            if (btnSugWord.Location.X <= -400)
            {
                _ReverseState = true;
                btnSugWord.Location = new Point(400, 0);
                btnSugWord.Text = _WordsEveryDay[_CurrentWordEveryDayIndex].Word;
            }
            else
            {
                if (_ReverseState && btnSugWord.Location.X == 0)
                {
                    sugWordLeftAnim.Stop();
                    _ReverseState = false;
                    return;
                }
                btnSugWord.Location = new Point(btnSugWord.Location.X - 50, 0);
            }

        }

        private void sugWordRightAnim_Tick(object sender, EventArgs e)
        {
            if (btnSugWord.Location.X >= 400)
            {
                _ReverseState = true;
                btnSugWord.Location = new Point(-400, 0);
                btnSugWord.Text = _WordsEveryDay[_CurrentWordEveryDayIndex].Word;
            }
            else
            {
                if (_ReverseState && btnSugWord.Location.X == 0)
                {
                    sugWordRightAnim.Stop();
                    _ReverseState = false;
                    return;
                }
                btnSugWord.Location = new Point(btnSugWord.Location.X + 50, 0);
            }
        }
        #endregion

    }
}
