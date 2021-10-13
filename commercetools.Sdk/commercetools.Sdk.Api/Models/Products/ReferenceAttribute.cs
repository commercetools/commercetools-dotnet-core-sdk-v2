using commercetools.Api.Models.Common;

namespace commercetools.Api.Models.Products
{
    public class ReferenceAttribute: Attribute, GenericAttribute<IReference>
    {
        public IReference GetValue() => (IReference)Value;
    }
}