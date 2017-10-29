using System.Xml;

namespace V4C_Editor
{
    public class XML
    {
        public enum XMLTag
        {
            Title,
            Description
        };

        private XmlWriterSettings settings = new XmlWriterSettings();
        private XmlWriter w;

        public XML()
        {
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
        }

        //read XML file
        public void read()
        {
            //TODO: Read file
        }

        //write XML file
        public void write(string fileLoc, string title, string content)
        {
            w = XmlWriter.Create(fileLoc, settings);

            w.WriteStartElement("Feed");
            w.WriteStartElement("Item");

            w.WriteStartElement("Title");
            w.WriteString(title);
            w.WriteEndElement();

            w.WriteStartElement("Description");
            w.WriteString(content);
            w.WriteEndElement();

            w.WriteEndElement();
            w.WriteEndElement();
            w.Close();
        }

        //TODO: Read File
        public void read(string fileLoc)
        {

        }

        //split an XML string into elements -> returns the specified element
        public XmlNodeList splitXML(string XMLString, XMLTag xmlType)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(XMLString);
            return xmlDoc.GetElementsByTagName(xmlType.ToString());
        }

    }
}