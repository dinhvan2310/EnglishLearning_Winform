namespace PBL3
{
    partial class FormGame1
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
            this.imgFlower = new CustomControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.iconCorrect = new FontAwesome.Sharp.IconButton();
            this.iconIncorrect = new FontAwesome.Sharp.IconButton();
            this.btnNext = new CustomControls.RJButton();
            this.btnAnsB = new CustomControls.RJButton();
            this.btnCheck = new CustomControls.RJButton();
            this.btnAnsA = new CustomControls.RJButton();
            this.btnAnsD = new CustomControls.RJButton();
            this.btnAnsC = new CustomControls.RJButton();
            this.rjButton2 = new CustomControls.RJButton();
            this.btnQuestion = new CustomControls.RJButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgFlower
            // 
            this.imgFlower.BackColor = System.Drawing.Color.Transparent;
            this.imgFlower.BackgroundColor = System.Drawing.Color.Transparent;
            this.imgFlower.BackgroundImage = global::PBL3.Properties.Resources.Flower_5;
            this.imgFlower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFlower.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.imgFlower.BorderRadius = 30;
            this.imgFlower.BorderSize = 0;
            this.imgFlower.FlatAppearance.BorderSize = 0;
            this.imgFlower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgFlower.ForeColor = System.Drawing.Color.White;
            this.imgFlower.Location = new System.Drawing.Point(753, 144);
            this.imgFlower.Name = "imgFlower";
            this.imgFlower.Size = new System.Drawing.Size(292, 328);
            this.imgFlower.TabIndex = 5;
            this.imgFlower.TextColor = System.Drawing.Color.White;
            this.imgFlower.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAnswer);
            this.panel1.Controls.Add(this.iconCorrect);
            this.panel1.Controls.Add(this.iconIncorrect);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnAnsB);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.btnAnsA);
            this.panel1.Controls.Add(this.btnAnsD);
            this.panel1.Controls.Add(this.btnAnsC);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Location = new System.Drawing.Point(12, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 351);
            this.panel1.TabIndex = 0;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.lblAnswer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.lblAnswer.Location = new System.Drawing.Point(117, 251);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(108, 21);
            this.lblAnswer.TabIndex = 10;
            this.lblAnswer.Text = "Đáp án đúng:";
            this.lblAnswer.Visible = false;
            // 
            // iconCorrect
            // 
            this.iconCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(184)))));
            this.iconCorrect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.iconCorrect.FlatAppearance.BorderSize = 0;
            this.iconCorrect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconCorrect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCorrect.ForeColor = System.Drawing.Color.Transparent;
            this.iconCorrect.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconCorrect.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(71)))));
            this.iconCorrect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCorrect.IconSize = 80;
            this.iconCorrect.Location = new System.Drawing.Point(43, 251);
            this.iconCorrect.Name = "iconCorrect";
            this.iconCorrect.Size = new System.Drawing.Size(68, 68);
            this.iconCorrect.TabIndex = 9;
            this.iconCorrect.UseVisualStyleBackColor = false;
            this.iconCorrect.Visible = false;
            // 
            // iconIncorrect
            // 
            this.iconIncorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.iconIncorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconIncorrect.FlatAppearance.BorderSize = 0;
            this.iconIncorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconIncorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.iconIncorrect.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconIncorrect.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.iconIncorrect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconIncorrect.IconSize = 80;
            this.iconIncorrect.Location = new System.Drawing.Point(43, 249);
            this.iconIncorrect.Name = "iconIncorrect";
            this.iconIncorrect.Size = new System.Drawing.Size(68, 68);
            this.iconIncorrect.TabIndex = 7;
            this.iconIncorrect.UseVisualStyleBackColor = false;
            this.iconIncorrect.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 30;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnNext.Location = new System.Drawing.Point(511, 242);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(155, 83);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Tiếp theo";
            this.btnNext.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAnsB
            // 
            this.btnAnsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnAnsB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnAnsB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnsB.BorderRadius = 30;
            this.btnAnsB.BorderSize = 0;
            this.btnAnsB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnsB.FlatAppearance.BorderSize = 0;
            this.btnAnsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsB.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnsB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnAnsB.Location = new System.Drawing.Point(357, 9);
            this.btnAnsB.Name = "btnAnsB";
            this.btnAnsB.Size = new System.Drawing.Size(322, 87);
            this.btnAnsB.TabIndex = 7;
            this.btnAnsB.Text = "B. Lionel Messi";
            this.btnAnsB.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnAnsB.UseVisualStyleBackColor = false;
            this.btnAnsB.Click += new System.EventHandler(this.btnAnswer_click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(88)))), ((int)(((byte)(134)))));
            this.btnCheck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(88)))), ((int)(((byte)(134)))));
            this.btnCheck.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCheck.BorderRadius = 30;
            this.btnCheck.BorderSize = 0;
            this.btnCheck.Enabled = false;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnCheck.Location = new System.Drawing.Point(511, 242);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(155, 83);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnAnsA
            // 
            this.btnAnsA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnAnsA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnAnsA.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnsA.BorderRadius = 30;
            this.btnAnsA.BorderSize = 0;
            this.btnAnsA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnsA.FlatAppearance.BorderSize = 0;
            this.btnAnsA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsA.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnsA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnAnsA.Location = new System.Drawing.Point(4, 7);
            this.btnAnsA.Name = "btnAnsA";
            this.btnAnsA.Size = new System.Drawing.Size(322, 87);
            this.btnAnsA.TabIndex = 6;
            this.btnAnsA.Text = "A. Neymar Jr";
            this.btnAnsA.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnAnsA.UseVisualStyleBackColor = false;
            this.btnAnsA.Click += new System.EventHandler(this.btnAnswer_click);
            // 
            // btnAnsD
            // 
            this.btnAnsD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnAnsD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnAnsD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnsD.BorderRadius = 30;
            this.btnAnsD.BorderSize = 0;
            this.btnAnsD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnsD.FlatAppearance.BorderSize = 0;
            this.btnAnsD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsD.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnsD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnAnsD.Location = new System.Drawing.Point(357, 117);
            this.btnAnsD.Name = "btnAnsD";
            this.btnAnsD.Size = new System.Drawing.Size(322, 87);
            this.btnAnsD.TabIndex = 9;
            this.btnAnsD.Text = "D. Cristiano Ronaldo";
            this.btnAnsD.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnAnsD.UseVisualStyleBackColor = false;
            this.btnAnsD.Click += new System.EventHandler(this.btnAnswer_click);
            // 
            // btnAnsC
            // 
            this.btnAnsC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnAnsC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btnAnsC.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnsC.BorderRadius = 30;
            this.btnAnsC.BorderSize = 0;
            this.btnAnsC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnsC.FlatAppearance.BorderSize = 0;
            this.btnAnsC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsC.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnsC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnAnsC.Location = new System.Drawing.Point(4, 117);
            this.btnAnsC.Name = "btnAnsC";
            this.btnAnsC.Size = new System.Drawing.Size(322, 87);
            this.btnAnsC.TabIndex = 8;
            this.btnAnsC.Text = "C. Kylian Mbappé";
            this.btnAnsC.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnAnsC.UseVisualStyleBackColor = false;
            this.btnAnsC.Click += new System.EventHandler(this.btnAnswer_click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjButton2.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderRadius = 30;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Enabled = false;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.rjButton2.Location = new System.Drawing.Point(16, 242);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(650, 83);
            this.rjButton2.TabIndex = 10;
            this.rjButton2.Text = "\r\n";
            this.rjButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // btnQuestion
            // 
            this.btnQuestion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQuestion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQuestion.BackgroundImage = global::PBL3.Properties.Resources.Theme4;
            this.btnQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuestion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuestion.BorderRadius = 35;
            this.btnQuestion.BorderSize = 0;
            this.btnQuestion.FlatAppearance.BorderSize = 0;
            this.btnQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestion.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.btnQuestion.Location = new System.Drawing.Point(51, 25);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(954, 89);
            this.btnQuestion.TabIndex = 6;
            this.btnQuestion.Text = "Who is the best football player in the world";
            this.btnQuestion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.btnQuestion.UseVisualStyleBackColor = false;
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
            this.btnReturn.Location = new System.Drawing.Point(5, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(40, 40);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormGame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.imgFlower);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame1";
            this.Text = "MC_GameForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJButton imgFlower;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJButton btnAnsB;
        private CustomControls.RJButton btnAnsA;
        private CustomControls.RJButton btnAnsD;
        private FontAwesome.Sharp.IconButton iconCorrect;
        private FontAwesome.Sharp.IconButton iconIncorrect;
        private CustomControls.RJButton btnNext;
        private CustomControls.RJButton btnAnsC;
        private CustomControls.RJButton btnCheck;
        private System.Windows.Forms.Label lblAnswer;
        private CustomControls.RJButton btnQuestion;
        private CustomControls.RJButton rjButton2;
        private FontAwesome.Sharp.IconButton btnReturn;
    }
}