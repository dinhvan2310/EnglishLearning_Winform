using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLL.Components;

namespace BLL.Workflows
{
    public class DataManager
    {
        public DataEDictMananger DataEdictAccess;

        public DataManager()
        {
            DataEdictAccess = new DataEDictMananger();
        }

    }
}
