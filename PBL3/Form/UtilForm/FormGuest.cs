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
    public partial class FormGuest : Form
    {
        public FormGuest()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.LoginForm.Show();

            GlobalForm.MainForm.Hide();
        }
    }
}
