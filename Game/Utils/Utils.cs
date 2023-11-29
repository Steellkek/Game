using System.ComponentModel;
using System.Reflection;

namespace Program;

public class Utils
{
    public static List<T> GetEnumList<T>()
    {
        return ((T[])Enum.GetValues(typeof(T))).ToList();
    }
    
    public static string DescriptionAttr<T>(T source)
    {
        FieldInfo fi = source.GetType().GetField(source.ToString());

        DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
            typeof(DescriptionAttribute), false);

        if (attributes != null && attributes.Length > 0) return attributes[0].Description;
        else return source.ToString();
    }
}