namespace underware.Edi.Common.DocumentModel;

public class Delivery
{
    public DateTime Date { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal Qty { get; set; }
    
    public SpecialDateMeaning SpecialMeaning { get; set; } = SpecialDateMeaning.None;
}

public enum SpecialDateMeaning
{
    None,
    AndOfCallOff, //000000
    NoRequirement, //222222
    Backlog, //33333
    Immediate, // 444444
    SwitchToWeeklyMonthly, // 55555
    Remaining, // 999999
    
}