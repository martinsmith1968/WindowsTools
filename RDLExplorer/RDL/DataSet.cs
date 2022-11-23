using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RDLExplorer.RDL
{
    public class DataSet
    {
        public readonly string Name;
        public readonly Query Query;

        public DataSet(XmlNode node)
        {
            Name = XmlHelper.GetAttribute(node, "Name");

            Query = new Query(node.SelectFirstNode("Query"));
        }

        public string DisplayName
        {
            get { return Name; }
        }

        static public DataSet[] Load(XmlNodeList nodes)
        {
            List<DataSet> list = new List<DataSet>();

            foreach (XmlNode node in nodes)
            {
                DataSet item = new DataSet(node);

                list.Add(item);
            }

            return list.ToArray();
        }
    }
}
