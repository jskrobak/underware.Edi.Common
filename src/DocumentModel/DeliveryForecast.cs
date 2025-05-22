namespace underware.Edi.Common.DocumentModel;

public class DeliveryForecast: BaseBillDocument
{
    public List<DeliveryForecastItem> Items { get; set; } = [];
}