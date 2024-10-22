namespace underware.Edi.Common.DocumentModel;

public class Invoice: BaseDocument
{
    public string InvoiceType { get; set;}
    public DateTime FulfillmentDate { get; set;}
    public DateTime? DeliveryDate { get; set;}
    public DocumentReference PurchaseOrder { get; set;}
    public DocumentReference DespatchAdvice { get; set;}
    public DocumentReference RefInvoice { get;set; }
    
    public DocumentReference Contract { get;set; }
    public PaymentRules PaymentRules { get;set; }
    
    public string Currency { get; set; }
    public IEnumerable<InvoiceItem> Items { get; set; }
    public IList<Tax> Taxes { get; set; }
    public decimal Round { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TotalAmountIncVAT { get; set; }
    public DocumentReference SalesOrder { get; set; }
    public decimal ToPay { get; set; }
    
}