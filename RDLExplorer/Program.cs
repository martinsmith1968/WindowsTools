using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RDLExplorer.CommandLine;

namespace RDLExplorer
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

            // Parse Arguments
            Arguments arguments = new Arguments();
            Parser.ParseArguments(args, arguments);

            // Create Form
            frmRDLViewer frm = new frmRDLViewer();
            // Apply arguments
            if (arguments.HasFileName)
                frm.OpenFile(arguments.FileName);

            Application.Run(frm);
        }
    }
}
