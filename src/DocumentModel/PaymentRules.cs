namespace underware.Edi.Common.DocumentModel;

public class PaymentRules
{
    public DateTime DueDate { get; set; }
    public string BankCode { get; set; }    
    public string BankAccountNo { get; set; }
    public string VariableSymbol { get; set; }
    public string ConstantSymbol { get; set; }
    public string SpecificSymbol { get; set; }
    public string IBAN { get; set; }
    public string SWIFT { get; set; }
    public string PaymentType { get; set; }
}