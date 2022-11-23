using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NRA.WinControls
{
    public partial class NamedPanelContainer : UserControl
    {
        public NamedPanelContainer()
        {
            InitializeComponent();

            BuildListItems();

            extendedTabControl1.TabIndexChanged += new EventHandler(extendedTabControl1_TabIndexChanged);
            extendedTabControl1.ControlAdded += new ControlEventHandler(extendedTabControl1_ControlAdded);
            extendedTabControl1.ControlRemoved += new ControlEventHandler(extendedTabControl1_ControlRemoved);

            lstPages.SelectedIndexChanged += new EventHandler(lstPages_SelectedIndexChanged);
        }

        void lstPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            extendedTabControl1.SelectedTab = lstPages.SelectedItem as TabPage;
        }

        void extendedTabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            lstPages.SelectedItem = extendedTabControl1.SelectedTab;
        }

        public TabControl.TabPageCollection Pages
        {
            get { return extendedTabControl1.TabPages; }
        }

        void BuildListItems()
        {
            lstPages.Items.Clear();
            foreach (TabPage tbp in extendedTabControl1.TabPages)
            {
                lstPages.Items.Add(tbp);
            }
        }

        void extendedTabControl1_ControlRemoved(object sender, ControlEventArgs e)
        {
            BuildListItems();
        }

        void extendedTabControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            BuildListItems();
        }


    }
}
