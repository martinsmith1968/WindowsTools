using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;

namespace RDLExplorer.RDL
{
    public class File
    {
        private string _FileName;
        private bool _IsValid;

        private List<DataSet> _DataSets;

        public string FileName
        {
            get { return _FileName; }
        }
        public bool IsValid
        {
            get { return _IsValid; }
        }
        public DataSet[] DataSets
        {
            get { return _DataSets.ToArray(); }
        }

        public File(string fileName)
        {
            _FileName = fileName;

            ReadData();
        }

        private void ReadData()
        {
            _IsValid = false;
            _DataSets = new List<DataSet>();

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(_FileName);

                _DataSets.AddRange(DataSet.Load(doc.SelectAllNodes("/Report/DataSets/DataSet")));

                _IsValid = true;
            }
            catch (Exception ex)
            {
                _IsValid = false;
            }
        }
    }
}
