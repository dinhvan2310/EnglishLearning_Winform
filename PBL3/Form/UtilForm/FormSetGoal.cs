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
    public partial class FormSetGoal : Form
    {
        private int _CurrentIndex = 2;
        public FormSetGoal()
        {
            InitializeComponent();

            ((Button)flowPanel.Controls[_CurrentIndex]).BackColor = Color.FromArgb(97, 110, 254);
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.OpenChildForm(FormStack.Pop(), FormStack.FormType.Strong);
        }

        private void btn5Min_MouseClick(object sender, MouseEventArgs e)
        {
            ((Button)flowPanel.Controls[_CurrentIndex]).BackColor = Color.FromArgb(240, 237, 254);

            _CurrentIndex = flowPanel.Controls.GetChildIndex((Control)sender);
            ((Button)flowPanel.Controls[_CurrentIndex]).BackColor = Color.FromArgb(97, 110, 254);
        }
    }
}
