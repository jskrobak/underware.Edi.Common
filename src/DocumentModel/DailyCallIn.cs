namespace underware.Edi.Common.DocumentModel;

public class DailyCallIn: BaseDocument
{
    public string CustomerNumber { get; set; }
    public string SupplierNumber { get; set; }
    public string TransmissionNumberOld { get; set; }
    public string TransmissionNumberNew { get; set; }
    public DateTime TransmissionDate { get; set; }
    
    public Party Customer { get; set; }
    public Party Supplier { get; set; }
    public Party DeliveryPlace { get; set; }
    
    public DateTime IssueDate { get; set; }

    public List<DailyCallInItem> Items { get; set; } = [];
    public string BillNo { get; set; }
    public string ReceivingLocation { get; set; }
}