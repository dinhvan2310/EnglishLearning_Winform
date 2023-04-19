
namespace PBL3
{
    partial class FormForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPassword));
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnContinue = new CustomControls.RJButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.rjButton1 = new CustomControls.RJButton();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.iconUser = new FontAwesome.Sharp.IconButton();
            this.rjButton7 = new CustomControls.RJButton();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelGmail = new System.Windows.Forms.Panel();
            this.rjButton2 = new CustomControls.RJButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rjButton3 = new CustomControls.RJButton();
            this.panelVerify = new System.Windows.Forms.Panel();
            this.btnRegenerate = new FontAwesome.Sharp.IconButton();
            this.rjButton16 = new CustomControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.rjButton17 = new CustomControls.RJButton();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.rjButton9 = new CustomControls.RJButton();
            this.rjButton8 = new CustomControls.RJButton();
            this.iconPassword = new FontAwesome.Sharp.IconButton();
            this.btnConfirmShow = new FontAwesome.Sharp.IconButton();
            this.iconConfirmPassword = new FontAwesome.Sharp.IconButton();
            this.btnShow = new FontAwesome.Sharp.IconButton();
            this.txtConPasswrd = new System.Windows.Forms.TextBox();
            this.txtPasswrd = new System.Windows.Forms.TextBox();
            this.rjButton6 = new CustomControls.RJButton();
            this.rjButton10 = new CustomControls.RJButton();
            this.labelNotify = new System.Windows.Forms.Label();
            this.timerEmail = new System.Windows.Forms.Timer(this.components);
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.panelUser.SuspendLayout();
            this.panelGmail.SuspendLayout();
            this.panelVerify.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
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
            this.btnLogo.Location = new System.Drawing.Point(88, 11);
            this.btnLogo.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(220, 117);
            this.btnLogo.TabIndex = 51;
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnContinue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnContinue.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnContinue.BorderRadius = 28;
            this.btnContinue.BorderSize = 0;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnContinue.Location = new System.Drawing.Point(136, 212);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(126, 32);
            this.btnContinue.TabIndex = 56;
            this.btnContinue.TabStop = false;
            this.btnContinue.Text = "TIẾP TỤC";
            this.btnContinue.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtUsername.Location = new System.Drawing.Point(64, 16);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 23);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "Tên Tài Khoản";
            this.txtUsername.Enter += new System.EventHandler(this.textBox_Enter);
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
            // panelUser
            // 
            this.panelUser.Controls.Add(this.rjButton7);
            this.panelUser.Controls.Add(this.iconUser);
            this.panelUser.Controls.Add(this.txtUsername);
            this.panelUser.Controls.Add(this.rjButton1);
            this.panelUser.Location = new System.Drawing.Point(30, 150);
            this.panelUser.Margin = new System.Windows.Forms.Padding(2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(340, 56);
            this.panelUser.TabIndex = 57;
            // 
            // panelGmail
            // 
            this.panelGmail.Controls.Add(this.rjButton2);
            this.panelGmail.Controls.Add(this.iconButton1);
            this.panelGmail.Controls.Add(this.txtEmail);
            this.panelGmail.Controls.Add(this.rjButton3);
            this.panelGmail.Location = new System.Drawing.Point(42, 250);
            this.panelGmail.Margin = new System.Windows.Forms.Padding(2);
            this.panelGmail.Name = "panelGmail";
            this.panelGmail.Size = new System.Drawing.Size(340, 56);
            this.panelGmail.TabIndex = 58;
            this.panelGmail.Visible = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 2;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Enabled = false;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(53, 12);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(2, 32);
            this.rjButton2.TabIndex = 47;
            this.rjButton2.TabStop = false;
            this.rjButton2.Text = "rjButton2";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(25, 17);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(29, 23);
            this.iconButton1.TabIndex = 35;
            this.iconButton1.TabStop = false;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtEmail.Location = new System.Drawing.Point(64, 16);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Nhập Email";
            this.txtEmail.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 25;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.Enabled = false;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(10, 6);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(322, 41);
            this.rjButton3.TabIndex = 33;
            this.rjButton3.TabStop = false;
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // panelVerify
            // 
            this.panelVerify.Controls.Add(this.btnRegenerate);
            this.panelVerify.Controls.Add(this.rjButton16);
            this.panelVerify.Controls.Add(this.label2);
            this.panelVerify.Controls.Add(this.txtVerify);
            this.panelVerify.Controls.Add(this.iconButton2);
            this.panelVerify.Controls.Add(this.rjButton17);
            this.panelVerify.Location = new System.Drawing.Point(88, 31);
            this.panelVerify.Margin = new System.Windows.Forms.Padding(2);
            this.panelVerify.Name = "panelVerify";
            this.panelVerify.Size = new System.Drawing.Size(322, 79);
            this.panelVerify.TabIndex = 62;
            this.panelVerify.Visible = false;
            // 
            // btnRegenerate
            // 
            this.btnRegenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.btnRegenerate.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnRegenerate.Click += new System.EventHandler(this.btnRegenerate_Click);
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
            this.txtVerify.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconButton2.Enabled = false;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(20, 39);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(29, 23);
            this.iconButton2.TabIndex = 58;
            this.iconButton2.TabStop = false;
            this.iconButton2.UseVisualStyleBackColor = false;
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
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.rjButton9);
            this.panelPassword.Controls.Add(this.rjButton8);
            this.panelPassword.Controls.Add(this.iconPassword);
            this.panelPassword.Controls.Add(this.btnConfirmShow);
            this.panelPassword.Controls.Add(this.iconConfirmPassword);
            this.panelPassword.Controls.Add(this.btnShow);
            this.panelPassword.Controls.Add(this.txtConPasswrd);
            this.panelPassword.Controls.Add(this.txtPasswrd);
            this.panelPassword.Controls.Add(this.rjButton6);
            this.panelPassword.Controls.Add(this.rjButton10);
            this.panelPassword.Location = new System.Drawing.Point(283, 217);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(2);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(343, 121);
            this.panelPassword.TabIndex = 63;
            this.panelPassword.Visible = false;
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
            this.rjButton9.Location = new System.Drawing.Point(54, 71);
            this.rjButton9.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton9.Name = "rjButton9";
            this.rjButton9.Size = new System.Drawing.Size(2, 32);
            this.rjButton9.TabIndex = 49;
            this.rjButton9.TabStop = false;
            this.rjButton9.Text = "rjButton9";
            this.rjButton9.TextColor = System.Drawing.Color.White;
            this.rjButton9.UseVisualStyleBackColor = false;
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
            this.rjButton8.Location = new System.Drawing.Point(54, 13);
            this.rjButton8.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton8.Name = "rjButton8";
            this.rjButton8.Size = new System.Drawing.Size(2, 32);
            this.rjButton8.TabIndex = 48;
            this.rjButton8.TabStop = false;
            this.rjButton8.Text = "rjButton8";
            this.rjButton8.TextColor = System.Drawing.Color.White;
            this.rjButton8.UseVisualStyleBackColor = false;
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
            this.iconPassword.Location = new System.Drawing.Point(25, 22);
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
            this.btnConfirmShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnConfirmShow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnConfirmShow.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnConfirmShow.IconSize = 25;
            this.btnConfirmShow.Location = new System.Drawing.Point(292, 77);
            this.btnConfirmShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmShow.Name = "btnConfirmShow";
            this.btnConfirmShow.Size = new System.Drawing.Size(22, 23);
            this.btnConfirmShow.TabIndex = 6;
            this.btnConfirmShow.TabStop = false;
            this.btnConfirmShow.UseVisualStyleBackColor = false;
            this.btnConfirmShow.Click += new System.EventHandler(this.Hide_Password);
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
            this.iconConfirmPassword.Location = new System.Drawing.Point(25, 77);
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
            this.btnShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnShow.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnShow.IconSize = 25;
            this.btnShow.Location = new System.Drawing.Point(292, 22);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(22, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.TabStop = false;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.Hide_Password);
            // 
            // txtConPasswrd
            // 
            this.txtConPasswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtConPasswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPasswrd.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPasswrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtConPasswrd.Location = new System.Drawing.Point(64, 75);
            this.txtConPasswrd.Margin = new System.Windows.Forms.Padding(2);
            this.txtConPasswrd.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtConPasswrd.Name = "txtConPasswrd";
            this.txtConPasswrd.Size = new System.Drawing.Size(218, 23);
            this.txtConPasswrd.TabIndex = 6;
            this.txtConPasswrd.Text = "Xác Nhận Mật Khẩu";
            this.txtConPasswrd.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // txtPasswrd
            // 
            this.txtPasswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtPasswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswrd.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtPasswrd.Location = new System.Drawing.Point(64, 18);
            this.txtPasswrd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswrd.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtPasswrd.Name = "txtPasswrd";
            this.txtPasswrd.Size = new System.Drawing.Size(218, 23);
            this.txtPasswrd.TabIndex = 5;
            this.txtPasswrd.Text = "Nhập mật khẩu mới";
            this.txtPasswrd.Enter += new System.EventHandler(this.textBox_Enter);
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
            this.rjButton6.Location = new System.Drawing.Point(10, 11);
            this.rjButton6.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(322, 41);
            this.rjButton6.TabIndex = 38;
            this.rjButton6.TabStop = false;
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            // 
            // rjButton10
            // 
            this.rjButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton10.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton10.BorderRadius = 25;
            this.rjButton10.BorderSize = 0;
            this.rjButton10.Enabled = false;
            this.rjButton10.FlatAppearance.BorderSize = 0;
            this.rjButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton10.ForeColor = System.Drawing.Color.White;
            this.rjButton10.Location = new System.Drawing.Point(8, 68);
            this.rjButton10.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton10.Name = "rjButton10";
            this.rjButton10.Size = new System.Drawing.Size(322, 41);
            this.rjButton10.TabIndex = 42;
            this.rjButton10.TabStop = false;
            this.rjButton10.TextColor = System.Drawing.Color.White;
            this.rjButton10.UseVisualStyleBackColor = false;
            // 
            // labelNotify
            // 
            this.labelNotify.AutoSize = true;
            this.labelNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotify.Location = new System.Drawing.Point(64, 112);
            this.labelNotify.Name = "labelNotify";
            this.labelNotify.Size = new System.Drawing.Size(86, 16);
            this.labelNotify.TabIndex = 64;
            this.labelNotify.Text = "..........................";
            this.labelNotify.Visible = false;
            // 
            // timerEmail
            // 
            this.timerEmail.Interval = 1000;
            this.timerEmail.Tick += new System.EventHandler(this.timerEmail_Tick);
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnReturn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 30;
            this.btnReturn.Location = new System.Drawing.Point(11, 24);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(30, 32);
            this.btnReturn.TabIndex = 65;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(396, 340);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.labelNotify);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelVerify);
            this.Controls.Add(this.panelGmail);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForgotPassword";
            this.Text = "FormForgotPassword";
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelGmail.ResumeLayout(false);
            this.panelGmail.PerformLayout();
            this.panelVerify.ResumeLayout(false);
            this.panelVerify.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogo;
        private CustomControls.RJButton btnContinue;
        private System.Windows.Forms.Timer timer;
        private CustomControls.RJButton rjButton1;
        private System.Windows.Forms.TextBox txtUsername;
        private FontAwesome.Sharp.IconButton iconUser;
        private CustomControls.RJButton rjButton7;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelGmail;
        private CustomControls.RJButton rjButton2;
        private System.Windows.Forms.TextBox txtEmail;
        private CustomControls.RJButton rjButton3;
        private System.Windows.Forms.Panel panelVerify;
        private FontAwesome.Sharp.IconButton btnRegenerate;
        private CustomControls.RJButton rjButton16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVerify;
        private FontAwesome.Sharp.IconButton iconButton2;
        private CustomControls.RJButton rjButton17;
        private System.Windows.Forms.Panel panelPassword;
        private CustomControls.RJButton rjButton9;
        private CustomControls.RJButton rjButton8;
        private FontAwesome.Sharp.IconButton iconPassword;
        private FontAwesome.Sharp.IconButton btnConfirmShow;
        private FontAwesome.Sharp.IconButton iconConfirmPassword;
        private FontAwesome.Sharp.IconButton btnShow;
        private System.Windows.Forms.TextBox txtConPasswrd;
        private System.Windows.Forms.TextBox txtPasswrd;
        private CustomControls.RJButton rjButton6;
        private CustomControls.RJButton rjButton10;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label labelNotify;
        private System.Windows.Forms.Timer timerEmail;
        private FontAwesome.Sharp.IconButton btnReturn;
    }
}