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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media.Media3D;

namespace PBL3
{
    public partial class FormSignUp : Form
    {
        private Form _parentForm;

        private Panel _currentPage;

        private bool[] _barIsDirtys = new bool[8];
        private readonly string[] _barStrings = new string[] { "Họ và Tên", "Giới Tính", "01/01/2003",
                                                    "Tên Tài Khoản", "Mật Khẩu", "Xác Nhận Mật Khẩu",
                                                    "Email", "Nhập Mã Xác Thực"};

        private TextBox[] _txtPHHolders = new TextBox[8];

        private string _verifyCode;

        public FormSignUp(Form parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;

            panelBase.Controls.Add(panelPage1);
            panelBase.Controls.Add(panelPage2);
            panelBase.Controls.Add(panelEmail);

            panelEmail.Location = new Point(0, 0);
            panelPage1.Location = new Point(0, 0);

            _txtPHHolders[0] = txtName;
            _txtPHHolders[1] = null;
            _txtPHHolders[2] = txtDate;
            _txtPHHolders[3] = txtUname;
            _txtPHHolders[4] = txtPasswrd;
            _txtPHHolders[5] = txtConPasswrd;
            _txtPHHolders[6] = txtEmail;
            _txtPHHolders[7] = txtVerify;
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
                _currentPage = panelPage1;

                btnReturn.Visible = true;
                btnResigter.Visible = true;
            }
            else
            {
                btnReturn.Visible = false;
                btnPage1.Visible = false;
                btnPage2.Visible = false;

                _currentPage.Visible = false;

                panelEmail.Visible = true;
                ActiveControl = txtEmail;
                txtEmail.ReadOnly = false;
                txtEmail.ForeColor = Color.FromArgb(240, 237, 254);
            }
        }

        private bool ValidateEmail()
        {
            string[] splits = txtEmail.Text.Split('@');
            if (splits.Length != 2)
            {
                return false;
            }
            else if (splits[1].CompareTo("gmail.com") != 0 || splits[0].Length == 0)
            {
                return false;
            }

            return true;
        }

        private bool ValidateDate()
        {
            string[] split = txtDate.Text.Split('/');
            int[] date = new int[3];

            if (split.Length != 3)
            {
                return false;
            }
            else
            {
                int i = 0;
                foreach (string s in split)
                {
                    if (!int.TryParse(s, out date[i++]))
                    {
                        return false;
                    }
                }

                try
                {
                    DateTime dateTime = new DateTime(date[2], date[1], date[0]);
                }
                catch
                {
                    return false;
                }

            }

            return true;
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            ((LoginForm)_parentForm).OpenChildForm(new FormSignIn(_parentForm));
        }

        private void btnPage1_CheckedChanged(object sender, EventArgs e)
        {
            if (panelPage1.Visible)
            {
                _currentPage = panelPage2;
            }
            else
            {
                _currentPage = panelPage1;
            }

            _currentPage.Location = new Point(450, 0);
            slideAnim.Start();

            panelPage1.Visible = !panelPage1.Visible;

            panelPage2.Visible = !panelPage2.Visible;
        }

        private void slideAnim_Tick(object sender, EventArgs e)
        {
            if (_currentPage.Location.X == 0)
            {
                slideAnim.Stop();
                return;
            }

            _currentPage.Location = new Point(_currentPage.Location.X - 25, _currentPage.Location.Y);
        }

        private void txtPH_Enter(object sender, EventArgs e)
        {
            int index = ((TextBox)sender).TabIndex - 1;
            if (!_barIsDirtys[index])
            {
                _txtPHHolders[index].Text = string.Empty;
                _txtPHHolders[index].ForeColor = Color.FromArgb(240, 237, 254);

                if (index == 4 || index == 5)
                {
                    _txtPHHolders[index].PasswordChar = '*';
                }
            }
        }

