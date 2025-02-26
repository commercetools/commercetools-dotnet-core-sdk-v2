using System;
using commercetools.Sdk.Api.Models.ProductTailorings;

namespace commercetools.Sdk.Api.Models.Products
{
    public class BooleanAttribute : Attribute, IGenericAttribute<bool>, IProductTailoringAttribute
    {
        public Type GetValueType() => typeof(bool);

        public bool GetValue() => (bool)Value;
    }
}