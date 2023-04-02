namespace PBL3
{
    partial class WordForm_Meaning
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
            this.lblWord = new System.Windows.Forms.Label();
            this.btnSpeak = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFavorite = new FontAwesome.Sharp.IconButton();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.txtDefinition = new System.Windows.Forms.RichTextBox();
            this.rjButton1 = new CustomControls.RJButton();
            this.lblType = new System.Windows.Forms.Label();
            this.underlineBar = new CustomControls.RJButton();
            this.underlineBarAnim = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.lblWord.Location = new System.Drawing.Point(71, 9);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(90, 37);
            this.lblWord.TabIndex = 5;
            this.lblWord.Text = "word";
            // 
            // btnSpeak
            // 
            this.btnSpeak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpeak.FlatAppearance.BorderSize = 0;
            this.btnSpeak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSpeak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeak.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            this.btnSpeak.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.btnSpeak.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSpeak.Location = new System.Drawing.Point(15, 8);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(50, 50);
            this.btnSpeak.TabIndex = 4;
            this.btnSpeak.TabStop = false;
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblWord);
            this.panel2.Controls.Add(this.btnFavorite);
            this.panel2.Controls.Add(this.btnSpeak);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 61);
            this.panel2.TabIndex = 8;
            // 
            // btnFavorite
            // 
            this.btnFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnFavorite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btnFavorite.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnFavorite.Location = new System.Drawing.Point(943, 8);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(50, 50);
            this.btnFavorite.TabIndex = 3;
            this.btnFavorite.TabStop = false;
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.Controls.Add(this.txtDefinition);
            this.panelInfo.Controls.Add(this.rjButton1);
            this.panelInfo.Controls.Add(this.lblType);
            this.panelInfo.Controls.Add(this.underlineBar);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 61);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1005, 375);
            this.panelInfo.TabIndex = 7;
            // 
            // txtDefinition
            // 
            this.txtDefinition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.txtDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDefinition.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDefinition.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.txtDefinition.Location = new System.Drawing.Point(16, 83);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.ReadOnly = true;
            this.txtDefinition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDefinition.Size = new System.Drawing.Size(977, 269);
            this.txtDefinition.TabIndex = 8;
            this.txtDefinition.TabStop = false;
            this.txtDefinition.Text = "\nDefinitions";
            this.txtDefinition.Visible = false;
            this.txtDefinition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDefSet_MouseClick);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(801, 14);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.lblType.Location = new System.Drawing.Point(12, 14);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(161, 34);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "ADJECTIVE";
            this.lblType.Visible = false;
            // 
            // underlineBar
            // 
            this.underlineBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.underlineBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.underlineBar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.underlineBar.BorderRadius = 5;
            this.underlineBar.BorderSize = 0;
            this.underlineBar.Enabled = false;
            this.underlineBar.FlatAppearance.BorderSize = 0;
            this.underlineBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.underlineBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.underlineBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underlineBar.ForeColor = System.Drawing.Color.White;
            this.underlineBar.Location = new System.Drawing.Point(15, 50);
            this.underlineBar.Name = "underlineBar";
            this.underlineBar.Size = new System.Drawing.Size(150, 10);
            this.underlineBar.TabIndex = 2;
            this.underlineBar.TabStop = false;
            this.underlineBar.TextColor = System.Drawing.Color.White;
            this.underlineBar.UseVisualStyleBackColor = false;
            // 
            // underlineBarAnim
            // 
            this.underlineBarAnim.Interval = 1;
            this.underlineBarAnim.Tick += new System.EventHandler(this.underlineBarAnim_Tick);
            // 
            // WordForm_Meaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1005, 436);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WordForm_Meaning";
            this.Text = "WordForm_Meaning";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WordForm_Meaning_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private FontAwesome.Sharp.IconButton btnSpeak;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnFavorite;
        private CustomControls.RJButton underlineBar;
        private System.Windows.Forms.Panel panelInfo;
        private CustomControls.RJButton rjButton1;
        private System.Windows.Forms.RichTextBox txtDefinition;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Timer underlineBarAnim;
    }
}