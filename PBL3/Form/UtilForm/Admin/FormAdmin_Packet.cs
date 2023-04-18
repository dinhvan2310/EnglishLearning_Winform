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
            Packet,
            Time
        };

        public FormAdmin_Packet()
        {
            InitializeComponent();
            SetUpUI();
        }

        private void SetUpUI()
        {
            /*ShowListAccount(SearchBy.None);*/

            rjComboBox1.SelectedIndex = 0;
        }

        /*private void ShowListAccount(SearchBy searchBy)
        {
            DataManager dataManager = new DataManager();
            try
            {
                switch (searchBy)
                {
                    case SearchBy.None:
                        {
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
                            }).ToList();
                            break;
                        }

                    case SearchBy.ID:
                        {
                            int id = Convert.ToInt32(txtSearch.Text);
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.AccountID == id).Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
                            }).ToList();
                            break;
                        }

                    case SearchBy.UserName:
                        {
                            string userName = txtSearch.Text;
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.UserName == userName).Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
                            }).ToList();
                            break;
                        }

                    case SearchBy.Name:
                        {
                            string name = txtSearch.Text;
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.Name.Contains(name)).Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
                            }).ToList();
                            break;
                        }

                    case SearchBy.BirthDate:
                        {
                            DateTime birthDate = Convert.ToDateTime(txtSearch.Text);
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.BirthDate == birthDate).Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
                            }).ToList();
                            break;
                        }

                    case SearchBy.Email:
                        {
                            string email = txtSearch.Text;
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.Email == email).Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
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
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataManager dataManager = new DataManager();
                int price = Convert.ToInt32(txtPrice.Text);
                dataManager.PackageManager.SetPricePacket("Premium", price);
                new FormMessageBox("Thông báo", "Thay đổi giá vé người dùng thành công", FormMessageBox.MessageType.Info).Show();
            }
            catch(Exception ex)
            {
                new FormMessageBox("Lỗi", "Vui lòng nhập giá gói người dùng là số nguyên", FormMessageBox.MessageType.Info).Show();
            }

        }
    }
}
