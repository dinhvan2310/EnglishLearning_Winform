using BLL.TransferObjects;
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
            dm.EDictionaryManager.GetTopicName_All().ForEach(item =>
            {
                dataGridView1.Rows.Add(item);
            });

            if (dataGridView1.Rows.Count > 0)
            {
                btnDemo.BackgroundImage = (Image)Properties.Resources.ResourceManager
                    .GetObject(dataGridView1.Rows[0].Cells[0].Value.ToString());

                lblTopic.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            }
        }

        private void SetupForm()
        {
            dataGridView1.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Tên chủ đề";
            column.Width = 450;
            column.ValueType = typeof(string);

            dataGridView1.Columns.Add(column);
        }
        #endregion

        #region EVENTS
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDemo.BackgroundImage = (Image)Properties.Resources.ResourceManager
                .GetObject(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Replace(' ', '_'));

            lblTopic.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        #endregion
    }
}
