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
        private RJButton[] _AnsOptions;
        private Button _CurrentLeftBtn;
        private Button _CurrentRightBtn;
        private List<Tuple<string, string>> _Question;
        private int _CorrectAnswerCount;
        private int _WrongAnswerCount;

        public FormGame2()
        {
            InitializeComponent();
            InitializeVariables();
        }
        private void InitializeVariables()
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

            Start_Game();
        }
        private void Start_Game()
        {
            _WrongAnswerCount = 0;
            _CorrectAnswerCount = 0;
            _Question = MiniGameWorkflow.Instance.GetWordFor_Game2();
            Set_Question();
        }
        private void Set_Question()
        {
            Random a = new Random();
            var numbersLeft = Enumerable.Range(0, 4).OrderBy(x => a.Next()).Take(4).ToList();
            var numbersRight = Enumerable.Range(4, 4).OrderBy(x => a.Next()).Take(4).ToList();

            btnNext.Enabled = false;

            for (int i = 0; i < 4; ++i)
            {
                _AnsOptions[numbersLeft[i]].Text = _Question[i].Item1;
                _AnsOptions[numbersLeft[i]].Enabled = true;

                _AnsOptions[numbersRight[i]].Text = _Question[i].Item2;
                _AnsOptions[numbersRight[i]].Enabled = true;
            }
        }
        private void CheckAns()
        {
            if (_CurrentRightBtn != null && _CurrentLeftBtn != null)
            {
                Tuple<string, string> temp = new Tuple<string, string>(_CurrentLeftBtn.Text, _CurrentRightBtn.Text);
                if (_Question.Contains(temp) == false)
                {
                    _CurrentLeftBtn.BackColor = Color.FromArgb(255, 75, 75);
                    _CurrentRightBtn.BackColor = Color.FromArgb(255, 75, 75);
                    _WrongAnswerCount = _WrongAnswerCount + 1;
                }
                else
                {
                    _CorrectAnswerCount = _CorrectAnswerCount + 1;
                    
                    _CurrentRightBtn.BackColor = Color.FromArgb(88, 204, 2);
                    _CurrentLeftBtn.BackColor = Color.FromArgb(88, 204, 2);

                    DataManager dm = new DataManager();
                    int accountID = LoginWorkflow.Instance.GetAccount().AccountID;
                    string notebookWord = _CurrentLeftBtn.Text;
                    dm.NotebookManager.Update_LearnedPercent(accountID, notebookWord, 10);

                    _CurrentLeftBtn.Enabled = false;
                    _CurrentRightBtn.Enabled = false;
                }
                timer1.Start();
            }

        }
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

            if (_CorrectAnswerCount == 4)
            {
                _CorrectAnswerCount = 0;
                _Question.RemoveRange(0, 4);
                btnNext.Enabled = true;
                btnNext.BackColor = Color.FromArgb(237, 233, 253);
                btnNext.ForeColor = Color.FromArgb(48, 48, 87);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Question.Count != 0)
            {
                Set_Question();
                btnNext.ForeColor = Color.FromArgb(237, 233, 253);
                btnNext.BackColor = Color.FromArgb(48, 48, 87);
            }    
            else
            {
                Form messageBox = new FormMessageBox("KẾT QUẢ", $"SỐ LẦN TRẢ LỜI SAI: {_WrongAnswerCount} \n" +
                                                                $"SỐ XU NHẬN ĐƯỢC: {_CorrectAnswerCount}",
                                      FormMessageBox.MessageType.Info);

                LoginWorkflow.Instance.AdjustBalance(_CorrectAnswerCount);

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
    }
}
