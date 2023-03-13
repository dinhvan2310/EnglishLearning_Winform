namespace PBL3
{
    partial class FormStatistic
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
            this.chart = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjPanel1 = new CustomControls.RJPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.chart.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.chart.Location = new System.Drawing.Point(20, 28);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(765, 303);
            this.chart.TabIndex = 0;
            this.chart.Text = "cartesianChart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(93, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thống Kê Quá Trình Học Tập";
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
            this.btnReturn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReturn_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.panel1.Location = new System.Drawing.Point(99, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 5);
            this.panel1.TabIndex = 22;
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.rjPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.Controls.Add(this.iconButton2);
            this.rjPanel1.Controls.Add(this.iconButton1);
            this.rjPanel1.Controls.Add(this.chart);
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.GradientAngle = 45F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjPanel1.Location = new System.Drawing.Point(99, 126);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(872, 331);
            this.rjPanel1.TabIndex = 23;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.DotCircle;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(791, 143);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 35);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.TabStop = false;
            this.iconButton1.Text = "Từ";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.DotCircle;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(791, 175);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 35);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.TabStop = false;
            this.iconButton2.Text = "Giờ";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStatistic";
            this.Text = "FormStatistic";
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            this.rjPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chart;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJPanel rjPanel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}