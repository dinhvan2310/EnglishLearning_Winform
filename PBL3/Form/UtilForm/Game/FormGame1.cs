
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

namespace PBL3
{
    public partial class FormGame1 : Form
    {
        private List<QnA> _Questions;
        private QnA _CurrentQuestion;
        private RJButton[] _AnsOptions;
        private Button _CurrentBtn;
        private int _CorrectAnsCount;
        public FormGame1()
        {
            InitializeComponent();
            InitializeVariables();
            StartGame();
        }
        private void InitializeVariables()
        {
            _AnsOptions = new RJButton[4];
            _AnsOptions[0] = btnAnsA;
            _AnsOptions[1] = btnAnsB;
            _AnsOptions[2] = btnAnsC;
            _AnsOptions[3] = btnAnsD;
        }
        private void StartGame()
        {
            _Questions = MiniGameWorkflow.Instance.GetWordFor_Game1();
            _CorrectAnsCount = 0;

            SetQuestion();
        }
        private void SetQuestion()
        {
            int index = _Questions.Count - 1;
            _CurrentQuestion = _Questions[index];
            btnQuestion.Text = _CurrentQuestion._Question;

            for (int i = 0; i < _AnsOptions.Count(); ++i)
                _AnsOptions[i].Text = _CurrentQuestion._Answers[i].word;

            _Questions.RemoveAt(index);
        }
        private void btnAnswer_click(object sender, EventArgs e)
        {
            if (btnNext.Visible == false)
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
                bool correctAns = (_CurrentBtn.Text == _CurrentQuestion._RightAnswer.word);

                DataManager dm = new DataManager();
                
                ShowAnswer(correctAns);

                if (correctAns)
                {
                    _CorrectAnsCount++;
                    dm.NotebookManager.Update_LearnedPercent(LoginWorkflow.Instance.GetAccount().AccountID, _CurrentQuestion._RightAnswer.word, 10);
                }

                btnNext.Visible = true;

                btnCheck.BackColor = Color.FromArgb(96, 88, 134);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            img_Change();
            ResetCurrentBtn();

            btnNext.Visible = false;
            iconIncorrect.Visible = false;
            iconCorrect.Visible = false;
            rjButton2.BackColor = Color.FromArgb(48, 48, 87);

            if (_Questions.Count != 0)
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
        private void ShowAnswer(bool state)
        {
            if (state == true)
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
            iconIncorrect.Visible = !state;
            iconCorrect.Visible = state;
            btnCheck.Enabled = false;
        }
        private void ResetCurrentBtn()
        {
            _CurrentBtn.BackColor = Color.FromArgb(48, 48, 87);
            _CurrentBtn.ForeColor = Color.FromArgb(237, 233, 253);
            _CurrentBtn = null;
        }
        private void img_Change()
        {
            if (_CorrectAnsCount < 2)
                imgFlower.BackgroundImage = (System.Drawing.Image)(Properties.Resources.Flower_5);

            else if (_CorrectAnsCount < 4)
                imgFlower.BackgroundImage = (System.Drawing.Image)(Properties.Resources.Flower_4);

            else if (_CorrectAnsCount < 6)
                imgFlower.BackgroundImage = (System.Drawing.Image)(Properties.Resources.Flower_3);

            else if (_CorrectAnsCount < 8)
                imgFlower.BackgroundImage = (System.Drawing.Image)(Properties.Resources.Flower_2);

            else if (_CorrectAnsCount < 10)
                imgFlower.BackgroundImage = (System.Drawing.Image)(Properties.Resources.Flower_1);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form messageBox = new FormMessageBox("XÁC NHẬN", "Bạn có chắc muốn thoát Minigame không ?", FormMessageBox.MessageType.Option);
            messageBox.StartPosition = FormStartPosition.CenterScreen;
            if (messageBox.ShowDialog() == DialogResult.OK)
                GlobalForm.MainForm.GoBack();
        }
    }
}
