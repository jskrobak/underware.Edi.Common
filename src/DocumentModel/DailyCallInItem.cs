namespace underware.Edi.Common.DocumentModel;

public class DailyCallInItem: BaseDocumentItem
{
    public decimal Qty { get; set; }
    public string Unit { get; set; }
    public DocumentReference PurchaseOrder { get; set; }
    public DocumentReference DeliveryNote { get; set; }
    
    public string CustomerStorageLocation { get; set; }
}