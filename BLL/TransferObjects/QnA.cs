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
        public int RightAnswerIndex { get; set; }
        public List<string> Answers { get; set; } = new List<string>();
        public string Question { get; set; }
        
    }
}
