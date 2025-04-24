using System.Globalization;
using System.Text;
using System.Xml.Linq;

namespace underware.Edi.Common;

public static class Extensions
{
    
    public static string DistillNumbers(this string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        var result = new StringBuilder();

        foreach (var c in input.Where(char.IsDigit))
        {
            result.Append(c);
        }

        return result.ToString();
    }
    
    public static string[] SplitToChunks(this string text, int chunkSize, int chunks)
    {
        var parts = new string[chunks];
        var textPos = 0;
        var part = 0;

        if (string.IsNullOrEmpty(text))
            return parts;
            
        while (textPos < text.Length && part < parts.Length)
        {
            var len = (textPos + chunkSize >= text.Length) ? text.Length - textPos : chunkSize;

            parts[part] = text.Substring(textPos, len);
            textPos += chunkSize;
            part += 1;
        }

        return parts;
    }
    
    public static DateTime GetDate(this XElement element)
    {
        return DateTime.TryParse(element?.Value, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date) ? date : DateTime.MinValue;
    }
    
    public static int GetInt(this XElement element)
    {
        return int.Parse(element?.Value);
    }
    
    public static decimal GetDecimal(this XElement element)
    {
        return decimal.TryParse(element?.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out var value) ? value : 0;
    }
}