namespace PBL3
{
    partial class WordForm_Grammar
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
            this.panelFrames = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDeriveds = new System.Windows.Forms.FlowLayoutPanel();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelFrames
            // 
            this.panelFrames.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelFrames.Location = new System.Drawing.Point(529, 131);
            this.panelFrames.Name = "panelFrames";
            this.panelFrames.Size = new System.Drawing.Size(407, 279);
            this.panelFrames.TabIndex = 9;
            // 
            // panelDeriveds
            // 
            this.panelDeriveds.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelDeriveds.Location = new System.Drawing.Point(64, 131);
            this.panelDeriveds.Name = "panelDeriveds";
            this.panelDeriveds.Size = new System.Drawing.Size(407, 279);
            this.panelDeriveds.TabIndex = 10;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblType.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.lblType.Location = new System.Drawing.Point(58, 69);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(255, 34);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "TỪ VỰNG CÙNG HỌ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(523, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "CÚ PHÁP";
            // 
            // WordForm_Grammar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1005, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.panelDeriveds);
            this.Controls.Add(this.panelFrames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WordForm_Grammar";
            this.Text = "WordForm_Grammar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelFrames;
        private System.Windows.Forms.FlowLayoutPanel panelDeriveds;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
    }
}