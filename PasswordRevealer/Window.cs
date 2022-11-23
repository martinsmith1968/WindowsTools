using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PasswordRevealer
{
    /// <summary>
    /// Object used to control a Windows Form.
    /// </summary>
    public class Window
    {
        /// <summary>
        /// Win32 API Imports
        /// </summary>
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool IsZoomed(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        [DllImport("user32.dll")]
        private static extern IntPtr AttachThreadInput(IntPtr idAttach, IntPtr idAttachTo, int fAttach);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

        /// <summary>
        /// Win32 API Constants for ShowWindowAsync()
        /// </summary>
        private const int SW_HIDE = 0;
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        private const int SW_SHOWNOACTIVATE = 4;
        private const int SW_RESTORE = 9;
        private const int SW_SHOWDEFAULT = 10;

        public const int EM_SETPASSWORDCHAR = 204;

        /// <summary>
        /// Private Fields
        /// </summary>
        private IntPtr m_hWnd;
        private string m_Title;
        private bool m_Visible = true;
        private string m_Process;
        private Int32 m_ProcessID;
        private bool m_WasMax = false;
        private bool m_WasIcon = false;
        private string m_FileName = string.Empty;

        /// <summary>
        /// Window Object's Public Properties
        /// </summary>
        public IntPtr hWnd
        {
            get { return m_hWnd; }
        }
        public string Title
        {
            get { return m_Title; }
        }
        public string ProcessName
        {
            get { return m_Process; }
        }
        public Int32 ProcessID
        {
            get { return m_ProcessID; }
        }
        public string FileName
        {
            get { return m_FileName; }
        }

        /// <summary>
        /// Sets this Window Object's visibility
        /// </summary>
        public bool Visible
        {
            get { return m_Visible; }
            set
            {
                //show the window
                if (value == true)
                {
                    if (m_WasMax)
                    {
                        if (ShowWindowAsync(m_hWnd, SW_SHOWMAXIMIZED))
                            m_Visible = true;
                    }
                    else if (m_WasIcon)
                    {
                        if (ShowWindowAsync(m_hWnd, SW_SHOWMINIMIZED))
                            m_Visible = true;
                    }
                    else
                    {
                        if (ShowWindowAsync(m_hWnd, SW_SHOWNORMAL))
                            m_Visible = true;
                    }
                }
                //hide the window
                if (value == false)
                {
                    m_WasMax = IsZoomed(m_hWnd);
                    m_WasIcon = IsIconic(m_hWnd);
                    if (ShowWindowAsync(m_hWnd, SW_HIDE))
                        m_Visible = false;
                }
            }
        }

        /// <summary>
        /// Constructs a Window Object
        /// </summary>
        /// <param name="Title">Title Caption</param>
        /// <param name="hWnd">Handle</param>
        /// <param name="Process">Owning Process</param>
        public Window(string Title, IntPtr hWnd, string process, int processID)
        {
            m_Title = Title;
            m_hWnd = hWnd;
            m_Process = process;
            m_ProcessID = processID;
            try
            {
                Process p = Process.GetProcessById(processID);
                m_FileName = p.MainModule.FileName;
            }
            catch
            {
            }
        }

        //Override ToString()
        public override string ToString()
        {
            //return the title if it has one, if not return the process name
            if (m_Title.Length > 0)
            {
                return m_Title;
            }
            else
            {
                return m_Process;
            }
        }

        /// <summary>
        /// Sets focus to this Window Object
        /// </summary>
        public void Activate()
        {
            if (m_hWnd == GetForegroundWindow())
                return;

            IntPtr ThreadID1 = GetWindowThreadProcessId(GetForegroundWindow(), IntPtr.Zero);
            IntPtr ThreadID2 = GetWindowThreadProcessId(m_hWnd, IntPtr.Zero);

            if (ThreadID1 != ThreadID2)
            {
                AttachThreadInput(ThreadID1, ThreadID2, 1);
                SetForegroundWindow(m_hWnd);
                AttachThreadInput(ThreadID1, ThreadID2, 0);
            }
            else
            {
                SetForegroundWindow(m_hWnd);
            }

            if (IsIconic(m_hWnd))
            {
                ShowWindowAsync(m_hWnd, SW_RESTORE);
            }
            else if (IsZoomed(m_hWnd))
            {
                ShowWindowAsync(m_hWnd, SW_SHOWMAXIMIZED);
            }
            else
            {
                ShowWindowAsync(m_hWnd, SW_SHOWNORMAL);
            }
        }
    }

    public class ProcessWindow
    {
        public int ProcessID;
        public int MainWindowHandle;
        public string MainWindowTitle;
        public string ModuleName;
        public string ModuleFileName;

        public ProcessWindow(Process p)
        {
            ProcessID = p.Id;
            MainWindowHandle = p.MainWindowHandle.ToInt32();
            MainWindowTitle = p.MainWindowTitle;
            ModuleName = p.ProcessName;
            try
            {
                ModuleFileName = p.MainModule.FileName;
            }
            catch
            {
            }
        }
    }

    /// <summary>
    /// Collection used to enumerate Window Objects
    /// </summary>
    public class Windows : IEnumerable, IEnumerator
    {
        /// <summary>
        /// Win32 API Imports
        /// </summary>
        [DllImport("user32.dll")]
        private static extern int GetWindowText(int hWnd, StringBuilder title, int size);
        [DllImport("user32.dll", EntryPoint = "GetWindowModuleFileNameA")]
        private static extern int GetWindowModuleFileName(int hWnd, StringBuilder title, int size);
        [DllImport("user32.dll")]
        private static extern int EnumWindows(EnumWindowsProc ewp, int lParam);
        [DllImport("user32.dll")]
        private static extern bool IsWindowVisible(int hWnd);
        [DllImport("user32")]
        private static extern UInt32 GetWindowThreadProcessId(Int32 hWnd, out Int32 lpdwProcessId);

        //delegate used for EnumWindows() callback function
        public delegate bool EnumWindowsProc(int hWnd, int lParam);

        private int m_Position = -1; //holds current index of wndArray, necessary for IEnumerable

        ArrayList wndArray = new ArrayList(); //array of windows
        Dictionary<int, ProcessWindow> processCache = new Dictionary<int, ProcessWindow>();

        public int Count
        {
            get { return wndArray.Count; }
        }

        //Object's private fields
        private bool m_invisible = false;
        private bool m_notitle = false;

        /// <summary>
        /// Collection Constructor with additional options
        /// </summary>
        /// <param name="Invisible">Include invisible Windows</param>
        /// <param name="Untitled">Include untitled Windows</param>
        public Windows(bool Invisible, bool Untitled)
        {
            m_invisible = Invisible;
            m_notitle = Untitled;

            processCache.Clear();
            foreach (Process p in Process.GetProcesses())
            {
                ProcessWindow pw = new ProcessWindow(p);
                if (pw.MainWindowHandle > 0)
                    processCache.Add(pw.MainWindowHandle, pw);
            }

            //Declare a callback delegate for EnumWindows() API call
            EnumWindowsProc ewp = new EnumWindowsProc(EvalWindow);
            //Enumerate all Windows
            EnumWindows(ewp, 0);
        }
        /// <summary>
        /// Collection Constructor
        /// </summary>
        public Windows()
        {
            //Declare a callback delegate for EnumWindows() API call
            EnumWindowsProc ewp = new EnumWindowsProc(EvalWindow);
            //Enumerate all Windows
            EnumWindows(ewp, 0);
        }
        //EnumWindows CALLBACK function
        private bool EvalWindow(int hWnd, int lParam)
        {
            if (m_invisible == false && !IsWindowVisible(hWnd))
                return (true);

            StringBuilder title = new StringBuilder(256);
            StringBuilder module = new StringBuilder(256);
            Int32 processID = 0;

            bool foundProcess = false;
            if (processCache.ContainsKey(hWnd))
            {
                ProcessWindow pw = processCache[hWnd];

                title.Append(pw.MainWindowTitle);
                module.Append(pw.ModuleName);
                processID = pw.ProcessID;

                foundProcess = true;
            }
            /*
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowHandle.ToInt32() == hWnd)
                {
                    title.Append(p.MainWindowTitle);
                    module.Append(p.MainModule.ModuleName);

                    foundProcess = true;

                    break;
                }
            }
             * */

            if (!foundProcess)
            {
                int x = GetWindowModuleFileName(hWnd, module, 256);
                GetWindowText(hWnd, title, 256);
                processID = GetWindowProcessID(hWnd);
                Process p = Process.GetProcessById(processID);
                if (p != null)
                {
                    module = new StringBuilder(p.ProcessName);
                }
            }

            if (m_notitle == false && title.Length == 0)
                return (true);

            wndArray.Add(new Window(title.ToString(), (IntPtr)hWnd, module.ToString(), processID));

            return (true);
        }

        private Int32 GetWindowProcessID(Int32 hwnd)
        {
            Int32 pid = 1;
            GetWindowThreadProcessId(hwnd, out pid);
            return pid;
        }

        //implement IEnumerable
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        //implement IEnumerator
        public bool MoveNext()
        {
            m_Position++;
            if (m_Position < wndArray.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            m_Position = -1;
        }
        public object Current
        {
            get
            {
                return wndArray[m_Position];
            }
        }
    }
}
