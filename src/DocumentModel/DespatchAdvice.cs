namespace underware.Edi.Common.DocumentModel;

public class DespatchAdvice: BaseBillDocument
{
    public DateTime? DeliveryDate { get; set; }
    public DateTime? DispatchDate { get; set; }
    public string DispatchNumber { get; set; }
    
    public string WeightUnit { get; set; }
    
    public decimal? GrossWeight { get; set; }
    
    public string AgreementNumber { get; set; }
    
    public  Party Carrier { get; set; }
    
    public DocumentReference PurchaseOrder { get; set; }
    public IEnumerable<DespatchAdviceItem> Items { get; set; }
    public string Plant { get; set; }
    public string UnloadingPoint { get; set; }
    public string MeansOfTransportNo { get; set; }
}