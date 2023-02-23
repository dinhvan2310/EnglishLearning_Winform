using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    internal static class FormStack
    {
        private static Stack<Form> _stack = new Stack<Form>();

        public static void Push(Form form)
        {
            _stack.Push(form);
        }

        public static Form Pop()
        {
            if (Count() == 0) return null;
            return _stack.Pop();
        }

        public static Form Peek()
        {
            if (Count() == 0) return null;
            return _stack.Peek();
        }

        public static int Count()
        {
            return _stack.Count;
        }

    }
}
