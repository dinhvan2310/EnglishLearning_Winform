using CustomControls;
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
    public partial class FormNotebook : Form
    {
        private bool _pushMode = false;

        public FormNotebook()
        {
            InitializeComponent();
        }

        private void btnPushtoTop_MouseClick(object sender, MouseEventArgs e)
        {
            _pushMode = !_pushMode;
        }

        private void rjButton6_MouseClick(object sender, MouseEventArgs e)
        {
            if (_pushMode)
            {
                flowLayoutPanel1.Controls.SetChildIndex(sender as RJButton, 0);
            }
        }
    }
}
