namespace underware.Edi.Common.DocumentModel;

public class OrderResponse: BaseDocument
{
    public DateTime DeliveryDate { get; set; }
    public DocumentReference PurchaseOrder { get; set; }
    public OrderResponseAction Action { get; set; }
    public IEnumerable<OrderResponseItem> Items { get; set; }
}