using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_大作业
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Global exception handlers to show errors instead of crashing silently
            Application.ThreadException += (sender, e) => ShowException(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                var ex = e.ExceptionObject as Exception;
                ShowException(ex);
            };

            try
            {
                Application.Run(new UI.FrmLogin());
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        private static void ShowException(Exception ex)
        {
            try
            {
                MessageBox.Show("未处理的异常：\r\n" + (ex?.ToString() ?? "无异常信息"), "程序错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                // 忽略展示异常时的二次异常
            }
        }
    }
}
