using System;
using commercetools.Sdk.Api.Models.ProductTailorings;
using commercetools.Sdk.Api.Models.ProductTypes;

namespace commercetools.Sdk.Api.Models.Products
{
    public class LocalizedEnumAttribute : Attribute, IGenericAttribute<IAttributeLocalizedEnumValue>, IProductTailoringAttribute
    {
        public Type GetValueType() => typeof(IAttributeLocalizedEnumValue);

        public IAttributeLocalizedEnumValue GetValue() => (IAttributeLocalizedEnumValue)Value;
    }
}