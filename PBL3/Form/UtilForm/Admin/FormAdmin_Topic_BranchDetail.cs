using BLL.TransferObjects;
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
    public partial class FormAdmin_Topic_BranchDetail : Form
    {
        public delegate void Func(int synsetID);
        public event Func Callback;

        private List<wn_synset> _Synsets;
        private string _Word;

        public FormAdmin_Topic_BranchDetail(string word)
        {
            InitializeComponent();

            _Word = word;

            SetupForm();
            SetupUI();
        }

        #region HELPER FUNCTIONS
        private void SetupUI()
        {
            dataGridView1.DataSource = _Synsets;
        }

        private void SetupForm()
        {
            dataGridView1.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Nghĩa";
            column.DataPropertyName = "definition";
            column.Width = 550;
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.Name = "synset_id";
            column.DataPropertyName = "synset_id";
            column.Visible = true;
            dataGridView1.Columns.Add(column);

            DataManager dm = new DataManager();
            _Synsets = dm.EDictionaryManager.GetSynset_ByWord(_Word.Replace(' ', '_'));
        }

        #endregion

        #region EVENTS
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Callback(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["synset_id"].Value));
            this.Dispose();
        }

        #endregion

    }
}
