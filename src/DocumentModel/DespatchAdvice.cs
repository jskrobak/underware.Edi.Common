namespace underware.Edi.Common.DocumentModel;

public class DespatchAdvice: BaseDocument
{
    public DateTime? DeliveryDate { get; set; }
    public DateTime? DispatchDate { get; set; }
    public DocumentReference PurchaseOrder { get; set; }
    public IEnumerable<DespatchAdviceItem> Items { get; set; }
}