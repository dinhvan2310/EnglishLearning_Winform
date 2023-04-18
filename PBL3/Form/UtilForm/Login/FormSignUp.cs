using BLL.Workflows;
using CustomControls;
using EFramework.Model;
using FontAwesome.Sharp;
using PBL3.Utilities;
using PBLLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media.Media3D;
using Library;

namespace PBL3
{
    public partial class FormSignUp : Form
    {
        private Panel _CurrentPage;

        private bool[] _BarIsDirtys = new bool[8];
        private readonly string[] _BarStrings = new string[] { "Họ và Tên", "Giới Tính", "01/01/2003",
                                                    "Tên Tài Khoản", "Mật Khẩu", "Xác Nhận Mật Khẩu",
                                                    "Email", "Nhập Mã Xác Thực"};

        private TextBox[] _TxtPHHolders = new TextBox[8];

        private string _VerifyCode;

        public FormSignUp()
        {
            InitializeComponent();

            SetupUI();
            InitVariables();
        }

        private void InitVariables()
        {
            _TxtPHHolders[0] = txtName;
            _TxtPHHolders[1] = null;
            _TxtPHHolders[2] = txtDate;
            _TxtPHHolders[3] = txtUname;
            _TxtPHHolders[4] = txtPasswrd;
            _TxtPHHolders[5] = txtConPasswrd;
            _TxtPHHolders[6] = txtEmail;
            _TxtPHHolders[7] = txtVerify;
        }

        private void SetupUI()
        {
            panelBase.Controls.Add(panelPage1);
            panelBase.Controls.Add(panelPage2);
            panelBase.Controls.Add(panelEmail);

            panelEmail.Location = new Point(0, 0);
            panelPage1.Location = new Point(0, 0);
        }

        private void SwapPanel()
        {
            if (panelEmail.Visible)
            {
                panelEmail.Visible = false;
                
                panelVerify.Visible = false;
                txtVerify.Text = string.Empty;
                panelSlideEmail.Location = new Point(3, 63);

                btnPage1.Visible = true;
                btnPage2.Visible = true;
                panelPage1.Visible = true;
                _CurrentPage = panelPage1;

                btnReturn.Visible = true;
                btnResigter.Visible = true;
            }
            else
            {
                btnReturn.Visible = false;
                btnPage1.Visible = false;
                btnPage2.Visible = false;

                _CurrentPage.Visible = false;

                panelEmail.Visible = true;
                ActiveControl = txtEmail;
                txtEmail.ReadOnly = false;
                txtEmail.ForeColor = Color.FromArgb(240, 237, 254);
            }
        }

        /// <summary>
        /// Kiểm tra định dạnh của email
        /// </summary>
        /// <returns>true/false</returns>
        private bool ValidateEmail()
        {
            return LoginWorkflow.Instance.CheckEmail(txtEmail.Text);
        }

        /// <summary>
        /// Kiểm tra định dạng của dateTime
        /// </summary>
        /// <returns>null/DateTime</returns>
        private DateTime? ValidateDate()
        {
            return LoginWorkflow.Instance.CheckDate(txtDate.Text);
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            GlobalForm.LoginForm.OpenChildForm(new FormSignIn());
        }

        private void btnPage1_CheckedChanged(object sender, EventArgs e)
        {
            if (panelPage1.Visible)
            {
                _CurrentPage = panelPage2;
            }
            else
            {
                _CurrentPage = panelPage1;
            }

            _CurrentPage.Location = new Point(450, 0);
            slideAnim.Start();

            panelPage1.Visible = !panelPage1.Visible;

            panelPage2.Visible = !panelPage2.Visible;
        }

        private void slideAnim_Tick(object sender, EventArgs e)
        {
            if (_CurrentPage.Location.X == 0)
            {
                slideAnim.Stop();
                return;
            }

            _CurrentPage.Location = new Point(_CurrentPage.Location.X - 25, _CurrentPage.Location.Y);
        }

