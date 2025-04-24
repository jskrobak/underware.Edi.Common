namespace underware.Edi.Common.DocumentModel;

public class OrderResponse: BaseBillDocument
{
    public DateTime DeliveryDate { get; set; }
    public DocumentReference PurchaseOrder { get; set; }
    public OrderResponseAction Action { get; set; }
    public IEnumerable<OrderResponseItem> Items { get; set; }
}