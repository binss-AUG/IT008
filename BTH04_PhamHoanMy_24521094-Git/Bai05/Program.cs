using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (DBhelper.TestConnection() == false)
            {
                Application.Run(new Form2());
                Application.Run(new Form2());
                Application.Run(new Form2());
            }    

            Application.Run(new Form1());
        }
    }
}
