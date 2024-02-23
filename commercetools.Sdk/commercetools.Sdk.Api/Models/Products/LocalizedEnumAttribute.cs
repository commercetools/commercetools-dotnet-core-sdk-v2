using System;
using commercetools.Sdk.Api.Models.ProductTypes;

namespace commercetools.Sdk.Api.Models.Products
{
    public class LocalizedEnumAttribute : Attribute, IGenericAttribute<IAttributeLocalizedEnumValue>
    {
        public Type GetValueType() => typeof(IAttributeLocalizedEnumValue);

        public IAttributeLocalizedEnumValue GetValue() => (IAttributeLocalizedEnumValue)Value;
    }
}