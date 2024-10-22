namespace underware.Edi.Common.DocumentModel;

public class InvoiceItem: BaseDocumentItem
{
    public string ItemType { get; set; }
    public decimal Qty { get; set; }
    public decimal Price { get; set; }
    public decimal? UnitPriceGross { get; set; }
    public decimal UnitPriceNet { get; set; }
    public decimal VATRate { get; set; }
    public DocumentReference PurchaseOrder { get; set; }
    
    public DocumentReference DespatchAdvice { get; set;}
    public DocumentReference RefInvoice { get; set;}
    public Party DeliveryPlace { get; set; }
    public DocumentReference SalesOrder { get; set; }
    public decimal EcoTaxPerUnit { get; set; }
    public decimal VATAmount { get; set; }
    
}