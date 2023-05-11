using BLL.Workflows;
using EFramework.Model;
using FontAwesome.Sharp;
using PBL3.Utilities;
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

namespace PBL3
{
    public partial class FormProfile : Form
    {
        private Font _OverFont;
        private Font _PrimaryFont;
        private Account _Account;

        // TO-DO
        //private PersonModel ;

        public FormProfile()
        {
            InitializeComponent();

            _PrimaryFont = btnAdjust1.Font;
            _OverFont = new Font(_PrimaryFont.FontFamily, _PrimaryFont.Size, FontStyle.Underline);
            _Account = LoginWorkflow.Instance.GetAccount();

            SetupUI();
        }

        private void SetupUI()
        {
            txtName.Text = _Account.Name;
            txtDate.Text = _Account.BirthDate.ToString();
            txtEmail.Text = _Account.Email;
            txtGender.Text = _Account.Gender ? "Nam" : "Nữ";
        }

        private DateTime? ValidateDate()
        {
            return LoginWorkflow.Instance.CheckDate(txtDate.Text);
        }
        private void btnAdjust1_MouseEnter(object sender, EventArgs e)
        {
            ((IconButton)sender).Font = _OverFont;
            ((IconButton)sender).IconColor = Color.FromArgb(240, 237, 254);
        }

        private void btnAdjust1_MouseLeave(object sender, EventArgs e)
        {
            ((IconButton)sender).Font = _PrimaryFont;
            ((IconButton)sender).IconColor = Color.Transparent;
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.panelPersonal.Visible = false;
            GlobalForm.MainForm.GoBack();
        }



        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).ReadOnly)
            {
                ExternalImport.HideCaret(((TextBox)sender).Handle);
                ActiveControl = null;
            }
        }

        private void btnAdjust1_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonToDefault();

            ActiveControl = txtName;

            txtName.ReadOnly = false;
            txtName.ForeColor = Color.FromArgb(240, 237, 254);
        }

        private void btnAdjust2_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonToDefault();

            ActiveControl = txtEmail;

            txtEmail.ReadOnly = false;
            txtEmail.ForeColor = Color.FromArgb(240, 237, 254);
        }

        private void btnAdjust3_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonToDefault();

            datePicker.Visible = true;
            ActiveControl = txtDate;

            txtDate.ReadOnly = false;
            txtDate.ForeColor = Color.FromArgb(240, 237, 254);
        }

        private void btnAdjust4_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonToDefault();

            cmbBoxGender.Text = txtGender.Text;
            cmbBoxGender.Visible = true;
            ActiveControl = cmbBoxGender;

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActiveControl = null;
            }
        }

        private void ResetButtonToDefault()
        {
            datePicker.Visible = false;
            cmbBoxGender.Visible = false;

            txtName.ForeColor = Color.FromArgb(119, 112, 156);
            txtEmail.ForeColor = Color.FromArgb(119, 112, 156);
            txtDate.ForeColor = Color.FromArgb(119, 112, 156);
        }

        private void txtDate_Leave(object sender, EventArgs e)
        {
            if (txtDate.ReadOnly || ActiveControl == datePicker)
            {
                return;
            }

            DateTime? date = ValidateDate();
            if (date != null)
            {
                datePicker.Value = (DateTime)date;
                txtDate.ForeColor = Color.FromArgb(119, 112, 156);
                txtDate.ReadOnly = true;
                datePicker.Visible = false;
            }
            else
            {
                Form messageBox = new FormMessageBox("NHẬP SAI", "Nhập Sai Ngày Sinh", FormMessageBox.MessageType.Info);
                messageBox.ShowDialog();
                txtDate.Text = "01/01/2003";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (!txtName.ReadOnly)
            {
                ((TextBox)sender).ReadOnly = true;
                ((TextBox)sender).ForeColor = Color.FromArgb(119, 112, 156);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!txtEmail.ReadOnly)
            {
                string[] splits = txtEmail.Text.Split('@');
                if (splits.Length != 2)
                {
                    Form messageBox = new FormMessageBox("NHẬP SAI", "Nhập Sai Email", FormMessageBox.MessageType.Info);
                    messageBox.ShowDialog();
                    txtEmail.Text = "email@gmail.com";
                }
                else
                {
                    txtEmail.ReadOnly = true;
                    txtEmail.ForeColor = Color.FromArgb(119, 112, 156);
                }
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = datePicker.Text;
            txtDate.ReadOnly = true;
            txtDate.ForeColor = Color.FromArgb(119, 112, 156);
        }

        private void cmbBoxGender_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtGender.Text = cmbBoxGender.SelectedItem.ToString();
            cmbBoxGender.Visible = false;
        }

        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            LoginWorkflow.Instance.UpdateAccount(new Account()
            {
                Email = txtEmail.Text,
                Name = txtName.Text,
                Gender = txtGender.Text == "Nam",
                BirthDate = datePicker.Value
            });
        }
    }
}
