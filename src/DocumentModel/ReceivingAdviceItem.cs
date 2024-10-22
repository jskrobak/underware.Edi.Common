namespace underware.Edi.Common.DocumentModel;

public class ReceivingAdviceItem: BaseDocumentItem
{
    public decimal? OrderedQty { get; set; }
    public decimal ReceivedQty { get; set; }
    public DocumentReference PurchaseOrder { get; set; }
    public DocumentReference DespatchAdvice { get; set; }
}