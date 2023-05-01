namespace PBL3
{
    partial class FormGame2
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
            this.rjPanel1 = new CustomControls.RJPanel();
            this.btnRight4 = new CustomControls.RJButton();
            this.btnRight3 = new CustomControls.RJButton();
            this.btnRight2 = new CustomControls.RJButton();
            this.btnRight1 = new CustomControls.RJButton();
            this.btnLeft4 = new CustomControls.RJButton();
            this.btnLeft3 = new CustomControls.RJButton();
            this.btnLeft2 = new CustomControls.RJButton();
            this.btnLeft1 = new CustomControls.RJButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new CustomControls.RJButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.rjPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.Controls.Add(this.btnRight4);
            this.rjPanel1.Controls.Add(this.btnRight3);
            this.rjPanel1.Controls.Add(this.btnRight2);
            this.rjPanel1.Controls.Add(this.btnRight1);
            this.rjPanel1.Controls.Add(this.btnLeft4);
            this.rjPanel1.Controls.Add(this.btnLeft3);
            this.rjPanel1.Controls.Add(this.btnLeft2);
            this.rjPanel1.Controls.Add(this.btnLeft1);
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.rjPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.rjPanel1.Location = new System.Drawing.Point(216, 77);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(574, 281);
            this.rjPanel1.TabIndex = 0;
            // 
            // btnRight4
            // 
            this.btnRight4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnRight4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnRight4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRight4.BorderRadius = 10;
            this.btnRight4.BorderSize = 0;
            this.btnRight4.FlatAppearance.BorderSize = 0;
            this.btnRight4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnRight4.Location = new System.Drawing.Point(342, 210);
            this.btnRight4.Name = "btnRight4";
            this.btnRight4.Size = new System.Drawing.Size(190, 47);
            this.btnRight4.TabIndex = 8;
            this.btnRight4.Text = "D";
            this.btnRight4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnRight4.UseVisualStyleBackColor = false;
            this.btnRight4.Click += new System.EventHandler(this.btnRightAns_click);
            // 
            // btnRight3
            // 
            this.btnRight3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnRight3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnRight3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRight3.BorderRadius = 10;
            this.btnRight3.BorderSize = 0;
            this.btnRight3.FlatAppearance.BorderSize = 0;
            this.btnRight3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnRight3.Location = new System.Drawing.Point(342, 147);
            this.btnRight3.Name = "btnRight3";
            this.btnRight3.Size = new System.Drawing.Size(190, 47);
            this.btnRight3.TabIndex = 7;
            this.btnRight3.Text = "C";
            this.btnRight3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnRight3.UseVisualStyleBackColor = false;
            this.btnRight3.Click += new System.EventHandler(this.btnRightAns_click);
            // 
            // btnRight2
            // 
            this.btnRight2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnRight2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnRight2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRight2.BorderRadius = 10;
            this.btnRight2.BorderSize = 0;
            this.btnRight2.FlatAppearance.BorderSize = 0;
            this.btnRight2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnRight2.Location = new System.Drawing.Point(342, 83);
            this.btnRight2.Name = "btnRight2";
            this.btnRight2.Size = new System.Drawing.Size(190, 47);
            this.btnRight2.TabIndex = 6;
            this.btnRight2.Text = "B";
            this.btnRight2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnRight2.UseVisualStyleBackColor = false;
            this.btnRight2.Click += new System.EventHandler(this.btnRightAns_click);
            // 
            // btnRight1
            // 
            this.btnRight1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnRight1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnRight1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRight1.BorderRadius = 10;
            this.btnRight1.BorderSize = 0;
            this.btnRight1.FlatAppearance.BorderSize = 0;
            this.btnRight1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnRight1.Location = new System.Drawing.Point(342, 20);
            this.btnRight1.Name = "btnRight1";
            this.btnRight1.Size = new System.Drawing.Size(190, 47);
            this.btnRight1.TabIndex = 5;
            this.btnRight1.Text = "A";
            this.btnRight1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnRight1.UseVisualStyleBackColor = false;
            this.btnRight1.Click += new System.EventHandler(this.btnRightAns_click);
            // 
            // btnLeft4
            // 
            this.btnLeft4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnLeft4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnLeft4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLeft4.BorderRadius = 10;
            this.btnLeft4.BorderSize = 0;
            this.btnLeft4.FlatAppearance.BorderSize = 0;
            this.btnLeft4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnLeft4.Location = new System.Drawing.Point(34, 210);
            this.btnLeft4.Name = "btnLeft4";
            this.btnLeft4.Size = new System.Drawing.Size(190, 47);
            this.btnLeft4.TabIndex = 3;
            this.btnLeft4.Text = "D";
            this.btnLeft4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnLeft4.UseVisualStyleBackColor = false;
            this.btnLeft4.Click += new System.EventHandler(this.btnLeftAns_click);
            // 
            // btnLeft3
            // 
            this.btnLeft3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnLeft3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnLeft3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLeft3.BorderRadius = 10;
            this.btnLeft3.BorderSize = 0;
            this.btnLeft3.FlatAppearance.BorderSize = 0;
            this.btnLeft3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnLeft3.Location = new System.Drawing.Point(34, 147);
            this.btnLeft3.Name = "btnLeft3";
            this.btnLeft3.Size = new System.Drawing.Size(190, 47);
            this.btnLeft3.TabIndex = 2;
            this.btnLeft3.Text = "C";
            this.btnLeft3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnLeft3.UseVisualStyleBackColor = false;
            this.btnLeft3.Click += new System.EventHandler(this.btnLeftAns_click);
            // 
            // btnLeft2
            // 
            this.btnLeft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnLeft2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnLeft2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLeft2.BorderRadius = 10;
            this.btnLeft2.BorderSize = 0;
            this.btnLeft2.FlatAppearance.BorderSize = 0;
            this.btnLeft2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnLeft2.Location = new System.Drawing.Point(34, 83);
            this.btnLeft2.Name = "btnLeft2";
            this.btnLeft2.Size = new System.Drawing.Size(190, 47);
            this.btnLeft2.TabIndex = 1;
            this.btnLeft2.Text = "B";
            this.btnLeft2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnLeft2.UseVisualStyleBackColor = false;
            this.btnLeft2.Click += new System.EventHandler(this.btnLeftAns_click);
            // 
            // btnLeft1
            // 
            this.btnLeft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnLeft1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnLeft1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLeft1.BorderRadius = 10;
            this.btnLeft1.BorderSize = 0;
            this.btnLeft1.FlatAppearance.BorderSize = 0;
            this.btnLeft1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnLeft1.Location = new System.Drawing.Point(34, 20);
            this.btnLeft1.Name = "btnLeft1";
            this.btnLeft1.Size = new System.Drawing.Size(190, 47);
            this.btnLeft1.TabIndex = 0;
            this.btnLeft1.Text = "A";
            this.btnLeft1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnLeft1.UseVisualStyleBackColor = false;
            this.btnLeft1.Click += new System.EventHandler(this.btnLeftAns_click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 10;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnNext.Location = new System.Drawing.Point(415, 378);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(190, 47);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Tiếp theo";
            this.btnNext.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.btnReturn.TabIndex = 10;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormGame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rjPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame2";
            this.Text = "FormGame2";
            this.rjPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJPanel rjPanel1;
        private CustomControls.RJButton btnLeft4;
        private CustomControls.RJButton btnLeft3;
        private CustomControls.RJButton btnLeft2;
        private CustomControls.RJButton btnLeft1;
        private CustomControls.RJButton btnRight4;
        private CustomControls.RJButton btnRight3;
        private CustomControls.RJButton btnRight2;
        private CustomControls.RJButton btnRight1;
        private System.Windows.Forms.Timer timer1;
        private CustomControls.RJButton btnNext;
        private FontAwesome.Sharp.IconButton btnReturn;
    }
}