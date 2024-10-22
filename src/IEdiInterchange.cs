using underware.Edi.Common.DocumentModel;

namespace underware.Edi.Common;

public interface IEdiInterchange
{
    string Sender { get; }
    string Receiver { get; }
    string Format { get;}
    string RefNo { get; }
    DateTime Created { get; }
    IEnumerable<IDocument> Documents { get; }
}