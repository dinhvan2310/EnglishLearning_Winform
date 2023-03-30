using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    internal static class GlobalForm
    {
        private static FormAdmin _adminForm;
        private static MainForm _mainForm;

        public static FormAdmin AdminForm
        {
            get
            {
                if (_adminForm == null)
                    _adminForm = (FormAdmin)Application.OpenForms["FormAdmin"];
                return _adminForm;
            }
            private set { }
        }

        public static MainForm MainForm
        {
            get
            {
                if (_mainForm == null)
                    _mainForm = (MainForm)Application.OpenForms["MainForm"];
                return _mainForm;
            }
            private set { }
        }
    }
}
