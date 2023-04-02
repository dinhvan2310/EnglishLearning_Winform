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
    public partial class FormAdmin_Account_AddUpdate : Form
    {
        public FormAdmin_Account_AddUpdate()
        {
            InitializeComponent();
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
    }
}
