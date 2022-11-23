using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using RDLExplorer;

namespace RDLExplorer.RDL
{
    public class Query
    {
        public readonly string DataSourceName;
        public readonly string CommandType;
        public readonly string CommandText;

        public Query(XmlNode node)
        {
            DataSourceName = XmlHelper.GetInnerText(node.SelectFirstNode("DataSourceName"));
            CommandType = XmlHelper.GetInnerText(node.SelectFirstNode("CommandType"));
            CommandText = XmlHelper.GetInnerText(node.SelectFirstNode("CommandText"));
        }
    }
}
