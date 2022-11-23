using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NRA.WinControls;

// TODO: Add Sorting from ListView Header click

namespace WinHider
{
    public partial class Main : Form
    {
        #region Constants

        private const string COL_ID_WINDOWTITLE = "WINDOWTITLE";
        private const string COL_ID_WINDOWHANDLE = "WINDOWHANDLE";
        private const string COL_ID_STATE = "STATE";
        private const string COL_ID_PROCESSNAME = "PROCESSNAME";
        private const string COL_ID_PROCESSID = "PROCESSID";

        private const string COL_TEXT_WINDOWTITLE = "Window Title";
        private const string COL_TEXT_WINDOWHANDLE = "Window Handle";
        private const string COL_TEXT_STATE = "State";
        private const string COL_TEXT_PROCESSNAME = "Process Name";
        private const string COL_TEXT_PROCESSID = "Process ID";

        #endregion

        private ListViewColumnSorter lvwColumnSorter;

        DateTime dtKeyDown = DateTime.MinValue;
        DateTime dtKeyUp = DateTime.MinValue;

        Dictionary<string,string> _KnownColumns = new Dictionary<string,string>();

        public Main()
        {
            InitializeComponent();

            _KnownColumns.Add(COL_ID_WINDOWTITLE, COL_TEXT_WINDOWTITLE);
            _KnownColumns.Add(COL_ID_WINDOWHANDLE, COL_TEXT_WINDOWHANDLE);
            _KnownColumns.Add(COL_ID_STATE, COL_TEXT_STATE);
            _KnownColumns.Add(COL_ID_PROCESSNAME, COL_TEXT_PROCESSNAME);
            _KnownColumns.Add(COL_ID_PROCESSID, COL_TEXT_PROCESSID);
        }

        #region Application Settings

        private void LoadSettings()
        {
            bool upgraded = false;

            if (AppSettings.Default.UpgradePending)
            {
                AppSettings.Default.Upgrade();
                AppSettings.Default.UpgradePending = false;
                upgraded = true;
            }

            try
            {
                Location = new Point(AppSettings.Default.Main_Location.X, AppSettings.Default.Main_Location.Y);
            }
            catch { }

            try
            {
                Size = new Size(AppSettings.Default.Main_Size.Width, AppSettings.Default.Main_Size.Height);
            }
            catch { }

            try
            {
                /*
                if (AppSettings.Default.Config_ListColumns == null || AppSettings.Default.Config_ListColumns.Count == 0)
                {
                    AppSettings.Default.Config_ListColumns = new System.Collections.ArrayList();
                    AppSettings.Default.Config_ListColumns.Add(COL_ID_WINDOWTITLE);
                    AppSettings.Default.Config_ListColumns.Add(COL_ID_PROCESSNAME);
                    AppSettings.Default.Config_ListColumns.Add(COL_ID_STATE);
                }

                BuildColumns(false);
                 * */

                if (AppSettings.Default.Config_ListColumns != null && AppSettings.Default.Config_ListColumns.Count > 0)
                {
                    BuildColumns(false);
                }
            }
            catch { }

            try
            {
                if (AppSettings.Default.Config_ColumnWidths == null)
                {
                    AppSettings.Default.Config_ColumnWidths.Add("180");
                    AppSettings.Default.Config_ColumnWidths.Add("90");
                    AppSettings.Default.Config_ColumnWidths.Add("90");
                }

                int colIndex = -1;
                foreach (object w in AppSettings.Default.Config_ColumnWidths)
                {
                    ++colIndex;

                    int width;
                    if (!Int32.TryParse(w.ToString(), out width))
                        continue;

                    lvwWindows.Columns[colIndex].Width = width;
                }
            }
            catch { }

            if (upgraded)
                AppSettings.Default.Save();
        }

        private void SaveSettings()
        {
            AppSettings.Default.Main_Location = new Point(Location.X, Location.Y);
            AppSettings.Default.Main_Size = new Size(Size.Width, Size.Height);
            AppSettings.Default.Config_ListColumns = new StringCollection();
            AppSettings.Default.Config_ColumnWidths = new StringCollection();
            foreach (ColumnHeader col in lvwWindows.Columns)
            {
                AppSettings.Default.Config_ListColumns.Add(Convert.ToString(col.Tag));
                AppSettings.Default.Config_ColumnWidths.Add(Convert.ToString(col.Width));
            }

            AppSettings.Default.Save();
        }

