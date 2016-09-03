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
    abstract class XmlHandler
    {
        public XmlDocument document { get; set; }
        //abstract public void LoadXmlFile(string fileName);
        public virtual void LoadXmlFile(string fileName)
        {            try
            {
                document = new XmlDocument();
                document.Load(fileName);
            }
            catch (XmlException exception)
            {
                MessageBox.Show("Your XML was probably bad...");
            }
        }
    }
}
