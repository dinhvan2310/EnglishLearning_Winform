using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.TransferObjects
{
    public class LearningStats
    {
        public List<int> TimeStats { get; set; }
        public List<int> WordStats { get; set; }

        public LearningStats()
        {
            TimeStats = new List<int>();
            WordStats = new List<int>();
        }
    }
}
