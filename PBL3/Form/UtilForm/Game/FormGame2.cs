using BLL.TransferObjects;
using BLL.Workflows;
using CustomControls;
using PBL3.Utilities;
using PBLLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormGame2 : Form
    {
        private Button[] _AnsOptions;
        private Button _CurrentLeftBtn;
        private Button _CurrentRightBtn;
        private List<QnA> _Questions;

        private int _WrongAnswerCount;
        private int _QuestionIndex;
        private int _AnsweredCount;

        public FormGame2()
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
            _AnsOptions = new RJButton[8];

            _AnsOptions[0] = btnLeft1;
            _AnsOptions[1] = btnLeft2;
            _AnsOptions[2] = btnLeft3;
            _AnsOptions[3] = btnLeft4;

            _AnsOptions[4] = btnRight1;
            _AnsOptions[5] = btnRight2;
            _AnsOptions[6] = btnRight3;
            _AnsOptions[7] = btnRight4;

            _WrongAnswerCount = 0;
            _Questions = MiniGameWorkflow.Instance.GetWordFor_Game2();
        }

        private void SetQuestion()
        {
            var numbersLeft = MiniGameWorkflow.Instance.GetListInt_Random(0, 4);
            var numbersRight = MiniGameWorkflow.Instance.GetListInt_Random(4, 4);

            btnNext.Enabled = false;

            for (int i = 0; i < 4; ++i)
            {
                QnA qna = _Questions[_QuestionIndex + i];

                _AnsOptions[numbersLeft[i]].Text = qna.Question;
                _AnsOptions[numbersLeft[i]].Enabled = true;

                _AnsOptions[numbersRight[i]].Text = qna.Answers[qna.RightAnswerIndex];
                _AnsOptions[numbersRight[i]].Enabled = true;
            }

        }
        private void CheckAns()
        {
            if (_CurrentRightBtn != null && _CurrentLeftBtn != null)
            {
                if (_Questions.Find(p => p.Question == _CurrentLeftBtn.Text).Answers[0] !=
                    _CurrentRightBtn.Text)
                {
                    _CurrentLeftBtn.BackColor = Color.FromArgb(255, 75, 75);
                    _CurrentRightBtn.BackColor = Color.FromArgb(255, 75, 75);
                    _WrongAnswerCount = _WrongAnswerCount + 1;
                }
                else
                {
                    _CurrentRightBtn.BackColor = Color.FromArgb(88, 204, 2);
                    _CurrentLeftBtn.BackColor = Color.FromArgb(88, 204, 2);

                    int userID = LoginWorkflow.Instance.GetAccount().AccountID;
                    DataManager dm = new DataManager();
                    string notebookWord = _CurrentLeftBtn.Text.Replace(' ', '_');
                    if (dm.NotebookManager.CheckWordIsExistInNotebook(userID, notebookWord))
                        dm.NotebookManager.IncreaseLearnedPercent(userID, notebookWord, 10);

                    _CurrentLeftBtn.Enabled = false;
                    _CurrentRightBtn.Enabled = false;

                    _AnsweredCount += 1;
                }
                timer1.Start();
            }

        }

        #endregion

        #region EVENTS
        private void btnLeftAns_click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (_CurrentLeftBtn != null)
                {
                    _CurrentLeftBtn.BackColor = Color.FromArgb(48, 48, 87);
                    _CurrentLeftBtn.ForeColor = Color.FromArgb(237, 233, 253);
                }

                _CurrentLeftBtn = (Button)sender;
                _CurrentLeftBtn.BackColor = Color.FromArgb(237, 233, 253);
                _CurrentLeftBtn.ForeColor = Color.FromArgb(48, 48, 87);
                CheckAns();
            }
        }
        private void btnRightAns_click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (_CurrentRightBtn != null)
                {
                    _CurrentRightBtn.BackColor = Color.FromArgb(48, 48, 87);
                    _CurrentRightBtn.ForeColor = Color.FromArgb(237, 233, 253);
                }    

                _CurrentRightBtn = (Button)sender;
                _CurrentRightBtn.BackColor = Color.FromArgb(237, 233, 253);
                _CurrentRightBtn.ForeColor = Color.FromArgb(48, 48, 87);

                CheckAns();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            _CurrentRightBtn.BackColor = Color.FromArgb(48, 48, 87);
            _CurrentRightBtn.ForeColor = Color.FromArgb(237, 233, 253);

            _CurrentLeftBtn.ForeColor = Color.FromArgb(237, 233, 253);
            _CurrentLeftBtn.BackColor = Color.FromArgb(48, 48, 87);

            _CurrentRightBtn = null;
            _CurrentLeftBtn = null;

            if (_AnsweredCount == 4)
            {
                _QuestionIndex += 4;

                btnNext.Enabled = true;
                btnNext.BackColor = Color.FromArgb(237, 233, 253);
                btnNext.ForeColor = Color.FromArgb(48, 48, 87);

                _AnsweredCount = 0;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_QuestionIndex < 20)
            {
                SetQuestion();
                btnNext.ForeColor = Color.FromArgb(237, 233, 253);
                btnNext.BackColor = Color.FromArgb(48, 48, 87);
            }    
            else
            {
                int coin = Math.Max(5, 20 - _WrongAnswerCount);
                Form messageBox = new FormMessageBox("KẾT QUẢ", $"SỐ LẦN TRẢ LỜI SAI: {_WrongAnswerCount} \n" +
                                                                $"SỐ XU NHẬN ĐƯỢC: {coin}",
                                      FormMessageBox.MessageType.Info);

                LoginWorkflow.Instance.AdjustBalance(coin);
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
