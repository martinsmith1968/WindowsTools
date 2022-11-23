using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RDLExplorer;

namespace RDLExplorer
{
    public partial class frmRDLViewer : Form
    {
        private RDL.File _RDLFile = null;

        public void OpenFile(string fileName)
        {
            _RDLFile = new RDL.File(fileName);

            DisplayData();
        }

        private void CloseFile()
        {
            _RDLFile = null;

            DisplayData();
        }

        public frmRDLViewer()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            lstDataSets.DataSource = _RDLFile == null ? null : _RDLFile.DataSets;
            lstDataSets.DisplayMember = "DisplayName";

            lstDataSets.SelectedItem = null;
            DisplayDataSet(null);
        }

        private void DisplayDataSet(RDL.DataSet ds)
        {
            lstDataSetQuery.Items.Clear();

            if (ds != null && ds.Query != null)
            {
                lstDataSetQuery.Items.Add("DataSource Name :").SubItems.Add(ds.Query.DataSourceName);
                lstDataSetQuery.Items.Add("Command Type :").SubItems.Add(ds.Query.CommandType);
                lstDataSetQuery.Items.Add("Command Text :").SubItems.Add(ds.Query.CommandText);
            }

            foreach(ColumnHeader col in lstDataSetQuery.Columns)
                col.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void frmRDLViewer_Load(object sender, EventArgs e)
        {

        }

        private void tsmnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmnuFileOpen_Click(object sender, EventArgs e)
        {

        }

        private void tsmnuHelpAbout_Click(object sender, EventArgs e)
        {
            using (frmAbout frm = new frmAbout())
            {
                frm.ShowDialog();
            }
        }

        private void lstDataSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DisplayDataSet(lstDataSets.SelectedValue as Data.DataSet);
        }
    }
}
