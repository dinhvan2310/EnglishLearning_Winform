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

        private Button _currentTag;
        private Form _currentChildForm;

        public FormAdmin_Account AccountForm { get; private set; }
        public FormAdmin_Word WordForm { get; private set; }
        public FormAdmin_Packet PacketForm { get; private set; }

        public FormAdmin()
        {
            InitializeComponent();

            AccountForm = new FormAdmin_Account();
            WordForm = new FormAdmin_Word();
            PacketForm = new FormAdmin_Packet();


            ActiveTag(btnAccount);
            OpenChildForm(AccountForm);
        }

        private void ActiveTag(Button tag)
        {
            if (_currentTag != null)
            {
                ResetTag();
            }

            _currentTag = tag;

            _currentTag.BackColor = Color.FromArgb(240, 237, 254);
            _currentTag.ForeColor = Color.FromArgb(48, 48, 87);
            _currentTag.Size = new Size(190, 60);
            _currentTag.Location = new Point(_currentTag.Location.X, _currentTag.Location.Y - 10);
            _currentTag.Enabled = false;
        }

        private void ResetTag()
        {
            _currentTag.BackColor = Color.FromArgb(44, 41, 74);
            _currentTag.ForeColor = Color.FromArgb(240, 237, 254);
            _currentTag.Size = new Size(190, 50);
            _currentTag.Enabled = true;
            _currentTag.Location = new Point(_currentTag.Location.X, _currentTag.Location.Y + 10);
        }

        public void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
            {
                _currentChildForm.Visible = false;
            }

            _currentChildForm = childForm;
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
