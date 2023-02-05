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
            this.rightPanelBtn = new System.Windows.Forms.Panel();
            this.iconOverlaySelectedBtn = new FontAwesome.Sharp.IconButton();
            this.btnOverlaySelectedBtn = new PBLLibrary.CustomControls.RJButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnGame = new FontAwesome.Sharp.IconButton();
            this.btnNotebook = new FontAwesome.Sharp.IconButton();
            this.btnTopic = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnCollapse = new FontAwesome.Sharp.IconButton();
            this.btnLogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconSearch = new FontAwesome.Sharp.IconButton();
            this.btnBackgroundSearch = new PBLLibrary.CustomControls.RJButton();
            this.panelSearchFound = new System.Windows.Forms.Panel();
            this.btnSearchFound10 = new FontAwesome.Sharp.IconButton();
            this.btnSearchFound9 = new FontAwesome.Sharp.IconButton();
            this.btnSearchFound8 = new FontAwesome.Sharp.IconButton();
            this.btnSearchFound7 = new FontAwesome.Sharp.IconButton();
            this.btnSearchFound6 = new FontAwesome.Sharp.IconButton();
            this.btnSearchFound5 = new FontAwesome.Sharp.IconButton();
            this.btnSearchFound4 = new FontAwesome.Sharp.IconButton();
            this.btnSearchFound3 = new FontAwesome.Sharp.IconButton();
            this.btnSearchFound2 = new FontAwesome.Sharp.IconButton();
            this.btnSearchFound1 = new FontAwesome.Sharp.IconButton();
            this.btnFilledSearchFound = new FontAwesome.Sharp.IconButton();
            this.rjToggleButton1 = new RJToggleButton();
            this.rjButton2 = new PBLLibrary.CustomControls.RJButton();
            this.btnAnnounce = new PBLLibrary.CustomControls.RJButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.iconChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblChildForm = new System.Windows.Forms.Label();
            this.panelDrag = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnBackgroundRoundIn = new PBLLibrary.CustomControls.RJButton();
            this.btnBackgroundRoundOut = new System.Windows.Forms.Button();
            this.collapseAnim = new System.Windows.Forms.Timer(this.components);
            this.expandAnim = new System.Windows.Forms.Timer(this.components);
            this.rightPanelAnim = new System.Windows.Forms.Timer(this.components);
            this.fadeInFormAnim = new System.Windows.Forms.Timer(this.components);
            this.fadeOutFormAnim = new System.Windows.Forms.Timer(this.components);
            this.panelButton.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelSearchFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).BeginInit();
            this.panelDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
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
            this.btnOverlaySelectedBtn.TextColor = System.Drawing.Color.White;
            this.btnOverlaySelectedBtn.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSetting.Text = "Settings";
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
            this.btnGame.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnGame.Text = "Minigames";
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
            this.btnNotebook.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnNotebook.Text = "Notebook";
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
            this.btnTopic.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnTopic.Text = "Topics";
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
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnHome.Text = "Home";
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
            this.btnCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnCollapse.FlatAppearance.BorderSize = 0;
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
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogo.BackgroundImage")));
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogo.Enabled = false;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(197, 194);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.UseVisualStyleBackColor = true;
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
            // panelBase
            // 
            this.panelBase.Controls.Add(this.txtSearch);
            this.panelBase.Controls.Add(this.iconSearch);
            this.panelBase.Controls.Add(this.btnBackgroundSearch);
            this.panelBase.Controls.Add(this.panelSearchFound);
            this.panelBase.Controls.Add(this.rjToggleButton1);
            this.panelBase.Controls.Add(this.rjButton2);
            this.panelBase.Controls.Add(this.btnAnnounce);
            this.panelBase.Controls.Add(this.btnExit);
            this.panelBase.Controls.Add(this.iconChildForm);
            this.panelBase.Controls.Add(this.lblChildForm);
            this.panelBase.Controls.Add(this.panelDrag);
            this.panelBase.Controls.Add(this.btnBackgroundRoundIn);
            this.panelBase.Controls.Add(this.btnBackgroundRoundOut);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBase.Location = new System.Drawing.Point(200, 0);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1057, 628);
            this.panelBase.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "jg"});
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtSearch.Location = new System.Drawing.Point(280, 90);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(422, 23);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // iconSearch
            // 
            this.iconSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconSearch.Enabled = false;
            this.iconSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.iconSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSearch.IconSize = 35;
            this.iconSearch.Location = new System.Drawing.Point(729, 81);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(38, 38);
            this.iconSearch.TabIndex = 5;
            this.iconSearch.UseVisualStyleBackColor = false;
            // 
            // btnBackgroundSearch
            // 
            this.btnBackgroundSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.btnBackgroundSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.btnBackgroundSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBackgroundSearch.BorderRadius = 20;
            this.btnBackgroundSearch.BorderSize = 0;
            this.btnBackgroundSearch.Enabled = false;
            this.btnBackgroundSearch.FlatAppearance.BorderSize = 0;
            this.btnBackgroundSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundSearch.ForeColor = System.Drawing.Color.White;
            this.btnBackgroundSearch.Location = new System.Drawing.Point(262, 74);
            this.btnBackgroundSearch.Name = "btnBackgroundSearch";
            this.btnBackgroundSearch.Size = new System.Drawing.Size(519, 50);
            this.btnBackgroundSearch.TabIndex = 2;
            this.btnBackgroundSearch.TextColor = System.Drawing.Color.White;
            this.btnBackgroundSearch.UseVisualStyleBackColor = true;
            // 
            // panelSearchFound
            // 
            this.panelSearchFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.panelSearchFound.Controls.Add(this.btnSearchFound10);
            this.panelSearchFound.Controls.Add(this.btnSearchFound9);
            this.panelSearchFound.Controls.Add(this.btnSearchFound8);
            this.panelSearchFound.Controls.Add(this.btnSearchFound7);
            this.panelSearchFound.Controls.Add(this.btnSearchFound6);
            this.panelSearchFound.Controls.Add(this.btnSearchFound5);
            this.panelSearchFound.Controls.Add(this.btnSearchFound4);
            this.panelSearchFound.Controls.Add(this.btnSearchFound3);
            this.panelSearchFound.Controls.Add(this.btnSearchFound2);
            this.panelSearchFound.Controls.Add(this.btnSearchFound1);
            this.panelSearchFound.Controls.Add(this.btnFilledSearchFound);
            this.panelSearchFound.Location = new System.Drawing.Point(262, 101);
            this.panelSearchFound.Name = "panelSearchFound";
            this.panelSearchFound.Size = new System.Drawing.Size(519, 325);
            this.panelSearchFound.TabIndex = 15;
            this.panelSearchFound.Visible = false;
            // 
            // btnSearchFound10
            // 
            this.btnSearchFound10.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchFound10.FlatAppearance.BorderSize = 0;
            this.btnSearchFound10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFound10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFound10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSearchFound10.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchFound10.IconColor = System.Drawing.Color.Black;
            this.btnSearchFound10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFound10.Location = new System.Drawing.Point(0, 295);
            this.btnSearchFound10.Name = "btnSearchFound10";
            this.btnSearchFound10.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearchFound10.Size = new System.Drawing.Size(519, 30);
            this.btnSearchFound10.TabIndex = 10;
            this.btnSearchFound10.Text = "Word";
            this.btnSearchFound10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFound10.UseVisualStyleBackColor = true;
            this.btnSearchFound10.MouseCaptureChanged += new System.EventHandler(this.btnSearchFound_Click);
            // 
            // btnSearchFound9
            // 
            this.btnSearchFound9.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchFound9.FlatAppearance.BorderSize = 0;
            this.btnSearchFound9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFound9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFound9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSearchFound9.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchFound9.IconColor = System.Drawing.Color.Black;
            this.btnSearchFound9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFound9.Location = new System.Drawing.Point(0, 265);
            this.btnSearchFound9.Name = "btnSearchFound9";
            this.btnSearchFound9.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearchFound9.Size = new System.Drawing.Size(519, 30);
            this.btnSearchFound9.TabIndex = 9;
            this.btnSearchFound9.Text = "Word";
            this.btnSearchFound9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFound9.UseVisualStyleBackColor = true;
            this.btnSearchFound9.MouseCaptureChanged += new System.EventHandler(this.btnSearchFound_Click);
            // 
            // btnSearchFound8
            // 
            this.btnSearchFound8.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchFound8.FlatAppearance.BorderSize = 0;
            this.btnSearchFound8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFound8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFound8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSearchFound8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchFound8.IconColor = System.Drawing.Color.Black;
            this.btnSearchFound8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFound8.Location = new System.Drawing.Point(0, 235);
            this.btnSearchFound8.Name = "btnSearchFound8";
            this.btnSearchFound8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearchFound8.Size = new System.Drawing.Size(519, 30);
            this.btnSearchFound8.TabIndex = 8;
            this.btnSearchFound8.Text = "Word";
            this.btnSearchFound8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFound8.UseVisualStyleBackColor = true;
            this.btnSearchFound8.MouseCaptureChanged += new System.EventHandler(this.btnSearchFound_Click);
            // 
            // btnSearchFound7
            // 
            this.btnSearchFound7.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchFound7.FlatAppearance.BorderSize = 0;
            this.btnSearchFound7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFound7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFound7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSearchFound7.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchFound7.IconColor = System.Drawing.Color.Black;
            this.btnSearchFound7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFound7.Location = new System.Drawing.Point(0, 205);
            this.btnSearchFound7.Name = "btnSearchFound7";
            this.btnSearchFound7.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearchFound7.Size = new System.Drawing.Size(519, 30);
            this.btnSearchFound7.TabIndex = 7;
            this.btnSearchFound7.Text = "Word";
            this.btnSearchFound7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFound7.UseVisualStyleBackColor = true;
            this.btnSearchFound7.MouseCaptureChanged += new System.EventHandler(this.btnSearchFound_Click);
            // 
            // btnSearchFound6
            // 
            this.btnSearchFound6.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchFound6.FlatAppearance.BorderSize = 0;
            this.btnSearchFound6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFound6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFound6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSearchFound6.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchFound6.IconColor = System.Drawing.Color.Black;
            this.btnSearchFound6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFound6.Location = new System.Drawing.Point(0, 175);
            this.btnSearchFound6.Name = "btnSearchFound6";
            this.btnSearchFound6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearchFound6.Size = new System.Drawing.Size(519, 30);
            this.btnSearchFound6.TabIndex = 6;
            this.btnSearchFound6.Text = "Word";
            this.btnSearchFound6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFound6.UseVisualStyleBackColor = true;
            this.btnSearchFound6.MouseCaptureChanged += new System.EventHandler(this.btnSearchFound_Click);
            // 
            // btnSearchFound5
            // 
            this.btnSearchFound5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchFound5.FlatAppearance.BorderSize = 0;
            this.btnSearchFound5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFound5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFound5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSearchFound5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchFound5.IconColor = System.Drawing.Color.Black;
            this.btnSearchFound5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFound5.Location = new System.Drawing.Point(0, 145);
            this.btnSearchFound5.Name = "btnSearchFound5";
            this.btnSearchFound5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearchFound5.Size = new System.Drawing.Size(519, 30);
            this.btnSearchFound5.TabIndex = 5;
            this.btnSearchFound5.Text = "Word";
            this.btnSearchFound5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFound5.UseVisualStyleBackColor = true;
            this.btnSearchFound5.MouseCaptureChanged += new System.EventHandler(this.btnSearchFound_Click);
            // 
            // btnSearchFound4
            // 
            this.btnSearchFound4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchFound4.FlatAppearance.BorderSize = 0;
            this.btnSearchFound4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFound4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFound4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSearchFound4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchFound4.IconColor = System.Drawing.Color.Black;
            this.btnSearchFound4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFound4.Location = new System.Drawing.Point(0, 115);
            this.btnSearchFound4.Name = "btnSearchFound4";
            this.btnSearchFound4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearchFound4.Size = new System.Drawing.Size(519, 30);
            this.btnSearchFound4.TabIndex = 4;
            this.btnSearchFound4.Text = "Word";
            this.btnSearchFound4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFound4.UseVisualStyleBackColor = true;
            this.btnSearchFound4.MouseCaptureChanged += new System.EventHandler(this.btnSearchFound_Click);
            // 
            // btnSearchFound3
            // 
            this.btnSearchFound3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchFound3.FlatAppearance.BorderSize = 0;
            this.btnSearchFound3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFound3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFound3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSearchFound3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchFound3.IconColor = System.Drawing.Color.Black;
            this.btnSearchFound3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFound3.Location = new System.Drawing.Point(0, 85);
            this.btnSearchFound3.Name = "btnSearchFound3";
            this.btnSearchFound3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearchFound3.Size = new System.Drawing.Size(519, 30);
            this.btnSearchFound3.TabIndex = 3;
            this.btnSearchFound3.Text = "Word";
            this.btnSearchFound3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFound3.UseVisualStyleBackColor = true;
            this.btnSearchFound3.MouseCaptureChanged += new System.EventHandler(this.btnSearchFound_Click);
            // 
            // btnSearchFound2
            // 
            this.btnSearchFound2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchFound2.FlatAppearance.BorderSize = 0;
            this.btnSearchFound2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFound2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFound2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSearchFound2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchFound2.IconColor = System.Drawing.Color.Black;
            this.btnSearchFound2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFound2.Location = new System.Drawing.Point(0, 55);
            this.btnSearchFound2.Name = "btnSearchFound2";
            this.btnSearchFound2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearchFound2.Size = new System.Drawing.Size(519, 30);
            this.btnSearchFound2.TabIndex = 2;
            this.btnSearchFound2.Text = "Word";
            this.btnSearchFound2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFound2.UseVisualStyleBackColor = true;
            this.btnSearchFound2.MouseCaptureChanged += new System.EventHandler(this.btnSearchFound_Click);
            // 
            // btnSearchFound1
            // 
            this.btnSearchFound1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchFound1.FlatAppearance.BorderSize = 0;
            this.btnSearchFound1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFound1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFound1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSearchFound1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchFound1.IconColor = System.Drawing.Color.Black;
            this.btnSearchFound1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFound1.Location = new System.Drawing.Point(0, 25);
            this.btnSearchFound1.Name = "btnSearchFound1";
            this.btnSearchFound1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearchFound1.Size = new System.Drawing.Size(519, 30);
            this.btnSearchFound1.TabIndex = 1;
            this.btnSearchFound1.Text = "Word";
            this.btnSearchFound1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFound1.UseVisualStyleBackColor = true;
            this.btnSearchFound1.MouseCaptureChanged += new System.EventHandler(this.btnSearchFound_Click);
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
            this.btnFilledSearchFound.Size = new System.Drawing.Size(519, 25);
            this.btnFilledSearchFound.TabIndex = 0;
            this.btnFilledSearchFound.UseVisualStyleBackColor = true;
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(841, 89);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 12;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(49)))), ((int)(((byte)(91)))));
            this.rjButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton2.BackgroundImage")));
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 15;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(995, 74);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(50, 50);
            this.rjButton2.TabIndex = 11;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
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
            this.btnAnnounce.Location = new System.Drawing.Point(936, 74);
            this.btnAnnounce.Name = "btnAnnounce";
            this.btnAnnounce.Size = new System.Drawing.Size(50, 50);
            this.btnAnnounce.TabIndex = 10;
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
            this.btnExit.Location = new System.Drawing.Point(1014, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 2;
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
            this.iconChildForm.Location = new System.Drawing.Point(10, 74);
            this.iconChildForm.Name = "iconChildForm";
            this.iconChildForm.Size = new System.Drawing.Size(50, 50);
            this.iconChildForm.TabIndex = 1;
            this.iconChildForm.TabStop = false;
            // 
            // lblChildForm
            // 
            this.lblChildForm.AutoSize = true;
            this.lblChildForm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.lblChildForm.Location = new System.Drawing.Point(66, 81);
            this.lblChildForm.Name = "lblChildForm";
            this.lblChildForm.Size = new System.Drawing.Size(98, 34);
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
            this.panelDrag.Size = new System.Drawing.Size(1057, 50);
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
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 32;
            this.btnMinimize.Location = new System.Drawing.Point(978, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnBackgroundRoundIn.Size = new System.Drawing.Size(150, 59);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1257, 628);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.Text = "MainForm";
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelBase.ResumeLayout(false);
            this.panelBase.PerformLayout();
            this.panelSearchFound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).EndInit();
            this.panelDrag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnGame;
        private FontAwesome.Sharp.IconButton btnNotebook;
        private System.Windows.Forms.Panel panelBase;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconPictureBox iconChildForm;
        private System.Windows.Forms.Label lblChildForm;
        private PBLLibrary.CustomControls.RJButton btnBackgroundSearch;
        private FontAwesome.Sharp.IconButton iconSearch;
        private PBLLibrary.CustomControls.RJButton rjButton2;
        private PBLLibrary.CustomControls.RJButton btnAnnounce;
        private System.Windows.Forms.Button btnLogo;
        private FontAwesome.Sharp.IconButton btnCollapse;
        private System.Windows.Forms.Panel panelDrag;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private PBLLibrary.CustomControls.RJButton btnBackgroundRoundIn;
        private System.Windows.Forms.Button btnBackgroundRoundOut;
        private System.Windows.Forms.Timer collapseAnim;
        private System.Windows.Forms.Timer expandAnim;
        private FontAwesome.Sharp.IconButton btnTopic;
        private FontAwesome.Sharp.IconButton iconOverlaySelectedBtn;
        private PBLLibrary.CustomControls.RJButton btnOverlaySelectedBtn;
        private System.Windows.Forms.Panel rightPanelBtn;
        private System.Windows.Forms.Timer rightPanelAnim;
        private System.Windows.Forms.Timer fadeInFormAnim;
        private System.Windows.Forms.Timer fadeOutFormAnim;
        private RJToggleButton rjToggleButton1;
        private System.Windows.Forms.Panel panelSearchFound;
        private FontAwesome.Sharp.IconButton btnFilledSearchFound;
        private FontAwesome.Sharp.IconButton btnSearchFound1;
        private FontAwesome.Sharp.IconButton btnSearchFound10;
        private FontAwesome.Sharp.IconButton btnSearchFound9;
        private FontAwesome.Sharp.IconButton btnSearchFound8;
        private FontAwesome.Sharp.IconButton btnSearchFound7;
        private FontAwesome.Sharp.IconButton btnSearchFound6;
        private FontAwesome.Sharp.IconButton btnSearchFound5;
        private FontAwesome.Sharp.IconButton btnSearchFound4;
        private FontAwesome.Sharp.IconButton btnSearchFound3;
        private FontAwesome.Sharp.IconButton btnSearchFound2;
        private System.Windows.Forms.TextBox txtSearch;
    }
}