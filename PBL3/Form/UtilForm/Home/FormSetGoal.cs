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
    public partial class FormSetGoal : Form
    {
        public delegate void Func(int goal);
        public event Func Callback;

        private int _CurrentIndex = 2;
        public FormSetGoal()
        {
            InitializeComponent();

            ((Button)flowPanel.Controls[_CurrentIndex]).BackColor = Color.FromArgb(97, 110, 254);
        }

        #region EVENTS

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.GoBack();
        }

        private void btn5Min_MouseClick(object sender, MouseEventArgs e)
        {
            ((Button)flowPanel.Controls[_CurrentIndex]).BackColor = Color.FromArgb(240, 237, 254);

            _CurrentIndex = flowPanel.Controls.GetChildIndex((Control)sender);
            ((Button)flowPanel.Controls[_CurrentIndex]).BackColor = Color.FromArgb(97, 110, 254);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Button b = (Button)flowPanel.Controls[_CurrentIndex];
            Callback(Convert.ToInt32(b.Text.Substring(0, 3).Trim()));

            GlobalForm.MainForm.GoBack();
        }

        #endregion
    }
}
