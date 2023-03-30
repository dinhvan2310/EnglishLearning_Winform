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
    public partial class FormAdmin_Account : Form
    {
        public FormAdmin_Account()
        {
            InitializeComponent();
        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.AdminForm.OpenChildForm(new FormAdmin_Account_AddUpdate());
        }
    }
}
