namespace PBL3
{
    partial class FormSetGoal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn5Min = new CustomControls.RJButton();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn15Min = new CustomControls.RJButton();
            this.btn30Min = new CustomControls.RJButton();
            this.btn45Min = new CustomControls.RJButton();
            this.btn60Min = new CustomControls.RJButton();
            this.btn120Min = new CustomControls.RJButton();
            this.rjPanel5 = new CustomControls.RJPanel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.flowPanel.SuspendLayout();
            this.rjPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.panel2.Location = new System.Drawing.Point(99, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 5);
            this.panel2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(93, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cài Đặt Mục Tiêu Học Tập";
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
            this.btnReturn.TabIndex = 22;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReturn_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(93, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hoàn thành mục tiêu mỗi ngày và thu thập Xu!";
            // 
            // btn5Min
            // 
            this.btn5Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn5Min.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn5Min.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn5Min.BorderRadius = 30;
            this.btn5Min.BorderSize = 0;
            this.btn5Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5Min.FlatAppearance.BorderSize = 0;
            this.btn5Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5Min.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn5Min.Location = new System.Drawing.Point(3, 3);
            this.btn5Min.Name = "btn5Min";
            this.btn5Min.Size = new System.Drawing.Size(360, 90);
            this.btn5Min.TabIndex = 0;
            this.btn5Min.Text = "10 Phút\r\nBắt đầu nhẹ nhàng!";
            this.btn5Min.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn5Min.UseVisualStyleBackColor = false;
            this.btn5Min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn5Min_MouseClick);
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.btn5Min);
            this.flowPanel.Controls.Add(this.btn15Min);
            this.flowPanel.Controls.Add(this.btn30Min);
            this.flowPanel.Controls.Add(this.btn45Min);
            this.flowPanel.Controls.Add(this.btn60Min);
            this.flowPanel.Controls.Add(this.btn120Min);
            this.flowPanel.Location = new System.Drawing.Point(99, 184);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(747, 300);
            this.flowPanel.TabIndex = 26;
            // 
            // btn15Min
            // 
            this.btn15Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn15Min.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn15Min.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn15Min.BorderRadius = 30;
            this.btn15Min.BorderSize = 0;
            this.btn15Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn15Min.FlatAppearance.BorderSize = 0;
            this.btn15Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn15Min.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn15Min.Location = new System.Drawing.Point(369, 3);
            this.btn15Min.Name = "btn15Min";
            this.btn15Min.Size = new System.Drawing.Size(360, 90);
            this.btn15Min.TabIndex = 1;
            this.btn15Min.Text = "15 Phút\r\nHình thành thói quen chưa?";
            this.btn15Min.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn15Min.UseVisualStyleBackColor = false;
            this.btn15Min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn5Min_MouseClick);
            // 
            // btn30Min
            // 
            this.btn30Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn30Min.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn30Min.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn30Min.BorderRadius = 30;
            this.btn30Min.BorderSize = 0;
            this.btn30Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn30Min.FlatAppearance.BorderSize = 0;
            this.btn30Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30Min.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn30Min.Location = new System.Drawing.Point(3, 99);
            this.btn30Min.Name = "btn30Min";
            this.btn30Min.Size = new System.Drawing.Size(360, 90);
            this.btn30Min.TabIndex = 2;
            this.btn30Min.Text = "30 Phút\r\nTập trung hơn nữa nào";
            this.btn30Min.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn30Min.UseVisualStyleBackColor = false;
            this.btn30Min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn5Min_MouseClick);
            // 
            // btn45Min
            // 
            this.btn45Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn45Min.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn45Min.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn45Min.BorderRadius = 30;
            this.btn45Min.BorderSize = 0;
            this.btn45Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn45Min.FlatAppearance.BorderSize = 0;
            this.btn45Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn45Min.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn45Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn45Min.Location = new System.Drawing.Point(369, 99);
            this.btn45Min.Name = "btn45Min";
            this.btn45Min.Size = new System.Drawing.Size(360, 90);
            this.btn45Min.TabIndex = 3;
            this.btn45Min.Text = "45 Phút\r\nChăm chỉ học hành ghê";
            this.btn45Min.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn45Min.UseVisualStyleBackColor = false;
            this.btn45Min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn5Min_MouseClick);
            // 
            // btn60Min
            // 
            this.btn60Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn60Min.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn60Min.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn60Min.BorderRadius = 30;
            this.btn60Min.BorderSize = 0;
            this.btn60Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn60Min.FlatAppearance.BorderSize = 0;
            this.btn60Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn60Min.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn60Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn60Min.Location = new System.Drawing.Point(3, 195);
            this.btn60Min.Name = "btn60Min";
            this.btn60Min.Size = new System.Drawing.Size(360, 90);
            this.btn60Min.TabIndex = 4;
            this.btn60Min.Text = "60 Phút\r\nChứng nhận cao thủ";
            this.btn60Min.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn60Min.UseVisualStyleBackColor = false;
            this.btn60Min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn5Min_MouseClick);
            // 
            // btn120Min
            // 
            this.btn120Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn120Min.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btn120Min.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn120Min.BorderRadius = 30;
            this.btn120Min.BorderSize = 0;
            this.btn120Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn120Min.FlatAppearance.BorderSize = 0;
            this.btn120Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn120Min.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn120Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn120Min.Location = new System.Drawing.Point(369, 195);
            this.btn120Min.Name = "btn120Min";
            this.btn120Min.Size = new System.Drawing.Size(360, 90);
            this.btn120Min.TabIndex = 5;
            this.btn120Min.Text = "120 Phút\r\nSiêu sao học tập";
            this.btn120Min.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn120Min.UseVisualStyleBackColor = false;
            this.btn120Min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn5Min_MouseClick);
            // 
            // rjPanel5
            // 
            this.rjPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rjPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel5.BorderRadius = 30;
            this.rjPanel5.Controls.Add(this.btnSave);
            this.rjPanel5.ForeColor = System.Drawing.Color.Black;
            this.rjPanel5.GradientAngle = 90F;
            this.rjPanel5.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel5.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel5.Location = new System.Drawing.Point(886, 364);
            this.rjPanel5.Name = "rjPanel5";
            this.rjPanel5.Size = new System.Drawing.Size(136, 120);
            this.rjPanel5.TabIndex = 37;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSave.IconSize = 100;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 120);
            this.btnSave.TabIndex = 8;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "LƯU";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormSetGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.rjPanel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetGoal";
            this.Text = "FormSetGoal";
            this.flowPanel.ResumeLayout(false);
            this.rjPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJButton btn5Min;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private CustomControls.RJButton btn15Min;
        private CustomControls.RJButton btn30Min;
        private CustomControls.RJButton btn45Min;
        private CustomControls.RJButton btn60Min;
        private CustomControls.RJButton btn120Min;
        private CustomControls.RJPanel rjPanel5;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}