using CustomControls;

namespace PBL3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnPremium = new CustomControls.RJButton();
            this.lblVersion = new System.Windows.Forms.Label();
            this.rightPanelBtn = new System.Windows.Forms.Panel();
            this.iconOverlaySelectedBtn = new FontAwesome.Sharp.IconButton();
            this.btnOverlaySelectedBtn = new CustomControls.RJButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnGame = new FontAwesome.Sharp.IconButton();
            this.btnNotebook = new FontAwesome.Sharp.IconButton();
            this.btnTopic = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnCollapse = new FontAwesome.Sharp.IconButton();
            this.btnLogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fakeTabStop = new System.Windows.Forms.TextBox();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelSearch = new CustomControls.RJPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTranslate = new CustomControls.RJButton();
            this.rjButton6 = new CustomControls.RJButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnSearchType = new CustomControls.RJToggleButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelSearchFound = new System.Windows.Forms.Panel();
            this.btnFilledSearchFound = new FontAwesome.Sharp.IconButton();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rjButton2 = new CustomControls.RJButton();
            this.panelPersonal = new CustomControls.RJPanel();
            this.iconLogin = new FontAwesome.Sharp.IconButton();
            this.iconPersonal = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPersonalLogin = new CustomControls.RJButton();
            this.btnPersonalInfo = new CustomControls.RJButton();
            this.btnPersonal = new CustomControls.RJButton();
            this.btnAnnounce = new CustomControls.RJButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.iconChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblChildForm = new System.Windows.Forms.Label();
            this.panelDrag = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.iconSub = new FontAwesome.Sharp.IconButton();
            this.btnBackgroundRoundIn = new CustomControls.RJButton();
            this.btnBackgroundRoundOut = new System.Windows.Forms.Button();
            this.collapseAnim = new System.Windows.Forms.Timer(this.components);
            this.expandAnim = new System.Windows.Forms.Timer(this.components);
            this.rightPanelAnim = new System.Windows.Forms.Timer(this.components);
            this.fadeInFormAnim = new System.Windows.Forms.Timer(this.components);
            this.fadeOutFormAnim = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.iconSetting = new FontAwesome.Sharp.IconButton();
            this.btnPersonalSetting = new CustomControls.RJButton();
            this.panelButton.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSearchFound.SuspendLayout();
            this.panelPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).BeginInit();
            this.panelDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.panelButton.Controls.Add(this.btnPremium);
            this.panelButton.Controls.Add(this.lblVersion);
            this.panelButton.Controls.Add(this.rightPanelBtn);
            this.panelButton.Controls.Add(this.iconOverlaySelectedBtn);
            this.panelButton.Controls.Add(this.btnOverlaySelectedBtn);
            this.panelButton.Controls.Add(this.btnSetting);
            this.panelButton.Controls.Add(this.btnGame);
            this.panelButton.Controls.Add(this.btnNotebook);
            this.panelButton.Controls.Add(this.btnTopic);
            this.panelButton.Controls.Add(this.btnHome);
            this.panelButton.Controls.Add(this.panelLogo);
            this.panelButton.Controls.Add(this.label1);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Margin = new System.Windows.Forms.Padding(0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(200, 628);
            this.panelButton.TabIndex = 0;
            // 
            // btnPremium
            // 
            this.btnPremium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.btnPremium.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.btnPremium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPremium.BackgroundImage")));
            this.btnPremium.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPremium.BorderRadius = 20;
            this.btnPremium.BorderSize = 0;
            this.btnPremium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPremium.FlatAppearance.BorderSize = 0;
            this.btnPremium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPremium.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremium.ForeColor = System.Drawing.Color.White;
            this.btnPremium.Location = new System.Drawing.Point(24, 547);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(150, 40);
            this.btnPremium.TabIndex = 9;
            this.btnPremium.TabStop = false;
            this.btnPremium.Text = "premium";
            this.btnPremium.TextColor = System.Drawing.Color.White;
            this.btnPremium.UseVisualStyleBackColor = false;
            this.btnPremium.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPremium_MouseClick);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.lblVersion.Location = new System.Drawing.Point(52, 603);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(96, 16);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "PBL3 App v1.0";
            // 
            // rightPanelBtn
            // 
            this.rightPanelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.rightPanelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightPanelBtn.Location = new System.Drawing.Point(190, 200);
            this.rightPanelBtn.Name = "rightPanelBtn";
            this.rightPanelBtn.Size = new System.Drawing.Size(150, 60);
            this.rightPanelBtn.TabIndex = 7;
            // 
            // iconOverlaySelectedBtn
            // 
            this.iconOverlaySelectedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.iconOverlaySelectedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconOverlaySelectedBtn.FlatAppearance.BorderSize = 0;
            this.iconOverlaySelectedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.iconOverlaySelectedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.iconOverlaySelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconOverlaySelectedBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconOverlaySelectedBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.iconOverlaySelectedBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconOverlaySelectedBtn.IconSize = 32;
            this.iconOverlaySelectedBtn.Location = new System.Drawing.Point(12, 210);
            this.iconOverlaySelectedBtn.Name = "iconOverlaySelectedBtn";
            this.iconOverlaySelectedBtn.Size = new System.Drawing.Size(40, 40);
            this.iconOverlaySelectedBtn.TabIndex = 7;
            this.iconOverlaySelectedBtn.TabStop = false;
            this.iconOverlaySelectedBtn.UseVisualStyleBackColor = false;
            // 
            // btnOverlaySelectedBtn
            // 
            this.btnOverlaySelectedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.btnOverlaySelectedBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.btnOverlaySelectedBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOverlaySelectedBtn.BorderRadius = 30;
            this.btnOverlaySelectedBtn.BorderSize = 0;
            this.btnOverlaySelectedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverlaySelectedBtn.FlatAppearance.BorderSize = 0;
            this.btnOverlaySelectedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.btnOverlaySelectedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.btnOverlaySelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverlaySelectedBtn.ForeColor = System.Drawing.Color.White;
            this.btnOverlaySelectedBtn.Location = new System.Drawing.Point(3, 200);
            this.btnOverlaySelectedBtn.Name = "btnOverlaySelectedBtn";
            this.btnOverlaySelectedBtn.Size = new System.Drawing.Size(230, 60);
            this.btnOverlaySelectedBtn.TabIndex = 6;
            this.btnOverlaySelectedBtn.TabStop = false;
            this.btnOverlaySelectedBtn.TextColor = System.Drawing.Color.White;
            this.btnOverlaySelectedBtn.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnSetting.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 440);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(200, 60);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.TabStop = false;
            this.btnSetting.Text = "Cài Đặt";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnGame
            // 
            this.btnGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGame.FlatAppearance.BorderSize = 0;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnGame.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.btnGame.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnGame.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGame.IconSize = 32;
            this.btnGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGame.Location = new System.Drawing.Point(0, 380);
            this.btnGame.Name = "btnGame";
            this.btnGame.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGame.Size = new System.Drawing.Size(200, 60);
            this.btnGame.TabIndex = 4;
            this.btnGame.TabStop = false;
            this.btnGame.Text = "Trò Chơi";
            this.btnGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnNotebook
            // 
            this.btnNotebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotebook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotebook.FlatAppearance.BorderSize = 0;
            this.btnNotebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotebook.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnNotebook.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.btnNotebook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnNotebook.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnNotebook.IconSize = 32;
            this.btnNotebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotebook.Location = new System.Drawing.Point(0, 320);
            this.btnNotebook.Name = "btnNotebook";
            this.btnNotebook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNotebook.Size = new System.Drawing.Size(200, 60);
            this.btnNotebook.TabIndex = 3;
            this.btnNotebook.TabStop = false;
            this.btnNotebook.Text = "Sổ Tay";
            this.btnNotebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotebook.UseVisualStyleBackColor = true;
            this.btnNotebook.Click += new System.EventHandler(this.btnNotebook_Click);
            // 
            // btnTopic
            // 
            this.btnTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTopic.FlatAppearance.BorderSize = 0;
            this.btnTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopic.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnTopic.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnTopic.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnTopic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTopic.IconSize = 32;
            this.btnTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopic.Location = new System.Drawing.Point(0, 260);
            this.btnTopic.Name = "btnTopic";
            this.btnTopic.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTopic.Size = new System.Drawing.Size(200, 60);
            this.btnTopic.TabIndex = 2;
            this.btnTopic.TabStop = false;
            this.btnTopic.Text = "Chủ Đề";
            this.btnTopic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTopic.UseVisualStyleBackColor = true;
            this.btnTopic.Click += new System.EventHandler(this.btnTopic_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 200);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnCollapse);
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 200);
            this.panelLogo.TabIndex = 1;
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.Transparent;
            this.btnCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnCollapse.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnCollapse.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnCollapse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCollapse.IconSize = 32;
            this.btnCollapse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCollapse.Location = new System.Drawing.Point(157, 10);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(40, 40);
            this.btnCollapse.TabIndex = 6;
            this.btnCollapse.TabStop = false;
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogo.BackgroundImage")));
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Location = new System.Drawing.Point(0, 5);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(197, 194);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.TabStop = false;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLogo_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(126, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // fakeTabStop
            // 
            this.fakeTabStop.Location = new System.Drawing.Point(87, 77);
            this.fakeTabStop.Name = "fakeTabStop";
            this.fakeTabStop.Size = new System.Drawing.Size(77, 22);
            this.fakeTabStop.TabIndex = 0;
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.panelSearch);
            this.panelBase.Controls.Add(this.panelSearchFound);
            this.panelBase.Controls.Add(this.lblSearchType);
            this.panelBase.Controls.Add(this.label3);
            this.panelBase.Controls.Add(this.rjButton2);
            this.panelBase.Controls.Add(this.panelPersonal);
            this.panelBase.Controls.Add(this.btnPersonal);
            this.panelBase.Controls.Add(this.btnAnnounce);
            this.panelBase.Controls.Add(this.btnExit);
            this.panelBase.Controls.Add(this.iconChildForm);
            this.panelBase.Controls.Add(this.lblChildForm);
            this.panelBase.Controls.Add(this.panelDrag);
            this.panelBase.Controls.Add(this.iconSub);
            this.panelBase.Controls.Add(this.btnBackgroundRoundIn);
            this.panelBase.Controls.Add(this.btnBackgroundRoundOut);
            this.panelBase.Controls.Add(this.fakeTabStop);
            this.panelBase.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBase.Location = new System.Drawing.Point(200, 0);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1058, 628);
            this.panelBase.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.panelSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.panelSearch.BorderRadius = 40;
            this.panelSearch.Controls.Add(this.panel1);
            this.panelSearch.Controls.Add(this.rjButton6);
            this.panelSearch.Controls.Add(this.iconButton1);
            this.panelSearch.Controls.Add(this.btnSearchType);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.ForeColor = System.Drawing.Color.Black;
            this.panelSearch.GradientAngle = 90F;
            this.panelSearch.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.panelSearch.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.panelSearch.Location = new System.Drawing.Point(247, 74);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(574, 50);
            this.panelSearch.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.btnTranslate);
            this.panel1.Location = new System.Drawing.Point(440, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 59);
            this.panel1.TabIndex = 53;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.btnTranslate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.btnTranslate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTranslate.BorderRadius = 20;
            this.btnTranslate.BorderSize = 0;
            this.btnTranslate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTranslate.FlatAppearance.BorderSize = 0;
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnTranslate.Location = new System.Drawing.Point(9, -1);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(125, 50);
            this.btnTranslate.TabIndex = 51;
            this.btnTranslate.TabStop = false;
            this.btnTranslate.Text = "Dịch Văn Bản";
            this.btnTranslate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTranslate_MouseClick);
            // 
            // rjButton6
            // 
            this.rjButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 2;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Location = new System.Drawing.Point(377, 6);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(3, 39);
            this.rjButton6.TabIndex = 49;
            this.rjButton6.TabStop = false;
            this.rjButton6.Text = "rjButton6";
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(335, 7);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(38, 38);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.TabStop = false;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnSearchType
            // 
            this.btnSearchType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchType.AutoSize = true;
            this.btnSearchType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.btnSearchType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchType.FlatAppearance.BorderSize = 0;
            this.btnSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchType.Location = new System.Drawing.Point(390, 14);
            this.btnSearchType.MinimumSize = new System.Drawing.Size(44, 22);
            this.btnSearchType.Name = "btnSearchType";
            this.btnSearchType.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btnSearchType.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btnSearchType.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btnSearchType.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.btnSearchType.Size = new System.Drawing.Size(44, 22);
            this.btnSearchType.SolidStyle = false;
            this.btnSearchType.TabIndex = 49;
            this.btnSearchType.TabStop = false;
            this.btnSearchType.UseVisualStyleBackColor = false;
            this.btnSearchType.CheckedChanged += new System.EventHandler(this.btnSearchType_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "jg"});
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtSearch.Location = new System.Drawing.Point(29, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 29);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panelSearchFound
            // 
            this.panelSearchFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearchFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panelSearchFound.Controls.Add(this.btnFilledSearchFound);
            this.panelSearchFound.Location = new System.Drawing.Point(247, 101);
            this.panelSearchFound.Name = "panelSearchFound";
            this.panelSearchFound.Size = new System.Drawing.Size(443, 325);
            this.panelSearchFound.TabIndex = 15;
            this.panelSearchFound.Visible = false;
            // 
            // btnFilledSearchFound
            // 
            this.btnFilledSearchFound.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilledSearchFound.FlatAppearance.BorderSize = 0;
            this.btnFilledSearchFound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.btnFilledSearchFound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.btnFilledSearchFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilledSearchFound.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFilledSearchFound.IconColor = System.Drawing.Color.Black;
            this.btnFilledSearchFound.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilledSearchFound.Location = new System.Drawing.Point(0, 0);
            this.btnFilledSearchFound.Name = "btnFilledSearchFound";
            this.btnFilledSearchFound.Size = new System.Drawing.Size(443, 25);
            this.btnFilledSearchFound.TabIndex = 0;
            this.btnFilledSearchFound.TabStop = false;
            this.btnFilledSearchFound.UseVisualStyleBackColor = true;
            // 
            // lblSearchType
            // 
            this.lblSearchType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.lblSearchType.Location = new System.Drawing.Point(634, 127);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(54, 16);
            this.lblSearchType.TabIndex = 50;
            this.lblSearchType.Text = "ANH - ANH";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Aquire", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(820, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "123";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton2.BackgroundImage")));
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Enabled = false;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(881, 74);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(50, 50);
            this.rjButton2.TabIndex = 24;
            this.rjButton2.TabStop = false;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // panelPersonal
            // 
            this.panelPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.panelPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.panelPersonal.BorderRadius = 30;
            this.panelPersonal.Controls.Add(this.iconLogin);
            this.panelPersonal.Controls.Add(this.iconSetting);
            this.panelPersonal.Controls.Add(this.iconPersonal);
            this.panelPersonal.Controls.Add(this.button2);
            this.panelPersonal.Controls.Add(this.button1);
            this.panelPersonal.Controls.Add(this.btnPersonalLogin);
            this.panelPersonal.Controls.Add(this.btnPersonalSetting);
            this.panelPersonal.Controls.Add(this.btnPersonalInfo);
            this.panelPersonal.ForeColor = System.Drawing.Color.Black;
            this.panelPersonal.GradientAngle = 90F;
            this.panelPersonal.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.panelPersonal.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.panelPersonal.Location = new System.Drawing.Point(824, 126);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(222, 210);
            this.panelPersonal.TabIndex = 23;
            this.panelPersonal.Visible = false;
            // 
            // iconLogin
            // 
            this.iconLogin.Enabled = false;
            this.iconLogin.FlatAppearance.BorderSize = 0;
            this.iconLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.iconLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogin.IconSize = 32;
            this.iconLogin.Location = new System.Drawing.Point(156, 155);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(30, 30);
            this.iconLogin.TabIndex = 30;
            this.iconLogin.TabStop = false;
            this.iconLogin.UseVisualStyleBackColor = true;
            // 
            // iconPersonal
            // 
            this.iconPersonal.Enabled = false;
            this.iconPersonal.FlatAppearance.BorderSize = 0;
            this.iconPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPersonal.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.iconPersonal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.iconPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPersonal.IconSize = 32;
            this.iconPersonal.Location = new System.Drawing.Point(156, 20);
            this.iconPersonal.Name = "iconPersonal";
            this.iconPersonal.Size = new System.Drawing.Size(30, 30);
            this.iconPersonal.TabIndex = 28;
            this.iconPersonal.TabStop = false;
            this.iconPersonal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(22, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 1);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnPersonalLogin
            // 
            this.btnPersonalLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.btnPersonalLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.btnPersonalLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.btnPersonalLogin.BorderRadius = 8;
            this.btnPersonalLogin.BorderSize = 0;
            this.btnPersonalLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonalLogin.FlatAppearance.BorderSize = 0;
            this.btnPersonalLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalLogin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.btnPersonalLogin.Location = new System.Drawing.Point(22, 147);
            this.btnPersonalLogin.Name = "btnPersonalLogin";
            this.btnPersonalLogin.Size = new System.Drawing.Size(128, 42);
            this.btnPersonalLogin.TabIndex = 25;
            this.btnPersonalLogin.TabStop = false;
            this.btnPersonalLogin.Text = "Đăng Nhập";
            this.btnPersonalLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.btnPersonalLogin.UseVisualStyleBackColor = false;
            this.btnPersonalLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPersonalInfo
            // 
            this.btnPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.btnPersonalInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.btnPersonalInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.btnPersonalInfo.BorderRadius = 8;
            this.btnPersonalInfo.BorderSize = 0;
            this.btnPersonalInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonalInfo.FlatAppearance.BorderSize = 0;
            this.btnPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalInfo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.btnPersonalInfo.Location = new System.Drawing.Point(22, 14);
            this.btnPersonalInfo.Name = "btnPersonalInfo";
            this.btnPersonalInfo.Size = new System.Drawing.Size(128, 42);
            this.btnPersonalInfo.TabIndex = 23;
            this.btnPersonalInfo.TabStop = false;
            this.btnPersonalInfo.Text = "Thông Tin";
            this.btnPersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.btnPersonalInfo.UseVisualStyleBackColor = false;
            this.btnPersonalInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPersonalInfo_MouseClick);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.btnPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.btnPersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonal.BackgroundImage")));
            this.btnPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPersonal.BorderRadius = 15;
            this.btnPersonal.BorderSize = 0;
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.Location = new System.Drawing.Point(996, 74);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(50, 50);
            this.btnPersonal.TabIndex = 11;
            this.btnPersonal.TabStop = false;
            this.btnPersonal.TextColor = System.Drawing.Color.White;
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnAnnounce
            // 
            this.btnAnnounce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnounce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.btnAnnounce.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.btnAnnounce.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnounce.BackgroundImage")));
            this.btnAnnounce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnounce.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnnounce.BorderRadius = 15;
            this.btnAnnounce.BorderSize = 0;
            this.btnAnnounce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnounce.FlatAppearance.BorderSize = 0;
            this.btnAnnounce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnounce.ForeColor = System.Drawing.Color.White;
            this.btnAnnounce.Location = new System.Drawing.Point(937, 74);
            this.btnAnnounce.Name = "btnAnnounce";
            this.btnAnnounce.Size = new System.Drawing.Size(50, 50);
            this.btnAnnounce.TabIndex = 10;
            this.btnAnnounce.TabStop = false;
            this.btnAnnounce.TextColor = System.Drawing.Color.White;
            this.btnAnnounce.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 32;
            this.btnExit.Location = new System.Drawing.Point(1015, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // iconChildForm
            // 
            this.iconChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.iconChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.iconChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.iconChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChildForm.IconSize = 50;
            this.iconChildForm.Location = new System.Drawing.Point(10, 79);
            this.iconChildForm.Name = "iconChildForm";
            this.iconChildForm.Size = new System.Drawing.Size(50, 50);
            this.iconChildForm.TabIndex = 1;
            this.iconChildForm.TabStop = false;
            // 
            // lblChildForm
            // 
            this.lblChildForm.AutoSize = true;
            this.lblChildForm.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.lblChildForm.Location = new System.Drawing.Point(66, 87);
            this.lblChildForm.Name = "lblChildForm";
            this.lblChildForm.Size = new System.Drawing.Size(78, 34);
            this.lblChildForm.TabIndex = 0;
            this.lblChildForm.Text = "HOME";
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.panelDrag.Controls.Add(this.btnMinimize);
            this.panelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(1058, 50);
            this.panelDrag.TabIndex = 8;
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimize.IconSize = 32;
            this.btnMinimize.Location = new System.Drawing.Point(979, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconSub
            // 
            this.iconSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconSub.BackgroundImage")));
            this.iconSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconSub.Enabled = false;
            this.iconSub.FlatAppearance.BorderSize = 0;
            this.iconSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSub.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSub.IconColor = System.Drawing.Color.Black;
            this.iconSub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSub.Location = new System.Drawing.Point(11, 54);
            this.iconSub.Name = "iconSub";
            this.iconSub.Size = new System.Drawing.Size(230, 91);
            this.iconSub.TabIndex = 16;
            this.iconSub.TabStop = false;
            this.iconSub.UseVisualStyleBackColor = true;
            this.iconSub.Visible = false;
            // 
            // btnBackgroundRoundIn
            // 
            this.btnBackgroundRoundIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.btnBackgroundRoundIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.btnBackgroundRoundIn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBackgroundRoundIn.BorderRadius = 30;
            this.btnBackgroundRoundIn.BorderSize = 0;
            this.btnBackgroundRoundIn.Enabled = false;
            this.btnBackgroundRoundIn.FlatAppearance.BorderSize = 0;
            this.btnBackgroundRoundIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundRoundIn.ForeColor = System.Drawing.Color.White;
            this.btnBackgroundRoundIn.Location = new System.Drawing.Point(0, 48);
            this.btnBackgroundRoundIn.Name = "btnBackgroundRoundIn";
            this.btnBackgroundRoundIn.Size = new System.Drawing.Size(200, 59);
            this.btnBackgroundRoundIn.TabIndex = 9;
            this.btnBackgroundRoundIn.TextColor = System.Drawing.Color.White;
            this.btnBackgroundRoundIn.UseVisualStyleBackColor = false;
            // 
            // btnBackgroundRoundOut
            // 
            this.btnBackgroundRoundOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnBackgroundRoundOut.Enabled = false;
            this.btnBackgroundRoundOut.FlatAppearance.BorderSize = 0;
            this.btnBackgroundRoundOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundRoundOut.Location = new System.Drawing.Point(-36, 34);
            this.btnBackgroundRoundOut.Name = "btnBackgroundRoundOut";
            this.btnBackgroundRoundOut.Size = new System.Drawing.Size(97, 45);
            this.btnBackgroundRoundOut.TabIndex = 5;
            this.btnBackgroundRoundOut.UseVisualStyleBackColor = false;
            // 
            // collapseAnim
            // 
            this.collapseAnim.Interval = 1;
            this.collapseAnim.Tick += new System.EventHandler(this.collapseAnim_Tick);
            // 
            // expandAnim
            // 
            this.expandAnim.Interval = 1;
            this.expandAnim.Tick += new System.EventHandler(this.expandAnim_Tick);
            // 
            // rightPanelAnim
            // 
            this.rightPanelAnim.Interval = 1;
            this.rightPanelAnim.Tick += new System.EventHandler(this.rightPanelAnim_Tick);
            // 
            // fadeInFormAnim
            // 
            this.fadeInFormAnim.Interval = 40;
            this.fadeInFormAnim.Tick += new System.EventHandler(this.fadeInFormAnim_Tick);
            // 
            // fadeOutFormAnim
            // 
            this.fadeOutFormAnim.Interval = 40;
            this.fadeOutFormAnim.Tick += new System.EventHandler(this.fadeOutFormAnim_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(22, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 1);
            this.button2.TabIndex = 27;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // iconSetting
            // 
            this.iconSetting.Enabled = false;
            this.iconSetting.FlatAppearance.BorderSize = 0;
            this.iconSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iconSetting.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.iconSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSetting.IconSize = 32;
            this.iconSetting.Location = new System.Drawing.Point(156, 88);
            this.iconSetting.Name = "iconSetting";
            this.iconSetting.Size = new System.Drawing.Size(30, 30);
            this.iconSetting.TabIndex = 29;
            this.iconSetting.TabStop = false;
            this.iconSetting.UseVisualStyleBackColor = true;
            // 
            // btnPersonalSetting
            // 
            this.btnPersonalSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.btnPersonalSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.btnPersonalSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.btnPersonalSetting.BorderRadius = 8;
            this.btnPersonalSetting.BorderSize = 0;
            this.btnPersonalSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonalSetting.FlatAppearance.BorderSize = 0;
            this.btnPersonalSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalSetting.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.btnPersonalSetting.Location = new System.Drawing.Point(22, 80);
            this.btnPersonalSetting.Name = "btnPersonalSetting";
            this.btnPersonalSetting.Size = new System.Drawing.Size(128, 42);
            this.btnPersonalSetting.TabIndex = 24;
            this.btnPersonalSetting.TabStop = false;
            this.btnPersonalSetting.Text = "Cài Đặt";
            this.btnPersonalSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalSetting.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.btnPersonalSetting.UseVisualStyleBackColor = false;
            this.btnPersonalSetting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPersonalSetting_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1258, 628);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelBase.ResumeLayout(false);
            this.panelBase.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelSearchFound.ResumeLayout(false);
            this.panelPersonal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).EndInit();
            this.panelDrag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelBase;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconPictureBox iconChildForm;
        private System.Windows.Forms.Label lblChildForm;
        private CustomControls.RJButton btnPersonal;
        private CustomControls.RJButton btnAnnounce;
        private System.Windows.Forms.Button btnLogo;
        private FontAwesome.Sharp.IconButton btnCollapse;
        private System.Windows.Forms.Panel panelDrag;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private CustomControls.RJButton btnBackgroundRoundIn;
        private System.Windows.Forms.Button btnBackgroundRoundOut;
        private System.Windows.Forms.Timer collapseAnim;
        private System.Windows.Forms.Timer expandAnim;
        private FontAwesome.Sharp.IconButton iconOverlaySelectedBtn;
        private CustomControls.RJButton btnOverlaySelectedBtn;
        private System.Windows.Forms.Panel rightPanelBtn;
        private System.Windows.Forms.Timer rightPanelAnim;
        private System.Windows.Forms.Panel panelSearchFound;
        private FontAwesome.Sharp.IconButton btnFilledSearchFound;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox fakeTabStop;
        private System.Windows.Forms.Button button1;
        private CustomControls.RJButton btnPersonalLogin;
        private CustomControls.RJButton btnPersonalInfo;
        private FontAwesome.Sharp.IconButton iconLogin;
        private FontAwesome.Sharp.IconButton iconPersonal;
        public System.Windows.Forms.Timer fadeInFormAnim;
        public System.Windows.Forms.Timer fadeOutFormAnim;
        private CustomControls.RJButton btnPremium;
        private System.Windows.Forms.Label lblVersion;
        private CustomControls.RJButton rjButton2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconSub;
        public FontAwesome.Sharp.IconButton btnHome;
        public FontAwesome.Sharp.IconButton btnSetting;
        public FontAwesome.Sharp.IconButton btnGame;
        public FontAwesome.Sharp.IconButton btnNotebook;
        public FontAwesome.Sharp.IconButton btnTopic;
        public RJPanel panelPersonal;
        private RJButton btnTranslate;
        private System.Windows.Forms.Label lblSearchType;
        private RJPanel panelSearch;
        private RJButton rjButton6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private RJToggleButton btnSearchType;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconSetting;
        private System.Windows.Forms.Button button2;
        private RJButton btnPersonalSetting;
    }
}