using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PBL3
{
    internal static class ExternalImport
    {
        // Rounded winform
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );


        // Drag winform
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Hide Cursor
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool HideCaret(IntPtr hWnd);
    }
}
