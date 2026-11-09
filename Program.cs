using System;
using System.Windows.Forms;

namespace CATAYAS_WEEK_05_WORK_04
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProductForm());
        }
    }
}