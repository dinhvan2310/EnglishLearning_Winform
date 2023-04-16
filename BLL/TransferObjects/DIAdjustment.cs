using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.TransferObjects
{
    public class DIAdjustment
    {
        public int BalanceOffset { get; set; }
        public Int16 ConsecutiveValue { get; set; } // -1: not consecutive, 0: already login, 1: first login
    }
}
