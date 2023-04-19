using BLL.Workflows;
using FontAwesome.Sharp;
using Library;
using PBL3.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormForgotPassword : Form
    {

        private String _VerifyCode;
        private int elapsedTime = 0;

        public FormForgotPassword()
        {
            InitializeComponent();
            SetComponent();
        }

        void SetComponent()
        {
            panelGmail.Location = new Point(350, 150);
            panelVerify.Location = new Point(350, 230);
            panelPassword.Location = new Point(350, 150);
            labelNotify.Location = new Point(70, panelVerify.Location.Y + panelVerify.Height);
        }

        #region Event

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // kiểm tra user trước khi nhập gmail
            if (panelUser.Visible == true)
            {
                if (LoginWorkflow.Instance.CheckUsername(txtUsername.Text))
                {
                    if (LoginWorkflow.Instance.CheckExsitAccount(txtUsername.Text))
                    {
                        panelUser.Visible = false;
                        panelGmail.Visible = true;
                        timer.Start();
                    }
                    else
                    {
                        FormMessageBox message = new FormMessageBox("Thông báo", "Tài khoản không tồn tại! Vui lòng thử lại!", FormMessageBox.MessageType.Info);

                        message.ShowDialog();
                    }
                }
                else
                {
                    FormMessageBox message = new FormMessageBox("Thông báo", "Username không hợp lệ! Vui lòng thử lại!", FormMessageBox.MessageType.Info);

                    message.ShowDialog();
                }
            }

            // kích họat sự kiện lấy mã từ gmail
            else if (panelGmail.Visible == true)
            {
                if (LoginWorkflow.Instance.CheckEmail(txtEmail.Text))
                {
                    if (LoginWorkflow.Instance.CheckExistGmail(txtEmail.Text, txtUsername.Text))
                    {
                        try
                        {
                            _VerifyCode = GlobalConfig.Instance.GenerateVerifyCode();
                            LoginWorkflow.Instance.SendMessage(txtEmail.Text, "Verify Code",
                                "Mã Xác Thực để cấp lại mật khẩu cho tài khoản " + txtUsername.Text + " là: " + _VerifyCode);

                            // Hiện ô nhập mã xác minh và thông báo  
                            btnContinue.Visible = false;
                            panelVerify.Visible = true;
                            timer.Start();


                            // hiện label thông báo thời gian chờ
                            labelNotify.Visible = true;
                            timerEmail.Start();
                        }
                        catch
                        {
                            FormMessageBox message = new FormMessageBox("Thông báo", "Vui lòng kết nối mạng để tiếp tục!", FormMessageBox.MessageType.Info);
                            message.ShowDialog();
                        }
                        
                    }
                    else
                    {
                        FormMessageBox message = new FormMessageBox("Thông báo", "Email không khớp với email đã đăng ký trước đó! Vui lòng thử lại!", FormMessageBox.MessageType.Info);

                        message.ShowDialog();
                    }
                }
                else
                {
                    FormMessageBox message = new FormMessageBox("Thông báo", "Email không đúng định dạng! Vui lòng thử lại!", FormMessageBox.MessageType.Info);

                    message.ShowDialog();
                }
            }

            // kiểm tra mật khẩu

            else if (panelPassword.Visible == true)
            {
                if (LoginWorkflow.Instance.CheckPassword(txtPasswrd.Text))
                {
                    if (txtPasswrd.Text.Equals(txtConPasswrd.Text))
                    {
                        if (LoginWorkflow.Instance.UpdatePassword(txtUsername.Text, txtPasswrd.Text))
                        {
                            FormMessageBox message = new FormMessageBox("Thông báo", "Đổi mật khẩu thành công!", FormMessageBox.MessageType.Info);
                            message.ShowDialog();


                            GlobalForm.LoginForm.OpenChildForm(new FormSignIn());
                            this.Dispose();
                        }
                        else
                        {
                            FormMessageBox message = new FormMessageBox("Đổi mật khẩu thất bại", "Đã có lỗi xảy ra! Vui lòng thử lại!", FormMessageBox.MessageType.Info);

                            message.ShowDialog();
                        }
                    }
                    else
                    {
                        FormMessageBox message = new FormMessageBox("Thông báo", "Mật khẩu không trùng nhau! Vui lòng thử lại", FormMessageBox.MessageType.Info);

                        message.ShowDialog();
                    }
                }
                else
                {
                    FormMessageBox message = new FormMessageBox("Thông báo", "Mật khẩu phải dài ít nhất 8 kí tự!", FormMessageBox.MessageType.Info);

                    message.ShowDialog();
                }

            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text != "")
            {
                txt.Text = "";
            }
        }

        private void txtVerify_TextChanged(object sender, EventArgs e)
        {
            if (txtVerify.Text == _VerifyCode)
            {
                Console.WriteLine("Success");

                panelGmail.Visible = false;
                panelVerify.Visible = false;
                panelPassword.Visible = true;


                // ẩn label thông báo gửi mã
                timerEmail.Stop();
                labelNotify.Visible = false;

                // hiển thị lại btnContinue
                timer.Start();
                btnContinue.Location = new Point(125, panelPassword.Location.Y + panelPassword.Size.Height + 20);
                btnContinue.Visible = true;
            }
        }

        private void Hide_Password(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;

            if (btn.Name == "btnShow")
            {
                if (btn.IconChar == IconChar.Eye)
                {
                    btn.IconChar = IconChar.EyeSlash;
                    txtPasswrd.UseSystemPasswordChar = true;
                }
                else
                {
                    btn.IconChar = IconChar.Eye;
                    txtPasswrd.UseSystemPasswordChar = false;
                }
            }
            else
            {
                if (btn.IconChar == IconChar.Eye)
                {
                    btn.IconChar = IconChar.EyeSlash;
                    txtConPasswrd.UseSystemPasswordChar = true;
                }
                else
                {
                    btn.IconChar = IconChar.Eye;
                    txtConPasswrd.UseSystemPasswordChar = false;
                }
            }
        }

        private void btnRegenerate_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text != "")
            {
                if (LoginWorkflow.Instance.CheckExistGmail(txtEmail.Text, txtUsername.Text))
                {
                    _VerifyCode = GlobalConfig.Instance.GenerateVerifyCode();
                    LoginWorkflow.Instance.SendMessage(txtEmail.Text, "Verify Code",
                        "Mã Xác Thực để cấp lại mật khẩu cho tài khoản " + txtUsername.Text + " là: " + _VerifyCode);
                    elapsedTime = 0;
                    timerEmail.Start();
                }
                else
                {
                    FormMessageBox message = new FormMessageBox("Thông báo", "Email không khớp với email đã đăng ký trước đó! Vui lòng thử lại!", FormMessageBox.MessageType.Info);
                    message.ShowDialog();
                }
            }
            else
            {
                FormMessageBox message = new FormMessageBox("Thông báo", "Vui lòng nhập email!", FormMessageBox.MessageType.Info);
                message.ShowDialog();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (panelGmail.Location.X > 40)
            {
                panelGmail.Location = new Point(panelGmail.Location.X - 10, 150);
                if (panelGmail.Location.X <= 40) timer.Stop();
            }

            else if (panelVerify.Location.X > 50)
            {
                panelVerify.Location = new Point(panelVerify.Location.X - 10, 230);
                if (panelVerify.Location.X <= 50) timer.Stop();
            }

            else if (panelPassword.Location.X > 40)
            {
                panelPassword.Location = new Point(panelPassword.Location.X - 10, 150);
                if (panelPassword.Location.X <= 40) timer.Stop();
            }

        }

        private void timerEmail_Tick(object sender, EventArgs e)
        {
            if (elapsedTime >= 120)
            {
                timerEmail.Stop();
                btnRegenerate.Enabled = true;
                btnRegenerate.Cursor = Cursors.Hand;

            }
            else
            {
                elapsedTime++;
                btnRegenerate.Enabled = false;
                btnRegenerate.Cursor = Cursors.No;
            }
            labelNotify.Text = "Mã xác nhận đã được gửi thành công. Vui lòng \n đợi sau " + (120 - elapsedTime).ToString() + " giây nữa để gửi lại mã.";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (panelUser.Visible == true)
            {
                GlobalForm.LoginForm.OpenChildForm(new FormSignIn());
                this.Dispose();
            }
            else if (panelGmail.Visible == true)
            {
                panelUser.Visible = true;
                txtUsername.Text = "Nhập tên đăng nhập";
                panelGmail.Visible = false;
                panelVerify.Visible = false;
                btnContinue.Visible = true;
            }
            else if (panelPassword.Visible == true)
            {
                panelPassword.Visible = false;
                panelGmail.Visible = true;
                txtEmail.Text = "Nhập email";
            }
        }



        #endregion


    }
}
