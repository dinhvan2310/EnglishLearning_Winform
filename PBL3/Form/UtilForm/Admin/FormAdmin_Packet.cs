using BLL.Workflows;
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
    public partial class FormAdmin_Packet : Form
    {

        private enum SearchBy
        {
            None,
            ID,
            UserName,
            Name,
        };

        private string[] placeholder =
        {
            "ID: 1",
            "UserName: phuongthao1204",
            "Name: Phương Thảo",
        };

        public FormAdmin_Packet()
        {
            InitializeComponent();
            SetUpUI();

        }

        private void SetUpUI()
        {
            ShowListAccount(SearchBy.None);

            rjComboBox1.SelectedIndex = 0;
        }

        private void ShowListAccount(SearchBy searchBy)
        {
            DataManager dataManager = new DataManager();
            try
            {
                switch (searchBy)
                {
                    case SearchBy.None:
                        {
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Join(dataManager.AccountManager.GetUserPacketInfo_All_ByNamePacket("Premium"),
                                a => a.AccountID, p => p.AccountID, (a, p) =>
                                {
                                    return new
                                    {
                                        a.AccountID, a.UserName, a.Name, p.PacketID, p.DueDate
                                    };
                                }).ToList();
                            break;
                        }

                    case SearchBy.ID:
                        {
                            int id = Convert.ToInt32(txtSearch.Text);
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.AccountID == id).Join(dataManager.AccountManager.GetUserPacketInfo_All_ByNamePacket("Premium"),
                                a => a.AccountID, p => p.AccountID, (a, p) =>
                                {
                                    return new
                                    {
                                        a.AccountID, a.UserName, a.Name, p.PacketID, p.DueDate
                                    };
                                }).ToList();
                            break;
                        }

                    case SearchBy.UserName:
                        {
                            string userName = txtSearch.Text;
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.UserName == userName).Join(dataManager.AccountManager.GetUserPacketInfo_All_ByNamePacket("Premium"),
                                a => a.AccountID, p => p.AccountID, (a, p) =>
                                {
                                    return new
                                    {
                                        a.AccountID, a.UserName, a.Name, p.PacketID, p.DueDate
                                    };
                                }).ToList();
                            break;
                        }

                    case SearchBy.Name:
                        {
                            string name = txtSearch.Text;
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.Name.Contains(name)).Join(dataManager.AccountManager.GetUserPacketInfo_All_ByNamePacket("Premium"),
                                a => a.AccountID, p => p.AccountID, (a, p) =>
                                {
                                    return new
                                    {
                                        a.AccountID, a.UserName, a.Name, p.PacketID, p.DueDate
                                    };
                                }).ToList();
                            break;
                        }


                }
            }
            catch (Exception ex)
            {
                FormMessageBox f = new FormMessageBox("Vui lòng nhập lại", "Định dạng thông tin nhập không  hợp lệ", FormMessageBox.MessageType.Info);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataManager dataManager = new DataManager();
                int price = Convert.ToInt32(txtPrice.Text);
                if(price > 0)
                {
                    dataManager.PackageManager.SetPricePacket("Premium", price);
                    new FormMessageBox("Thông báo", "Thay đổi giá vé người dùng thành công", FormMessageBox.MessageType.Info).Show();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                new FormMessageBox("Lỗi", "Vui lòng nhập giá gói người dùng là số nguyên", FormMessageBox.MessageType.Info).Show();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || placeholder.Any(i => i == txtSearch.Text))
            {
                ShowListAccount(SearchBy.None);
                return;
            }

            switch (rjComboBox1.SelectedItem.ToString())
            {
                case "ID":
                    {
                        ShowListAccount(SearchBy.ID);
                        break;
                    }

                case "UserName":
                    {
                        ShowListAccount(SearchBy.UserName);
                        break;
                    }

                case "Name":
                    {
                        ShowListAccount(SearchBy.Name);
                        break;
                    }
            }
        }

        private void setPlaceholder()
        {
            txtSearch.ForeColor = Color.FromArgb(119, 112, 156);
            txtSearch.Text = placeholder[rjComboBox1.SelectedIndex];
        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            setPlaceholder();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(!placeholder.Any(i => i == txtSearch.Text))
            {
                return;
            }
            txtSearch.ForeColor = Color.White;
            txtSearch.Text = "";
        }


    }
}
