using System;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTailorings;

namespace commercetools.Sdk.Api.Models.Products
{
    public class LocalizedStringAttribute : Attribute, IGenericAttribute<LocalizedString>, IProductTailoringAttribute
    {
        public Type GetValueType() => typeof(LocalizedString);

        public LocalizedString GetValue() => (LocalizedString)Value;
    }
}