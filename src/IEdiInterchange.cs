namespace underware.Edi.Common;

public interface IEdiInterchange
{
    string Sender { get; }
    string Receiver { get; }
    string Format { get;}
    
}