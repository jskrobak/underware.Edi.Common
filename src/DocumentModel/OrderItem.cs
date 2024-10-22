namespace underware.Edi.Common.DocumentModel;

public class OrderItem: BaseDocumentItem
{
    public decimal? NetUnitPrice { get; set; }
    public decimal Qty { get; set; }
}