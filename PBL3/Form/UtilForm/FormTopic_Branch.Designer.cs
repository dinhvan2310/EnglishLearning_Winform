namespace PBL3
{
    partial class FormTopic_Branch
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
            this.panelBranch = new System.Windows.Forms.Panel();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.lblTopic = new System.Windows.Forms.Label();
            this.rjButton2 = new CustomControls.RJButton();
            this.SuspendLayout();
            // 
            // panelBranch
            // 
            this.panelBranch.AutoScroll = true;
            this.panelBranch.Location = new System.Drawing.Point(48, 87);
            this.panelBranch.Name = "panelBranch";
            this.panelBranch.Size = new System.Drawing.Size(958, 352);
            this.panelBranch.TabIndex = 1;
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
            this.btnReturn.TabIndex = 23;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReturn_MouseClick);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(205)))), ((int)(((byte)(216)))));
            this.lblTopic.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.lblTopic.Location = new System.Drawing.Point(129, 22);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(139, 39);
            this.lblTopic.TabIndex = 30;
            this.lblTopic.Text = "Chủ Đề";
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(205)))), ((int)(((byte)(216)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(205)))), ((int)(((byte)(216)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 33;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Enabled = false;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(97, 9);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(468, 66);
            this.rjButton2.TabIndex = 31;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // FormTopic_Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panelBranch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTopic_Branch";
            this.Text = "FormTopic_Branch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBranch;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Label lblTopic;
        private CustomControls.RJButton rjButton2;
    }
}