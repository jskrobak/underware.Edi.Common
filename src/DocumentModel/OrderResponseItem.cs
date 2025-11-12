namespace underware.Edi.Common.DocumentModel;

public class OrderResponseItem: OrderItem
{
    public decimal ConfirmedQty { get; set; }
    public DateTime ConfirmedDeliveryDate { get; set; }
    public decimal? ConfirmedNetUnitPrice { get; set; }

    public OrderResponseItemAction Action { get; private set; }

    public void RecalculateAction()
    {
        if (ConfirmedQty == 0) Action = OrderResponseItemAction.REJECTED;
        else if (ConfirmedQty != Qty 
            || DeliveryDate != ConfirmedDeliveryDate 
            || (NetUnitPrice.HasValue &&
            ConfirmedNetUnitPrice.HasValue &&
            NetUnitPrice != ConfirmedNetUnitPrice)) Action = OrderResponseItemAction.CHANGED;
        else
            Action = OrderResponseItemAction.ACCEPTED;
        
        Console.WriteLine($"Result: {Action}");
    }
}