using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.Win32;
using PBLLibrary.CustomControls;
using MySql.Data.MySqlClient;
using PBLLibrary.Database;
using System.Windows.Controls;
using Mysqlx.Crud;
using System.Windows.Controls.Primitives;

namespace PBL3
{
    public partial class MainForm : Form
    {
        private bool _searchBarIsDirty = false;

        private IconButton _currentBtn;
        private Form _currentChildForm;

        private IconButton[] _searchOptions;
        private int _currentSearchOptionIndex;

        public MainForm()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            this.DoubleBuffered = true;
            fadeInFormAnim.Start();

            ActivateButton(btnHome, Color.FromArgb(97, 110, 254));
            OpenChildForm(new FormHome());
            rightPanelAnim.Start();

            //vScrollBar1.Value = flowLayoutPanel1.VerticalScroll.Value;
            //vScrollBar1.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            //vScrollBar1.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;

            _searchOptions = new IconButton[10];
            _searchOptions[0] = btnSearchFound1;
            _searchOptions[1] = btnSearchFound2;
            _searchOptions[2] = btnSearchFound3;
            _searchOptions[3] = btnSearchFound4;
            _searchOptions[4] = btnSearchFound5;
            _searchOptions[5] = btnSearchFound6;
            _searchOptions[6] = btnSearchFound7;
            _searchOptions[7] = btnSearchFound8;
            _searchOptions[8] = btnSearchFound9;
            _searchOptions[9] = btnSearchFound10;
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();

                _currentBtn = (IconButton)sender;

                _currentBtn.Enabled = false;

                // background
                btnOverlaySelectedBtn.Visible = true;
                btnOverlaySelectedBtn.Location = new Point(btnOverlaySelectedBtn.Location.X, _currentBtn.Location.Y);

                // icon
                iconOverlaySelectedBtn.Visible = true;
                iconOverlaySelectedBtn.Location = new Point(iconOverlaySelectedBtn.Location.X,
                    _currentBtn.Location.Y + 10);
                iconOverlaySelectedBtn.IconChar = _currentBtn.IconChar;
                iconOverlaySelectedBtn.IconColor = color;

                // panel
                rightPanelBtn.BackColor = color;
                rightPanelBtn.Location = new Point(190, _currentBtn.Location.Y);
                rightPanelAnim.Start();

