using System.Xml.Linq;

namespace underware.Edi.Common;

public interface IXmlExportable
{
    XDocument ToXml();
}