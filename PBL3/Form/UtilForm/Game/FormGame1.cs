
using BLL.TransferObjects;
using PBLLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using CustomControls;
using PBL3.Utilities;
using EFramework.Model;
using EFramework;
using BLL.Workflows;
using PBL3.Properties;

namespace PBL3
{
    public partial class FormGame1 : Form
    {
        private List<QnA> _Questions;

        private Button[] _AnsOptions;
        private Button _CurrentBtn;

        private int _CorrectAnsCount;
        private int _QuestionIndex = -1;
        public FormGame1()
        {
            InitializeComponent();

            SetupForm();
            SetupUI();
        }

        #region HELPER FUNCTIONS
        private void SetupUI()
        {
            SetQuestion();
        }

        private void SetupForm()
        {
            _AnsOptions = new RJButton[4];
            _AnsOptions[0] = btnAnsA;
            _AnsOptions[1] = btnAnsB;
            _AnsOptions[2] = btnAnsC;
            _AnsOptions[3] = btnAnsD;

            _Questions = MiniGameWorkflow.Instance.GetWordFor_Game1();
            _CorrectAnsCount = 0;
        }

        private void SetQuestion()
        {
            QnA currentQuest = _Questions[++_QuestionIndex];
            btnQuestion.Text = currentQuest.Question;

            for (int i = 0; i < _AnsOptions.Count(); ++i)
                _AnsOptions[i].Text = currentQuest.Answers[i];
        }

        private void ShowAnswer(bool correct)
        {
            btnNext.Visible = true;
            btnCheck.BackColor = Color.FromArgb(96, 88, 134);

            if (correct == true)
            {
                rjButton2.BackColor = Color.FromArgb(215, 255, 184);
                btnNext.BackColor = Color.FromArgb(118, 185, 71);
            }
            else
            {
                rjButton2.BackColor = Color.FromArgb(247, 190, 192);
                btnNext.BackColor = Color.FromArgb(231, 98, 95);
            }

            btnNext.ForeColor = Color.FromArgb(237, 233, 253);
            iconIncorrect.Visible = !correct;
            iconCorrect.Visible = correct;
            btnCheck.Enabled = false;
        }
        private void ResetCurrentBtn()
        {
            _CurrentBtn.BackColor = Color.FromArgb(48, 48, 87);
            _CurrentBtn.ForeColor = Color.FromArgb(237, 233, 253);
            _CurrentBtn = null;
        }
        private void UpdateImage()
        {
            int imageIndex = (int)Math.Floor(_CorrectAnsCount * -0.5 + 5.5);
            imgFlower.BackgroundImage = (Image)Resources.ResourceManager.GetObject("Flower_" + imageIndex);
        }

        #endregion

        #region EVENTS

        private void btnAnswer_click(object sender, EventArgs e)
        {
            if (!btnNext.Visible)
            {
                if (_CurrentBtn != null)
                    ResetCurrentBtn();

                _CurrentBtn = (Button)sender;
                _CurrentBtn.BackColor = Color.FromArgb(237, 233, 253);
                _CurrentBtn.ForeColor = Color.FromArgb(48, 48, 87);

                btnCheck.BackColor = Color.FromArgb(237, 233, 253);
                btnCheck.Enabled = true;
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (_CurrentBtn != null)
            {
                string rightAns = _Questions[_QuestionIndex].Answers[_Questions[_QuestionIndex].RightAnswerIndex];
                bool correctAns = _CurrentBtn.Text == rightAns;

                DataManager dm = new DataManager();
                
                ShowAnswer(correctAns);

                if (correctAns)
                {
                    _CorrectAnsCount++;
                    int userID = LoginWorkflow.Instance.GetAccount().AccountID;
                    if (dm.NotebookManager.CheckWordIsExistInNotebook(userID, rightAns.Replace(' ', '_')))
                        dm.NotebookManager.IncreaseLearnedPercent(LoginWorkflow.Instance.GetAccount().AccountID,
                            rightAns, 10);
                }

            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            UpdateImage();
            ResetCurrentBtn();

            btnNext.Visible = false;
            iconIncorrect.Visible = false;
            iconCorrect.Visible = false;
            rjButton2.BackColor = Color.FromArgb(48, 48, 87);

            if (_QuestionIndex != 9)
                SetQuestion();
            else
            {
                Form messageBox = new FormMessageBox("KẾT QUẢ", $"SỐ CÂU ĐÚNG: {_CorrectAnsCount} \n" +
                                                                $"SỐ XU NHẬN ĐƯỢC: {_CorrectAnsCount}",
                                      FormMessageBox.MessageType.Info);
                
                LoginWorkflow.Instance.AdjustBalance(_CorrectAnsCount);
                GlobalForm.MainForm.UpdateCoinView();

                if (messageBox.ShowDialog() == DialogResult.OK)
                    this.Close();
                GlobalForm.MainForm.GoBack();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form messageBox = new FormMessageBox("XÁC NHẬN", "Bạn có chắc muốn thoát Minigame không ?", FormMessageBox.MessageType.Option);
            messageBox.StartPosition = FormStartPosition.CenterScreen;
            if (messageBox.ShowDialog() == DialogResult.OK)
                GlobalForm.MainForm.GoBack();
        }
        #endregion
    }
}