        private void txtPH_Enter(object sender, EventArgs e)
        {
            int index = ((TextBox)sender).TabIndex - 1;

            // validate color
            switch (index)
            {
                case 3:
                    iconUser.BackColor = Color.FromArgb(75, 65, 114);
                    break;
                case 4:
                    iconPassword.BackColor = Color.FromArgb(75, 65, 114);
                    break;
                case 5:
                    iconConfirmPassword.BackColor = Color.FromArgb(75, 65, 114);
                    break;
            }

            // not dirty
            if (!_BarIsDirtys[index])
            {
                _TxtPHHolders[index].Text = string.Empty;
                _TxtPHHolders[index].ForeColor = Color.FromArgb(240, 237, 254);

                
                if (index == 4)
                {
                    _TxtPHHolders[index].PasswordChar = '*';
                }
                if (index == 5)
                {
                    _TxtPHHolders[index].PasswordChar = '*';
                }
            }
        }

        private void txtPH_Leave(object sender, EventArgs e)
        {
            int index = ((TextBox)sender).TabIndex - 1;
            _BarIsDirtys[index] = _TxtPHHolders[index].Text.Length != 0;

            if (!_BarIsDirtys[index])
            {
                _TxtPHHolders[index].Text = _BarStrings[index];
                _TxtPHHolders[index].ForeColor = Color.FromArgb(119, 112, 156);

                switch (index)
                {
                    case 3:
                        _TxtPHHolders[index].PasswordChar = '\0';
                        break;
                    case 4:
                        _TxtPHHolders[index].PasswordChar = '\0';
                        break;
                }

            }
            else
            {
                switch (index)
                {
                    case 3: // username
                        if (!LoginWorkflow.Instance.CheckUsername(txtUname.Text))
                        {
                            iconUser.BackColor = Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
                        }
                        break;
                    case 4: // password
                        if (!LoginWorkflow.Instance.CheckPassword(txtPasswrd.Text))
                        {
                            iconPassword.BackColor = Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
                        }
                        break;
                    case 5: // confirmed Password
                        if (txtPasswrd.Text != txtConPasswrd.Text)
                        {
                            iconConfirmPassword.BackColor = Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
                        }
                        break;
                    case 2: // datetime
                        DateTime? dateTime = ValidateDate();
                        if (dateTime != null)
                        {
                            datePicker.Value = (DateTime)dateTime;
                        }
                        else
                        {
                            txtDate.Text = _BarStrings[2];
                            _BarIsDirtys[2] = false;
                            Form messageBox = new FormMessageBox("NHẬP SAI", "Nhập Sai Ngày Sinh", FormMessageBox.MessageType.Info);
                            messageBox.ShowDialog();
                        }
                        break;
                    // email
                    case 6:
                        if (txtEmail.ReadOnly)
                            break;
                        if (ValidateEmail())
                        {
                            _VerifyCode = GlobalConfig.Instance.GenerateVerifyCode();
                            LoginWorkflow.Instance.SendMessage(txtEmail.Text, "Verify Code",
                                "Mã Xác Thực cho tài khoản English Learning là: " + _VerifyCode);

                            _TxtPHHolders[index].ReadOnly = true;
                            _TxtPHHolders[index].ForeColor = Color.FromArgb(119, 112, 156);

                            panelVerify.Location = new Point(-474, panelVerify.Location.Y);
                            panelVerify.Visible = true;
                            childSlideAnim.Start();
                        }
                        else
                        {
                            Form messageBox = new FormMessageBox("NHẬP SAI", "Nhập Sai Email", FormMessageBox.MessageType.Info);
                            messageBox.ShowDialog();
                        }
                        break;
                    case 0:
                        {
                            if (txtName.Text == String.Empty)
                            {
                                iconName.ForeColor = Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
                            }
                        }
                        break;
                }
            }
        }

        

        private void cmbBoxGender_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            _BarIsDirtys[1] = true;
            cmbBoxGender.ForeColor = Color.FromArgb(240, 237, 254);
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            _BarIsDirtys[2] = true;
            txtDate.Text = datePicker.Text;
            txtDate.ForeColor = Color.FromArgb(240, 237, 254);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            IconButton button = (IconButton)sender;
            int index = button.TabIndex - 1;

            if (!_BarIsDirtys[index])
            {
                return;
            }

            if (_TxtPHHolders[index].PasswordChar == '*')
            {
                button.IconChar = FontAwesome.Sharp.IconChar.Eye;
                _TxtPHHolders[index].PasswordChar = '\0';
            }
            else
            {
                button.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                _TxtPHHolders[index].PasswordChar = '*';
            }
        }

