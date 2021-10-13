using commercetools.Api.Models.ProductTypes;

namespace commercetools.Api.Models.Products
{
    public class LocalizedEnumAttribute : Attribute, GenericAttribute<IAttributeLocalizedEnumValue>
    {
        public IAttributeLocalizedEnumValue GetValue() => (IAttributeLocalizedEnumValue)Value;
    }
}