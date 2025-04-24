namespace underware.Edi.Common.DocumentModel;

public class InterchangeAcknowledgement: BaseDocument
{
    public string RefNo { get; set; }
    public string RefInterchangeRefNo { get; set; }
    public string RefInterchangeSender { get; set; }
    public string RefInterchangeRecipient { get; set; }
    public string RefInterchangeStatusCode { get; set; }
    public string RefMessageType { get; set; }
    public string RefMessageRefNo { get; set; }
    public string RefMessageStatusCode { get; set; }
}