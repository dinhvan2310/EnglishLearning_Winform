using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormAdmin : Form
    {

        private Button _CurrentTag;
        private Form _CurrentChildForm;

        private Form AccountForm;
        private Form WordForm;
        private Form PacketForm;

        public FormAdmin()
        {
            InitializeComponent();

            AccountForm = new FormAdmin_Account();
            WordForm = new FormAdmin_Topic();
            PacketForm = new FormAdmin_Packet();


            ActiveTag(btnAccount);
            OpenChildForm(AccountForm);
        }

        private void ActiveTag(Button tag)
        {
            if (_CurrentTag != null)
            {
                ResetTag();
            }

            _CurrentTag = tag;

            _CurrentTag.BackColor = Color.FromArgb(240, 237, 254);
            _CurrentTag.ForeColor = Color.FromArgb(48, 48, 87);
            _CurrentTag.Size = new Size(190, 60);
            _CurrentTag.Location = new Point(_CurrentTag.Location.X, _CurrentTag.Location.Y - 10);
            _CurrentTag.Enabled = false;
        }

        private void ResetTag()
        {
            _CurrentTag.BackColor = Color.FromArgb(44, 41, 74);
            _CurrentTag.ForeColor = Color.FromArgb(240, 237, 254);
            _CurrentTag.Size = new Size(190, 50);
            _CurrentTag.Enabled = true;
            _CurrentTag.Location = new Point(_CurrentTag.Location.X, _CurrentTag.Location.Y + 10);
        }

        public void OpenChildForm(Form childForm)
        {
            if (_CurrentChildForm != null)
            {
                _CurrentChildForm.Visible = false;
            }

            _CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelBase.Controls.Add(childForm);
            panelBase.Tag = childForm;
            childForm.SendToBack();
            childForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActiveTag((Button)sender);
            OpenChildForm(AccountForm);
        }


        private void btnWord_Click(object sender, EventArgs e)
        {
            ActiveTag((Button)sender);
            OpenChildForm(WordForm);

        }

        private void btnPacket_Click(object sender, EventArgs e)
        {
            ActiveTag((Button)sender);
            OpenChildForm(PacketForm);
        }
    }
}
