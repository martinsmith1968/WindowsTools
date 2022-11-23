using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ArgsTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Arguments Length: {0}", args.Length).AppendLine();

            if (args.Length > 0)
            {
                sb.AppendLine();

                int argNo = 0;
                foreach (string arg in args)
                {
                    sb.AppendFormat("[{0}] = {1}", argNo++, arg).AppendLine();
                }
            }

            MessageBox.Show(sb.ToString(), Application.ExecutablePath, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
