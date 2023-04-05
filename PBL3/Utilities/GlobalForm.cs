using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Utilities
{
    internal static class GlobalForm
    {
        private static FormAdmin _AdminForm;
        private static MainForm _MainForm;

        public static FormAdmin AdminForm
        {
            get
            {
                if (_AdminForm == null)
                    _AdminForm = (FormAdmin)Application.OpenForms["FormAdmin"];
                return _AdminForm;
            }
            private set { }
        }

        public static MainForm MainForm
        {
            get
            {
                if (_MainForm == null)
                    _MainForm = (MainForm)Application.OpenForms["MainForm"];
                return _MainForm;
            }
            private set { }
        }
    }
}