        private void txtPH_Leave(object sender, EventArgs e)
        {
            int index = ((TextBox)sender).TabIndex - 1;
            _barIsDirtys[index] = _txtPHHolders[index].Text.Length != 0;

            if (!_barIsDirtys[index])
            {
                _txtPHHolders[index].Text = _barStrings[index];
                _txtPHHolders[index].ForeColor = Color.FromArgb(119, 112, 156);

                if (index == 4 || index == 5)
                {
                    _txtPHHolders[index].PasswordChar = '\0';
                }
            }
            else
            {
                if (index == 2)
                {
                    if (ValidateDate())
                    {
                        string[] split = _txtPHHolders[index].Text.Split('/');
                        int[] date = new int[3];

                        int i = 0;
                        foreach (string s in split)
                        {
                            date[i++] = Convert.ToInt32(s);
                        }

                        DateTime dateTime = new DateTime(date[2], date[1], date[0]);
                        datePicker.Value = dateTime;
                    }
                    else
                    {
                        Form messageBox = new MessageBox("NHẬP SAI", "Nhập Sai Ngày Sinh", MessageBox.MessageType.Info);
                        messageBox.ShowDialog();
                    }
                    

                }

                if (index == 6 && !txtEmail.ReadOnly)
                {
                    if (ValidateEmail())
                    {
                        _verifyCode = GlobalConfig.GenerateVerifyCode();
                        GlobalConfig.SendMessage(txtEmail.Text, "Verify Code",
                            "Mã Xác Thực cho tài khoản English Learning là: " + _verifyCode);

                        _txtPHHolders[index].ReadOnly = true;
                        _txtPHHolders[index].ForeColor = Color.FromArgb(119, 112, 156);

                        panelVerify.Location = new Point(-474, panelVerify.Location.Y);
                        panelVerify.Visible = true;
                        childSlideAnim.Start();
                    }
                    else
                    {
                        Form messageBox = new MessageBox("NHẬP SAI", "Nhập Sai Email", MessageBox.MessageType.Info);
                        messageBox.ShowDialog();
                    }

                }    
            }
        }

        

        private void cmbBoxGender_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxGender.ForeColor = Color.FromArgb(240, 237, 254);
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            _barIsDirtys[2] = true;
            txtDate.Text = datePicker.Text;
            txtDate.ForeColor = Color.FromArgb(240, 237, 254);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!_barIsDirtys[4])
            {
                return;
            }

            if (_txtPHHolders[4].PasswordChar == '*')
            {
                btnShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
                _txtPHHolders[4].PasswordChar = '\0';
            }
            else
            {
                btnShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                _txtPHHolders[4].PasswordChar = '*';
            }
        }

        private void btnConfirmShow_Click(object sender, EventArgs e)
        {
            if (!_barIsDirtys[5])
            {
                return;
            }

            if (_txtPHHolders[5].PasswordChar == '*')
            {
                btnConfirmShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                _txtPHHolders[5].PasswordChar = '\0';
            }
            else
            {
                btnConfirmShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
                _txtPHHolders[5].PasswordChar = '*';
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
                if (txtVerify.Text.CompareTo(_verifyCode) == 0)
                {
                    ActiveControl = null;

                    SwapPanel();
                }

                else
                {
                    Form messageBox = new MessageBox("SAI MÃ", "Mã Xác Nhận Không Chính Xác",
                        MessageBox.MessageType.Info);
                    messageBox.ShowDialog();

                    ActiveControl = txtEmail;
                    txtEmail.ReadOnly = false;

                    txtEmail.ForeColor = ColorConfig.TextColor;
                    panelVerify.Location = new Point(-474, panelVerify.Location.Y);
                    panelVerify.Visible = false;
                }
            }
        }

        private void btnRegenerate_MouseClick(object sender, MouseEventArgs e)
        {
            _verifyCode = GlobalConfig.GenerateVerifyCode();
        }

    }
}
