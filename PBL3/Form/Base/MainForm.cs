using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Reflection;

using BLL.Workflows;
using BLL.TransferObjects;
using PBL3.Utilities;

namespace PBL3
{
    public partial class MainForm : Form
    {
        public FormHome HomeForm { get; private set; }
        public FormAdmin AdminForm { get; private set; }
        public FormTopic TopicForm { get; private set; }
        public FormNotebook NotebookForm { get; private set; }
        public Form MinigameForm { get; private set; }
        public FormSetting SettingForm { get; private set; }

        private IconButton _CurrentBtn;

        private bool _SearchBarIsDirty = false;
        private Button[] _SearchOptions;
        private int _CurrentSearchOptionIndex;


        public MainForm()
        {
            InitializeComponent();

            SetupForm();
            SetupUI();
        }

        #region HELPER FUNCTIONS
        private void SetupUI()
        {
            if (LoginWorkflow.Instance.IsLoggedIn())
            {
                lblBalance.Text = LoginWorkflow.Instance.GetAccountDetail().Balance.ToString();
                btnPersonalLogin.Text = "Đăng Xuất";
                OpenChildForm(HomeForm, FormType.Strong);
            }
            else
            {
                lblBalance.Text = "∞";
                btnPersonalLogin.Text = "Đăng Nhập";
                OpenChildForm(new FormGuest(), FormType.Strong);
            }

            fadeInFormAnim.Start();

            // FormHome for default
            ActivateButton(btnHome, Color.FromArgb(97, 110, 254));
        }

        private void SetupForm()
        {
            SettingFormProperties();
            InitializeChildForm();
            InitializeFoundButton();
        }
        public void GoBack()
        {
            OpenChildForm(null, FormType.Return);
        }

        public void SwitchForm(Form form, FormType formType)
        {
            OpenChildForm(form, formType);
        }

        private void InitializeChildForm()
        {
            AdminForm = new FormAdmin();
            HomeForm = new FormHome();
            TopicForm = new FormTopic();
            NotebookForm = new FormNotebook();
            SettingForm = new FormSetting();
        }

        private void InitializeFoundButton()
        {
            _SearchOptions = new IconButton[10];

            for (int i = 0; i < 10; ++i)
            {
                _SearchOptions[i] = CreateSearchButton(i);
                panelSearchFound.Controls.Add(_SearchOptions[i]);
            }
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();

                _CurrentBtn = (IconButton)sender;

                _CurrentBtn.Enabled = false;

                // background
                btnOverlaySelectedBtn.Visible = true;
                btnOverlaySelectedBtn.Location = new Point(btnOverlaySelectedBtn.Location.X, _CurrentBtn.Location.Y);

                // icon
                iconOverlaySelectedBtn.Visible = true;
                iconOverlaySelectedBtn.Location = new Point(iconOverlaySelectedBtn.Location.X,
                    _CurrentBtn.Location.Y + 10);
                iconOverlaySelectedBtn.IconChar = _CurrentBtn.IconChar;
                iconOverlaySelectedBtn.IconColor = color;

                // panel
                rightPanelBtn.BackColor = color;
                rightPanelBtn.Location = new Point(190, _CurrentBtn.Location.Y);
                rightPanelAnim.Start();

                // childform
                iconChildForm.IconChar = _CurrentBtn.IconChar;
                iconChildForm.IconColor = color;
                lblChildForm.Text = _CurrentBtn.Text.ToUpper();
                lblChildForm.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (_CurrentBtn != null)
            {
                _CurrentBtn.Enabled = true;
                rightPanelBtn.Location = new Point(190, _CurrentBtn.Location.Y);
            }

        }

        private void OpenChildForm(Form childForm, FormType formType)
        {
            Form currentForm = FormStack.Peek();
            if (currentForm != null)
            {
                if (currentForm == childForm)
                {
                    return;
                }

                currentForm.Visible = false;
            }

            switch (formType)
            {
                case FormType.Strong:
                    FormStack.Clear();
                    FormStack.Push(childForm);
                    break;
                case FormType.Weak:
                    FormStack.Push(childForm);
                    break;
                case FormType.Return:
                    FormStack.Pop()?.Hide();
                    FormStack.Peek()?.Show();
                    return;
            }

            Console.WriteLine(FormStack.Peek() + " " + FormStack.Count().ToString());
            Console.WriteLine(formType);

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Bottom;
            panelBase.Controls.Add(childForm);
            panelBase.Tag = childForm;
            childForm.Location = new Point(0, 132);
            childForm.SendToBack();
            childForm.Show();

        }

