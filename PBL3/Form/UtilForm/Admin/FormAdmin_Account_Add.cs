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

using BLL.Workflows;
using EFramework.Model;

namespace PBL3
{
    public partial class FormAdmin_Account_Add : Form
    {
        public event EventHandler ShowListAccount;
        private bool validEmail = false;
        private bool validUsername = false;
        private bool validPassword = false;
        private bool validName = false;
        private bool validCoin = false;
        private bool validNgaySinh = false;
        private bool validGender = false;

        public FormAdmin_Account_Add()
        {
            InitializeComponent();

            // Reduce Flicker
            this.DoubleBuffered = true;

        }

        #region EVENTS

        private void FormAdmin_Account_Add_MouseDown(object sender, MouseEventArgs e)
        {
            ExternalImport.ReleaseCapture();
            ExternalImport.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text != String.Empty)
            {
                if (!LoginWorkflow.Instance.CheckEmail(txtEmail.Text))
                {
                    iconEmail.BackColor = Color.FromArgb(192, 57, 43);
                    validEmail = false;
                }
                else
                {
                    iconEmail.BackColor = Color.FromArgb(75, 65, 114);
                    validEmail = true;
                }
            }
            else
            {
                iconEmail.BackColor = Color.FromArgb(192, 57, 43);
                validEmail = false;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text != String.Empty)
            {
                if (!LoginWorkflow.Instance.CheckUsername(txtUserName.Text))
                {
                    iconUserName.BackColor = Color.FromArgb(192, 57, 43);
                    validUsername = false;
                }
                else if(LoginWorkflow.Instance.CheckExsitAccount(txtUserName.Text))
                {
                    iconUserName.BackColor = Color.FromArgb(192, 57, 43);
                    validUsername = false;
                }
                else
                {
                    iconUserName.BackColor = Color.FromArgb(75, 65, 114);
                    validUsername = true;
                }
            }
            else
            {
                iconUserName.BackColor = Color.FromArgb(192, 57, 43);
                validUsername = false;
            }
        }


        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text != String.Empty)
            {
                if (!LoginWorkflow.Instance.CheckPassword(txtPass.Text))
                {
                    iconPass.BackColor = Color.FromArgb(192, 57, 43);
                    validPassword = false;
                }
                else
                {
                    iconPass.BackColor = Color.FromArgb(75, 65, 114);
                    validPassword = true;
                }
            }
            else
            {
                iconPass.BackColor = Color.FromArgb(192, 57, 43);
                validPassword = false;
            }
        }

        

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == String.Empty)
            {
                iconName.BackColor = Color.FromArgb(192, 57, 43);
                validName = false;
            }
            else
            {
                iconName.BackColor = Color.FromArgb(75, 65, 114);
                validName = true;
            }
        }

        

        private void txtNgaySinh_Leave(object sender, EventArgs e)
        {
            if (txtNgaySinh.Text != String.Empty)
            {
                DateTime? dateTime = LoginWorkflow.Instance.CheckDate(txtNgaySinh.Text);
                if (dateTime == null || dateTime > DateTime.Now)
                {
                    iconNgaySinh.BackColor = Color.FromArgb(192, 57, 43);
                    validNgaySinh = false;
                }
                else
                {
                    iconNgaySinh.BackColor = Color.FromArgb(75, 65, 114);
                    validNgaySinh = true;
                }
            }
            else
            {
                validNgaySinh = false;
                iconNgaySinh.BackColor = Color.FromArgb(192, 57, 43);
            }
        }

        

        private void txtCoin_Leave(object sender, EventArgs e)
        {
            if (txtCoin.Text != String.Empty)
            {
                try
                {
                    int coin = Convert.ToInt32(txtCoin.Text);
                    iconCoin.BackColor = Color.FromArgb(75, 65, 114);
                    validCoin = true;
                }
                catch(Exception ex)
                {
                    iconCoin.BackColor = Color.FromArgb(192, 57, 43);
                    validCoin = false;
                }
            }
            else
            {
                iconCoin.BackColor = Color.FromArgb(192, 57, 43);
                validCoin = false;
            }
        }

        

        private void cmbBoxGender_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            validGender = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validEmail && validUsername && validPassword && validName && validNgaySinh && validCoin && validGender)
            {
                string name = txtName.Text;
                bool gender = (cmbBoxGender.SelectedIndex == 0) ? true : false;
                DateTime? birthDay = LoginWorkflow.Instance.CheckDate(txtNgaySinh.Text);
                string userName = txtUserName.Text;
                string passWord = txtPass.Text;
                string email = txtEmail.Text;
                int coin = Convert.ToInt32(txtCoin.Text);
                if (LoginWorkflow.Instance.SaveAccount(new Account()
                {
                    Name = name,
                    Gender = gender,
                    BirthDate = birthDay,
                    UserName = userName,
                    Password = passWord,
                    Email = email,
                    DetailedInformation = new DetailedInformation()
                    {
                        Balance = coin,
                    },
                }))
                {
                    if(ShowListAccount != null)
                    {
                        ShowListAccount.Invoke(this, new EventArgs());
                    }
                    this.Dispose();
                }
            }
            else
            {
                new FormMessageBox("Thông báo", "Thêm không thành công", FormMessageBox.MessageType.Info).ShowDialog();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                btnShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPass.PasswordChar = '\0';
            }
            else
            {
                btnShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPass.PasswordChar = '*';
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            txtNgaySinh.Text = datePicker.Text;
            txtNgaySinh_Leave(this, new EventArgs());
        }

        #endregion

        
    }
}
