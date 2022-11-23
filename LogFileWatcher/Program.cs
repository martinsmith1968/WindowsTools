using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LogFileWatcher
{
    static class ControlExtensions
    {
        static public void UIThread(this Control control, Action code)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(code);
                return;
            }
            code.Invoke();
        }

        static public void UIThreadInvoke(this Control control, Action code)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(code);
                return;
            }
            code.Invoke();
        }
    }

    static class Program
    {
        static MainForm theForm = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (theForm = new MainForm())
            {
                FileSystemWatcher watcher = new FileSystemWatcher(Path.GetTempPath(), "Crap.txt");

                watcher.Changed += new FileSystemEventHandler(watcher_Changed);
                watcher.Created += new FileSystemEventHandler(watcher_Created);
                watcher.Deleted += new FileSystemEventHandler(watcher_Deleted);
                watcher.Error += new ErrorEventHandler(watcher_Error);
                watcher.Renamed += new RenamedEventHandler(watcher_Renamed);
                watcher.EnableRaisingEvents = true;
                watcher.NotifyFilter = NotifyFilters.Attributes
                                     | NotifyFilters.CreationTime
                                     | NotifyFilters.DirectoryName
                                     | NotifyFilters.FileName
                                     | NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.Security
                                     | NotifyFilters.Size;

                Application.Run(theForm);
            }
        }

        static void watcher_Renamed(object sender, RenamedEventArgs e)
        {
            theForm.AddLog(string.Format("Renamed: {0} From: {1} To: {2}",
                e.ChangeType,
                e.OldFullPath,
                e.FullPath
                ));
        }

        static void watcher_Error(object sender, ErrorEventArgs e)
        {
            theForm.AddLog(string.Format("Error: {0} - {1}", e.GetException().GetType().Name, e.GetException().Message));
        }

        static void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            theForm.AddLog(string.Format("Deleted: {0}",
                e.ChangeType
                ));
        }

        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            theForm.AddLog(string.Format("Changed: {0} - Size: {1}",
                e.ChangeType,
                new FileInfo(e.FullPath).Length
                ));
        }

        static void watcher_Created(object sender, FileSystemEventArgs e)
        {
            theForm.AddLog(string.Format("Created: {0}",
                e.ChangeType
                ));
        }
    }
}