        private void CopySettings(AppSettings source, AppSettings dest)
        {
            if (source != null && dest != null)
            {
                foreach (System.Configuration.SettingsProperty prop in source.Properties)
                {
                    object value = source.PropertyValues[prop.Name].PropertyValue;
                    if (dest.PropertyValues[prop.Name] == null)
                    {
                        System.Configuration.SettingsPropertyValue x = new System.Configuration.SettingsPropertyValue(source.Properties[prop.Name]);
                        x.PropertyValue = value;
                        dest.PropertyValues.Add(x);
                    }
                    else
                        dest.PropertyValues[prop.Name].PropertyValue = value;
                }
            }
        }

        #endregion

        /// <summary>
        /// Commands the enabler.
        /// </summary>
        private void CommandEnabler()
        {
            bool windowSelected = (lvwWindows.SelectedItems.Count > 0);

            btnShowHide.Enabled = windowSelected;
            btnSetText.Enabled  = windowSelected;
        }

        #region Form Events

        /// <summary>
        /// Handles the Idle event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Application_Idle(object sender, EventArgs e)
        {
            CommandEnabler();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            Application.Idle += new EventHandler(Application_Idle);

            lvwColumnSorter = new ListViewColumnSorter();
            lvwWindows.ListViewItemSorter = lvwColumnSorter;

            Text = string.Format("{0} v{1}", Application.ProductName, Application.ProductVersion);

            panWindows.Dock = DockStyle.Fill;

            LoadSettings();

            PopulateWindows();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Escape:
                    //Close();
                    break;
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            // Prevent keyboard repeat
            if (dtKeyUp < dtKeyDown)
                return;
            dtKeyDown = DateTime.Now;

            // What was pressed ?
            switch (e.KeyCode)
            {
                case Keys.F5:
                    btnRefresh.PerformClick();
                    break;
            }
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            dtKeyUp = DateTime.Now;
        }

        #endregion

        #region Control Events

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateWindows();
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            using (Configuration dlgConfig = new Configuration())
            {
                AppSettings copy = new AppSettings();
                CopySettings(AppSettings.Default, copy);

                // Show Dialog
                dlgConfig.Settings = copy;
                dlgConfig.KnownColumns.Clear();
                foreach(KeyValuePair<string,string> kvp in _KnownColumns)
                    dlgConfig.KnownColumns.Add(kvp.Key, kvp.Value);
                if (dlgConfig.ShowDialog() == DialogResult.OK)
                {
                    CopySettings(copy, AppSettings.Default);
                    BuildColumns(true);
                    btnRefresh.PerformClick();
                }
            }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (lvwWindows.SelectedItems.Count > 0)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    ListViewItem itm = lvwWindows.SelectedItems[0];

                    ToggleWindow(itm.Tag as Window);
                    UpdateItem(itm);

                    lvwWindows.SelectedItems.Clear();
                    lvwWindows.SelectedIndices.Add(itm.Index);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }

