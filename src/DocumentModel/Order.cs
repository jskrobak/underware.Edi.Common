namespace underware.Edi.Common.DocumentModel;

public class Order: BaseDocument
{
    public DateTime DeliveryDate { get; set; }
    public IEnumerable<OrderItem> Items { get; set; }
}