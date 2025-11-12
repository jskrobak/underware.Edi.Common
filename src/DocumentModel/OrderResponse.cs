namespace underware.Edi.Common.DocumentModel;

public class OrderResponse: BaseBillDocument
{
    public DateTime DeliveryDate { get; set; }
    public DocumentReference PurchaseOrder { get; set; }
    public OrderResponseAction Action { get; set; }
    public IList<OrderResponseItem> Items { get; set; }

    public void RecalculateAction()
    {
        if (Items.All(x => x.Action == OrderResponseItemAction.REJECTED))
            Action = OrderResponseAction.REJECTED;
        else if(Items.All(x => x.Action == OrderResponseItemAction.ACCEPTED))
            Action = OrderResponseAction.ACCEPTED;
        else 
            Action = OrderResponseAction.CHANGED;
    }
}