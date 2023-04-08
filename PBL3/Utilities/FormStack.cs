using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Utilities
{
    public static class FormStack
    {
        private static Stack<Form> _Stack = new Stack<Form>();

        public static void Push(Form form)
        {
            _Stack.Push(form);
        }

        public static Form Pop()
        {
            if (Count() == 0) return null;
            return _Stack.Pop();
        }

        public static Form Peek()
        {
            if (Count() == 0) return null;
            return _Stack.Peek();
        }

        public static int Count()
        {
            return _Stack.Count;
        }

        public static void Clear()
        {
            int i = 1;
            foreach (Form form in _Stack)
            {
                if (_Stack.Count == i) // if base form
                {
                    form.Hide();
                    continue;
                }
                form.Close();
                i++;
            }
            _Stack.Clear();
        }

    }
}
