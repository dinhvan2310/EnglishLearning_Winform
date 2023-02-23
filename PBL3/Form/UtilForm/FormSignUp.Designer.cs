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
            this.iconUser = new FontAwesome.Sharp.IconButton();
            this.txtPasswrd = new System.Windows.Forms.TextBox();
            this.iconPassword = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConPasswrd = new System.Windows.Forms.TextBox();
            this.iconConfirmPassword = new FontAwesome.Sharp.IconButton();
            this.btnConfirmShow = new FontAwesome.Sharp.IconButton();
            this.btnShow = new FontAwesome.Sharp.IconButton();
            this.panelPage2 = new System.Windows.Forms.Panel();
            this.rjButton9 = new CustomControls.RJButton();
            this.rjButton7 = new CustomControls.RJButton();
            this.rjButton8 = new CustomControls.RJButton();
            this.rjButton1 = new CustomControls.RJButton();
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
            this.rjButton3 = new CustomControls.RJButton();
            this.fakeTabStop = new System.Windows.Forms.TextBox();
            this.btnLogo = new System.Windows.Forms.Button();
            this.panelPage2.SuspendLayout();
            this.panelPage1.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUname
            // 
            this.txtUname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtUname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUname.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtUname.Location = new System.Drawing.Point(85, 24);
            this.txtUname.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(291, 25);
            this.txtUname.TabIndex = 4;
            this.txtUname.Text = "Tên Tài Khoản";
            this.txtUname.Enter += new System.EventHandler(this.txtPH_Enter);
            this.txtUname.Leave += new System.EventHandler(this.txtPH_Leave);
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
            this.iconUser.Location = new System.Drawing.Point(33, 21);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(39, 28);
            this.iconUser.TabIndex = 35;
            this.iconUser.TabStop = false;
            this.iconUser.UseVisualStyleBackColor = false;
            // 
            // txtPasswrd
            // 
            this.txtPasswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtPasswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswrd.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtPasswrd.Location = new System.Drawing.Point(85, 92);
            this.txtPasswrd.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtPasswrd.Name = "txtPasswrd";
            this.txtPasswrd.Size = new System.Drawing.Size(291, 25);
            this.txtPasswrd.TabIndex = 5;
            this.txtPasswrd.Text = "Mật Khẩu";
            this.txtPasswrd.Enter += new System.EventHandler(this.txtPH_Enter);
            this.txtPasswrd.Leave += new System.EventHandler(this.txtPH_Leave);
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
            this.iconPassword.Location = new System.Drawing.Point(33, 87);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(39, 28);
            this.iconPassword.TabIndex = 39;
            this.iconPassword.TabStop = false;
            this.iconPassword.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(160, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Đã Có Tài Khoản?";
            // 
            // txtConPasswrd
            // 
            this.txtConPasswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtConPasswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPasswrd.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPasswrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtConPasswrd.Location = new System.Drawing.Point(85, 160);
            this.txtConPasswrd.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtConPasswrd.Name = "txtConPasswrd";
            this.txtConPasswrd.Size = new System.Drawing.Size(291, 25);
            this.txtConPasswrd.TabIndex = 6;
            this.txtConPasswrd.Text = "Xác Nhận Mật Khẩu";
            this.txtConPasswrd.Enter += new System.EventHandler(this.txtPH_Enter);
            this.txtConPasswrd.Leave += new System.EventHandler(this.txtPH_Leave);
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
            this.iconConfirmPassword.Location = new System.Drawing.Point(33, 155);
            this.iconConfirmPassword.Name = "iconConfirmPassword";
            this.iconConfirmPassword.Size = new System.Drawing.Size(39, 28);
            this.iconConfirmPassword.TabIndex = 43;
            this.iconConfirmPassword.TabStop = false;
            this.iconConfirmPassword.UseVisualStyleBackColor = false;
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
            this.btnConfirmShow.Location = new System.Drawing.Point(385, 156);
            this.btnConfirmShow.Name = "btnConfirmShow";
            this.btnConfirmShow.Size = new System.Drawing.Size(29, 28);
            this.btnConfirmShow.TabIndex = 45;
            this.btnConfirmShow.TabStop = false;
            this.btnConfirmShow.UseVisualStyleBackColor = false;
            this.btnConfirmShow.Click += new System.EventHandler(this.btnConfirmShow_Click);
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
            this.btnShow.Location = new System.Drawing.Point(385, 88);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(29, 28);
            this.btnShow.TabIndex = 44;
            this.btnShow.TabStop = false;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
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
            this.panelPage2.Location = new System.Drawing.Point(12, 389);
            this.panelPage2.Name = "panelPage2";
            this.panelPage2.Size = new System.Drawing.Size(454, 198);
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
            this.rjButton9.Location = new System.Drawing.Point(71, 148);
            this.rjButton9.Name = "rjButton9";
            this.rjButton9.Size = new System.Drawing.Size(3, 39);
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
            this.rjButton7.Location = new System.Drawing.Point(71, 15);
            this.rjButton7.Name = "rjButton7";
            this.rjButton7.Size = new System.Drawing.Size(3, 39);
            this.rjButton7.TabIndex = 47;
            this.rjButton7.TabStop = false;
            this.rjButton7.Text = "rjButton7";
            this.rjButton7.TextColor = System.Drawing.Color.White;
            this.rjButton7.UseVisualStyleBackColor = false;
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
            this.rjButton8.Location = new System.Drawing.Point(71, 82);
            this.rjButton8.Name = "rjButton8";
            this.rjButton8.Size = new System.Drawing.Size(3, 39);
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
            this.rjButton1.Location = new System.Drawing.Point(13, 7);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(430, 50);
            this.rjButton1.TabIndex = 33;
            this.rjButton1.TabStop = false;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
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
            this.rjButton2.Location = new System.Drawing.Point(13, 74);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(430, 50);
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
            this.rjButton6.Location = new System.Drawing.Point(13, 143);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(430, 50);
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
            this.panelPage1.Location = new System.Drawing.Point(29, 3);
            this.panelPage1.Name = "panelPage1";
            this.panelPage1.Size = new System.Drawing.Size(454, 210);
            this.panelPage1.TabIndex = 51;
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
            this.rjButton12.Location = new System.Drawing.Point(71, 82);
            this.rjButton12.Name = "rjButton12";
            this.rjButton12.Size = new System.Drawing.Size(3, 39);
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
            this.cmbBoxGender.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.cmbBoxGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.cmbBoxGender.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không"});
            this.cmbBoxGender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.cmbBoxGender.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.cmbBoxGender.Location = new System.Drawing.Point(80, 87);
            this.cmbBoxGender.MinimumSize = new System.Drawing.Size(200, 0);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(349, 32);
            this.cmbBoxGender.TabIndex = 2;
            this.cmbBoxGender.Text = "Giới Tính";
            this.cmbBoxGender.Texts = "";
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
            this.datePicker.Location = new System.Drawing.Point(386, 153);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(35, 35);
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
            this.rjButton15.Location = new System.Drawing.Point(71, 148);
            this.rjButton15.Name = "rjButton15";
            this.rjButton15.Size = new System.Drawing.Size(3, 39);
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
            this.txtDate.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtDate.Location = new System.Drawing.Point(85, 160);
            this.txtDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(291, 25);
            this.txtDate.TabIndex = 3;
            this.txtDate.Text = "01/01/2003";
            this.txtDate.Enter += new System.EventHandler(this.txtPH_Enter);
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
            this.iconDate.Location = new System.Drawing.Point(33, 155);
            this.iconDate.Name = "iconDate";
            this.iconDate.Size = new System.Drawing.Size(39, 28);
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
            this.iconGender.Location = new System.Drawing.Point(33, 87);
            this.iconGender.Name = "iconGender";
            this.iconGender.Size = new System.Drawing.Size(39, 28);
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
            this.rjButton13.Location = new System.Drawing.Point(13, 74);
            this.rjButton13.Name = "rjButton13";
            this.rjButton13.Size = new System.Drawing.Size(430, 50);
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
            this.rjButton10.Location = new System.Drawing.Point(71, 15);
            this.rjButton10.Name = "rjButton10";
            this.rjButton10.Size = new System.Drawing.Size(3, 39);
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
            this.txtName.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtName.Location = new System.Drawing.Point(85, 24);
            this.txtName.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 25);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Họ và Tên";
            this.txtName.Enter += new System.EventHandler(this.txtPH_Enter);
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
            this.iconName.Location = new System.Drawing.Point(33, 21);
            this.iconName.Name = "iconName";
            this.iconName.Size = new System.Drawing.Size(39, 28);
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
            this.rjButton11.Location = new System.Drawing.Point(13, 7);
            this.rjButton11.Name = "rjButton11";
            this.rjButton11.Size = new System.Drawing.Size(430, 50);
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
            this.rjButton14.Location = new System.Drawing.Point(13, 143);
            this.rjButton14.Name = "rjButton14";
            this.rjButton14.Size = new System.Drawing.Size(430, 50);
            this.rjButton14.TabIndex = 61;
            this.rjButton14.TabStop = false;
            this.rjButton14.TextColor = System.Drawing.Color.White;
            this.rjButton14.UseVisualStyleBackColor = false;
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.panelPage1);
            this.panelBase.Location = new System.Drawing.Point(50, 134);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(454, 210);
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
            this.btnPage2.Location = new System.Drawing.Point(127, 362);
            this.btnPage2.MinimumSize = new System.Drawing.Size(0, 21);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPage2.Size = new System.Drawing.Size(27, 21);
            this.btnPage2.TabIndex = 53;
            this.btnPage2.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnPage2.UseVisualStyleBackColor = true;
            // 
            // btnPage1
            // 
            this.btnPage1.AutoSize = true;
            this.btnPage1.Checked = true;
            this.btnPage1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnPage1.Location = new System.Drawing.Point(95, 362);
            this.btnPage1.MinimumSize = new System.Drawing.Size(0, 21);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPage1.Size = new System.Drawing.Size(27, 21);
            this.btnPage1.TabIndex = 52;
            this.btnPage1.TabStop = true;
            this.btnPage1.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnPage1.UseVisualStyleBackColor = true;
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
            this.rjButton5.Location = new System.Drawing.Point(79, 414);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(411, 4);
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
            this.rjButton4.Location = new System.Drawing.Point(298, 431);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(114, 30);
            this.rjButton4.TabIndex = 37;
            this.rjButton4.TabStop = false;
            this.rjButton4.Text = "Đăng Nhập";
            this.rjButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 30;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.rjButton3.Location = new System.Drawing.Point(320, 345);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(170, 60);
            this.rjButton3.TabIndex = 36;
            this.rjButton3.TabStop = false;
            this.rjButton3.Text = "ĐĂNG KÍ";
            this.rjButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // fakeTabStop
            // 
            this.fakeTabStop.Location = new System.Drawing.Point(233, 68);
            this.fakeTabStop.Name = "fakeTabStop";
            this.fakeTabStop.Size = new System.Drawing.Size(81, 22);
            this.fakeTabStop.TabIndex = 0;
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
            this.btnLogo.Location = new System.Drawing.Point(129, 3);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(293, 144);
            this.btnLogo.TabIndex = 50;
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(550, 467);
            this.Controls.Add(this.panelPage2);
            this.Controls.Add(this.btnPage2);
            this.Controls.Add(this.btnPage1);
            this.Controls.Add(this.rjButton5);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.fakeTabStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSignUp";
            this.Text = "FormSignIn";
            this.MouseCaptureChanged += new System.EventHandler(this.FormSignUp_MouseCaptureChanged);
            this.panelPage2.ResumeLayout(false);
            this.panelPage2.PerformLayout();
            this.panelPage1.ResumeLayout(false);
            this.panelPage1.PerformLayout();
            this.panelBase.ResumeLayout(false);
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
        private CustomControls.RJButton rjButton3;
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
    }
}