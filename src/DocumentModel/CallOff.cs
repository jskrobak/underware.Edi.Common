namespace underware.Edi.Common.DocumentModel;

public class CallOff : BaseDocument
{
    public string CustomerNumber { get; set; }
    public string SupplierNumber { get; set; }
    public string TransmissionNumberOld { get; set; }
    public string TransmissionNumberNew { get; set; }
    public DateTime TransmissionDate { get; set; }

    public string CustomerPlant { get; set; }
    public string PlaceOfDischarge { get; set; }
    public string PlaceOfDelivery { get; set; }

    public string CallOffNumberNew { get; set; }
    public string CallOffNumberOld { get; set; }

    public DateTime CallOffDateNew { get; set; }
    public DateTime CallOffDateOld { get; set; }
    
    public string ContractOrOrderNumber { get; set; }
    public string CustomerReference { get; set; }
    
    public string PartNumberCustomer { get; set; }
    public string PartNumberSupplier { get; set; }

    

    public string LastReceivedDeliveryNoteNo { get; set; }
    public DateTime? LastReceivedDeliveryNoteDate { get; set; }
    
    public decimal? LastReceiptQty { get; set; } 

    //public decimal CumulativeQtyReceived { get; set; }
    //public decimal MostRecentArrivalOfGoods { get; set; }
    //public DateTime MostRecentArrivalOfGoodsDate { get; set; }

    public decimal? BackorderQty { get; set; }
    public decimal? ImmediateNeedQty { get; set; }
    
    public List<Delivery> Deliveries { get; set; } = new List<Delivery>();
}