using System;
using commercetools.Sdk.Api.Models.ProductTailorings;

namespace commercetools.Sdk.Api.Models.Products
{
    public class StringAttribute : Attribute, IGenericAttribute<string>, IProductTailoringAttribute
    {
        public Type GetValueType() => typeof(string);

        public string GetValue() => (string)Value;
    }
}