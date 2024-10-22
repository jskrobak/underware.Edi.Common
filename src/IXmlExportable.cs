using System.Text;
using System.Xml.Linq;

namespace underware.Edi.Common;

public interface IXmlExportable
{
    XDocument ToXml(Encoding outEnc);
}