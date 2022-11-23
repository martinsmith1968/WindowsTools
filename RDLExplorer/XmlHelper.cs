using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RDLExplorer
{
    public abstract class XmlHelper
    {
        static public string GetAttribute(XmlNode node, string name)
        {
            return GetAttribute(node, name, null);
        }
        static public string GetAttribute(XmlNode node, string name, string defaultValue)
        {
            string ret = defaultValue;

            if (node != null)
            {
                XmlNode att = node.Attributes.GetNamedItem(name);
                if (att != null)
                {
                    ret = att.Value;
                }
            }

            return ret;
        }

        static public string GetInnerText(XmlNode node)
        {
            return GetInnerText(node, string.Empty);
        }
        static public string GetInnerText(XmlNode node, string defaultValue)
        {
            string ret = defaultValue;

            if (node != null)
            {
                ret = node.InnerText;
            }

            return ret;
        }
    }
}
