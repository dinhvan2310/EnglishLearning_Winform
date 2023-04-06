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


namespace PBL3
{
    public partial class FormSignIn : Form
    {
        private Form _ParentForm;

        private bool[] _barIsDirtys = new bool[2] { false, false };

        private readonly string[] _barStrings = new string[] { "Tên Tài Khoản", "Mật Khẩu" };

        private TextBox[] _txtPHHolders = new TextBox[2];


        List<Image> images = new List<Image>();
        string[] location = new string[25];

        public FormSignIn(Form parentForm)
        {
            InitializeComponent();

            _ParentForm = parentForm;

            _txtPHHolders[0] = txtUsername;
            _txtPHHolders[1] = txtPasswrd;




            location[0] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_1.png";
            location[1] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_2.png";
            location[2] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_4.png";
            location[3] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_5.png";
            location[4] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_6.png";
            location[5] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_7.png";
            location[6] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_8.png";
            location[7] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_9.png";
            location[8] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_10.png";
            location[9] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_11.png";
            location[10] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_12.png";
            location[11] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_13.png";
            location[12] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_14.png";
            location[13] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_15.png";
            location[14] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_16.png";
            location[15] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_17.png";
            location[16] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_18.png";
            location[17] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_19.png";
            location[18] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_20.png";
            location[19] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_21.png";
            location[20] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_22.png";
            location[21] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_23.png";
            location[22] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_user_24.png";
            location[23] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\textbox_password.png";
            location[24] = $"{Application.StartupPath}\\..\\..\\..\\PBL3\\Resources\\Login_AnimationImage\\debut.png";
            tounage();
        }

        private void tounage()
        {
            for (int i = 0; i <= 24; i++)
            {
                Bitmap bitmap = new Bitmap(location[i]);
                images.Add(bitmap);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ((LoginForm)_ParentForm).OpenChildForm(new FormSignUp(_ParentForm));
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

            if (index == 1)
            {
                pictureBox1.Image = images[23];
            }
            else if (index == 0)
            {
                if (txtUsername.Text.Length > 0 && txtUsername.Text.Length <= 23)
                    pictureBox1.Image = images[txtUsername.Text.Length - 1];
                else if (txtUsername.Text == String.Empty)
                {
                    pictureBox1.Image = images[24];
                }
                else
                {
                    pictureBox1.Image = images[22];
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

            if (SignUpWorkflow.Instance.CheckUsername(txtUsername.Text))
            {
                if (SignUpWorkflow.Instance.Login(txtUsername.Text, txtPasswrd.Text))
                {
                    LoginForm LoginForm = (LoginForm)_ParentForm;

                    LoginForm.MainForm.StartPosition = FormStartPosition.CenterScreen;
                    LoginForm.MainForm.Show();

                    _ParentForm.Hide();
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
            if (txtUsername.Text.Length > 0 && txtUsername.Text.Length <= 23)
            {
                pictureBox1.Image = images[txtUsername.Text.Length - 1];
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txtUsername.Text.Length <= 0)
                pictureBox1.Image = images[24];
            else
                pictureBox1.Image = images[22];
        }
    }
}
