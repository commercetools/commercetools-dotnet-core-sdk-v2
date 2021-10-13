using System.Collections.Generic;

namespace commercetools.Api.Models.Products
{
    public class SetAttribute<T>: Attribute, GenericAttribute<List<T>>
    {
        public List<T> GetValue() => (List<T>)Value;
    }
}