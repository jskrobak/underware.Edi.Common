namespace underware.Edi.Common.DocumentModel;

public abstract class BaseDocumentItem
{
    public string LineNo { get; set; }
    public string Name { get; set; }
    public string GTIN { get; set; }
    public string SupplierItemCode { get; set; }
    public string CustomerItemCode { get; set; }
    //public decimal Qty { get; set; }
    public string Unit { get; set; }
    
    /// <summary>
    /// Z/O (Zboží / Obal)
    /// </summary>
    public string ItemType { get; set; }
    public decimal? PcePerUnitQty { get; set; }
    public DateTime DeliveryDate { get; set; }
    
    public IEnumerable<TextNote> Texts { get; set; } = [];
}