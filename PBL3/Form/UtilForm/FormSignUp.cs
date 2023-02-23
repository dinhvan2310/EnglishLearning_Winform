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

        private bool[] _barIsDirtys = new bool[6];
        private readonly string[] _barStrings = new string[] { "Họ và Tên", "Giới Tính", "01/01/2003",
                                                    "Tên Tài Khoản", "Mật Khẩu", "Xác Nhận Mật Khẩu" };

        private TextBox[] _txtPHHolders = new TextBox[6];

        public FormSignUp(Form parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;

            panelBase.Controls.Add(panelPage1);
            panelBase.Controls.Add(panelPage2);

            panelPage1.Location = new Point(0, 0);

            _txtPHHolders[0] = txtName;
            _txtPHHolders[1] = null;
            _txtPHHolders[2] = txtDate;
            _txtPHHolders[3] = txtUname;
            _txtPHHolders[4] = txtPasswrd;
            _txtPHHolders[5] = txtConPasswrd;
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
                _currentPage = panelPage1;

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
                    string[] split = _txtPHHolders[index].Text.Split('/');
                    int[] date = new int[3];

                    if (split.Length != 3)
                    {
                        MessageBox.Show("Wrong Date Format");
                        _barIsDirtys[index] = false;
                        _txtPHHolders[index].Text = _barStrings[index];
                        _txtPHHolders[index].ForeColor = Color.FromArgb(119, 112, 156);
                    }
                    else
                    {
                        int i = 0;
                        foreach (string s in split)
                        {
                            if (!int.TryParse(s, out date[i++]))
                            {
                                MessageBox.Show("Wrong Date Format");
                                _barIsDirtys[index] = false;
                                _txtPHHolders[index].Text = _barStrings[index];
                                _txtPHHolders[index].ForeColor = Color.FromArgb(119, 112, 156);
                                break;
                            }
                        }

                        try
                        { 
                            DateTime dateTime = new DateTime(date[2], date[1], date[0]);
                            datePicker.Value = dateTime;
                        }
                        catch
                        {
                            MessageBox.Show("Wrong Date Format");
                            _barIsDirtys[index] = false;
                            _txtPHHolders[index].Text = _barStrings[index];
                            _txtPHHolders[index].ForeColor = Color.FromArgb(119, 112, 156);
                        }

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
    }
}
