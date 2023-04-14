using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL.Workflows;
using PBL3.Utilities;

namespace PBL3
{
    public partial class FormSignIn : Form
    {
        private bool[] _barIsDirtys = new bool[2] { false, false };

        private readonly string[] _barStrings = new string[] { "Tên Tài Khoản", "Mật Khẩu" };

        private TextBox[] _txtPHHolders = new TextBox[2];

        public FormSignIn()
        {
            InitializeComponent();

            _txtPHHolders[0] = txtUsername;
            _txtPHHolders[1] = txtPasswrd;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            GlobalForm.LoginForm.OpenChildForm(new FormSignUp());
        }

        private void txtPH_Enter(object sender, EventArgs e)
        {
            int index = ((TextBox)sender).TabIndex - 1;
            if (!_barIsDirtys[index])
            {
                _txtPHHolders[index].Text = string.Empty;
                _txtPHHolders[index].ForeColor = Color.FromArgb(240, 237, 254);


                if (index == 1)
                {
                    _txtPHHolders[index].PasswordChar = '*';
                }
            }

            if (index == 1) // password
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("textbox_password");
            }
            else if (index == 0) // username
            {
                if (txtUsername.Text.Length >= 0 && txtUsername.Text.Length <= 23)
                    pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(
                        txtUsername.Text.Length == 0 ? "textbox_user_Clicked"
                        : "textbox_user_" + txtUsername.Text.Length);

            }

        }

        private void txtPH_Leave(object sender, EventArgs e)
        {
            int index = ((TextBox)sender).TabIndex - 1;
            _barIsDirtys[index] = _txtPHHolders[index].Text.Length != 0;

            if (!_barIsDirtys[index])
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("debut");
                _txtPHHolders[index].Text = _barStrings[index];
                _txtPHHolders[index].ForeColor = Color.FromArgb(119, 112, 156);

                if (index == 1)
                {
                    _txtPHHolders[index].PasswordChar = '\0';
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!_barIsDirtys[1])
            {
                return;
            }

            if (_txtPHHolders[1].PasswordChar == '*')
            {
                btnShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
                _txtPHHolders[1].PasswordChar = '\0';
            }
            else
            {
                btnShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                _txtPHHolders[1].PasswordChar = '*';
            }
        }

        private void FormSignIn_MouseCaptureChanged(object sender, EventArgs e)
        {
            ActiveControl = null;
            ActiveControl = fakeTabStop;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool failure = false;

            if (LoginWorkflow.Instance.CheckUsername(txtUsername.Text))
            {
                if (LoginWorkflow.Instance.Login(txtUsername.Text, txtPasswrd.Text))
                {
                    if (btnSave.Checked)
                    {
                        LoginWorkflow.Instance.ActiveRememberMeLogin(txtUsername.Text, txtPasswrd.Text);
                    }
                    else
                    {
                        LoginWorkflow.Instance.DisableRememberMeLogin();
                    }

                    SettingWorkflow.Instance.ApplyUserSettings(LoginWorkflow.Instance.GetAccount().AccountID);

                    GlobalForm.MainForm.StartPosition = FormStartPosition.CenterScreen;
                    GlobalForm.MainForm.Show();

                    GlobalForm.LoginForm.Hide();
                }
                else
                {
                    failure = true;
                }
            }
            else
            {
                failure = true;
            }

            if (failure)
            {
                FormMessageBox message = new FormMessageBox("Đăng nhập thất bại", "Thông tin tài khoản không chính xác",
                    FormMessageBox.MessageType.Info);

                message.ShowDialog();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length >= 0 && txtUsername.Text.Length <= 23)
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(
                                txtUsername.Text.Length == 0 ? "textbox_user_Clicked"
                                : "textbox_user_" + txtUsername.Text.Length);
            }
        }

        
    }
}
