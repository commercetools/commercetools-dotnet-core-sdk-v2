using System;
using commercetools.Api.Models.ProductTypes;

namespace commercetools.Api.Models.Products
{
    public class LocalizedEnumAttribute : Attribute, IGenericAttribute<IAttributeLocalizedEnumValue>
    {
        public Type GetValueType() => typeof(IAttributeLocalizedEnumValue);

        public IAttributeLocalizedEnumValue GetValue() => (IAttributeLocalizedEnumValue)Value;
    }
}