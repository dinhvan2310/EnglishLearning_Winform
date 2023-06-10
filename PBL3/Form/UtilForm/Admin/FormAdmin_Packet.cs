using BLL.Workflows;
using EFramework.Model;
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
            rjComboBox2.Items.AddRange(new BLL.Workflows.DataManager().PackageManager.GetAllUserPackage().ToArray());
            rjComboBox2.DisplayMember = "Name";
            rjComboBox2.SelectedIndex = 0;
            rjComboBox1.SelectedIndex = 0;

            ShowListAccount(SearchBy.None, ((UserPacket)(rjComboBox2.SelectedItem)).Name.ToString());
        }

        private void ShowListAccount(SearchBy searchBy, string packageName)
        {
            DataManager dataManager = new DataManager();
            try
            {
                switch (searchBy)
                {
                    case SearchBy.None:
                        {
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts()
                                .Where(p => new BLL.Workflows.DataManager().PackageManager.IsHasUserPacket(p.AccountID, packageName))
                                .Select(p => new
                                {
                                    p.AccountID,
                                    p.UserName,
                                    p.Name,
                                    p.UserPacketInfos.FirstOrDefault(pp => pp.UserPacket.Name == packageName).PacketID,
                                    p.UserPacketInfos.FirstOrDefault(pp => pp.UserPacket.Name == packageName).DueDate,
                                }).ToList();
                            break;
                        }

                    case SearchBy.ID:
                        {
                            int id = Convert.ToInt32(txtSearch.Text);
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts()
                                .Where(p => new BLL.Workflows.DataManager().PackageManager.IsHasUserPacket(p.AccountID, packageName) && p.AccountID == id)
                                .Select(p => new
                                {
                                    p.AccountID,
                                    p.UserName,
                                    p.Name,
                                    p.UserPacketInfos.FirstOrDefault(pp => pp.UserPacket.Name == packageName).PacketID,
                                    p.UserPacketInfos.FirstOrDefault(pp => pp.UserPacket.Name == packageName).DueDate,
                                }).ToList();
                            break;
                        }

                    case SearchBy.UserName:
                        {
                            string userName = txtSearch.Text;
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts()
                                .Where(p => new BLL.Workflows.DataManager().PackageManager.IsHasUserPacket(p.AccountID, packageName) && p.UserName == userName)
                                .Select(p => new
                                {
                                    p.AccountID,
                                    p.UserName,
                                    p.Name,
                                    p.UserPacketInfos.FirstOrDefault(pp => pp.UserPacket.Name == packageName).PacketID,
                                    p.UserPacketInfos.FirstOrDefault(pp => pp.UserPacket.Name == packageName).DueDate,
                                }).ToList();
                            break;
                        }

                    case SearchBy.Name:
                        {
                            string name = txtSearch.Text;
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts()
                                .Where(p => new BLL.Workflows.DataManager().PackageManager.IsHasUserPacket(p.AccountID, packageName) && p.Name.Contains(name))
                                .Select(p => new
                                {
                                    p.AccountID,
                                    p.UserName,
                                    p.Name,
                                    p.UserPacketInfos.FirstOrDefault(pp => pp.UserPacket.Name == packageName).PacketID,
                                    p.UserPacketInfos.FirstOrDefault(pp => pp.UserPacket.Name == packageName).DueDate,
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
                    if(dataManager.PackageManager.SetPricePacket(((UserPacket)(rjComboBox2.SelectedItem)).Name.ToString(), price))
                    {
                        FormMessageBox f = new FormMessageBox("Thông báo", "Thay đổi giá vé người dùng thành công", FormMessageBox.MessageType.Info);
                        f.StartPosition = FormStartPosition.CenterScreen;
                        f.Show();
                    }
                    else
                    {
                        FormMessageBox f = new FormMessageBox("Lỗi", "Có lỗi xảy ra", FormMessageBox.MessageType.Info);
                        f.StartPosition = FormStartPosition.CenterScreen;
                        f.Show();
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch(FormatException ex)
            {
                FormMessageBox f = new FormMessageBox("Vui lòng nhập lại", "Vui lòng nhập giá gói người dùng là số nguyên dương", FormMessageBox.MessageType.Info);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || placeholder.Any(i => i == txtSearch.Text))
            {
                ShowListAccount(SearchBy.None, ((UserPacket)(rjComboBox2.SelectedItem)).Name.ToString());
                setPlaceholder();
                return;
            }

            switch (rjComboBox1.SelectedItem.ToString())
            {
                case "ID":
                    {
                        ShowListAccount(SearchBy.ID, ((UserPacket)(rjComboBox2.SelectedItem)).Name.ToString());
                        break;
                    }

                case "UserName":
                    {
                        ShowListAccount(SearchBy.UserName, ((UserPacket)(rjComboBox2.SelectedItem)).Name.ToString());
                        break;
                    }

                case "Name":
                    {
                        ShowListAccount(SearchBy.Name, ((UserPacket)(rjComboBox2.SelectedItem)).Name.ToString());
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
