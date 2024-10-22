namespace underware.Edi.Common.DocumentModel;

public  abstract class BaseDocument
{
    public  string BillNo { get; set; }
    public  string MessageFunction { get; set; }
    public  DateTime IssueDate { get; set; }
    public  Party Customer { get; set; }
    public  Party Supplier { get; set; }
    public  Party DeliveryPlace { get; set; }
    public  Party InvoicePlace { get; set; }
    public  Party DispatchPlace { get; set; }
    
    public  Party UltimateCustomer { get; set; }

    public IEnumerable<Party> AllParties { get; set; } = [];

    public IEnumerable<TextNote> Texts { get; set; } = [];
}