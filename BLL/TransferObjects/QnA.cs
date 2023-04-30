using EFramework.Model;
using MySql.Data.MySqlClient;
using PBLLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.TransferObjects
{
    public class QnA
    {
        public wn_word[] _Answers { get; set; }
        public wn_word _RightAnswer { get; set; }
        public string _Question { get; set; }
        public QnA() 
        {
            _Answers = new wn_word[4];
        }
        
    }
}
