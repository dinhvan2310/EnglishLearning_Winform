using CustomControls;
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
    public partial class FormNotebook : Form
    {
        public FormNotebook()
        {
            InitializeComponent();
        }

        #region HELPER FUNCTIONS
        #endregion

        #region EVENTS
        private void btnStatistic_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.SwitchForm(new FormStatistic(),
                FormType.Weak);
        }

        private void FormNotebook_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
                return;
        }

        #endregion
    }
}
