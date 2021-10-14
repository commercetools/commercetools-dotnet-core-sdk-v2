using System;
using commercetools.Api.Models.ProductTypes;

namespace commercetools.Api.Models.Products
{
    public class PlainEnumAttribute : Attribute, IGenericAttribute<IAttributePlainEnumValue>
    {
        public Type GetValueType() => typeof(IAttributePlainEnumValue);

        public IAttributePlainEnumValue GetValue() => (IAttributePlainEnumValue)Value;
    }
}