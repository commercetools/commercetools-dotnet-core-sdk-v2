using System.Collections.Generic;

namespace commercetools.Api.Models.Products
{
    public class NestedAttribute: Attribute, GenericAttribute<List<IAttribute>>
    {
        public List<IAttribute> GetValue() => (List<IAttribute>)Value;
    }
}