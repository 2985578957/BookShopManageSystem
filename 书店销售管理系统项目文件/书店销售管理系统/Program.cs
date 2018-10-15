using System;
using System.Windows.Forms;
using 书店销售管理系统.Interface;

namespace 书店销售管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login_Page login = new Login_Page();

            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK)
            {
                login.Dispose();
                Application.Run(new Main_Page());
            }
            else if (login.DialogResult == DialogResult.Cancel)
            {
                login.Dispose();
                return;
            }

        }
    }
}
