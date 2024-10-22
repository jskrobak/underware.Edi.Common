namespace underware.Edi.Common.DocumentModel;

public class DespatchAdviceItem: BaseDocumentItem
{
    public string ItemType { get; set; }
    //public decimal PcePerUnitQty { get; set; }
    public decimal? Price { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal Qty { get; set; }
    public DocumentReference PurchaseOrder { get; set; }
}