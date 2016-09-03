using Document_Generator_From_XML.GeneralClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Generator_From_XML.Interfaces
{
    interface IGimbalSettingsDocumentGenerator
    {
        void GenerateDocument(string fileName, Dictionary<string,XmlDataClass> attributeDictionary);
    }
}
