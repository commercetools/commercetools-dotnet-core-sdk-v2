using commercetools.Api.Models.ProductTypes;

namespace commercetools.Api.Models.Products
{
    public class PlainEnumAttribute : Attribute, GenericAttribute<IAttributePlainEnumValue>
    {
        public IAttributePlainEnumValue GetValue() => (IAttributePlainEnumValue)Value;
    }
}