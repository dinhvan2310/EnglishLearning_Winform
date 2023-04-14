namespace PBL3
{
    partial class FormAdmin
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
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPacket = new CustomControls.RJButton();
            this.btnAccount = new CustomControls.RJButton();
            this.btnTopic = new CustomControls.RJButton();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 60);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1057, 436);
            this.panelBase.TabIndex = 11;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Controls.Add(this.btnPacket);
            this.panelTop.Controls.Add(this.btnTopic);
            this.panelTop.Controls.Add(this.btnAccount);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1057, 60);
            this.panelTop.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.panel2.Location = new System.Drawing.Point(37, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 5);
            this.panel2.TabIndex = 60;
            // 
            // btnPacket
            // 
            this.btnPacket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnPacket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnPacket.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPacket.BorderRadius = 20;
            this.btnPacket.BorderSize = 0;
            this.btnPacket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacket.FlatAppearance.BorderSize = 0;
            this.btnPacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacket.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnPacket.Location = new System.Drawing.Point(256, 29);
            this.btnPacket.Name = "btnPacket";
            this.btnPacket.Size = new System.Drawing.Size(190, 50);
            this.btnPacket.TabIndex = 2;
            this.btnPacket.Text = "GÓI NGƯỜI DÙNG";
            this.btnPacket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPacket.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnPacket.UseVisualStyleBackColor = false;
            this.btnPacket.Click += new System.EventHandler(this.btnPacket_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnAccount.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAccount.BorderRadius = 20;
            this.btnAccount.BorderSize = 0;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnAccount.Location = new System.Drawing.Point(50, 29);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(190, 50);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "TÀI KHOẢN";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccount.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnTopic
            // 
            this.btnTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnTopic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnTopic.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTopic.BorderRadius = 20;
            this.btnTopic.BorderSize = 0;
            this.btnTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopic.FlatAppearance.BorderSize = 0;
            this.btnTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopic.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnTopic.Location = new System.Drawing.Point(462, 29);
            this.btnTopic.Name = "btnTopic";
            this.btnTopic.Size = new System.Drawing.Size(190, 50);
            this.btnTopic.TabIndex = 1;
            this.btnTopic.Text = "CHỦ ĐỀ TỪ VỰNG";
            this.btnTopic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTopic.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnTopic.UseVisualStyleBackColor = false;
            this.btnTopic.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Panel panelTop;
        private CustomControls.RJButton btnAccount;
        private CustomControls.RJButton btnPacket;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJButton btnTopic;
    }
}