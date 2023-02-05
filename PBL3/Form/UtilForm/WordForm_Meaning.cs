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
    public partial class WordForm_Meaning : Form
    {
        public WordForm_Meaning(string word)
        {
            InitializeComponent();

            lblWord.Text = word;
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (btnFavorite.IconFont == FontAwesome.Sharp.IconFont.Regular)
            {
                btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
            else
            {
                btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Regular;
            }
        }

        private void WordForm_Meaning_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Hello");
        }
    }
}
