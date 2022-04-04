using System;
using commercetools.Sdk.Api.Models.Common;

namespace commercetools.Sdk.Api.Models.Products
{
    public class LocalizedStringAttribute : Attribute, IGenericAttribute<LocalizedString>
    {
        public Type GetValueType() => typeof(LocalizedString);

        public LocalizedString GetValue() => (LocalizedString)Value;
    }
}