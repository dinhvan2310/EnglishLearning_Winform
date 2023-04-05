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
    public partial class FormPremium : Form
    {
        public FormPremium()
        {
            InitializeComponent();

            this.Region = System.Drawing.Region.FromHrgn(ExternalImport.CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void FormPremium_MouseMove(object sender, MouseEventArgs e)
        {
            ExternalImport.ReleaseCapture();
            ExternalImport.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
