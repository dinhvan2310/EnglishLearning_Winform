namespace PBL3
{
    partial class WordForm_Synonym
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
            this.lblType = new System.Windows.Forms.Label();
            this.underlineBar = new CustomControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelWords = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWordFound1 = new System.Windows.Forms.Label();
            this.underlineBarAnim = new System.Windows.Forms.Timer(this.components);
            this.panelWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblType.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.lblType.Location = new System.Drawing.Point(59, 41);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(180, 34);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "ĐỒNG NGHĨA";
            this.lblType.Click += new System.EventHandler(this.LabelType_MouseClick);
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
            this.underlineBar.Location = new System.Drawing.Point(62, 77);
            this.underlineBar.Name = "underlineBar";
            this.underlineBar.Size = new System.Drawing.Size(150, 10);
            this.underlineBar.TabIndex = 4;
            this.underlineBar.TabStop = false;
            this.underlineBar.TextColor = System.Drawing.Color.White;
            this.underlineBar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(359, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "TRÁI NGHĨA";
            this.label1.Click += new System.EventHandler(this.LabelType_MouseClick);
            // 
            // panelWords
            // 
            this.panelWords.Controls.Add(this.lblWordFound1);
            this.panelWords.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelWords.Location = new System.Drawing.Point(65, 126);
            this.panelWords.Name = "panelWords";
            this.panelWords.Size = new System.Drawing.Size(853, 256);
            this.panelWords.TabIndex = 8;
            // 
            // lblWordFound1
            // 
            this.lblWordFound1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWordFound1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblWordFound1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWordFound1.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordFound1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.lblWordFound1.Location = new System.Drawing.Point(3, 0);
            this.lblWordFound1.Name = "lblWordFound1";
            this.lblWordFound1.Size = new System.Drawing.Size(250, 30);
            this.lblWordFound1.TabIndex = 1;
            this.lblWordFound1.Text = "word";
            // 
            // underlineBarAnim
            // 
            this.underlineBarAnim.Interval = 1;
            this.underlineBarAnim.Tick += new System.EventHandler(this.underlineBarAnim_Tick);
            // 
            // WordForm_Synonym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1005, 436);
            this.Controls.Add(this.panelWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.underlineBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WordForm_Synonym";
            this.Text = "WordForm_Synonym";
            this.panelWords.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private CustomControls.RJButton underlineBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelWords;
        private System.Windows.Forms.Label lblWordFound1;
        private System.Windows.Forms.Timer underlineBarAnim;
    }
}