        private void btnSetText_Click(object sender, EventArgs e)
        {
            if (lvwWindows.SelectedItems.Count > 0)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    ListViewItem itm = lvwWindows.SelectedItems[0];

                    Window window = itm.Tag as Window;
                    if (window != null)
                    {
                        string title = window.Title;

                        DialogResult result = InputBox.Show("Set Title", "Enter the desired Window Title", ref title);

                        if (result == DialogResult.OK)
                        {
                            window.SetTitle(title);

                            UpdateItem(itm);
                        }
                    }
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvwWindows_DoubleClick(object sender, EventArgs e)
        {
            btnShowHide.PerformClick();
        }

        #endregion

        private void BuildColumns(bool restoreWidths)
        {
            Dictionary<string, int> widths = new Dictionary<string,int>();
            if (restoreWidths)
            {
                foreach (ColumnHeader col in lvwWindows.Columns)
                {
                    widths.Add(Convert.ToString(col.Tag), col.Width);
                }
            }

            lvwWindows.Columns.Clear();
            foreach (string colID in AppSettings.Default.Config_ListColumns)
            {
                ColumnHeader col = lvwWindows.Columns.Add(colID, _KnownColumns[colID]);
                col.Name = "mycol" + colID;
                col.Tag = colID;
                if (restoreWidths)
                {
                    if (widths.ContainsKey(colID))
                        col.Width = widths[colID];
                    else
                        col.Width = 90;
                }


                switch (colID)
                {
                    case COL_ID_PROCESSID:
                    case COL_ID_WINDOWHANDLE:
                        col.TextAlign = HorizontalAlignment.Right;
                        break;
                    default:
                        col.TextAlign = HorizontalAlignment.Left;
                        break;
                }

                try
                {
                    lvwWindows.Columns.Add(col);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
        }

        private void SetListViewText(ListViewItem itm, string text, int index)
        {
            if (index == 0)
            {
                itm.Text = text;
            }
            else
            {
                while (itm.SubItems.Count <= index)
                    itm.SubItems.Add(string.Empty);

                itm.SubItems[index].Text = text;
            }
        }

        #region Window Processing

        private ListViewItem ToListViewItem(Window w)
        {
            ListViewItem itm = new ListViewItem();

            itm.Tag = w;
            UpdateItem(itm);

            return itm;
        }

        private void UpdateItem(ListViewItem itm)
        {
            Window w = itm.Tag as Window;

            try
            {
                lvwWindows.BeginUpdate();

                itm.SubItems.Clear();
                itm.UseItemStyleForSubItems = true;

                if (w != null)
                {
                    itm.ForeColor = (w.Visible) ? Color.FromKnownColor(KnownColor.WindowText) : Color.DarkGray;
                    if (AppSettings.Default.Config_ShowApplicationIcons)
                    {
                        UpdateImage(lvwWindows.SmallImageList, w, false);
                    }
                    foreach (ColumnHeader col in lvwWindows.Columns)
                    {
                        switch (Convert.ToString(col.Tag))
                        {
                            case COL_ID_WINDOWTITLE:
                                SetListViewText(itm, w.Title, col.Index);
                                itm.ImageKey = AppSettings.Default.Config_ShowApplicationIcons
                                                ? w.FileName
                                                : string.Empty;
                                break;
                            case COL_ID_WINDOWHANDLE:
                                SetListViewText(itm, w.hWnd.ToString(), col.Index);
                                break;
                            case COL_ID_STATE:
                                SetListViewText(itm, (w.Visible ? "Visible" : "Hidden"), col.Index);
                                break;
                            case COL_ID_PROCESSNAME:
                                SetListViewText(itm, System.IO.Path.GetFileName(w.ProcessName), col.Index);
                                break;
                            case COL_ID_PROCESSID:
                                SetListViewText(itm, w.ProcessID.ToString(), col.Index);
                                break;
                        }
                    }
                }
                else
                {
                    itm.Text = "";
                }
            }
            catch
            {
            }
            finally
            {
                lvwWindows.EndUpdate();
            }
        }

        private void UpdateImage(ImageList imageList, Window window, bool overwrite)
        {
            if (imageList != null)
            {
                if (imageList.Images.ContainsKey(window.FileName))
                {
                    if (overwrite)
                    {
                        imageList.Images.RemoveByKey(window.FileName);
                    }
                    else
                    {
                        return;
                    }
                }

                imageList.Images.Add(window.FileName, System.Drawing.Icon.ExtractAssociatedIcon(window.FileName));
            }
        }

        private void ToggleWindow(Window w)
        {
            if (w != null)
            {
                w.Visible = !w.Visible;
            }
        }

        private void PopulateWindows()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                //lstWindows.Items.Clear();
                lvwWindows.Items.Clear();

                foreach (Window w in new Windows(AppSettings.Default.Config_ShowInvisibleWindows, AppSettings.Default.Config_ShowUntitledWindows))
                {
                    // Ignore myself
                    if (w.hWnd == Handle)
                        continue;

                    lvwWindows.Items.Add(ToListViewItem(w));
                }

                lvwWindows.SelectedItems.Clear();
            }
            catch
            {
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion

        private void lvwWindows_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            lvwWindows.Sort();
        }
    }
}