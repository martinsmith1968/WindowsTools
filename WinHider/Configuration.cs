using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinHider
{
    partial class Configuration : Form
    {
        private EventHandler _IdleHandler;
        private AppSettings _Settings;
        private Dictionary<string,string> _KnownColumns = new Dictionary<string,string>();

        public AppSettings Settings
        {
            get { return _Settings; }
            set { _Settings = value; }
        }
        public Dictionary<string, string> KnownColumns
        {
            get { return _KnownColumns; }
        }

        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            _IdleHandler = new EventHandler(Application_Idle);
            Application.Idle += _IdleHandler;

            tbcSettings.SelectedIndex = 0;

            ValuesToScreen();
        }

        void Application_Idle(object sender, EventArgs e)
        {
            CommandEnabler();
        }

        private void CommandEnabler()
        {
            btnColMoveUp.Enabled = clbColumns.SelectedIndex > 0;
            btnColMoveDown.Enabled = clbColumns.SelectedIndex < (clbColumns.Items.Count - 1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            ScreenToValues();

            DialogResult = DialogResult.OK;
        }

        private bool IsValid()
        {
            try
            {
                if (clbColumns.CheckedItems.Count == 0)
                {
                    tbcSettings.SelectedTab = tbpListColumns;
                    throw new Exception("You must select at least 1 Column");
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void ValuesToScreen()
        {
            chkWindowControl_ShowInvisible.Checked = _Settings == null ? false : _Settings.Config_ShowInvisibleWindows;
            chkWindowControl_ShowUntitled.Checked = _Settings == null ? false : _Settings.Config_ShowUntitledWindows;
            chkWindowControl_ShowApplicationIcons.Checked = _Settings == null ? false : _Settings.Config_ShowApplicationIcons;

            clbColumns.Items.Clear();
            foreach (string colID in _Settings.Config_ListColumns)
            {
                int index = clbColumns.Items.Add(_KnownColumns[colID]);
                clbColumns.SetItemChecked(index, true);
            }
            foreach (KeyValuePair<string, string> kvp in _KnownColumns)
            {
                if (clbColumns.Items.Contains(kvp.Value))
                    continue;
                int index = clbColumns.Items.Add(kvp.Value);
                clbColumns.SetItemChecked(index, false);
            }
        }

        private void ScreenToValues()
        {
            if (_Settings != null)
            {
                _Settings.Config_ShowInvisibleWindows = chkWindowControl_ShowInvisible.Checked;
                _Settings.Config_ShowUntitledWindows = chkWindowControl_ShowUntitled.Checked;
                _Settings.Config_ShowApplicationIcons = chkWindowControl_ShowApplicationIcons.Checked;

                _Settings.Config_ListColumns.Clear();
                foreach (string title in clbColumns.CheckedItems)
                {
                    foreach (KeyValuePair<string, string> kvp in _KnownColumns)
                    {
                        if (title == kvp.Value)
                        {
                            _Settings.Config_ListColumns.Add(kvp.Key);
                        }
                    }
                }
            }
        }

        private void Configuration_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_IdleHandler != null)
                Application.Idle -= _IdleHandler;
        }

        private void btnColMoveUp_Click(object sender, EventArgs e)
        {
            if (clbColumns.SelectedItem != null)
            {
                object o = clbColumns.SelectedItem;
                int index = clbColumns.SelectedIndex;
                bool isChecked = clbColumns.CheckedIndices.Contains(index);

                clbColumns.Items.Remove(o);
                clbColumns.Items.Insert(index - 1, o);
                clbColumns.SelectedIndex = (index - 1);
                clbColumns.SetItemChecked(index - 1, isChecked);
            }
        }

        private void btnColMoveDown_Click(object sender, EventArgs e)
        {
            if (clbColumns.SelectedItem != null)
            {
                object o = clbColumns.SelectedItem;
                int index = clbColumns.SelectedIndex;
                bool isChecked = clbColumns.CheckedIndices.Contains(index);

                clbColumns.Items.Remove(o);
                clbColumns.Items.Insert(index + 1, o);
                clbColumns.SelectedIndex = (index + 1);
                clbColumns.SetItemChecked(index + 1, isChecked);
            }
        }
    }
}