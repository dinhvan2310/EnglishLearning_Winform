using PBL3.Utilities;
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
    public partial class FormAdmin_Account_Add : Form
    {
        public FormAdmin_Account_Add()
        {
            InitializeComponent();

            this.Region = System.Drawing.Region.FromHrgn(ExternalImport.CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            // Reduce Flicker
            this.DoubleBuffered = true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            FormAdmin baseForm = (FormAdmin)Application.OpenForms["FormAdmin"];
            (baseForm).OpenChildForm(baseForm.AccountForm);
        }

        private void FormAdmin_Account_Add_MouseDown(object sender, MouseEventArgs e)
        {
            ExternalImport.ReleaseCapture();
            ExternalImport.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
