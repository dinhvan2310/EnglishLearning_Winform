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
        private static MainForm _MainForm;
        private static LoginForm _LoginForm;

        public static MainForm MainForm
        {
            get
            {
                if (_MainForm == null)
                    _MainForm = new MainForm();
                return _MainForm;
            }
            private set { }
        }

        public static LoginForm LoginForm
        {
            get
            {
                _LoginForm = new LoginForm();
                return _LoginForm;
            }
            private set { }
        }
    }
}
