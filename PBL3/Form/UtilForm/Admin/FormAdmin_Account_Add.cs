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

        

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            FormAdmin baseForm = (FormAdmin)Application.OpenForms["FormAdmin"];
            (baseForm).OpenChildForm(baseForm.AccountForm);
        }

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
            }
        }




        

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            iconEmail.BackColor = Color.FromArgb(75, 65, 114);
            validEmail = true;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            iconUserName.BackColor = Color.FromArgb(75, 65, 114);
            validUsername = true;
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
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            iconPass.BackColor = Color.FromArgb(75, 65, 114);
            validPassword = true;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == String.Empty)
            {
                iconName.BackColor = Color.FromArgb(192, 57, 43);
                validName = false;
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            iconName.BackColor = Color.FromArgb(75, 65, 114);
            validName = true;
        }

        private void txtNgaySinh_Leave(object sender, EventArgs e)
        {
            if (txtNgaySinh.Text != String.Empty)
            {
                if (LoginWorkflow.Instance.CheckDate(txtNgaySinh.Text) == null)
                {
                    iconNgaySinh.BackColor = Color.FromArgb(192, 57, 43);
                    validNgaySinh = false;
                }
            }
        }

        private void txtNgaySinh_Enter(object sender, EventArgs e)
        {
            iconNgaySinh.BackColor = Color.FromArgb(75, 65, 114);
            validNgaySinh = true;
        }

        private void txtCoin_Leave(object sender, EventArgs e)
        {
            if (txtCoin.Text != String.Empty)
            {
                try
                {
                    int coin = Convert.ToInt32(txtCoin.Text);
                }
                catch(Exception ex)
                {
                    iconCoin.BackColor = Color.FromArgb(192, 57, 43);
                    validCoin = false;
                }
            }
        }

        private void txtCoin_Enter(object sender, EventArgs e)
        {
            iconCoin.BackColor = Color.FromArgb(75, 65, 114);
            validCoin = true;
        }

        private void cmbBoxGender_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            validGender = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            bool gender = (cmbBoxGender.SelectedIndex == 0) ? true : false;
            DateTime? birthDay = LoginWorkflow.Instance.CheckDate(txtNgaySinh.Text);
            string userName = txtUserName.Text;
            string passWord = txtPass.Text;
            string email = txtEmail.Text;
            int coin = Convert.ToInt32(txtCoin.Text);

            if (validEmail && validUsername && validPassword && validName && validNgaySinh && validCoin && validGender)
            {
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
        #endregion
    }
}
