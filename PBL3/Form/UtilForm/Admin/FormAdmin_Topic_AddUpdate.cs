using BLL.EnityFramework.Model;
using BLL.TransferObjects;
using BLL.Workflows;
using EFramework.Model;
using Library;
using Microsoft.Win32;
using PBL3.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormAdmin_Topic_AddUpdate : Form
    {

        public delegate void Func();
        public event Func Callback;

        private int _TopicID;

        private int _LastSelectedRow = -1;

        public FormAdmin_Topic_AddUpdate(int topicID = -1)
        {
            InitializeComponent();

            _TopicID = topicID;

            SetupForm();
            SetupUI();
        }

        #region HELPER FUNCTIONS

        private void SetupUI()
        {
            if (_TopicID != -1)
            {
                DataManager dm = new DataManager();
                Topic topic = dm.EDictionaryManager.GetTopic_ByTopicID(_TopicID);
                txtTopic.Text = topic.TopicName.Replace('_', ' ');

                dm.EDictionaryManager.GetBranch_ByTopicID(_TopicID).ForEach(item => {
                    dataGridView1.Rows.Add(item.SynsetID, item.BranchName);
                });

                using (MemoryStream ms = new MemoryStream(topic.Background))
                {
                    btnDemo.BackgroundImage = Image.FromStream(ms);
                }

                btnAdd.Text = "Sửa";
            }
            else
            {
                btnDemo.BackgroundImage = Resources.Empty;
            }    
        }

        private void SetupForm()
        {
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Synset ID";
            column.DataPropertyName = "synset_id";
            column.ValueType = typeof(int);
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Name = "Tên nhánh";
            column.DataPropertyName = "branch_name";
            column.Width = 250;
            column.ValueType = typeof(string);
            dataGridView1.Columns.Add(column);

        }

        private void UpdateSelectedRow(int synsetID)
        {
            dataGridView1.Rows[_LastSelectedRow].Cells["Synset ID"].Value = synsetID;
        }

        private bool ValidateForm()
        {
            if (txtTopic.Text == "Untitled")
                return false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Tên nhánh"].Value.ToString() == "-row-")
                {
                    return false;
                }
            }

            return true;
        }

        private List<Branch> GetBranches()
        {
            List<Branch> branches = new List<Branch>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                branches.Add(new Branch()
                {
                    SynsetID = Convert.ToDecimal(row.Cells["Synset ID"].Value),
                    BranchName = row.Cells["Tên nhánh"].Value.ToString()
                });
            }

            return branches;
        }

        #endregion

        #region EVENTS
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            fileDialog.Title = "Select an Image";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = fileDialog.FileName;
                btnDemo.BackgroundImage = Image.FromFile(selectedFileName);
            }
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(0, "-row-");
        }

        private void btnDelBranch_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            FormMessageBox form = new FormMessageBox("Xác nhận", "Bạn có muốn xoá không", FormMessageBox.MessageType.Option);
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                    dataGridView1.Rows.Remove(r);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                Form form = new FormMessageBox(
                    "Không hợp lệ",
                    "Chưa đổi tên chủ đề hoặc nhánh",
                    FormMessageBox.MessageType.Info);
                form.ShowDialog();

                return;
            }

            Form mForm;
            DataManager dm = new DataManager();
            List<Branch> branches = GetBranches();

            Topic topic = new Topic()
            {
                TopicName = txtTopic.Text.Replace(' ', '_'),
                Branches = branches,
                Background = (byte[])new ImageConverter().ConvertTo((btnDemo.BackgroundImage), typeof(byte[]))
            };

            if (_TopicID == -1)  // add
            {
                try
                {
                    dm.EDictionaryManager.AddTopic(topic);
                }
                catch
                {
                    mForm = new FormMessageBox("Không hợp lệ", "Kích thước ảnh quá lớn",
                        FormMessageBox.MessageType.Info);
                    mForm.ShowDialog();

                    return;
                }
                mForm = new FormMessageBox("Thông báo", "Thêm thành công", FormMessageBox.MessageType.Info);
                mForm.ShowDialog();
            }
            else // edit
            {
                branches.ForEach(p => p.TopicID = _TopicID);

                try
                {
                    topic.TopicID = _TopicID;
                    dm.EDictionaryManager.UpdateTopic(topic);
                }
                catch
                {
                    mForm = new FormMessageBox("Không hợp lệ", "Kích thước ảnh quá lớn",
                        FormMessageBox.MessageType.Info);
                    mForm.ShowDialog();

                    return;
                }
                Form form = new FormMessageBox("Thông báo", "Sửa thành công", FormMessageBox.MessageType.Info);
                form.ShowDialog();
            }

            Callback();
            this.Dispose();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dataGridView1.Rows[e.RowIndex].Cells["Tên nhánh"].Value == null)
            {
                dataGridView1.Rows[e.RowIndex].Cells["Tên nhánh"].Value = "-row-";
                return;
            }

            DataManager dm = new DataManager();
            if (dm.EDictionaryManager.GetSynset_ByWord(
                dataGridView1.Rows[e.RowIndex].Cells["Tên nhánh"].Value.ToString()).Count == 0)
                // Not corresding with word database
            {
                Form form = new FormMessageBox("Không hợp lệ",
                    "Tên nhánh không khớp với hệ thống",
                    FormMessageBox.MessageType.Info);

                dataGridView1.Rows[e.RowIndex].Cells["Tên nhánh"].Value = "-row-";

                form.ShowDialog();
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows) // Duplicate
                {
                    if (row == dataGridView1.Rows[e.RowIndex])
                        continue;

                    if (dataGridView1.Rows[e.RowIndex].Cells["Tên nhánh"].Value.ToString()
                        == row.Cells["Tên nhánh"].Value.ToString())
                    {
                        Form formm = new FormMessageBox("Không hợp lệ",
                            "Tên nhánh bị trùng",
                            FormMessageBox.MessageType.Info);

                        dataGridView1.Rows[e.RowIndex].Cells["Tên nhánh"].Value = "-row-";
                        formm.ShowDialog();

                        return;
                    }    
                }    

                _LastSelectedRow = e.RowIndex;

                FormAdmin_Topic_BranchDetail form = new FormAdmin_Topic_BranchDetail(
                    dataGridView1.Rows[e.RowIndex].Cells["Tên nhánh"].Value.ToString());
                form.Callback += UpdateSelectedRow;
                form.ShowDialog();
            }
        }

        private void txtTopic_Leave(object sender, EventArgs e)
        {
            DataManager dm = new DataManager();
            if (dm.EDictionaryManager.CheckTopicNameIsExist(txtTopic.Text.Replace(' ', '_')))
            {
                Form message = new FormMessageBox("Không hợp lệ", "Tên chủ đề đã tồn tại",
                    FormMessageBox.MessageType.Info);

                message.ShowDialog();

                txtTopic.Text = "Untitled";

            }

        }

        #endregion

    }
}
