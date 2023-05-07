using BLL.TransferObjects;
using BLL.Workflows;
using EFramework.Model;
using Library;
using PBL3.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormAdmin_Topic : Form
    {
        public FormAdmin_Topic()
        {
            InitializeComponent();

            SetupForm();
            SetupUI();
        }

        #region HELPER FUNCTIONS
        private void SetupUI()
        {
            DataManager dm = new DataManager();
            dataGridView1.DataSource = dm.EDictionaryManager.GetTopic_All();

            if (dataGridView1.Rows.Count > 0)
            {
                lblTopic.Text = dataGridView1.Rows[0].Cells["Tên chủ đề"].Value.ToString();

                Topic topic = dm.EDictionaryManager.GetTopic_ByTopicID(
                    Convert.ToInt32(dataGridView1.Rows[0].Cells["ID"].Value));

                using (MemoryStream ms = new MemoryStream(topic.Background))
                {
                    btnDemo.BackgroundImage = Image.FromStream(ms);
                }
            }
        }

        private void SetupForm()
        {
            dataGridView1.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Tên chủ đề";
            column.DataPropertyName = "TopicName";
            column.Width = 450;
            column.ValueType = typeof(string);
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Name = "ID";
            column.DataPropertyName = "TopicID";
            column.Visible = false;
            column.ValueType = typeof(int);
            dataGridView1.Columns.Add(column);
        }

        private void UpdateDataGridView()
        {
            DataManager dm = new DataManager();
            dataGridView1.DataSource = dm.EDictionaryManager.GetTopic_All();

            Topic topic = dm.EDictionaryManager.GetTopic_ByTopicID(
            Convert.ToInt32(dataGridView1.Rows[0].Cells["ID"].Value));
            UpdateTopicBackground(topic);
        }

        private void UpdateTopicBackground(Topic topic)
        {

            using (MemoryStream ms = new MemoryStream(topic.Background))
            {
                btnDemo.BackgroundImage = Image.FromStream(ms);
            }
        }

        #endregion

        #region EVENTS
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            lblTopic.Text = dataGridView1.Rows[e.RowIndex].Cells["Tên chủ đề"].Value.ToString();

            DataManager dm = new DataManager();
            Topic topic = dm.EDictionaryManager.GetTopic_ByTopicID(
                        Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value));
            UpdateTopicBackground(topic);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdmin_Topic_AddUpdate form = new FormAdmin_Topic_AddUpdate();
            form.Callback += UpdateDataGridView;
            form.Callback += ((FormTopic)GlobalForm.MainForm.TopicForm).UpdateTopicBtn;
            form.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;

            FormAdmin_Topic_AddUpdate form = new FormAdmin_Topic_AddUpdate(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value));
            form.Callback += UpdateDataGridView;
            form.Callback += ((FormTopic)GlobalForm.MainForm.TopicForm).UpdateTopicBtn;
            form.ShowDialog();
        }

        private void FormAdmin_Topic_MouseDown(object sender, MouseEventArgs e)
        {
            ExternalImport.ReleaseCapture();
            ExternalImport.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataManager dm = new DataManager();
            dataGridView1.DataSource = dm.EDictionaryManager.GetTopic_ByFilter(
                txtSearch.Text.Replace(' ', '_') + "%");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            Form message = new FormMessageBox("Xác nhận", "Bạn có muốn xoá không?", FormMessageBox.MessageType.Option);
            if (message.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            DataManager dm = new DataManager();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dm.EDictionaryManager.DeleteTopic(Convert.ToInt32(row.Cells["ID"].Value));
            }

            UpdateDataGridView();

            message = new FormMessageBox("Thông báo", "Xoá thành công", FormMessageBox.MessageType.Info);
            message.ShowDialog();
        }

        #endregion

    }
}
