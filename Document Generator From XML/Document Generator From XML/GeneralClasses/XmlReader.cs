using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Linq;

namespace Document_Generator_From_XML.GeneralClasses
{
    class XmlReader: XmlHandler
    {
        private Dictionary<string, XmlDataClass> attibuteDictionary;
        private const string TAG_NAME = "name";
        private const string TAG_VALUE = "value";
        XmlDataClass xmldataClass;
        public XmlReader()
        {
            attibuteDictionary = new Dictionary<string, XmlDataClass>();
        }
        public Dictionary<string, XmlDataClass> GetNodeValues()
        {          
            XmlNodeList nodeList = document.DocumentElement.SelectNodes("/response/scheme/items/item");          
            foreach (XmlNode node in nodeList)
            {
                xmldataClass = new XmlDataClass();
                xmldataClass.Name = node.SelectSingleNode("name").InnerText;
                xmldataClass.Value = node.SelectSingleNode("value").InnerText;
                xmldataClass.Type = node.SelectSingleNode("type").InnerText;
                attibuteDictionary.Add(xmldataClass.Name, xmldataClass);
            }
            return attibuteDictionary;
        }
      
       
    }
}
