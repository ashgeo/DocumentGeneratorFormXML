using Document_Generator_From_XML.Interfaces;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Generator_From_XML.GeneralClasses
{
   public  class ConfigSheet: IGimbalSettingsDocumentGenerator
    {
        public void GenerateDocument(string fileName, Dictionary<string, XmlDataClass> attributeDictionary)
        {

        }

        private static void SetCheckBox(OpenXmlElement field, bool isChecked)
        {
            field.Parent.Parent.FirstChild.GetFirstChild<SdtContentCheckBox>().Checked.Val = isChecked ? OnOffValues.True : OnOffValues.False;
            field.Parent.Parent.Descendants<Run>().First().GetFirstChild<Text>().Text = isChecked ? "☒" : "☐";
        }
    }
}
