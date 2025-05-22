namespace underware.Edi.Common.DocumentModel;

public class Delivery
{
    public DateTime Date { get; set; }
    public decimal Qty { get; set; }
    
    public string SpecialDateCode { get; set; }
}