                // childform
                iconChildForm.IconChar = _currentBtn.IconChar;
                iconChildForm.IconColor = color;
                lblChildForm.Text = _currentBtn.Text.ToUpper();
                lblChildForm.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (_currentBtn != null)
            {
                _currentBtn.Enabled = true;
                rightPanelBtn.Location = new Point(190, _currentBtn.Location.Y);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
            {
                _currentChildForm.Close();
            }

            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Bottom;
            panelBase.Controls.Add(childForm);
            panelBase.Tag = childForm;
            childForm.Location = new Point(0, 132);
            childForm.SendToBack();
            childForm.Show();
        }

        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            fadeOutFormAnim.Start();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            // Collapse
            if (panelButton.Size.Width > 180)
            {
                if (expandAnim.Enabled)
                    return;

                btnCollapse.Dock = DockStyle.Top;
                btnCollapse.ImageAlign = ContentAlignment.MiddleCenter;
                btnCollapse.Size = new Size(btnCollapse.Size.Width, 60);
                btnLogo.Visible = false;
                // buttons
                btnHome.Text = string.Empty;
                //btnHome.ImageAlign = ContentAlignment.MiddleCenter;
                //btnHome.Padding = new Padding(0);

                btnTopic.Text = string.Empty;
                //btnTopic.ImageAlign = ContentAlignment.MiddleCenter;
                //btnTopic.Padding = new Padding(0);

                btnNotebook.Text = string.Empty;
                //btnNotebook.ImageAlign = ContentAlignment.MiddleCenter;
                //btnNotebook.Padding = new Padding(0);

                btnGame.Text = string.Empty;
                //btnGame.ImageAlign = ContentAlignment.MiddleCenter;
                //btnGame.Padding = new Padding(0);

                btnSetting.Text = string.Empty;
                //btnSetting.ImageAlign = ContentAlignment.MiddleCenter;
                //btnSetting.Padding = new Padding(0);

                collapseAnim.Start();
            }
            // Expand
            else
            {
                if (collapseAnim.Enabled)
                    return;

                btnCollapse.Dock = DockStyle.None;
                btnCollapse.Size = new Size(40, 40);
                // buttons
                btnHome.ImageAlign = ContentAlignment.MiddleLeft;
                btnHome.Padding = new Padding(20, 0, 0, 0);

                btnTopic.ImageAlign = ContentAlignment.MiddleLeft;
                btnTopic.Padding = new Padding(20, 0, 0, 0);

                btnNotebook.ImageAlign = ContentAlignment.MiddleLeft;
                btnNotebook.Padding = new Padding(20, 0, 0, 0);

                btnGame.ImageAlign = ContentAlignment.MiddleLeft;
                btnGame.Padding = new Padding(20, 0, 0, 0);

                btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
                btnSetting.Padding = new Padding(20, 0, 0, 0);

                expandAnim.Start();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(97, 110, 254));
            OpenChildForm(new FormHome());
        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 191, 159));
        }

        private void btnNotebook_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(127, 135, 255));
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 108, 131));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(60, 150, 255));
        }

        private void collapseAnim_Tick(object sender, EventArgs e)
        {
            if (panelButton.Size.Width > 80)
            {
                panelButton.Size = new Size(panelButton.Size.Width - 10, panelButton.Size.Height);
            }
            else
                collapseAnim.Stop();
        }
        private void expandAnim_Tick(object sender, EventArgs e)
        {
            if (panelButton.Size.Width < 200)
            {
                panelButton.Size = new Size(panelButton.Size.Width + 10, panelButton.Size.Height);
            }
            else
            {
                expandAnim.Stop();
                btnLogo.Visible = true;
                btnHome.Text = "Home";
                btnTopic.Text = "Topics";
                btnNotebook.Text = "Notebook";
                btnGame.Text = "Minigames";
                btnSetting.Text = "Settings";
            }
        }
        private void rightPanelAnim_Tick(object sender, EventArgs e)
        {
            if (rightPanelBtn.Location.X > 60)
            {
                rightPanelBtn.Location = new Point(rightPanelBtn.Location.X - 10, rightPanelBtn.Location.Y);
            }
            else
            {
                rightPanelAnim.Stop();
            }
        }

        private void fadeInFormAnim_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity += 0.2;
            else
                fadeInFormAnim.Stop();
        }

        private void fadeOutFormAnim_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
                Opacity -= 0.2;
            else
            {
                fadeInFormAnim.Stop();
                Application.Exit();
            }

        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            //RegistryKey rk = Registry.CurrentUser.OpenSubKey
            //    ("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            //if (chkStartup.Checked)
            //    rk.SetValue("PBL3", Application.ExecutablePath);
            //else
            //    rk.DeleteValue("PBL3", false);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.FromArgb(119, 112, 156);

                _searchBarIsDirty = false;
            }
            else
            {
                _searchBarIsDirty = true;
            }

            panelSearchFound.Visible = false;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                panelSearchFound.Visible = false;
                return;
            }

            string filter = "\'" + txtSearch.Text + "%'";
            MySqlDataReader reader = DatabaseConnection.Query(
                "SELECT DISTINCT wn_synset.word FROM wn_pro_mysql.wn_synset\nWHERE word LIKE " + filter + "\nLIMIT 10;");

            if (reader == null)
            {
                return;
            }

            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    _searchOptions[i].Text = reader.GetString(0).Replace('_', ' ');
                    i++;
                }

                panelSearchFound.Size = new Size(519, 25 + 30 * i);
            }
            else
            {
                panelSearchFound.Size = new Size(519, 55);
                _searchOptions[0].Text = txtSearch.Text;
            }

            _currentSearchOptionIndex = 0;
            ActiveSearchOption();

            panelSearchFound.Visible = true;

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                panelSearchFound.Visible = false;
                //TO-DO: check if it exist in wordnet or not
                OpenChildForm(new WordForm(((System.Windows.Forms.TextBox)sender).Text));
            }

            if (e.KeyCode == Keys.Down)
            {
                ResetSearchOption();
                _currentSearchOptionIndex = (_currentSearchOptionIndex + 1) % 10;
                ActiveSearchOption();
            }

            if (e.KeyCode == Keys.Up)
            {
                ResetSearchOption();
                _currentSearchOptionIndex = (_currentSearchOptionIndex == 0) ? 9 : _currentSearchOptionIndex - 1;
                ActiveSearchOption();
            }
        }

        private void ActiveSearchOption()
        {
            _searchOptions[_currentSearchOptionIndex].BackColor = Color.FromArgb(50, 40, 80);
        }

        private void ResetSearchOption()
        {
            _searchOptions[_currentSearchOptionIndex].BackColor = Color.FromArgb(60, 50, 99);
        }
        private void btnSearchFound_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WordForm(((IconButton)sender).Text));
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (!_searchBarIsDirty)
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.FromArgb(240, 237, 252);

            }
        }


        // Rounded winform
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );


        // Drag winform
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
