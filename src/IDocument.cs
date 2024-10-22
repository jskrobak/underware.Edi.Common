using underware.Edi.Common.DocumentModel;

namespace underware.Edi.Common;

public interface IDocument
{
    public BaseDocument GetDocument();
    public void FromDocument(BaseDocument doc);
}