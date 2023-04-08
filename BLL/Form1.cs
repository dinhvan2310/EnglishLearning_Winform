using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EFramework;
using EFramework.Model;
using BLL.Workflows;
using System.Text.RegularExpressions;
using BLL.Components;

namespace BLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*using (var dbContext = new Model1())
            {
                *//*var li = dbContext.wn_synset.Where(p => p.synset_id == 100001740).FirstOrDefault();
                List<wn_synset> list = new List<wn_synset>();
                dbContext.Entry(li).Collection(p => p.wn_synset12).Load();
                list = li.wn_synset12.ToList();

                

                dataGridView1.DataSource = list;



                textBox1.Text = list.Count.ToString();*/

            /*var results = (from i in dbContext.wn_word
                       where i.word.Contains("Ru")
                       select new WordModel() {Word = i.word}
                       ).Distinct().Take(10).ToList();*//*

            dataGridView1.DataSource = dbContext.wn_word.ToList();
        }*/
            DataManager dm = new DataManager();
            dataGridView1.DataSource = dm.EDictionaryManager.GetWord_ByFilter("ru", 10, true);

            string pattern = @"^[0-9]{1,2}\/[0-9]{1,2}\/[0-9]{4}$";
            string input = "23/10/2003";
            if (Regex.IsMatch(input, pattern))
            {
                textBox1.Text = "true";
            }
        }
    }
}
