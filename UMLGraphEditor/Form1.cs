using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace UMLGraphEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool LoadFromFile(string fileName)
        {
            try
            {
                FileInfo fi = new FileInfo(fileName);
                if (fi.Exists)
                {
                    rtfDoctext.Text = File.ReadAllText(fileName);
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void RefreshPreview()
        {
            string dotFileName = Path.ChangeExtension(Path.GetTempFileName(), ".dot");
            File.WriteAllText(dotFileName, rtfDoctext.Text);

            string outputFileName = CreateDotOutput(dotFileName);
            if (string.IsNullOrEmpty(outputFileName))
                picPreview.Image = null;
            else
                picPreview.ImageLocation = outputFileName;
        }

        private string CreateDotOutput(string fileName)
        {
            try
            {
                string graphicFormat = "png";

                string outputFileName = string.Format("{0}.{1}", fileName, graphicFormat);

                ProcessStartInfo psi = new ProcessStartInfo(@"C:\Program Files (x86)\Graphviz 2.28\bin\dot.exe", string.Format("-O -T{1} \"{0}\"", fileName, graphicFormat));
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.WorkingDirectory = Path.GetDirectoryName(fileName);

                Process p = Process.Start(psi);
                p.WaitForExit();

                if (!File.Exists(outputFileName))
                    return null;

                return outputFileName;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            picPreview.Dock = DockStyle.Fill;

            panEditor.Dock = DockStyle.Fill;

            LoadFromFile("Sample.dot");
        }

        private void tsmnuViewRefresh_Click(object sender, EventArgs e)
        {
            RefreshPreview();
        }
    }
}