        private void ActiveSearchOption()
        {
            _SearchOptions[_CurrentSearchOptionIndex].BackColor = Color.FromArgb(50, 40, 80);
        }

        private void ResetSearchOption()
        {
            _SearchOptions[_CurrentSearchOptionIndex].BackColor = Color.FromArgb(60, 50, 99);
        }

        private Button CreateSearchButton(int index)
        {
            IconButton b = new IconButton();
            b.BackColor = Color.FromArgb(60, 50, 99);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font("Century Gothic", 10.2f);
            b.ForeColor = Color.FromArgb(240, 237, 254);
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.TabStop = false;
            b.Location = new Point(0, 25 + 30 * index);
            b.Size = new Size(443, 30);
            b.Padding = new Padding(15, 0, 0, 0);

            return b;
        }

        private void SettingFormProperties()
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Region = System.Drawing.Region.FromHrgn(ExternalImport.CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            // Reduce Flicker
            this.DoubleBuffered = true;

            typeof(System.Windows.Forms.Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, panelBase, new object[] { true });

            typeof(System.Windows.Forms.Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, panelDrag, new object[] { true });
        }
        #endregion

        #region EVENTS
        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            ExternalImport.ReleaseCapture();
            ExternalImport.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form messageBox = new FormMessageBox("XÁC NHẬN", "Muốn Rời Khỏi?", FormMessageBox.MessageType.Option);

            messageBox.StartPosition = FormStartPosition.CenterScreen;
            messageBox.ShowDialog();
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
                btnPremium.Size = new Size(0, 80);
                btnPremium.Dock = DockStyle.Bottom;
                lblVersion.Visible = false;

                // buttons
                btnHome.Text = string.Empty;

                btnTopic.Text = string.Empty;

                btnNotebook.Text = string.Empty;

                btnGame.Text = string.Empty;

                btnSetting.Text = string.Empty;

                lblChildForm.Text = "";

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

                btnPremium.Size = new Size(150, 40);
                btnPremium.Dock = DockStyle.None;
                lblVersion.Visible = true;
                iconSub.Visible = false;
                expandAnim.Start();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(97, 110, 254));

