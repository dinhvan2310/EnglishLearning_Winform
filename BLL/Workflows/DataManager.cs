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
        public EDictionaryMananger EDictionaryManager { get; private set; }
        public VDictionaryManager VDictionaryManager { get; private set; }
        public AccountManager AccountManager { get; private set; }
        public PackageManager PackageManager { get; private set; }
        public NotebookManager NotebookManager { get; private set; }

        public DataManager()
        {
            EDictionaryManager = new EDictionaryMananger();
            VDictionaryManager = new VDictionaryManager();
            AccountManager = new AccountManager();
            PackageManager = new PackageManager();
            NotebookManager = new NotebookManager();
        }

    }
}
