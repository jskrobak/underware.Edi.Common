namespace underware.Edi.Common.DocumentModel;

public class Delivery
{
    public DateTime Date { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal Qty { get; set; }
    public SpecialDateMeaning SpecialMeaning { get; set; } = SpecialDateMeaning.None;

    public int Year { get; set; }
    public IntervalType Interval { get; set; } = IntervalType.Day;
    public int IntervalNumber { get; set; }
    
    public static DateTime GetFirstDayOfWeek(int year, int week)
    {
        // ISO 8601 weeks: Week 1 is the week with the first Thursday of the year
        var jan4 = new DateTime(year, 1, 4);
        var daysOffset = DayOfWeek.Thursday - jan4.DayOfWeek;

        var firstThursday = jan4.AddDays(daysOffset);
        var cal = System.Globalization.CultureInfo.InvariantCulture.Calendar;

        // ISO 8601 week 1
        var firstWeek = cal.GetWeekOfYear(firstThursday, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

        // Start of the ISO week
        var result = firstThursday.AddDays((week - 1) * 7);

        // Move back to Monday
        return result.AddDays(-3);
    }
}

public enum IntervalType
{
    None = 0,   
    Day = 1,
    Week = 2,
    Month = 3 
}

public enum SpecialDateMeaning
{
    None,
    EndOfCallOff, //000000
    NoRequirement, //222222
    Backlog, //33333
    Immediate, // 444444
    SwitchToWeeklyMonthly, // 55555
    Remaining, // 999999
    
}