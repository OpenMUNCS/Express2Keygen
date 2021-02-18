using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace AuthenticationGenerator
{
    class XmlModule
    {
        public static string SerializeXml(object data)
        {

            XmlWriterSettings settings = new XmlWriterSettings();

#if DEBUG
            settings.Indent = true;
            settings.IndentChars = "    ";
            settings.NewLineChars = "\r\n";
#else
            settings.Indent = false;
            settings.IndentChars = "";
            settings.NewLineChars = "";
#endif
            settings.Encoding = Encoding.UTF8;
            settings.OmitXmlDeclaration = true;

            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(sw, settings))
                {
                    XmlSerializer xz = new XmlSerializer(data.GetType());
                    // 强制指定命名空间，覆盖默认的命名空间
                    XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    xz.Serialize(xmlWriter, data, namespaces);
                    xmlWriter.Close();
                    sw.Close();
                    return sw.ToString();
                };
            };
        }
    }
}
