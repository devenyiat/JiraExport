using System.Collections.Generic;
using System.Reflection;

namespace JiraExport.Extensions
{
    public static class ObjectExtensions
    {
        public static IDictionary<string, string> ToDictionary(this object data)
        {
            BindingFlags publicAttributes = BindingFlags.Public | BindingFlags.Instance;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            foreach (PropertyInfo property in data.GetType().GetProperties(publicAttributes))
            {
                if (property.CanRead)
                    dictionary.Add(property.Name, property.GetValue(data, null).ToString());
            }

            return dictionary;
        }
    }
}