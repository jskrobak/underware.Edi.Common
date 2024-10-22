namespace underware.Edi.Common.DocumentModel;

public class Tax
{
    public string TaxType { get; set; }
    public string Code { get; set; }
    public decimal Rate { get; set; }
    public decimal Amount { get; set; }
    public decimal Basis { get; set; }
}