            if (LoginWorkflow.Instance.IsLoggedIn())
            {
                OpenChildForm(HomeForm, FormType.Strong);
            }
            else
            {
                OpenChildForm(new FormGuest(), FormType.Strong);
            }

        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(83, 205, 216));
            OpenChildForm(TopicForm, FormType.Strong);
        }

        private void btnNotebook_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 191, 159));

            if (LoginWorkflow.Instance.IsLoggedIn())
            {
                OpenChildForm(NotebookForm, FormType.Strong);
            }
            else
            {
                OpenChildForm(new FormGuest(), FormType.Strong);
            }
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 108, 131));
            if (LoginWorkflow.Instance.IsLoggedIn())
            {

            }
            else
            {
                OpenChildForm(new FormGuest(), FormType.Strong);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 211, 137));
            OpenChildForm(SettingForm, FormType.Strong);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                panelSearchFound.Visible = false;
                return;
            }
            DataManager dataAccess = new DataManager();
            List<WordModel> words = dataAccess.EDictionaryManager.GetWord_ByFilter(txtSearch.Text.Replace(' ', '_') + "%", 10, true);


            if (words.Count != 0)
            {
                panelSearchFound.Size = new Size(panelSearchFound.Size.Width, 25 + 30 * words.Count);

                int i = 0;
                foreach (WordModel w in words)
                {
                    _SearchOptions[i++].Text = w.Word.Replace('_', ' ');
                }
            }
            else
            {
                panelSearchFound.Size = new Size(panelSearchFound.Size.Width, 55);
                _SearchOptions[0].Text = txtSearch.Text;
            }

            _CurrentSearchOptionIndex = 0;
            ActiveSearchOption();

            panelSearchFound.Visible = true;

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            _SearchBarIsDirty = txtSearch.Text.Length != 0;
            if (!_SearchBarIsDirty)
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.FromArgb(119, 112, 156);
            }

            panelSearchFound.Visible = false;
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
                _SearchOptions[_CurrentSearchOptionIndex].BackColor = Color.FromArgb(60, 50, 99);

                // When press enter, application make a Ting sound, so this is a little trick
                e.Handled = true;
                e.SuppressKeyPress = true;

                DataManager dataAccess = new DataManager();
                if (dataAccess.EDictionaryManager.GetWord_ByFilter(_SearchOptions[_CurrentSearchOptionIndex].
                    Text.Replace(' ', '_')).Count == 0)
                {
                    OpenChildForm(new WordForm_None(txtSearch.Text.Replace(' ', '_')), FormType.Weak);
                }
                else
                {
                    OpenChildForm(new WordForm(_SearchOptions[_CurrentSearchOptionIndex].Text.Replace(' ', '_')),
                        FormType.Weak);
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                ResetSearchOption();
                _CurrentSearchOptionIndex = (_CurrentSearchOptionIndex + 1) % 10;
                ActiveSearchOption();
            }

            if (e.KeyCode == Keys.Up)
            {
                ResetSearchOption();
                _CurrentSearchOptionIndex = (_CurrentSearchOptionIndex == 0) ? 9 : _CurrentSearchOptionIndex - 1;
                ActiveSearchOption();
            }

        }

        private void btnSearchFound_Click(object sender, EventArgs e)
        {
            DataManager dataAccess = new DataManager();
            if (dataAccess.EDictionaryManager.GetWord_ByFilter(_SearchOptions[_CurrentSearchOptionIndex].Text.Replace(' ', '_')) == null)
            {
                OpenChildForm(new WordForm_None(((IconButton)sender).Text.Replace(' ', '_')), FormType.Weak);
            }
            else
            {
                OpenChildForm(new WordForm(((IconButton)sender).Text.Replace(' ', '_')), FormType.Weak);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (!_SearchBarIsDirty)
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.FromArgb(240, 237, 252);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = false;

            GlobalForm.LoginForm.Show();
            this.Hide();
        }


        private void btnPersonal_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = !panelPersonal.Visible;
        }

        private void btnPersonalSetting_MouseClick(object sender, MouseEventArgs e)
        {
            panelPersonal.Visible = false;

            ActivateButton(btnSetting, Color.FromArgb(255, 255, 127));
            OpenChildForm(SettingForm, FormType.Strong);
        }

        private void btnLogo_MouseClick(object sender, MouseEventArgs e)
        {
            btnHome_Click(btnHome, e);
        }

        private void btnPersonalInfo_MouseClick(object sender, MouseEventArgs e)
        {
            panelPersonal.Visible = false;

            if (LoginWorkflow.Instance.IsLoggedIn())
                OpenChildForm(new FormProfile(), FormType.Weak);
            else
                OpenChildForm(new FormGuest(), FormType.Strong);

        }

        private void btnPremium_MouseClick(object sender, MouseEventArgs e)
        {
            Form premiumForm = new FormPremium();
            premiumForm.ShowDialog();
        }

        private void btnSearchType_CheckedChanged(object sender, EventArgs e)
        {
            if (lblSearchType.Text.CompareTo("ANH - ANH") == 0)
            {
                lblSearchType.Text = "ANH - VIET";
            }
            else
            {
                lblSearchType.Text = "ANH - ANH";
            }
        }

        private void btnTranslate_MouseClick(object sender, MouseEventArgs e)
        {
            Form form = new FormTranslanteText();
            OpenChildForm(form, FormType.Weak);
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            SetupUI();
        }

        #endregion

        #region ANIMATION
        private void collapseAnim_Tick(object sender, EventArgs e)
        {
            if (panelButton.Size.Width > 80)
            {
                panelButton.Size = new Size(panelButton.Size.Width - 20, panelButton.Size.Height);
            }
            else
            {
                collapseAnim.Stop();
                iconSub.Visible = true;
            }
        }

        private void expandAnim_Tick(object sender, EventArgs e)
        {
            if (panelButton.Size.Width < 200)
            {
                panelButton.Size = new Size(panelButton.Size.Width + 20, panelButton.Size.Height);
            }
            else
            {
                expandAnim.Stop();
                btnLogo.Visible = true;
                btnHome.Text = "Trang Chủ";
                btnTopic.Text = "Chủ Đề";
                btnNotebook.Text = "Sổ Tay";
                btnGame.Text = "Trò Chơi";
                btnSetting.Text = "Cài Đặt";

                lblChildForm.Text = _CurrentBtn.Text.ToUpper();
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

        #endregion
    }
}