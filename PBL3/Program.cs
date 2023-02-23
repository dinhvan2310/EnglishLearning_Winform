using PBLLibrary;
using PBLLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.InitializeConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            mainForm.Show();
            Application.Run();
        }
    }
}
