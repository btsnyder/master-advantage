using System.Reflection;

namespace MasterAdvantage.Shared
{
    public class Helpers
    {
        public static T? GetPropertyByName<T>(object obj, string propertyName)
        {
            PropertyInfo? property = obj.GetType().GetProperty(propertyName);
            object? val = property?.GetValue(obj);
            if (val == null)
            {
                return default;
            }
            object? converted = Convert.ChangeType(val, typeof(T));
            return (T)converted;
        }

        public static void SetProperty<T>(object obj, string propertyName, T val)
        {
            PropertyInfo? property = obj.GetType().GetProperty(propertyName);
            property?.SetValue(obj, val);
        }
    }
}
