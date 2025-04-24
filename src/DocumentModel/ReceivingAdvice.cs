namespace underware.Edi.Common.DocumentModel;

public class ReceivingAdvice: BaseBillDocument
{
    public DateTime? DeliveryDate { get; set; }
    public DateTime? ReceiveDate { get; set; }
    public DocumentReference PurchaseOrder { get; set; }
    public DocumentReference DespatchAdvice { get; set; }
    public IEnumerable<ReceivingAdviceItem> Items { get; set; }
}

