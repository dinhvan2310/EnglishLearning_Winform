namespace PBL3
{
    partial class WordForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnSynonym = new PBLLibrary.CustomControls.RJButton();
            this.btnGrammar = new PBLLibrary.CustomControls.RJButton();
            this.btnMeaning = new PBLLibrary.CustomControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.panelTop.Controls.Add(this.btnReturn);
            this.panelTop.Controls.Add(this.btnSynonym);
            this.panelTop.Controls.Add(this.btnGrammar);
            this.panelTop.Controls.Add(this.btnMeaning);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1057, 60);
            this.panelTop.TabIndex = 0;
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
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(40, 40);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSynonym
            // 
            this.btnSynonym.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnSynonym.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnSynonym.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSynonym.BorderRadius = 20;
            this.btnSynonym.BorderSize = 0;
            this.btnSynonym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSynonym.FlatAppearance.BorderSize = 0;
            this.btnSynonym.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSynonym.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSynonym.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSynonym.Location = new System.Drawing.Point(462, 29);
            this.btnSynonym.Name = "btnSynonym";
            this.btnSynonym.Size = new System.Drawing.Size(190, 50);
            this.btnSynonym.TabIndex = 2;
            this.btnSynonym.Text = "SYNONYM";
            this.btnSynonym.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSynonym.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSynonym.UseVisualStyleBackColor = false;
            this.btnSynonym.Click += new System.EventHandler(this.btnSynonym_Click);
            // 
            // btnGrammar
            // 
            this.btnGrammar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnGrammar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnGrammar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGrammar.BorderRadius = 20;
            this.btnGrammar.BorderSize = 0;
            this.btnGrammar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrammar.FlatAppearance.BorderSize = 0;
            this.btnGrammar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrammar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnGrammar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnGrammar.Location = new System.Drawing.Point(254, 29);
            this.btnGrammar.Name = "btnGrammar";
            this.btnGrammar.Size = new System.Drawing.Size(190, 50);
            this.btnGrammar.TabIndex = 1;
            this.btnGrammar.Text = "GRAMMAR";
            this.btnGrammar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrammar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnGrammar.UseVisualStyleBackColor = false;
            this.btnGrammar.Click += new System.EventHandler(this.btnGrammar_Click);
            // 
            // btnMeaning
            // 
            this.btnMeaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnMeaning.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnMeaning.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMeaning.BorderRadius = 20;
            this.btnMeaning.BorderSize = 0;
            this.btnMeaning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeaning.FlatAppearance.BorderSize = 0;
            this.btnMeaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeaning.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnMeaning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnMeaning.Location = new System.Drawing.Point(50, 29);
            this.btnMeaning.Name = "btnMeaning";
            this.btnMeaning.Size = new System.Drawing.Size(190, 50);
            this.btnMeaning.TabIndex = 0;
            this.btnMeaning.Text = "MEANING";
            this.btnMeaning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMeaning.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnMeaning.UseVisualStyleBackColor = false;
            this.btnMeaning.Click += new System.EventHandler(this.btnMeaning_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 436);
            this.panel3.TabIndex = 7;
            // 
            // panelBase
            // 
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(52, 60);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1005, 436);
            this.panelBase.TabIndex = 8;
            // 
            // WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.ControlBox = false;
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WordForm";
            this.Text = "WordForm";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private PBLLibrary.CustomControls.RJButton btnMeaning;
        private PBLLibrary.CustomControls.RJButton btnSynonym;
        private PBLLibrary.CustomControls.RJButton btnGrammar;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelBase;
    }
}