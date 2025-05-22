namespace underware.Edi.Common.DocumentModel;

public class DeliveryForecastItem
{
    public string PartNumber { get; set; }
    public string PlaceOfDischarge { get; set; }
    public string PlaceOfDelivery { get; set; }
    public string OrderNo { get; set; }
    public string DeliveryScheduleNumberNew { get; set; }
    public string DeliveryScheduleNumberOld { get; set; }
    public DateTime? DeliveryScheduleDateNew { get; set; }
    public DateTime? DeliveryScheduleDateOld { get; set; }
    public string MostRecentArrivalOfGoodsDate { get; set; }
    public string LastReceivedDeliveryNoteNo { get; set; }
    public DateTime? LastReceivedDeliveryNoteDate { get; set; }
    public string MostRecentArrivalOfGoods { get; set; }

    public decimal? BackorderQty { get; set; }
    public decimal? CumulativeQtyReceived { get; set; }
    public decimal? LastReceivedQty { get; set; }

    public List<Delivery> Deliveries { get; set; } = [];
    public DateTime? CalculationDate { get; set; }
}