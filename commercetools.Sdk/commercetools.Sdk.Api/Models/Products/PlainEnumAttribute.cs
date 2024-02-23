using System;
using commercetools.Sdk.Api.Models.ProductTypes;

namespace commercetools.Sdk.Api.Models.Products
{
    public class PlainEnumAttribute : Attribute, IGenericAttribute<IAttributePlainEnumValue>
    {
        public Type GetValueType() => typeof(IAttributePlainEnumValue);

        public IAttributePlainEnumValue GetValue() => (IAttributePlainEnumValue)Value;
    }
}