using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Models.Products;

namespace commercetools.Api.Serialization.Tests
{
    public static class Extensions
    {
        public static object Get(this List<IAttribute> attributes, string name)
        {
            return attributes.FirstOrDefault(a => a.Name.Equals(name))?.Value;
        }
        
        public static T GetAttribute<T>(this List<IAttribute> attributes, string name)
        {
            return (T) attributes.FirstOrDefault(a => a.Name.Equals(name));
        }
    }
}