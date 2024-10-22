namespace underware.Edi.Common.DocumentModel;

public class OrderResponseItem: OrderItem
{
    public decimal ConfirmedQty { get; set; }
    public DateTime ConfirmedDeliveryDate { get; set; }
    public decimal? ConfirmedNetUnitPrice { get; set; }  
    
    public int GetActionCode()
    {
        if (ConfirmedQty == 0) return 7;
        if (ConfirmedQty != Qty) return 3;
        if (DeliveryDate != ConfirmedDeliveryDate) return 3;
        if (NetUnitPrice.HasValue && ConfirmedNetUnitPrice.HasValue && NetUnitPrice != ConfirmedNetUnitPrice) return 5;
            
        return 5;
    }
}