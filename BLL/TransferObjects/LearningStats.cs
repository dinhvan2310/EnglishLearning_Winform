using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.TransferObjects
{
    public class LearningStats
    {
        public List<Stat> Stats = new List<Stat>();
    }

    public class Stat
    {
        public int TimeAmount { get; set; }
        public int WordCount { get; set; }
    }
}
