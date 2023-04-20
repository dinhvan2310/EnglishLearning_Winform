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
using CustomControls;
using System.Windows.Media.Media3D;
using EFramework.Model;

namespace PBL3
{
    public partial class FormHome : Form
    {
        private const int _SuggestedWordCount = 10;

        private int _CurrentWordEveryDayIndex = 0;
        private List<wn_word> _WordsEveryDay;

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
            btnSugWord.Text = _WordsEveryDay[0].word;
            UpdateComprehensiveStat();
            UpdateOnlineGoal();
        }

        private void UpdateComprehensiveStat()
        {
            if (!LoginWorkflow.Instance.IsLoggedIn())
                return;
            txtDay.Text = LoginWorkflow.Instance.GetAccountDetail().NumberOfConsecutiveDay.ToString();
            txtWord.Text = LoginWorkflow.Instance.GetNumberOfLearnedWord().ToString();
            txtHour.Text = Convert.ToInt32(LoginWorkflow.Instance.GetNumberOfLearnedHour()).ToString();
        }

        private void UpdateOnlineGoal()
        {
            if (!LoginWorkflow.Instance.IsLoggedIn())
                return;
            int onlineMinute = Convert.ToInt32(LoginWorkflow.Instance.GetNumberOfLearnedMinute_Today());
            lblCurrent.Text = onlineMinute.ToString();
            lblGoal.Text = SettingWorkflow.Instance.GetUserSettings(LoginWorkflow.Instance.GetAccount().AccountID).Goal.ToString();
            int progressBarValue = (int)(onlineMinute / Convert.ToDouble(lblGoal.Text) * 100);
            progressBar.Value = (progressBarValue <= 100) ? progressBarValue : 100;
            iconPercent.Text = progressBar.Value + " %";
        }

        private void UpdateNotebook()
        {
            panelNotebook.Controls.Clear();

            DataManager dm = new DataManager();
            List<NotebookCard> words = dm.NotebookManager.GetNotebookWord_All(LoginWorkflow.Instance.GetAccount().AccountID);
            words.ForEach(w =>
            {
                panelNotebook.Controls.Add(CreateButtonWord(w.Word, w.LearnedPercent));
            });
        }

        private Button CreateButtonWord(string word, int learnedPercent)
        {
            RJButton btn = new RJButton();

            btn.Text = word;
            btn.Name = word;
            btn.Size = new Size(150 + Math.Max(0, word.Length - 8) * 15, 50);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(
                "Theme3_" + learnedPercent / 20);
            btn.BorderRadius = 20;
            btn.ForeColor = Color.FromArgb(240, 237, 254);
            btn.BackColor = Color.FromArgb(44, 41, 74);
            btn.BackgroundColor = Color.FromArgb(44, 41, 74);
            btn.Font = new Font("Bahnschrift", 13.8f, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.MouseClick += WordFound_MouseClick;
            panelNotebook.Controls.Add(btn);

            return btn;
        }
        private void InitializeVariables()
        {
            DataManager dm = new DataManager();
            _WordsEveryDay = dm.EDictionaryManager.GetWord_Random(_SuggestedWordCount);
            foreach (wn_word word in _WordsEveryDay)
            {
                word.word = word.word.ToUpper().Replace('_', ' ');
            }
        }

        private void SetGoal(int goal)
        {
            lblGoal.Text = goal.ToString();
            if (!LoginWorkflow.Instance.IsLoggedIn())
                return;
            SettingWorkflow.Instance.SetUserGoal(LoginWorkflow.Instance.GetAccount().AccountID, Convert.ToInt32(goal.ToString()));
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
            FormSetGoal form = new FormSetGoal();
            form.Callback += SetGoal;
            GlobalForm.MainForm.SwitchForm(form, FormType.Weak);
        }

        private void FormHome_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
                return;

            UpdateNotebook();
        }

        private void WordFound_MouseClick(object sender, EventArgs e)
        {
            GlobalForm.MainForm.SwitchForm(new WordForm(((Button)sender).Text.Replace(' ', '_')), FormType.Weak);
        }

        private void updateGoalTick_Tick(object sender, EventArgs e)
        {
            UpdateComprehensiveStat();
            UpdateOnlineGoal();
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
                btnSugWord.Text = _WordsEveryDay[_CurrentWordEveryDayIndex].word;
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
                btnSugWord.Text = _WordsEveryDay[_CurrentWordEveryDayIndex].word;
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
