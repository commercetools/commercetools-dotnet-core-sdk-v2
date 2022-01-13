using System;
using commercetools.Api.Models.Common;

namespace commercetools.Api.Models.Products
{
    public class LocalizedStringAttribute : Attribute, IGenericAttribute<LocalizedString>
    {
        public Type GetValueType() => typeof(LocalizedString);

        public LocalizedString GetValue() => (LocalizedString)Value;
    }
}