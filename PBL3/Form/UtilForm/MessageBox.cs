using PBLLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace PBL3
{
    public partial class MessageBox : Form
    {
        public enum MessageType
        {
            Info, Option
        }

        public MessageBox(string subject, string message, MessageType type)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(ExternalImport.CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            lblSubject.Text = subject;
            lblMessage.Text = message;
            switch (type)
            {
                case MessageType.Option:
                    InitOptionBox();
                    break;
                case MessageType.Info:
                    InitInfoBox();
                    break;

            }
        }

        private void InitInfoBox()
        {
            int width = panelContainer.Size.Width;

            Button confirmBtn = GenerateButton("Xác Nhận", Color.FromArgb(0, 191, 159), width);
            confirmBtn.MouseClick += btnCancel_Click;
            confirmBtn.Dock = DockStyle.Left;

            panelContainer.Controls.Add(confirmBtn);

            lblMessage.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;

        }

        private void InitOptionBox()
        {
            int width = (int)Math.Ceiling(panelContainer.Size.Width / 2.0f);

            Button cancelBtn = GenerateButton("Thoát", Color.FromArgb(255, 108, 131), width);
            cancelBtn.MouseClick += btnCancel_Click;
            cancelBtn.Dock = DockStyle.Left;
            Button confirmBtn = GenerateButton("Xác Nhận", Color.FromArgb(0, 191, 159), width);
            confirmBtn.MouseClick += btnConfirm_Click;
            confirmBtn.Dock = DockStyle.Left;

            panelContainer.Controls.Add(confirmBtn);
            panelContainer.Controls.Add(cancelBtn);

            lblMessage.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
        }

        private Button GenerateButton(string name, Color color, int width)
        {
            Button btn = new Button();
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Text = name;
            btn.BackColor = color;
            btn.ForeColor = ColorConfig.DarkTextColor;
            btn.Size = new Size(width, 53);
            btn.Font = new Font("Bahnschrift", 13.8f, FontStyle.Bold);

            return btn;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            ExternalImport.ReleaseCapture();
            ExternalImport.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
