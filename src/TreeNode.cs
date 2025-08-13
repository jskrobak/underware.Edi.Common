using System.Collections;

namespace underware.Edi.Common;

public class TreeNode
{
    public string Name { get; set; }
    public string? Value { get; set; }
    public List<TreeNode> Children { get; set; } = [];
    
    public static TreeNode Build(string name, object? obj)
    {
        if(obj is IEnumerable and not string)
            throw new ArgumentException("Object cannot be an IEnumerable unless it is a string.", nameof(obj));
                
        Console.WriteLine($"Build: {name}({obj})");
        
        var node = new TreeNode { Name = name };

        if (obj is null)
            return node;

        
        if (obj is Type t)
        {
            node.Value = t.FullName ?? t.Name;
            return node;
        }
        
        var type = obj.GetType();

        // Simple value → store text only
        if (IsSimpleType(type))
        {
            node.Value = obj.ToString();
            return node;
        }

        // Complex object → iterate properties
        foreach (var prop in type.GetProperties())
        {
            object? value;
            try
            {
                value = prop.GetValue(obj);
            }
            catch
            {
                value = "⚠️ Error reading property";
            }

            if (value is IEnumerable and not string)
                continue;
            
            node.Children.Add(Build(prop.Name, value));
        }

        return node;
    }
    
    private static bool IsSimpleType(Type type)
    {
        if (type.IsPrimitive) return true;
        if (type.IsEnum) return true;
        if (type == typeof(string)) return true;
        if (type == typeof(decimal)) return true;
        if (type == typeof(DateTime) || type == typeof(DateTimeOffset)) return true;
        if (type == typeof(TimeSpan)) return true;
        if (type == typeof(Guid)) return true;

        // Nullable<T>
        if (Nullable.GetUnderlyingType(type) is Type underlyingType)
            return IsSimpleType(underlyingType);

        return false;
    }
}
