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
        public FormNotebook()
        {
            InitializeComponent();
        }

        private void btnStatistic_MouseClick(object sender, MouseEventArgs e)
        {
            ((MainForm)Application.OpenForms["MainForm"]).OpenChildForm(new FormStatistic(),
                FormStack.FormType.Neutral);
        }
    }
}
