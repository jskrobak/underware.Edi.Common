namespace underware.Edi.Common;

public class ParseDocumentException : Exception
{
    public ParseDocumentException(IDocument document, IEdiInterchange interchange): base()
    {
        Document = document;
        Interchange = interchange;
    }

    public IDocument Document { get; }
    public IEdiInterchange Interchange { get; }
}