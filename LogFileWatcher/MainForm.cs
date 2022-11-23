using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogFileWatcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddLog(string text)
        {
            this.UIThread(delegate
            {
                textBox1.Text += text + Environment.NewLine;
            });

            this.UIThread(
                () => textBox1.Text += text + Environment.NewLine
            );
        }

        private void SetText(string txt)
        {
            if (textBox1.InvokeRequired)
                textBox1.Invoke(new MethodInvoker(delegate { SetText(txt); }));
            else
                textBox1.Text = txt;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
