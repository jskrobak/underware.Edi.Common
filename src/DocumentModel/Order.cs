namespace underware.Edi.Common.DocumentModel;

public class Order: BaseBillDocument
{
    public DateTime? DeliveryDate { get; set; }
    public List<OrderItem> Items { get; set; }
}