        private void FormSignUp_MouseCaptureChanged(object sender, EventArgs e)
        {
            ActiveControl = null;
            ActiveControl = fakeTabStop;
        }

        private void childSlideAnim_Tick(object sender, EventArgs e)
        {
            if (panelSlideEmail.Location.Y > 3)
            {
                panelSlideEmail.Location = new Point(panelSlideEmail.Location.X, panelSlideEmail.Location.Y - 20);
            }

            if (panelVerify.Location.X < 24)
            {
                panelVerify.Location = new Point(panelVerify.Location.X + 50, panelVerify.Location.Y);
            }

            if (panelSlideEmail.Location.Y <= 3 && panelVerify.Location.X >= 24)
            {
                childSlideAnim.Stop();
                return;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActiveControl = null;
            }
        }


        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            SwapPanel();
        }

        private void lblChangeMail_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveControl = txtEmail;

            txtEmail.ReadOnly = false;
            txtEmail.ForeColor = Color.FromArgb(240, 237, 254);
        }

        private void txtVerify_TextChanged(object sender, EventArgs e)
        {
            if (txtVerify.Text.Length == 6)
            {
                if (txtVerify.Text.CompareTo(_VerifyCode) == 0)
                {
                    ActiveControl = null;
                    SwapPanel();
                }

                else
                {
                    Form messageBox = new FormMessageBox("SAI MÃ", "Mã Xác Nhận Không Chính Xác",
                        FormMessageBox.MessageType.Info);
                    messageBox.ShowDialog();

                    ActiveControl = txtEmail;
                    txtEmail.ReadOnly = false;

                    txtEmail.ForeColor = Color.FromArgb(240, 237, 254);
                    panelVerify.Location = new Point(-474, panelVerify.Location.Y);
                    panelVerify.Visible = false;
                }
            }
        }

        private void btnRegenerate_MouseClick(object sender, MouseEventArgs e)
        {
            _VerifyCode = GlobalConfig.Instance.GenerateVerifyCode();
        }

        private void btnResigter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            bool gender = (cmbBoxGender.SelectedIndex == 0) ? true : false;
            DateTime? birthDay = (DateTime)datePicker.Value;
            string userName = txtUname.Text;
            string passWord = txtPasswrd.Text;
            string confirmPass = txtConPasswrd.Text;
            string email = txtEmail.Text;

            bool[] isValids = 
            {
                _BarIsDirtys[0],    //Name
                _BarIsDirtys[1],    //Gender
                _BarIsDirtys[2],    //Birthday
                (_BarIsDirtys[3] && LoginWorkflow.Instance.CheckUsername(userName) && !LoginWorkflow.Instance.CheckExsitAccount(userName)),    //UserName
                (_BarIsDirtys[4] && LoginWorkflow.Instance.CheckPassword(passWord) && passWord == confirmPass),  //Password
                (_BarIsDirtys[5]),  //Email
            };


            Console.WriteLine($"Name: {isValids[0]}, Gender: {isValids[1]}, Birthday: {isValids[2]}, UserName: {isValids[3]}, Password: {isValids[4]}, Email: {isValids[5]}");

            if (isValids[0] && isValids[1] && isValids[2] && isValids[3] && isValids[4] && isValids[5])
            {
                if (LoginWorkflow.Instance.SaveAccount(new Account()
                {
                    Name = name,
                    Gender = gender,
                    BirthDate = birthDay,
                    UserName = userName,
                    Password = passWord,
                    Email = email,
                }))
                {
                    GlobalForm.LoginForm.OpenChildForm(new FormSignIn());
                }
                else
                {
                    new FormMessageBox("Lỗi", "Tạo tài khoản không thành công !", FormMessageBox.MessageType.Info).ShowDialog();
                }
            }
            else
            {
                /*string mess = "";*/
                for (int i = 0; i <= 5; i++)
                {
                    if (!isValids[i])
                    {
                        /*mess += $"{_BarStrings[i]}, ";*/
                        new FormMessageBox("Lỗi", $"{_BarStrings[i]} vừa nhập không hợp lệ !", FormMessageBox.MessageType.Info).ShowDialog();
                    }
                }

            }

        }
    }
}
