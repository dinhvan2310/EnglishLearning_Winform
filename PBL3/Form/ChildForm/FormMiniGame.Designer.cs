using CustomControls;
namespace PBL3
{
    partial class FormMiniGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMiniGame));
            this.rjButton1 = new CustomControls.RJButton();
            this.panelBase = new System.Windows.Forms.Panel();
            this.btnStartGame2 = new CustomControls.RJButton();
            this.rjButton3 = new CustomControls.RJButton();
            this.rjButton2 = new CustomControls.RJButton();
            this.panelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Goldenrod;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold);
            this.rjButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.rjButton1.Location = new System.Drawing.Point(115, 396);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "PLAY";
            this.rjButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.btnStartGame2);
            this.panelBase.Controls.Add(this.rjButton3);
            this.panelBase.Controls.Add(this.rjButton1);
            this.panelBase.Controls.Add(this.rjButton2);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBase.Location = new System.Drawing.Point(0, 0);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1057, 496);
            this.panelBase.TabIndex = 15;
            // 
            // btnStartGame2
            // 
            this.btnStartGame2.BackColor = System.Drawing.Color.Goldenrod;
            this.btnStartGame2.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btnStartGame2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStartGame2.BorderRadius = 20;
            this.btnStartGame2.BorderSize = 0;
            this.btnStartGame2.FlatAppearance.BorderSize = 0;
            this.btnStartGame2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnStartGame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnStartGame2.Location = new System.Drawing.Point(369, 396);
            this.btnStartGame2.Name = "btnStartGame2";
            this.btnStartGame2.Size = new System.Drawing.Size(150, 40);
            this.btnStartGame2.TabIndex = 15;
            this.btnStartGame2.Text = "PLAY";
            this.btnStartGame2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.btnStartGame2.UseVisualStyleBackColor = false;
            this.btnStartGame2.Click += new System.EventHandler(this.btnStartGame2_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton3.BackgroundImage")));
            this.rjButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(337, 79);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(204, 343);
            this.rjButton3.TabIndex = 16;
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundImage = global::PBL3.Properties.Resources.Flower_;
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(87, 79);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(204, 343);
            this.rjButton2.TabIndex = 0;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // FormMiniGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.ControlBox = false;
            this.Controls.Add(this.panelBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FormMiniGame";
            this.Text = "MG_Form";
            this.panelBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private CustomControls.RJButton rjButton1;
        private System.Windows.Forms.Panel panelBase;
        private RJButton btnStartGame2;
        private RJButton rjButton3;
        private RJButton rjButton2;
    }
}