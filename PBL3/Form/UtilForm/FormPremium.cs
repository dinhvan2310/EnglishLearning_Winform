using BLL.Workflows;
using EFramework.Model;
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
        private UserPacket _Packet;

        public FormPremium()
        {
            InitializeComponent();

            SetupForm();
            SetupUI();
        }

        private void SetupUI()
        {
            btnBuy.Text = _Packet.Price.ToString();
        }

        private void SetupForm()
        {
            this.Region = System.Drawing.Region.FromHrgn(ExternalImport.CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            DataManager dm = new DataManager();
            _Packet = dm.PackageManager.GetPacket_ByName("Premium");
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

        private void btnBuy_MouseClick(object sender, MouseEventArgs e)
        {
            if (LoginWorkflow.Instance.IsLoggedIn())
            {

            }
            else
            {
                FormMessageBox form = new FormMessageBox("Chưa đăng nhập", "Vui lòng đăng nhập để có thể xem thêm",
                    FormMessageBox.MessageType.Info);

                form.ShowDialog();
            }
        }
    }
}
