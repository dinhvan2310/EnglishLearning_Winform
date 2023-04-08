using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLL.Components;
using EFramework;

namespace BLL.Workflows
{
    public class DataManager
    {
        public EDictionaryMananger EDictionaryManager;

        public DataManager()
        {
            EDictionaryManager = new EDictionaryMananger();
        }

    }
}
