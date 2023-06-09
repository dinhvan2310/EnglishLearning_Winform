using CustomControls;

namespace PBL3
{
    partial class FormSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtPasswrd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConPasswrd = new System.Windows.Forms.TextBox();
            this.panelPage2 = new System.Windows.Forms.Panel();
            this.rjButton9 = new CustomControls.RJButton();
            this.rjButton7 = new CustomControls.RJButton();
            this.iconUser = new FontAwesome.Sharp.IconButton();
            this.rjButton8 = new CustomControls.RJButton();
            this.rjButton1 = new CustomControls.RJButton();
            this.iconPassword = new FontAwesome.Sharp.IconButton();
            this.btnConfirmShow = new FontAwesome.Sharp.IconButton();
            this.iconConfirmPassword = new FontAwesome.Sharp.IconButton();
            this.btnShow = new FontAwesome.Sharp.IconButton();
            this.rjButton2 = new CustomControls.RJButton();
            this.rjButton6 = new CustomControls.RJButton();
            this.panelPage1 = new System.Windows.Forms.Panel();
            this.rjButton12 = new CustomControls.RJButton();
            this.cmbBoxGender = new CustomControls.RJComboBox();
            this.datePicker = new CustomControls.RJDatePicker();
            this.rjButton15 = new CustomControls.RJButton();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.iconDate = new FontAwesome.Sharp.IconButton();
            this.iconGender = new FontAwesome.Sharp.IconButton();
            this.rjButton13 = new CustomControls.RJButton();
            this.rjButton10 = new CustomControls.RJButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.iconName = new FontAwesome.Sharp.IconButton();
            this.rjButton11 = new CustomControls.RJButton();
            this.rjButton14 = new CustomControls.RJButton();
            this.panelBase = new System.Windows.Forms.Panel();
            this.slideAnim = new System.Windows.Forms.Timer(this.components);
            this.btnPage2 = new CustomControls.RJRadioButton();
            this.btnPage1 = new CustomControls.RJRadioButton();
            this.rjButton5 = new CustomControls.RJButton();
            this.rjButton4 = new CustomControls.RJButton();
            this.btnResigter = new CustomControls.RJButton();
            this.fakeTabStop = new System.Windows.Forms.TextBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.panelVerify = new System.Windows.Forms.Panel();
            this.lblChangeMail = new System.Windows.Forms.Label();
            this.btnRegenerate = new FontAwesome.Sharp.IconButton();
            this.rjButton16 = new CustomControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.rjButton17 = new CustomControls.RJButton();
            this.panelSlideEmail = new System.Windows.Forms.Panel();
            this.rjButton19 = new CustomControls.RJButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.rjButton20 = new CustomControls.RJButton();
            this.childSlideAnim = new System.Windows.Forms.Timer(this.components);
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnLogo = new System.Windows.Forms.Button();
            this.panelPage2.SuspendLayout();
            this.panelPage1.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.panelVerify.SuspendLayout();
            this.panelSlideEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUname
            // 
            this.txtUname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtUname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUname.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtUname.Location = new System.Drawing.Point(64, 20);
            this.txtUname.Margin = new System.Windows.Forms.Padding(2);
            this.txtUname.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(218, 30);
            this.txtUname.TabIndex = 4;
            this.txtUname.Text = "Tên Tài Khoản";
            this.txtUname.Enter += new System.EventHandler(this.txtPH_Enter);
            this.txtUname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtUname.Leave += new System.EventHandler(this.txtPH_Leave);
            // 
            // txtPasswrd
            // 
            this.txtPasswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtPasswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswrd.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtPasswrd.Location = new System.Drawing.Point(64, 75);
            this.txtPasswrd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswrd.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtPasswrd.Name = "txtPasswrd";
            this.txtPasswrd.Size = new System.Drawing.Size(218, 23);
            this.txtPasswrd.TabIndex = 5;
            this.txtPasswrd.Text = "Mật Khẩu";
            this.txtPasswrd.Enter += new System.EventHandler(this.txtPH_Enter);
            this.txtPasswrd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtPasswrd.Leave += new System.EventHandler(this.txtPH_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(94, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Đã Có Tài Khoản?";
            // 
            // txtConPasswrd
            // 
            this.txtConPasswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtConPasswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPasswrd.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPasswrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtConPasswrd.Location = new System.Drawing.Point(64, 130);
            this.txtConPasswrd.Margin = new System.Windows.Forms.Padding(2);
            this.txtConPasswrd.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtConPasswrd.Name = "txtConPasswrd";
            this.txtConPasswrd.Size = new System.Drawing.Size(218, 23);
            this.txtConPasswrd.TabIndex = 6;
            this.txtConPasswrd.Text = "Xác Nhận Mật Khẩu";
            this.txtConPasswrd.Enter += new System.EventHandler(this.txtPH_Enter);
            this.txtConPasswrd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtConPasswrd.Leave += new System.EventHandler(this.txtPH_Leave);
            // 
            // panelPage2
            // 
            this.panelPage2.Controls.Add(this.rjButton9);
            this.panelPage2.Controls.Add(this.rjButton7);
            this.panelPage2.Controls.Add(this.iconUser);
            this.panelPage2.Controls.Add(this.rjButton8);
            this.panelPage2.Controls.Add(this.txtUname);
            this.panelPage2.Controls.Add(this.rjButton1);
            this.panelPage2.Controls.Add(this.iconPassword);
            this.panelPage2.Controls.Add(this.btnConfirmShow);
            this.panelPage2.Controls.Add(this.iconConfirmPassword);
            this.panelPage2.Controls.Add(this.btnShow);
            this.panelPage2.Controls.Add(this.txtConPasswrd);
            this.panelPage2.Controls.Add(this.txtPasswrd);
            this.panelPage2.Controls.Add(this.rjButton2);
            this.panelPage2.Controls.Add(this.rjButton6);
            this.panelPage2.Location = new System.Drawing.Point(13, 37);
            this.panelPage2.Margin = new System.Windows.Forms.Padding(2);
            this.panelPage2.Name = "panelPage2";
            this.panelPage2.Size = new System.Drawing.Size(340, 161);
            this.panelPage2.TabIndex = 50;
            this.panelPage2.Visible = false;
            // 
            // rjButton9
            // 
            this.rjButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton9.BorderRadius = 2;
            this.rjButton9.BorderSize = 0;
            this.rjButton9.Enabled = false;
            this.rjButton9.FlatAppearance.BorderSize = 0;
            this.rjButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton9.ForeColor = System.Drawing.Color.White;
            this.rjButton9.Location = new System.Drawing.Point(53, 120);
            this.rjButton9.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton9.Name = "rjButton9";
            this.rjButton9.Size = new System.Drawing.Size(2, 32);
            this.rjButton9.TabIndex = 49;
            this.rjButton9.TabStop = false;
            this.rjButton9.Text = "rjButton9";
            this.rjButton9.TextColor = System.Drawing.Color.White;
            this.rjButton9.UseVisualStyleBackColor = false;
            // 
            // rjButton7
            // 
            this.rjButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton7.BorderRadius = 2;
            this.rjButton7.BorderSize = 0;
            this.rjButton7.Enabled = false;
            this.rjButton7.FlatAppearance.BorderSize = 0;
            this.rjButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton7.ForeColor = System.Drawing.Color.White;
            this.rjButton7.Location = new System.Drawing.Point(53, 12);
            this.rjButton7.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton7.Name = "rjButton7";
            this.rjButton7.Size = new System.Drawing.Size(2, 32);
            this.rjButton7.TabIndex = 47;
            this.rjButton7.TabStop = false;
            this.rjButton7.Text = "rjButton7";
            this.rjButton7.TextColor = System.Drawing.Color.White;
            this.rjButton7.UseVisualStyleBackColor = false;
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconUser.Enabled = false;
            this.iconUser.FlatAppearance.BorderSize = 0;
            this.iconUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 25;
            this.iconUser.Location = new System.Drawing.Point(25, 17);
            this.iconUser.Margin = new System.Windows.Forms.Padding(2);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(29, 23);
            this.iconUser.TabIndex = 35;
            this.iconUser.TabStop = false;
            this.iconUser.UseVisualStyleBackColor = false;
            // 
            // rjButton8
            // 
            this.rjButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton8.BorderRadius = 2;
            this.rjButton8.BorderSize = 0;
            this.rjButton8.Enabled = false;
            this.rjButton8.FlatAppearance.BorderSize = 0;
            this.rjButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton8.ForeColor = System.Drawing.Color.White;
            this.rjButton8.Location = new System.Drawing.Point(53, 67);
            this.rjButton8.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton8.Name = "rjButton8";
            this.rjButton8.Size = new System.Drawing.Size(2, 32);
            this.rjButton8.TabIndex = 48;
            this.rjButton8.TabStop = false;
            this.rjButton8.Text = "rjButton8";
            this.rjButton8.TextColor = System.Drawing.Color.White;
            this.rjButton8.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 25;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(10, 6);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(322, 41);
            this.rjButton1.TabIndex = 33;
            this.rjButton1.TabStop = false;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // iconPassword
            // 
            this.iconPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconPassword.Enabled = false;
            this.iconPassword.FlatAppearance.BorderSize = 0;
            this.iconPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPassword.IconSize = 25;
            this.iconPassword.Location = new System.Drawing.Point(25, 71);
            this.iconPassword.Margin = new System.Windows.Forms.Padding(2);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(29, 23);
            this.iconPassword.TabIndex = 39;
            this.iconPassword.TabStop = false;
            this.iconPassword.UseVisualStyleBackColor = false;
            // 
            // btnConfirmShow
            // 
            this.btnConfirmShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.btnConfirmShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmShow.FlatAppearance.BorderSize = 0;
            this.btnConfirmShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.btnConfirmShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.btnConfirmShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnConfirmShow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnConfirmShow.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnConfirmShow.IconSize = 25;
            this.btnConfirmShow.Location = new System.Drawing.Point(289, 127);
            this.btnConfirmShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmShow.Name = "btnConfirmShow";
            this.btnConfirmShow.Size = new System.Drawing.Size(22, 23);
            this.btnConfirmShow.TabIndex = 6;
            this.btnConfirmShow.TabStop = false;
            this.btnConfirmShow.UseVisualStyleBackColor = false;
            this.btnConfirmShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // iconConfirmPassword
            // 
            this.iconConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconConfirmPassword.Enabled = false;
            this.iconConfirmPassword.FlatAppearance.BorderSize = 0;
            this.iconConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconConfirmPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconConfirmPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.iconConfirmPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconConfirmPassword.IconSize = 25;
            this.iconConfirmPassword.Location = new System.Drawing.Point(25, 126);
            this.iconConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.iconConfirmPassword.Name = "iconConfirmPassword";
            this.iconConfirmPassword.Size = new System.Drawing.Size(29, 23);
            this.iconConfirmPassword.TabIndex = 43;
            this.iconConfirmPassword.TabStop = false;
            this.iconConfirmPassword.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnShow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnShow.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnShow.IconSize = 25;
            this.btnShow.Location = new System.Drawing.Point(289, 72);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(22, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.TabStop = false;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 25;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Enabled = false;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(10, 60);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(322, 41);
            this.rjButton2.TabIndex = 38;
            this.rjButton2.TabStop = false;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 25;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.Enabled = false;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Location = new System.Drawing.Point(10, 116);
            this.rjButton6.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(322, 41);
            this.rjButton6.TabIndex = 42;
            this.rjButton6.TabStop = false;
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            // 
            // panelPage1
            // 
            this.panelPage1.Controls.Add(this.rjButton12);
            this.panelPage1.Controls.Add(this.cmbBoxGender);
            this.panelPage1.Controls.Add(this.datePicker);
            this.panelPage1.Controls.Add(this.rjButton15);
            this.panelPage1.Controls.Add(this.txtDate);
            this.panelPage1.Controls.Add(this.iconDate);
            this.panelPage1.Controls.Add(this.iconGender);
            this.panelPage1.Controls.Add(this.rjButton13);
            this.panelPage1.Controls.Add(this.rjButton10);
            this.panelPage1.Controls.Add(this.txtName);
            this.panelPage1.Controls.Add(this.iconName);
            this.panelPage1.Controls.Add(this.rjButton11);
            this.panelPage1.Controls.Add(this.rjButton14);
            this.panelPage1.Location = new System.Drawing.Point(357, 71);
            this.panelPage1.Margin = new System.Windows.Forms.Padding(2);
            this.panelPage1.Name = "panelPage1";
            this.panelPage1.Size = new System.Drawing.Size(340, 171);
            this.panelPage1.TabIndex = 51;
            this.panelPage1.Visible = false;
            // 
            // rjButton12
            // 
            this.rjButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton12.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton12.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton12.BorderRadius = 2;
            this.rjButton12.BorderSize = 0;
            this.rjButton12.Enabled = false;
            this.rjButton12.FlatAppearance.BorderSize = 0;
            this.rjButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton12.ForeColor = System.Drawing.Color.White;
            this.rjButton12.Location = new System.Drawing.Point(53, 67);
            this.rjButton12.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton12.Name = "rjButton12";
            this.rjButton12.Size = new System.Drawing.Size(2, 32);
            this.rjButton12.TabIndex = 59;
            this.rjButton12.TabStop = false;
            this.rjButton12.Text = "rjButton12";
            this.rjButton12.TextColor = System.Drawing.Color.White;
            this.rjButton12.UseVisualStyleBackColor = false;
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.cmbBoxGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.cmbBoxGender.BorderSize = 0;
            this.cmbBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGender.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.cmbBoxGender.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbBoxGender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.cmbBoxGender.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.cmbBoxGender.Location = new System.Drawing.Point(58, 71);
            this.cmbBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxGender.MinimumSize = new System.Drawing.Size(150, 0);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(262, 29);
            this.cmbBoxGender.TabIndex = 2;
            this.cmbBoxGender.Texts = "Giới tính";
            this.cmbBoxGender.OnSelectedIndexChanged += new System.EventHandler(this.cmbBoxGender_OnSelectedIndexChanged);
            // 
            // datePicker
            // 
            this.datePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePicker.BorderSize = 0;
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.datePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.datePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePicker.CustomFormat = "";
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(290, 124);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(27, 35);
            this.datePicker.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.datePicker.TabIndex = 54;
            this.datePicker.TabStop = false;
            this.datePicker.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // rjButton15
            // 
            this.rjButton15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton15.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton15.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton15.BorderRadius = 2;
            this.rjButton15.BorderSize = 0;
            this.rjButton15.Enabled = false;
            this.rjButton15.FlatAppearance.BorderSize = 0;
            this.rjButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton15.ForeColor = System.Drawing.Color.White;
            this.rjButton15.Location = new System.Drawing.Point(53, 120);
            this.rjButton15.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton15.Name = "rjButton15";
            this.rjButton15.Size = new System.Drawing.Size(2, 32);
            this.rjButton15.TabIndex = 63;
            this.rjButton15.TabStop = false;
            this.rjButton15.Text = "rjButton15";
            this.rjButton15.TextColor = System.Drawing.Color.White;
            this.rjButton15.UseVisualStyleBackColor = false;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtDate.Location = new System.Drawing.Point(64, 130);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(218, 23);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "01/01/2003";
            this.txtDate.Enter += new System.EventHandler(this.txtPH_Enter);
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtPH_Leave);
            // 
            // iconDate
            // 
            this.iconDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconDate.Enabled = false;
            this.iconDate.FlatAppearance.BorderSize = 0;
            this.iconDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDate.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconDate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.iconDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDate.IconSize = 25;
            this.iconDate.Location = new System.Drawing.Point(25, 126);
            this.iconDate.Margin = new System.Windows.Forms.Padding(2);
            this.iconDate.Name = "iconDate";
            this.iconDate.Size = new System.Drawing.Size(29, 23);
            this.iconDate.TabIndex = 62;
            this.iconDate.TabStop = false;
            this.iconDate.UseVisualStyleBackColor = false;
            // 
            // iconGender
            // 
            this.iconGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconGender.Enabled = false;
            this.iconGender.FlatAppearance.BorderSize = 0;
            this.iconGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGender.IconChar = FontAwesome.Sharp.IconChar.Genderless;
            this.iconGender.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.iconGender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGender.IconSize = 25;
            this.iconGender.Location = new System.Drawing.Point(25, 71);
            this.iconGender.Margin = new System.Windows.Forms.Padding(2);
            this.iconGender.Name = "iconGender";
            this.iconGender.Size = new System.Drawing.Size(29, 23);
            this.iconGender.TabIndex = 58;
            this.iconGender.TabStop = false;
            this.iconGender.UseVisualStyleBackColor = false;
            // 
            // rjButton13
            // 
            this.rjButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton13.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton13.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton13.BorderRadius = 25;
            this.rjButton13.BorderSize = 0;
            this.rjButton13.Enabled = false;
            this.rjButton13.FlatAppearance.BorderSize = 0;
            this.rjButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton13.ForeColor = System.Drawing.Color.White;
            this.rjButton13.Location = new System.Drawing.Point(10, 60);
            this.rjButton13.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton13.Name = "rjButton13";
            this.rjButton13.Size = new System.Drawing.Size(322, 41);
            this.rjButton13.TabIndex = 57;
            this.rjButton13.TabStop = false;
            this.rjButton13.TextColor = System.Drawing.Color.White;
            this.rjButton13.UseVisualStyleBackColor = false;
            // 
            // rjButton10
            // 
            this.rjButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton10.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton10.BorderRadius = 2;
            this.rjButton10.BorderSize = 0;
            this.rjButton10.Enabled = false;
            this.rjButton10.FlatAppearance.BorderSize = 0;
            this.rjButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton10.ForeColor = System.Drawing.Color.White;
            this.rjButton10.Location = new System.Drawing.Point(53, 12);
            this.rjButton10.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton10.Name = "rjButton10";
            this.rjButton10.Size = new System.Drawing.Size(2, 32);
            this.rjButton10.TabIndex = 55;
            this.rjButton10.TabStop = false;
            this.rjButton10.Text = "rjButton10";
            this.rjButton10.TextColor = System.Drawing.Color.White;
            this.rjButton10.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtName.Location = new System.Drawing.Point(64, 20);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Họ và Tên";
            this.txtName.Enter += new System.EventHandler(this.txtPH_Enter);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtName.Leave += new System.EventHandler(this.txtPH_Leave);
            // 
            // iconName
            // 
            this.iconName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconName.Enabled = false;
            this.iconName.FlatAppearance.BorderSize = 0;
            this.iconName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconName.IconChar = FontAwesome.Sharp.IconChar.Feather;
            this.iconName.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.iconName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconName.IconSize = 25;
            this.iconName.Location = new System.Drawing.Point(25, 17);
            this.iconName.Margin = new System.Windows.Forms.Padding(2);
            this.iconName.Name = "iconName";
            this.iconName.Size = new System.Drawing.Size(29, 23);
            this.iconName.TabIndex = 54;
            this.iconName.TabStop = false;
            this.iconName.UseVisualStyleBackColor = false;
            // 
            // rjButton11
            // 
            this.rjButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton11.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton11.BorderRadius = 25;
            this.rjButton11.BorderSize = 0;
            this.rjButton11.Enabled = false;
            this.rjButton11.FlatAppearance.BorderSize = 0;
            this.rjButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton11.ForeColor = System.Drawing.Color.White;
            this.rjButton11.Location = new System.Drawing.Point(10, 6);
            this.rjButton11.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton11.Name = "rjButton11";
            this.rjButton11.Size = new System.Drawing.Size(322, 41);
            this.rjButton11.TabIndex = 53;
            this.rjButton11.TabStop = false;
            this.rjButton11.TextColor = System.Drawing.Color.White;
            this.rjButton11.UseVisualStyleBackColor = false;
            // 
            // rjButton14
            // 
            this.rjButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton14.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton14.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton14.BorderRadius = 25;
            this.rjButton14.BorderSize = 0;
            this.rjButton14.Enabled = false;
            this.rjButton14.FlatAppearance.BorderSize = 0;
            this.rjButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton14.ForeColor = System.Drawing.Color.White;
            this.rjButton14.Location = new System.Drawing.Point(10, 116);
            this.rjButton14.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton14.Name = "rjButton14";
            this.rjButton14.Size = new System.Drawing.Size(322, 41);
            this.rjButton14.TabIndex = 61;
            this.rjButton14.TabStop = false;
            this.rjButton14.TextColor = System.Drawing.Color.White;
            this.rjButton14.UseVisualStyleBackColor = false;
            // 
            // panelBase
            // 
            this.panelBase.Location = new System.Drawing.Point(38, 109);
            this.panelBase.Margin = new System.Windows.Forms.Padding(2);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(340, 171);
            this.panelBase.TabIndex = 54;
            // 
            // slideAnim
            // 
            this.slideAnim.Interval = 1;
            this.slideAnim.Tick += new System.EventHandler(this.slideAnim_Tick);
            // 
            // btnPage2
            // 
            this.btnPage2.AutoSize = true;
            this.btnPage2.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnPage2.Location = new System.Drawing.Point(95, 294);
            this.btnPage2.Margin = new System.Windows.Forms.Padding(2);
            this.btnPage2.MinimumSize = new System.Drawing.Size(0, 17);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnPage2.Size = new System.Drawing.Size(22, 17);
            this.btnPage2.TabIndex = 53;
            this.btnPage2.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnPage2.UseVisualStyleBackColor = true;
            this.btnPage2.Visible = false;
            // 
            // btnPage1
            // 
            this.btnPage1.AutoSize = true;
            this.btnPage1.Checked = true;
            this.btnPage1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnPage1.Location = new System.Drawing.Point(71, 294);
            this.btnPage1.Margin = new System.Windows.Forms.Padding(2);
            this.btnPage1.MinimumSize = new System.Drawing.Size(0, 17);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnPage1.Size = new System.Drawing.Size(22, 17);
            this.btnPage1.TabIndex = 52;
            this.btnPage1.TabStop = true;
            this.btnPage1.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnPage1.UseVisualStyleBackColor = true;
            this.btnPage1.Visible = false;
            this.btnPage1.CheckedChanged += new System.EventHandler(this.btnPage1_CheckedChanged);
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 2;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.Enabled = false;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(59, 336);
            this.rjButton5.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(308, 3);
            this.rjButton5.TabIndex = 40;
            this.rjButton5.Text = "rjButton5";
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 15;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.rjButton4.Location = new System.Drawing.Point(203, 350);
            this.rjButton4.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(111, 24);
            this.rjButton4.TabIndex = 37;
            this.rjButton4.TabStop = false;
            this.rjButton4.Text = "Đăng Nhập";
            this.rjButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // btnResigter
            // 
            this.btnResigter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnResigter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnResigter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnResigter.BorderRadius = 30;
            this.btnResigter.BorderSize = 0;
            this.btnResigter.FlatAppearance.BorderSize = 0;
            this.btnResigter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResigter.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResigter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnResigter.Location = new System.Drawing.Point(240, 280);
            this.btnResigter.Margin = new System.Windows.Forms.Padding(2);
            this.btnResigter.Name = "btnResigter";
            this.btnResigter.Size = new System.Drawing.Size(128, 49);
            this.btnResigter.TabIndex = 36;
            this.btnResigter.TabStop = false;
            this.btnResigter.Text = "ĐĂNG KÍ";
            this.btnResigter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnResigter.UseVisualStyleBackColor = false;
            this.btnResigter.Visible = false;
            this.btnResigter.Click += new System.EventHandler(this.btnResigter_Click);
            // 
            // fakeTabStop
            // 
            this.fakeTabStop.Location = new System.Drawing.Point(175, 55);
            this.fakeTabStop.Margin = new System.Windows.Forms.Padding(2);
            this.fakeTabStop.Name = "fakeTabStop";
            this.fakeTabStop.Size = new System.Drawing.Size(62, 20);
            this.fakeTabStop.TabIndex = 0;
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.panelVerify);
            this.panelEmail.Controls.Add(this.panelSlideEmail);
            this.panelEmail.Location = new System.Drawing.Point(10, 162);
            this.panelEmail.Margin = new System.Windows.Forms.Padding(2);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(340, 171);
            this.panelEmail.TabIndex = 64;
            // 
            // panelVerify
            // 
            this.panelVerify.Controls.Add(this.lblChangeMail);
            this.panelVerify.Controls.Add(this.btnRegenerate);
            this.panelVerify.Controls.Add(this.rjButton16);
            this.panelVerify.Controls.Add(this.label2);
            this.panelVerify.Controls.Add(this.txtVerify);
            this.panelVerify.Controls.Add(this.iconButton1);
            this.panelVerify.Controls.Add(this.rjButton17);
            this.panelVerify.Location = new System.Drawing.Point(0, 75);
            this.panelVerify.Margin = new System.Windows.Forms.Padding(2);
            this.panelVerify.Name = "panelVerify";
            this.panelVerify.Size = new System.Drawing.Size(322, 73);
            this.panelVerify.TabIndex = 61;
            this.panelVerify.Visible = false;
            // 
            // lblChangeMail
            // 
            this.lblChangeMail.AutoSize = true;
            this.lblChangeMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChangeMail.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.lblChangeMail.Location = new System.Drawing.Point(245, 8);
            this.lblChangeMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeMail.Name = "lblChangeMail";
            this.lblChangeMail.Size = new System.Drawing.Size(69, 17);
            this.lblChangeMail.TabIndex = 62;
            this.lblChangeMail.Text = "Đổi Email";
            this.lblChangeMail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblChangeMail_MouseClick);
            // 
            // btnRegenerate
            // 
            this.btnRegenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.btnRegenerate.FlatAppearance.BorderSize = 0;
            this.btnRegenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegenerate.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnRegenerate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnRegenerate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegenerate.IconSize = 25;
            this.btnRegenerate.Location = new System.Drawing.Point(284, 41);
            this.btnRegenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegenerate.Name = "btnRegenerate";
            this.btnRegenerate.Size = new System.Drawing.Size(29, 23);
            this.btnRegenerate.TabIndex = 61;
            this.btnRegenerate.TabStop = false;
            this.btnRegenerate.UseVisualStyleBackColor = false;
            this.btnRegenerate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRegenerate_MouseClick);
            // 
            // rjButton16
            // 
            this.rjButton16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton16.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton16.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton16.BorderRadius = 2;
            this.rjButton16.BorderSize = 0;
            this.rjButton16.Enabled = false;
            this.rjButton16.FlatAppearance.BorderSize = 0;
            this.rjButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton16.ForeColor = System.Drawing.Color.White;
            this.rjButton16.Location = new System.Drawing.Point(53, 33);
            this.rjButton16.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton16.Name = "rjButton16";
            this.rjButton16.Size = new System.Drawing.Size(2, 32);
            this.rjButton16.TabIndex = 59;
            this.rjButton16.TabStop = false;
            this.rjButton16.Text = "rjButton16";
            this.rjButton16.TextColor = System.Drawing.Color.White;
            this.rjButton16.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(2, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "Xác Thực";
            // 
            // txtVerify
            // 
            this.txtVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtVerify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerify.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtVerify.Location = new System.Drawing.Point(69, 40);
            this.txtVerify.Margin = new System.Windows.Forms.Padding(2);
            this.txtVerify.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(185, 23);
            this.txtVerify.TabIndex = 8;
            this.txtVerify.Text = "Nhập mã xác thực";
            this.txtVerify.TextChanged += new System.EventHandler(this.txtVerify_TextChanged);
            this.txtVerify.Enter += new System.EventHandler(this.txtPH_Enter);
            this.txtVerify.Leave += new System.EventHandler(this.txtPH_Leave);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(20, 39);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(29, 23);
            this.iconButton1.TabIndex = 58;
            this.iconButton1.TabStop = false;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton17
            // 
            this.rjButton17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton17.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton17.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton17.BorderRadius = 25;
            this.rjButton17.BorderSize = 0;
            this.rjButton17.Enabled = false;
            this.rjButton17.FlatAppearance.BorderSize = 0;
            this.rjButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton17.ForeColor = System.Drawing.Color.White;
            this.rjButton17.Location = new System.Drawing.Point(0, 28);
            this.rjButton17.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton17.Name = "rjButton17";
            this.rjButton17.Size = new System.Drawing.Size(278, 41);
            this.rjButton17.TabIndex = 57;
            this.rjButton17.TabStop = false;
            this.rjButton17.TextColor = System.Drawing.Color.White;
            this.rjButton17.UseVisualStyleBackColor = false;
            this.rjButton17.Enter += new System.EventHandler(this.txtPH_Enter);
            this.rjButton17.Leave += new System.EventHandler(this.txtPH_Leave);
            // 
            // panelSlideEmail
            // 
            this.panelSlideEmail.Controls.Add(this.rjButton19);
            this.panelSlideEmail.Controls.Add(this.txtEmail);
            this.panelSlideEmail.Controls.Add(this.iconButton3);
            this.panelSlideEmail.Controls.Add(this.rjButton20);
            this.panelSlideEmail.Location = new System.Drawing.Point(2, 51);
            this.panelSlideEmail.Margin = new System.Windows.Forms.Padding(2);
            this.panelSlideEmail.Name = "panelSlideEmail";
            this.panelSlideEmail.Size = new System.Drawing.Size(338, 65);
            this.panelSlideEmail.TabIndex = 63;
            // 
            // rjButton19
            // 
            this.rjButton19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton19.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton19.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton19.BorderRadius = 2;
            this.rjButton19.BorderSize = 0;
            this.rjButton19.Enabled = false;
            this.rjButton19.FlatAppearance.BorderSize = 0;
            this.rjButton19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton19.ForeColor = System.Drawing.Color.White;
            this.rjButton19.Location = new System.Drawing.Point(50, 17);
            this.rjButton19.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton19.Name = "rjButton19";
            this.rjButton19.Size = new System.Drawing.Size(2, 32);
            this.rjButton19.TabIndex = 55;
            this.rjButton19.TabStop = false;
            this.rjButton19.Text = "rjButton19";
            this.rjButton19.TextColor = System.Drawing.Color.White;
            this.rjButton19.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtEmail.Location = new System.Drawing.Point(62, 24);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 23);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtPH_Enter);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtEmail.Leave += new System.EventHandler(this.txtPH_Leave);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconButton3.Enabled = false;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.At;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(22, 22);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(29, 23);
            this.iconButton3.TabIndex = 54;
            this.iconButton3.TabStop = false;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton20
            // 
            this.rjButton20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton20.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton20.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton20.BorderRadius = 25;
            this.rjButton20.BorderSize = 0;
            this.rjButton20.Enabled = false;
            this.rjButton20.FlatAppearance.BorderSize = 0;
            this.rjButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton20.ForeColor = System.Drawing.Color.White;
            this.rjButton20.Location = new System.Drawing.Point(8, 11);
            this.rjButton20.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton20.Name = "rjButton20";
            this.rjButton20.Size = new System.Drawing.Size(322, 41);
            this.rjButton20.TabIndex = 53;
            this.rjButton20.TabStop = false;
            this.rjButton20.TextColor = System.Drawing.Color.White;
            this.rjButton20.UseVisualStyleBackColor = false;
            // 
            // childSlideAnim
            // 
            this.childSlideAnim.Interval = 1;
            this.childSlideAnim.Tick += new System.EventHandler(this.childSlideAnim_Tick);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.btnReturn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 40;
            this.btnReturn.Location = new System.Drawing.Point(4, 116);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(29, 23);
            this.btnReturn.TabIndex = 66;
            this.btnReturn.TabStop = false;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReturn_MouseClick);
            // 
            // btnLogo
            // 
            this.btnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogo.BackgroundImage")));
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogo.Enabled = false;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Location = new System.Drawing.Point(97, 2);
            this.btnLogo.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(220, 117);
            this.btnLogo.TabIndex = 50;
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(412, 379);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panelPage2);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.btnPage2);
            this.Controls.Add(this.btnPage1);
            this.Controls.Add(this.rjButton5);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.btnResigter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.fakeTabStop);
            this.Controls.Add(this.panelPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSignUp";
            this.Text = "FormSignIn";
            this.MouseCaptureChanged += new System.EventHandler(this.FormSignUp_MouseCaptureChanged);
            this.panelPage2.ResumeLayout(false);
            this.panelPage2.PerformLayout();
            this.panelPage1.ResumeLayout(false);
            this.panelPage1.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelVerify.ResumeLayout(false);
            this.panelVerify.PerformLayout();
            this.panelSlideEmail.ResumeLayout(false);
            this.panelSlideEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUname;
        private FontAwesome.Sharp.IconButton iconUser;
        private CustomControls.RJButton rjButton1;
        private CustomControls.RJButton rjButton5;
        private System.Windows.Forms.TextBox txtPasswrd;
        private CustomControls.RJButton rjButton4;
        private FontAwesome.Sharp.IconButton iconPassword;
        private CustomControls.RJButton rjButton2;
        private CustomControls.RJButton btnResigter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConPasswrd;
        private FontAwesome.Sharp.IconButton iconConfirmPassword;
        private CustomControls.RJButton rjButton6;
        private FontAwesome.Sharp.IconButton btnConfirmShow;
        private CustomControls.RJButton rjButton7;
        private CustomControls.RJButton rjButton8;
        private CustomControls.RJButton rjButton9;
        private FontAwesome.Sharp.IconButton btnShow;
        private System.Windows.Forms.Panel panelPage2;
        private System.Windows.Forms.Panel panelPage1;
        private System.Windows.Forms.TextBox txtDate;
        private FontAwesome.Sharp.IconButton iconDate;
        private CustomControls.RJButton rjButton14;
        private CustomControls.RJButton rjButton12;
        private FontAwesome.Sharp.IconButton iconGender;
        private CustomControls.RJButton rjButton13;
        private CustomControls.RJButton rjButton10;
        private System.Windows.Forms.TextBox txtName;
        private FontAwesome.Sharp.IconButton iconName;
        private CustomControls.RJButton rjButton11;
        private RJRadioButton btnPage1;
        private RJRadioButton btnPage2;
        private CustomControls.RJButton rjButton15;
        private RJDatePicker datePicker;
        private RJComboBox cmbBoxGender;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Timer slideAnim;
        private System.Windows.Forms.TextBox fakeTabStop;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Panel panelEmail;
        private RJButton rjButton19;
        private System.Windows.Forms.TextBox txtEmail;
        private FontAwesome.Sharp.IconButton iconButton3;
        private RJButton rjButton20;
        private System.Windows.Forms.Label lblChangeMail;
        private System.Windows.Forms.Panel panelVerify;
        private FontAwesome.Sharp.IconButton btnRegenerate;
        private FontAwesome.Sharp.IconButton iconButton1;
        private RJButton rjButton16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVerify;
        private RJButton rjButton17;
        private System.Windows.Forms.Panel panelSlideEmail;
        private System.Windows.Forms.Timer childSlideAnim;
        private FontAwesome.Sharp.IconButton btnReturn;
    }
}