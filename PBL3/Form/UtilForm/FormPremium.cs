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
        public event EventHandler SetupUI_MainForm;

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
            DataManager dataManager = new DataManager();
            if (LoginWorkflow.Instance.IsLoggedIn())
            {
                int userID = LoginWorkflow.Instance.GetAccount().AccountID;
                if (dataManager.PackageManager.IsHasUserPacket(userID, "Premium"))
                {
                    FormMessageBox form = new FormMessageBox("Thông báo", $"Bạn đã sỡ hữu gói dịch vụ này, hạn sử dụng đến {dataManager.PackageManager.GetUserPacketInfo(userID, "Premium").DueDate}",
                    FormMessageBox.MessageType.Info);

                    form.ShowDialog();
                    return;
                }
                
                if(dataManager.PackageManager.BuyUserPacket(userID, "Premium"))
                {
                    FormMessageBox form = new FormMessageBox("Thông báo", "Giao dịch thành công",
                    FormMessageBox.MessageType.Info);
                    form.ShowDialog();
                    if(SetupUI_MainForm != null)
                    {
                        SetupUI_MainForm(this, new EventArgs());
                    }
                }
                else
                {
                    FormMessageBox form = new FormMessageBox("Lỗi", "Coin của bạn không đủ để thực hiện giao dịch này",
                    FormMessageBox.MessageType.Info);

                    form.ShowDialog();
                }
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
