using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.TransferObjects
{
    public class SynsetModel
    {
        public decimal ID { get; set; }
        public string Definition { get; set; }
        public List<WordModel> Words { get; set; }

        public SynsetModel() { }

        public SynsetModel(int iD, string definition, List<WordModel> words)
        {
            ID = iD;
            Definition = definition;
            Words = words;
        }

        
    }
}
