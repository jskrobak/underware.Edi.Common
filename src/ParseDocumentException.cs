namespace underware.Edi.Common;

public class ParseDocumentException(IDocument document, IEdiInterchange interchange, Exception innerEx)
    : Exception("Failed to parse document", innerEx)
{
    public IDocument Document { get; } = document;
    public IEdiInterchange Interchange { get; } = interchange;
}