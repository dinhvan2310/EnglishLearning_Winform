using PBL3.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormTopic_List : Form
    {

        private string _Branch;
        public FormTopic_List(string branch)
        {
            InitializeComponent();

            _Branch = branch;

            SetupUI();
        }

        private void SetupUI()
        {
            lblBranch.Text = _Branch;
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            //GlobalForm.MainForm.OpenChildForm(FormStack.Pop(), FormStack.CurrentFormType == FormType.Strong
            //    ? FormType.Strong : FormType.Neutral);
        }
    }
}
